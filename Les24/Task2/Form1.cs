using System.Windows.Forms.DataVisualization.Charting;

namespace Task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double xmin = double.Parse(textBox1.Text);
            double xmax = double.Parse(textBox2.Text);
            double step = double.Parse(textBox3.Text);

            // Очищаем все серии данных в Chart2
            chart2.Series.Clear();

            // Создаем новую серию данных
            Series series = new Series();
            series.ChartType = SeriesChartType.Line;
            series.BorderWidth = 4;
            series.Name = "y = √(x)";

            // Добавляем точки на график
            for (double x = xmin; x <= xmax; x += step)
            {
                double y = Math.Sqrt(x);
                series.Points.AddXY(x, y);
            }

            // Добавляем серию данных на график
            chart2.Series.Add(series);
        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chart2.Series.Clear();
            chart2.Titles.Add("График функции");
        }
    }
}