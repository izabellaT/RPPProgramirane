using System;
using System.Collections.Generic;
using System.Linq;

namespace Zad5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            while (true)
            {
                string[] input = Console.ReadLine().Split().ToArray();
                string command = input[0];
                if (command == "print")
                {
                    break;
                }
                int index = 0;
                switch (command)
                {
                    case "add":
                        {
                            index = int.Parse(input[1]);
                            int num = int.Parse(input[2]);
                            nums.Insert(index, num);
                            break;
                        }
                    case "addMany":
                        {
                            index = int.Parse(input[1]);
                            for (int i = input.Length - 1; i > 1; i--)
                            {
                                int num = int.Parse(input[i]);
                                nums.Insert(index, num);
                            }
                            break;
                        }
                    case "contains":
                        {
                            
                            break;
                        }
                    case "remove":
                        {

                            break;
                        }
                    case "shift":
                        {

                            break;
                        }
                    case "sumPairs":
                        {

                            break;
                        }
                }
            }
        }
    }
}
