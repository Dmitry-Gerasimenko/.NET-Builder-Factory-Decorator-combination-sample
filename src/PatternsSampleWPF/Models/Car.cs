using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace PatternsSampleWPF.Models
{
    internal class Car : IDrawableCar
    {
        /// <summary>
        ///  Represents the body of car. In real world should be another class model, string for simplification.
        /// </summary>
        public string CarBody { get; set; }
        public string Wheels { get; set; }
        public string Engine { get; set; }
        public string Tunning { get; set; }

        public void Output(MainWindow parent)
        {
            parent.ContentsGrid.Children.RemoveRange(0, parent.ContentsGrid.Children.Count); // clear the screen
            if (this.IsCarPartBuilt(() => CarBody))
            {
                DrawBody(parent);
            }

            if (this.IsCarPartBuilt(() => Wheels))
            {
                DrawWheels(parent);
            }

            if (this.IsCarPartBuilt(() => Engine))
            {
                DrawEngine(parent);
            }

            if (this.IsCarPartBuilt(() => Tunning))
            {
                DrawLuxuryTunning(parent);
            }
        }

        private static void DrawLuxuryTunning(MainWindow parent)
        {
            Brush color = new SolidColorBrush(Color.FromRgb(199, 18, 36));
            Brush color1 = new SolidColorBrush(Color.FromRgb(49, 32, 138));
            Brush color2 = new SolidColorBrush(Color.FromRgb(96, 150, 229));

            Line line = new Line();
            line.StrokeThickness = 20;
            line.Stroke = color;
            line.X1 = 686;
            line.Y1 = 367;
            line.X2 = 590;
            line.Y2 = 521;
            parent.ContentsGrid.Children.Add(line);

            Line line1 = new Line();
            line1.StrokeThickness = 20;
            line1.Stroke = color1;
            line1.X1 = 665;
            line1.Y1 = 357;
            line1.X2 = 563;
            line1.Y2 = 521;
            parent.ContentsGrid.Children.Add(line1);

            Line line2 = new Line();
            line2.StrokeThickness = 20;
            line2.Stroke = color2;
            line2.X1 = 644;
            line2.Y1 = 348;
            line2.X2 = 536;
            line2.Y2 = 521;
            parent.ContentsGrid.Children.Add(line2);
        }

        private static void DrawEngine(MainWindow parent)
        {
            Brush color = new SolidColorBrush(Color.FromRgb(66, 63, 63));

            Polyline polygon = new Polyline();
            polygon.VerticalAlignment = VerticalAlignment.Top;

            polygon.Points = new PointCollection()
            {
                new Point(164, 451), new Point(235, 444),
                new Point(217, 440), new Point(229, 472),
                new Point(228, 479), new Point(157, 477),
                new Point(157, 485), new Point(223, 487),
                new Point(170, 500), new Point(220, 501),
                new Point(220, 515), new Point(177, 514),
                new Point(170, 502)
            };
            polygon.Stroke = color;
            parent.ContentsGrid.Children.Add(polygon);

            Polyline polygon1 = new Polyline();
            polygon1.VerticalAlignment = VerticalAlignment.Top;

            polygon1.Points = new PointCollection()
            {
                new Point(741, 435), new Point(829, 434),
                new Point(823, 468), new Point(725, 469),
                new Point(741, 435)
            };
            polygon1.Stroke = color;
            parent.ContentsGrid.Children.Add(polygon1);

            Polyline polygon2 = new Polyline();
            polygon2.VerticalAlignment = VerticalAlignment.Top;

            polygon2.Points = new PointCollection()
            {
                new Point(544, 342), new Point(525, 413),
                new Point(520, 507), new Point(522, 524)
            };
            polygon2.Stroke = color;
            parent.ContentsGrid.Children.Add(polygon2);

            Polyline polygon3 = new Polyline();
            polygon3.VerticalAlignment = VerticalAlignment.Top;

            polygon3.Points = new PointCollection()
            {
                    new Point(382, 392), new Point(382, 412),
                new Point(389, 413), new Point(376, 431),
                new Point(371, 477), new Point(376, 509),
                new Point(381, 523)
            };
            polygon3.Stroke = color;
            parent.ContentsGrid.Children.Add(polygon3);
        }

        private static void DrawWheels(MainWindow parent)
        {
            Ellipse el = new Ellipse();
            el.Name = "FirstWheel";
            el.Width = 100;
            el.Height = 100;
            el.VerticalAlignment = VerticalAlignment.Top;
            el.HorizontalAlignment = HorizontalAlignment.Left;
            el.Fill = Brushes.Black;
            el.Stroke = Brushes.Red;
            el.StrokeThickness = 1;
            el.Margin = new Thickness(226, 452, 0, 0);
            parent.ContentsGrid.Children.Add(el);

            Ellipse el1 = new Ellipse();
            el1.Name = "SecondWheel";
            el1.Width = 100;
            el1.Height = 100;
            el1.VerticalAlignment = VerticalAlignment.Top;
            el1.HorizontalAlignment = HorizontalAlignment.Left;
            el1.Fill = Brushes.Black;
            el1.Stroke = Brushes.Red;
            el1.StrokeThickness = 1;
            el1.Margin = new Thickness(630, 457, 0, 0);
            parent.ContentsGrid.Children.Add(el1);
        }

        private static void DrawBody(MainWindow parent)
        {
            Polygon polygon = new Polygon();
            polygon.VerticalAlignment = VerticalAlignment.Top;
            polygon.Fill = Brushes.Black;
            polygon.Points = new PointCollection()
            {
                new Point(164, 442), new Point(179, 435),
                new Point(205, 428), new Point(243, 421),
                new Point(326, 413), new Point(339, 409),
                new Point(350, 410), new Point(406, 374),
                new Point(445, 353), new Point(468, 346),
                new Point(529, 341), new Point(595, 342),
                new Point(640, 346), new Point(658, 351),
                new Point(750, 396), new Point(757, 400),
                new Point(829, 408), new Point(831, 417),
                new Point(830, 436), new Point(825, 466),
                new Point(838, 475), new Point(833, 498),
                new Point(825, 510), new Point(817, 510),
                new Point(805, 520), new Point(740, 523),
                new Point(736, 499), new Point(726, 476),
                new Point(703, 459), new Point(682, 455),
                new Point(657, 458), new Point(636, 471),
                new Point(628, 492), new Point(622, 505),
                new Point(621, 526), new Point(333, 526),
                new Point(330, 493), new Point(316, 465),
                new Point(289, 450), new Point(266, 449),
                new Point(238, 464), new Point(221, 492),
                new Point(219, 521), new Point(169, 521),
                new Point(175, 512), new Point(166, 500),
                new Point(158, 498), new Point(154, 486),
                new Point(154, 474), new Point(165, 469)
            };
            polygon.Stroke = Brushes.Black;
            parent.ContentsGrid.Children.Add(polygon);

            Brush color = new SolidColorBrush(Color.FromRgb(66, 63, 63));
            Line line = new Line();
            line.StrokeThickness = 1;
            line.Stroke = color;
            line.X1 = 354;
            line.Y1 = 413;
            line.X2 = 748;
            line.Y2 = 402;
            parent.ContentsGrid.Children.Add(line);
        }
    }
}
