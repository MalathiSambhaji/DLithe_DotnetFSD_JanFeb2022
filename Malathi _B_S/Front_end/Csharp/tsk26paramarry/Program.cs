using System;
namespace paramarray
{
    class program
    {
        public void Show(params int[] val)
        {
            for(int i = 0; i<val.Length;i++)
            {
                Console.WriteLine(val[i]);
            }
        }
        static void Main(string[]args)
        {
            program program = new program();
            program.Show(2, 3, 4, 5, 6, 7);
        }


    }

}