namespace Tutorial
{
    partial class fmChapter3
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
            this.gbChapter = new System.Windows.Forms.GroupBox();
            this.btnChapter3_1 = new System.Windows.Forms.Button();
            this.btnChapter3 = new System.Windows.Forms.Button();
            this.gbChapter.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbChapter
            // 
            this.gbChapter.Controls.Add(this.btnChapter3_1);
            this.gbChapter.Controls.Add(this.btnChapter3);
            this.gbChapter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbChapter.Location = new System.Drawing.Point(0, 0);
            this.gbChapter.Name = "gbChapter";
            this.gbChapter.Size = new System.Drawing.Size(300, 269);
            this.gbChapter.TabIndex = 0;
            this.gbChapter.TabStop = false;
            // 
            // btnChapter3_1
            // 
            this.btnChapter3_1.Location = new System.Drawing.Point(13, 57);
            this.btnChapter3_1.Name = "btnChapter3_1";
            this.btnChapter3_1.Size = new System.Drawing.Size(275, 38);
            this.btnChapter3_1.TabIndex = 1;
            this.btnChapter3_1.Text = "Anonymous \"Read Only";
            this.btnChapter3_1.UseVisualStyleBackColor = true;
            this.btnChapter3_1.Click += new System.EventHandler(this.btnChapter3_1_Click);
            // 
            // btnChapter3
            // 
            this.btnChapter3.Location = new System.Drawing.Point(13, 13);
            this.btnChapter3.Name = "btnChapter3";
            this.btnChapter3.Size = new System.Drawing.Size(275, 38);
            this.btnChapter3.TabIndex = 0;
            this.btnChapter3.Text = "propfull , prop";
            this.btnChapter3.UseVisualStyleBackColor = true;
            this.btnChapter3.Click += new System.EventHandler(this.btnChapter3_Click);
            // 
            // fmChapter3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 269);
            this.Controls.Add(this.gbChapter);
            this.Name = "fmChapter3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chapter 3";
            this.gbChapter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbChapter;
        private System.Windows.Forms.Button btnChapter3_1;
        private System.Windows.Forms.Button btnChapter3;
    }
}