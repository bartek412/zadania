using System;

namespace _3._10
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma = 0,x=1;
            while (x<=100)
            {
                if (x%2==0)
                {
                    suma = suma + x;
                }
                x++;
            }
            Console.WriteLine("Suma liczb parzystych wynosi: "+suma);
            Console.Read();
        }
    }
}
