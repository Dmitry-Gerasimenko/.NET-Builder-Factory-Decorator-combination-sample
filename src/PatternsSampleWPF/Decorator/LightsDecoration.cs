using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;
using PatternsSampleWPF.Models;

namespace PatternsSampleWPF.Decorator
{
    internal class LightsDecoration : AutoTuningDecoratorBase
    {
        public LightsDecoration(IDrawableCar auto) : base(auto)
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
            DrawLightsDecorations(parent);
        }

        private static void DrawLightsDecorations(MainWindow parent)
        {
            Brush color = new SolidColorBrush(Color.FromRgb(66, 63, 63));
            Polygon polygon4 = new Polygon();
            polygon4.Opacity = 0.3;
            polygon4.VerticalAlignment = VerticalAlignment.Top;
            polygon4.Fill = Brushes.LightYellow;
            polygon4.Points = new PointCollection()
            {
                new Point(171, 448), new Point(1, 535),
                new Point(56, 535), new Point(168, 468),
                new Point(185, 458)
            };
            polygon4.Stroke = Brushes.Yellow;
            parent.ContentsGrid.Children.Add(polygon4);

            Polygon polygon5 = new Polygon();
            polygon5.Opacity = 0.2;
            polygon5.VerticalAlignment = VerticalAlignment.Top;
            polygon5.Fill = Brushes.Red;
            polygon5.Points = new PointCollection()
            {
                new Point(813, 427), new Point(810, 458),
                new Point(835, 453), new Point(839, 421), new Point(835, 423)
            };
            polygon5.Stroke = Brushes.Red;
            parent.ContentsGrid.Children.Add(polygon5);


            Polyline polygon = new Polyline();
            polygon.VerticalAlignment = VerticalAlignment.Top;
            polygon.Points = new PointCollection()
            {
                new Point(164, 447), new Point(165, 468),
                new Point(175, 468), new Point(173, 448),
                new Point(183, 449), new Point(187, 468),
                new Point(178, 457), new Point(164, 457)
            };
            polygon.Stroke = color;
            parent.ContentsGrid.Children.Add(polygon);

            Polyline polygon1 = new Polyline();
            polygon1.VerticalAlignment = VerticalAlignment.Top;

            polygon1.Points = new PointCollection()
            {
                new Point(827, 425), new Point(815, 428),
                new Point(814, 436), new Point(827, 435),
                new Point(826, 445), new Point(813, 447),
                new Point(817, 457), new Point(826, 456)
            };
            polygon1.Stroke = color;
            parent.ContentsGrid.Children.Add(polygon1);
        }
    }
}