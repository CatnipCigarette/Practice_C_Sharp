namespace Task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.AddRange(new string[] { "Ад прадзедаў спакон вякоў", "Я тебя обниму и закутаю в плащ", "Солнце Закат Разъедает Осколки", "Ах, Ненависть" });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string selectedItem = listBox1.SelectedItem.ToString();
                string lowerCaseRussianLetters = new string(selectedItem.Where(c => Char.IsLower(c) && c >= 'а' && c <= 'я').ToArray());
                label1.Text += Environment.NewLine + lowerCaseRussianLetters;
            }
        }
    }
}