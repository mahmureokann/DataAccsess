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
    public partial class AdminSessionForm : Form
    {
        public AdminSessionForm()
        {
            InitializeComponent();
        }
        ProjectContext db = new ProjectContext();

        SessionService sessionsService = new SessionService();

        Session session = new Session();

        private void SessionListele() //Kendimiz oluşturduk.
        {
            listView1.Items.Clear();
            List<Session> sessionList = sessionsService.SessionList();
            foreach (Session session in sessionList)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = session.ID.ToString();
                lvi.SubItems.Add(session.SessionTime.ToString());
                lvi.SubItems.Add(session.Duration.ToString());
               
                listView1.Items.Add(lvi);
            }
        }
       

        private void AdminSessionForm_Load(object sender, EventArgs e)
        {
            SessionListele();
        }
        Session session1= new Session();
        private void btnEkle_Click(object sender, EventArgs e)
        {
            session1.SessionTime = dtpSeans.Value;
            session1.Duration = Convert.ToInt32(txtSeans.Text);
            string result = sessionsService.CreateSession(session);
            MessageBox.Show(result);
            SessionListele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            session1.SessionTime = dtpSeans.Value;
            session1.Duration = Convert.ToInt32(txtSeans.Text);
            string result = sessionsService.UpdateSession(session);
            MessageBox.Show(result);
            SessionListele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            string result = sessionsService.DeleteSession(Convert.ToInt32(txtSeans.Text));
            MessageBox.Show(result);
            SessionListele();
        }
    }
}
