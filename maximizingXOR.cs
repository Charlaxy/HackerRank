// Challenge: https://www.hackerrank.com/challenges/maximizing-xor
// Task: Given integers l and r, find the maximal value of a xor b, where l <= a <= b <= r

using System;

namespace HackerRank
{
    public static class MaximizingXOR
    {
        static int maxXor(int l, int r)
        {
            int x = 0;
            for (int a = l; a <= r; a++)
            {
                for (int b = l; b <= r; b++)
                {
                    int y = a ^ b; // Set y to a xor b
                    if (y > x)
                    {
                        x = y; // Set x to y if y is larger
                    }
                }
            }
            return x; // Output the maximal value
        }

        #region This is HackerRank's code
        static void Main(String[] args)
        {
            int max;
            int _l;
            _l = Convert.ToInt32(Console.ReadLine());

            int _r;
            _r = Convert.ToInt32(Console.ReadLine());

            max = maxXor(_l, _r);
            Console.WriteLine(max);

        }
        #endregion
    }
}