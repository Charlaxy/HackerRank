// Challenge: https://www.hackerrank.com/challenges/ctci-lonely-integer/
// Task: Given an array a, find the element that doesn't occur twice, and print it.

using System;

namespace HackerRank
{
    class LonelyInteger
    {
        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine()); // Number of ints in array
            string[] line = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(line, Int32.Parse); // Array a of ints

            for (int i = 0; i < a.Length; i++)
            {
                if (Array.IndexOf(a, a[i], i + 1) < 0 && Array.IndexOf(a, a[i]) == i)
                {   // If there is no number that matches the current one in foreach loop
                    Console.WriteLine(a[i]); // Print current int
                    return;
                }
            }
        }
    }
}
