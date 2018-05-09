using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace _6._1
{
    class Identy
    {
        string name,name2;
        FileStream fin, fout;
        public void Czytaj()
        {
            Console.WriteLine("Podaj imie i nazwisko ");
            name = Console.ReadLine();
           
        }
        public void Zapisz()
        {
            fout = new FileStream("dane.txt", FileMode.Create);
            StreamWriter fstrout = new StreamWriter(fout);
            fstrout.Write(name);
            fstrout.Close();
            fout.Close();

        }
        public void Odczyt()
        {
            fin = new FileStream("dane.txt", FileMode.Open);
            StreamReader ftrin = new StreamReader(fin);
            while ((name2=ftrin.ReadLine())!=null)
            {
                Console.WriteLine(name2);
            }
            ftrin.Close();
            fin.Close();
            
        }
    
}
}
