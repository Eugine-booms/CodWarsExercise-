namespace CodeWars.Exercise.Valid_Braces_6ku
{
    using NUnit.Framework;

    [TestFixture]
    public class BraceTests
    {

        [Test]
        public void Test1()
        {
            Assert.AreEqual(true, Brace.validBraces("()"));
        }
        [Test]
        public void Test2()
        {

            Assert.AreEqual(false, Brace.validBraces("[(])"));
        }
        [Test]
        public void Test3()
        {

            Assert.AreEqual(false, Brace.validBraces("}}]]))}])"));
        }
        [Test]
        public void Test4()
        {
            Assert.AreEqual(false, Brace.validBraces("(})"));
        }
    }

}
