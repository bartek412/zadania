using System;
using System.Collections;

namespace _4._12
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add("Kacper");
            list.Add("Ola");
            list.Add("Kuba");
            list.Add("Mateusz");
            list.Add("Paweł");
            list.Add("Maciek");
            list.Sort();
        
            foreach (string x in list)
            {
                Console.WriteLine(x);
            }
            Console.Read();
        }
    }
}
