﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Task4 : Form
    {
        public Task4()
        {
            InitializeComponent();
        }

        private void btnCalculatePercen_Click(object sender, EventArgs e)
        {
            double n= double.Parse(txtNumber.Text);
            double P = double.Parse(txtPercent.Text);

            double R = (n* P) / 100;

            txtResult.Text = R.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
