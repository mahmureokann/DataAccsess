using BLL.Service;
using DataAccsess.Context;
using DataAccsess.Entity;
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
    public partial class SessionForm : Form
    {
        public SessionForm()
        {
            InitializeComponent();
        }

        ProjectContext db= new ProjectContext();
        private void SessionForm_Load(object sender, EventArgs e)
        {
            //Hangi film hangi saatte hangi salonda
            
            var result = db.theaters.Select(x => new
            {
                FilmAdi = x.movie.MovieName,
                Saat = x.session.SessionTime,
                SalonAdi = x.saloon.saloon

            }).ToList();
            dataGridView1.DataSource=result;
            
        }
    }
}
