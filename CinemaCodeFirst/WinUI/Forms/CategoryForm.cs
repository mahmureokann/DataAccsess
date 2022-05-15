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
    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();
        }
        ProjectContext db = new ProjectContext();
        CategoryService categoryService = new CategoryService();
        Category category = new Category();
        MovieCategory movieCategory = new MovieCategory();
       
        private void CategoryForm_Load(object sender, EventArgs e)
        {
            //Hangi filmler hangi kategoride
            var result = movieCategory.Select(x => new
            {
                FilmAdi = x.movie.MovieName,
                KategoriAdi = x.CategoryId.ToString(category.categoryName)


            }).ToList();
            dataGridView1.DataSource = result.ToString();

        }
       

       
    }
    
}
