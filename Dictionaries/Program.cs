using System;

namespace Dictionaries 
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,string> kullanicilar = new Dictionary<int, string>();

            kullanicilar.Add(1,"Alperen");
            kullanicilar.Add(12,"Ahmet");
            kullanicilar.Add(34,"Özge");
            kullanicilar.Add(45,"İlayda");

            Console.WriteLine(kullanicilar[1]);
            foreach (var item in kullanicilar)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(kullanicilar.Count);

            Console.WriteLine(kullanicilar.ContainsKey(1));
            Console.WriteLine(kullanicilar.ContainsValue("Alperen"));

            Console.WriteLine(kullanicilar.Remove(12));
             foreach (var item in kullanicilar)
            {
                Console.WriteLine(item.Key);
            }
             foreach (var item in kullanicilar.Values)
            {
                Console.WriteLine(item);
            }

        }
    }
}