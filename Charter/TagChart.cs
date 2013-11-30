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

        public void UpdateEvent(TagEvent e)
        {
            int i;

            //Todo; Suport multiple chart areas

            //can have multiple series on one chart
            for(i = 0; i < base.Series.Count; i++)
            {
                //if (e.Name == base.Tag.ToString()) //base.ChartAreas[i].Name) //
                if(base.Series[i].Name == e.Name)
                {
                    
                    if (base.Series[i].Points.Count < base.ChartAreas[0].AxisX.Maximum)
                    {
                        base.Series[i].Points.Add(e.Value);
                    }
                    else
                    {
                        indx = int.Parse(base.Series[i].Points[0].GetCustomProperty("index"));

                        base.Series[i].Points[indx].SetValueY(e.Value);
                        

                        if (++indx > base.ChartAreas[0].AxisX.Maximum - 1) indx = 0;

                        base.Series[i].Points[0].SetCustomProperty("index", indx.ToString());

                        Invalidate();
                    }
                }
           }
        }
    }
}
