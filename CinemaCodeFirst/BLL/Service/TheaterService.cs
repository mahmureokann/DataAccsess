using DataAccsess.Context;
using DataAccsess.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Service
{
    public class TheaterService
    {

        ProjectContext db = new ProjectContext();
        public string CreateTheater(Theater theater) 
        {
            try
            {
                db.theaters.Add(theater);
                db.SaveChanges();
                return " Kaydedildi!";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }
        public List<Theater> TheaterList()
        {
            return db.theaters.ToList();
        }
        public string UpdateTheater(Theater theater)
        {
            try
            {
                db.Entry(theater).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return "Güncelleme başarılı!";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }
        public string DeleteTheater(int id)
        {
            try
            {
                Theater silinecek = db.theaters.Find(id);
                db.theaters.Remove(silinecek);
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
