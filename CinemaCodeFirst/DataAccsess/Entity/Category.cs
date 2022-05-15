using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsess.Entity
{
    public class Category
    {
        public int ID { get; set; }
        public string categoryName { get; set; }

        //Bir kategorinin birden fazla filmi olur
        public List<Movie> movies { get; set; }
    }
}
