// Challenge: https://www.hackerrank.com/challenges/simple-array-sum
// Task: Given an array of n integers, find the sum of its elements.

using System;
using System.Linq;

namespace HackerRank
{
    class SimpleArraySum
    {
        static void Main(String[] args)
        {
            Console.ReadLine(); // Int n is irrelevant to solving the problem, so skipped
            int sum = 0;

            Console.ReadLine().Split(' ').Select(str => Int32.Parse(str)).ToList().ForEach(num => sum += num);
            // Parse ints from the string and add them to sum
            Console.WriteLine(sum);
        }

    }
}
