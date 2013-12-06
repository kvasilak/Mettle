//Charter, an embedded software analysis tool
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
using System.Linq;
using System.Text;

namespace Mettle
{

    class Tags : IComparable<Tags>
    {
        public string Name;
        public List<string> Data = new List<string>();
        public bool ValueValid = false;

        public int min = int.MaxValue;
        public int max = int.MinValue;

        public Tags(TagEvent e)
        {
            Name = e.Name;

            if (e.ValueValid)
            {
                if (e.Value > max)
                {
                    max = e.Value;
                }

                if (e.Value < min)
                {
                    min = e.Value;
                }
                
                ValueValid = true;

            }
            else
            {

                Data.Add(e.Data);
            }
        }

        public int CompareTo(Tags other)
        {
            // Alphabetic sort 
            return this.Name.CompareTo(other.Name);
        }

        public override string ToString()
        {
            // String representation.
            return this.Name;
        }

        public void Value(int v)
        {
            if (v > max)
            {
                max = v;
            }

            if (v < min)
            {
                min = v;
            }

        }
    }
}
