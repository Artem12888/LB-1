﻿namespace Lab1
{
    partial class Task3
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
            this.btnCalculateTriangleWithAngle = new System.Windows.Forms.Button();
            this.txtTriangleAngleArea = new System.Windows.Forms.TextBox();
            this.txtAngle = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(23, 196);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(57, 24);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCalculateTriangleWithAngle
            // 
            this.btnCalculateTriangleWithAngle.Location = new System.Drawing.Point(102, 196);
            this.btnCalculateTriangleWithAngle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCalculateTriangleWithAngle.Name = "btnCalculateTriangleWithAngle";
            this.btnCalculateTriangleWithAngle.Size = new System.Drawing.Size(89, 24);
            this.btnCalculateTriangleWithAngle.TabIndex = 14;
            this.btnCalculateTriangleWithAngle.Text = "Вычислить";
            this.btnCalculateTriangleWithAngle.UseVisualStyleBackColor = true;
            this.btnCalculateTriangleWithAngle.Click += new System.EventHandler(this.btnCalculateTriangleWithAngle_Click);
            // 
            // txtTriangleAngleArea
            // 
            this.txtTriangleAngleArea.Enabled = false;
            this.txtTriangleAngleArea.ForeColor = System.Drawing.Color.Black;
            this.txtTriangleAngleArea.Location = new System.Drawing.Point(35, 172);
            this.txtTriangleAngleArea.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTriangleAngleArea.Name = "txtTriangleAngleArea";
            this.txtTriangleAngleArea.Size = new System.Drawing.Size(108, 20);
            this.txtTriangleAngleArea.TabIndex = 13;
            // 
            // txtAngle
            // 
            this.txtAngle.ForeColor = System.Drawing.Color.Black;
            this.txtAngle.Location = new System.Drawing.Point(35, 135);
            this.txtAngle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAngle.Name = "txtAngle";
            this.txtAngle.Size = new System.Drawing.Size(76, 20);
            this.txtAngle.TabIndex = 12;
            // 
            // txtB
            // 
            this.txtB.ForeColor = System.Drawing.Color.Black;
            this.txtB.Location = new System.Drawing.Point(35, 99);
            this.txtB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(76, 20);
            this.txtB.TabIndex = 11;
            // 
            // txtA
            // 
            this.txtA.ForeColor = System.Drawing.Color.Black;
            this.txtA.Location = new System.Drawing.Point(35, 58);
            this.txtA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(76, 20);
            this.txtA.TabIndex = 10;
            // 
            // Task3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(543, 246);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculateTriangleWithAngle);
            this.Controls.Add(this.txtTriangleAngleArea);
            this.Controls.Add(this.txtAngle);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Task3";
            this.Text = "Task3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCalculateTriangleWithAngle;
        private System.Windows.Forms.TextBox txtTriangleAngleArea;
        private System.Windows.Forms.TextBox txtAngle;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtA;
    }
}