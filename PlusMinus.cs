// Challenge: https://www.hackerrank.com/challenges/plus-minus/
// Task: Given an array of ints, find which fraction are positive, negative, and zeroes, respectively.

using System;
using System.Linq;

namespace HackerRank
{
    class PlusMinus
    {
        static void Main(String[] args)
        {
            decimal n = Int32.Parse(Console.ReadLine()); // Number of ints in set
            int[] nums = Console.ReadLine().Split(' ').Select(str => Int32.Parse(str)).ToArray();
            // Make an array of ints
            decimal pos = 0;
            decimal neg = 0;
            decimal zero = 0;

            foreach (int num in nums)
            {
                if (num > 0)
                {
                    pos++;
                }
                else if (num < 0)
                {
                    neg++;
                }
                else
                {
                    zero++;
                }
            }
            Console.WriteLine(pos / n);
            Console.WriteLine(neg / n);
            Console.WriteLine(zero / n); // Find and write the fraction of each sign in ints
        }
    }
}