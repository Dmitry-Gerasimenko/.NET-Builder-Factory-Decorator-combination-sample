using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;
using PatternsSampleWPF.Models;

namespace PatternsSampleWPF.Decorator
{
    class WheelsDecoration : AutoTuningDecoratorBase
    {
        public WheelsDecoration(IDrawableCar auto) : base(auto)
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
            DecorateWheels(parent);
        }

        private static void DecorateWheels(MainWindow parent)
        {
            Ellipse el = new Ellipse();
            el.Opacity = 0.2;
            el.Name = "FirstWheel";
            el.Width = 100;
            el.Height = 100;
            el.VerticalAlignment = VerticalAlignment.Top;
            el.HorizontalAlignment = HorizontalAlignment.Left;
            el.Fill = new SolidColorBrush(Color.FromRgb(191, 191, 6));
            el.Stroke = Brushes.DarkBlue;
            el.StrokeThickness = 15;
            el.Margin = new Thickness(226, 452, 0, 0);
            parent.ContentsGrid.Children.Add(el);

            Brush color = new SolidColorBrush(Color.FromRgb(127, 19, 19));
            Ellipse el1 = new Ellipse();
            el1.Opacity = 0.2;
            el1.Name = "SecondWheel";
            el1.Width = 100;
            el1.Height = 100;
            el1.VerticalAlignment = VerticalAlignment.Top;
            el1.HorizontalAlignment = HorizontalAlignment.Left;
            el1.Fill = new SolidColorBrush(Color.FromRgb(6, 191, 188));
            el1.Stroke = color;
            el1.StrokeThickness = 15;
            el1.Margin = new Thickness(630, 457, 0, 0);
            parent.ContentsGrid.Children.Add(el1);
        }
    }
}
