using System.Net.Mail;
using System.Text.RegularExpressions;

namespace Task4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        #region GetSet
        public string LastName { get => textBox1.Text; set => LastName = value; }
        public string FirstName { get => textBox2.Text; set => FirstName = value; }
        public string Patronymic { get => textBox3.Text; set => Patronymic = value; }
        public string Data { get => comboBox1.Text + " " + comboBox2.Text + " " + comboBox3.Text; set => Data = value; }
        public string HomeAdress { get => textBox4.Text; set => HomeAdress = value; }
        public string EmailAdress { get => textBox5.Text; set => EmailAdress = value; }
        public string PhoneType { get => comboBox4.Text; set => PhoneType = value; }
        public string PhoneNumber { get => textBox6.Text; set => PhoneNumber = value; }
        public string MinSalary { get => numericUpDown1.Text; set => MinSalary = value; }
        public string MaxSalary { get => numericUpDown2.Text; set => MaxSalary = value; }
        public string Summary { get => richTextBox1.Text; set => Summary = value; }
        #endregion

        #region Experience
        public short experience;

        private void radioButton1_CheckedChanged(object sender, EventArgs e) => experience = 1;

        private void radioButton2_CheckedChanged(object sender, EventArgs e) => experience = 2;

        private void radioButton3_CheckedChanged(object sender, EventArgs e) => experience = 3;

        private void radioButton4_CheckedChanged(object sender, EventArgs e) => experience = 4;

        private void radioButton5_CheckedChanged(object sender, EventArgs e) => experience = 5;
        #endregion

        #region Schedule

        public short schedule;

        private void radioButton8_CheckedChanged(object sender, EventArgs e) => schedule = 1;

        private void radioButton9_CheckedChanged(object sender, EventArgs e) => schedule = 2;

        private void radioButton10_CheckedChanged(object sender, EventArgs e) => schedule = 3;

        private void radioButton11_CheckedChanged(object sender, EventArgs e) => schedule = 4;
        #endregion

        #region Test

        public bool lastNameVerification = false;
        public bool firstNameVerification = false;
        public bool PatronymicVerification = false;
        public bool EmailAdressVerification = false;
        public bool PhoneNumberVerification = false;

        //public bool pF, pN, pOt, pPh, pEm;
        public void Test()
        {
            if (textBox1.Text != string.Empty)
            {
                lastNameVerification = true;
                for (int i = 0; i < textBox1.Text.Length; i++)
                {
                    if (!Char.IsLetter(textBox1.Text[i]))
                    {
                        lastNameVerification = false;
                        break;
                    }
                }
            }
            if (textBox2.Text != string.Empty)
            {
                firstNameVerification = true;
                for (int i = 0; i < textBox2.Text.Length; i++)
                {
                    if (!Char.IsLetter(textBox2.Text[i]))
                    {
                        firstNameVerification = false;
                        break;
                    }
                }
            }

            if (textBox3.Text != string.Empty)
            {
                PatronymicVerification = true;
                for (int i = 0; i < textBox3.Text.Length; i++)
                {
                    if (!Char.IsLetter(textBox3.Text[i]))
                    {
                        PatronymicVerification = false;
                        break;
                    }
                }
            }

            if (textBox5.Text != string.Empty)
            {
                EmailAdressVerification = false;
                string pattern = @"^(?("")("".+?""@)|(([0-9a-zA-Z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-zA-Z])@))" +
                 @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,6}))$";
                if (Regex.IsMatch(textBox5.Text, pattern))
                {
                    EmailAdressVerification = true;
                }
            }

            if (textBox6.Text != string.Empty)
            {
                PhoneNumberVerification = true;
                for (int i = 0; i < textBox6.Text.Length; i++)
                {
                    if (textBox6.Text.Length != 9) PhoneNumberVerification = false;
                    else
                    {
                        if (!Char.IsNumber(textBox6.Text[i]))
                        {
                            PhoneNumberVerification = false;
                            break;
                        }
                    }
                }
            }
        }
        #endregion

        private void SaveButton_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
            textBox2.BackColor = Color.White;
            textBox3.BackColor = Color.White;
            textBox5.BackColor = Color.White;
            textBox6.BackColor = Color.White;
            comboBox1.BackColor = Color.White;
            comboBox2.BackColor = Color.White;
            comboBox3.BackColor = Color.White;
            Test();
            if (textBox1.Text != string.Empty && textBox2.Text != string.Empty && textBox3.Text != string.Empty && textBox5.Text != string.Empty &&
                comboBox1.Text != string.Empty && comboBox2.Text != string.Empty && comboBox3.Text != string.Empty)
            {
                if (lastNameVerification && firstNameVerification && PatronymicVerification && EmailAdressVerification && PhoneNumberVerification)
                {
                    File.AppendAllText("���������.txt", "\r\n" + LastName + " " + FirstName + " " + Patronymic + "\r\n");
                    if (Man.Checked) File.AppendAllText("���������.txt", "��� - �������\r\n");
                    if (Woman.Checked) File.AppendAllText("���������.txt", "��� - �������\r\n");
                    File.AppendAllText("���������.txt", "���� �������� - " + Data + "\r\n");
                    File.AppendAllText("���������.txt", "�������� ����� - " + HomeAdress + "\r\n");
                    File.AppendAllText("���������.txt", "Email ����� - " + EmailAdress + "\r\n");
                    File.AppendAllText("���������.txt", "��������� ������� - " + PhoneType + " " + PhoneNumber + "\r\n");
                    string lineOne = "���� ������ - ";
                    switch (experience)
                    {
                        case 1: File.AppendAllText("���������.txt", "������ �� �������" + "\r\n"); break;
                        case 2: File.AppendAllText("���������.txt", lineOne + "������ 1 ����" + "\r\n"); break;
                        case 3: File.AppendAllText("���������.txt", lineOne + "�� 1 ���� �� 5 ���" + "\r\n"); break;
                        case 4: File.AppendAllText("���������.txt", lineOne + "�� 5 �� 9 ���" + "\r\n"); break;
                        case 5: File.AppendAllText("���������.txt", lineOne + "10 ��� � ������" + "\r\n"); break;
                    }
                    string lineTwo = "��� ��������� - ";
                    switch (schedule)
                    {
                        case 1: File.AppendAllText("���������.txt", lineTwo + "������ ���������" + "\r\n"); break;
                        case 2: File.AppendAllText("���������.txt", lineTwo + "��������� ���������" + "\r\n"); break;
                        case 3: File.AppendAllText("���������.txt", lineTwo + "������ �� ����" + "\r\n"); break;
                        case 4: File.AppendAllText("���������.txt", lineTwo + "��������� ������" + "\r\n"); break;
                    }

                    if (checkBox1.Checked) File.AppendAllText("���������.txt", "������ ���������� - ����\r\n");
                    else File.AppendAllText("���������.txt", "������� ���������� - ����\r\n");

                    if (checkBox2.Checked)
                    {
                        File.AppendAllText("���������.txt", "������������ ������������� - ���� ");
                        if (checkBox3.Checked) File.AppendAllText("���������.txt", " A");
                        if (checkBox4.Checked) File.AppendAllText("���������.txt", " B");
                        if (checkBox5.Checked) File.AppendAllText("���������.txt", " C");
                        if (checkBox6.Checked) File.AppendAllText("���������.txt", " D");
                        File.AppendAllText("���������.txt", "\r\n");

                    }
                    else File.AppendAllText("���������.txt", "������������ ������������� - ����\r\n");
                    if (MinSalary != "0" && MaxSalary != "0") File.AppendAllText("���������.txt", "�� ��:" + MinSalary + " ��:" + MaxSalary + "\r\n");
                    if (richTextBox1.Text != String.Empty) File.AppendAllText("���������.txt", "������� ������:\r\n" + Summary + "\r\n");
                    File.AppendAllText("���������.txt", "=================================\r\n");

                    MessageBox.Show("���������!", "����������!", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                else
                {
                    string lineThree = "������� ������� �������� ����:\r\n";
                    if (!lastNameVerification) { lineThree += "- �������\r\n"; textBox1.BackColor = Color.DarkRed; }
                    if (!firstNameVerification) { lineThree += "- ���\r\n"; textBox2.BackColor = Color.DarkRed; }
                    if (!PatronymicVerification) { lineThree += "- ��������\r\n"; textBox3.BackColor = Color.DarkRed; }
                    if (!EmailAdressVerification) { lineThree += "- ������ �. �����\r\n"; textBox5.BackColor = Color.DarkRed; }
                    if (!PhoneNumberVerification) { lineThree += "- ����� ��������\r\n"; textBox6.BackColor = Color.DarkRed; }
                    MessageBox.Show(lineThree, "������� ��������� ����!", MessageBoxButtons.OK);
                }
            }
            else
            {
                string lineFour = "�� ��������� �������� ����:\r\n";
                if (textBox1.Text == string.Empty) { lineFour += "- �������\r\n"; textBox1.BackColor = Color.DarkRed; }
                if (textBox2.Text == string.Empty) { lineFour += "- ���\r\n"; textBox2.BackColor = Color.DarkRed; }
                if (textBox3.Text == string.Empty) { lineFour += "- ��������\r\n"; textBox3.BackColor = Color.DarkRed; }
                if (comboBox1.Text == string.Empty) { lineFour += "- ���� ��������\r\n"; comboBox1.BackColor = Color.DarkRed; }
                if (comboBox2.Text == string.Empty) { lineFour += "- ����� ��������\r\n"; comboBox2.BackColor = Color.DarkRed; }
                if (comboBox3.Text == string.Empty) { lineFour += "- ��� ��������\r\n"; comboBox3.BackColor = Color.DarkRed; }
                if (textBox5.Text == string.Empty) { lineFour += "- ����� ��. �����\r\n"; textBox5.BackColor = Color.DarkRed; }

                MessageBox.Show(lineFour, "�� ��������� ����!", MessageBoxButtons.OK);
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            Experience1.Checked = false;
            Experience2.Checked = false;
            Experience3.Checked = false;
            Experience4.Checked = false;
            Experience5.Checked = false;
            Man.Checked = false;
            Woman.Checked = false;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox5.Text = string.Empty;
            textBox6.Text = string.Empty;
            richTextBox1.Text = string.Empty;
            comboBox1.Text = string.Empty;
            comboBox2.Text = string.Empty;
            comboBox3.Text = string.Empty;
            comboBox4.Text = string.Empty;
            numericUpDown1.Text = "0";
            numericUpDown2.Text = "0";
            radioButton8.Checked = false;
            radioButton9.Checked = false;
            radioButton10.Checked = false;
            radioButton11.Checked = false;
            textBox1.BackColor = Color.White;
            textBox2.BackColor = Color.White;
            textBox3.BackColor = Color.White;
            textBox5.BackColor = Color.White;
            textBox6.BackColor = Color.White;
            comboBox1.BackColor = Color.White;
            comboBox2.BackColor = Color.White;
            comboBox3.BackColor = Color.White;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, helpProvider1.HelpNamespace);
        }
    }
}