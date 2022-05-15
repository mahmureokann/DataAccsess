using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Entityframework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NorthwindEntities db = new NorthwindEntities(); //NorthwindEntities veritabanını temsil eder.
                                                            //Product => veritabanında bulunan tabloyu temsil eden class;
                                                            //foreach (Product p in db.Products)
                                                            //{
                                                            //    MessageBox.Show(p.ProductName);
                                                            //}

            foreach (Product p in db.Products)
            {
                listBox1.Items.Add(p.ProductName);
            }
        }
    }
}
