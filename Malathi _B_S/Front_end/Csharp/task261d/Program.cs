using System;
namespace one_Dimensiona1
{

    class Program
{
    static void Main(string[] args)
    {
        int[] arr = new int[10];
        for (int x = 0; x < 10; x++)
        {
            Console.WriteLine("Enter array element : {0}", x + 1);
            arr[x] = Int32.Parse(Console.ReadLine());
        }
        foreach (int i in arr)
        {
            Console.WriteLine(i);
        }
        Console.ReadLine();
        }
    }
}
