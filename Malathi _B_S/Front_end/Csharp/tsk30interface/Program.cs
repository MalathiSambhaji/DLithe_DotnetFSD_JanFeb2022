using System;
namespace Interface
{
    interface IPolygon
    {
        void calculateArea(int l, int b);
    }
    class Rectangle : IPolygon             
    {
        public void calculateArea(int l,int b)        //implementation of interface inside method
        {
            int area = l * b;
            Console.WriteLine("Area of Rectangle: " + area);
        }
    }
    class Program
    {
        static void Main (string [] args)
        {
            Rectangle r1 = new Rectangle();
            r1.calculateArea(100, 200);
        }
    }
}