using System;
using System.Collections.Generic;
using System.Linq;

namespace Spisuci
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            int last = nums[nums.Count - 1]; //last element of list
            nums.RemoveAll(x => x == last); //removing all items that equals the last element
            Console.WriteLine(string.Join(" ",nums));
        }
    }
}
