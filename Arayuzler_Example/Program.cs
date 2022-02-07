using System;

namespace Arayuzler_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Focus focus =  new Focus();
            Console.WriteLine(focus.marka().ToString());
            Console.WriteLine(focus.renk().ToString());
            Console.WriteLine(focus.tekerlekSayisi());

            Civic civic =  new();
            Console.WriteLine(civic.marka().ToString());
            Console.WriteLine(civic.renk().ToString());
            Console.WriteLine(civic.tekerlekSayisi());

        }
    }
}