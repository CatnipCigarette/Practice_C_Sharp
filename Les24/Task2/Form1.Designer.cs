using System.Windows.Forms.DataVisualization.Charting;

namespace Task2
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
            ChartArea chartArea1 = new ChartArea();
            Legend legend1 = new Legend();
            Series series1 = new Series();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            chart2 = new Chart();
            ((System.ComponentModel.ISupportInitialize)chart2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 407);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 1;
            label1.Text = "Xmin";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(153, 407);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 2;
            label2.Text = "Xmax";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(257, 407);
            label3.Name = "label3";
            label3.Size = new Size(38, 20);
            label3.TabIndex = 3;
            label3.Text = "Шаг";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(49, 430);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(75, 27);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(153, 430);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(75, 27);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(257, 430);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(75, 27);
            textBox3.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(557, 428);
            button1.Name = "button1";
            button1.Size = new Size(123, 29);
            button1.TabIndex = 7;
            button1.Text = "Расчёт!";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // chart2
            // 
            chartArea1.Name = "ChartArea1";
            chart2.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart2.Legends.Add(legend1);
            chart2.Location = new Point(49, 12);
            chart2.Name = "chart2";
            chart2.Palette = ChartColorPalette.Berry;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart2.Series.Add(series1);
            chart2.Size = new Size(631, 375);
            chart2.TabIndex = 8;
            chart2.Text = "chart2";
            chart2.Click += chart2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(737, 485);
            Controls.Add(chart2);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "График функции";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)chart2).EndInit();
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
        private Button button1;
        private System.CodeDom.CodeTypeReference chart1;
        private Chart chart2;
    }
}