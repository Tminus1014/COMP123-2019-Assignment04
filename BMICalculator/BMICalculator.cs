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
    /// <summary>
    /// BMI Calculator main form. All user inputs are made and all calculations are shown here.
    /// </summary>
    public partial class BMICalculator : Form {
        private static double _heightInput;
        private static double _weightInput;
        private static double _bmiResult;
        private static string _unitsMode;

        public BMICalculator() {
            InitializeComponent();
        }

        /* ------------ */
        /* -= Events =- */
        /* ------------ */

        /// <summary>
        /// Actions to be performed upon main form load.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BMICalculator_Load(object sender, EventArgs e) {
            // Default units to Metric
            MetricRadioBtn.Checked = true; changeUnitsMode();

            // Reset everything just to make sure the plate is clean :)
            resetAll();
        }

        /// <summary>
        /// Properly handles application exit after closing the form via the exit button at the top.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BMICalculator_FormClosed(object sender, FormClosedEventArgs e) {
            Application.Exit();
        }
        /// <summary>
        /// Opens the BMI Scale form upon clicking the tool strip menu item.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ContentsToolStripMenuItem_Click(object sender, EventArgs e) {
            Program.bmiScaleForm.Show();
        }

        /// <summary>
        /// Automatically validate the height user input once text has been added/removed in the textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HeightTextBox_TextChanged(object sender, EventArgs e) {
            validateInput();
        }

        /// <summary>
        /// Automatically validate the weight user input once text has been added/removed in the textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WeightTextBox_TextChanged(object sender, EventArgs e) {
            validateInput();
        }

        /// <summary>
        /// Disables the calculate button, and then calculates, displays, and describes the BMI result upon clicking the calculate button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalculateBMIButton_Click(object sender, EventArgs e) {
            disableCalculateButton();
            calculateBMI();
            displayBMIResult();
            describeBMIResult();
        }

        /// <summary>
        /// Runs the resetAll() method upon clicking reset button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ResetButton_Click(object sender, EventArgs e) {
            resetAll();
        }

        /// <summary>
        /// Changes the input and calculation units to metric while running the resetAll() method to ensure a clean state.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MetricRadioBtn_CheckedChanged(object sender, EventArgs e) {
            changeUnitsMode();
            resetAll();
        }

        /// <summary>
        /// Changes the input and calculation units to imperial while running the resetAll() method to ensure a clean state.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImperialRadioBtn_CheckedChanged(object sender, EventArgs e) {
            changeUnitsMode();
            resetAll();
        }

        /* ------------- */
        /* -= Methods =- */
        /* ------------- */

        /// <summary>
        /// Calculates the BMI given user input height and weight.
        /// </summary>
        private void calculateBMI() {
            if (_unitsMode == "Metric") {
                _bmiResult = _weightInput / Math.Pow(_heightInput, 2);
            } else if (_unitsMode == "Imperial") {
                _bmiResult = (_weightInput * 703) / Math.Pow(_heightInput, 2);
            }
        }

        /// <summary>
        /// Displays the BMI result.
        /// </summary>
        private void displayBMIResult() {
            _bmiResult = Math.Round(_bmiResult, 1);
            BMIResultTextBox.Text = _bmiResult.ToString();
        }

        /// <summary>
        /// Describes the BMI result according to the BMI scale.
        /// </summary>
        private void describeBMIResult() {
            string description = "";

            // Scale statement based on BMI result

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

            // Describe BMI statement
            BMIResultMultiLineTextBox.Text = $"With a measurement of {_heightInput} {HeightUnitLabel.Text} and {_weightInput} {WeightUnitLabel.Text}, your calculated BMI is {_bmiResult}, which means you are considered to {description}.";
        }

        /// <summary>
        /// Validates user input to ensure everything can be calculated without any errors.
        /// </summary>
        private void validateInput() {
            try {
                _heightInput = Convert.ToDouble(HeightTextBox.Text);
                _weightInput = Convert.ToDouble(WeightTextBox.Text);

                // Further validation to ensure none of the inputs are below 0
                if (_heightInput <= 0 || _weightInput <= 0) {
                    disableCalculateButton();
                }
                else {
                    enableCalculateButton();
                }

            } catch { // There is invalid input in one of the textboxes -gasp-
                CalculateBMIButton.Enabled = false;
            }
        }
        /// <summary>
        /// Enables the calculate button.
        /// </summary>
        private void enableCalculateButton() {
            CalculateBMIButton.Enabled = true;
        }

        /// <summary>
        /// Disables the calculate button.
        /// </summary>
        private void disableCalculateButton() {
            CalculateBMIButton.Enabled = false;
        }

        /// <summary>
        /// Changes the units based on user selection.
        /// </summary>
        private void changeUnitsMode() {
            // Metric selected
            if (MetricRadioBtn.Checked == true) {
                HeightUnitLabel.Text = "m";
                WeightUnitLabel.Text = "kg";
                _unitsMode = "Metric";

            // Imperial selected
            } else if (ImperialRadioBtn.Checked == true) {
                HeightUnitLabel.Text = "inch.";
                WeightUnitLabel.Text = "lbs";
                _unitsMode = "Imperial";
            }
        }

        /// <summary>
        /// Resets the form by clearing the following: HeightTextBox input, WeightTextBox input, BMIResultTextBox output, BMIResultMultiLineTextBox output.
        /// </summary>
        private void resetAll() {
            HeightTextBox.Text = "";
            WeightTextBox.Text = "";
            BMIResultTextBox.Text = "";
            BMIResultMultiLineTextBox.Text = "";
        }
    }
}
