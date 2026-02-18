using System;

namespace Course9
{
    internal class Program
    {
        public static int globalvalue = 3;
        static void Main(string[] args)
        {
            int[] vect = new int[] { 3,4,5 };
            ChangeOddValues(vect);
            Console.WriteLine(string.Join(" ",vect));
        }
        public static void ChangeOddValues(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 != 0)
                {
                    numbers[i] += globalvalue;
                }
            }
        }
    }
}
