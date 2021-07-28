namespace Solution
{
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;

    namespace Solution
    {
        [TestFixture]
        public class SolutionTest
        {
            //[Test]
            //public void TestToRoman_001()
            //{
            //    int input = 1;
            //    string expected = "I";

            //    string actual = RomanNumerals.ToRoman(input);

            //    Assert.AreEqual(expected, actual);
            //}

            //[Test]
            //public void TestToRoman_002()
            //{
            //    int input = 2;
            //    string expected = "II";

            //    string actual = RomanNumerals.ToRoman(input);

            //    Assert.AreEqual(expected, actual);
            //}

            [Test]
            public void TestFromRoman_001()
            {
                string input = "I";
                int expected = 1;

                int actual = RomanNumerals.FromRoman(input);

                Assert.AreEqual(expected, actual);
            }

            [Test]
            public void TestFromRoman_002()
            {
                string input = "II";
                int expected = 2;

                int actual = RomanNumerals.FromRoman(input);

                Assert.AreEqual(expected, actual);
            }
            [Test]
            public void TestFromRoman_003()
            {
                string input = "IX";
                int expected = 9;

                int actual = RomanNumerals.FromRoman(input);

                Assert.AreEqual(expected, actual);
            }
        }
    }
}