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
                if (base.Multiline)
                {
                    AppendText(e.Data + "\r\n");

                    ScrollToCaret();
                }
                else
                {
                    base.Text = e.Data;
                }
            }

            if (base.Tag.ToString() == "*")
            {
                if (base.Multiline)
                {
                    AppendText(e.Name + "\t\t" + e.Data + "\r\n");

                    ScrollToCaret();
                }
                else
                {
                    Text = e.Name + "\t\t" + e.Data + "\r\n";
                }
            }
        }
    }
}
