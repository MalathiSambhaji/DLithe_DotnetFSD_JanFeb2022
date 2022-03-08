using System;
namespace Partial_method
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassA cls = new ClassA();
            cls.SetSalary();
        }
    }
    public partial class ClassA
    {
        partial void SetData();
    }
    public partial class ClassA
    {
        public void SetSalary()
        {
            SetData();          
        }
        partial void SetData()
        {
            Console.Write("This is a partial method.");
            Console.ReadKey();
        }
    }
}