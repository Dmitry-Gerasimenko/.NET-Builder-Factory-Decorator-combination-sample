namespace PatternsSampleWPF.Models
{
    /// <summary>
    ///  Forces models to have output methods to draw themselfs on WPF UI.
    /// </summary>
    public interface IDrawableCar
    {
        void Output(MainWindow parent);
    }
}
