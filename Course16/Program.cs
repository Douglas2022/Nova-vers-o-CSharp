using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using Course16.Entities;

namespace Course16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();

            // Verifica se o arquivo existe antes de tentar abrir
            if (!File.Exists(path))
            {
                Console.WriteLine("Arquivo não encontrado: " + path);
                return;
            }

            List<Product> list = new List<Product>();

            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    while (!sr.EndOfStream) // Correção: ler enquanto NÃO chegou ao fim
                    {
                        string[] fields = sr.ReadLine().Split(',');
                        if (fields.Length < 2) continue; // evita erro se faltar dados

                        string name = fields[0];
                        double price;

                        // Tenta converter o preço com segurança
                        if (double.TryParse(fields[1], NumberStyles.Any, CultureInfo.InvariantCulture, out price))
                        {
                            list.Add(new Product(name, price));
                        }
                        else
                        {
                            Console.WriteLine($"Preço inválido para o produto: {name}");
                        }
                    }
                }

                // Calcula média
                var avg = list.Select(p => p.Price).DefaultIfEmpty(0.0).Average();
                Console.WriteLine("Average price = " + avg.ToString("F2", CultureInfo.InvariantCulture));

                // Seleciona nomes abaixo da média, ordenados decrescente
                var names = list
                    .Where(p => p.Price < avg)
                    .OrderByDescending(p => p.Name)
                    .Select(p => p.Name);

                foreach (string name in names)
                {
                    Console.WriteLine(name);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Erro de IO: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro inesperado: " + e.Message);
            }
        }
    }
}
