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
        private static double _heightInput;
        private static double _weightInput;
        private static double _bmiResult;
        private static string _unitsMode;

        public BMICalculator() {
            InitializeComponent();
        }

        private void BMICalculator_Load(object sender, EventArgs e) {
            // Default units to Metric
            MetricRadioBtn.Checked = true; changeUnitsMode();

            // Reset everything just to make sure the plate is clean :)
            resetAll();
        }

        private void BMICalculator_FormClosed(object sender, FormClosedEventArgs e) {
            Application.Exit();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e) {
            Program.aboutForm.Show();
        }

        private void HeightTextBox_TextChanged(object sender, EventArgs e) {
            validateValidInput();
        }

        private void WeightTextBox_TextChanged(object sender, EventArgs e) {
            validateValidInput();
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
            if (_unitsMode == "Metric") {
                _bmiResult = _weightInput / Math.Pow(_heightInput, 2);
            } else if (_unitsMode == "Imperial") {
                _bmiResult = (_weightInput * 703) / Math.Pow(_heightInput, 2);
            }
        }

        private void displayBMIResult() {
            _bmiResult = Math.Round(_bmiResult, 1);
            BMIResultTextBox.Text = _bmiResult.ToString();
        }

        private void describeBMIResult() {
            string description = "";

            // < 18.5: Overweight
            if (_bmiResult < 18.5) {
                description = "be underweight";
            // >= 18.5 and <= 24.9: Normal
            } else if (_bmiResult >= 18.5 && _bmiResult <= 24.9) {
                description = "have normal weight";
            // >= 25 and <= 29.9: Overweight
            } else if (_bmiResult >= 25 && _bmiResult <= 29.9) {
                description = "be overweight";
            // >= 30: Obese
            } else if (_bmiResult >= 30) {
                description = "be obese";
            }

            BMIResultMultiLineTextBox.Text = $"With a measurement of {_heightInput} {HeightUnitLabel.Text} and {_weightInput} {WeightUnitLabel.Text}, your calculated BMI is {_bmiResult}, which means you are considered to {description}.";
        }

        private void validateValidInput() {
            try {
                _heightInput = Convert.ToDouble(HeightTextBox.Text);
                _weightInput = Convert.ToDouble(WeightTextBox.Text);

                if (_heightInput <= 0 || _weightInput <= 0) {
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
                _unitsMode = "Metric";
            } else if (ImperialRadioBtn.Checked == true) {
                HeightUnitLabel.Text = "inch.";
                WeightUnitLabel.Text = "lbs";
                _unitsMode = "Imperial";
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
