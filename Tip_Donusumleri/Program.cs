using System;

namespace Tip_Donusumleri
{
    class Program
    {
        static void Main(string[] args)
        {
            byte x = 1;
            sbyte y = 2;
            short z = 3;

            int v = x+y+z;
            Console.WriteLine("v:"+v);

            long a = v;
            Console.WriteLine("a:"+ a);

            float b = a;
            Console.WriteLine("b:"+b);

            string c = "alperen";
            char d = 'f';
            object e = c+d+v;
            Console.WriteLine("e:"+e);

           Console.WriteLine("------------------------");
          

           int r = 3;
           byte t = (byte)r;
           Console.WriteLine("t:"+t);
           
           float j = 5.2f;
           byte l =(byte)j;
           Console.WriteLine("l:"+l);

           Console.WriteLine("------------------------");

           
        
        }
    }
}
