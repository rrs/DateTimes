using System;
using System.Collections.Generic;
using System.Text;

namespace Rrs.DateTimes
{
    public static class TimeSpanExtensions
    {
        public static TimeSpan RoundUp(this TimeSpan ts, TimeSpan d)
        {
            var modTicks = ts.Ticks % d.Ticks;
            var delta = modTicks != 0 ? d.Ticks - modTicks : 0;
            return new TimeSpan(ts.Ticks + delta);
        }

        public static TimeSpan RoundDown(this TimeSpan ts, TimeSpan d)
        {
            var delta = ts.Ticks % d.Ticks;
            return new TimeSpan(ts.Ticks - delta);
        }

        public static TimeSpan RoundToNearest(this TimeSpan ts, TimeSpan d)
        {
            var delta = ts.Ticks % d.Ticks;
            bool roundUp = delta >= d.Ticks / 2;
            var offset = roundUp ? d.Ticks : 0;

            return new TimeSpan(ts.Ticks + offset - delta);
        }
    }
}
