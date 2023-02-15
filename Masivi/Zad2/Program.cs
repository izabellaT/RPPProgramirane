using System;
using System.Linq;

namespace Zad2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split();
            int n = int.Parse(Console.ReadLine());

            while(true)
            {
                string[] command = Console.ReadLine().Split();
                if (command[0] == "END")
                {
                    break;
                }
                switch (command[0])
                {
                    case "Reverse":
                        Array.Reverse(arr);
                        break;
                    case "Distinct":
                        arr = arr.Distinct().ToArray();
                        break;
                    case "Replace":
                        int index = int.Parse(command[1]);
                        if (index <0 || index >= arr.Length)
                        {
                            Console.WriteLine("Invalid input!");
                        }
                        break;
                    case "Print":
                        var result = arr.Where(x => x.StartsWith(command[1])).ToArray();
                        Console.WriteLine(string.Join(" ", arr));
                        break;
                    default:
                        Console.WriteLine("Invalid input!");
                        break;
                }
            }
            Console.WriteLine(string.Join(", ", arr));
        }
    }
}
