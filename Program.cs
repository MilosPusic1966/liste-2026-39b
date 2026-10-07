using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace liste_2026_39b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> ime;
            ime = new List<string>();
            ime.Add("Milos");
            ime.Add("Jelena");
            ime.Add("Maja");

            Console.WriteLine(ime[1]);
        }
    }
}
