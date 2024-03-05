using LiveCharts.Defaults;
using LiveCharts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Task3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private double xMin;
        private double xMax;
        private double h;
        private SeriesCollection seriesCollection;

        public event PropertyChangedEventHandler PropertyChanged;

        public ChartValues<ObservablePoint> DataPoints { get; set; }

        public double XMin
        {
            get => xMin;
            set
            {
                xMin = value;
                OnPropertyChanged("XMin");
            }
        }

        public double XMax
        {
            get => xMax;
            set
            {
                xMax = value;
                OnPropertyChanged("XMax");
            }
        }

        public double H
        {
            get => h;
            set
            {
                h = value;
                OnPropertyChanged("H");
            }
        }

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            DataPoints = new ChartValues<ObservablePoint>();
        }

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void ButtonPlot_Click(object sender, RoutedEventArgs e)
        {
            double xMinValue, xMaxValue, hValue;

            if (!double.TryParse(TextBoxXMin.Text, out xMinValue) ||
                !double.TryParse(TextBoxXMax.Text, out xMaxValue) ||
                !double.TryParse(TextBoxH.Text, out hValue))
            {
                MessageBox.Show("Invalid input values!");
                return;
            }

            if (xMinValue >= xMaxValue || hValue <= 0)
            {
                MessageBox.Show("Invalid input values!");
                return;
            }

            XMin = xMinValue;
            XMax = xMaxValue;
            H = hValue;

            // Clear previous data points
            DataPoints.Clear();

            // Generate new data points
            for (double x = XMin; x <= XMax; x += H)
            {
                double y = Math.Sqrt(x);
                DataPoints.Add(new ObservablePoint(x, y));
            }
        }
    }
}


