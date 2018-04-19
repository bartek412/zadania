using System;

namespace _3._13
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1, suma = 0;
            do
            {
                if (x % 2 != 0) suma = suma + x;
                x++;

            } while (x<=100);
            Console.WriteLine("Suma liczb nieparzystych wynosi: " + suma);
            Console.Read();
        }

    }
}
