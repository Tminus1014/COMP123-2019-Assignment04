using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// 
/// Program Title: BMI Calculator
/// Author: Trent B Minia tm-
/// Author Student #: 301041132
/// Date last modified: 2019-07-26
/// 
/// Description: This windows form app calculates a user's BMI given their height 
///              and weight input values. The BMI calculation is returned and is
///              described based on the BMI scale.
///              
/// Revision History:
///  * 2019-07-17: Basic UI completed
///  * 2019-07-21: Added some basic functionality
///  * 2019-07-22: Added proper calculation functionality
///                Added more functionality:
///                 - Added code that allows change of units between metric and 
///                   imperial
///                 - Added proper descriptions for the BMI result
///                 - Changed/fixed name for BMIResultMultiLineTextBox
///                 - Changed input and result type from int to double for decimal 
///                   functionality
///                 - Adjusted reset functionality
///                Added a functional splash screen and an about form
///                 - About form shows author details and BMI scale
///  * 2019-07-23: Added colours on the calculator form and adjusted colours on 
///                   the about form
///                Made major design changes with the splash screen to make it 
///                   look prettier
///  * 2019-07-24: Re-worked the app menu strip as demonstrated in COMP123-2019-Lesson11
///                 - As part of the menu strip re-work, the About form was renamed
///                   to BMI Scale and its main purpose is to show the BMI scale. 
///                   The form only shows the BMI scale.
///                 - The main menu strip now shows a single item titled, "Help," 
///                   and the form to view the BMI scale can be accessed there
///  * 2019-07-26: Added internal documentation
///                Adjusted the size BMI Scale form so it's the same size as the main
///                   form.
///                   
/// More detailed revision history notes can be seen on the GitHub Repository under commits.
/// 
/// </summary>
namespace BMICalculator {
    static class Program {
        // Form fields
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

            // Instantiate the forms
            bmiCalculator = new BMICalculator();
            bmiScaleForm = new BMIScale();
            splashScreen = new SplashScreen();

            // Run the application; start at splash screen
            Application.Run(splashScreen);
        }
    }
}
