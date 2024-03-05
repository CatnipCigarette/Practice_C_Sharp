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
            components = new System.ComponentModel.Container();
            clickButton1 = new ClickButton(components);
            userControlTimer1 = new UserControlTimer();
            userControlTimer21 = new UserControlTimer2();
            clickButton2 = new ClickButton(components);
            SuspendLayout();
            // 
            // clickButton1
            // 
            clickButton1.Location = new Point(12, 22);
            clickButton1.Name = "clickButton1";
            clickButton1.Size = new Size(262, 118);
            clickButton1.TabIndex = 0;
            clickButton1.Text = "Не тыкать!";
            clickButton1.UseVisualStyleBackColor = true;
            // 
            // userControlTimer1
            // 
            userControlTimer1.Location = new Point(94, 158);
            userControlTimer1.Name = "userControlTimer1";
            userControlTimer1.Size = new Size(90, 37);
            userControlTimer1.TabIndex = 1;
            userControlTimer1.TimeEnabled = true;
            // 
            // userControlTimer21
            // 
            userControlTimer21.Location = new Point(106, 145);
            userControlTimer21.Name = "userControlTimer21";
            userControlTimer21.Size = new Size(67, 22);
            userControlTimer21.TabIndex = 2;
            // 
            // clickButton2
            // 
            clickButton2.Location = new Point(363, 223);
            clickButton2.Name = "clickButton2";
            clickButton2.Size = new Size(227, 173);
            clickButton2.TabIndex = 3;
            clickButton2.Text = "clickButton2";
            clickButton2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(671, 515);
            Controls.Add(clickButton2);
            Controls.Add(userControlTimer21);
            Controls.Add(userControlTimer1);
            Controls.Add(clickButton1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ClickButton clickButton1;
        private UserControlTimer userControlTimer1;
        private UserControlTimer2 userControlTimer21;
        private ClickButton clickButton2;
    }
}