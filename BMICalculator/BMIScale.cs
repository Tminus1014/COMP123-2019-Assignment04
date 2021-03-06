﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMICalculator {
    /// <summary>
    /// Shows the BMI scale for users.
    /// </summary>
    public partial class BMIScale : Form {
        public BMIScale() {
            InitializeComponent();
        }

        /// <summary>
        /// Closes the BMI Scale form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseBMIScaleButton_Click(object sender, EventArgs e) {
            Program.bmiScaleForm.Hide();
        }
    }
}
