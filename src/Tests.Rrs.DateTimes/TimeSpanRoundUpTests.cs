using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Rrs.DateTimes;

namespace Tests.Rrs.DateTimes
{
    [TestClass]
    public class TimeSpanRoundUpTests
    {
        [TestMethod]
        public void TestRoundUpToTheSecondFrom500Milliseconds()
        {
            var time = new TimeSpan(0, 0, 0, 0, 500);
            var span = TimeSpan.FromSeconds(1);
            var r = time.RoundUp(span);

            Assert.AreEqual(new TimeSpan(0, 0, 1), r);
        }

        [TestMethod]
        public void TestRoundUpToTheSecondFrom200Milliseconds()
        {
            var time = new TimeSpan(0, 0, 0, 0, 200);
            var span = TimeSpan.FromSeconds(1);
            var r = time.RoundUp(span);

            Assert.AreEqual(new TimeSpan(0, 0, 1), r);
        }

        [TestMethod]
        public void TestRoundUpToTheSecondUpToTheMinute()
        {
            var time = new TimeSpan(0, 0, 0, 59, 500);
            var span = TimeSpan.FromSeconds(1);
            var r = time.RoundUp(span);

            Assert.AreEqual(new TimeSpan(0, 1, 0), r);
        }

        [TestMethod]
        public void TestRoundUpToTheMinuteFrom30Seconds()
        {
            var time = new TimeSpan(0, 0, 30);
            var span = TimeSpan.FromMinutes(1);
            var r = time.RoundUp(span);

            Assert.AreEqual(new TimeSpan(0, 1, 0), r);
        }

        [TestMethod]
        public void TestRoundUpToTheMinuteFrom10Seconds()
        {
            var time = new TimeSpan(0, 0, 10);
            var span = TimeSpan.FromMinutes(1);
            var r = time.RoundUp(span);

            Assert.AreEqual(new TimeSpan(0, 1, 0), r);
        }

        [TestMethod]
        public void TestRoundUpToTheMinuteUpToTheHour()
        {
            var time = new TimeSpan(0, 59, 30);
            var span = TimeSpan.FromMinutes(1);
            var r = time.RoundUp(span);

            Assert.AreEqual(new TimeSpan(1, 0, 0), r);
        }

        [TestMethod]
        public void TestRoundUpToTheHourFrom30Minutes()
        {
            var time = new TimeSpan(0, 30, 0);
            var span = TimeSpan.FromHours(1);
            var r = time.RoundUp(span);

            Assert.AreEqual(new TimeSpan(1, 0, 0), r);
        }

        [TestMethod]
        public void TestRoundUpToTheHourFrom10Minutes()
        {
            var time = new TimeSpan(0, 10, 0);
            var span = TimeSpan.FromHours(1);
            var r = time.RoundUp(span);

            Assert.AreEqual(new TimeSpan(1, 0, 0), r);
        }

        [TestMethod]
        public void TestRoundUpToTheHourUpToTheDay()
        {
            var time = new TimeSpan(23, 59, 0);
            var span = TimeSpan.FromHours(1);
            var r = time.RoundUp(span);

            Assert.AreEqual(new TimeSpan(1, 0, 0, 0), r);
        }

        [TestMethod]
        public void TestRoundUpToTheDayFrom12Hours()
        {
            var time = new TimeSpan(12, 0, 0);
            var span = TimeSpan.FromDays(1);
            var r = time.RoundUp(span);

            Assert.AreEqual(new TimeSpan(1, 0, 0, 0), r);
        }

        [TestMethod]
        public void TestRoundUpToTheDayFrom2Hours()
        {
            var time = new TimeSpan(2, 0, 0);
            var span = TimeSpan.FromDays(1);
            var r = time.RoundUp(span);

            Assert.AreEqual(new TimeSpan(1, 0, 0, 0), r);
        }
    }
}
