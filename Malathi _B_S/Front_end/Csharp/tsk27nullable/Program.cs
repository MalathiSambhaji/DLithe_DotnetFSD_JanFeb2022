using System;
namespace nullable
{
    class nullableexample
    {
        static void Main(string[]args)
        {
            Nullable<int> a = 11;
            Nullable<double>b = 10.10;
            Nullable<char> c = 'R';
            Nullable<bool>d = false;
            Console.WriteLine(a.Value);   //displaying value
            a = null;
            b = null;
            c = null;
            d = null;                   //assigning  null values
            if(a.HasValue)              //checking wheather 'a' has value
            {
                Console.WriteLine(a.Value);
            }
            if (a == null)
                Console.WriteLine("It contains a null value");


        }
    }
}