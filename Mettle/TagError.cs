using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Mettle
{
    public partial class TagError : TextBox, ITagErrorInterface
    {
        private const int EM_SETTABSTOPS = 0x00CB;
        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr SendMessage(IntPtr h, int msg, int wParam, int[] lParam);
        private const int TabSize = 4;

        private string m_ModuleName;

        public TagError()
        {
            InitializeComponent();
        }

        #region Interfaces

        void ITagErrorInterface.Reset()
        {
            Clear();
        }

        void ITagErrorInterface.Initialize()
        {
            // define value of the Tab indent 
            int[] stops = { TabSize };
            // change the indent 
            //SendMessage(this.Handle, EM_SETTABSTOPS, 1, stops);
            SendMessage(Handle, EM_SETTABSTOPS, 1, new int[] { TabSize * 4 });
        }

        void ITagErrorInterface.UpdateEvent(string s)
        {
            //if ((ModuleName == null) || (ModuleName == e.ModuleName))
            //{
            //    if (e.Name == base.Tag.ToString())
            //    {
            //        if (base.Multiline)
            //        {
                        AppendText(s + "\r\n");

            //            ScrollToCaret();
            //        }
            //        else
            //        {
            //            base.Text = e.Data;
            //        }
            //    }

            //    if (base.Tag.ToString() == "*")
            //    {
            //        if (base.Multiline)
            //        {
            //            if (e.Name.Length < TabSize)
            //            {
            //                AppendText(e.Name + "\t\t\t\t" + e.Data + "\r\n");
            //            }
            //            else if (e.Name.Length < TabSize * 2)
            //            {
            //                AppendText(e.Name + "\t\t\t" + e.Data + "\r\n");
            //            }
            //            else if (e.Name.Length < TabSize * 3)
            //            {
            //                AppendText(e.Name + "\t\t" + e.Data + "\r\n");
            //            }
            //            else
            //            {
            //                AppendText(e.Name + "\t" + e.Data + "\r\n");
            //            }

            //            ScrollToCaret();
            //        }
            //        else
            //        {
            //            Text = e.Name + "\t\t" + e.Data + "\r\n";
            //        }
            //    }
            //}
        }

        #endregion

        [System.ComponentModel.Browsable(true),
        System.ComponentModel.Category("Mettle"),
        System.ComponentModel.Description("The module name filter. Leave blank to see all module")]
        public string ModuleName
        {
            get
            {
                return m_ModuleName;
            }
            set
            {
                m_ModuleName = value;
            }
        }
    }
}
