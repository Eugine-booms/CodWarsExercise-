namespace CodeWars.Exercise.Replace_all_dots
{

    using NUnit.Framework;

    [TestFixture]
    public class SolutionTest
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual("one-two-three", Kata.ReplaceDots("one.two.three"));
        }
    }

}
