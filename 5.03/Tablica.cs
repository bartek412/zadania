using System;
using System.Collections.Generic;
using System.Text;

namespace _5._03
{
    class Tablica
    {
       
        int suma;
      public  void czytaj(int[,] table,int count)
        {
            Random random = new Random();
            for (int i = 0; i < count; i++)
            {
                for (int j = 0; j < count; j++)
                {
                    if (i==j)
                    {
                        table[i, j] = random.Next(1, 9);
                    }
                    else
                    {
                        table[i, j] = 0;
                    }
                }
            }
        }
        public void licz(int[,] table, int count)
        {

            for (int i = 0; i < count; i++)
            {
                suma += table[i,i];
            }
            Console.WriteLine("suma przekatnej to: "+suma);
        }
      public  void wyswietl(int[,] table, int count)
        {
            for (int i = 0; i < count; i++)
            {
                for (int j = 0; j < count; j++)
                {
                    Console.Write(table[i,j]);
                }
                Console.WriteLine();
            }
        }
    }
}
