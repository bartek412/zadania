using System;

namespace _4._10
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma = 0,suma2=0;
            int[] table = new int[100];
            for (int i = 0; i < table.Length; i++)
            {
                table[i] = i + 1;
            }
            foreach (int x in table)
            {
                if (x%2==0)
                {
                    suma += x;
                }
                else
                {
                    suma2 += x;
                }
               
            }
            Console.WriteLine(suma+" "+suma2);
            Console.Read();
        }
    }
}