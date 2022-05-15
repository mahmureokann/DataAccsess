using DataAccsess.Context;
using DataAccsess.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Service
{
   public class CategoryService
    {
        //CRUD İŞLEMLERİ
        ProjectContext db = new ProjectContext();

        //Create
        public string CreateCategory(Category category)
        {
            try
            {
                db.categories.Add(category);
                db.SaveChanges();
                return $"{category.categoryName} kaydedildi!";

            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        //List
        public List<Category> CategoryList()
        {
            return db.categories.ToList();
        }

        //Update
        //public string UpdateCategory(Category category)
        //{
        //    try
        //    {
        //        db.Entry(category).State = System.Data.Entity.EntityState.Modified;
        //        db.SaveChanges();
        //        return $"{category.categoryName} güncelleme başarılı!";
        //    }
        //    catch (Exception ex)
        //    {

        //        return ex.Message;
        //    }
        //}

        public string UpdateCategory(Category category)
        {

            Category updated = db.categories.FirstOrDefault(x => x.ID == category.ID);
            updated.categoryName = category.categoryName;

            db.SaveChanges();
            return "Guncelleme tamamlandı";
        }
        //Delete
        public string DeleteCategory(int id)
        {
            try
            {
                Category silinecek = db.categories.Find(id);
                db.categories.Remove(silinecek);
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
