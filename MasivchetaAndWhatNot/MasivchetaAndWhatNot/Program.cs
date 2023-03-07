using System;
using System.Linq;

namespace MasivchetaAndWhatNot
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray(); //malkotoMiMasivche
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("count= ", arr.Count(x => x<100));
                Console.WriteLine("max= ", arr.Max());
                Console.WriteLine(arr.Reverse());
                
                Console.WriteLine(arr);
            }
            

        }
    }
}
