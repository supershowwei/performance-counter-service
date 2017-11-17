using System.Configuration;

namespace PerformanceCounterService.Configuration
{
    public class PerformanceCounterServiceSection : ConfigurationSection
    {
        [ConfigurationProperty("", IsDefaultCollection = true)]
        [ConfigurationCollection(typeof(PerformanceCounterElement), AddItemName = "PerformanceCounter")]
        public PerformanceCounterElementCollection PerformanceCounters => (PerformanceCounterElementCollection)base[""];
    }
}