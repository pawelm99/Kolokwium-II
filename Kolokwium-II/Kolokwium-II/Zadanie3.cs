using System;
using System.IO;

namespace Zadanie3
{
    class Program
    {
        enum MyEnum
        {
            info,
            warning, 
            error
        }

        interface ILoger
        {
            public void methodZaloguj(string tresc,MyEnum myEnum);
        }

        class LoggerKonsola : ILoger 
        {
            public void methodZaloguj(string tresc, MyEnum myEnum)
            {
                Console.WriteLine($"{DateTime.Now} {myEnum}: {"jaki blad"}");
            }
        }

        class LoggerPlik : ILoger
        {
            public void methodZaloguj(string tresc, MyEnum myEnum)
            {
                string path = Path.Combine(Environment.CurrentDirectory, DateTime.Now.Millisecond + "plik.txt");
                if (!File.Exists(path))
                {
                    
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.WriteLine($"{DateTime.Now} : {myEnum}");
                        sw.WriteLine("Dziekujemy i zapraszamy ponownie");
                    }	
                }
            }
        }
        
        static void Zadanie3(string[] args)
        {

        }
    }
    
}
