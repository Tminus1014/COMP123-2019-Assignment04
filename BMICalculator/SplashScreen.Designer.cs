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
            this.SplashScreenAuthorLabel = new System.Windows.Forms.Label();
            this.SplashScreenTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // SplashScreenTitleLabel
            // 
            this.SplashScreenTitleLabel.AutoSize = true;
            this.SplashScreenTitleLabel.Font = new System.Drawing.Font("Trebuchet MS", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SplashScreenTitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(105)))), ((int)(((byte)(147)))));
            this.SplashScreenTitleLabel.Location = new System.Drawing.Point(11, 5);
            this.SplashScreenTitleLabel.Name = "SplashScreenTitleLabel";
            this.SplashScreenTitleLabel.Size = new System.Drawing.Size(237, 43);
            this.SplashScreenTitleLabel.TabIndex = 0;
            this.SplashScreenTitleLabel.Text = "BMI Calculator";
            this.SplashScreenTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SplashScreenDescriptionLabel
            // 
            this.SplashScreenDescriptionLabel.AutoSize = true;
            this.SplashScreenDescriptionLabel.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SplashScreenDescriptionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(182)))), ((int)(((byte)(182)))));
            this.SplashScreenDescriptionLabel.Location = new System.Drawing.Point(15, 68);
            this.SplashScreenDescriptionLabel.Name = "SplashScreenDescriptionLabel";
            this.SplashScreenDescriptionLabel.Size = new System.Drawing.Size(192, 20);
            this.SplashScreenDescriptionLabel.TabIndex = 2;
            this.SplashScreenDescriptionLabel.Text = "Designed for Assignment 4.";
            // 
            // SplashScreenAuthorLabel
            // 
            this.SplashScreenAuthorLabel.AutoSize = true;
            this.SplashScreenAuthorLabel.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SplashScreenAuthorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(182)))), ((int)(((byte)(182)))));
            this.SplashScreenAuthorLabel.Location = new System.Drawing.Point(15, 48);
            this.SplashScreenAuthorLabel.Name = "SplashScreenAuthorLabel";
            this.SplashScreenAuthorLabel.Size = new System.Drawing.Size(239, 20);
            this.SplashScreenAuthorLabel.TabIndex = 3;
            this.SplashScreenAuthorLabel.Text = "© 2019 - Trent B Minia - COMP123";
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
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(467, 361);
            this.ControlBox = false;
            this.Controls.Add(this.SplashScreenDescriptionLabel);
            this.Controls.Add(this.SplashScreenAuthorLabel);
            this.Controls.Add(this.SplashScreenTitleLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
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
        private System.Windows.Forms.Label SplashScreenAuthorLabel;
        private System.Windows.Forms.Timer SplashScreenTimer;
    }
}