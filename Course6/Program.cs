using System;
using Course6.Extentions;

namespace Course6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime DT = new DateTime(2018,12,16,8,10,45);
            Console.WriteLine(DT.ElapsedTime());
        }
    }
}
