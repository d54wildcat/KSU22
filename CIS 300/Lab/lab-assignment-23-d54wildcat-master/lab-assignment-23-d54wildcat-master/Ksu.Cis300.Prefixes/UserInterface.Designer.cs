namespace Ksu.Cis300.Prefixes
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
            this.uxLookUp = new System.Windows.Forms.Button();
            this.uxWord = new System.Windows.Forms.TextBox();
            this.uxOpen = new System.Windows.Forms.Button();
            this.uxOpenDialog = new System.Windows.Forms.OpenFileDialog();
            this.uxCompletions = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // uxLookUp
            // 
            this.uxLookUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxLookUp.Location = new System.Drawing.Point(15, 114);
            this.uxLookUp.Name = "uxLookUp";
            this.uxLookUp.Size = new System.Drawing.Size(216, 56);
            this.uxLookUp.TabIndex = 18;
            this.uxLookUp.Text = "Look up Prefix";
            this.uxLookUp.UseVisualStyleBackColor = true;
            this.uxLookUp.Click += new System.EventHandler(this.uxLookUp_Click);
            // 
            // uxWord
            // 
            this.uxWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxWord.Location = new System.Drawing.Point(16, 79);
            this.uxWord.Name = "uxWord";
            this.uxWord.Size = new System.Drawing.Size(215, 29);
            this.uxWord.TabIndex = 17;
            // 
            // uxOpen
            // 
            this.uxOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxOpen.Location = new System.Drawing.Point(16, 17);
            this.uxOpen.Name = "uxOpen";
            this.uxOpen.Size = new System.Drawing.Size(215, 56);
            this.uxOpen.TabIndex = 16;
            this.uxOpen.Text = "Open Word List";
            this.uxOpen.UseVisualStyleBackColor = true;
            this.uxOpen.Click += new System.EventHandler(this.uxOpen_Click);
            // 
            // uxOpenDialog
            // 
            this.uxOpenDialog.Filter = "Text Files|*.txt";
            // 
            // uxCompletions
            // 
            this.uxCompletions.FormattingEnabled = true;
            this.uxCompletions.Location = new System.Drawing.Point(16, 176);
            this.uxCompletions.Name = "uxCompletions";
            this.uxCompletions.Size = new System.Drawing.Size(215, 160);
            this.uxCompletions.TabIndex = 19;
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 352);
            this.Controls.Add(this.uxLookUp);
            this.Controls.Add(this.uxWord);
            this.Controls.Add(this.uxOpen);
            this.Controls.Add(this.uxCompletions);
            this.Name = "UserInterface";
            this.Text = "Prefix Lookup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uxLookUp;
        private System.Windows.Forms.TextBox uxWord;
        private System.Windows.Forms.Button uxOpen;
        private System.Windows.Forms.OpenFileDialog uxOpenDialog;
        private System.Windows.Forms.ListBox uxCompletions;
    }
}

