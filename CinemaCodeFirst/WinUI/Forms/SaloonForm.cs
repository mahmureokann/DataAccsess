using DataAccsess.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinUI
{
    public partial class SaloonForm : Form
    {
        public SaloonForm()
        {
            InitializeComponent();
        }


            ProjectContext db = new ProjectContext();

        private void SaloonForm_Load(object sender, EventArgs e)
        {
            //Hangi film hangi salonda 
            var result = db.theaters.Select(x => new
            {
                FilmAdi = x.movie.MovieName,
                
                SalonAdi = x.saloon.saloon

            }).ToList();
            dataGridView1.DataSource = result;
        }
    }
}
