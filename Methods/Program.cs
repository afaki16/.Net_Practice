using System;

namespace Methods // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
           int a = 2;
           int b = 3;
           Console.WriteLine(a+b);
           Metotlar metotlar = new Metotlar();
           int result = Toplam(a,b); 
           Console.WriteLine(result);
           int result2 =  metotlar.ArtveTop(ref a, ref b);
           
           metotlar.Sonuclar(Convert.ToString(result));
           metotlar.ArtveTop(ref a, ref b);
           metotlar.Sonuclar(Convert.ToString(result2));
           metotlar.Sonuclar(Convert.ToString(a+b)); 
        }
 
         static int Toplam(int x, int y)
         {
             
               return(x*y);

         }         

    }

   class Metotlar
   {
       public void Sonuclar(string veri)
       {
             Console.WriteLine(veri);
       }

       public int ArtveTop (ref int j, ref int k)
       { 
           j++;
           k++;
           return j+k;

       }
   }

}