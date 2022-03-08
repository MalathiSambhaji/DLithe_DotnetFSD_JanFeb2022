using System;
namespace sortarray
{
    class program
    {
        public static void Main()
        {
            int[] arr = new int[] { 13, 12, 11, 54, 33 };
            Console.WriteLine("Array before sorting:\n");
            foreach (int value in arr)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine("\n");
            Array.Sort(arr);
            Array.Reverse(arr);
            Console.WriteLine("array after sorting:n");
            foreach (int value in arr)
            {
                Console.Write(value + " ");
            }
        }
    }
}