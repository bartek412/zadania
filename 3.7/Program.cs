using System;

namespace _3._7
{
    class Program
    {
        static void Main(string[] args)
        {
            int x=0;
            for (int i = 1; i <= 100; i++)
            {
                
                x = x + i;
            }
            Console.WriteLine("suma liczb 1-100 = "+x);
            Console.Read();
        }
    }
}
