using System.Configuration;

namespace PerformanceCounterService.Configuration
{
    public class PerformanceCounterElement : ConfigurationElement
    {
        [ConfigurationProperty("categoryName", IsRequired = true)]
        public string CategoryName
        {
            get => (string)base["categoryName"];
            set => base["categoryName"] = value;
        }

        [ConfigurationProperty("counterName", IsRequired = true)]
        public string CounterName
        {
            get => (string)base["counterName"];
            set => base["counterName"] = value;
        }

        [ConfigurationProperty("instanceName")]
        public string InstanceName
        {
            get => (string)base["instanceName"];
            set => base["instanceName"] = value;
        }
    }
}