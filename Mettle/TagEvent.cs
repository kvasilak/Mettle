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
    public class TagEvent : EventArgs
    {
        /// <summary>
        /// The module name of the recieved tag
        /// </summary>
        private string EventModule;

        /// <summary>
        /// The name of the tag recieved
        /// </summary>
        private string EventName;

        /// <summary>
        /// The value of the tag as an int
        /// </summary>
        private int EventValue;

        //how to do this....
        //private double EventDoubleValue;

        /// <summary>
        /// The event data string associated with the tag
        /// </summary>
        private string EventData;

        /// <summary>
        /// true is value is a valid integer
        /// </summary>
        public bool ValueValid = false;

        public string ModuleName
        {
            set
            {
                EventModule = value;
            }
            get
            {
                return this.EventModule;
            }
        }

        public string Name
        {
            set
            {
                EventName = value;
            }
            get
            {
                return this.EventName;
            }
        }

        public int Value
        {
            set
            {
                EventValue = value;
            }
            get
            {
                return this.EventValue;
            }
        }

        public string Data
        {
            set
            {
                EventData = value;
            }
            get
            {
                return this.EventData;
            }
        }

    }
}
