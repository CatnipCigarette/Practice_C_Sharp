namespace Task3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // �������� ������������ �������
            Graphics g = this.CreateGraphics();

            Brush brush = Brushes.Red;

            // ��������� ������
            g.FillRectangle(brush, 60, 10, 110, 160);
            brush = Brushes.White;

            g.FillRectangle(brush, 75, 35, 80, 40);
            g.FillRectangle(brush, 75, 90, 80, 40);



            // �������� ����� ��� ��������� �����
            brush = Brushes.Brown;

            // ��������� ������� �����
            g.FillRectangle(brush, 50, 150, 130, 20);

            // ��������� ����� �����
            g.FillRectangle(brush, 50, 170, 20, 100);
            g.FillRectangle(brush, 160, 170, 20, 100);

        }
    }
}