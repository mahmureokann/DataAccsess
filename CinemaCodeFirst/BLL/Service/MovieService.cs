using DataAccsess.Context;
using DataAccsess.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Service
{
    public class MovieService
    {
        ProjectContext db = new ProjectContext();

        //Create
        public string CreateMovie(Movie movie)
        {
            try
            {
                db.movies.Add(movie);
                db.SaveChanges();
                return $"{movie.MovieName} kaydedildi!";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }


        //List
        public List<Movie> MovieList()
        {
            return db.movies.ToList();  
        }

        //Update
        public string UpdateMovie(Movie movie)
        {

            Movie updated = db.movies.FirstOrDefault(x => x.MovieName == movie.MovieName);
            updated.MovieName = movie.MovieName;
            updated.Description = movie.Description;
            updated.Duration = movie.Duration;
            db.SaveChanges();
            return "Guncelleme tamamlandı";
        }
        //public string UpdateMovie(Movie movie)
        //{
        //    try
        //    {
        //        db.Entry(movie).State = System.Data.Entity.EntityState.Modified;
        //        db.SaveChanges();
        //        return "Güncelleme işlemi gerçekleştirildi!";
        //    }
        //    catch (Exception ex)
        //    {

        //        return ex.Message;
        //    }
        //}

        //Delete
        public string DeleteMovie(int id) //ID bulunacak ve ıd silinecek.
        {
            try
            {
                Movie silinecek = db.movies.Find(id);
                db.movies.Remove(silinecek);
                db.SaveChanges();
                return "Silme işlemi gerçekleştirildi!";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }
        




    }
}
