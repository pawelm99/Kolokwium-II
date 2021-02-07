using System;
using System.Collections.Generic;

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


    class Zadaniee1
    {
        static void Main(string[] args)
        {
            DateTime date1 = new DateTime(2008, 6, 1, 7, 47, 0);
            Random rnd = new Random();
            List<Wiadomosc> wiadomoscsi = new List<Wiadomosc>()
            {
                new Wiadomosc("Wiadomosc1", date1.AddDays(rnd.Next(0, 10))),
                new Wiadomosc("Wiadomosc2", date1.AddDays(rnd.Next(0, 10))),
                new Wiadomosc("Wiadomosc3", date1.AddDays(rnd.Next(0, 10))),
                new Wiadomosc("Wiadomosc4", date1.AddDays(rnd.Next(0, 10))),
                new Wiadomosc("Wiadomosc5", date1.AddDays(rnd.Next(0, 10))),
                new Wiadomosc("Wiadomosc6", date1.AddDays(rnd.Next(0, 10))),
                new Wiadomosc("Wiadomosc7", date1.AddDays(rnd.Next(0, 10))),
                new Wiadomosc("Wiadomosc8", date1.AddDays(rnd.Next(0, 10))),
                new Wiadomosc("Wiadomosc9", date1.AddDays(rnd.Next(0, 10))),
                new Wiadomosc("Wiadomosc10", date1.AddDays(rnd.Next(0, 10))),
            };
            foreach (var item in wiadomoscsi)
            {
                Console.WriteLine(item);
            }
            var z = method(wiadomoscsi,"Wiadomosc1");
            
        }

        private static bool method(List<Wiadomosc> a,string slowo)
        {
            for (int i = 0; i < a.Count; i++)
            {
                if (a[i].Tresc == slowo)
                {
                    Console.WriteLine("Slowo Znajleziono !");
                    return true;
                }
                else
                {
                    Console.WriteLine("Nie znaleziono w liscie slowa");
                    return false;
                }
            }

            return false;
        }
    }