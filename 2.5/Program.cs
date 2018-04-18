using System;

namespace _2._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int  pkt,numbertocatch,numberinpunt;
            Random random = new Random();
         
            pkt = 0;
            for (int i = 0; i <5; i++)
            {
                numbertocatch =random.Next(1,10);
                Console.WriteLine("podaj liczbe od 0-9");
                numberinpunt = int.Parse(Console.ReadLine());
                if (numberinpunt==numbertocatch)
                {
                    pkt++;
                    Console.WriteLine("zgadles masz: "+pkt+" pkt"); 
                }
                else
                {
                    Console.WriteLine("niestety nie zgadles masz: " + pkt + " pkt prawidlowa odp to:"+numbertocatch);
                }

            }
            Console.WriteLine("koniec gry zdobyles: " + pkt + " pkt");
            Console.Read();
            
        }
    }
}
