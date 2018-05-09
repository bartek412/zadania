using System;

namespace _5._05
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            silnia silnia = new silnia();
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine(" " +i +"! = "+silnia.silnial(i));
            }
            Console.Read();
        }
    }
}
