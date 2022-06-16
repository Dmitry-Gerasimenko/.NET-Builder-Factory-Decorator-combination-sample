using PatternsSampleWPF.Builder;
using PatternsSampleWPF.Models;

namespace PatternsSampleWPF.Factory
{
    /// <summary>
    ///  Base class to implement various factories forces to implement construct method to produce a car.
    /// </summary>
    abstract class CarFactoryBase
    {
        /// <summary>
        ///  Uses builder abstractions to create parts of the car.
        /// </summary>
        protected readonly CarBuilderBase CarBuilder;

        protected CarFactoryBase(CarBuilderBase builder)
        {
            CarBuilder = builder;
        }

        public abstract Car Construct();
    }
}
