using System;

namespace _4._8
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            int[,] a = new int[n, n];
            int[,] b = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {

                    a[j,i] = i;


                }

            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {

                    b[i, j] = a[j, i];


                }

            }

      
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(b[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("tablica:a ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.Read();
        }
    }
}
