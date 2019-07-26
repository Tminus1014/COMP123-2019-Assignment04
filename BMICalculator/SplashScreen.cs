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
    /// The BMI calculator splash screen. This is run first upon application start.
    /// </summary>
    public partial class SplashScreen : Form {
        public SplashScreen() {
            InitializeComponent();
        }

        /// <summary>
        /// Enables the splash screen timer upon form load.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SplashScreen_Load(object sender, EventArgs e) {
            SplashScreenTimer.Enabled = true;
        }

        /// <summary>
        /// Hides the splash screen and shows the main form upon splash screen timer expiration.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SplashScreenTimer_Tick(object sender, EventArgs e) {
            SplashScreenTimer.Enabled = false;

            // Hide splash screen and show the calculator
            Program.splashScreen.Hide();
            Program.bmiCalculator.Show();
        }
    }
}
