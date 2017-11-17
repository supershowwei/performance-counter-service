using System;

namespace PerformanceCounterService.Extensions
{
    internal static class DateTimeExtension
    {
        public static long ToJavaScriptMilliseconds(this DateTime me)
        {
            return Convert.ToInt64(me.Subtract(new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalMilliseconds);
        }
    }
}