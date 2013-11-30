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
    public partial class TagState : Control
    {
        public TagState()
        {
            InitializeComponent();
        }

        public void UpdateEvent(TagEvent e)
        {
            if (e.Name == base.Tag.ToString())
            {
                if (e.Data == base.Text)
                    Checked = true;
                else
                    Checked = false;
            }

        }

        private void StateButton_Load(object sender, EventArgs e)
        {

        }

        public new string Text
        {
            get { return base.Text; }

            set
            {
                if (value == base.Text)
                {
                    return;
                }

                base.Text = value;

                Invalidate();
            }
        }
        private bool _Checked = false;
        public bool Checked
        {
            get { return _Checked; }
            set
            {
                if (value == _Checked)
                    return;

                _Checked = value;

                Invalidate();
            }
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
                Checked = true;
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                Checked = false;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics gfx = e.Graphics;
            Rectangle rc = ClientRectangle;

            rc.Width -= 1;
            rc.Height -= 1;

            gfx.FillRectangle(new SolidBrush(Parent.BackColor), ClientRectangle);

            Color fill;
            if (Checked)
                fill = Color.Blue;
            else
                fill = Color.LightGray;

            gfx.FillEllipse(new SolidBrush(fill), rc);

            gfx.DrawEllipse(new Pen(Color.Blue, 1.0f), rc);

            Font fnt = new Font("Verdana", (float)rc.Height * 0.5f, FontStyle.Bold, GraphicsUnit.Pixel);

            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;
            sf.LineAlignment = StringAlignment.Center;
            gfx.DrawString(Text, fnt, new SolidBrush(Color.Black), new RectangleF((float)rc.Left, (float)rc.Top, (float)rc.Width, (float)rc.Height), sf);

        }

        protected override void OnPaintBackground(PaintEventArgs pevent)
        {
            base.OnPaintBackground(pevent);
        }
    }
}
