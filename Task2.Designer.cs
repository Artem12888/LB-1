﻿namespace Lab1
{
    partial class Task2
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
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtRectangleArea = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCalculateRectangle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtB
            // 
            this.txtB.ForeColor = System.Drawing.Color.Black;
            this.txtB.Location = new System.Drawing.Point(64, 98);
            this.txtB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(106, 20);
            this.txtB.TabIndex = 7;
            // 
            // txtA
            // 
            this.txtA.ForeColor = System.Drawing.Color.Black;
            this.txtA.Location = new System.Drawing.Point(64, 54);
            this.txtA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(106, 20);
            this.txtA.TabIndex = 6;
            // 
            // txtRectangleArea
            // 
            this.txtRectangleArea.Enabled = false;
            this.txtRectangleArea.ForeColor = System.Drawing.Color.Black;
            this.txtRectangleArea.Location = new System.Drawing.Point(64, 148);
            this.txtRectangleArea.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtRectangleArea.Name = "txtRectangleArea";
            this.txtRectangleArea.Size = new System.Drawing.Size(106, 20);
            this.txtRectangleArea.TabIndex = 8;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(175, 184);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(59, 27);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCalculateRectangle
            // 
            this.btnCalculateRectangle.Location = new System.Drawing.Point(64, 184);
            this.btnCalculateRectangle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCalculateRectangle.Name = "btnCalculateRectangle";
            this.btnCalculateRectangle.Size = new System.Drawing.Size(82, 27);
            this.btnCalculateRectangle.TabIndex = 10;
            this.btnCalculateRectangle.Text = "Вычислить";
            this.btnCalculateRectangle.UseVisualStyleBackColor = true;
            this.btnCalculateRectangle.Click += new System.EventHandler(this.btnCalculateRectangle_Click);
            // 
            // Task2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(511, 256);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculateRectangle);
            this.Controls.Add(this.txtRectangleArea);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Task2";
            this.Text = "Task2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtRectangleArea;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCalculateRectangle;
    }
}