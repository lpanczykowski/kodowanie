using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public struct User
            {
                public string Imie;
                public byte wiek;
            }

        static void Main(string[] args)
        {
            User [] Bar= new User[2];
            Bar[0].Imie="Jan Kowalski";
            Bar[0].wiek=32;
            Bar[1].Imie="Andrzej Hhol";
            Bar[1].wiek=54;

            for(int i=0;i<Bar.Length;i++)
                {
                Console.WriteLine("{0,-15} | {1,5}", Bar[i].Imie, Bar[i].wiek);

}
            Console.ReadLine();

           

            /* string s=File.ReadAllText(@"C:\Users\Marcin\source\repos\kodowanie2\ConsoleApp1\ConsoleApp1\txt.txt");
            Console.WriteLine(s);
            Console.ReadKey();
            */
        }
    }
}
