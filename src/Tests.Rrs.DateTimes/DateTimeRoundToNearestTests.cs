using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Rrs.DateTimes;

namespace Tests.Rrs.DateTimes
{
    [TestClass]
    public class DateTimeRoundToNearestTests
    {
        [TestMethod]
        public void TestRoundToNearestToTheSecondFrom500Milliseconds()
        {
            var date = new DateTime(2000, 1, 1, 12, 0, 0, 500);
            var span = TimeSpan.FromSeconds(1);
            var r = date.RoundToNearest(span);

            Assert.AreEqual(new DateTime(2000, 1, 1, 12, 0, 1), r);
        }

        [TestMethod]
        public void TestRoundToNearestToTheSecondFrom200Milliseconds()
        {
            var date = new DateTime(2000, 1, 1, 12, 0, 0, 200);
            var span = TimeSpan.FromSeconds(1);
            var r = date.RoundToNearest(span);

            Assert.AreEqual(new DateTime(2000, 1, 1, 12, 0, 0), r);
        }

        [TestMethod]
        public void TestRoundToNearestToTheSecondUpToTheMinute()
        {
            var date = new DateTime(2000, 1, 1, 12, 0, 59, 500);
            var span = TimeSpan.FromSeconds(1);
            var r = date.RoundToNearest(span);

            Assert.AreEqual(new DateTime(2000, 1, 1, 12, 1, 0), r);
        }

        [TestMethod]
        public void TestRoundToNearestToTheMinuteFrom30Seconds()
        {
            var date = new DateTime(2000, 1, 1, 12, 0, 30);
            var span = TimeSpan.FromMinutes(1);
            var r = date.RoundToNearest(span);

            Assert.AreEqual(new DateTime(2000, 1, 1, 12, 1, 0), r);
        }

        [TestMethod]
        public void TestRoundToNearestToTheMinuteFrom10Seconds()
        {
            var date = new DateTime(2000, 1, 1, 12, 0, 10);
            var span = TimeSpan.FromMinutes(1);
            var r = date.RoundToNearest(span);

            Assert.AreEqual(new DateTime(2000, 1, 1, 12, 0, 0), r);
        }

        [TestMethod]
        public void TestRoundToNearestToTheMinuteUpToTheHour()
        {
            var date = new DateTime(2000, 1, 1, 12, 59, 30);
            var span = TimeSpan.FromMinutes(1);
            var r = date.RoundToNearest(span);

            Assert.AreEqual(new DateTime(2000, 1, 1, 13, 0, 0), r);
        }

        [TestMethod]
        public void TestRoundToNearestToTheHourFrom30Minutes()
        {
            var date = new DateTime(2000, 1, 1, 12, 30, 0);
            var span = TimeSpan.FromHours(1);
            var r = date.RoundToNearest(span);

            Assert.AreEqual(new DateTime(2000, 1, 1, 13, 0, 0), r);
        }

        [TestMethod]
        public void TestRoundToNearestToTheHourFrom10Minutes()
        {
            var date = new DateTime(2000, 1, 1, 12, 10, 0);
            var span = TimeSpan.FromHours(1);
            var r = date.RoundToNearest(span);

            Assert.AreEqual(new DateTime(2000, 1, 1, 12, 0, 0), r);
        }

        [TestMethod]
        public void TestRoundToNearestToTheHourUpToTheDay()
        {
            var date = new DateTime(2000, 1, 1, 23, 59, 0);
            var span = TimeSpan.FromHours(1);
            var r = date.RoundToNearest(span);

            Assert.AreEqual(new DateTime(2000, 1, 2, 0, 0, 0), r);
        }

        [TestMethod]
        public void TestRoundToNearestToTheDayFrom12Hours()
        {
            var date = new DateTime(2000, 1, 1, 12, 0, 0);
            var span = TimeSpan.FromDays(1);
            var r = date.RoundToNearest(span);

            Assert.AreEqual(new DateTime(2000, 1, 2, 0, 0, 0), r);
        }

        [TestMethod]
        public void TestRoundToNearestToTheDayFrom2Hours()
        {
            var date = new DateTime(2000, 1, 1, 2, 0, 0);
            var span = TimeSpan.FromDays(1);
            var r = date.RoundToNearest(span);

            Assert.AreEqual(new DateTime(2000, 1, 1, 0, 0, 0), r);
        }

        [TestMethod]
        public void TestRoundToNearestToTheDayUpToTheMonth()
        {
            var date = new DateTime(2000, 1, 31, 12, 0, 0);
            var span = TimeSpan.FromDays(1);
            var r = date.RoundToNearest(span);

            Assert.AreEqual(new DateTime(2000, 2, 1, 0, 0, 0), r);
        }
    }
}
