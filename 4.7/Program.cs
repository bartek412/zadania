using System;

namespace _4._7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10, suma = 0, suma2 = 0 ;
            int[,] tablica = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j==0)
                    {
                        tablica[i, j] = i;
                        suma += tablica[i, j];
                    }
                    else if (j==1)
                    {
                        tablica[i, j] = i * i;
                        suma2 += tablica[i, j];
                    }
                    else
                    {
                        tablica[i, j] = 0;

                        suma += tablica[i, j];

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
            Console.WriteLine("suma wynosi " + suma +" "+suma2);
            Console.Read();
        }
    }
}
