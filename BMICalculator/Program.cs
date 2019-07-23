using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMICalculator {
    static class Program {
        public static BMICalculator bmiCalculator;
        public static SplashScreen splashScreen;
        public static AboutForm aboutForm;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            bmiCalculator = new BMICalculator();
            aboutForm = new AboutForm();
            splashScreen = new SplashScreen();

            Application.Run(splashScreen);
        }
    }
}
