namespace Exercise.SquareEveryDigit
{
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Exercise.SquareEveryDigit;

    [TestFixture]
    public class SquareEveryDigitTest
    {
       
            [Test]
            public void SquareDigitsTest()
            {
                Assert.AreEqual(811181, Kata.SquareDigits(9119));
                Assert.AreEqual(0, Kata.SquareDigits(0));
            }
        
    }

}