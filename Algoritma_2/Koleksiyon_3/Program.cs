using System;
using System.Collections;

namespace Koleksiyon_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir cümle giriniz : ");
            string n = Console.ReadLine();
            ArrayList sesli = new ArrayList();
            char[] sabit_sesliler = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };

            char[] harfler = new char[n.Length];
            harfler =n.ToCharArray();

            foreach (char giris in harfler)
            {
                foreach (char sabit in sabit_sesliler)
                {
                    if(giris==sabit)
                    sesli.Add(giris);
                }
            }
            foreach (var item in sesli)
            {
                Console.Write(item + " ");
            }
            
             	
       
        }
    }
}