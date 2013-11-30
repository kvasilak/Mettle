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
