using System;
using System.Linq;

namespace _2._Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            Action<int []> pointToPrintCount = PrintCount;
            pointToPrintCount(array);
            
            Action<int []> pointToPrintSum = PrintSum;
            pointToPrintSum(array);
            
        }
        static void PrintCount(int[] array)
        {
            Console.WriteLine(array.Length);
        }
        static void PrintSum(int[] array)
        {
            Console.WriteLine(array.Sum());
        }
    }
}

