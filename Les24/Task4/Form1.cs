namespace Task4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string controlType = textBox1.Text;

            // Получаем координаты для размещения элемента управления
            int x = int.Parse(textBox2.Text);
            int y = int.Parse(textBox3.Text);

            Control newControl = null;
            switch (controlType)
            {
                case "К":
                    newControl = new Button();
                    ((Button)newControl).Text = "Кнопка";
                    break;
                case "П":
                    newControl = new TextBox();
                    ((TextBox)newControl).Text = "Поле ввода";
                    break;
                case "М":
                    newControl = new Label();
                    ((Label)newControl).Text = "Метка";
                    break;
                default:
                    MessageBox.Show("Неверный тип элемента управления!");
                    return;
            }

            // Настройка свойств созданного элемента управления
            newControl.Location = new Point(x, y);
            newControl.Size = new Size(100, 30);

            // Добавление созданного элемента управления на форму
            this.Controls.Add(newControl);

            // Установка обработчика события для удаления элемента управления при наведении на него курсора
            newControl.MouseEnter += (s, ev) => this.Controls.Remove(newControl);
        }
    
    }
}