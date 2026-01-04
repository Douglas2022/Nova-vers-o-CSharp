using System;
using System.IO;
using System.Collections.Generic;
using Couser.Entities;

namespace Couser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\paulo\Downloads\Carla ,4300.00.txt";
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    List<Funcionarios> list = new List<Funcionarios>();
                    while (!sr.EndOfStream)
                    {
                        list.Add(new Funcionarios(sr.ReadLine()));
                    }
                    list.Sort();
                    foreach (Funcionarios str in list)
                    {
                        Console.WriteLine(str);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}

