using System;
namespace StringApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string fname, lname;    //string concatination
            fname = "Raju";
            lname = "Singh";
            char[] letters = { 'h', 'e', 'l', 'l', 'o', };
            string[] sarray = { "hello", "from", "bootcamp" };

            string fullname = fname + lname;
            Console.WriteLine("full name: {0}", fullname);
            string greetings = new string(letters);
            Console.WriteLine("greetings: {0}", greetings);  //using string constructor
            string message = String.Join(" ", sarray);
            Console.WriteLine("Message: {0}", message);     //returning string
        }
    }
}