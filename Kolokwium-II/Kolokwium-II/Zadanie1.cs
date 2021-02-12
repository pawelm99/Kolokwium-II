using System;
using System.Collections.Generic;

namespace Zadanie1
{
    public class Wiadomosc
    {
        public string Tresc { get; set; }
        public DateTime Czas { get; set; }

        public Wiadomosc(string tresc, DateTime czas)
        {
            Tresc = tresc;
            Czas = czas;
        }


        public override string ToString()
        {
            return $"{nameof(Tresc)}: {Tresc}, {nameof(Czas)}: {Czas}";
        }
    }


    class  Program
    {
        public void Zad1()
        {
            Random rnd = new Random();
            DateTime date1 = new DateTime(rnd.Next(1, 2020), rnd.Next(1,12), rnd.Next(1,20), rnd.Next(1,24), rnd.Next(0,60), rnd.Next(0,60));
            List<Wiadomosc> wiadomoscsi = new List<Wiadomosc>()
            {
                new Wiadomosc("Wiadomosc1", new DateTime(rnd.Next(1, 2020), rnd.Next(1,12), rnd.Next(1,20), rnd.Next(1,24), rnd.Next(0,60), rnd.Next(0,60))),
                new Wiadomosc("Wiadomosc2", new DateTime(rnd.Next(1, 2020), rnd.Next(1,12), rnd.Next(1,20), rnd.Next(1,24), rnd.Next(0,60), rnd.Next(0,60))),
                new Wiadomosc("Wiadomosc3", new DateTime(rnd.Next(1, 2020), rnd.Next(1,12), rnd.Next(1,20), rnd.Next(1,24), rnd.Next(0,60), rnd.Next(0,60))),
                new Wiadomosc("Wiadomosc4", new DateTime(rnd.Next(1, 2020), rnd.Next(1,12), rnd.Next(1,20), rnd.Next(1,24), rnd.Next(0,60), rnd.Next(0,60))),
                new Wiadomosc("Wiadomosc5", new DateTime(rnd.Next(1, 2020), rnd.Next(1,12), rnd.Next(1,20), rnd.Next(1,24), rnd.Next(0,60), rnd.Next(0,60))),
                new Wiadomosc("Wiadomosc6", new DateTime(rnd.Next(1, 2020), rnd.Next(1,12), rnd.Next(1,20), rnd.Next(1,24), rnd.Next(0,60), rnd.Next(0,60))),
                new Wiadomosc("Wiadomosc7", new DateTime(rnd.Next(1, 2020), rnd.Next(1,12), rnd.Next(1,20), rnd.Next(1,24), rnd.Next(0,60), rnd.Next(0,60))),
                new Wiadomosc("Wiadomosc8", new DateTime(rnd.Next(1, 2020), rnd.Next(1,12), rnd.Next(1,20), rnd.Next(1,24), rnd.Next(0,60), rnd.Next(0,60))),
                new Wiadomosc("Wiadomosc9", new DateTime(rnd.Next(1, 2020), rnd.Next(1,12), rnd.Next(1,20), rnd.Next(1,24), rnd.Next(0,60), rnd.Next(0,60))),
                new Wiadomosc("Wiadomosc10", new DateTime(rnd.Next(1, 2020), rnd.Next(1,12), rnd.Next(1,20), rnd.Next(1,24), rnd.Next(0,60), rnd.Next(0,60))),
           
            };
            foreach (var item in wiadomoscsi)
            {
                Console.WriteLine(item);
            }

            var wyszukaniePoSlowie = WyszukaniePoSlowie(wiadomoscsi, "osc");
            var wyszukaniePoDacie = WyszukaniePoDacie(wiadomoscsi, date1);
        }

        private static bool WyszukaniePoSlowie(List<Wiadomosc> a, string slowo)
        {
            int matchNumber = 0;
            for (int i = 0; i < a.Count; i++)
            {
                if ((System.Text.RegularExpressions.Regex.IsMatch(a[i].Tresc, slowo)))
                {
                    matchNumber++;
                    continue;
                }
            }

            Console.WriteLine("Znaleziono pasujacych: {0} do słowa: {1}!", matchNumber, slowo);
            return true;
        }

        private static bool WyszukaniePoDacie(List<Wiadomosc> a, DateTime dateTime)
        {
            int matchNumber = 0;
            for (int i = 0; i < a.Count; i++)
            {
                if ((System.Text.RegularExpressions.Regex.IsMatch(a[i].Czas.ToString(), dateTime.ToString())))
                {
                    matchNumber++;
                    continue;
                }
            }

            Console.WriteLine("Znaleziono pasujacych: {0} po dacie: {1}!", matchNumber, dateTime);
            return true;
        }
    }
}