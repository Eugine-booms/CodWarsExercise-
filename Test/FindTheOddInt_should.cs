using NUnit.Framework;

namespace Delegates.Observers.Exercise.FindTheOddInt
{
    [TestFixture]
    public class FindTheOddInt_should
    {
        [Test]
        public void Tests()
        {
            Assert.AreEqual(5, Kata.Find_it(new[] { 20, 1, -1, 2, -2, 3, 3, 5, 5, 1, 2, 4, 20, 4, -1, -2, 5 }));
        }
    }
}

