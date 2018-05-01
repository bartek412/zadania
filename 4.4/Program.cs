using System;

namespace _4._4
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
                    if (i == j)
                    {

                        tablica[i, j] = i;

                        suma += i;
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
