using DataAccsess.Context;
using DataAccsess.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Service
{
    public class SessionService
    {
        //Create
        ProjectContext db = new ProjectContext();
        public string CreateSession(Session session)
        {
            try
            {
                db.sessions.Add(session);
                db.SaveChanges();
                return $"{session.SessionTime} kaydedildi!";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        //List

        public List<Session> SessionList()
        {
            return db.sessions.ToList();

        }

        //Update
        public string UpdateSession(Session session)
        {

            Session updated = db.sessions.FirstOrDefault(x => x.SessionTime == session.SessionTime);
            updated.SessionTime = session.SessionTime;
            updated.Duration  = session.Duration;

            db.SaveChanges();
            return "Guncelleme tamamlandı";
        }
        //Silme
        public string DeleteSession(int id)
        {
            try
            {
                Session silinecek = db.sessions.Find(id);
                db.sessions.Remove(silinecek);
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
