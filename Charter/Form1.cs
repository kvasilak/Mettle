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

namespace Charter
{
    public partial class Form1 : Form
    {
        string RxString;
        RollingPointPairList list = new RollingPointPairList(1000);
        RollingPointPairList list1 = new RollingPointPairList(1000);

        double x, y1, y2;
        int i;

        public Form1()
        {
            InitializeComponent();

            txtData.Text = "This is a test";
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
            //String tmpstr = serialPort1.ReadExisting();
            String tmpstr = serialPort1.ReadLine();

            RxString = tmpstr;
            this.Invoke(new EventHandler(HandleMesage));
        }

        private void HandleMesage(object sender, EventArgs e)
        {
            int a=0;
            int b = 0;

            char[] delimiterChars = { ' ', ',', '.', ':' };

            //need to build clean null terminated string
            //and strip off \n

            txtData.AppendText(RxString);
            txtData.AppendText("\n");

            if (RxString.Length > 0)
            {
                string[] columns = RxString.Split(delimiterChars);

                if (int.TryParse(columns[0], out a))
                {
                    list.Add(i, a);
                }

                if (int.TryParse(columns[1], out b))
                {
                    list1.Add(i, b);
                }

                zedGraphControl1.AxisChange();
                zedGraphControl1.Invalidate();

                i++;

                // Keep the X scale at a rolling  interval, with one
                // major step between the max X value and the end of the axis
                Scale xScale = zedGraphControl1.GraphPane.XAxis.Scale;

                if (i > xScale.Max - xScale.MajorStep)
                {
                    xScale.Max = i + xScale.MajorStep;
                    xScale.Min = xScale.Max - 1000.0;
                }
            }
        }



        private void btnClose_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen) serialPort1.Close();
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
            zedGraphControl1.Size = new Size(ClientRectangle.Width - 40, ClientRectangle.Height - 40);
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

            zedGraphControl1.GraphPane.XAxis.Scale.MinorStep = 10;
            zedGraphControl1.GraphPane.XAxis.Scale.MajorStep = 50;
            zedGraphControl1.AxisChange();

            // Generate a red curve with diamond
            // symbols, and "Porsche" in the legend
            LineItem myCurve = myPane.AddCurve("", list, Color.Red, SymbolType.None);
                
            // Generate a blue curve with circle
            // symbols, and "Piper" in the legend
            LineItem myCurve2 = myPane.AddCurve("", list1, Color.Blue, SymbolType.None);

            // Tell ZedGraph to refigure the
            // axes since the data have changed
            zgc.AxisChange();
        }
    }
}
