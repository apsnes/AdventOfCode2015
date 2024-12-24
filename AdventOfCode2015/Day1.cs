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
    }
}
