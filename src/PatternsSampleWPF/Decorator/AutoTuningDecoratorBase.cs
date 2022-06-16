using PatternsSampleWPF.Models;

namespace PatternsSampleWPF.Decorator
{
    /// <summary>
    ///  Base class for the decorators that would decorate Output method of the drawable car.
    /// </summary>
    abstract class AutoTuningDecoratorBase : IDrawableCar
    {
        protected IDrawableCar CarToDecorate;

        protected AutoTuningDecoratorBase(IDrawableCar carToDecorate)
        {
            CarToDecorate = carToDecorate;
        }

        public abstract void Output(MainWindow parent);
    }
}
