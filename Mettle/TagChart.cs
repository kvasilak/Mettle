//Mettle, an embedded software analysis tool
//Copyright (C) 2013  Keith Vasilakes
//
//This program is free software: you can redistribute it and/or modify
//it under the terms of the GNU General Public License as published by
//the Free Software Foundation, either version 3 of the License, or
//(at your option) any later version.
//
//This program is distributed in the hope that it will be useful,
//but WITHOUT ANY WARRANTY; without even the implied warranty of
//MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//GNU General Public License for more details.
//
//You should have received a copy of the GNU General Public License
//along with this program.  If not, see <http://www.gnu.org/licenses/>.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Mettle
{
    public partial class TagChart : Chart, ITagInterface
    {
        private int indx = 0;
        private string m_ModuleName;

        public TagChart()
        {
            InitializeComponent();
        }

        //Do any custom initialization here
        void ITagInterface.Initialize()
        {
        }

        //Module names are ignored until we can figure it out!
        void ITagInterface.UpdateEvent(TagEvent e)
        {
            int i;

            //Todo; Suport multiple chart areas

            if ((ModuleName == null) || (ModuleName == e.ModuleName))
            {
                //can have multiple series on one chart
                for (i = 0; i < base.Series.Count; i++)
                {
                    //if (e.Name == base.Tag.ToString()) //base.ChartAreas[i].Name) //
                    if (base.Series[i].Name == e.Name)
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
