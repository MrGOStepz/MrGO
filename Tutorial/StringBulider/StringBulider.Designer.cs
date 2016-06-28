namespace Tutorial
{
    partial class fmStringBulider
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
            this.btnStb = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.lbTime = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.gbForm = new System.Windows.Forms.GroupBox();
            this.gbForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStb
            // 
            this.btnStb.Location = new System.Drawing.Point(96, 58);
            this.btnStb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStb.Name = "btnStb";
            this.btnStb.Size = new System.Drawing.Size(135, 40);
            this.btnStb.TabIndex = 0;
            this.btnStb.Text = "String Bulider";
            this.btnStb.UseVisualStyleBackColor = true;
            this.btnStb.Click += new System.EventHandler(this.btnStb_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(96, 105);
            this.btnPlus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(135, 40);
            this.btnPlus.TabIndex = 1;
            this.btnPlus.Text = "String +";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Location = new System.Drawing.Point(36, 26);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(51, 20);
            this.lbTime.TabIndex = 2;
            this.lbTime.Text = "Time :";
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(96, 22);
            this.txtTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(134, 26);
            this.txtTime.TabIndex = 3;
            // 
            // gbForm
            // 
            this.gbForm.Controls.Add(this.txtTime);
            this.gbForm.Controls.Add(this.btnStb);
            this.gbForm.Controls.Add(this.lbTime);
            this.gbForm.Controls.Add(this.btnPlus);
            this.gbForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbForm.Location = new System.Drawing.Point(0, 0);
            this.gbForm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbForm.Name = "gbForm";
            this.gbForm.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbForm.Size = new System.Drawing.Size(290, 180);
            this.gbForm.TabIndex = 4;
            this.gbForm.TabStop = false;
            // 
            // fmStringBulider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 180);
            this.Controls.Add(this.gbForm);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "fmStringBulider";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chapter 1";
            this.gbForm.ResumeLayout(false);
            this.gbForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStb;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.GroupBox gbForm;
    }
}

