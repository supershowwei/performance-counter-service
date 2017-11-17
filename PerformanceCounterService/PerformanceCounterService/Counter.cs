namespace PerformanceCounterService
{
    public class Counter
    {
        public Counter(string name, object value)
        {
            this.Name = name;
            this.Value = value;
        }

        public string Name { get; }

        public object Value { get; }
    }
}