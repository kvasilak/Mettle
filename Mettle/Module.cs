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
using System.Linq;
using System.Text;

namespace Mettle
{
    class Module : IComparable<Module>
    {
        public string ModuleName;
        public List<Tags> TagList = new List<Tags>();

        public Module(TagEvent e)
        {
            ModuleName = e.ModuleName;

            TagList.Add(new Tags(e));
        }

        //Create a list of unique module/tag/data combinations 
        public void Uniques(TagEvent e)
        {
            bool TagNameFound = false;

            //Search to see if tag exists
            foreach (Tags tg in TagList)
            {
                if (tg.Name == e.Name)
                {
                    //found, now check data and values
                    TagNameFound = true;
                    tg.Uniques(e);
                }
            }

            //add tag to list of unique tags
            if (false == TagNameFound)
            {
                TagList.Add(new Tags(e));

                TagList.Sort();
            }

        }
        public int CompareTo(Module other)
        {
            // Alphabetic sort 
            return this.ModuleName.CompareTo(other.ModuleName);
        }
    }
}
