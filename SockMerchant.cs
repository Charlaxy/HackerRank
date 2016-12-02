//  Challenge: https://www.hackerrank.com/challenges/sock-merchant/
/*  A store has a pile of unmatched socks. Sock (i) is labeled with an int c(i), denoting color.
    Find the matching pairs where c(i) == c(j).
*/

using System;

namespace HackerRank
{
    class SockMerchant
    {
        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine()); // Number of socks
            string[] line2 = Console.ReadLine().Split(' ');
            int[] c = Array.ConvertAll(line2, Int32.Parse); // Array of ints describing color values
            int sum = 0; // Number of matching pairs

            for (int i = 0; i < c.Length; i++) // Get each value from the array
            {
                if (c[i] == 0)
                {
                    continue; // If no value in c[i], then skip
                }
                int index = Array.IndexOf(c, c[i], i + 1); // In array c, find the next value, set index to it
                if (index > -1)
                {
                    c[index] = 0;
                    c[i] = 0; // Set values back to 0
                    sum++;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
