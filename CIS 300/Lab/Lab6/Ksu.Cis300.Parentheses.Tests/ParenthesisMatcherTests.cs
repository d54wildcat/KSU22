/* ParenthesisMatcherTests.cs
 * Author: Rod Howell
 */
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ksu.Cis300.Parentheses;

namespace Ksu.Cis300.Parentheses.Tests
{
    /// <summary>
    /// A unit test class for the class library Ksu.Cis300.Parentheses.
    /// </summary>
    [TestFixture]
    public class ParenthesisMatcherTests
    {
        /// <summary>
        /// Checks the empty string, which is balanced.
        /// </summary>
        [Test, Timeout(1000)]
        public void TestAEmptyString()
        {
            Assert.That(ParenthesisMatcher.IsBalanced(""), Is.True);
        }

        /// <summary>
        /// Checks the string "abcdefg", which is balanced.
        /// </summary>
        [Test, Timeout(1000)]
        public void TestBNoParentheses()
        {
            Assert.That(ParenthesisMatcher.IsBalanced("abcdefg"), Is.True);
        }

        /// <summary>
        /// Checks the string "[", which is not balanced.
        /// </summary>
        [Test, Timeout(1000)]
        public void TestCOpeningParenthesis()
        {
            Assert.That(ParenthesisMatcher.IsBalanced("["), Is.False);
        }

        /// <summary>
        /// Checks the string ")", which is not balanced.
        /// </summary>
        [Test, Timeout(1000)]
        public void TestDClosingParenthesis()
        {
            Assert.That(ParenthesisMatcher.IsBalanced(")"), Is.False);
        }

        /// <summary>
        /// Tests the string "{{}", which is not balanced.
        /// </summary>
        [Test, Timeout(1000)]
        public void TestEMissingClose()
        {
            Assert.That(ParenthesisMatcher.IsBalanced("{{}"), Is.False);
        }

        /// <summary>
        /// Tests the string "[[]", which is not balanced.
        /// </summary>
        [Test, Timeout(1000)]
        public void TestEExtraClose()
        {
            Assert.That(ParenthesisMatcher.IsBalanced("[]]"), Is.False);
        }

        /// <summary>
        /// Tests the string "[}", which is not balanced.
        /// </summary>
        [Test, Timeout(1000)]
        public void TestEMismatch()
        {
            Assert.That(ParenthesisMatcher.IsBalanced("[}"), Is.False);
        }

        /// <summary>
        /// Tests the string "[}]", which is not balanced.
        /// </summary>
        [Test, Timeout(1000)]
        public void TestEMismatch2()
        {
            Assert.That(ParenthesisMatcher.IsBalanced("[}]"), Is.False);
        }

        /// <summary>
        /// Tests the string "(a{[]b({})}c)[]", which is balanced.
        /// </summary>
        [Test, Timeout(1000)]
        public void TestFLongMatch()
        {
            Assert.That(ParenthesisMatcher.IsBalanced("(a{[]b({})}c)[]"), Is.True);
        }

        /// <summary>
        /// Tests the string "(a{[]b({})}c)[](", whose last parenthesis is not matched.
        /// </summary>
        [Test, Timeout(1000)]
        public void TestFLongMissingClose()
        {
            Assert.That(ParenthesisMatcher.IsBalanced("(a{[]b({})}c)[]("), Is.False);
        }

        /// <summary>
        /// Tests the string "(a{[]b({})}c)[]())", whose last parenthesis is not matched.
        /// </summary>
        [Test, Timeout(1000)]
        public void TestFLongExtraClose()
        {
            Assert.That(ParenthesisMatcher.IsBalanced("(a{[]b({})}c)[]())"), Is.False);
        }

        /// <summary>
        /// Tests the string "(a{[]b({})}c}[]", whose first character is paired with the last '}', and
        /// hence is mismatched.
        /// </summary>
        [Test, Timeout(1000)]
        public void TestFLongMismatch()
        {
            Assert.That(ParenthesisMatcher.IsBalanced("(a{[]b({})}c}[]"), Is.False);
        }
    }
}