using System;


namespace _5._02
{

    class function
{
    double a, b, c, x,delta,x1,x2,count;
    public void czytaj()
    {
        Console.WriteLine("podaj a ");
        a = double.Parse(Console.ReadLine());
        switch (a)
        {
            case 0: { x = -1 * (b / c);
                    Console.WriteLine("zla wartosc a");
                        Console.Read();
                        Environment.Exit(0);
                    }
                break;
        }
        Console.WriteLine("podaj b ");
        b = double.Parse(Console.ReadLine());
        Console.WriteLine("podaj c ");
        c = double.Parse(Console.ReadLine());

    }
        public void oblicz()
        {
            delta = (Math.Pow(b, 2) - (4 * a * c));
            if (delta==0) count = 1;
            if (delta>0) count = 2;
            if (delta < 0) count = 0;
            switch (count)
            {
                case 1: {x1= -b/(2*a); }
                    break;
                case 2: { x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                    x2= x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    }
                    break;
            }
        }
        public void wyswietl()
        {
            switch (count)
            {
               case 0:
                    { Console.WriteLine("nie ma rozwiazan"); }
                    break;
                case 1:
                    { Console.WriteLine("jest jedno roz w "+x1); }
                    break;
                case 2:
                    { Console.WriteLine("sa 2 roz w " + x1+" "+x2); }
                    break;
            }
        }

} }
