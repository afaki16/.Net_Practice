using System;
using System.Collections;

namespace ArrayLists // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList liste = new ArrayList();
            liste.Add("Alperen");
            liste.Add(6);
            liste.Add(true);
            liste.Add('A');


            Console.WriteLine(liste[0]);
            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("**********");
            string[] renkler = {"Sarı","Kırmızı","Yeşil","Mavi"};
            List<int> sayilar = new List<int>(){1,2,56,4,66,8};
            liste.AddRange(renkler);
            liste.AddRange(sayilar);
            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }
             liste.Sort(); //Bütün elemanların aynı değişken türünde olması gerekir.
             liste.BinarySearch(2); //Sort işleminden sonra kullanılır.
             liste.Reverse(); // Listeyi ters sıralar
             liste.Clear(); // Bütün listeyi siler.

        }
    }
}