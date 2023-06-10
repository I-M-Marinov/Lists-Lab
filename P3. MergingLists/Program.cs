using System;
using System.Collections.Generic;
using System.Linq;

namespace P3._MergingLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> listOfInts1 = Console.ReadLine().Split().Select(int.Parse).ToList();  
            List<int> listOfInts2 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> resultList = new List<int>();
            int list1Length = listOfInts1.Count;
            int list2Length = listOfInts2.Count;

            for (int i = 0; i < list1Length; i++)
            {
                resultList.Add(listOfInts1[i]);

                if (i < list2Length)
                {
                    resultList.Add(listOfInts2[i]);
                }
            }
            for (int i = list1Length; i < list2Length; i++)
            {
                resultList.Add(listOfInts2[i]);
            }
            Console.WriteLine(string.Join(" ", resultList));   
        }
    }
}
