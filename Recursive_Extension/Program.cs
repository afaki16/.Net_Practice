using System;

namespace Recursive_Extension
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 1;
            for (int i = 1; i < 5; i++)
            {
                result *= 3;
            }
            Console.WriteLine(result);
            İslemler islemler = new();
            Console.WriteLine(islemler.Expo(3, 4));


            string ifade = "Alperen Fakı";
            bool sonuc = ifade.CheckSpaces();
            Console.WriteLine(sonuc);
            if (sonuc)
            {
                Console.WriteLine(ifade.RemoveWhiteSpaces());
                 Console.WriteLine(ifade.MakeLowerCase());
                 Console.WriteLine(ifade.MakeUpperCase());
                
            }

            int[] diziler = {5,6,7,3,5,8,34,67};
            diziler.SortArray();
            diziler.Yazdir();

            int c = 7;
            Console.WriteLine(c.IsEvenNumber());
            Console.WriteLine(ifade.GetFirst());
        }

    }
    public class İslemler
    {
        public int Expo(int sayi, int us)
        {
            if (us < 2)
                return sayi;
            return Expo(sayi, us - 1) * sayi;

        }

    }
    public static class Extension
    {
        public static bool CheckSpaces(this string param)
        {
           return param.Contains("");
        }

        public static string RemoveWhiteSpaces(this string param)
        {
            string[] dizi = param.Split(" ");
            return string.Join("",dizi);
        }
        public static string MakeUpperCase(this string param)
        {
            return param.ToUpper();
        }
        public static string MakeLowerCase(this string param)
        {
            return param.ToLower();
        }

        public static int[] SortArray(this int[] param)
        {
            Array.Sort(param);
            return param;
        }
        public static void Yazdir(this int[] param)
        {
            foreach (int item in param)
            {
                Console.WriteLine(item);
            }
            
        }
        public static bool IsEvenNumber(this int param)
        {
            
            return param%2==0;
        }
        public static string GetFirst(this string param)
        {
             return param.Substring(0,1);
            
        }
    }

}