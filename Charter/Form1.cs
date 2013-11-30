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

namespace Charter
{
    public partial class Form1 : Form
    {
        string RxString;

        public event TagHandeler TagEvent;
        public delegate void TagHandeler(EventTag e);
 
        public Form1()
        {
            InitializeComponent();

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Control c in tabMain.Controls)
            {
                if (c.Name != "tabSetup")
                {
                    foreach (Control d in c.Controls)
                    {
                        //todo check for containers
                        //we might be in one
                        if (d.GetType() == typeof(TagText))
                        {
                            TagEvent += new TagHandeler( ((TagText)d).UpdateEvent);
                        }

                        if (d.GetType() == typeof(AGauge))
                        {
                            TagEvent += new TagHandeler(((AGauge)d).UpdateEvent);
                        }

                        if (d.GetType() == typeof(StateButton ))
                        {
                            TagEvent += new TagHandeler(((StateButton)d).UpdateEvent);
                        }


                        if (d.GetType() == typeof(IOState))
                        {
                            TagEvent += new TagHandeler(((IOState)d).UpdateEvent);
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
                    //SerialPortFixer.Execute(cboComPort.Text);

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

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                try
                {
                    String tmpstr = serialPort1.ReadLine();

                    RxString = tmpstr;
                    this.Invoke(new EventHandler(HandleMesage));
                }
                catch (Exception ex)
                {
                    return;
                }
            }
        }

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
                end = instr.IndexOf("<", /*offset +*/ start + 1);

                if (end > 0)
                {
                    //found start and end, find the comma
                    comma = instr.IndexOf(",", start + 1);

                    if (comma > 0)
                    {
                        //set the tag recieved event
                        EventTag t = new EventTag();

                        t.Name = instr.Substring(start + 1, comma - (start + 1)).Trim();
                        t.Data = instr.Substring(comma + 1, end - (comma + 1)).Trim();

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
