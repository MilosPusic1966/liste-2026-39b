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
            // niz
            int[] a = new int[10];
            a[2] = 8;
            a[1] = 7;
            // Console.WriteLine(a[1]);

            // matrica
            int[,] b = new int[3, 4];
            b[1, 1] = 5;
            // Console.WriteLine(b[1,1]);

            /*
            // Lista
            List<string> lista = new List<string>();
            lista.Add("Milos");
            lista.Add("Ana");
            lista.Add("Milica");
            Console.WriteLine(lista[1]);
            lista.RemoveAt(1);
            Console.WriteLine(lista[1]);
            */

            /*
            // stek
            Stack<int> c;
            c = new Stack<int>();
            c.Push(5);
            c.Push(3);
            c.Push(4);
            Console.WriteLine(c.Peek());
            c.Pop();
            Console.WriteLine(c.Peek());
            c.Pop();
            Console.WriteLine(c.Pop());
            Console.WriteLine(c.Count);
            */

            /*
            // red
            Queue<string> d;
            d = new Queue<string>();
            d.Enqueue("Milos");
            d.Enqueue("Jelena");
            d.Enqueue("Maja");
            Console.WriteLine(d.Count);
            
            Console.WriteLine(d.Peek());
            d.Dequeue();
            Console.WriteLine(d.Peek());
            */

            // niz listi
            List<int> sused = new List<int>();
            List<int>[] grane = new List<int>[5];
            for (int i = 0; i < 5; i++)
            {
                grane[i] = new List<int>();
            }
            grane[2].Add(3);
            grane[2].Add(4);
            // Console.WriteLine(grane[2][1]);
            
            // niz listi struktura
            List<grana>[] graf = new List<grana>[5];
            for (int i = 0; i < 5; i++)
            {
                graf[i] = new List<grana>();
            }
            grana nova = new grana();
            nova.kraj = 2;
            nova.tezina = 10;
            graf[0].Add(nova);
            
            nova = new grana();
            nova.kraj = 3;
            nova.tezina = 5;
            graf[0].Add(nova);
            Console.WriteLine(graf[0][1].kraj);
        }
    }
}
