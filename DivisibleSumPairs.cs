// Challenge: https://www.hackerrank.com/challenges/divisible-sum-pairs/
/*  Task: Given an array of (n) integers, a.0, a.1,...,a.n-1, and a positive integer (k),
    print the number of (i, j) pairs where i < j and a.i + a.j is evenly divisible by (k).
*/

using System;

namespace HackerRank
{
    class DivisibleSumPairs
    {
        static void Main(String[] args)
        {
            string[] line1 = Console.ReadLine().Split(' '); // First line contains n, k
            int n = Convert.ToInt32(line1[0]);
            int k = Convert.ToInt32(line1[1]);
            string[] line2 = Console.ReadLine().Split(' '); // Next line has integers, a.0...
            int[] a = Array.ConvertAll(line2, Int32.Parse);
            int count = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = i; j < n; j++) // Get the (i, j) pairs
                {
                    if (i < j) // Check each pair (i, j) to see if i < j
                    {
                        if ((a[i] + a[j]) % k == 0) // Check if evenly divisible by k
                        {
                            count++; // Add to count if it meets both requirements
                        }
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
