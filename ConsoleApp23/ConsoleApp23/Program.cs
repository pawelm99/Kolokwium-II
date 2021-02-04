using System;
using System.Text.RegularExpressions;

namespace ConsoleApp23
{
    class Program
    {
        static void Main(string[] args)
        {
            PolePowierzchniObjectoscKuli();
            string tekst = "supersuper fghfgsuperbhfn ";
            var ilosc = FunkcjaPrzyjmijTekst(tekst);
            Console.WriteLine("Ile razy Super : {0} ", ilosc);

            Restauracja restauracja = new Restauracja(10);
            restauracja.ZarezerwujStolik(ref restauracja._stoliki[0]);
            restauracja.ZarezerwujStolik(ref restauracja._stoliki[1]);
            restauracja.ZarezerwujStolik(ref restauracja._stoliki[2]);
            restauracja.ZarezerwujStolik(ref restauracja._stoliki[3]);
            restauracja.ZarezerwujStolik(ref restauracja._stoliki[4]);
            restauracja.ZarezerwujStolik(ref restauracja._stoliki[5]);
            restauracja.ZarezerwujStolik(ref restauracja._stoliki[6]);
            restauracja.ZarezerwujStolik(ref restauracja._stoliki[7]);
            restauracja.ZarezerwujStolik(ref restauracja._stoliki[8]);
            restauracja.ZarezerwujStolik(ref restauracja._stoliki[9]);
            restauracja.OpuscStolik(ref restauracja._oceny[0], ref restauracja._opinie[0]);
            Console.WriteLine("Ilosc wolnych stolikow: {0}",restauracja.IloscMWolnychStolikow);
            

        }

        private static int FunkcjaPrzyjmijTekst(string tekst)
        {
            Regex rgx = new Regex("super");
            string sentence = tekst;
            var z = 0;
            foreach (Match match in rgx.Matches(sentence))
            {
                z++;
            }
            return z;
        }


        static void PolePowierzchniObjectoscKuli()
        {
            var r = "4"; //test
            bool udalosie = int.TryParse(r, out int rP);
            if (udalosie)
            {
                Console.WriteLine("Udalo sie sparsowac");
            }
            else
            {
                Console.WriteLine("Nie dualo sie sparsowac");
            }

            double P = 4 * Math.PI * rP * rP;
            double O = 4 / 3.0 * Math.PI * rP * rP;
            Console.WriteLine("Pole powierzchni: {0} Objętość kuli: {1}", P, O);
        }
    }
}