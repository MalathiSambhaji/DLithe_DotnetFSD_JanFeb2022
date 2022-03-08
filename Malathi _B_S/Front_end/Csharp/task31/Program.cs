using System;
namespace InterfaceDemo
{
    interface interface1 // remove public and add interface
    {
        void Test();
        void Show();
    }
    interface interface2   // remove public and add the interface
    {
        void Test();
        void Show();
    }
    class ImplementInterafce : interface1, interface2   
    {

        public void Test()     // overide with the void
        {
            Console.WriteLine("The Test method is implemented");
        }
        public void Show()      // overide with the void
        {
            Console.WriteLine("The Show method is implemented");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ImplementInterafce obj = new ImplementInterafce();
            obj.Test();
            obj.Show();
            Console.WriteLine("Press any key to exit.");   
            Console.ReadKey();
        }
    }
}
