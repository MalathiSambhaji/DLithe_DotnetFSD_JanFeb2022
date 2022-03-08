using System;
public class Polynomial
{
    public virtual double len
    {
        get;
        set;
    }
    public virtual double wid
    {
        get;
        set;
    }
    public virtual double Area()
    {
        return len * wid;
    }
}
public class Rectangle:
Polynomial{ }
public class square :
Polynomial
{
    public override double len
    {
        get;
        set;
    }
    public override double
        Area()
    {
        return len * len;
    }
}
public class Circle :
    Polynomial
{
    public double radius
    {
        get;
        set;
    }
    public override double Area()
    
        {
            return Math.PI * radius * radius;
        }
    }
    public class Triangle : Polynomial
    {
        public override double Area()
        {
            return 0.5 * len * wid;
        }
    }
    public class Program
    {
        public static void Main()
        {
            var rect = new Rectangle();
            rect.len = 5;
            rect.wid = 10;
            Console.WriteLine("Area of Rectangle = " + rect.Area());
            var sq = new square();
            sq.len = 15;
            Console.WriteLine("Area of Square = " + sq.Area());
            var cir = new Circle();
            cir.radius = 10;
            Console.WriteLine("Area of Circle = " + cir.Area());
            var tri = new Triangle();
            tri.len = 5;
            tri.wid = 10;
            Console.WriteLine("Area of Triangle = " + tri.Area());
        }
    }

