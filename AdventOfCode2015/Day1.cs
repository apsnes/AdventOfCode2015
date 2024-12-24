using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2015
{
    internal static class Day1
    {
        internal static int CountFloors()
        {
            string input = File.ReadAllText("Day1.txt");
            int floor = 0;
            foreach (char c in input)
            {
                if (c == '(')
                {
                    floor++;
                }
                else
                {
                    floor--;
                }
            }
            return floor;
        }
        internal static int FindBasement()
        {
            string input = File.ReadAllText("Day1.txt");
            int floor = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    floor++;
                }
                else
                {
                    floor--;
                }
                if (floor == -1)
                {
                    return i + 1;
                }
            }
            return 0;
        }
    }
}
