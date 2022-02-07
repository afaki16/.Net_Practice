using System;

namespace Arayuzler_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Focus focus = new Focus();
            Console.WriteLine(focus.marka().ToString());
            Console.WriteLine(focus.renk().ToString());
            Console.WriteLine(focus.tekerlekSayisi());

            Console.WriteLine("************");

            Civic civic = new();
            Console.WriteLine(civic.marka().ToString());
            Console.WriteLine(civic.renk().ToString());
            Console.WriteLine(civic.tekerlekSayisi());

            Console.WriteLine("************");

            NewFocus newfocus = new NewFocus();
            Console.WriteLine(newfocus.marka().ToString());
            Console.WriteLine(newfocus.renk().ToString());
            Console.WriteLine(newfocus.tekerleksayisi());

            Console.WriteLine("************");

            NewCivic newcivic = new();
            Console.WriteLine(newcivic.marka().ToString());
            Console.WriteLine(newcivic.renk().ToString());
            Console.WriteLine(newcivic.tekerleksayisi());
        }
    }
}