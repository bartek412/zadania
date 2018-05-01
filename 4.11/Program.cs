using System;
using System.Collections;

namespace _4._11
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add(5);
            list.Add(23);
            list.Add(1);
            list.Add(53);
            list.Add(20);
            list.Add(-2);
            list.Sort();
            foreach (int x in list)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine();
            list.RemoveAt(1);
            list.Add(3);
            list.Sort();
            foreach (int x in list)
            {
                Console.WriteLine(x);
            }
            Console.Read();
        }
    }
}
