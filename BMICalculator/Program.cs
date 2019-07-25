using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMICalculator {
    static class Program {
        public static BMICalculator bmiCalculator;
        public static SplashScreen splashScreen;
        public static BMIScale bmiScaleForm;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            bmiCalculator = new BMICalculator();
            bmiScaleForm = new BMIScale();
            splashScreen = new SplashScreen();

            Application.Run(splashScreen);
        }
    }
}
