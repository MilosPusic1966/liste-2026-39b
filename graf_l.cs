using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace liste_2026_39b
{
    internal class graf_l
    {
        public string[] cvor;
        public List<grana>[] lista;
        public graf_l() { }
        public void Unos()
        {
            Console.WriteLine("Broj cvorova=");
            int n = Convert.ToInt32(Console.ReadLine());
            cvor = new string[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Cvor " + i + "=");
                cvor[i] = Console.ReadLine();
            }

            return;
        }
    }
}
