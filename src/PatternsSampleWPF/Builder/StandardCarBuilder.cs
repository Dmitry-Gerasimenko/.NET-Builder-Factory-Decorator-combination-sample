namespace PatternsSampleWPF.Builder
{
    /// <summary>
    ///  Provides an interface to build the state of specific part of the car with 'standard' parts.
    /// </summary>
    internal class StandardCarBuilder : CarBuilderBase
    {
        public override void BuildBody() => Car.CarBody = "E38 body built";

        public override void BuildEngine() => Car.Engine = "236 hp Engine built";

        public override void BuildTunning() => Car.Tunning = "M5 Tuning built";

        public override void BuildWheels() => Car.Wheels = "New r18 wheels built";
    }
}
