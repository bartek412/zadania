using System;

namespace _4._9
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma = 0;
            int[] table = new int[100];
            for (int i = 0; i < table.Length; i++)
            {
                table[i] = i + 1;
            }
            foreach (int x in table)
            {
             
                suma += x;
            }
            Console.WriteLine(suma);
            Console.Read();
        }
    }
}
