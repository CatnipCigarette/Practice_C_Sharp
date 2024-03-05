namespace Task1
{
    partial class ChildForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ChildTextBox = new RichTextBox();
            ChildWindowMenu = new MenuStrip();
            FormatMenuItem = new ToolStripMenuItem();
            ToggleMenuItem = new ToolStripMenuItem();
            ChildWindowMenu.SuspendLayout();
            SuspendLayout();
            // 
            // ChildTextBox
            // 
            ChildTextBox.Dock = DockStyle.Fill;
            ChildTextBox.Location = new Point(0, 28);
            ChildTextBox.Name = "ChildTextBox";
            ChildTextBox.Size = new Size(382, 225);
            ChildTextBox.TabIndex = 0;
            ChildTextBox.Text = "";
            // 
            // ChildWindowMenu
            // 
            ChildWindowMenu.ImageScalingSize = new Size(20, 20);
            ChildWindowMenu.Items.AddRange(new ToolStripItem[] { FormatMenuItem });
            ChildWindowMenu.Location = new Point(0, 0);
            ChildWindowMenu.Name = "ChildWindowMenu";
            ChildWindowMenu.Size = new Size(382, 28);
            ChildWindowMenu.TabIndex = 1;
            ChildWindowMenu.Text = "menuStrip1";
            // 
            // FormatMenuItem
            // 
            FormatMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ToggleMenuItem });
            FormatMenuItem.MergeAction = MergeAction.Insert;
            FormatMenuItem.MergeIndex = 1;
            FormatMenuItem.Name = "FormatMenuItem";
            FormatMenuItem.Size = new Size(74, 24);
            FormatMenuItem.Text = "F&ormat";
            // 
            // ToggleMenuItem
            // 
            ToggleMenuItem.Name = "ToggleMenuItem";
            ToggleMenuItem.Size = new Size(225, 26);
            ToggleMenuItem.Text = "&Toggle Foreground";
            ToggleMenuItem.Click += ToggleMenuItem_Click;
            // 
            // ChildForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 253);
            Controls.Add(ChildTextBox);
            Controls.Add(ChildWindowMenu);
            MainMenuStrip = ChildWindowMenu;
            Name = "ChildForm";
            Text = "Child Form";
            ChildWindowMenu.ResumeLayout(false);
            ChildWindowMenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox ChildTextBox;
        private MenuStrip ChildWindowMenu;
        private ToolStripMenuItem FormatMenuItem;
        private ToolStripMenuItem ToggleMenuItem;
    }
}