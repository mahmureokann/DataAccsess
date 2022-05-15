using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinUI.Forms;

namespace WinUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void childForm(Form _childForm)
        {
            this.Width = _childForm.Width + 22;
            this.Height = _childForm.Height + 60;
            bool durum = false;

            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Text == _childForm.Text)
                {
                    durum = true;
                    frm.Activate();
                }
                else
                {
                    frm.Close();
                }

            }

            if (durum == false)
            {
                _childForm.MdiParent = this;
                _childForm.StartPosition = FormStartPosition.Manual;
                _childForm.FormBorderStyle = FormBorderStyle.None;
                _childForm.Show();
            }


        }

        private void salonlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            childForm(new SaloonForm());
        }

        private void seanslarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            childForm(new SessionForm());   
        }

        private void kategorilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            childForm(new CategoryForm());
        }

        private void kategorilerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            childForm(new AdminCategoryForm());
        }

        private void salonlarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            childForm(new AdminSaloonForm());
        }

        private void filmlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            childForm(new AdminMovieForm());
        }

        private void seanslarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            childForm(new AdminSessionForm());
        }
    }
}
