using System;

namespace _4._13
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            int[,] a = new int[n, n];
            int[,] b = new int[n, n];
            int[,] c = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {

                    a[i,j] = 1;


                }

            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {

                    b[i, j] = 2;


                }

            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {

                    c[i, j] = a[i,j]+b[i,j];


                }

            }


            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(c[i, j] + " ");
                }
                Console.WriteLine();
            }
            

            Console.Read();
        }
    }
}
