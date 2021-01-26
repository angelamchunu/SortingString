using System;
using System.Collections.Generic;

namespace SortingString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Sorter sorter = new Sorter();
            var sorted = sorter.Sort("Contrary to popular belief, the pink unicorn flies east.");

            foreach (KeyValuePair<char, int> entry in sorted)
            {
                for (int i = 0; i < entry.Value; i++)
                {
                    Console.Write(entry.Key);
                }
            }
        }
    }
}
