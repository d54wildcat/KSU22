namespace Ksu.Cis300.TextEditor
{
    partial class UserInterface
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.uxMenu = new System.Windows.Forms.MenuStrip();
            this.uxFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.uxOpenFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.uxSaveFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.uxTextBox = new System.Windows.Forms.TextBox();
            this.uxOpenDialog = new System.Windows.Forms.OpenFileDialog();
            this.uxSaveDialog = new System.Windows.Forms.SaveFileDialog();
            this.uxMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(513, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // uxMenu
            // 
            this.uxMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uxFileMenu});
            this.uxMenu.Location = new System.Drawing.Point(0, 0);
            this.uxMenu.Name = "uxMenu";
            this.uxMenu.Size = new System.Drawing.Size(513, 24);
            this.uxMenu.TabIndex = 1;
            this.uxMenu.Text = "menuStrip2";
            // 
            // uxFileMenu
            // 
            this.uxFileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uxOpenFileMenu,
            this.uxSaveFileMenu});
            this.uxFileMenu.Name = "uxFileMenu";
            this.uxFileMenu.Size = new System.Drawing.Size(37, 20);
            this.uxFileMenu.Text = "File";
            // 
            // uxOpenFileMenu
            // 
            this.uxOpenFileMenu.Name = "uxOpenFileMenu";
            this.uxOpenFileMenu.Size = new System.Drawing.Size(180, 22);
            this.uxOpenFileMenu.Text = "Open";
            this.uxOpenFileMenu.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // uxSaveFileMenu
            // 
            this.uxSaveFileMenu.Name = "uxSaveFileMenu";
            this.uxSaveFileMenu.Size = new System.Drawing.Size(180, 22);
            this.uxSaveFileMenu.Text = "Save";
            this.uxSaveFileMenu.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // uxTextBox
            // 
            this.uxTextBox.Location = new System.Drawing.Point(12, 51);
            this.uxTextBox.Multiline = true;
            this.uxTextBox.Name = "uxTextBox";
            this.uxTextBox.Size = new System.Drawing.Size(468, 417);
            this.uxTextBox.TabIndex = 2;
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 507);
            this.Controls.Add(this.uxTextBox);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.uxMenu);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "UserInterface";
            this.Text = "Text Editor";
            this.uxMenu.ResumeLayout(false);
            this.uxMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip uxMenu;
        private System.Windows.Forms.ToolStripMenuItem uxFileMenu;
        private System.Windows.Forms.ToolStripMenuItem uxOpenFileMenu;
        private System.Windows.Forms.ToolStripMenuItem uxSaveFileMenu;
        private System.Windows.Forms.TextBox uxTextBox;
        private System.Windows.Forms.OpenFileDialog uxOpenDialog;
        private System.Windows.Forms.SaveFileDialog uxSaveDialog;
    }
}

