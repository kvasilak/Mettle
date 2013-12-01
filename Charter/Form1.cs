//Charter, an embedded software analysis tool
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
namespace Charter
{
    public partial class FormMain : Form
    {
        string RxString;

        public event TagHandeler TagEvent;
        public delegate void TagHandeler(TagEvent e);
 
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
                if (c.Name != "tabSetup")
                {
                    foreach (Control d in c.Controls)
                    {
                        //todo check for containers
                        //we might be in one

                        //Todo, is there a more generic way to determine if a control
                        //supoorts the tag event?

                        //determine if the control is one of our custom ones,
                        //if it is add it to the tag event list
                        if (d.GetType() == typeof(TagText))
                        {
                            TagEvent += new TagHandeler( ((TagText)d).UpdateEvent);
                        }

                        if (d.GetType() == typeof(TagGauge))
                        {
                            TagEvent += new TagHandeler(((TagGauge)d).UpdateEvent);
                        }

                        if (d.GetType() == typeof(TagState ))
                        {
                            TagEvent += new TagHandeler(((TagState)d).UpdateEvent);
                        }


                        if (d.GetType() == typeof(TagIO))
                        {
                            TagEvent += new TagHandeler(((TagIO)d).UpdateEvent);
                        }


                        if (d.GetType() == typeof(TagChart))
                        {
                            TagEvent += new TagHandeler(((TagChart)d).UpdateEvent);
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
                    serialPort1.RtsEnable = true;
                    serialPort1.Encoding = Encoding.GetEncoding(28591); //So I can read all 8 bits from the stupid serial port
                    serialPort1.Open();
                    serialPort1.DiscardInBuffer();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Serial port; " + ex.Message, "Error!");
                }
            }
        }

        //we have recieved serial data, get a line of it and send it to the parser
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                try
                {
                    //if (Form1 != null && !this.IsDisposed)
                    //{
                        String tmpstr = serialPort1.ReadLine();

                        RxString = tmpstr;

                        this.Invoke(new EventHandler(HandleMesage));
                   // }
                }
                catch (Exception ex)
                {
                    //MessageBox.Show("Serial handeler; " + ex.Message, "Error!");
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
                        //set the tag recieved event
                        TagEvent t = new TagEvent();

                        //split the tag and cleanup any whitespace
                        t.Name = instr.Substring(start + 1, comma - (start + 1)).Trim();
                        t.Data = instr.Substring(comma + 1, end - (comma + 1)).Trim();

                        //see if there is a number in the data
                        if (int.TryParse(t.Data, out d))
                        {
                            t.Value = d;
                            t.ValueValid = true;

                        }

                        //make sure someone is listening
                        if(null != TagEvent)
                            TagEvent(t);
                    }
                }
            }
            return end;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            SafeSerialClose();
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
            MessageBox.Show("Serial port error; " + e.ToString());
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

    }
}
