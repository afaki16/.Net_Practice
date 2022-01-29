using System;

namespace Algoritma_1
{

    class Program
    {

        static void Main(string[] args)
        {
            İslemler i = new İslemler();
            i.Soru_1();
            i.Soru_2();
            i.Soru_3();
            i.Soru_4();
        }


    }




    public class İslemler
    {
        public void Soru_1()
        {
            Console.WriteLine("Lütfen pozitif bir sayı giriniz: ");
            int n = int.Parse(Console.ReadLine());
            int m = 0;
            int[] sayilar = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Lütfen sayı giriniz: ");
                m = int.Parse(Console.ReadLine());
                sayilar[i] = m;
            }
            Console.WriteLine("Girilen çift sayılar :");
            foreach (var item in sayilar)
            {
                if (item % 2 == 0)
                    Console.WriteLine(item);
            }


        }

        public void Soru_2()
        {
            Console.WriteLine("Lüften 1. sayıyı giriniz :");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Lüften 2. sayıyı giriniz :");
            int m = int.Parse(Console.ReadLine());
            int k = 0;
            int[] sayilar = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Lütfen sayı giriniz: ");
                k = int.Parse(Console.ReadLine());
                sayilar[i] = k;
            }

            Console.WriteLine("İkinci sayıya eşit veya tam bölünen sayılar :");
            foreach (var item in sayilar)
            {
                if (item % m == 0 || item == m)
                    Console.WriteLine(item);
            }

        }
        public void Soru_3()
        {
            Console.WriteLine("Lütfen pozitif bir sayı giriniz: ");
            int n = int.Parse(Console.ReadLine());
            string m;
            string[] kelimeler = new string[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Lütfen kelime giriniz ");
                m = Console.ReadLine();
                kelimeler[i] = m;
            }
            Console.WriteLine("Girilen kelimeler sondan başa göre ");
            Array.Reverse(kelimeler);
            foreach (var item in kelimeler)
            {
                Console.WriteLine(item);
            }
        }
        public void Soru_4()
        {
            Console.WriteLine("Lüften bir cümle yazınız : ");
            string m = Console.ReadLine();
            string[] kelimeler = m.Split(" ");
            int sayi = 0;
            Console.WriteLine("Toplam kelime sayısı :" + kelimeler.Length);
            for (int i = 0; i < kelimeler.Length; i++)
            {
                char[] harfler = kelimeler[i].ToCharArray();
                sayi += harfler.Length;
            }
            Console.WriteLine("Toplam harf sayısı :" + sayi);
        }
    }
}
