using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Task3
{
    public partial class CatsButton : Button
    {
        private Form catForm;
        private PictureBox catPictureBox;
        private Button closeButton;

        public CatsButton()
        {
            InitializeComponent();

            this.Text = "Получить котёнка";
            this.Click += new EventHandler(CatsButton_Click);
        }

        public CatsButton(IContainer container)
        {
            container.Add(this);

            InitializeComponent();

            this.Text = "Получить котёнка";
            this.Click += new EventHandler(CatsButton_Click);
        }

        private void CatsButton_Click(object sender, EventArgs e)
        {
            catForm = new Form();
            catForm.Size = new Size(300, 300);
            catForm.StartPosition = FormStartPosition.Manual;
            catForm.Location = new Point(0, 0);

            catPictureBox = new PictureBox();
            catPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            catPictureBox.Image = Image.FromFile(@"E:\Учёба\Практика по пр\Les25\cat.jpg");
            catPictureBox.Size = new Size(300, 300);
            catPictureBox.Location = new Point(0, 0);
            catPictureBox.MouseEnter += new EventHandler(CatPictureBox_MouseEnter);

            closeButton = new Button();
            closeButton.Text = "Жаль!";
            closeButton.Location = new Point(100, 250);
            closeButton.Click += new EventHandler(CloseButton_Click);

            catForm.Controls.Add(catPictureBox);
            catForm.Controls.Add(closeButton);

            catForm.Show();
        }

        private void CatPictureBox_MouseEnter(object sender, EventArgs e)
        {
            catPictureBox.Dispose();
            catForm.Hide();

            MessageBox.Show("Котик убежал ;(");
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            catForm.Close();
        }
    }
}

