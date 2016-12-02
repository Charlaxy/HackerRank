// Challenge: https://www.hackerrank.com/challenges/ctci-making-anagrams/
// Task: Given strings a and b, find the min number of character deletions needed to make a and b anagrams.

using System;

namespace HackerRank
{
    class MakingAnagrams
    {
        static void Main(String[] args)
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            int sum = 0;

            for (int i = 0; i < a.Length; i++)
            {
                int index = b.LastIndexOf(a[i]);

                if (index < 0) // If a character from a isn't found in b
                {
                    sum++; // Increase sum
                }
                else
                {
                    a = a.Remove(i, 1);
                    b = b.Remove(index, 1); // Else, remove letter from both strings
                    i--;
                }
            }
            sum += b.Length;
            // Add to the sum anything leftover in b (string lengths may not be equal)
            Console.WriteLine(sum);
        }
    }
}