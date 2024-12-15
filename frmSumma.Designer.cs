namespace Lab1
{
    partial class frmSumma
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtSumma = new System.Windows.Forms.TextBox();
            this.btnCount = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.tasksBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtA
            // 
            this.txtA.ForeColor = System.Drawing.Color.Black;
            this.txtA.Location = new System.Drawing.Point(70, 97);
            this.txtA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(76, 20);
            this.txtA.TabIndex = 0;
            // 
            // txtB
            // 
            this.txtB.ForeColor = System.Drawing.Color.Black;
            this.txtB.Location = new System.Drawing.Point(70, 141);
            this.txtB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(76, 20);
            this.txtB.TabIndex = 1;
            // 
            // txtC
            // 
            this.txtC.ForeColor = System.Drawing.Color.Black;
            this.txtC.Location = new System.Drawing.Point(70, 187);
            this.txtC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(76, 20);
            this.txtC.TabIndex = 2;
            // 
            // txtSumma
            // 
            this.txtSumma.Enabled = false;
            this.txtSumma.ForeColor = System.Drawing.Color.Black;
            this.txtSumma.Location = new System.Drawing.Point(70, 226);
            this.txtSumma.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSumma.Name = "txtSumma";
            this.txtSumma.Size = new System.Drawing.Size(76, 20);
            this.txtSumma.TabIndex = 3;
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(61, 260);
            this.btnCount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(106, 27);
            this.btnCount.TabIndex = 4;
            this.btnCount.Text = "Вычислить";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(92, 313);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 27);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // tasksBtn
            // 
            this.tasksBtn.Location = new System.Drawing.Point(206, 226);
            this.tasksBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tasksBtn.Name = "tasksBtn";
            this.tasksBtn.Size = new System.Drawing.Size(116, 40);
            this.tasksBtn.TabIndex = 6;
            this.tasksBtn.Text = "Дополнительный задания";
            this.tasksBtn.UseVisualStyleBackColor = true;
            this.tasksBtn.Click += new System.EventHandler(this.tasksBtn_Click_1);
            // 
            // frmSumma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(350, 375);
            this.Controls.Add(this.tasksBtn);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.txtSumma);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmSumma";
            this.Text = "frmSumma";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.TextBox txtSumma;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button tasksBtn;
    }
}

