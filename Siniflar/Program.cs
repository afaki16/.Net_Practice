using System;

namespace Siniflar // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            Calisanlar calisan = new Calisanlar();
            calisan.Ad = "Alperen";
            calisan.Soyad = "FAKI";
            calisan.No = 11;
            calisan.Departman = "IT";
            calisan.CalisanBilgileri();
            Console.WriteLine("*********");
            calisan.Ad = "Merve";
            calisan.Soyad = "Çakır";
            calisan.No = 33;
            calisan.Departman = "Satış";
            calisan.CalisanBilgileri();
        }
    }

    class Calisanlar
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;

        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışan Adı : {0}", Ad);
            Console.WriteLine("Çalışan Soyadı : {0}", Soyad);
            Console.WriteLine("Çalışan Numarası : {0}", No);
            Console.WriteLine("Çalışan Departmanı : {0}", Departman);

        }



    }
}