using PatternsSampleWPF.Models;

namespace PatternsSampleWPF.Builder
{
    internal abstract class CarBuilderBase
    {
        protected Car Car; // Car that will be processed. In real world should be base type as much as possible.

        protected CarBuilderBase()
        {
            Car = new Car();
        }

        public Car GetCar() => Car;

        public abstract void BuildBody();
        public abstract void BuildWheels();
        public abstract void BuildEngine();
        public abstract void BuildTunning();
    }
}