using DataAccsess.Context;
using DataAccsess.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Service
{
    public class SaloonService
    {
        //Create
        ProjectContext db = new ProjectContext();
        public string CreateSaloon(Saloon saloon)
        {
            try
            {
                db.saloons.Add(saloon);
                db.SaveChanges();
                return $"{saloon.saloon} kaydedildi!";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        //List

        public List<Saloon> SaloonList()
        {
            return db.saloons.ToList();
        }


        //Update
        public string UpdateSaloon(Saloon saloon)
        {
            try
            {
                db.Entry(saloon).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return "Güncelleme başarılı!";

            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        //Delete
        public string DeleteSaloon(int id)
        {
            try
            {
                Saloon silinecek = db.saloons.Find(id);
                db.saloons.Remove(silinecek);
                db.SaveChanges();
                return "Silme işlemi başarılı!";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }
    }
}
