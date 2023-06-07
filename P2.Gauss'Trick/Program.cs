using System;
using System.Collections.Generic;
using System.Linq;

namespace P2.Gauss_Trick
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> inputInts =Console.ReadLine().Split().Select(int.Parse).ToList();

            int startupLength = inputInts.Count;

            for (int i = 0; i < startupLength / 2; i++)
            {
                inputInts[i] += inputInts[inputInts.Count - 1];

                inputInts.RemoveAt(inputInts.Count - 1);
            }
            Console.WriteLine(string.Join(" ", inputInts));
        }
    }
}
