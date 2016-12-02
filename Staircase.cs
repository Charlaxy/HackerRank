// Challenge: https://www.hackerrank.com/challenges/staircase/
// Task: Make a staircase that ascends to the right of size n from #.

using System;

namespace HackerRank
{
    class Staircase
    {
        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine()); // Get an int for size of the staircase

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("{0}{1}", new String(' ', (n - i)), new String('#', i));
            }   // Write a line with n - i spaces, followed by i number of #
        }
    }
}
