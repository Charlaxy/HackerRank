// Challenge: https://www.hackerrank.com/challenges/compare-the-triplets/
/*  Task: A and B created a problem that is rated on a 1-100 scale based on 3 categories.
    Compare each of their 3 scores, giving A or B a point depending on who was higher.
*/

using System;

namespace HackerRank
{
    class CompareTheTriplets
    {
        static void Main(String[] args)
        {
            string[] line1 = Console.ReadLine().Split(' '); // Set of scores for A
            string[] line2 = Console.ReadLine().Split(' '); // Set of scores for B
            int a = 0; // Overall score for A
            int b = 0; // Overall score for B

            for (int i = 0; i < line1.Length; i++)
            {
                if (Convert.ToInt32(line1[i]) != Convert.ToInt32(line2[i])) // If the scores are unequal...
                {
                    if (Convert.ToInt32(line1[i]) > Convert.ToInt32(line2[i]))
                    {
                        a++; // Increase A's overall score if individual score is better...
                    }
                    else
                    {
                        b++; // Or increase B's
                    }
                }
            }
            Console.WriteLine(a + " " + b); // Output scores
        }
    }
}
