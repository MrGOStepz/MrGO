namespace Tutorial
{
    partial class fmAnonymous
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
            this.btnCode2 = new System.Windows.Forms.Button();
            this.btnCode1 = new System.Windows.Forms.Button();
            this.gbForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbForm
            // 
            this.gbForm.Controls.Add(this.btnCode2);
            this.gbForm.Controls.Add(this.btnCode1);
            this.gbForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbForm.Location = new System.Drawing.Point(0, 0);
            this.gbForm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbForm.Name = "gbForm";
            this.gbForm.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbForm.Size = new System.Drawing.Size(317, 316);
            this.gbForm.TabIndex = 0;
            this.gbForm.TabStop = false;
            // 
            // btnCode2
            // 
            this.btnCode2.Location = new System.Drawing.Point(14, 72);
            this.btnCode2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCode2.Name = "btnCode2";
            this.btnCode2.Size = new System.Drawing.Size(290, 39);
            this.btnCode2.TabIndex = 1;
            this.btnCode2.Text = "Code 2";
            this.btnCode2.UseVisualStyleBackColor = true;
            this.btnCode2.Click += new System.EventHandler(this.btnCode2_Click);
            // 
            // btnCode1
            // 
            this.btnCode1.Location = new System.Drawing.Point(14, 26);
            this.btnCode1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCode1.Name = "btnCode1";
            this.btnCode1.Size = new System.Drawing.Size(290, 39);
            this.btnCode1.TabIndex = 0;
            this.btnCode1.Text = "Code 1";
            this.btnCode1.UseVisualStyleBackColor = true;
            this.btnCode1.Click += new System.EventHandler(this.btnCode_Click);
            // 
            // fmAnonymous
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 316);
            this.Controls.Add(this.gbForm);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "fmAnonymous";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chapter 3.1";
            this.gbForm.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbForm;
        private System.Windows.Forms.Button btnCode1;
        private System.Windows.Forms.Button btnCode2;
    }
}