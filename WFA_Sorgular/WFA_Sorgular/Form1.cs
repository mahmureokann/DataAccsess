using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Sorgular
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        NORTHWNDEntities db = new NORTHWNDEntities();   
        private void btnSorgu_Click(object sender, EventArgs e)
        {
            //Soru
            //Fiyatı 20 ile 50 arasında olan ürünlerin ıd,ürün adı,fiyatı,stok miktarı ve kategori adını listeleyin.


            //T-SQL
            //select p.ProductID,p.UnitPrice,p.UnitsInStock,c.CategoryName from Products p join Categories c on p.CategoryID=c.CategoryID where p.UnitPrice>20 and p.UnitPrice<50

            //Linq
            //var = sorgunun sonucunda hangi tip geliyorsa otomatik olarak resulta o tipi atar.

            //var result = from p in db.Products
            //             where p.UnitPrice > 20 && p.UnitPrice < 50
            //             select new
            //             {
            //                 p.ProductID,
            //                 p.ProductName,
            //                 p.UnitsInStock,
            //                 p.UnitPrice,
            //                 p.Category.CategoryName
            //             };
            //dataGridView1.DataSource = result.ToList();

            //Linq to Entity
            //Linq expression (Lambda)
            // x => x.property
            var result = db.Products.Where(x => x.UnitPrice > 20 && x.UnitPrice < 50).Select(x => new
            {
                x.ProductID,
                x.ProductName,
                x.UnitPrice,
                x.Category.CategoryName
            }).ToList();

            dataGridView1.DataSource = result;
        }

        private void btnSorgu2_Click(object sender, EventArgs e)
        {
            //Soru
            //Siparişler tablosundan müşteri şirket adı, çalışan adı ve soyadı , sipariş ıdsi, sipariş tarihi ve kargo şirket adını getiren sorguyu yazın.


            //T-SQL
            /*select c.CompanyName as 'Şirket Adı', (e.FirstName + ' ' + e.LastName) as 'Çalışan Bilgisi', o.OrderID as 'Sipariş ID', o.OrderDate as 'Sipariş Tarih',s.CompanyName as 'Kargo Şirketi' from Orders o
            join Customers c on c.CustomerID = o.CustomerID
            join Employees e on e.EmployeeID = o.EmployeeID
            join Shippers s on s.ShipperID = o.ShipVia 
            */

            //Linq

            //var result = from o in db.Orders
            //             select new
            //             {
            //                 MüşretiAdi = o.Customer.CompanyName,
            //                 AdSoyad = o.Employee.FirstName + " " + o.Employee.LastName,
            //                 o.OrderID,
            //                 o.OrderDate,
            //                 o.Shipper.CompanyName
            //             };
            //dataGridView1.DataSource = result.ToList();

            //Linq to entity

            var result = db.Orders.Select(x => new
            {
                x.Customer.CompanyName,
                Adsoyad = x.Employee.FirstName + " " + x.Employee.LastName,
                x.OrderID,
                x.OrderDate,
                KargoŞirket = x.Shipper.CompanyName

            });
            dataGridView1.DataSource=result.ToList();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            //Kategorisi beverages olan ve ürün adı 'kola' fiyatı 5 stok adet 500 olan ürünü ekleyin

            //T-SQL
            //insert into Products(ProductName,CategoryID,UnitPrice,UnitsInStock) values ('kola',1,5,500)

            //Ekleme işlemi
            Product p = new Product();
            p.ProductName = "Ayran";
            p.UnitPrice = 5;
            p.UnitsInStock = 500;

           // int catId = db.Categories.First(x => x.CategoryName == "beverages").CategoryID;

            int catId2 = db.Categories.FirstOrDefault(x => x.CategoryName == "beverages").CategoryID;
            p.CategoryID = catId2;
            db.Products.Add(p);
            db.SaveChanges();
            MessageBox.Show("Ürün eklendi!");


        }

        private void btn4_Click(object sender, EventArgs e)
        {
            db.Products.Add(new Product
            {
                ProductName = "Sprite",
                UnitPrice = 5,
                UnitsInStock = 500,
                CategoryID = db.Categories.FirstOrDefault(x=> x.CategoryName == "beverages").CategoryID
            });
            db.SaveChanges();
            MessageBox.Show("Ürün eklendiz!");
        }
    }
}
