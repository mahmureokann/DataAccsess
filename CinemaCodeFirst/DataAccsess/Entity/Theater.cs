using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsess.Entity
{
    public class Theater
    {
        public int ID { get; set; }
        public int MovieId { get; set; }
        public int CategoryId { get; set; }
        public int SaloonId { get; set; }
        public int SessionId { get; set; }

        public Movie movie { get; set; }

        public Saloon saloon { get; set; }
        public Session session { get; set; }
        public Week weeks { get; set; }
    }
}
