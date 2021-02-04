using System;

namespace Kolokwium_II_Przgotowanie
{
    class Klasy_Generyczne
    {


        interface IInterface<Typee> where Typee : class
        {

        }

        //where Typee : class, new()
        public class MyClass<Typee> : IInterface<Typee> where Typee : class
        {

        }

        class MyClass<Type, Type2> where Type : new()
        {
            public virtual Type method(Type2 T)
            {
                Console.WriteLine("Kalas 1");
                Type x = new Type();
                return x;
            }

            public void method2()
            {
                Console.WriteLine("Method 2");
            }
        }

        class MyClass2 : MyClass<int, int>
        {
            public override int method(int x)
            {
                Console.WriteLine("Myclass2");
                return x;
            }
        }

        class T1
        {
            public string name1;
            public string name2;

            public T1(string name1, string name2, string name3)
            {
                this.name1 = name1;
                this.name2 = name2;
                this.name3 = name3;
            }

            public string name3;
        }

        class T2 : T1
        {
            public T2(string name1, string name2, string name3) : base(name1, name2, name3)
            {
            }
        }

    }
}