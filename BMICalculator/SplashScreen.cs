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
    public partial class SplashScreen : Form {
        public SplashScreen() {
            InitializeComponent();
        }

        private void SplashScreen_Load(object sender, EventArgs e) {
            SplashScreenTimer.Enabled = true;
        }

        private void SplashScreenTimer_Tick(object sender, EventArgs e) {
            SplashScreenTimer.Enabled = false;
            Program.splashScreen.Hide();
            Program.bmiCalculator.Show();
        }
    }
}
