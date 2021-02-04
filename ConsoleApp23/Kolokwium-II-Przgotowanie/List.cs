using System;
using System.Collections.Generic;

namespace Kolokwium_II_Przgotowanie
{
    public class List
    {
        public void Lists()
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
            list.Add(new Person("Alina"));

            list.Insert(3,new Person("e"));
            /*name: Tomek
            name: Tomek1
            name: Tomek2
            name: Tomek3
            name: Tomek4
            name: Tomek5
            name: Alina
            */
            
            
            //odwrotna kolejnosc Tomek ostatni
            Stack<Person> stack = new Stack<Person>();
            stack.Push(new Person("Tomek"));
            stack.Push(new Person("Tomek1"));
            stack.Push(new Person("Tomek2"));
            stack.Push(new Person("Tomek3"));
            stack.Push(new Person("Tomek4"));
            stack.Push(new Person("Tomek5"));

            //stack
            /*name: Tomek4
            name: Tomek3
            name: Tomek2
            name: Tomek1
            name: Tomek
            */
            
            //usuwa ostani element czyli Tomka
            stack.Pop();

            //zwraca pierwszy element
            // Console.WriteLine(stack.Peek());

            Queue<Person> queue = new Queue<Person>();

            queue.Enqueue(new Person("Tomek"));
            queue.Enqueue(new Person("Tomek1"));
            queue.Enqueue(new Person("Tomek2"));
            queue.Enqueue(new Person("Tomek3"));
            queue.Enqueue(new Person("Tomek4"));
            queue.Enqueue(new Person("Tomek5"));

            /*name: Tomek1
            name: Tomek2
            name: Tomek3
            name: Tomek4
            name: Tomek5*/

            //usuwa pierwszy element
            //queue.Dequeue();

            var dictionary = new Dictionary<int, Person>();
            
            
            dictionary[0]=new Person("Tomek");
            dictionary[1]=new Person("Tomek1");
            dictionary[2]=new Person("Tomek2");
            dictionary[3]=new Person("Tomek3");
            dictionary[4]=new Person("Tomek4");
            dictionary[5]=new Person("Tomek5");
                
            /*[0, name: Tomek]
                [1, name: Tomek1]
                [2, name: Tomek2]
                [3, name: Tomek3]
                [4, name: Tomek4]
                [5, name: Tomek5]
                */
                
                
            foreach (var person in dictionary)
            {
                Console.WriteLine(person);
            }
        }
        
    }
}