using System;

namespace ConsoleApp23
{
    public class Restauracja
    {
        public bool[] _stoliki;
        public string[] _opinie;
        public int[] _oceny;
        public int IloscMWolnychStolikow {
            get
            {
                var zlicz = 0;
                for (int i = 0; i < _stoliki.Length; i++)
                {
                    if (_stoliki[i]== false)
                    {
                        zlicz++;
                    }
                }
                return zlicz;
            }
            }

        public Restauracja(int iloscStolikow,int opinie =3,int oceny = 10)
        {
            this._stoliki = new bool[iloscStolikow];
            this._opinie = new string[opinie];
            this._oceny = new int[oceny];
        }
        public void ZarezerwujStolik(ref bool _stoliki)
        {
            _stoliki = true;
        }
        
        public void OpuscStolik(ref int _ocenyMet,ref string _opinieMet)
        {
            Console.Write("Wpisz opinie: ");
           _opinieMet  = Console.ReadLine();
           Console.Write("Wpisz ocene: ");
           _ocenyMet = Console.Read();

        }

    }

}