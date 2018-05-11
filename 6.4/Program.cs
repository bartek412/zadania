using System;

namespace _6._4
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] table = new char[] { 'a', 'b', 'c', 'd', 'f', 'g', 'h' };
            PlikSwobodny plik = new PlikSwobodny();
            plik.Odczyt(table);
            Console.Read();
            
        }
    }
}
