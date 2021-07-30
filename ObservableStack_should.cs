using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
namespace Solution
{
    [TestFixture]
    public class Test
    {
        [Test]
        public void ShouldWorkTest()
        {
            Assert.AreEqual(0, Kata.IsInteresting(3, new List<int>() { 1337, 256 }));
            //Assert.AreEqual(1, Kata.IsInteresting(1336, new List<int>() { 1337, 256 }));
            Assert.AreEqual(2, Kata.IsInteresting(1337, new List<int>() { 1337, 256 }));
            Assert.AreEqual(2, Kata.IsInteresting(11111, new List<int>() { 1337, 256 }));
            Assert.AreEqual(2, Kata.IsInteresting(1337, new List<int>() { 1337, 256 }));
            Assert.AreEqual(1, Kata.IsInteresting(11209, new List<int>() { 1337, 256 }));
            Assert.AreEqual(2, Kata.IsInteresting(11211, new List<int>() { 1337, 256 }));
        }
    }
}