using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;//SqlConnection classını barındıran kütüphane
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_AdoNet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Ado.Net
            /*
                
                
                //Disconnected
                --ilk etapta veritabanına bir istek gönderilecek.
                --eğer veritabanı bağlantısı kapalı ise açılacak.
                --bağlantı açıldıktan sonra veriler projeye çekilecek
                --bağlantı kapatılacak.
                --verilerde işlemler yapılacak.
                */
            //Standart Connection (Sql server authentication)=> Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;
            //Trusted Connection (Windows Authentication) => Server=myServerAddress;Database=myDataBase;Trusted_Connection=True;
            //connectionString=> bağlantı yolu. (server name,login,password)

            SqlConnection sqlConnection = new SqlConnection(@"server=FATIH\SQLEXPRESS;database=northwind;uid=sa;password=123");

            //SqlConnection connection = new SqlConnection("server=.;database=northwind;Trusted_Connection=True");
            #region Disconnected
            //if (sqlConnection.State == ConnectionState.Closed) 
            //    sqlConnection.Open();
            //SqlCommand cmd = new SqlCommand("select * from orders",sqlConnection);
            //SqlDataReader dr = cmd.ExecuteReader();

            //DataTable dt = new DataTable();
            //dt.Load(dr);

            //dataGridView1.DataSource = dt;
            //sqlConnection.Close(); 
            #endregion

            //Connected

            //SqlDataAdapter dataAdapter = new SqlDataAdapter("select * from orders", "server=FATIH\\SQLEXPRESS;database=northwind;uid=sa;pwd=123");
            //DataTable dt = new DataTable();
            //dataAdapter.Fill(dt);
            //dataGridView1.DataSource = dt;

            //Entityframework
            NorthwindEntities db = new NorthwindEntities();
            dataGridView1.DataSource = db.Orders.ToList();



        }
    }
}
