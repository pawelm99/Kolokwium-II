using System;
using System.Collections;
using System.Collections.Generic;

namespace Kolokwium_II_Przgotowanie
{
    class Program
    {
        delegate void Del<Type,Type2>(Type x, Type2 y);

        public static Action<int,int> _action;
        public static Func<int, int, int> Func;
        
        static void method(int x, int y)
        {
            Console.WriteLine(x);
        }

        static void method2(Del<int,int> x, int z)
        {
            x(3, 4);
        }

        static void method3(int x, int y)
        {
            Console.WriteLine(x);
        }

        static int method4(int x, int y)
        {
            
            return y;
        }

        //public Action<Person> del;
        
        static void Main(string[] args)
        {
            Del<int,int> del = method; 
            method2(del,3); //przekaznaie delegata zainicjalizowanego

            _action = method3;
            _action(3, 4);

            Func = method4;
            Console.WriteLine(Func(3, 4));
            

        }
    }
}

//Action<Type,Type> - dla void fun(typ,typ)
//Func<Type,ResultType> - dla Type fun(typ,typ) ostatni parametr zwraca


/*1. Kolekcje generyczne (m.in. List, Stack, Queue, Dictionary). !
2. LINQ - funkcje (m.in. ale nie tylko: select, where, orderby (sort), skip/take, sum/min/max/avg, first, single), przetwarzanie kolekcji, chain'owanie.
3. Interfejsy - systemowe i własne, Implementacja
4. Dziedziczenie - tworzenie hierarchii, odwołania do klas bazowych, funkcje wirtualne i ich nadpisywanie
5. Klasy i interfejsy generyczne (dla jednego lub wielu typów). Tworzenie instancji typów generycznych.
6. Polimorfizm
7. Eventy i event handlery, delegaty
8. Tworzenie i czytanie plików (tekstowych).*/