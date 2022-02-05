using System;

namespace Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Gunler.Pazar);
            Console.WriteLine((int)Gunler.Salı);

            Console.WriteLine("Hava Sıcaklığını Giriniz:");
            int n = int.Parse(Console.ReadLine());

            if (n<=(int)HavaDurumu.Normal)
            {
            Console.WriteLine("Hava normalden daha kötü durumda...");
            }
            else if(n >= (int)HavaDurumu.Sicak)
            {
            Console.WriteLine("Dışarısı sıcak...");
            }
            else if(n >= (int)HavaDurumu.CokSicak)
            {
            Console.WriteLine("Evde otur..");
            }
        }
    }

    enum Gunler
    {
      Pazartesi=1,
      Salı,
      Çarşamba,
      Perşembe,
      Cuma,
      Cumartesi,
      Pazar


    }
    enum HavaDurumu
    {
        Soğuk=5,
        Normal=20,
        Sicak=25,
        CokSicak=35
    }
}