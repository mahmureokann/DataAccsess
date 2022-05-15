using DataAccsess.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsess.Context
{
   public class ProjectContext:DbContext
    {
        //DbSetlerin bulundupu yer. Classların tablolara dönüşmesi.
        //DbContextten miras alabilmek için Manage NuGetten EntityFramework'ü indirmemiz gerekiyor.Daha sonra ctrl. ile using açıyoruz.

        public ProjectContext()
        {
            Database.Connection.ConnectionString = "server = DESKTOP-S4HM3GR\\SQLEXPRESS;database = CinemaCodeFirstDB;Trusted_Connection=true";
            //SQL ağını bağladık.
        }

        //Entityde tablo adlarını ekledikten sonra tablolaştırıyoruz.(ctrl.)
        public DbSet<Category> categories { get; set; }
        public DbSet<Movie> movies { get; set; }
        public DbSet<Saloon> saloons { get; set; }
        public DbSet<Session> sessions { get; set; }
        public DbSet<Week> weeks { get; set; }
        public DbSet<Theater> theaters { get; set; }
        public DbSet<MovieCategory> movieCategories { get; set; }
    }
}
