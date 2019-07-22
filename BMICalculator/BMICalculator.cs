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
        private static double heightInput;
        private static double weightInput;
        private static double bmiResult;
        private static string unitsMode;

        public BMICalculator() {
            InitializeComponent();
        }

        private void BMICalculator_Load(object sender, EventArgs e) {
            // Default units to Metric
            MetricRadioBtn.Checked = true; changeUnitsMode();

            // Reset everything just to make sure the plate is clean :)
            resetAll();
        }

        private void HeightTextBox_TextChanged(object sender, EventArgs e) {
            verifyValidInput();
        }

        private void WeightTextBox_TextChanged(object sender, EventArgs e) {
            verifyValidInput();
        }

        private void CalculateBMIButton_Click(object sender, EventArgs e) {
            calculateBMI();
            disableCalculateButton();
            displayBMIResult();
            describeBMIResult();
        }

        private void ResetButton_Click(object sender, EventArgs e) {
            resetAll();
        }

        private void MetricRadioBtn_CheckedChanged(object sender, EventArgs e) {
            changeUnitsMode();
            resetAll();
        }

        private void ImperialRadioBtn_CheckedChanged(object sender, EventArgs e) {
            changeUnitsMode();
            resetAll();
        }

        private void calculateBMI() {
            if (unitsMode == "Metric") {
                bmiResult = weightInput / Math.Pow(heightInput, 2);
            } else if (unitsMode == "Imperial") {
                bmiResult = (weightInput * 703) / Math.Pow(heightInput, 2);
            }
        }

        private void displayBMIResult() {
            bmiResult = Math.Round(bmiResult, 1);
            BMIResultTextBox.Text = bmiResult.ToString();
        }

        private void describeBMIResult() {
            string description = "";

            // < 18.5: Overweight
            if (bmiResult < 18.5) {
                description = "be underweight";
            // >= 18.5 and <= 24.9: Normal
            } else if (bmiResult >= 18.5 && bmiResult <= 24.9) {
                description = "have normal weight";
            // >= 25 and <= 29.9: Overweight
            } else if (bmiResult >= 25 && bmiResult <= 29.9) {
                description = "be overweight";
            // >= 30: Obese
            } else if (bmiResult >= 30) {
                description = "be obese";
            }

            BMIResultMultiLineTextBox.Text = $"With a measurement of {heightInput}{HeightUnitLabel.Text} and {weightInput}{WeightUnitLabel.Text}, your calculated BMI is {bmiResult}, which means you are considered to {description}.";
        }

        private void verifyValidInput() {
            try {
                heightInput = Convert.ToDouble(HeightTextBox.Text);
                weightInput = Convert.ToDouble(WeightTextBox.Text);

                if (heightInput <= 0 || weightInput <= 0) {
                    disableCalculateButton();
                }
                else {
                    enableCalculateButton();
                }

            } catch {
                CalculateBMIButton.Enabled = false;
            }
        }

        private void enableCalculateButton() {
            CalculateBMIButton.Enabled = true;
        }

        private void disableCalculateButton() {
            CalculateBMIButton.Enabled = false;
        }

        private void changeUnitsMode() {
            if (MetricRadioBtn.Checked == true) {
                HeightUnitLabel.Text = "m";
                WeightUnitLabel.Text = "kg";
                unitsMode = "Metric";
            } else if (ImperialRadioBtn.Checked == true) {
                HeightUnitLabel.Text = "inch";
                WeightUnitLabel.Text = "lbs";
                unitsMode = "Imperial";
            }
        }

        private void resetAll() {
            HeightTextBox.Text = "";
            WeightTextBox.Text = "";
            BMIResultTextBox.Text = "";
            BMIResultMultiLineTextBox.Text = "";
        }
    }
}
