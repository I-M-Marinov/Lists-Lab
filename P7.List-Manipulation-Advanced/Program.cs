using System;
using System.Collections.Generic;
using System.Linq;

namespace P7.List_Manipulation_Advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> integersList = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            bool isChanged = false;

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
                    isChanged = true;
                }
                else if (index[0] == "Remove")
                {
                    integersList.Remove(int.Parse(index[1]));
                    isChanged = true;
                }
                else if (index[0] == "RemoveAt")
                {
                    integersList.RemoveAt(int.Parse(index[1]));
                    isChanged = true;
                }
                else if (index[0] == "Insert")
                {
                    integersList.Insert(int.Parse(index[2]), int.Parse(index[1]));
                    isChanged = true;
                }
                else if (index[0] == "Contains")
                {

                    if (integersList.Contains(int.Parse(index[1])))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                else if (index[0] == "PrintEven")
                {
                    for (int i = 0; i < integersList.Count; i++)
                    {
                        if (integersList[i] % 2 == 0)
                        {
                            Console.Write(integersList[i] + " ");
                        }
                    }
                    Console.WriteLine();
                }
                else if (index[0] == "PrintOdd")
                {
                    for (int i = 0; i <= integersList.Count-1; i++)
                    {
                        if (integersList[i] % 2 != 0)
                        {
                            Console.Write(integersList[i] + " ");
                        }
                    }
                    Console.WriteLine();
                }
                else if (index[0] == "GetSum")
                {
                    int sum = 0;

                    for (int i = 0; i < integersList.Count; i++)
                    {
                        sum += integersList[i];
                    }

                    Console.WriteLine(sum);
                }
                else if (index[0] == "Filter")
                {
                    if (index[1] == ">")
                    {
                        for (int i = 0; i < integersList.Count; i++)
                        {
                            if (integersList[i] > int.Parse(index[2]))
                            {
                                Console.Write(integersList[i] + " ");
                            }
                        }
                        Console.WriteLine();
                    }
                    else if (index[1] == ">=")
                    {
                        for (int i = 0; i < integersList.Count; i++)
                        {
                            if (integersList[i] >= int.Parse(index[2]))
                            {
                                Console.Write(integersList[i] + " ");
                            }

                        }
                        Console.WriteLine();
                    }
                    else if (index[1] == "<")
                    {
                        for (int i = 0; i < integersList.Count; i++)
                        {
                            if (integersList[i] < int.Parse(index[2]))
                            {
                                Console.Write(integersList[i] + " ");
                            }
                        }
                        Console.WriteLine();
                    }
                    else if (index[1] == "<=")
                    { 
                        for (int i = 0; i < integersList.Count; i++)
                        {
                            
                            if (integersList[i] <= int.Parse(index[2]))
                            {
                                Console.Write(integersList[i] + " ");
                            }
                            
                        }
                        Console.WriteLine();
                    }
                }
            }

            if (isChanged)
            {
                Console.WriteLine(string.Join(" ", integersList));
            }

        }
    }
}