// Challenge: https://www.hackerrank.com/challenges/a-very-big-sum
// Task: From an array of integers of size n, print the sum of the elements, which may be large.

using System;
using System.Linq;

namespace HackerRank
{
    class AVeryBigSum
    {
        static void Main(String[] args)
        {
            Console.ReadLine(); // Int n is actually unncessary for this challenge, so it's skipped.
            long sum = 0;

            Console
                .ReadLine()
                .Split(' ')
                .Select(str => long.Parse(str)) // Parse into a long integer
                .ToList()
                .ForEach(num => sum += num); // Add each to the sum

            Console.WriteLine(sum);
        }
    }
}