using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace _6._2
{
    class Class1
    {
        FileStream fout, fin;
        public void Czytaj(int[,] table,int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i==j)
                    {
                        table[i, j] = 1;
                    }
                    else
                    {
                        table[i, j] = 0;
                        
                    }
                    Console.Write(table[i, j] + " ");
                   
                }
                Console.WriteLine();
            }


        }
        public void Zapisz(int[,] table ,int n)
        {
            Console.WriteLine();
            fout = new FileStream("text.txt", FileMode.Create);
            StreamWriter strw = new StreamWriter(fout);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    strw.Write((char)table[i, j]);
                    Console.Write(table[i, j] + " ");
                }
                Console.WriteLine();
            }
            strw.Close();
            fout.Close();
        
        }
        public void Odczyt(int[,] table, int n)
        {
            Console.WriteLine();
            fin = new FileStream("text.txt", FileMode.Open);
            StreamReader str = new StreamReader(fin);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    table[i, j] = str.Read();
                    Console.Write(table[i, j] + " ");
                }
                Console.WriteLine();
            }
            str.Close();
            fin.Close();
        }
    }
}
