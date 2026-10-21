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
            lista = new List<grana>[n];
            for (int i = 0; i < n; i++)
            {
                lista[i] = new List<grana>();
                Console.WriteLine($"Sused cvora {i}");
                int sused = Convert.ToInt32(Console.ReadLine());
                while (sused != -1)
                {
                    Console.WriteLine($"Tezina grane {i} - {sused}");
                    int tezina = Convert.ToInt32(Console.ReadLine());
                    grana nova = new grana();
                    nova.kraj = sused;
                    nova.tezina = tezina;
                    lista[i].Add(nova);
                    Console.WriteLine($"Sused cvora {i}");
                    sused = Convert.ToInt32(Console.ReadLine());
                }
            }
            return;
        } 
        public void Ispis()
        {
            for (int i = 0; i < cvor.Length; i++)
            {
                Console.WriteLine("Cvor " + i + "=" + cvor[i]);
                foreach (grana g in lista[i])
                {
                    Console.WriteLine($"Sused {g.kraj} tezina {g.tezina}");
                }
            }
            /*
             public void Snimi(string ime)
{
    System.IO.StreamWriter sw = new System.IO.StreamWriter(ime);
    sw.WriteLine(cvor.Length);
    for (int i = 0; i < cvor.Length; i++)
    {
        sw.WriteLine(cvor[i]);
    }
    for (int i = 0; i < cvor.Length; i++)
    {
        foreach (grana g in lista[i])
        {
            sw.WriteLine($"{i} {g.kraj} {g.tezina}");
        }
    }
    sw.Close();
}
public void Ucitaj(string ime)
{
    System.IO.StreamReader sr = new System.IO.StreamReader(ime);
    int n = Convert.ToInt32(sr.ReadLine());
    cvor = new string[n];
    for (int i = 0; i < n; i++)
    {
        cvor[i] = sr.ReadLine();
    }
    lista = new List<grana>[n];
    for (int i = 0; i < n; i++)
    {
        lista[i] = new List<grana>();
    }
    while (!sr.EndOfStream)
    {
        string[] delovi = sr.ReadLine().Split(' ');
        int pocetak = Convert.ToInt32(delovi[0]);
        int kraj = Convert.ToInt32(delovi[1]);
        int tezina = Convert.ToInt32(delovi[2]);
        grana nova = new grana();
        nova.kraj = kraj;
        nova.tezina = tezina;
        lista[pocetak].Add(nova);
    }
    sr.Close();
}

              
             * */
        }

    }
}
