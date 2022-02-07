using System;
using static Bitkiler;
using static Hayvanlar;

namespace Inheritances
{
    class Program
    {
        static void Main(string[] args)
        {
           TohumluBitkiler tohumlubitki = new TohumluBitkiler();
           tohumlubitki.TohumlaCogalma();

           Kuslar marti = new Kuslar();
           marti.Ucmak();

        }
    }
}