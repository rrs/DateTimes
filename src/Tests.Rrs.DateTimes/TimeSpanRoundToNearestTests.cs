using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Rrs.DateTimes;

namespace Tests.Rrs.DateTimes
{
    [TestClass]
    public class TimeSpanRoundToNearestTests
    {
        [TestMethod]
        public void TestRoundToNearestToTheSecondFrom500Milliseconds()
        {
            var time = new TimeSpan(0, 0, 0, 0, 500);
            var span = TimeSpan.FromSeconds(1);
            var r = time.RoundToNearest(span);

            Assert.AreEqual(new TimeSpan(0, 0, 1), r);
        }

        [TestMethod]
        public void TestRoundToNearestToTheSecondFrom200Milliseconds()
        {
            var time = new TimeSpan(0, 0, 0, 1, 200);
            var span = TimeSpan.FromSeconds(1);
            var r = time.RoundToNearest(span);

            Assert.AreEqual(new TimeSpan(0, 0, 1), r);
        }

        [TestMethod]
        public void TestRoundToNearestToTheSecondUpToTheMinute()
        {
            var time = new TimeSpan(0, 0, 0, 59, 500);
            var span = TimeSpan.FromSeconds(1);
            var r = time.RoundToNearest(span);

            Assert.AreEqual(new TimeSpan(0, 1, 0), r);
        }

        [TestMethod]
        public void TestRoundToNearestToTheMinuteFrom30Seconds()
        {
            var time = new TimeSpan(0, 0, 30);
            var span = TimeSpan.FromMinutes(1);
            var r = time.RoundToNearest(span);

            Assert.AreEqual(new TimeSpan(0, 1, 0), r);
        }

        [TestMethod]
        public void TestRoundToNearestToTheMinuteFrom10Seconds()
        {
            var time = new TimeSpan(0, 1, 10);
            var span = TimeSpan.FromMinutes(1);
            var r = time.RoundToNearest(span);

            Assert.AreEqual(new TimeSpan(0, 1, 0), r);
        }

        [TestMethod]
        public void TestRoundToNearestToTheMinuteUpToTheHour()
        {
            var time = new TimeSpan(0, 59, 30);
            var span = TimeSpan.FromMinutes(1);
            var r = time.RoundToNearest(span);

            Assert.AreEqual(new TimeSpan(1, 0, 0), r);
        }

        [TestMethod]
        public void TestRoundToNearestToTheHourFrom30Minutes()
        {
            var time = new TimeSpan(1, 30, 0);
            var span = TimeSpan.FromHours(1);
            var r = time.RoundToNearest(span);

            Assert.AreEqual(new TimeSpan(2, 0, 0), r);
        }

        [TestMethod]
        public void TestRoundToNearestToTheHourFrom10Minutes()
        {
            var time = new TimeSpan(1, 10, 0);
            var span = TimeSpan.FromHours(1);
            var r = time.RoundToNearest(span);

            Assert.AreEqual(new TimeSpan(1, 0, 0), r);
        }

        [TestMethod]
        public void TestRoundToNearestToTheHourUpToTheDay()
        {
            var time = new TimeSpan(1, 23, 59, 0);
            var span = TimeSpan.FromHours(1);
            var r = time.RoundToNearest(span);

            Assert.AreEqual(new TimeSpan(2, 0, 0, 0), r);
        }

        [TestMethod]
        public void TestRoundToNearestToTheDayFrom12Hours()
        {
            var time = new TimeSpan(1, 12, 0, 0);
            var span = TimeSpan.FromDays(1);
            var r = time.RoundToNearest(span);

            Assert.AreEqual(new TimeSpan(2, 0, 0, 0), r);
        }

        [TestMethod]
        public void TestRoundToNearestToTheDayFrom2Hours()
        {
            var time = new TimeSpan(1, 2, 0, 0);
            var span = TimeSpan.FromDays(1);
            var r = time.RoundToNearest(span);

            Assert.AreEqual(new TimeSpan(1, 0, 0, 0), r);
        }
    }
}
