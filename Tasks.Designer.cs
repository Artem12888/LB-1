namespace Lab1
{
    partial class Tasks
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
            this.task1 = new System.Windows.Forms.Button();
            this.task2 = new System.Windows.Forms.Button();
            this.task3 = new System.Windows.Forms.Button();
            this.task4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(160, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выбирите дополнительные задания";
            // 
            // task1
            // 
            this.task1.Location = new System.Drawing.Point(163, 103);
            this.task1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.task1.Name = "task1";
            this.task1.Size = new System.Drawing.Size(76, 27);
            this.task1.TabIndex = 5;
            this.task1.Text = "Задание 1";
            this.task1.UseVisualStyleBackColor = true;
            this.task1.Click += new System.EventHandler(this.task1_Click);
            // 
            // task2
            // 
            this.task2.Location = new System.Drawing.Point(163, 157);
            this.task2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.task2.Name = "task2";
            this.task2.Size = new System.Drawing.Size(76, 27);
            this.task2.TabIndex = 6;
            this.task2.Text = "Задание 2";
            this.task2.UseVisualStyleBackColor = true;
            this.task2.Click += new System.EventHandler(this.task2_Click);
            // 
            // task3
            // 
            this.task3.Location = new System.Drawing.Point(284, 103);
            this.task3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.task3.Name = "task3";
            this.task3.Size = new System.Drawing.Size(76, 27);
            this.task3.TabIndex = 7;
            this.task3.Text = "Задание 3";
            this.task3.UseVisualStyleBackColor = true;
            this.task3.Click += new System.EventHandler(this.task3_Click);
            // 
            // task4
            // 
            this.task4.Location = new System.Drawing.Point(284, 157);
            this.task4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.task4.Name = "task4";
            this.task4.Size = new System.Drawing.Size(76, 27);
            this.task4.TabIndex = 8;
            this.task4.Text = "Задание 4";
            this.task4.UseVisualStyleBackColor = true;
            this.task4.Click += new System.EventHandler(this.task4_Click);
            // 
            // Tasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(464, 207);
            this.Controls.Add(this.task4);
            this.Controls.Add(this.task3);
            this.Controls.Add(this.task2);
            this.Controls.Add(this.task1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Tasks";
            this.Text = "Tasks";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button task1;
        private System.Windows.Forms.Button task2;
        private System.Windows.Forms.Button task3;
        private System.Windows.Forms.Button task4;
    }
}