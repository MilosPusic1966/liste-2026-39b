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
            graf_l novi=null;

            while (n!=0)
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
                    case 0:
                        Console.WriteLine("Kraj");
                        break;
                    case 1:
                        novi = new graf_l();
                        novi.Unos();
                        break;
                    case 4:
                        if (novi != null)
                        {
                            novi.Ispis();
                        }
                        break;
                    default:
                        break;
                }
                if (n == 0)
                {
                    break;
                }
            }
        }
    }
}
