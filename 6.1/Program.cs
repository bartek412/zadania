using System;

namespace _6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Identy identy = new Identy();
            identy.Czytaj();
            identy.Zapisz();
            identy.Odczyt();
            Console.Read();
        }
    }
}
