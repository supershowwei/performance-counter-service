using System.Configuration;

namespace PerformanceCounterService.Configuration
{
    public class PerformanceCounterElementCollection : ConfigurationElementCollection
    {
        public PerformanceCounterElement this[int idx] => this.BaseGet(idx) as PerformanceCounterElement;

        protected override ConfigurationElement CreateNewElement()
        {
            return new PerformanceCounterElement();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            var performanceCounterElement = element as PerformanceCounterElement;

            var key = $"{performanceCounterElement.CategoryName}\\{performanceCounterElement.CounterName}";

            if (!string.IsNullOrEmpty(performanceCounterElement.InstanceName))
            {
                key += $"\\{performanceCounterElement.InstanceName}";
            }

            return key;
        }
    }
}