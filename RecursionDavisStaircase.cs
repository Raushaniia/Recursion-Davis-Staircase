using System;
using System.Collections.Generic;

namespace RecursionDavisStaircase
{
    class Program
    {
        public static Dictionary<int, int> dict = new Dictionary<int, int>();
        static void Main(string[] args)
        {
            dict.Add(0, 1);
            int n = 7;
            int c = CountSteps(n);
            Console.WriteLine(c);
            Console.ReadLine();
        }
        public static int CountSteps(int stairsNum)
        {
            if (stairsNum < 0)
            {
               return 0;
            }
            if (dict.ContainsKey(stairsNum)) {
               return dict[stairsNum];
            }
            int ways = CountSteps(stairsNum - 1) + CountSteps(stairsNum - 2) + CountSteps(stairsNum - 3);
            dict.Add(stairsNum, ways);
            return ways;
        }
    }
}
