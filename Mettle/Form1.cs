//Mettle, an embedded software analysis tool
//Copyright (C) 2013  Keith Vasilakes
//
//This program is free software: you can redistribute it and/or modify
//it under the terms of the GNU General Public License as published by
//the Free Software Foundation, either version 3 of the License, or
//(at your option) any later version.
//
//This program is distributed in the hope that it will be useful,
//but WITHOUT ANY WARRANTY; without even the implied warranty of
//MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//GNU General Public License for more details.
//
//You should have received a copy of the GNU General Public License
//along with this program.  If not, see <http://www.gnu.org/licenses/>.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO.Ports;
using System.Collections;
using System.Diagnostics;
using System.Threading;

//
// This program is designed to recieve tagged data from an embedded device over a serial connection. RS232 or USB
// a tag consists of a name and data. When a tag is recieved, it is ent to all the custom controls on all the tabs
// Each controll then looks at the tag name to decide if they are interested in it. If they are they can get the data and display it
// If a tag contains a valid integer, the integer is available as well as the string representation.
//A tag can use the name and the data or just the name or anything it wants to do with the data when it recieves the event.
//
//To use this program, just drag one of the custom controls onto a tab, set the tag property to what you want it to respond to and 
//set the name for controls like tagstate. All other properties are available for use as a normal program.
//Then run the program and watch the magic!
//
namespace Mettle
{
    public partial class FormMain : Form
    {
        string RxString = string.Empty;

        public event TagHandeler TagEvent;
        public delegate void TagHandeler(TagEvent e);


        public event ErrorHandeler TagErrorEvent;
        public delegate void ErrorHandeler(string s);

        private List<Module>ModuleList = new List<Module>();
        private String RXBuffer = string.Empty; //new StringBuilder();
        private Module SelectedModule = null;

        public FormMain()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Walk through each tab and find all our custom controls
            //then register them for the tag recieved event
            foreach (Control c in tabMain.Controls)
            {
                foreach (Control ctl in c.Controls)
                {
                    //determine if the control is one of our custom ones,
                    //our custom controls all implement ITagInterface
                    if (ctl is ITagInterface)
                    {
                        TagEvent += new TagHandeler( ((ITagInterface)ctl).UpdateEvent);
                        ((ITagInterface)ctl).Initialize();
                    }

                    if (ctl is ITagErrorInterface)
                    {
                        TagErrorEvent += new ErrorHandeler( ((ITagErrorInterface)ctl).UpdateEvent);
                        ((ITagErrorInterface)ctl).Initialize();
                    }

                    //look for and register child controls in containers
                    //such as the panel and groupbox
                    foreach (Control child in ctl.Controls)
                    {
                        if (child is ITagInterface)
                        {
                            Trace.WriteLine(child.Name);

                            TagEvent += new TagHandeler(((ITagInterface)child).UpdateEvent);
                            ((ITagInterface)child).Initialize();
                        }
                    }
                }
            }
        }


        private void btnOK_Click(object sender, EventArgs e)
        {
            OpenSerialPort();
        }

        private void OpenSerialPort()
        {
            if (!serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.PortName = Properties.Settings.Default.COMport;
                    serialPort1.BaudRate = int.Parse(Properties.Settings.Default.BaudRate.ToString());
                    serialPort1.DataBits = 8;
                    serialPort1.Parity = System.IO.Ports.Parity.None;
                    serialPort1.StopBits = System.IO.Ports.StopBits.One;
                    //serialPort1.RtsEnable = true;
                    serialPort1.Encoding = Encoding.GetEncoding(28591); //So I can read all 8 bits from the stupid serial port
                    serialPort1.Open();
                    serialPort1.DiscardInBuffer();

                    stripStatus.Text = "Running";
                    stripError.Text = "No Errors";

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Serial port; " + ex.Message, "Error!");
                    stripError.Text = "Serial open Error; " + ex.Message;
                }
            }
        }

        //we have recieved serial data, get a line of it and send it to the parser
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string temp;

            if (serialPort1.IsOpen)
            {
                int cr;
                try
                {
                    //get rx chars
                    RXBuffer += serialPort1.ReadExisting();
                    
                    //is there a \n?
                    cr = RXBuffer.IndexOf("\n");

                    //there HAS to be at least 1 character to be at all valid;
                    while (cr >= 0)
                    {
                        //copy all data up to \n
                        //as long as there IS data
                        if (cr > 1)
                        {
                            RxString = RXBuffer.Substring(0, cr);

                            //Process the message
                            this.Invoke(new EventHandler(HandleMesage));
                        }

                        //Copy everything after \n back into rx buffer, removing string just sent
                        int len = RXBuffer.Length - (cr + 1);
                        temp = string.Empty;

                        //Anything left to copy?
                        if (len > 0)
                        {
                            temp = RXBuffer.Substring(cr + 1, len);
                        }

                        RXBuffer = temp;

                        //any more \n?
                        cr = RXBuffer.IndexOf("\n");

                    }

                    stripError.Text = "No Errors";
                }
                catch (Exception ex)
                {
                    Type ep = ex.GetType();
                    return;
                }
            }
        }

        //Update the serial output box and call the parser
        private void HandleMesage(object sender, EventArgs e)
        {
            int position = 0;

            txtAllText.AppendText(RxString);
            txtAllText.AppendText("\n");


            do //may have multiple tags per line
            {
                position = ParseTags(RxString, position);
            }
            while ((position >0) && (position < RxString.Length));
        }
        
        //find the next tag and data, set an event to all listeners
        private int ParseTags(string instr, int offset)
        {
            int start;
            int end = instr.Length;
            int comma;
            int comma2;
            int d;

            //Tag format is >string, string<
            start = instr.IndexOf(">", offset);

            if(start >= 0)//May be first character
            {
                end = instr.IndexOf("<", start + 1);

                if (end > 0)
                {
                    //found start and end, find the comma
                    comma = instr.IndexOf(",", start + 1);

                    if (comma > 0)
                    {
                        //find the second comma
                        comma2 = instr.IndexOf(",", comma + 1);

                        if (comma2 > 0)
                        {
                            //set the tag recieved event
                            TagEvent t = new TagEvent();

                            //split the tag and cleanup any whitespace
                            t.ModuleName = instr.Substring(start + 1, comma - (start + 1)).Trim(); //module name
                            t.Name = instr.Substring(comma + 1, comma2 - (comma + 1)).Trim(); //tag name
                            t.Data = instr.Substring(comma2 + 1, end - (comma2 + 1)).Trim(); //data

                            //see if there is a number in the data
                            if (int.TryParse(t.Data, out d))
                            {
                                t.Value = d;
                                t.ValueValid = true;

                            }

                            //make sure someone is listening
                            if (null != TagEvent)
                                TagEvent(t);

                            Uniques(t);

                        }
                        else
                        {
                            if(null != TagErrorEvent)
                                TagErrorEvent(instr.Substring(offset));
                        }
                    }
                    else
                    {
                        if (null != TagErrorEvent)
                            TagErrorEvent(instr.Substring(offset));
                    }
                }
                else
                {
                    if (null != TagErrorEvent)
                        TagErrorEvent(instr.Substring(offset));
                }
            }
            return end+1;
        }

        private void Uniques(TagEvent e)
        {
            bool ModuleNameFound = false;

            //Search to see if tag exists
            foreach (Module m in ModuleList)
            {
                if (m.ModuleName == e.ModuleName)
                {
                    ModuleNameFound = true;

                    //module found, add tag or data if unique
                    m.Uniques(e);
                }
            }

            if (false == ModuleNameFound)
            {
                ModuleList.Add(new Module(e));

                ModuleList.Sort();

                //we have a new tag, redisplay them all
                txtModules.Clear();

                foreach (Module m in ModuleList)
                {
                    txtModules.AppendText(m.ModuleName + "\n");
                }

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            SafeSerialClose();

            stripStatus.Text = "Stopped";
        }


        // close the serial port in a seperate thread to prevent
        //A GUI deadlock
        private void SafeSerialClose()
        {
            Thread myThread = new System.Threading.Thread(delegate()
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.Close();
                }
            });
            myThread.Start();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SafeSerialClose();

            //Wait for serialPort1 port To actually close
            Thread.Sleep(200);
        }

        private void serialPort1_ErrorReceived(object sender, SerialErrorReceivedEventArgs e)
        {
            //MessageBox.Show("Serial port error; " + e.EventType.ToString());

            stripError.Text = "Error!" + e.EventType.ToString();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            OpenSerialPort();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            SafeSerialClose();
        }

        private void btnTools_Click(object sender, EventArgs e)
        {
            dlgSerial SetupDialog = new dlgSerial();

            SetupDialog.StartPosition = FormStartPosition.CenterParent;

            SetupDialog.ShowDialog(this);

        }

        private void textUniques_MouseClick(object sender, MouseEventArgs e)
        {
            txtTagData.Clear();

            int charindex = txtUniques.GetCharIndexFromPosition(e.Location);
            int line = txtUniques.GetLineFromCharIndex(charindex);

            string sx = txtUniques.Lines[line];

            foreach (Tags t in SelectedModule.TagList)
            {
                if (t.Name == sx)
                {
                    if (t.ValueValid)
                    {
                        txtTagData.AppendText("Max; " + t.max + "\n");
                        txtTagData.AppendText("Min; " + t.min + "\n");
                    }
                    else
                    {
                        //Display all data from tag
                        foreach (string s in t.Data)
                        {
                            txtTagData.AppendText(s + "\n");
                        }
                    }
                }
            }
        }

        private void txtModules_MouseClick(object sender, MouseEventArgs e)
        {
            txtUniques.Clear();
            txtTagData.Clear();

            int charindex = txtModules.GetCharIndexFromPosition(e.Location);
            int line = txtModules.GetLineFromCharIndex(charindex);

            string sx = txtModules.Lines[line];

            foreach (Module m in ModuleList)
            {
                if (m.ModuleName == sx)
                {
                    SelectedModule = m;

                    foreach (Tags t in m.TagList)
                    {
                        txtUniques.AppendText(t.Name + "\n");
                    }
                }
            }
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Embedded Monitoring Tool; V1.0\nCopyright 2013 Keith Vasilakes\n\nLicensed under GPL\nhttp://www.gnu.org/licenses", "Embedded Monitor");
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            txtAllText.Clear();

            foreach (Control c in tabMain.Controls)
            {
                foreach (Control ctl in c.Controls)
                {
                    //determine if the control is one of our custom ones,
                    //our custom controls all implement ITagInterface
                    if (ctl is ITagInterface)
                    {
                        ((ITagInterface)ctl).Reset();
                    }

                    if (ctl is ITagErrorInterface)
                    {
                        ((ITagErrorInterface)ctl).Reset();
                    }

                    //look for and register child controls in containers
                    //such as the panel and groupbox
                    foreach (Control child in ctl.Controls)
                    {
                        if (child is ITagInterface)
                        {
                            ((ITagInterface)child).Reset();
                        }

                        if (child is ITagErrorInterface)
                        {
                            ((ITagErrorInterface)child).Reset();
                        }
                    }
                }
            }
        }
    }
}
