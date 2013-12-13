using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mettle
{
    interface ITagInterface
    {
        void UpdateEvent(TagEvent e);
        void Initialize();
        void Reset();
    }
}
