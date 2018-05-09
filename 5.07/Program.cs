using System;

namespace _5._07
{
    class Program
    {
        static void Main(string[] args)
        {
            Fibo fibo = new Fibo();
            for (int i = 1; i <=10; i++)
            {
                Console.WriteLine(fibo.Oblicz(i));
            }
            Console.Read();
        }
    }
}
