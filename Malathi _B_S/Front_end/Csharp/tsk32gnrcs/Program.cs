using System;
using System.Collections.Generic; 

namespace Generics
{
    public class TestClass<T>
    {
        T[] obj = new T[5];                    //  Array of Generic type 
        int count = 0;                          // adding items into generic
        public void Add(T item)
        {
            if (count + 1 < 6)                  // //checking the lenth
            {
                obj[count] = item;

            }
            count++;
        }
        public T this[int index]                  // use indexer for foreach statement 
        {
            get { return obj[index]; }
            set { obj[index] = value; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            TestClass<int> intObj = new TestClass<int>();          // generic with Integer
                                                                   //adding integer values into the collection
            intObj.Add(1);
            intObj.Add(2);
            intObj.Add(3);     
            intObj.Add(4);
            intObj.Add(5);
            for (int i = 0; i < 5; i++)                           //displaying values
            {
                Console.WriteLine(intObj[i]); 
            }
            Console.ReadKey();
        }
    }
}