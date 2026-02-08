using System;
using System.Collections.Generic;

namespace Course3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedSet<int> a = new SortedSet<int>() {0,2,4,6,8,10};
            SortedSet<int> b = new SortedSet<int>() { 5,6,7,8,9,10};

            //unio de A e B
            SortedSet<int> c = new SortedSet<int>(a);
            c.UnionWith(b);
            PrintCollection(c);
        }
        static void PrintCollection<T>(IEnumerable<T> collection)
        {
            foreach (T obj in collection)
            {
                Console.Write(obj + " ");
            }
            Console.WriteLine();
        }
    }
}
