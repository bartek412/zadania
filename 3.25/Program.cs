using System;

namespace _3._25
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, count = 0;
            for (int i = 1000; i <= 9999; i++)
            {
               
                x = i / 100;
                y = i % 100;
                if ((Math.Pow(x,2)+Math.Pow(y,2))==i)
                {
                    Console.WriteLine(i);
                    count++;
                }

            }
            Console.WriteLine("ilosc liczb spelniajacych rownanie to: "+count);
            Console.Read();
        }
    }
}
