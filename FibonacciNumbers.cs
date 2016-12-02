// Challenge: https://www.hackerrank.com/challenges/ctci-fibonacci-numbers/
// Task: Given n, complete the fibonacci function so that it returns fibonacci(n).
// Solution: Create a recursive method that returns the next number in fibonacci sequence

using System;

namespace HackerRank
{
    class FibonacciNumbers
    {
        public static int Fibonacci(int n)
        {
            if (n < 2)
            {
                return n;
            }
            else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
        }

        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine()); // Starting number for fibonacci sequence
            Console.WriteLine(Fibonacci(n));
        }
    }
}
