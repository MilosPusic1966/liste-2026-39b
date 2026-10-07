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
            List<int>[] a = new List<int>[3];
            a[0] = new List<int>();
            a[1] = new List<int>();
            a[2] = new List<int>();
            a[1].Add(5);

            List<string> ime;
            ime = new List<string>();
            ime.Add("Milos");
            ime.Add("Jelena");
            ime.Add("Maja");

            Console.WriteLine(ime[1]);
        }
    }
}
