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
            this.uxMenuBar = new System.Windows.Forms.MenuStrip();
            this.uxFile = new System.Windows.Forms.ToolStripMenuItem();
            this.uxOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.uxSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.uxTextBox = new System.Windows.Forms.TextBox();
            this.uxOpenDialog = new System.Windows.Forms.OpenFileDialog();
            this.uxSaveDialog = new System.Windows.Forms.SaveFileDialog();
            this.uxEncrypt = new System.Windows.Forms.ToolStripMenuItem();
            this.uxEncryptString = new System.Windows.Forms.ToolStripMenuItem();
            this.uxEncryptStringBuilder = new System.Windows.Forms.ToolStripMenuItem();
            this.uxMenuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // uxMenuBar
            // 
            this.uxMenuBar.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.uxMenuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uxFile,
            this.uxEncrypt});
            this.uxMenuBar.Location = new System.Drawing.Point(0, 0);
            this.uxMenuBar.Name = "uxMenuBar";
            this.uxMenuBar.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.uxMenuBar.Size = new System.Drawing.Size(389, 24);
            this.uxMenuBar.TabIndex = 0;
            this.uxMenuBar.Text = "menuStrip1";
            // 
            // uxFile
            // 
            this.uxFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uxOpen,
            this.uxSaveAs});
            this.uxFile.Name = "uxFile";
            this.uxFile.Size = new System.Drawing.Size(37, 22);
            this.uxFile.Text = "File";
            // 
            // uxOpen
            // 
            this.uxOpen.Name = "uxOpen";
            this.uxOpen.Size = new System.Drawing.Size(180, 22);
            this.uxOpen.Text = "Open . . .";
            this.uxOpen.Click += new System.EventHandler(this.uxOpen_Click);
            // 
            // uxSaveAs
            // 
            this.uxSaveAs.Name = "uxSaveAs";
            this.uxSaveAs.Size = new System.Drawing.Size(180, 22);
            this.uxSaveAs.Text = "Save As . . .";
            this.uxSaveAs.Click += new System.EventHandler(this.uxSaveAs_Click);
            // 
            // uxTextBox
            // 
            this.uxTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uxTextBox.Location = new System.Drawing.Point(8, 23);
            this.uxTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxTextBox.MaxLength = 0;
            this.uxTextBox.Multiline = true;
            this.uxTextBox.Name = "uxTextBox";
            this.uxTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.uxTextBox.Size = new System.Drawing.Size(374, 310);
            this.uxTextBox.TabIndex = 1;
            // 
            // uxEncrypt
            // 
            this.uxEncrypt.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uxEncryptString,
            this.uxEncryptStringBuilder});
            this.uxEncrypt.Name = "uxEncrypt";
            this.uxEncrypt.Size = new System.Drawing.Size(59, 22);
            this.uxEncrypt.Text = "Encrypt";
            // 
            // uxEncryptString
            // 
            this.uxEncryptString.Name = "uxEncryptString";
            this.uxEncryptString.Size = new System.Drawing.Size(180, 22);
            this.uxEncryptString.Text = "With String";
            this.uxEncryptString.Click += new System.EventHandler(this.UxEncryptString);
            // 
            // uxEncryptStringBuilder
            // 
            this.uxEncryptStringBuilder.Name = "uxEncryptStringBuilder";
            this.uxEncryptStringBuilder.Size = new System.Drawing.Size(180, 22);
            this.uxEncryptStringBuilder.Text = "With StringBuilder";
            this.uxEncryptStringBuilder.Click += new System.EventHandler(this.uxEnryptStringBuilder);
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 339);
            this.Controls.Add(this.uxTextBox);
            this.Controls.Add(this.uxMenuBar);
            this.MainMenuStrip = this.uxMenuBar;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UserInterface";
            this.Text = "Text Editor";
            this.uxMenuBar.ResumeLayout(false);
            this.uxMenuBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip uxMenuBar;
        private System.Windows.Forms.ToolStripMenuItem uxFile;
        private System.Windows.Forms.ToolStripMenuItem uxOpen;
        private System.Windows.Forms.ToolStripMenuItem uxSaveAs;
        private System.Windows.Forms.TextBox uxTextBox;
        private System.Windows.Forms.OpenFileDialog uxOpenDialog;
        private System.Windows.Forms.SaveFileDialog uxSaveDialog;
        private System.Windows.Forms.ToolStripMenuItem uxEncrypt;
        private System.Windows.Forms.ToolStripMenuItem uxEncryptString;
        private System.Windows.Forms.ToolStripMenuItem uxEncryptStringBuilder;
    }
}

