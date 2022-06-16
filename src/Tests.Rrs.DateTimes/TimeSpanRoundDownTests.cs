using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Rrs.DateTimes;

namespace Tests.Rrs.DateTimes
{
    [TestClass]
    public class TimeSpanRoundDownTests
    {
        [TestMethod]
        public void TestRoundDownToTheSecondFrom500Milliseconds()
        {
            var time = new TimeSpan(0, 0, 0, 1, 500);
            var span = TimeSpan.FromSeconds(1);
            var r = time.RoundDown(span);

            Assert.AreEqual(new TimeSpan(0, 0, 1), r);
        }

        [TestMethod]
        public void TestRoundDownToTheSecondFrom700Milliseconds()
        {
            var time = new TimeSpan(0, 0, 0, 1, 700);
            var span = TimeSpan.FromSeconds(1);
            var r = time.RoundDown(span);

            Assert.AreEqual(new TimeSpan(0, 0, 1), r);
        }

        [TestMethod]
        public void TestRoundDownToTheMinuteFrom30Seconds()
        {
            var time = new TimeSpan(0, 1, 30);
            var span = TimeSpan.FromMinutes(1);
            var r = time.RoundDown(span);

            Assert.AreEqual(new TimeSpan(0, 1, 0), r);
        }

        [TestMethod]
        public void TestRoundDownToTheMinuteFrom50Seconds()
        {
            var time = new TimeSpan(0, 1, 50);
            var span = TimeSpan.FromMinutes(1);
            var r = time.RoundDown(span);

            Assert.AreEqual(new TimeSpan(0, 1, 0), r);
        }

        [TestMethod]
        public void TestRoundDownToTheHourFrom30Minutes()
        {
            var time = new TimeSpan(1, 30, 0);
            var span = TimeSpan.FromHours(1);
            var r = time.RoundDown(span);

            Assert.AreEqual(new TimeSpan(1, 0, 0), r);
        }

        [TestMethod]
        public void TestRoundDownToTheHourFrom50Minutes()
        {
            var time = new TimeSpan(1, 50, 0);
            var span = TimeSpan.FromHours(1);
            var r = time.RoundDown(span);

            Assert.AreEqual(new TimeSpan(1, 0, 0), r);
        }

        [TestMethod]
        public void TestRoundDownToTheDayFrom12Hours()
        {
            var time = new TimeSpan(1, 12, 0, 0);
            var span = TimeSpan.FromDays(1);
            var r = time.RoundDown(span);

            Assert.AreEqual(new TimeSpan(1, 0, 0, 0), r);
        }

        [TestMethod]
        public void TestRoundDownToTheDayFrom20Hours()
        {
            var time = new TimeSpan(1, 20, 0, 0);
            var span = TimeSpan.FromDays(1);
            var r = time.RoundDown(span);

            Assert.AreEqual(new TimeSpan(1, 0, 0, 0), r);
        }
    }
}
