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
    public partial class BMICalculator : Form {
        private int heightInput;
        private int weightInput;
        private int bmiResult;

        public BMICalculator() {
            InitializeComponent();
        }

        private void HeightTextBox_TextChanged(object sender, EventArgs e) {
            verifyValidInput();
        }

        private void WeightTextBox_TextChanged(object sender, EventArgs e) {
            verifyValidInput();
        }

        private void CalculateBMIButton_Click(object sender, EventArgs e) {
            calculateBMI();
            displayBMIResult();
            describeBMIResult();
        }

        private void ResetButton_Click(object sender, EventArgs e) {
            resetAll();
        }

        private void calculateBMI() {
            bmiResult = heightInput + weightInput;
        }

        private void displayBMIResult() {
            BMIResultTextBox.Text = bmiResult.ToString();
        }

        private void describeBMIResult() {
            string description = "";

            if (bmiResult >= 2) {
                description = "lul u fat";
            } else if (bmiResult < 2) {
                description = "lul u skinny";
            }

            BMIResultMultLineTextBox.Text = $"With a measurement of {heightInput}{HeightUnitLabel.Text} and {weightInput}{WeightUnitLabel.Text}, your calculated BMI is {bmiResult}, which means {description}.";
        }

        private void verifyValidInput() {
            try {
                heightInput = Convert.ToInt32(HeightTextBox.Text);
                weightInput = Convert.ToInt32(WeightTextBox.Text);

                if (heightInput <= 0 || weightInput <= 0) {
                    CalculateBMIButton.Enabled = false;
                } else {
                    CalculateBMIButton.Enabled = true;
                }

            } catch {
                CalculateBMIButton.Enabled = false;
            }
        }

        private void resetAll() {
            MetricRadioBtn.Checked = true;
            HeightTextBox.Text = "";
            WeightTextBox.Text = "";
            BMIResultTextBox.Text = "";
            BMIResultMultLineTextBox.Text = "";
        }
    }
}
