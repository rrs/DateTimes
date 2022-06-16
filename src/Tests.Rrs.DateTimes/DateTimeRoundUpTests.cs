using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Rrs.DateTimes;

namespace Tests.Rrs.DateTimes
{
    [TestClass]
    public class DateTimeRoundUpTests
    {
        [TestMethod]
        public void TestRoundUpToTheSecondFrom500Milliseconds()
        {
            var date = new DateTime(2000, 1, 1, 12, 0, 0, 500);
            var span = TimeSpan.FromSeconds(1);
            var r = date.RoundUp(span);

            Assert.AreEqual(new DateTime(2000, 1, 1, 12, 0, 1), r);
        }

        [TestMethod]
        public void TestRoundUpToTheSecondFrom200Milliseconds()
        {
            var date = new DateTime(2000, 1, 1, 12, 0, 0, 200);
            var span = TimeSpan.FromSeconds(1);
            var r = date.RoundUp(span);

            Assert.AreEqual(new DateTime(2000, 1, 1, 12, 0, 1), r);
        }

        [TestMethod]
        public void TestRoundUpToTheSecondUpToTheMinute()
        {
            var date = new DateTime(2000, 1, 1, 12, 0, 59, 500);
            var span = TimeSpan.FromSeconds(1);
            var r = date.RoundUp(span);

            Assert.AreEqual(new DateTime(2000, 1, 1, 12, 1, 0), r);
        }

        [TestMethod]
        public void TestRoundUpToTheMinuteFrom30Seconds()
        {
            var date = new DateTime(2000, 1, 1, 12, 0, 30);
            var span = TimeSpan.FromMinutes(1);
            var r = date.RoundUp(span);

            Assert.AreEqual(new DateTime(2000, 1, 1, 12, 1, 0), r);
        }

        [TestMethod]
        public void TestRoundUpToTheMinuteFrom10Seconds()
        {
            var date = new DateTime(2000, 1, 1, 12, 0, 10);
            var span = TimeSpan.FromMinutes(1);
            var r = date.RoundUp(span);

            Assert.AreEqual(new DateTime(2000, 1, 1, 12, 1, 0), r);
        }

        [TestMethod]
        public void TestRoundUpToTheMinuteUpToTheHour()
        {
            var date = new DateTime(2000, 1, 1, 12, 59, 30);
            var span = TimeSpan.FromMinutes(1);
            var r = date.RoundUp(span);

            Assert.AreEqual(new DateTime(2000, 1, 1, 13, 0, 0), r);
        }

        [TestMethod]
        public void TestRoundUpToTheHourFrom30Minutes()
        {
            var date = new DateTime(2000, 1, 1, 12, 30, 0);
            var span = TimeSpan.FromHours(1);
            var r = date.RoundUp(span);

            Assert.AreEqual(new DateTime(2000, 1, 1, 13, 0, 0), r);
        }

        [TestMethod]
        public void TestRoundUpToTheHourFrom10Minutes()
        {
            var date = new DateTime(2000, 1, 1, 12, 10, 0);
            var span = TimeSpan.FromHours(1);
            var r = date.RoundUp(span);

            Assert.AreEqual(new DateTime(2000, 1, 1, 13, 0, 0), r);
        }

        [TestMethod]
        public void TestRoundUpToTheHourUpToTheDay()
        {
            var date = new DateTime(2000, 1, 1, 23, 59, 0);
            var span = TimeSpan.FromHours(1);
            var r = date.RoundUp(span);

            Assert.AreEqual(new DateTime(2000, 1, 2, 0, 0, 0), r);
        }

        [TestMethod]
        public void TestRoundUpToTheDayFrom12Hours()
        {
            var date = new DateTime(2000, 1, 1, 12, 0, 0);
            var span = TimeSpan.FromDays(1);
            var r = date.RoundUp(span);

            Assert.AreEqual(new DateTime(2000, 1, 2, 0, 0, 0), r);
        }

        [TestMethod]
        public void TestRoundUpToTheDayFrom2Hours()
        {
            var date = new DateTime(2000, 1, 1, 2, 0, 0);
            var span = TimeSpan.FromDays(1);
            var r = date.RoundUp(span);

            Assert.AreEqual(new DateTime(2000, 1, 2, 0, 0, 0), r);
        }

        [TestMethod]
        public void TestRoundUpToTheDayUpToTheMonth()
        {
            var date = new DateTime(2000, 1, 31, 12, 0, 0);
            var span = TimeSpan.FromDays(1);
            var r = date.RoundUp(span);

            Assert.AreEqual(new DateTime(2000, 2, 1, 0, 0, 0), r);
        }
    }
}
