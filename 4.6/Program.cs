using System;

namespace _4._6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10, suma = 0;
            int[,] tablica = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i + j + 1 == n)
                    {

                        tablica[i, j] = i;

                        suma += tablica[i, j];
                    }
                    else
                    {
                        tablica[i, j] = 0;
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(tablica[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("suma wynosi " + suma);
            Console.Read();
        }
    }
}
