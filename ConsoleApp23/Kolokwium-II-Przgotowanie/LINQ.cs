using System;
using System.Collections.Generic;
using System.Linq;

namespace Kolokwium_II_Przgotowanie
{
    class LINQ
    {
        void abce()
        {
            List<Person> list = new List<Person>()
            {
                new Person("Tomek"),
                new Person("Tomek1"),
                new Person("Tomek2"),
                new Person("Tomek3"),
                new Person("Tomek4"),
                new Person("Tomek5")
            };

            List<Person> list2 = new List<Person>()
            {
                new Person("Tomek"),
            };
//Intersect - krzyżój(Tomek) jesli jest to wyswietli
//Except - usunie Czesc Tomek
//Prepend doda na początek

            var collection = list.Select(x => x)
                .Single();

            var collection2 = from person in list
                orderby person.name descending
                where person.name.Length > 5
                select person;

            Console.WriteLine(collection);
            /*foreach (var item in collection)
          {
              Console.WriteLine(item);
          }*/
        }
    }
}