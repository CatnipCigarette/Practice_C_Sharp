namespace Les3Task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Step;
            double x, y, z;
            double result;

            // ������ �������� �� TextBox1-4 � ��������� � ��������������� ����������
            if (double.TryParse(textBox1.Text, out x) &&
                double.TryParse(textBox2.Text, out y) &&
                double.TryParse(textBox3.Text, out z) &&
                int.TryParse(textBox5.Text, out Step))
            {
                z = z * Math.Pow(10, Step);

                // ��������� ���������
                result = (5 * Math.Atan(x)) - (1.0 / 4) * Math.Acos(x) * ((x + (3 * Math.Abs(x - y)) + Math.Pow(x, 2)) / (Math.Abs(x - y) * z + Math.Pow(x, 2)));

                // ������� ��������� � TextBox6
                textBox6.Text +=
                    "x = " + x.ToString();
                textBox6.Text += Environment.NewLine +
                    "y = " + y.ToString();
                textBox6.Text += Environment.NewLine +
                    "z = " + Math.Round(z, 6).ToString();
                textBox6.Text += Environment.NewLine +
                    "���������: " + Math.Round(result, 3).ToString();
            }
            else
            {
                // ���� ���� �� �������� TextBox1-4 �� �������� ������, ������� ��������� �� ������
                MessageBox.Show("������� �������� �������� �� ��� ����", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}