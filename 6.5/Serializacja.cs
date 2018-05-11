using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace _6._5
{
    class Serializacja
    {
        public void CzytajZapisz(double[] table)
        {
            for (int i = 0; i < table.Length; i++)
            {
                Console.WriteLine(table[i]+" ");
            }
            Stream stream = new FileStream("dane.dat", FileMode.Create);
            BinaryFormatter formatter =new BinaryFormatter();
            formatter.Serialize(stream, table);
            stream.Close();
            Console.WriteLine();
            Console.WriteLine("co 2 pomiar");
            Stream streamreader = new FileStream("dane.dat", FileMode.Open);
            BinaryFormatter binaryReader = new BinaryFormatter();
            table = (double[])binaryReader.Deserialize(streamreader);
            for (int i = 0; i < table.Length; i+=2)
            {
                Console.WriteLine(table[i]+" ");

            }
            streamreader.Close();


        }
    }
}
