using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Rrs.DateTimes;

namespace Tests.Rrs.DateTimes
{
    [TestClass]
    public class DateTimeRoundDownTests
    {
        [TestMethod]
        public void TestRoundDownToTheSecondFrom500Milliseconds()
        {
            var date = new DateTime(2000, 1, 1, 12, 0, 0, 500);
            var span = TimeSpan.FromSeconds(1);
            var r = date.RoundDown(span);

            Assert.AreEqual(new DateTime(2000, 1, 1, 12, 0, 0), r);
        }

        [TestMethod]
        public void TestRoundDownToTheSecondFrom700Milliseconds()
        {
            var date = new DateTime(2000, 1, 1, 12, 0, 0, 700);
            var span = TimeSpan.FromSeconds(1);
            var r = date.RoundDown(span);

            Assert.AreEqual(new DateTime(2000, 1, 1, 12, 0, 0), r);
        }

        [TestMethod]
        public void TestRoundDownToTheMinuteFrom30Seconds()
        {
            var date = new DateTime(2000, 1, 1, 12, 0, 30);
            var span = TimeSpan.FromMinutes(1);
            var r = date.RoundDown(span);

            Assert.AreEqual(new DateTime(2000, 1, 1, 12, 0, 0), r);
        }

        [TestMethod]
        public void TestRoundDownToTheMinuteFrom50Seconds()
        {
            var date = new DateTime(2000, 1, 1, 12, 0, 50);
            var span = TimeSpan.FromMinutes(1);
            var r = date.RoundDown(span);

            Assert.AreEqual(new DateTime(2000, 1, 1, 12, 0, 0), r);
        }

        [TestMethod]
        public void TestRoundDownToTheHourFrom30Minutes()
        {
            var date = new DateTime(2000, 1, 1, 12, 30, 0);
            var span = TimeSpan.FromHours(1);
            var r = date.RoundDown(span);

            Assert.AreEqual(new DateTime(2000, 1, 1, 12, 0, 0), r);
        }

        [TestMethod]
        public void TestRoundDownToTheHourFrom50Minutes()
        {
            var date = new DateTime(2000, 1, 1, 12, 50, 0);
            var span = TimeSpan.FromHours(1);
            var r = date.RoundDown(span);

            Assert.AreEqual(new DateTime(2000, 1, 1, 12, 0, 0), r);
        }

        [TestMethod]
        public void TestRoundDownToTheDayFrom12Hours()
        {
            var date = new DateTime(2000, 1, 1, 12, 0, 0);
            var span = TimeSpan.FromDays(1);
            var r = date.RoundDown(span);

            Assert.AreEqual(new DateTime(2000, 1, 1, 0, 0, 0), r);
        }

        [TestMethod]
        public void TestRoundDownToTheDayFrom20Hours()
        {
            var date = new DateTime(2000, 1, 1, 20, 0, 0);
            var span = TimeSpan.FromDays(1);
            var r = date.RoundDown(span);

            Assert.AreEqual(new DateTime(2000, 1, 1, 0, 0, 0), r);
        }
    }
}
