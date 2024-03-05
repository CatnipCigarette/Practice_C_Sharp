namespace Les3Task2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label5 = new Label();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            button1 = new Button();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(31, 19);
            label1.Name = "label1";
            label1.Size = new Size(130, 28);
            label1.TabIndex = 0;
            label1.Text = "Введите x =";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(31, 63);
            label2.Name = "label2";
            label2.Size = new Size(130, 28);
            label2.TabIndex = 1;
            label2.Text = "Введите y =";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(32, 106);
            label3.Name = "label3";
            label3.Size = new Size(129, 28);
            label3.TabIndex = 2;
            label3.Text = "Введите z =";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(167, 23);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(79, 27);
            textBox1.TabIndex = 4;
            textBox1.Text = "0,1722";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(167, 67);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(79, 27);
            textBox2.TabIndex = 5;
            textBox2.Text = "6,33";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(167, 110);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(79, 27);
            textBox3.TabIndex = 6;
            textBox3.Text = "3,25";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(252, 106);
            label5.Name = "label5";
            label5.Size = new Size(53, 28);
            label5.TabIndex = 8;
            label5.Text = "x 10";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(301, 93);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(28, 27);
            textBox5.TabIndex = 9;
            textBox5.Text = "-4";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(30, 178);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.ScrollBars = ScrollBars.Vertical;
            textBox6.Size = new Size(399, 216);
            textBox6.TabIndex = 10;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(291, 413);
            button1.Name = "button1";
            button1.Size = new Size(138, 42);
            button1.TabIndex = 11;
            button1.Text = "Выполнить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(30, 147);
            label6.Name = "label6";
            label6.Size = new Size(360, 28);
            label6.TabIndex = 12;
            label6.Text = "Результат выполнения программы:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(459, 466);
            Controls.Add(label6);
            Controls.Add(button1);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Линейные алгоритмы";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label5;
        private TextBox textBox5;
        private TextBox textBox6;
        private Button button1;
        private Label label6;
    }
}