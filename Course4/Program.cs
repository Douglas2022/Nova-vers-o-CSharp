using System;
using System.Collections.Generic;
using System.IO;
using Course4.Entities;

namespace Course4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<LogRecods> set = new HashSet<LogRecods>();

            Console.Write("Enter file full path:: ");
            string path = Console.ReadLine();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while(!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(' ');
                        string name = line[0];
                        DateTime instant = DateTime.Parse(line[1]);
                        set.Add(new LogRecods { UserName = name, Instant = instant });
                    }
                    Console.WriteLine("Total de elementos: " + set.Count);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
