using System;

namespace _6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 class1 = new Class1();
            int n = 10;
            int[,] table = new int[n, n];
            int[,] table2 = new int[n, n];
            class1.Czytaj(table, n);
            class1.Zapisz(table, n);
            class1.Odczyt(table2, n);
            Console.Read();
        }
    }
}
