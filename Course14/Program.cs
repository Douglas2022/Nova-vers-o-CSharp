using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Globalization;
//Linq - Languagem Integrate Qurey
namespace Course14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Pegar os números pares e multiplicar por 10.
            //Especificar o Data Source
            //Criar um vetor
            int[] numero = new int[] { 1, 2, 3, 4, 5,6 };
            //Definir a consulta
            //Predicado para os números pares
            var result = numero
                .Where(x => x % 2 == 0)
                .Select(x => x * 10);
            //Executar a consulta
            foreach (var x in result)
            {
                Console.WriteLine(x);
            }
        }
    }
}
