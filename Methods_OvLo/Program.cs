using System;

namespace Methods_OvLo
{
    class Program
    {
        static void Main(string[] args)
        {
            Metotlar m = new Metotlar();
            string sayi = "222";

            bool sonuc = int.TryParse(sayi, out int yenisayi);
            if (sonuc == true)
            {
                Console.WriteLine("True");
                Console.WriteLine(yenisayi);
            }
            else
            {
                Console.WriteLine("False");
            }

            int t =345;


            m.Topla(1, 6, out int newresult);
            Console.WriteLine(newresult);
            
            m.Screen(t);
            m.Screen("abc","def");



        }

        class Metotlar
        {
            public void Topla(int a, int b, out int toplam)
            {
                toplam = a + b;

            }

            public void Screen(string veri)
            {
                Console.WriteLine(veri);

            }
            public void Screen(int veri)
            {
                Console.WriteLine(veri);

            }
            public void Screen(string veri1, string veri2)
            {
                Console.WriteLine(veri1 + veri2);

            }




        }
    }
}