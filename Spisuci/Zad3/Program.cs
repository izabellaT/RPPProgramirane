using System;
using System.Collections.Generic;
using System.Linq;

namespace Zad3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> result = new List<int>();
            List<string> input = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries).ToList();
            input.Reverse();
            for (int i = 0; i < input.Count; i++)
            {
                int[] masiv = input[i].Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                result.AddRange(masiv);
            }
                Console.WriteLine(string.Join(" ", result));
            }
        }
    }
