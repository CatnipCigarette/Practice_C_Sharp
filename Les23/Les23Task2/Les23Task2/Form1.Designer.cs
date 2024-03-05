namespace Les23Task2
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
            label6 = new Label();
            button1 = new Button();
            textBox6 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(26, 201);
            label6.Name = "label6";
            label6.Size = new Size(360, 28);
            label6.TabIndex = 23;
            label6.Text = "Результат выполнения программы:";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(152, 464);
            button1.Name = "button1";
            button1.Size = new Size(138, 42);
            button1.TabIndex = 22;
            button1.Text = "Вычислить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(26, 232);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.ScrollBars = ScrollBars.Vertical;
            textBox6.Size = new Size(399, 216);
            textBox6.TabIndex = 21;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(162, 108);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(79, 27);
            textBox3.TabIndex = 18;
            textBox3.Text = "0,2";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(162, 65);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(79, 27);
            textBox2.TabIndex = 17;
            textBox2.Text = "1";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(162, 21);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(79, 27);
            textBox1.TabIndex = 16;
            textBox1.Text = "-2,4";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(27, 104);
            label3.Name = "label3";
            label3.Size = new Size(138, 28);
            label3.TabIndex = 15;
            label3.Text = "Введите dₓ =";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(26, 61);
            label2.Name = "label2";
            label2.Size = new Size(137, 28);
            label2.TabIndex = 14;
            label2.Text = "Введите xₖ =";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(26, 17);
            label1.Name = "label1";
            label1.Size = new Size(138, 28);
            label1.TabIndex = 13;
            label1.Text = "Введите x₀ =";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(162, 152);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(79, 27);
            textBox4.TabIndex = 25;
            textBox4.Text = "2,5";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(27, 148);
            label4.Name = "label4";
            label4.Size = new Size(137, 28);
            label4.TabIndex = 24;
            label4.Text = "Введите b  =";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(437, 534);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(button1);
            Controls.Add(textBox6);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Циклический алгоритм";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Button button1;
        private TextBox textBox6;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox4;
        private Label label4;
    }
}