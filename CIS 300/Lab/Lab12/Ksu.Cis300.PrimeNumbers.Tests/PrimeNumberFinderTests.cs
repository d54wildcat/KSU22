/* PrimeNumberFinderTests.cs
 * Author: Rod Howell
 */
using NUnit.Framework;
using System;
using System.Text;

namespace Ksu.Cis300.PrimeNumbers.Tests
{
    /// <summary>
    /// A unit test class for the class PrimeNumberFinder.
    /// </summary>
    [TestFixture]
    public class PrimeNumberFinderTests
    {
        /// <summary>
        /// Places the elements of the given linked list into a StringBuilder.
        /// The elements are each followed by the character ';'.
        /// </summary>
        /// <param name="list">The list to copy.</param>
        /// <returns>A StringBuilder containing the elements of the given linked list.</returns>
        private StringBuilder ToStringBuilder(LinkedListCell<int> list)
        {
            StringBuilder sb = new StringBuilder();
            for (LinkedListCell<int> p = list; p != null; p = p.Next)
            {
                sb.Append(p.Data).Append(';');
            }
            return sb;
        }

        /// <summary>
        /// Tests GetNumbersLessThan to ensure that when given 0, it returns null.
        /// </summary>
        [Test, Timeout(1000)]
        public void TestAGetAllLessThan0()
        {
            Assert.That(PrimeNumberFinder.GetNumbersLessThan(0), Is.Null);
        }

        /// <summary>
        /// Tests GetNumbersLessThan to ensure that when given 2, it returns null.
        /// </summary>
        [Test, Timeout(1000)]
        public void TestAGetAllLessThan2()
        {
            Assert.That(PrimeNumberFinder.GetNumbersLessThan(2), Is.Null);
        }

        /// <summary>
        /// Tests GetNumbersLessThan on 10.
        /// </summary>
        [Test, Timeout(1000)]
        public void TestAGetAllLessThan10()
        {
            LinkedListCell<int> list = PrimeNumberFinder.GetNumbersLessThan(10);
            StringBuilder sb = ToStringBuilder(list);
            Assert.That(sb.ToString(), Is.EqualTo("2;3;4;5;6;7;8;9;"));
        }

        /// <summary>
        /// Tests that RemoveMultiples can remove all multiples of 2 following 2 in the 
        /// list of integers greater than 1 and less than 10.
        /// </summary>
        [Test, Timeout(1000)]
        public void TestBSingleRemoveMultiples()
        {
            LinkedListCell<int> list = PrimeNumberFinder.GetNumbersLessThan(10);
            PrimeNumberFinder.RemoveMultiples(2, list);
            StringBuilder sb = ToStringBuilder(list);
            Assert.That(sb.ToString(), Is.EqualTo("2;3;5;7;9;"));
        }

        /// <summary>
        /// Tests that RemoveMultiples can remove all multiples of 2 following 2 in the
        /// list of integers greater than 1 and less than 26, then remove all multiples of
        /// 5 following 5 in the resulting list. The second call will need to remove the
        /// last element of the list.
        /// </summary>
        [Test, Timeout(1000)]
        public void TestCDoubleRemoveMultiples()
        {
            LinkedListCell<int> list = PrimeNumberFinder.GetNumbersLessThan(26);
            PrimeNumberFinder.RemoveMultiples(2, list);
            PrimeNumberFinder.RemoveMultiples(5, list.Next.Next);
            StringBuilder sb = ToStringBuilder(list);
            Assert.That(sb.ToString(), Is.EqualTo("2;3;5;7;9;11;13;17;19;21;23;"));
        }

        /// <summary>
        /// Tests GetPrimesLessThan on 20.
        /// </summary>
        [Test, Timeout(1000)]
        public void TestDFindPrimesLessThan20()
        {
            LinkedListCell<int> list = PrimeNumberFinder.GetPrimesLessThan(20);
            StringBuilder sb = ToStringBuilder(list);
            Assert.That(sb.ToString(), Is.EqualTo("2;3;5;7;11;13;17;19;"));
        }

        /// <summary>
        /// Tests GetPrimesLessThan on 26. This tests whether the square of a prime at
        /// the end of the list is removed. This makes sure the optimization doesn't end
        /// the method too soon.
        /// </summary>
        [Test, Timeout(1000)]
        public void TestDFindPrimesLessThan26()
        {
            LinkedListCell<int> list = PrimeNumberFinder.GetPrimesLessThan(26);
            StringBuilder sb = ToStringBuilder(list);
            Assert.That(sb.ToString(), Is.EqualTo("2;3;5;7;11;13;17;19;23;"));
        }

        /// <summary>
        /// Tests GetPrimesLessThan on 2. The list returned should be null.
        /// </summary>
        [Test, Timeout(1000)]
        public void TestEFindPrimesLessThan2()
        {
            Assert.That(PrimeNumberFinder.GetPrimesLessThan(2), Is.Null);
        }

        /// <summary>
        /// Tests the time it takes to find all primes less than 1,000,000.
        /// If the optimization is correct, it should take no more than a couple
        /// of seconds.
        /// </summary>
        [Test, Timeout(5000)]
        public void TestFFindPrimesLessThanMillion()
        {
            PrimeNumberFinder.GetPrimesLessThan(1000000);
            Assert.Pass("Test complete.");
        }
    }
}