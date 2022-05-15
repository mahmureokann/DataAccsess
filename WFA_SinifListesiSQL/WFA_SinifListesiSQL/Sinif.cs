using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_SinifListesiSQL
{
    public class Sinif
    {
        //METOT(geriye değer döndürecek)
        public Sinif(string ad, string soyad, short puan)
        {
            Ad = ad;
            Soyad = soyad;
            Puan = puan;

        }
        //Sınıf içerisindeki kişileri bir listeye attım.Bu listeye her yerden ulaşabilmek istediğim için static yaptım.
        public static List<Sinif> sinifListesi = new List<Sinif>()
       {
           new Sinif("Mert","Atalay",0),
           new Sinif("Azad","MAJIDLI",0),
           new Sinif("Sıla","Şirin",0),
           new Sinif("Umut","Yılbaş",0),
           new Sinif("Saruhan Mert","Demiray",0),
           new Sinif("Onur","Doğru",0),
           new Sinif("Emre","Bektaşoğlu",0),
           new Sinif("Enes", "Serenli",0),
           new Sinif("Furkan Semih", "Güneş",0),
           new Sinif("Bahadır", "Arda",0),
           new Sinif("Burak", "Uysal",0),
           new Sinif("Ahmet Caner", "Tatlı",0),
           new Sinif("Tuba", "Buğday Karadut",0),
           new Sinif("Mahmure", "Okan",0),
           new Sinif("Arya", "Kapıkıran",0),
           new Sinif("Berk", "Basat",0)


        };

        //Bir sınıfın nesi olur?
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public short Puan { get; set; }


        //Sınıf listesi yol şeklinde geldiği için zorunlu bir ezme işlemi gerçekleştirdim.
        public override string ToString()
        {
            return Ad + " " + Soyad;
        }
    }
}
