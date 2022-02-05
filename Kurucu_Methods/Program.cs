using System;

namespace Kurucu_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Calisanlar calisan = new Calisanlar("Alperen","Fakı",11,"IT");
            calisan.CalisanBilgileri();
            Console.WriteLine("*********");
            calisan.Ad = "Merve";
            calisan.Soyad = "Çakır";
            calisan.No = 33;
            calisan.Departman = "Satış";
            calisan.CalisanBilgileri();
            Console.WriteLine("*********");
            Calisanlar calisanlar3 = new Calisanlar("Ayşenur","FAKI");
            calisanlar3.CalisanBilgileri();
        }
    }

    class Calisanlar
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;
         
        public Calisanlar(string ad, string soyad, int no, string departman)
        {
           this.Ad=ad;
           this.Soyad=soyad;
           this.No=no;
           this.Departman=departman;

        }
        public Calisanlar(){}
         public Calisanlar(string ad, string soyad)
         {
             this.Ad=ad;
             this.Soyad=soyad;

         }
        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışan Adı : {0}", Ad);
            Console.WriteLine("Çalışan Soyadı : {0}", Soyad);
            Console.WriteLine("Çalışan Numarası : {0}", No);
            Console.WriteLine("Çalışan Departmanı : {0}", Departman);

        }



    }
}