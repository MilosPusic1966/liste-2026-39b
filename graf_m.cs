using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace liste_2026_39b
{
    internal class graf_m
    {
        public string[] cvor;
        public int?[,] matrica;
        public static graf_m LM(graf_l stari)
        {
            graf_m novi = new graf_m();
            novi.cvor = new string[stari.cvor.Length];
            for (int i = 0; i < stari.cvor.Length; i++)
            {
                novi.cvor[i] = stari.cvor[i];
            }
            novi.matrica = new int?[stari.cvor.Length, stari.cvor.Length];
            for (int vrsta = 0; vrsta < stari.cvor.Length; vrsta++)
            {
                for (int red_br = 0; red_br < stari.lista[vrsta].Count; red_br++)
                {
                    novi.matrica[vrsta, stari.lista[vrsta][red_br].kraj] = stari.lista[vrsta][red_br].tezina;
                }
            }
            return novi;
        }
        public static bool neusmeren(graf_m ulaz) { 
            bool rez = true;
            for (int i = 0; i < ulaz.cvor.Length; i++)
            {
                for (int j = i+1; j < ulaz.cvor.Length; j++)
                {
                    if (ulaz.matrica[i, j] != ulaz.matrica[j, i])
                    {
                        rez = false;
                        break;
                    }
                }
                if (rez == false)
                {
                    break;
                }
            }
            return rez;
        }
        public static bool neusmeren(graf_l ulaz)
        {
            bool rez = true;
            graf_m pomocni = LM(ulaz);
            rez = neusmeren(pomocni);
            return rez;
        }
    }
}
