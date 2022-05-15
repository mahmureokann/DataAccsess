using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_EF_Performans
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Trusted_Connection
        /*
         Server=myServerAddress;Database=myDataBase;Trusted_Connection=True;
         */
        private void btnConnected_Click(object sender, EventArgs e)
        {
            DateTime baslangic = DateTime.Now;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select orderId from orders", "server=FATIH\\SQLEXPRESS;database=northwind;uid=sa;pwd=123");
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            listBox1.DataSource = dt;
            listBox1.DisplayMember = "orderId";
            DateTime bitis = DateTime.Now;
           TimeSpan ts= bitis - baslangic;
            lblConnected.Text = ts.Milliseconds.ToString();
        }

        private void btnDisconnected_Click(object sender, EventArgs e)
        {
            DateTime baslangic = DateTime.Now;
            SqlConnection sqlConnection = new SqlConnection("server=FATIH\\SQLEXPRESS;database=northwind;uid=sa;pwd=123");
            SqlCommand cmd = new SqlCommand("select orderId from orders", sqlConnection);
            if (sqlConnection.State == ConnectionState.Closed) sqlConnection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    listBox2.Items.Add(dr.GetInt32(0));
                }
            }
            DateTime bitis = DateTime.Now;
            TimeSpan ts = bitis - baslangic;
            lblDisconnected.Text = ts.Milliseconds.ToString();
        }

        private void btnEntityframework_Click(object sender, EventArgs e)
        {
            DateTime baslangic = DateTime.Now;
            NorthwindEntities db = new NorthwindEntities();
            listBox3.DataSource = db.Orders.ToList();
            listBox3.DisplayMember = "OrderId";
            DateTime bitis = DateTime.Now;
            TimeSpan ts = bitis - baslangic;
            lblEntityFramework.Text = ts.Milliseconds.ToString();
        }
    }
}
