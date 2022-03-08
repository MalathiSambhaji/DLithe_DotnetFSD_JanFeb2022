using System;
namespace jaggedarray
{
    class program
    {
        public static void Main()
        {
            int[][] arr = new int[2][];   // declaring an array

            arr[0] = new int[] { 10, 12, 13 };   // initializing an array
            arr[1] = new int[] { 17, 19, 21 };
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    System.Console.Write(arr[i][j] + " ");

                }
                System.Console.WriteLine();
            }
        }
    }

            
}
