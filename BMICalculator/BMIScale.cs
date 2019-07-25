using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMICalculator {
    public partial class BMIScale : Form {
        public BMIScale() {
            InitializeComponent();
        }

        private void CloseBMIScaleButton_Click(object sender, EventArgs e) {
            Program.bmiScaleForm.Hide();
        }
    }
}
