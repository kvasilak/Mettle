using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace Charter
{
    public partial class dlgSerial : Form
    {
        public dlgSerial()
        {
            InitializeComponent();

            cboBaud.SelectedIndex = 1;
        }

        private void cboPort_DropDown(object sender, EventArgs e)
        {
            cboPort.Items.Clear();

            ArrayList items = new ArrayList();
            items.AddRange(System.IO.Ports.SerialPort.GetPortNames());
            items.Sort();
            cboPort.Items.AddRange(items.ToArray());
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.COMport = cboPort.Text;
            Properties.Settings.Default.BaudRate = UInt32.Parse(cboBaud.Text);
            Properties.Settings.Default.Save();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void dlgSerial_Load(object sender, EventArgs e)
        {
            cboPort.Items.Clear();

            ArrayList items = new ArrayList();
            items.AddRange(System.IO.Ports.SerialPort.GetPortNames());
            items.Sort();
            cboPort.Items.AddRange(items.ToArray());

            cboPort.SelectedText = Properties.Settings.Default.COMport;
        }
    }
}
