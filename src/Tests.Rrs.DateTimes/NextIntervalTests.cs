using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rrs.DateTimes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests.Rrs.DateTimes
{
    [TestClass]
    public class NextIntervalTests
    {
        [TestMethod]
        public void TestBeforeNextIntervalSeconds()
        {
            var now = new DateTime(2000, 1, 1, 12, 0, 0, 950);
            var rate = TimeSpan.FromSeconds(1);
            var nextInterval = IntervalHelper.NextInterval(now, rate);

            Assert.AreEqual(new DateTime(2000, 1, 1, 12, 0, 2, 0), nextInterval);
        }

        [TestMethod]
        public void TestAfterNextIntervalSeconds()
        {
            var now = new DateTime(2000, 1, 1, 12, 0, 1, 50);
            var rate = TimeSpan.FromSeconds(1);
            var nextInterval = IntervalHelper.NextInterval(now, rate);

            Assert.AreEqual(new DateTime(2000, 1, 1, 12, 0, 2, 0), nextInterval);
        }

        [TestMethod]
        public void TestNextIntervalSeconds()
        {
            var now = new DateTime(2000, 1, 1, 12, 0, 1, 0);
            var rate = TimeSpan.FromSeconds(1);
            var nextInterval = IntervalHelper.NextInterval(now, rate);

            Assert.AreEqual(new DateTime(2000, 1, 1, 12, 0, 2, 0), nextInterval);
        }
    }
}
