using PatternsSampleWPF.Builder;
using PatternsSampleWPF.Models;

namespace PatternsSampleWPF.Factory
{
    class CheapCarFactory : CarFactoryBase
    {
        public CheapCarFactory(CarBuilderBase builder) : base(builder)
        {
        }

        /// <summary>
        ///  Build only basic needs. As minimum as possible to produce a car.
        /// </summary>
        /// <returns></returns>
        public override Car Construct()
        {
            CarBuilder.BuildBody();
            CarBuilder.BuildEngine();
            CarBuilder.BuildWheels();

            return CarBuilder.GetCar();
        }
    }
}
