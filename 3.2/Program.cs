using System;

namespace _3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            x = 0;
            do
            {
                y=3*x;
                Console.WriteLine("x = "+x+" y "+y);
                x++;
            } while (x<=10);
            Console.Read();
        }
    }
}
