using System;

namespace Rrs.DateTimes
{
    public static class IntervalHelper
    {
        public static DateTime NextInterval(DateTime referenceDate, TimeSpan rate)
        {
            return referenceDate.RoundToNearest(rate).Add(rate);
        }

        public static TimeSpan CalculateDelay(DateTime referenceDate, DateTime nextInterval, TimeSpan rate)
        {
            var delay = nextInterval - referenceDate;
            return delay.TotalMilliseconds > 0 ? delay : (referenceDate.RoundUp(rate) - referenceDate);
        }
    }
}
