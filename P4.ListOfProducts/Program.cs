using System;
using System.Collections.Generic;

namespace P4.ListOfProducts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int productsNumber = int.Parse(Console.ReadLine());
            List<string> productList = new List<string>();

            for (int i = 0; i < productsNumber; i++)
            {
                string productName = Console.ReadLine();
                productList.Add(productName);
            }
            productList.Sort();
            for (int i = 1; i < productsNumber+1; i++)
            {

                Console.WriteLine($"{i}.{productList[i-1]}");
            }
        }
    }
}
