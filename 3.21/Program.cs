using System;

namespace _3._21
{
    class Program
    {
        static void Main(string[] args)
        {
            int kolumna = 1, wiersz = 1;
            while (kolumna<=10)
            {
                wiersz=1;
                while (wiersz<=10)
                {
                    Console.Write(wiersz*kolumna +"\t");
                    wiersz++;

                }
                kolumna++;
                Console.WriteLine();
                
            }
            Console.Read();
            
        }
    }
}
