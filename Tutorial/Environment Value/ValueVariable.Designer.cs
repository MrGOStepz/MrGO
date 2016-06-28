namespace Tutorial
{
    partial class ValueVariable
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
            this.btnShow = new System.Windows.Forms.Button();
            this.btnSet = new System.Windows.Forms.Button();
            this.txtValueVar = new System.Windows.Forms.TextBox();
            this.txtNameVar = new System.Windows.Forms.TextBox();
            this.lbValueVar = new System.Windows.Forms.Label();
            this.lbNVar = new System.Windows.Forms.Label();
            this.btnGet = new System.Windows.Forms.Button();
            this.lvGetAll = new System.Windows.Forms.ListView();
            this.chVariable = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbForm
            // 
            this.gbForm.Controls.Add(this.btnShow);
            this.gbForm.Controls.Add(this.btnSet);
            this.gbForm.Controls.Add(this.txtValueVar);
            this.gbForm.Controls.Add(this.txtNameVar);
            this.gbForm.Controls.Add(this.lbValueVar);
            this.gbForm.Controls.Add(this.lbNVar);
            this.gbForm.Controls.Add(this.btnGet);
            this.gbForm.Controls.Add(this.lvGetAll);
            this.gbForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbForm.Location = new System.Drawing.Point(0, 0);
            this.gbForm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbForm.Name = "gbForm";
            this.gbForm.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbForm.Size = new System.Drawing.Size(651, 615);
            this.gbForm.TabIndex = 1;
            this.gbForm.TabStop = false;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(309, 578);
            this.btnShow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(84, 29);
            this.btnShow.TabIndex = 8;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(218, 578);
            this.btnSet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(84, 29);
            this.btnSet.TabIndex = 7;
            this.btnSet.Text = "Set";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // txtValueVar
            // 
            this.txtValueVar.Location = new System.Drawing.Point(127, 542);
            this.txtValueVar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtValueVar.Name = "txtValueVar";
            this.txtValueVar.Size = new System.Drawing.Size(517, 26);
            this.txtValueVar.TabIndex = 6;
            // 
            // txtNameVar
            // 
            this.txtNameVar.Location = new System.Drawing.Point(127, 508);
            this.txtNameVar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNameVar.Name = "txtNameVar";
            this.txtNameVar.Size = new System.Drawing.Size(517, 26);
            this.txtNameVar.TabIndex = 5;
            // 
            // lbValueVar
            // 
            this.lbValueVar.AutoSize = true;
            this.lbValueVar.Location = new System.Drawing.Point(7, 546);
            this.lbValueVar.Name = "lbValueVar";
            this.lbValueVar.Size = new System.Drawing.Size(120, 20);
            this.lbValueVar.TabIndex = 4;
            this.lbValueVar.Text = "Value Variable :";
            // 
            // lbNVar
            // 
            this.lbNVar.AutoSize = true;
            this.lbNVar.Location = new System.Drawing.Point(7, 508);
            this.lbNVar.Name = "lbNVar";
            this.lbNVar.Size = new System.Drawing.Size(121, 20);
            this.lbNVar.TabIndex = 3;
            this.lbNVar.Text = "Name Variable :";
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(127, 578);
            this.btnGet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(84, 29);
            this.btnGet.TabIndex = 2;
            this.btnGet.Text = "Get";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // lvGetAll
            // 
            this.lvGetAll.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvGetAll.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chVariable,
            this.chValue});
            this.lvGetAll.FullRowSelect = true;
            this.lvGetAll.GridLines = true;
            this.lvGetAll.HotTracking = true;
            this.lvGetAll.HoverSelection = true;
            this.lvGetAll.Location = new System.Drawing.Point(7, 15);
            this.lvGetAll.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lvGetAll.Name = "lvGetAll";
            this.lvGetAll.Size = new System.Drawing.Size(637, 483);
            this.lvGetAll.TabIndex = 1;
            this.lvGetAll.UseCompatibleStateImageBehavior = false;
            this.lvGetAll.View = System.Windows.Forms.View.Details;
            // 
            // chVariable
            // 
            this.chVariable.Text = "Name Variable";
            this.chVariable.Width = 180;
            // 
            // chValue
            // 
            this.chValue.Text = "Value Variable";
            this.chValue.Width = 382;
            // 
            // ValueVariable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 615);
            this.Controls.Add(this.gbForm);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ValueVariable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chapter2";
            this.Load += new System.EventHandler(this.Chapter2_Load);
            this.gbForm.ResumeLayout(false);
            this.gbForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbForm;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.TextBox txtValueVar;
        private System.Windows.Forms.TextBox txtNameVar;
        private System.Windows.Forms.Label lbValueVar;
        private System.Windows.Forms.Label lbNVar;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.ListView lvGetAll;
        private System.Windows.Forms.ColumnHeader chVariable;
        private System.Windows.Forms.ColumnHeader chValue;
    }
}