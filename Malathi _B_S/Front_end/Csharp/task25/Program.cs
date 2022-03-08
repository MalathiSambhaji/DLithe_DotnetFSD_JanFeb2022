using System;
public class twodimmensionalarray
{
    public static void Main(string[] args)
    {
        int[,] arr = new int[2, 2]; //2d array declaration
        arr[0, 1] = 10;
        arr[1, 2] = 20;
            //traversal
        for(int i=0; i<2; i++)
        {
            for(int j=0; j<2; j++)
            {
                Console.Write(arr[i, j] + "");
            }
            Console.WriteLine();
        }
    }
}
