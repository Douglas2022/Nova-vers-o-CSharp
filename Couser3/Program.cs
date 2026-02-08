using System;

namespace Couser3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string a = "Maria";
            //string b = "Alexa";

            //Console.WriteLine(a.Equals(b));


            string a = "Maria";
           // string a = "Maria";
            string b = "José";
           // string b = "Alexa";

            Console.WriteLine(a.Equals(b));
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());

        }
    }
}
