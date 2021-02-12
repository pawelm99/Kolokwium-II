using System;
using System.Collections.Generic;

namespace Zadanie2
{
    class DictionaryBuilder<A,B>
    {
        public Dictionary<A,B> BuildDictionary(List<A> listA, List<B> listB)
        {
            Dictionary<A,B> dictionary = new Dictionary<A, B>();
            if (listA.Count != listB.Count)
            {
                throw new NotImplementedException();
            }
            else
            {
                
                for (int i = 0; i < listA.Count; i++)
                {
                    dictionary.Add(listA[i],listB[i]);
                }

                return dictionary;
            }

            return dictionary;
        }
    }
    class Program
    {
       
        public void Zad2()
        {
            List<int> list = new List<int>()
            {
                1,2,3,4
            };
            List<double> listb = new List<double>()
            {
                1.0,2.0,3.0,4.0
            };
            
            DictionaryBuilder<int,double> builder = new DictionaryBuilder<int, double>();

            var dictionary = builder.BuildDictionary(list, listb);
            foreach (var item in dictionary)
            {
                Console.WriteLine(item);
            }
        }
    }
    
}