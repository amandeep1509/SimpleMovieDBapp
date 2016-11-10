namespace ShowMovieDB
{
    partial class Form2
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
            this.Titlebox = new System.Windows.Forms.TextBox();
            this.Publisherbox = new System.Windows.Forms.TextBox();
            this.Previewedbox = new System.Windows.Forms.TextBox();
            this.ReleaseYearbox = new System.Windows.Forms.TextBox();
            this.TypeIDbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Titlebox
            // 
            this.Titlebox.Location = new System.Drawing.Point(160, 39);
            this.Titlebox.Name = "Titlebox";
            this.Titlebox.Size = new System.Drawing.Size(359, 20);
            this.Titlebox.TabIndex = 0;
            // 
            // Publisherbox
            // 
            this.Publisherbox.Location = new System.Drawing.Point(160, 90);
            this.Publisherbox.Name = "Publisherbox";
            this.Publisherbox.Size = new System.Drawing.Size(359, 20);
            this.Publisherbox.TabIndex = 1;
            // 
            // Previewedbox
            // 
            this.Previewedbox.Location = new System.Drawing.Point(160, 141);
            this.Previewedbox.Name = "Previewedbox";
            this.Previewedbox.Size = new System.Drawing.Size(359, 20);
            this.Previewedbox.TabIndex = 2;
            // 
            // ReleaseYearbox
            // 
            this.ReleaseYearbox.Location = new System.Drawing.Point(160, 193);
            this.ReleaseYearbox.Name = "ReleaseYearbox";
            this.ReleaseYearbox.Size = new System.Drawing.Size(359, 20);
            this.ReleaseYearbox.TabIndex = 3;
            // 
            // TypeIDbox
            // 
            this.TypeIDbox.Location = new System.Drawing.Point(160, 241);
            this.TypeIDbox.Name = "TypeIDbox";
            this.TypeIDbox.Size = new System.Drawing.Size(359, 20);
            this.TypeIDbox.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(411, 313);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 363);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TypeIDbox);
            this.Controls.Add(this.ReleaseYearbox);
            this.Controls.Add(this.Previewedbox);
            this.Controls.Add(this.Publisherbox);
            this.Controls.Add(this.Titlebox);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Titlebox;
        private System.Windows.Forms.TextBox Publisherbox;
        private System.Windows.Forms.TextBox Previewedbox;
        private System.Windows.Forms.TextBox ReleaseYearbox;
        private System.Windows.Forms.TextBox TypeIDbox;
        private System.Windows.Forms.Button button1;
    }
}