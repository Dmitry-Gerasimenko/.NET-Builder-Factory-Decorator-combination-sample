using PatternsSampleWPF.Builder;
using PatternsSampleWPF.Models;

namespace PatternsSampleWPF.Factory
{
    class LuxuryCarFactory : CarFactoryBase
    {
        public LuxuryCarFactory(CarBuilderBase builder) : base(builder)
        {
        }

        /// <summary>
        ///  Build basic needs + tunings.
        /// </summary>
        /// <returns></returns>
        public override Car Construct()
        {
            CarBuilder.BuildBody();
            CarBuilder.BuildWheels();
            CarBuilder.BuildEngine();

            // Add more luxury this to the build.
            CarBuilder.BuildTunning();

            return CarBuilder.GetCar();
        }
    }
}
