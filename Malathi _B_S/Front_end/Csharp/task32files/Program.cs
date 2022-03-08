using System;
using System.IO; //include System.IO namespace
namespace Files 
{
    class program
    {
        static void Main(string[] args)
        {
            string writeText = "Welcome";   //create a text
            File.WriteAllText("filename.txt", writeText);    //create files and write content in it
            string readText = File.ReadAllText("fiename.txt");   //read the content
            Console.WriteLine(readText);                         // print the content
        }
    }
}
