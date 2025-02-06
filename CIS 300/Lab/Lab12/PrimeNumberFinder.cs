/*PrimeNumberFinder.cs
 * Author: Dacey Wieland
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ksu.Cis300.PrimeNumbers
{
    public static class PrimeNumberFinder
    {
        /// <summary>
        /// Method to get the numbers that are less than n and set it to the list
        /// </summary>
        /// <param name="n">The number we are trying to find the primes that are less than</param>
        /// <returns>Returns the list that we pushed into</returns>
        public static LinkedListCell<int> GetNumbersLessThan(int n)
        {
            LinkedListCell<int> list = null;
            for (int i = n - 1; i > 1; i--)
            {
                LinkedListCell<int> cell = new LinkedListCell<int>();
                cell.Data = i;
                cell.Next = list;
                list = cell;
            }
            return list;
        }
        /// <summary>
        /// Method to remove any numbers that are divisible by k and setting the list to the next next cell
        /// </summary>
        /// <param name="k"> A number to see if the list has any numbers divisible by it</param>
        /// <param name="list"> the list that contains the numbers we are checking</param>
        public static void RemoveMultiples(int k, LinkedListCell<int> list)
        {
            while (list.Next != null)
            {
                if(list.Next.Data % k == 0)
                {
                    list.Next = list.Next.Next;
                }
                else
                {
                    list = list.Next;
                }
            }
        }
        /// <summary>
        /// Method that gets all the prime numbers less than n, using the previous two methods above
        /// </summary>
        /// <param name="n">The number we want to find the primes less than</param>
        /// <returns>Returns the list of primes numbers that are less than n</returns>
        public static LinkedListCell<int> GetPrimesLessThan(int n)
        {
            LinkedListCell<int> list = GetNumbersLessThan(n);
            for (LinkedListCell<int> p = list; p != null && p.Data * p.Data < n; p = p.Next){
                RemoveMultiples(p.Data, p);
            }
            return list;
        }
    }
}
