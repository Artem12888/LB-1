namespace Lab1
{
    partial class Task4
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCalculatePercen = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.txtPercent = new System.Windows.Forms.TextBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(102, 112);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(57, 29);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCalculatePercen
            // 
            this.btnCalculatePercen.Location = new System.Drawing.Point(6, 112);
            this.btnCalculatePercen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCalculatePercen.Name = "btnCalculatePercen";
            this.btnCalculatePercen.Size = new System.Drawing.Size(81, 26);
            this.btnCalculatePercen.TabIndex = 15;
            this.btnCalculatePercen.Text = "Вычислить";
            this.btnCalculatePercen.UseVisualStyleBackColor = true;
            this.btnCalculatePercen.Click += new System.EventHandler(this.btnCalculatePercen_Click);
            // 
            // txtResult
            // 
            this.txtResult.Enabled = false;
            this.txtResult.ForeColor = System.Drawing.Color.Black;
            this.txtResult.Location = new System.Drawing.Point(11, 79);
            this.txtResult.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(108, 20);
            this.txtResult.TabIndex = 14;
            // 
            // txtPercent
            // 
            this.txtPercent.ForeColor = System.Drawing.Color.Black;
            this.txtPercent.Location = new System.Drawing.Point(11, 46);
            this.txtPercent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPercent.Name = "txtPercent";
            this.txtPercent.Size = new System.Drawing.Size(76, 20);
            this.txtPercent.TabIndex = 13;
            // 
            // txtNumber
            // 
            this.txtNumber.ForeColor = System.Drawing.Color.Black;
            this.txtNumber.Location = new System.Drawing.Point(11, 11);
            this.txtNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(76, 20);
            this.txtNumber.TabIndex = 12;
            // 
            // Task4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(497, 253);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculatePercen);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtPercent);
            this.Controls.Add(this.txtNumber);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Task4";
            this.Text = "Task4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCalculatePercen;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.TextBox txtPercent;
        private System.Windows.Forms.TextBox txtNumber;
    }
}