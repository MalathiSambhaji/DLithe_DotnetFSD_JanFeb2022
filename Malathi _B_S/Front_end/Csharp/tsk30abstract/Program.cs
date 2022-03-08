using System;
namespace AbstractClass
{
    abstract class Animal
    {
        protected string name;
        //abstract method
        public abstract string Name
        {
            get;
            set;
        }
    }
    //inheriting ftrom abstract class
    class Dog : Animal
    {
        public override string Name     // implementation of abstract method
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dog obj = new Dog();             //creating an object
            obj.Name = "Shruti";
            Console.WriteLine("Name: " + obj.Name);
            Console.ReadLine();
        }
    }
}
