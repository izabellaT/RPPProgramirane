using System;
using System.Collections.Generic;
using System.Linq;

namespace Spisuk
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split("-").Select(int.Parse).ToList();
            while (true)
            {
                string[] input = Console.ReadLine().Split().ToArray();
                if (input[0] == "print")
                {
                    break;
                }
                switch (input[0])
                {
                    case "add":
                        {
                            int index = int.Parse(input[1]);
                            int element = int.Parse(input[2]);
                            for (int i = 0; i < index; i++)
                            {
                                nums.Add(element);
                            }
                        }
                        break;

                    case "ins":
                        {
                            int index = int.Parse(input[1]);
                            for (int i = input.Count() - 1; i >= 2; i--)
                            {
                                nums.Insert(index, int.Parse(input[i]));
                            }
                            break;
                        }

                    case "contains":
                        {
                            int element = int.Parse(input[1]);
                            if (nums.Contains(element))
                            {
                                Console.WriteLine("yes!");
                                nums.Remove(element);
                            }
                            else
                            {
                                Console.WriteLine("no!");
                            }
                            break;
                        }
                }
            }
            Console.WriteLine(string.Join(" ", nums));
        }
    }
}

           
            