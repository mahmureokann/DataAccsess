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

namespace WinUI.Forms
{
    public partial class AdminMovieForm : Form
    {
        public AdminMovieForm()
        {
            InitializeComponent();
        }

        ProjectContext db = new ProjectContext();

        MovieService movieService = new MovieService();

        Movie movie = new Movie();

        private void MovieListele() //Kendimiz oluşturduk.
        {
            listView1.Items.Clear();
            List<Movie> movieList = movieService.MovieList();
            foreach (Movie movie in movieList)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = movie.ID.ToString();
                lvi.SubItems.Add(movie.MovieName);
                lvi.SubItems.Add(movie.Description);
                lvi.SubItems.Add(Convert.ToInt32(movie.Duration).ToString());
                listView1.Items.Add(lvi);
            }
        }
        private void AdminMovieForm_Load(object sender, EventArgs e)
        {
            MovieListele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            movie.MovieName = txtFilmAd.Text;
            movie.Description = txtAciklama.Text;
            movie.Duration = Convert.ToInt32(txtSure.Text);
            string result = movieService.CreateMovie(movie);
            MessageBox.Show(result);
            MovieListele();
            
        }
        Movie Movie =new Movie();

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Movie.ID = Convert.ToInt32(txtID.Text);
            movie.MovieName = txtFilmAd.Text;
            movie.Description = txtAciklama.Text;
            movie.Duration = Convert.ToInt32(txtSure.Text);
            string result = movieService.UpdateMovie(movie);
            MessageBox.Show(result);
            MovieListele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            string result = movieService.DeleteMovie(Convert.ToInt32(txtID.Text));
            MessageBox.Show(result);
            MovieListele();
        }
    }
}
