using System;
using NUnit.Framework;
namespace Solution
{
    [TestFixture]
    public class BrainLuckTest
    {
        // Echo until byte(255) encountred
        [Test]
        public void test1()
        {
            Assert.AreEqual("Codewars", Kata.BrainLuck(",+[-.,+]", "Codewars" + char.ConvertFromUtf32(255)), "Should return \"Codewars\" ");
        }

        // Echo until byte(0) encountred
        [Test]
        public void test2()
        {
            Assert.AreEqual("Codewars", Kata.BrainLuck(",[.[-],]", "Codewars" + char.ConvertFromUtf32(0)), "Should return \"Codewars\" ");
        }

        // Two numbers multiplier
        [Test]
        public void test3()
        {
            Assert.AreEqual(char.ConvertFromUtf32(72), Kata.BrainLuck(",>,<[>[->+>+<<]>>[-<<+>>]<<<-]>>.", char.ConvertFromUtf32(8) + char.ConvertFromUtf32(9)), "Should return H");
        }
    }
}