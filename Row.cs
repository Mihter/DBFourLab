using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBFourLab
{
    public class Row
    {
        public Dictionary<SchemeColumn, object> Data { get; set; }
        public Row()
        {
            Data = new Dictionary<SchemeColumn, object>();
        }
    }
}
