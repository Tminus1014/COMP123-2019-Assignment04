namespace BMICalculator {
    partial class BMIScale {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BMIScale));
            this.BMIScaleTitleLabel = new System.Windows.Forms.Label();
            this.CloseBMIScaleButton = new System.Windows.Forms.Button();
            this.BMIScaleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BMIScaleTitleLabel
            // 
            this.BMIScaleTitleLabel.AutoSize = true;
            this.BMIScaleTitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(105)))), ((int)(((byte)(147)))));
            this.BMIScaleTitleLabel.Location = new System.Drawing.Point(13, 13);
            this.BMIScaleTitleLabel.Name = "BMIScaleTitleLabel";
            this.BMIScaleTitleLabel.Size = new System.Drawing.Size(161, 43);
            this.BMIScaleTitleLabel.TabIndex = 0;
            this.BMIScaleTitleLabel.Text = "BMI Scale";
            // 
            // CloseBMIScaleButton
            // 
            this.CloseBMIScaleButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.CloseBMIScaleButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CloseBMIScaleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseBMIScaleButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(22)))));
            this.CloseBMIScaleButton.Location = new System.Drawing.Point(149, 318);
            this.CloseBMIScaleButton.Name = "CloseBMIScaleButton";
            this.CloseBMIScaleButton.Size = new System.Drawing.Size(139, 38);
            this.CloseBMIScaleButton.TabIndex = 4;
            this.CloseBMIScaleButton.Text = "Close";
            this.CloseBMIScaleButton.UseVisualStyleBackColor = false;
            this.CloseBMIScaleButton.Click += new System.EventHandler(this.CloseBMIScaleButton_Click);
            // 
            // BMIScaleLabel
            // 
            this.BMIScaleLabel.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BMIScaleLabel.ForeColor = System.Drawing.Color.White;
            this.BMIScaleLabel.Location = new System.Drawing.Point(16, 55);
            this.BMIScaleLabel.Name = "BMIScaleLabel";
            this.BMIScaleLabel.Size = new System.Drawing.Size(272, 258);
            this.BMIScaleLabel.TabIndex = 5;
            this.BMIScaleLabel.Text = resources.GetString("BMIScaleLabel.Text");
            this.BMIScaleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BMIScale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 42F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(300, 368);
            this.ControlBox = false;
            this.Controls.Add(this.BMIScaleLabel);
            this.Controls.Add(this.CloseBMIScaleButton);
            this.Controls.Add(this.BMIScaleTitleLabel);
            this.Font = new System.Drawing.Font("Trebuchet MS", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.Name = "BMIScale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Scale";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BMIScaleTitleLabel;
        private System.Windows.Forms.Button CloseBMIScaleButton;
        private System.Windows.Forms.Label BMIScaleLabel;
    }
}