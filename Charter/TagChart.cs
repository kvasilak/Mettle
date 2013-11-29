using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Charter
{
    public partial class TagChart : Chart
    {
        private int indx = 0;

        public TagChart()
        {
            InitializeComponent();
        }

        public void UpdateEvent(EventTag e)
        {
            int i;

            //Suport multiple chart areas
            // (i = 0; i < base.ChartAreas.Count; i++)
            //{
                if (e.Name == base.Tag.ToString()) //base.ChartAreas[i].Name) //
                //if(base.Tag.ToString().Contains(e.Name))
                {
                    if (base.Series[0].Points.Count < base.ChartAreas[0].AxisX.Maximum)
                    {
                        base.Series[0].Points.Add(e.Value);
                    }
                    else
                    {
                        base.Series[0].Points[indx].SetValueY(e.Value);

                        if (++indx > base.ChartAreas[0].AxisX.Maximum - 1) indx = 0;

                        Invalidate();
                    }
                }
            //}
        }
    }
}
