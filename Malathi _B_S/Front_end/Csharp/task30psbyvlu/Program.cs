using System;
namespace constructors
{
    class person
    {
        public string name, location; //Default constructor
        public person()
        {
            name = "Sudha";
            location = "Delhi";
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            person person = new person();
            Console.WriteLine(person.name);
            Console.WriteLine(person.location);
            Console.ReadLine();
        }
    }
}