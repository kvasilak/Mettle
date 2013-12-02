using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Charter
{
    
    class Tags
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
