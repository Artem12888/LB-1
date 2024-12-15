namespace Lab1
{
    partial class Task1
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
            this.txtTriangleArea = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCalculateTriangle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTriangleArea
            // 
            this.txtTriangleArea.Enabled = false;
            this.txtTriangleArea.ForeColor = System.Drawing.Color.Black;
            this.txtTriangleArea.Location = new System.Drawing.Point(53, 162);
            this.txtTriangleArea.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTriangleArea.Name = "txtTriangleArea";
            this.txtTriangleArea.Size = new System.Drawing.Size(108, 20);
            this.txtTriangleArea.TabIndex = 7;
            // 
            // txtC
            // 
            this.txtC.ForeColor = System.Drawing.Color.Black;
            this.txtC.Location = new System.Drawing.Point(53, 115);
            this.txtC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(76, 20);
            this.txtC.TabIndex = 6;
            // 
            // txtB
            // 
            this.txtB.ForeColor = System.Drawing.Color.Black;
            this.txtB.Location = new System.Drawing.Point(53, 77);
            this.txtB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(76, 20);
            this.txtB.TabIndex = 5;
            // 
            // txtA
            // 
            this.txtA.ForeColor = System.Drawing.Color.Black;
            this.txtA.Location = new System.Drawing.Point(53, 28);
            this.txtA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(76, 20);
            this.txtA.TabIndex = 4;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(27, 195);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(65, 27);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCalculateTriangle
            // 
            this.btnCalculateTriangle.Location = new System.Drawing.Point(122, 195);
            this.btnCalculateTriangle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCalculateTriangle.Name = "btnCalculateTriangle";
            this.btnCalculateTriangle.Size = new System.Drawing.Size(85, 27);
            this.btnCalculateTriangle.TabIndex = 8;
            this.btnCalculateTriangle.Text = "Вычислить";
            this.btnCalculateTriangle.UseVisualStyleBackColor = true;
            this.btnCalculateTriangle.Click += new System.EventHandler(this.btnCalculateTriangle_Click);
            // 
            // Task1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(220, 239);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculateTriangle);
            this.Controls.Add(this.txtTriangleArea);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Task1";
            this.Text = "Task1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTriangleArea;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCalculateTriangle;
    }
}