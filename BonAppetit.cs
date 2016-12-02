// Challenge: https://www.hackerrank.com/challenges/bon-appetit/
/*  Task: A and B order (n) items at a restaurant, but A declines to eat the (k)th item,
    where 0 < k < n. They split the cost of what they shared, but the check may not account
    for items that weren't shared.
    Given (n), (k), the cost of each of the (n) items, and total charged, write 'Bon Appetit'
    if the bill is fairly split; othwerise, print the amount that B owes to A.
*/
// Solution: Add all items that A ate, then see if half that cost is half of what was charged

using System;

namespace HackerRank
{
    class BonAppetit
    {
        static void Main(String[] args)
        {
            int[] Line1 = Array.ConvertAll<string, int>(Console.ReadLine().Split(' '), Int32.Parse); // First line of input contains n and k
            int n = Line1[0]; // Number of items
            int k = Line1[1]; // This is the k item that A doesn't want
            int[] price = Array.ConvertAll<string, int>(Console.ReadLine().Split(' '), Int32.Parse); // Second line has the prices of each item
            int charge = Convert.ToInt32(Console.ReadLine()); // How much they were charged for the items
            int sum = 0;

            for (int i = 0; i < n; i++) // Summing the prices of items that A ate
            {
                if (i == k)
                {
                    continue; // Don't add the k item that A didn't eat
                }
                else
                {
                    sum += price[i];
                }
            }
            sum /= 2;
            if (sum == charge)
            {
                Console.WriteLine("Bon Appetit"); // The bill was added correctly if what A paid == 1/2 the price of what A ate
            }
            else
            {
                Console.WriteLine(charge - sum); // If the bill is incorrect, this is the difference owed to A
            }
        }
    }
}