using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Protected
{
    class access
    {
        protected string name;  //string variable declared as protected
        public void print()
        {
            Console.WriteLine("\nMy name is " + name);
        }
    }
    class Program : access //inherit access class
    {
        static void Main(string[] args)
        {
            Program p =  new Program();
            Console.Write("Enter your name:\t");
            p.name = Console.ReadLine();
            p.print();
            Console.ReadLine();
        }
    }
}
