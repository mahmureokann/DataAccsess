using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsess.Entity
{
   public class Movie
    {
        public int ID { get; set; }
        public string MovieName { get; set; }
        public string Description { get; set; }
        public int Duration { get; set; }

        //Bir filmin birden fazla kategorisi olur
        public List<Category> categories { get; set; }
    }
}
