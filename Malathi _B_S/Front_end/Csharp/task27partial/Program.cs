using System;
namespace partial
{
    public class program
    {
        static void Main(string[] args)
        {
            HelloClass hello = new HelloClass();
            hello.GoodMorning();
            hello.GoodAfternoon();
        }
    }
    public partial class HelloClass
    {
        public void GoodMorning()
        {
            Console.WriteLine("Good Morning");
        }
    }
    
    public partial class HelloClass
    {
        public void GoodAfternoon()
        {
            Console.WriteLine("GoodAfternoon");
        }
        
    }
}
