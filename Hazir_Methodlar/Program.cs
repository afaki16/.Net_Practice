using System;

namespace Hazir_Methodlar // Note: actual namespace depends on the project name.
{
     class Program
    {
        static void Main(string[] args)
        {
            string degiskenler = "Ahmet Alperen Fakı";
            string degiskenler2 = "Ahmet Alperen";
            string[] str =degiskenler.Split(' ');
            

            Console.WriteLine(degiskenler.Length);
            Console.WriteLine(degiskenler.ToUpper());
            Console.WriteLine(degiskenler.ToLower());
            Console.WriteLine(String.Concat(degiskenler," Selam"));
            Console.WriteLine(degiskenler.CompareTo(degiskenler2));
            Console.WriteLine(String.Compare(degiskenler,degiskenler2,true));
            Console.WriteLine(String.Compare(degiskenler,degiskenler2,false));
            Console.WriteLine(degiskenler.Contains(degiskenler2));
            Console.WriteLine(degiskenler.EndsWith("Fakı"));
            Console.WriteLine(degiskenler.StartsWith("Ahmet"));
            Console.WriteLine(degiskenler.IndexOf("Alperen"));
            Console.WriteLine(degiskenler.Insert(0,"Selam "));
            Console.WriteLine(degiskenler.LastIndexOf("k"));
            Console.WriteLine(degiskenler + degiskenler2.PadLeft(20));
            Console.WriteLine(degiskenler + degiskenler2.PadRight(20));
            Console.WriteLine(degiskenler.Remove(10));
            Console.WriteLine(degiskenler.Remove(5,3));
            Console.WriteLine(degiskenler.Replace("Ahmet","Alperen"));
            Console.WriteLine(degiskenler.Replace(" ",""));
            Console.WriteLine(degiskenler.Split(' ')[1]);
            Console.WriteLine(degiskenler.Substring(3));
            Console.WriteLine(degiskenler.Substring(3,4));
            Console.WriteLine(str[0]);

            


            



        }
    }
}
