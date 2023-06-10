using System;
using System.Collections.Generic;
using System.Linq;

namespace P5.RemoveNegativesAndReverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> integers =Console.ReadLine().Split().Select(int.Parse).ToList();

            for (int i = 0; i < integers.Count; i++)
            {
                if (integers[i] < 0)
                {
                    integers.RemoveAt(i);
                    i--;
                }
            }
            if (integers.Count > 0)
            {
                integers.Reverse();
                Console.WriteLine(string.Join(" ", integers));
            }
            else
            {
                Console.WriteLine("empty");
            }
        }
    }
}
