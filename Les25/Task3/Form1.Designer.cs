namespace Task3
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
            components = new System.ComponentModel.Container();
            catsButton1 = new CatsButton(components);
            SuspendLayout();
            // 
            // catsButton1
            // 
            catsButton1.Location = new Point(68, 12);
            catsButton1.Name = "catsButton1";
            catsButton1.Size = new Size(203, 29);
            catsButton1.TabIndex = 0;
            catsButton1.Text = "Получить котёнка!";
            catsButton1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(336, 61);
            Controls.Add(catsButton1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Котик";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private CatsButton catsButton1;
    }
}