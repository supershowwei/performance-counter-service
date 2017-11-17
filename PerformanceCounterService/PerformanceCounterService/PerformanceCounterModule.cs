using System;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using Nancy;
using PerformanceCounterService.Configuration;
using PerformanceCounterService.Extensions;

namespace PerformanceCounterService
{
    public class PerformanceCounterModule : NancyModule
    {
        private static readonly PerformanceCounter[] PerformanceCounters = GeneratePerformanceCounters();

        public PerformanceCounterModule()
        {
            this.Get["/performance-counters"] = p => this.Response.AsJson(
                new
                    {
                        UtcTime = DateTime.UtcNow.ToJavaScriptMilliseconds(),
                        Counters = PerformanceCounters.Select(x => x.ToCounter()).ToArray()
                    });
        }

        private static PerformanceCounter[] GeneratePerformanceCounters()
        {
            return ((PerformanceCounterServiceSection)ConfigurationManager.GetSection("PerformanceCounterService"))
                .PerformanceCounters.Cast<PerformanceCounterElement>()
                .Select(
                    x =>
                        {
                            var performanceCounter = new PerformanceCounter(x.CategoryName, x.CounterName);

                            if (!string.IsNullOrEmpty(x.InstanceName))
                            {
                                performanceCounter.InstanceName = x.InstanceName;
                            }

                            return performanceCounter;
                        })
                .ToArray();
        }
    }
}