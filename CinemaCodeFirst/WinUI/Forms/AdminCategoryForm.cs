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
    public partial class AdminCategoryForm : Form
    {
        public AdminCategoryForm()
        {
            InitializeComponent();
        }
        ProjectContext db = new ProjectContext();

        CategoryService categoryService = new CategoryService();

        private void KategoriListele() //Kendimiz oluşturduk.
        {
            listView1.Items.Clear();
            List<Category> categoryList = categoryService.CategoryList();
            foreach (Category category in categoryList)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = category.ID.ToString();
                lvi.SubItems.Add(category.categoryName);
                listView1.Items.Add(lvi);
            }
        }
        private void AdminCategoryForm_Load(object sender, EventArgs e)
        {
            KategoriListele();
        }
        Category category = new Category();
        private void btnEkle_Click(object sender, EventArgs e)
        {

            category.categoryName = txtKategori.Text;
            string result = categoryService.CreateCategory(category);
            MessageBox.Show(result);
            KategoriListele();

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

            category.ID = Convert.ToInt32(txtId.Text);
            category.categoryName = txtKategori.Text;
            string result = categoryService.UpdateCategory(category);
            MessageBox.Show(result);
            KategoriListele();




        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            string result = categoryService.DeleteCategory(Convert.ToInt32(txtId.Text));
            MessageBox.Show(result);
            KategoriListele();
        }

       
    }
}
