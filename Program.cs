using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace liste_2026_39b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n=99;

            while(n!=0)
            {
                Console.WriteLine("Odaberite:");
                Console.WriteLine("1: Unos");
                Console.WriteLine("2: Snimi");
                Console.WriteLine("3: Ucitaj");
                Console.WriteLine("4: Ispis");
                Console.WriteLine("0: Kraj");
                n = Convert.ToInt32(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        graf_l novi = new graf_l();
                        novi.
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
