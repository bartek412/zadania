using System;

namespace _5._03
{
    class Program
    {
        static void Main(string[] args)
        {
            int romiar = 10;
            int[,] table = new int[romiar, romiar];
            Tablica tablica = new Tablica();
            tablica.czytaj(table, romiar);
            tablica.wyswietl(table, romiar);
            tablica.licz(table, romiar);
            Console.Read();
        }
    }
}
