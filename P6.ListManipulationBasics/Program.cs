using System;
using System.Collections.Generic;
using System.Linq;

namespace P6.ListManipulationBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> integersList = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }

                List<string> index = input.Split().ToList();

                if (index[0] == "Add")
                {
                    integersList.Add(int.Parse(index[1]));
                }
                else if (index[0] == "Remove")
                {
                    integersList.Remove(int.Parse(index[1]));
                }
                else if (index[0] == "RemoveAt")
                {
                    integersList.RemoveAt(int.Parse(index[1]));
                }
                else if (index[0] == "Insert")
                {
                    integersList.Insert(int.Parse(index[2]), int.Parse(index[1]));
                }
            }
            Console.WriteLine(string.Join(" ", integersList));  
        }
    }
}
