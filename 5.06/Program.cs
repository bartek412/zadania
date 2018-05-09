using System;

namespace _5._06
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            Licz licz = new Licz();
            for (int i = 1; i <=n; i++)
            {
                Console.WriteLine(licz.Oblicz(i));
            }
         
            Console.Read();
        }
    }
}
