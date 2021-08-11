    using NUnit.Framework;
    using System;
    using System.Collections.Generic;
using System.Linq;

namespace Solution
    {
       
        public class SolutionTest
        {
            [Test]
            public void Example1()
            {
                Assert.AreEqual(new List<string> { "a" }, Permutations.SinglePermutations("a").OrderBy(x => x).ToList());
            }
        [Test]
        public void Example1_2()
        {
            Assert.AreEqual(new List<string> { "aa" }, Permutations.SinglePermutations("aa").OrderBy(x => x).ToList());
        }

        [Test]
            public void Example2()
            {
                    Assert.AreEqual(new List<string> { "ab", "ba" }, Permutations.SinglePermutations("ab").OrderBy(x => x).ToList());
            }
        [Test]
        public void Example2_1()
        {
            Assert.AreEqual(new List<string> { "abc", "acb", "bac", "bca", "cab", "cba" }, Permutations.SinglePermutations("abc").OrderBy(x => x).ToList());
        }
        [Test]
            public void Example3()
            {
                Assert.AreEqual(new List<string> { "aabb", "abab", "abba", "baab", "baba", "bbaa" }, Permutations.SinglePermutations("aabb").OrderBy(x => x).ToList());
            }
        }
    }
