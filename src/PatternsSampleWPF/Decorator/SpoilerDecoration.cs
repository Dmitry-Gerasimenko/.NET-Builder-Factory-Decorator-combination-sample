using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;
using PatternsSampleWPF.Models;

namespace PatternsSampleWPF.Decorator
{
    internal class SpoilerDecorator : AutoTuningDecoratorBase
    {
        public SpoilerDecorator(IDrawableCar auto) : base(auto)
        {
        }

        public override void Output(MainWindow parent)
        {
            if (CarToDecorate is null)
            {
                MessageBox.Show("Nothing to decorate! Create a car first.");
                return;
            }

            CarToDecorate.Output(parent); // first draw base car, then decorate it by addition action below.
            DrawSpoilerDecoration(parent);
        }

        private static void DrawSpoilerDecoration(MainWindow parent)
        {
            Polygon polygon4 = new Polygon();
            polygon4.Opacity = 1;
            polygon4.VerticalAlignment = VerticalAlignment.Top;
            polygon4.Fill = Brushes.Black;
            polygon4.Points = new PointCollection()
            {
                new Point(797, 405), new Point(812, 399),
                new Point(837, 400), new Point(829, 409),
            };
            polygon4.Stroke = Brushes.Blue;
            parent.ContentsGrid.Children.Add(polygon4);

            Polygon polygon5 = new Polygon();
            polygon5.Opacity = 1;
            polygon5.VerticalAlignment = VerticalAlignment.Top;
            polygon5.Fill = Brushes.Black;
            polygon5.Points = new PointCollection()
            {
                new Point(643, 347), new Point(662, 348),
                new Point(663, 355)
            };
            polygon5.Stroke = Brushes.Blue;
            parent.ContentsGrid.Children.Add(polygon5);
        }
    }
}
