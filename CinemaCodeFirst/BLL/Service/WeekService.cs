using DataAccsess.Context;
using DataAccsess.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Service
{
    public class WeekService
    {
        ProjectContext db = new ProjectContext();

        public string CreateWeek(Week week)
        {
            try
            {
                db.weeks.Add(week);
                db.SaveChanges();
                return "Eklendi!";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }
        public List<Week> WeekList()
        {
            return db.weeks.ToList();
        }
        public string UpdateWeek(Week week)
        {
            try
            {
                db.Entry(week).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return "Güncelleme başarılı!";

            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }
        public string DeleteWeek(int id)
        {
            try
            {
                Week silinecek = db.weeks.Find(id);
                db.weeks.Remove(silinecek);
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
