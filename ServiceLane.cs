// Challenge: https://www.hackerrank.com/challenges/service-lane
/*  Task: You are given an array width of length n, where width[k] represents the width of the k
    segment of the service lane. Lanes passed through will be at most 1000 segments, including
    the entry and exit.
    If width[k] = 1, only a bike can pass through the k segment.
    If width[k] = 2, the bike and car can pass through the k segment.
    If width[k] = 3, all three vehicles can pass through the k segment.
    Given the entry and exit point of a vehicle in the service lane, output the largest vehicle
    type that can pass through the service lane (including entry/exit segments).
*/

using System;
using System.Collections.Generic;

namespace HackerRank
{
    public static class ServiceLane
    {
        static void Main(string[] args)
        {
            string[] array1 = Console.ReadLine().Split(' ');
            string[] array2 = Console.ReadLine().Split(' '); // Widths
            int lanes = Convert.ToInt32(array1[0]); // Lanes of the freeway
            int tests = Convert.ToInt32(array1[1]); // Number of test cases
            List<Int32> widths = new List<Int32>(); // List for widths of the lanes

            for (int i = 0; i < lanes; i++)
            {
                widths.Add(Convert.ToInt32(array2[i])); // Add widths to list
            }

            for (int j = 0; j < tests; j++)
            {
                string[] line = Console.ReadLine().Split(' '); // Test cases with entry/exit values
                int enter = Convert.ToInt32(line[0]);
                int exit = Convert.ToInt32(line[1]);

                int length = exit - enter; // How far traveled
                int max = 3;

                for (int l = 0; l <= length; l++)
                {
                    int block = l + enter;

                    if (widths[block] < max)
                        // If width of any lanes traveled is < 3, reset the max size to that
                    {
                        max = widths[block];
                    }
                }
                Console.WriteLine(max);
            }
        }
    }
}