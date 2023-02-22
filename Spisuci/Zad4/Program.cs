using System;
using System.Collections.Generic;
using System.Linq;

namespace Zad4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            var output = nums.Where(n => Math.Sqrt(n) == (int)Math.Sqrt(n));
            Console.WriteLine(string.Join(" ",output));
        }
    }
}
