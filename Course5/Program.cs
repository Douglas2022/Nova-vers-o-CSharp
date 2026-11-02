using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,string> cookies = new Dictionary<string,string>();

            cookies ["User: "] = "Maria";
            cookies["Email"] = "maria@gmail.com";
            cookies["Phone"] = "99547814";
            cookies["Phone"] = "88745122";

            Console.WriteLine(cookies["Phone"]);
            Console.WriteLine(cookies["Email"]);

            cookies.Remove("Email");

            // Console.WriteLine(cookies["Email"]);
            if (cookies.ContainsKey("Email"))
            {
                Console.WriteLine(cookies["Email"]);
            }
            else
            {
                Console.WriteLine("Não há 'email' da chave");
            }

            Console.WriteLine("Quantidade: " + cookies.Count);
            Console.WriteLine("Todos os dicionáros");
            foreach(var item in cookies)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }

        }
    }
}
