namespace AlgebricEqSolver
{
    partial class slForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.selcomb = new System.Windows.Forms.ComboBox();
            this.btnok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Your Option";
            // 
            // selcomb
            // 
            this.selcomb.FormattingEnabled = true;
            this.selcomb.Items.AddRange(new object[] {
            "Quadratic_Equations",
            "Linear_Equations",
            "(a+/-b)^n",
            "(a^n+/-b^n)"});
            this.selcomb.Location = new System.Drawing.Point(239, 50);
            this.selcomb.Name = "selcomb";
            this.selcomb.Size = new System.Drawing.Size(121, 21);
            this.selcomb.TabIndex = 1;
            this.selcomb.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnok
            // 
            this.btnok.Location = new System.Drawing.Point(260, 131);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(75, 23);
            this.btnok.TabIndex = 2;
            this.btnok.Text = "OK";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // slForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 261);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.selcomb);
            this.Controls.Add(this.label1);
            this.Name = "slForm";
            this.Text = "SelectionForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox selcomb;
        private System.Windows.Forms.Button btnok;
    }
}

