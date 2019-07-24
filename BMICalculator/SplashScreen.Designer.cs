namespace BMICalculator {
    partial class SplashScreen {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.SplashScreenTitleLabel = new System.Windows.Forms.Label();
            this.SplashScreenDescriptionLabel = new System.Windows.Forms.Label();
            this.SplashScreenTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // SplashScreenTitleLabel
            // 
            this.SplashScreenTitleLabel.Font = new System.Drawing.Font("Trebuchet MS", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SplashScreenTitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(105)))), ((int)(((byte)(147)))));
            this.SplashScreenTitleLabel.Location = new System.Drawing.Point(11, 9);
            this.SplashScreenTitleLabel.Name = "SplashScreenTitleLabel";
            this.SplashScreenTitleLabel.Size = new System.Drawing.Size(597, 102);
            this.SplashScreenTitleLabel.TabIndex = 0;
            this.SplashScreenTitleLabel.Text = "BMI Calculator";
            // 
            // SplashScreenDescriptionLabel
            // 
            this.SplashScreenDescriptionLabel.AutoSize = true;
            this.SplashScreenDescriptionLabel.Font = new System.Drawing.Font("Trebuchet MS", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SplashScreenDescriptionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(182)))), ((int)(((byte)(182)))));
            this.SplashScreenDescriptionLabel.Location = new System.Drawing.Point(20, 111);
            this.SplashScreenDescriptionLabel.Name = "SplashScreenDescriptionLabel";
            this.SplashScreenDescriptionLabel.Size = new System.Drawing.Size(528, 86);
            this.SplashScreenDescriptionLabel.TabIndex = 3;
            this.SplashScreenDescriptionLabel.Text = "© 2019 - Trent B Minia - COMP123\r\nDesigned for Assignment 4.";
            // 
            // SplashScreenTimer
            // 
            this.SplashScreenTimer.Interval = 3000;
            this.SplashScreenTimer.Tick += new System.EventHandler(this.SplashScreenTimer_Tick);
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.ClientSize = new System.Drawing.Size(620, 300);
            this.ControlBox = false;
            this.Controls.Add(this.SplashScreenDescriptionLabel);
            this.Controls.Add(this.SplashScreenTitleLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(7);
            this.MaximizeBox = false;
            this.Name = "SplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashScreen";
            this.Load += new System.EventHandler(this.SplashScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SplashScreenTitleLabel;
        private System.Windows.Forms.Label SplashScreenDescriptionLabel;
        private System.Windows.Forms.Timer SplashScreenTimer;
    }
}