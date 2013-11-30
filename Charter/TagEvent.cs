//Charter, an embedded software analysis tool
//Copyright (C) 2013  Keith Vasilakes
//
//This program is free software: you can redistribute it and/or modify
//it under the terms of the GNU General Public License as published by
//the Free Software Foundation, either version 3 of the License, or
//(at your option) any later version.
//
//In addition any and all modifications made to this program belong to the origional copyright holder.
//This includes existing code and new code that is designed to work within the framework or expands this framework.
//All such changes shall be published as a branch to the origional code within 6 months of creation.
//All New source files shall contain this notice.
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

namespace Charter
{
    public class TagEvent : EventArgs
    {
        /// <summary>
        /// The name of the tag recieved
        /// </summary>
        private string EventName;

        /// <summary>
        /// The value of the tag as an int
        /// </summary>
        private int EventValue;

        /// <summary>
        /// The event data string associated with the tag
        /// </summary>
        private string EventData;

        /// <summary>
        /// true is value is a valid integer
        /// </summary>
        public bool ValueValid = false;

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
