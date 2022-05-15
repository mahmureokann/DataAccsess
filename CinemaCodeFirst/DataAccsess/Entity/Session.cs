using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsess.Entity
{
    public class Session
    {
        public int ID { get; set; }
        public DateTime SessionTime { get; set; } //Ekstra

        public int Duration { get; set; }
    }
}
