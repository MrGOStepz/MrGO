namespace Tutorial
{
    partial class propfull
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
            this.btnCode = new System.Windows.Forms.Button();
            this.gbForm = new System.Windows.Forms.GroupBox();
            this.gbForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCode
            // 
            this.btnCode.Location = new System.Drawing.Point(117, 26);
            this.btnCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCode.Name = "btnCode";
            this.btnCode.Size = new System.Drawing.Size(84, 38);
            this.btnCode.TabIndex = 0;
            this.btnCode.Text = "Code";
            this.btnCode.UseVisualStyleBackColor = true;
            this.btnCode.Click += new System.EventHandler(this.btnCode_Click);
            // 
            // gbForm
            // 
            this.gbForm.Controls.Add(this.btnCode);
            this.gbForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbForm.Location = new System.Drawing.Point(0, 0);
            this.gbForm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbForm.Name = "gbForm";
            this.gbForm.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbForm.Size = new System.Drawing.Size(317, 316);
            this.gbForm.TabIndex = 1;
            this.gbForm.TabStop = false;
            // 
            // propfull
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 316);
            this.Controls.Add(this.gbForm);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "propfull";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chapter3";
            this.Load += new System.EventHandler(this.Chapter3_Load);
            this.gbForm.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCode;
        private System.Windows.Forms.GroupBox gbForm;
    }
}