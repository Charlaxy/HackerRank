// Challenge: https://www.hackerrank.com/challenges/diagonal-difference/
// Task: Given a square matrix of size N * N, find the absolute difference between the sum of its diagonals.

using System;
using System.Linq;

namespace HackerRank
{
    class DiagonalDifference
    {
        static void Main(String[] args)
        {
            int n = Int32.Parse(Console.ReadLine()); // Number of rows
            int[][] ints = new int[n][]; // Create a 2D array of n size
            int num1 = 0;
            int num2 = 0;

            for (int i = 0; i < n; i++)
            {
                ints[i] = Console.ReadLine().Split(' ').Select(str => Int32.Parse(str)).ToArray();
                // Populate each value of the first array (rows) with an array (columns)
            }

            for (int i = 0; i < n; i++)
            {
                num1 += ints[i][i]; // Sum up the numbers across one diagonal section
            }

            for (int j = n - 1; j >= 0; j--)
            {
                num2 += ints[j][(n - 1) - j]; // Sum up the other diagonal
            }

            int dif = Math.Abs(num2 - num1); // Find absolute difference

            Console.WriteLine(dif);
        }
    }
}