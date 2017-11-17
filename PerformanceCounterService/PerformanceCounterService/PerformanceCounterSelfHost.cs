using System;
using System.Configuration;
using Nancy.Hosting.Self;

namespace PerformanceCounterService
{
    public class PerformanceCounterSelfHost
    {
        private NancyHost host;

        public void Start()
        {
            this.host = new NancyHost(new Uri(ConfigurationManager.AppSettings["NancyHost"]));
            this.host.Start();
        }

        public void Stop()
        {
            this.host.Stop();
        }
    }
}