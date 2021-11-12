using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace Zadanie2
{
    class Program
    {
        public struct people
        {
            public string f;
            public string i;
            public string o;
            public string age;
            public string ves;
        }
        static void Main(string[] args)
        {
            StreamReader s = new StreamReader("file.txt");
            people p;
            List<string> chel = new List<string>();

            while (!s.EndOfStream)
            {
                chel.Add(s.ReadLine());
            }
            Console.WriteLine("Исходная коллекция:");
            Console.WriteLine();
            foreach (var item in chel)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine("Люди у которых возраст кратен 3:");
            Console.WriteLine();
            try
            {
                foreach (var item in chel)
                {
                    string[] str = item.Split(' ');
                    p.f = str[0];
                    p.i = str[1];
                    p.o = str[2];
                    p.age = str[3];
                    p.ves = str[4];
                    int v = int.Parse(str[3]);

                    if (str.All(x => Convert.ToInt32(x[3]) % 3 == 0))
                    {
                        Console.WriteLine(item);
                    }
                }
            }
            catch { Console.WriteLine("Ошибка!"); }
        }
    }
}
