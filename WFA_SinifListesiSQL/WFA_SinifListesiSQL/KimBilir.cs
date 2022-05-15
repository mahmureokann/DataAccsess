using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_SinifListesiSQL
{
    public partial class KimBilir : Form
    {
        public KimBilir()
        {
            InitializeComponent();
        }
        //Konu listesi
        List<Konu> konuListesi = new List<Konu>()
         {
           Konu.Opertörler,
           Konu.TryCatch,
           Konu.Interface,
           Konu.Enum,
           Konu.Encapsulation,
           Konu.Abstract,
           Konu.Constructor,
           Konu.Runtime,
           Konu.Polymorphism,
           Konu.Metotlar,
           Konu.Döngüler,
           Konu.Inheritance,
           Konu.KararYapıları,
           Konu.Değişkenler,

         };
        private void KimBilir_Load(object sender, EventArgs e)
        {
            //Uygulama ilk açıldığında sınıf listesi ve konu listesi hazır olacak.

            for (int i = 0; i < Sinif.sinifListesi.Count; i++)
            {
                LstSinifListesi.Items.Add(Sinif.sinifListesi[i]);
            }
            for (int i = 0; i < konuListesi.Count; i++)
            {
                lstKonu.Items.Add(konuListesi[i]);
            }
        }

        public void btnSec_Click(object sender, EventArgs e)
        {
            //Rastgele konu ve kişi ismi listviewe eklenecek.
            ListViewItem lvi = new ListViewItem();
            Random rnd = new Random(); //Kişi randomı
            Random rnd2 = new Random(); //Konu randomı
            int rastgeleKisi = rnd.Next(0, LstSinifListesi.Items.Count);
            int rastgeleKonu = rnd.Next(0, lstKonu.Items.Count);

            if (LstSinifListesi.Items.Count > 0)
            {
                Sinif secilmisKisi = (Sinif)LstSinifListesi.Items[rastgeleKisi];
                //Sınıf listesi içinde dönüp eğer seçilmiş kişi,kişiye eşitse bir dialog gelsin.
                foreach (Sinif kisi in Sinif.sinifListesi)
                {
                    if (secilmisKisi.Ad == kisi.Ad)
                    {
                        DialogResult dr = MessageBox.Show(kisi.Ad + " " + kisi.Soyad + " " + " Konu: " + konuListesi[rastgeleKonu], "Listeye eklensin mi?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (dr == DialogResult.Yes)
                        {
                            lvi.Text = kisi.Ad;
                            lvi.SubItems.Add(kisi.Soyad);
                            lvi.SubItems.Add(konuListesi[rastgeleKonu].ToString());
                            listView1.Items.Add(lvi);
                            LstSinifListesi.Items.RemoveAt(rastgeleKisi);
                            // lstKonu.Items.RemoveAt(rastgeleKonu); !!!! GEREK YOK !!!
                            kisi.Puan = 5;
                            lvi.SubItems.Add(kisi.Puan.ToString());
                            

                        }
                        else
                        {
                            lvi.Text = kisi.Ad;
                            lvi.SubItems.Add(kisi.Soyad);
                            lvi.SubItems.Add(konuListesi[rastgeleKonu].ToString());
                            listView1.Items.Add(lvi);
                            LstSinifListesi.Items.RemoveAt(rastgeleKisi);
                            kisi.Puan = 0;
                            lvi.SubItems.Add(kisi.Puan.ToString());

                        }
                    }

                }


            }
            else
            {
                MessageBox.Show("Başka kişi kalmadııı :))");
            }
        }
    }
}
