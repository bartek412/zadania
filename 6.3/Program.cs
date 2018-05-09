using System;

namespace _6._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            int[,] table = new int[n, n];
            int[,] table2 = new int[n, n];
            int[,] table3 = new int[n, n];

            Class1 class1 = new Class1();

            class1.Czytaj(table, n);
            class1.Przetworz(table,table2,n);
            class1.Zapisz(table2, n);
            class1.Odczyt(table3, n);
            Console.Read();
        }
    }
}
