using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsess.Entity
{
    public class Week
    {
        public int ID { get; set; }
        public int week { get; set; }
        public DateTime FirstDay { get; set; }
        public DateTime LastDay { get; set; }
    }
}
