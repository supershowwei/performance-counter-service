using Topshelf;

namespace PerformanceCounterService
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            HostFactory.Run(
                x =>
                    {
                        x.Service<PerformanceCounterSelfHost>(
                            s =>
                                {
                                    s.ConstructUsing(name => new PerformanceCounterSelfHost());
                                    s.WhenStarted(c => c.Start());
                                    s.WhenStopped(c => c.Stop());
                                });

                        x.SetServiceName("PerformanceCounterService");
                        x.SetDisplayName("Performance Counter Service");
                        x.SetDescription("Performance Counter Service");

                        x.RunAsLocalSystem();
                        x.StartAutomatically();
                    });
        }
    }
}