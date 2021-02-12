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
            public void methodZaloguj(string tresc, MyEnum myEnum);
        }

        class LoggerKonsola : ILoger
        {
            public void methodZaloguj(string tresc, MyEnum myEnum)
            {
                Console.WriteLine($"{DateTime.Now} {myEnum} \"{tresc}\"");
            }
        }

        class LoggerPlik : ILoger
        {
            public void methodZaloguj(string tresc, MyEnum myEnum)
            {
                string folderName = Environment.CurrentDirectory;
                string pathFolder = Path.Combine(folderName, "Logger");
                string path = Path.Combine(pathFolder, $"{myEnum}.txt");

                if ((!File.Exists(path)) || (!Directory.Exists(pathFolder)))
                {
                    Directory.CreateDirectory(pathFolder);
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.WriteLine($"{DateTime.Now} : {myEnum} \"{tresc}\"");
                    }
                }
                else
                {
                    using (StreamWriter sw = File.AppendText(path))
                    {
                        sw.WriteLine($"{DateTime.Now} : {myEnum} \"{tresc}\"");
                    }
                }
            }
        }

        public void Zad3()
        {
            LoggerKonsola loggerKonsola = new LoggerKonsola();
            loggerKonsola.methodZaloguj("Blad rozdzielacza YVC3", MyEnum.error);
            loggerKonsola.methodZaloguj("Stara wersja systemu", MyEnum.info);
            loggerKonsola.methodZaloguj("Prasa nie jest zaryglowana", MyEnum.warning);

            LoggerPlik loggerPlik = new LoggerPlik();
            loggerPlik.methodZaloguj("Blad rozdzielacza YVC3", MyEnum.error);
            loggerPlik.methodZaloguj("Stara wersja systemu", MyEnum.info);
            loggerPlik.methodZaloguj("Prasa nie jest zaryglowana", MyEnum.warning);
        }
    }
}