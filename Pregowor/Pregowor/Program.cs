using System;
using System.Linq;

namespace Pregowor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] arr = new string[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = Console.ReadLine();
            }
            Console.WriteLine("Count= " + string.Join(' ', arr.Count(x => x.Length <= 3)));
            Array.Reverse(arr);
            Console.WriteLine(string.Join(", ", arr));
        }
    }
}
