using System;
using System.Collections.Generic;
using System.Linq;

namespace Zad2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            nums = nums.Where(n => n >= 0).ToList();
            if (nums.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                nums.Reverse();
                Console.WriteLine(string.Join(" ", nums));
            }
        }
    }
}
