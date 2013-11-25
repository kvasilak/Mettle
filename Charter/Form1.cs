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
using ZedGraph;
using System.Diagnostics;


namespace Charter
{

    public partial class Form1 : Form
    {
        string RxString;
        RollingPointPairList list = new RollingPointPairList(1000);
        RollingPointPairList list1 = new RollingPointPairList(1000);

        int li;
        int ri;

        public event TagHandeler TagEvent;
        public delegate void TagHandeler(Form1 f, EventTag e);

 
        public Form1()
        {
            InitializeComponent();

        }

        //show serial connect dialog
        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        
        //Connect or disconnect the serial port
        private void chkConnect_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboComPort.Items.Clear();

            ArrayList items = new ArrayList();
            items.AddRange(System.IO.Ports.SerialPort.GetPortNames());
            items.Sort();
            cboComPort.Items.AddRange(items.ToArray());

            cboComPort.SelectedText = Properties.Settings.Default.COMport;

            cboBaudRate.SelectedIndex = 1;

            // Setup the graph
            CreateGraph(zedGraphControl1);
            // Size the control to fill the form with a margin
            SetSize();

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)
            {
                try
                {
                    //SerialPortFixer.Execute(cboComPort.Text);
                    
                    serialPort1.PortName = cboComPort.Text;
                    serialPort1.BaudRate = int.Parse(cboBaudRate.Text);
                    serialPort1.DataBits = 8;
                    serialPort1.Parity = System.IO.Ports.Parity.None;
                    serialPort1.StopBits = System.IO.Ports.StopBits.One;
                    //serialPort1.RtsEnable = true;
                    serialPort1.Encoding = Encoding.GetEncoding(28591); //So I can read all 8 bits from the stupid serial port
                    serialPort1.Open();
                    serialPort1.DiscardInBuffer();

                    Properties.Settings.Default.COMport = cboComPort.Text;
                    Properties.Settings.Default.BaudRate = UInt32.Parse(cboBaudRate.Text);
                    Properties.Settings.Default.Save();

                    foreach (Control c in this.Controls)
                    {
                        c.Enabled = true; ;
                    }
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
            //int a=0;
            //int b = 0;
            int position = 0;

            do //may have multiple tags per line
            {
                position = ParseTags(RxString, position);
            }
            while ((position >0) && (position < RxString.Length));


            txtData.AppendText(RxString);
            txtData.AppendText("\n");


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
                end = instr.IndexOf("<", offset + start + 1);

                if (end > 0)
                {
                    //found start and end, find the comma
                    comma = instr.IndexOf(",", start + 1);

                    if (comma > 0)
                    {
                        //set the tag recieved event
                        EventTag t = new EventTag();

                        t.Name = instr.Substring(start + 1, comma - (start + 1));
                        t.Data = instr.Substring(comma + 1, end - (comma + 1));

                        //textTags.AppendText(t.Name + "; " + t.Data + "\n");


                        if (int.TryParse(t.Data, out d))
                        {
                            t.Value = d;
                            t.ValueValid = true;

                        }

                        //make sure someone is listening
                        if(null != TagEvent)
                            TagEvent(this, t);
                    }
                }
            }
            return end;
        }

        private void UpdateGraph(Form1 f, EventTag e) //(string chan, int d)
        {
            if (e.Name == "Left")
            {
                list.Add(li, e.Value);

                aGauge3.Value = e.Value-50;
            }
            else if (e.Name == "Right")
            {
                list1.Add(ri, e.Value);

                aGauge5.Value = e.Value-50;
            }

            li++;
            ri++;

            // Keep the X scale at a rolling  interval, with one
            // major step between the max X value and the end of the axis
            Scale xScale = zedGraphControl1.GraphPane.XAxis.Scale;

            if (li > xScale.Max - xScale.MajorStep)
            {
                xScale.Max = li + xScale.MajorStep;
                xScale.Min = xScale.Max - 1000;
            }

            zedGraphControl1.AxisChange();
            zedGraphControl1.Invalidate();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            SafeSerialClose();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            SetSize();
        }

        // SetSize() is separate from Resize() so we can 
        // call it independently from the Form1_Load() method
        // This leaves a 10 px margin around the outside of the control
        // Customize this to fit your needs
        private void SetSize()
        {
            zedGraphControl1.Location = new Point(10, 10);

            // Leave a small margin around the outside of the control
            zedGraphControl1.Size = new Size(splitContainer1.Panel2.Width-10, (splitContainer1.Panel2.Height - splitContainer1.SplitterDistance)+40);
            //zedGraphControl1.Size = new Size(ClientRectangle.Width - 40, ClientRectangle.Height - 40);
        }

        // Build the Chart
        private void CreateGraph(ZedGraphControl zgc)
        {
            // get a reference to the GraphPane
            GraphPane myPane = zgc.GraphPane;

            // Set the Titles
            myPane.Title.Text = "Test Graph";
            myPane.XAxis.Title.Text = "Sample";
            myPane.YAxis.Title.Text = "Height";


            zedGraphControl1.GraphPane.YAxis.Scale.Min = 0;
            zedGraphControl1.GraphPane.YAxis.Scale.Max = 110;

            zedGraphControl1.GraphPane.XAxis.Scale.Min = 0;
            zedGraphControl1.GraphPane.XAxis.Scale.Max = 1000;

            zedGraphControl1.GraphPane.XAxis.Scale.MinorStep = 2;
            zedGraphControl1.GraphPane.XAxis.Scale.MajorStep = 10;
            zedGraphControl1.AxisChange();

            // Generate a red curve with diamond
            LineItem myCurve = myPane.AddCurve("", list, Color.Red, SymbolType.None);
                
            // Generate a blue curve with circle
            LineItem myCurve2 = myPane.AddCurve("", list1, Color.Blue, SymbolType.None);

            // Tell ZedGraph to refigure the
            // axes since the data have changed
            zgc.AxisChange();

            TagEvent += new TagHandeler(UpdateGraph);
        }

        //TODO, close the serial port in a seperate thread to prevent
        //A GUI deadlock
        private void SafeSerialClose()
        {
            if (serialPort1.IsOpen)
            {
                
                serialPort1.Close();

            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SafeSerialClose();
        }

        private void serialPort1_ErrorReceived(object sender, SerialErrorReceivedEventArgs e)
        {
            MessageBox.Show("Serial port error; " + e.ToString());
        }
    }
}
