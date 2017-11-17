using System.Diagnostics;
using System.Text;

namespace PerformanceCounterService.Extensions
{
    internal static class PerformanceCounterExtension
    {
        public static string GetFullName(this PerformanceCounter me)
        {
            var sb = new StringBuilder();

            sb.AppendFormat("{0}\\{1}", me.CategoryName, me.CounterName);

            if (!string.IsNullOrEmpty(me.InstanceName)) sb.AppendFormat("\\{0}", me.InstanceName);

            return sb.ToString();
        }

        public static Counter ToCounter(this PerformanceCounter me)
        {
            return new Counter($"{me.GetFullName()}", me.NextValue());
        }
    }
}