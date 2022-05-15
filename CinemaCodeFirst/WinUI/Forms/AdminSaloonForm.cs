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
    public partial class AdminSaloonForm : Form
    {
        public AdminSaloonForm()
        {
            InitializeComponent();
        }

        ProjectContext db = new ProjectContext();

        SaloonService saloonService = new SaloonService();

        private void SaloonListele() //Kendimiz oluşturduk.
        {
            listView1.Items.Clear();
            List<Saloon> saloonList = saloonService.SaloonList();
            foreach (Saloon saloon in saloonList)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = saloon.ID.ToString();
                lvi.SubItems.Add(saloon.saloon);
                listView1.Items.Add(lvi);
            }
        }

        private void AdminSaloonForm_Load(object sender, EventArgs e)
        {
            SaloonListele();
        }
        Saloon Saloon = new Saloon();

        private void btnEkle_Click(object sender, EventArgs e)
        {

            Saloon.saloon = txtSaloon.Text;
            string result = saloonService.CreateSaloon(Saloon);
            MessageBox.Show(result);
            SaloonListele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Saloon.saloon = txtID.Text;
            Saloon.saloon = txtSaloon.Text;
            string result = saloonService.UpdateSaloon(Saloon);
            MessageBox.Show(result);
            SaloonListele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            string result = saloonService.DeleteSaloon(Convert.ToInt32(txtID.Text));
            MessageBox.Show(result);
            SaloonListele();
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
