namespace Les23Task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // ������ ������ �� textBox1-4
            double x0 = double.Parse(textBox1.Text);
            double xk = double.Parse(textBox2.Text);
            double dx = double.Parse(textBox3.Text);
            double b = double.Parse(textBox4.Text);

            // ������� �������� x � ����� dx � ��������� �� x0 �� xk
            for (double x = x0; x <= xk; x += dx)
            {
                // ���������� �������� ������� y
                double y = 9 * (x + 15 * Math.Sqrt(Math.Pow(x, 3) + Math.Pow(b, 3)));

                // ����� ���������� � textBox5
                textBox6.AppendText("��� x = " + x + ", y = " + y + Environment.NewLine);
            }
        }
    }
}