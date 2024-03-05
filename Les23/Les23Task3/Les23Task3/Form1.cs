namespace Les23Task3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            foreach (RadioButton radioButton in groupBox1.Controls.OfType<RadioButton>())
            {
                radioButton.Checked = false;
            }

            this.textBox1.Clear();
            this.textBox2.Clear();
            this.textBox6.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double x, b, result;
            double.TryParse(textBox1.Text, out x);
            double.TryParse(textBox2.Text, out b);

            // Получаем выбранный Radiobutton
            RadioButton selectedRadioButton = groupBox1.Controls.OfType<RadioButton>().FirstOrDefault(rb => rb.Checked);

            if (selectedRadioButton != null)
            {
                // Выбранная функция
                Func<double, double> selectedFunction = null;

                if (selectedRadioButton == radioButton1)
                {
                    selectedFunction = Math.Sinh;
                }
                else if (selectedRadioButton == radioButton2)
                {
                    selectedFunction = num => Math.Pow(num, 2);
                }
                else if (selectedRadioButton == radioButton3)
                {
                    selectedFunction = Math.Exp;
                }

                if (selectedFunction != null)
                {
                    // Вычисляем результат в зависимости от значения x*b
                    double xTimesB = x * b;

                    if (xTimesB > 1 && xTimesB < 10)
                    {
                        result = Math.Exp(selectedFunction(x));
                    }
                    else if (xTimesB > 12 && xTimesB < 40)
                    {
                        result = Math.Sqrt(Math.Abs(selectedFunction(x) + 4 * b));
                    }
                    else
                    {
                        result = b * Math.Pow(selectedFunction(x), 2);
                    }

                    string selectedFunc = "";
                    if (radioButton1.Checked)
                    {
                        selectedFunc = radioButton1.Text;
                    }
                    else if (radioButton2.Checked)
                    {
                        selectedFunc = radioButton2.Text;
                    }
                    else if (radioButton3.Checked)
                    {
                        selectedFunc = radioButton3.Text;
                    }

                    // Выводим результат в TextBox3
                    textBox6.Text += "При x = " + textBox2.Text +
                    Environment.NewLine;
                    textBox6.Text += "При b = " + textBox1.Text +
                    Environment.NewLine;
                    textBox6.Text += "При f(x) = " + selectedFunc +
                    Environment.NewLine;
                    textBox6.Text += "Результат: " + result.ToString();
                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }
    }
}