namespace BMICalculator {
    partial class AboutForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.AboutTitleLabel = new System.Windows.Forms.Label();
            this.AboutAuthorLabel = new System.Windows.Forms.Label();
            this.AboutDescriptionLabel = new System.Windows.Forms.Label();
            this.BMIScaleGroupBox = new System.Windows.Forms.GroupBox();
            this.BMIScaleLabel = new System.Windows.Forms.Label();
            this.CloseAboutButton = new System.Windows.Forms.Button();
            this.BMIScaleGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // AboutTitleLabel
            // 
            this.AboutTitleLabel.AutoSize = true;
            this.AboutTitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(105)))), ((int)(((byte)(147)))));
            this.AboutTitleLabel.Location = new System.Drawing.Point(13, 13);
            this.AboutTitleLabel.Name = "AboutTitleLabel";
            this.AboutTitleLabel.Size = new System.Drawing.Size(231, 42);
            this.AboutTitleLabel.TabIndex = 0;
            this.AboutTitleLabel.Text = "BMI Calculator";
            // 
            // AboutAuthorLabel
            // 
            this.AboutAuthorLabel.AutoSize = true;
            this.AboutAuthorLabel.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutAuthorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(182)))), ((int)(((byte)(182)))));
            this.AboutAuthorLabel.Location = new System.Drawing.Point(17, 56);
            this.AboutAuthorLabel.Name = "AboutAuthorLabel";
            this.AboutAuthorLabel.Size = new System.Drawing.Size(239, 20);
            this.AboutAuthorLabel.TabIndex = 1;
            this.AboutAuthorLabel.Text = "© 2019 - Trent B Minia - COMP123";
            // 
            // AboutDescriptionLabel
            // 
            this.AboutDescriptionLabel.AutoSize = true;
            this.AboutDescriptionLabel.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutDescriptionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(182)))), ((int)(((byte)(182)))));
            this.AboutDescriptionLabel.Location = new System.Drawing.Point(17, 76);
            this.AboutDescriptionLabel.Name = "AboutDescriptionLabel";
            this.AboutDescriptionLabel.Size = new System.Drawing.Size(192, 20);
            this.AboutDescriptionLabel.TabIndex = 1;
            this.AboutDescriptionLabel.Text = "Designed for Assignment 4.";
            // 
            // BMIScaleGroupBox
            // 
            this.BMIScaleGroupBox.Controls.Add(this.BMIScaleLabel);
            this.BMIScaleGroupBox.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BMIScaleGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(182)))), ((int)(((byte)(182)))));
            this.BMIScaleGroupBox.Location = new System.Drawing.Point(21, 99);
            this.BMIScaleGroupBox.Name = "BMIScaleGroupBox";
            this.BMIScaleGroupBox.Size = new System.Drawing.Size(261, 241);
            this.BMIScaleGroupBox.TabIndex = 2;
            this.BMIScaleGroupBox.TabStop = false;
            this.BMIScaleGroupBox.Text = "BMI Scale";
            // 
            // BMIScaleLabel
            // 
            this.BMIScaleLabel.ForeColor = System.Drawing.Color.White;
            this.BMIScaleLabel.Location = new System.Drawing.Point(7, 25);
            this.BMIScaleLabel.Name = "BMIScaleLabel";
            this.BMIScaleLabel.Size = new System.Drawing.Size(248, 213);
            this.BMIScaleLabel.TabIndex = 0;
            this.BMIScaleLabel.Text = resources.GetString("BMIScaleLabel.Text");
            // 
            // CloseAboutButton
            // 
            this.CloseAboutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.CloseAboutButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CloseAboutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseAboutButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(22)))));
            this.CloseAboutButton.Location = new System.Drawing.Point(149, 346);
            this.CloseAboutButton.Name = "CloseAboutButton";
            this.CloseAboutButton.Size = new System.Drawing.Size(139, 38);
            this.CloseAboutButton.TabIndex = 4;
            this.CloseAboutButton.Text = "Close";
            this.CloseAboutButton.UseVisualStyleBackColor = false;
            this.CloseAboutButton.Click += new System.EventHandler(this.CloseAboutButton_Click);
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 42F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(300, 393);
            this.ControlBox = false;
            this.Controls.Add(this.CloseAboutButton);
            this.Controls.Add(this.BMIScaleGroupBox);
            this.Controls.Add(this.AboutDescriptionLabel);
            this.Controls.Add(this.AboutAuthorLabel);
            this.Controls.Add(this.AboutTitleLabel);
            this.Font = new System.Drawing.Font("Trebuchet MS", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.Name = "AboutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator - About";
            this.BMIScaleGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AboutTitleLabel;
        private System.Windows.Forms.Label AboutAuthorLabel;
        private System.Windows.Forms.Label AboutDescriptionLabel;
        private System.Windows.Forms.GroupBox BMIScaleGroupBox;
        private System.Windows.Forms.Button CloseAboutButton;
        private System.Windows.Forms.Label BMIScaleLabel;
    }
}