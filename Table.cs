using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBFourLab
{
    public class Table
    {
        public List<Row> Rows { get; set; }
        public Table()
        {
            Rows = new List<Row>();
        }
    }
}
