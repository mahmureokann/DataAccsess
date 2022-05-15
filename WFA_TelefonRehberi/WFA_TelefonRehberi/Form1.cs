using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_TelefonRehberi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        FhristDBEntities db = new FhristDBEntities();
        private void Form1_Load(object sender, EventArgs e)
        {
            GetPersons();
        }
        public void GetPersons()
        {
            listView1.Items.Clear();
            foreach (Person person in db.Persons)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = person.ID.ToString();
                lvi.SubItems.Add(person.Firstname);
                lvi.SubItems.Add(person.Lastname);
                lvi.SubItems.Add(person.PhoneNumber);
                lvi.Tag = person;
                listView1.Items.Add(lvi);
            }
        }

        public void GetPersons(string param) //parametreli GetPersons aldık.Ara textBoxı için.
        {
            listView1.Items.Clear();


            //Lamda Expression=>
            // x => (dışardaki xi içeri aktarır.)
            // x => x.

            //StartWith = bunun ile başlıyorsa.


            foreach (Person person in db.Persons.Where(x=>x.Firstname.StartsWith(param)||x.Lastname.StartsWith(param)))
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = person.ID.ToString();
                lvi.SubItems.Add(person.Firstname);
                lvi.SubItems.Add(person.Lastname);
                lvi.SubItems.Add(person.PhoneNumber);
                lvi.Tag = person;
                listView1.Items.Add(lvi);
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtFirstname.Text.Length == 0 || txtLastname.Text.Length == 0 || txtPhoneNumber.Text.Length == 0)
            {
                MessageBox.Show("lütfen bilgileri eksiksiz doldurun!");
            }
            else
            {
                Person p = new Person();
                p.Firstname = txtFirstname.Text;
                p.Lastname = txtLastname.Text;
                p.PhoneNumber = txtPhoneNumber.Text;

                db.Persons.Add(p);
                db.SaveChanges();//dbye kaydetmiş olduk.
                MessageBox.Show("Kişi kaydedildi!");
                GetPersons();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count > 0)
            {
                Person p = (Person)listView1.SelectedItems[0].Tag;
                db.Persons.Remove(p);
                db.SaveChanges();
                MessageBox.Show("kişi silindi!");
                GetPersons();
            }
            else
            {
                MessageBox.Show("önce bir veri ekleyin");
            }
        }
        Person guncellencek;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            if (listView1.Items.Count > 0)
            {
                guncellencek = (Person)listView1.SelectedItems[0].Tag;
                txtFirstname.Text = guncellencek.Firstname;
                txtLastname.Text = guncellencek.Lastname;
                txtPhoneNumber.Text = guncellencek.PhoneNumber;
                btnKaydet.Enabled = false; //Kaydet butonu, listview ıtemına çift tıklandığı anda yok olacak.
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            guncellencek.Firstname = txtFirstname.Text;
            guncellencek.Lastname = txtLastname.Text;
            guncellencek.PhoneNumber = txtPhoneNumber.Text;
            db.SaveChanges();
            MessageBox.Show("Veri güncellendi!");
            GetPersons();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            GetPersons(textBox1.Text);
        }
    }
}
