using System.Windows;
using System.Windows.Input;
using PatternsSampleWPF.Builder;
using PatternsSampleWPF.Decorator;
using PatternsSampleWPF.Factory;
using PatternsSampleWPF.Models;

namespace PatternsSampleWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private IDrawableCar currentCar;
        private CarBuilderBase carBuilder; // builder responsible for building engine, body, wheels of the current car.

        CarFactoryBase cheapFactory;
        CarFactoryBase luxuryFactory;

        public MainWindow()
        {
            InitializeComponent();

            carBuilder = new StandardCarBuilder();
            cheapFactory = new CheapCarFactory(carBuilder);
            luxuryFactory = new LuxuryCarFactory(carBuilder);
        }

        private void CarBodyBuild_Click(object sender, RoutedEventArgs e)
        {
            carBuilder.BuildBody();
            currentCar = carBuilder.GetCar();
            currentCar.Output(this);
        }

        private void WheelsBuild_Click(object sender, RoutedEventArgs e)
        {
            carBuilder.BuildWheels();
            currentCar = carBuilder.GetCar();
            currentCar.Output(this);
        }

        private void EngineBuild_Click(object sender, RoutedEventArgs e)
        {
            carBuilder.BuildEngine();
            currentCar = carBuilder.GetCar();
            currentCar.Output(this);
        }

        private void ConstructCheapCar_Click(object sender, RoutedEventArgs e)
        {
            currentCar = cheapFactory.Construct();
            currentCar.Output(this);
        }

        private void ConstructLuxuryCar_Click(object sender, RoutedEventArgs e)
        {
            currentCar = luxuryFactory.Construct();
            currentCar.Output(this);
        }

        private void AddLights_Click(object sender, RoutedEventArgs e)
        {
            currentCar = new LightsDecoration(currentCar);
            currentCar.Output(this);
        }

        private void AddSpoiler_Click(object sender, RoutedEventArgs e)
        {
            currentCar = new SpoilerDecorator(currentCar);
            currentCar.Output(this);
        }

        private void DecorateWheels_Click(object sender, RoutedEventArgs e)
        {
            currentCar = new WheelsDecoration(currentCar);
            currentCar.Output(this);
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            carBuilder = new StandardCarBuilder(); // init an empty builder
            cheapFactory = new CheapCarFactory(carBuilder);
            luxuryFactory = new LuxuryCarFactory(carBuilder);

            ContentsGrid.Children.RemoveRange(0, ContentsGrid.Children.Count); // clear ui elements
        }

        private void Close_click(object sender, RoutedEventArgs e) => Close();

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e) => DragMove();
    }
}
