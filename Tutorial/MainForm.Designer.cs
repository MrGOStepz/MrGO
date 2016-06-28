namespace Tutorial
{
    partial class MainForm
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
            this.gbForm = new System.Windows.Forms.GroupBox();
            this.btnChapter4 = new System.Windows.Forms.Button();
            this.btnChapter3 = new System.Windows.Forms.Button();
            this.btnChapter2 = new System.Windows.Forms.Button();
            this.btnChapter1 = new System.Windows.Forms.Button();
            this.gbForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbForm
            // 
            this.gbForm.Controls.Add(this.btnChapter4);
            this.gbForm.Controls.Add(this.btnChapter3);
            this.gbForm.Controls.Add(this.btnChapter2);
            this.gbForm.Controls.Add(this.btnChapter1);
            this.gbForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbForm.Location = new System.Drawing.Point(0, 0);
            this.gbForm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbForm.Name = "gbForm";
            this.gbForm.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbForm.Size = new System.Drawing.Size(298, 316);
            this.gbForm.TabIndex = 0;
            this.gbForm.TabStop = false;
            // 
            // btnChapter4
            // 
            this.btnChapter4.Location = new System.Drawing.Point(15, 165);
            this.btnChapter4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnChapter4.Name = "btnChapter4";
            this.btnChapter4.Size = new System.Drawing.Size(271, 42);
            this.btnChapter4.TabIndex = 3;
            this.btnChapter4.Text = "Chapter 4";
            this.btnChapter4.UseVisualStyleBackColor = true;
            this.btnChapter4.Click += new System.EventHandler(this.btnChapter4_Click);
            // 
            // btnChapter3
            // 
            this.btnChapter3.Location = new System.Drawing.Point(14, 115);
            this.btnChapter3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnChapter3.Name = "btnChapter3";
            this.btnChapter3.Size = new System.Drawing.Size(271, 42);
            this.btnChapter3.TabIndex = 2;
            this.btnChapter3.Text = "Anonymous";
            this.btnChapter3.UseVisualStyleBackColor = true;
            this.btnChapter3.Click += new System.EventHandler(this.btnChapter3_Click);
            // 
            // btnChapter2
            // 
            this.btnChapter2.Location = new System.Drawing.Point(14, 65);
            this.btnChapter2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnChapter2.Name = "btnChapter2";
            this.btnChapter2.Size = new System.Drawing.Size(271, 42);
            this.btnChapter2.TabIndex = 1;
            this.btnChapter2.Text = "Environment Value";
            this.btnChapter2.UseVisualStyleBackColor = true;
            this.btnChapter2.Click += new System.EventHandler(this.btnChapter2_Click);
            // 
            // btnChapter1
            // 
            this.btnChapter1.Location = new System.Drawing.Point(14, 15);
            this.btnChapter1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnChapter1.Name = "btnChapter1";
            this.btnChapter1.Size = new System.Drawing.Size(271, 42);
            this.btnChapter1.TabIndex = 0;
            this.btnChapter1.Text = "String Bulider";
            this.btnChapter1.UseVisualStyleBackColor = true;
            this.btnChapter1.Click += new System.EventHandler(this.btnChapter1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 316);
            this.Controls.Add(this.gbForm);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chapter";
            this.gbForm.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbForm;
        private System.Windows.Forms.Button btnChapter2;
        private System.Windows.Forms.Button btnChapter1;
        private System.Windows.Forms.Button btnChapter3;
        private System.Windows.Forms.Button btnChapter4;
    }
}