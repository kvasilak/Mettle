using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Charter
{
    public partial class TagText : TextBox
    {
        public TagText()
        {
            InitializeComponent();
        }

        public void UpdateEvent(EventTag e)
        {
            if (e.Name == base.Tag.ToString())
            {
                AppendText( e.Data + "\r\n");

                ScrollToCaret();
            }

            if (base.Tag.ToString() == "*")
            {
                AppendText(e.Name + "\t\t" + e.Data + "\r\n");

                ScrollToCaret();
            }
        }
    }
}
