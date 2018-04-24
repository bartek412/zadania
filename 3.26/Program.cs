using System;

namespace _3._26
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, count = 0;
            int i = 100000;
            while ( i <= 999999)
            {

                x = i / 1000;
                y = i % 1000;
                if ((Math.Pow(x, 2) + Math.Pow(y, 2)) == i)
                {
                    Console.WriteLine(i);
                    count++;
                }
                i++;

            }
            Console.WriteLine("ilosc liczb spelniajacych rownanie to: " + count);
            Console.Read();
        }
    }
}