namespace Solution
{
    using NUnit.Framework;

    using Interval = System.ValueTuple<int, int>;

    public class IntervalTest
    {
        [Test]
        public void ShouldHandleEmptyIntervals()
        {
            Assert.AreEqual(0, Intervals.SumIntervals(new Interval[] { }));
            Assert.AreEqual(0, Intervals.SumIntervals(new Interval[] { (4, 4), (6, 6), (8, 8) }));
        }

        [Test]
        public void ShouldAddDisjoinedIntervals()
        {
            Assert.AreEqual(9, Intervals.SumIntervals(new Interval[] { (1, 2), (6, 10), (11, 15) }));
            Assert.AreEqual(11, Intervals.SumIntervals(new Interval[] { (4, 8), (9, 10), (15, 21) }));
            Assert.AreEqual(7, Intervals.SumIntervals(new Interval[] { (-1, 4), (-5, -3) }));
            Assert.AreEqual(78, Intervals.SumIntervals(new Interval[] { (-245, -218), (-194, -179), (-155, -119) }));
        }

        [Test]
        public void ShouldAddAdjacentIntervals()
        {
            Assert.AreEqual(54, Intervals.SumIntervals(new Interval[] { (1, 2), (2, 6), (6, 55) }));
            Assert.AreEqual(23, Intervals.SumIntervals(new Interval[] { (-2, -1), (-1, 0), (0, 21) }));
        }

        [Test]
        public void ShouldAddOverlappingIntervals()
        {
            Assert.AreEqual(7, Intervals.SumIntervals(new Interval[] { (1, 4), (7, 10), (3, 5) }));
            Assert.AreEqual(6, Intervals.SumIntervals(new Interval[] { (5, 8), (3, 6), (1, 2) }));
            Assert.AreEqual(19, Intervals.SumIntervals(new Interval[] { (1, 5), (10, 20), (1, 6), (16, 19), (5, 11) }));
        }

        [Test]
        public void ShouldHandleMixedIntervals()
        {
            Assert.AreEqual(13, Intervals.SumIntervals(new Interval[] { (2, 5), (-1, 2), (-40, -35), (6, 8) }));
            Assert.AreEqual(1234, Intervals.SumIntervals(new Interval[] { (-7, 8), (-2, 10), (5, 15), (2000, 3150), (-5400, -5338) }));
            Assert.AreEqual(158, Intervals.SumIntervals(new Interval[] { (-101, 24), (-35, 27), (27, 53), (-105, 20), (-36, 26) }));
        }
        [Test]
        public void ShouldHandleRandomIntervals()
        {
            Assert.AreEqual(19461, Intervals.SumIntervals(new Interval[] { (-6432, 9700), (-4562, 6732), (-273, 3749), (-8833, 3611), 
                (-362, 7468), (-8341, 4846), (-9761, -8103) ,
            (-4702, 2104), (-8280, 2864), (6201, 7444), (-4971, 4828), (7282, 7657), (-9761, -8103), (-4224, -296), (-1751, 1759),
            (-2281, 7737), (-5417, 7391), (1370, 5183), (-3476, 7707), (-6860, -182), (-9322, -8943), (5615, 8701), (2067, 3034), (-5007, 1288)}));
            //    (-1311, 5982) , (-4945, -1028), (3412, 9351), (-6296, -6241), (-3715, 7128), (-6460, 9460), (-5956, 956), (-8522, -8149), (-8081, -6571) }));
            //    //Assert.AreEqual(1234, Intervals.SumIntervals(new Interval[] { (-7, 8), (-2, 10), (5, 15), (2000, 3150), (-5400, -5338) }));
            //    //Assert.AreEqual(158, Intervals.SumIntervals(new Interval[] { (-101, 24), (-35, 27), (27, 53), (-105, 20), (-36, 26) }));
        }
}






}