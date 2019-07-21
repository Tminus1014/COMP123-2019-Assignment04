namespace BMICalculator {
    partial class BMICalculator {
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
            this.SetUnitsTableLayout_sub = new System.Windows.Forms.TableLayoutPanel();
            this.ImperialRadioBtn = new System.Windows.Forms.RadioButton();
            this.MetricRadioBtn = new System.Windows.Forms.RadioButton();
            this.UserInputLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.MyWeightLabel = new System.Windows.Forms.Label();
            this.HeightTextBox = new System.Windows.Forms.TextBox();
            this.WeightTextBox = new System.Windows.Forms.TextBox();
            this.WeightUnitLabel = new System.Windows.Forms.Label();
            this.MyHeightLabel = new System.Windows.Forms.Label();
            this.HeightUnitLabel = new System.Windows.Forms.Label();
            this.CalculateBMIButton = new System.Windows.Forms.Button();
            this.ResultsLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ResultsLayoutPanel_sub = new System.Windows.Forms.TableLayoutPanel();
            this.BMIResultLabel = new System.Windows.Forms.Label();
            this.BMIResultTextBox = new System.Windows.Forms.TextBox();
            this.BMIResultMultLineTextBox = new System.Windows.Forms.TextBox();
            this.ResetButton = new System.Windows.Forms.Button();
            this.SetUnitsGroupBox = new System.Windows.Forms.GroupBox();
            this.SetUnitsTableLayout_sub.SuspendLayout();
            this.UserInputLayoutPanel.SuspendLayout();
            this.ResultsLayoutPanel.SuspendLayout();
            this.ResultsLayoutPanel_sub.SuspendLayout();
            this.SetUnitsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SetUnitsTableLayout_sub
            // 
            this.SetUnitsTableLayout_sub.ColumnCount = 2;
            this.SetUnitsTableLayout_sub.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.SetUnitsTableLayout_sub.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.SetUnitsTableLayout_sub.Controls.Add(this.ImperialRadioBtn, 0, 0);
            this.SetUnitsTableLayout_sub.Controls.Add(this.MetricRadioBtn, 1, 0);
            this.SetUnitsTableLayout_sub.Location = new System.Drawing.Point(0, 35);
            this.SetUnitsTableLayout_sub.Name = "SetUnitsTableLayout_sub";
            this.SetUnitsTableLayout_sub.RowCount = 1;
            this.SetUnitsTableLayout_sub.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SetUnitsTableLayout_sub.Size = new System.Drawing.Size(282, 33);
            this.SetUnitsTableLayout_sub.TabIndex = 0;
            // 
            // ImperialRadioBtn
            // 
            this.ImperialRadioBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ImperialRadioBtn.AutoSize = true;
            this.ImperialRadioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImperialRadioBtn.Location = new System.Drawing.Point(3, 3);
            this.ImperialRadioBtn.Name = "ImperialRadioBtn";
            this.ImperialRadioBtn.Size = new System.Drawing.Size(101, 27);
            this.ImperialRadioBtn.TabIndex = 0;
            this.ImperialRadioBtn.TabStop = true;
            this.ImperialRadioBtn.Text = "Imperial";
            this.ImperialRadioBtn.UseVisualStyleBackColor = true;
            // 
            // MetricRadioBtn
            // 
            this.MetricRadioBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.MetricRadioBtn.AutoSize = true;
            this.MetricRadioBtn.Checked = true;
            this.MetricRadioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MetricRadioBtn.Location = new System.Drawing.Point(144, 3);
            this.MetricRadioBtn.Name = "MetricRadioBtn";
            this.MetricRadioBtn.Size = new System.Drawing.Size(86, 27);
            this.MetricRadioBtn.TabIndex = 0;
            this.MetricRadioBtn.TabStop = true;
            this.MetricRadioBtn.Text = "Metric";
            this.MetricRadioBtn.UseVisualStyleBackColor = true;
            // 
            // UserInputLayoutPanel
            // 
            this.UserInputLayoutPanel.ColumnCount = 3;
            this.UserInputLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.98655F));
            this.UserInputLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.01345F));
            this.UserInputLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.UserInputLayoutPanel.Controls.Add(this.MyWeightLabel, 0, 1);
            this.UserInputLayoutPanel.Controls.Add(this.HeightTextBox, 1, 0);
            this.UserInputLayoutPanel.Controls.Add(this.WeightTextBox, 1, 1);
            this.UserInputLayoutPanel.Controls.Add(this.WeightUnitLabel, 2, 1);
            this.UserInputLayoutPanel.Controls.Add(this.MyHeightLabel, 0, 0);
            this.UserInputLayoutPanel.Controls.Add(this.HeightUnitLabel, 2, 0);
            this.UserInputLayoutPanel.Location = new System.Drawing.Point(12, 92);
            this.UserInputLayoutPanel.Name = "UserInputLayoutPanel";
            this.UserInputLayoutPanel.RowCount = 2;
            this.UserInputLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.UserInputLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.UserInputLayoutPanel.Size = new System.Drawing.Size(281, 71);
            this.UserInputLayoutPanel.TabIndex = 2;
            // 
            // MyWeightLabel
            // 
            this.MyWeightLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.MyWeightLabel.AutoSize = true;
            this.MyWeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyWeightLabel.Location = new System.Drawing.Point(22, 40);
            this.MyWeightLabel.Name = "MyWeightLabel";
            this.MyWeightLabel.Size = new System.Drawing.Size(112, 25);
            this.MyWeightLabel.TabIndex = 0;
            this.MyWeightLabel.Text = "My Weight:";
            this.MyWeightLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // HeightTextBox
            // 
            this.HeightTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.HeightTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeightTextBox.Location = new System.Drawing.Point(140, 3);
            this.HeightTextBox.Name = "HeightTextBox";
            this.HeightTextBox.Size = new System.Drawing.Size(82, 30);
            this.HeightTextBox.TabIndex = 1;
            // 
            // WeightTextBox
            // 
            this.WeightTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.WeightTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeightTextBox.Location = new System.Drawing.Point(140, 38);
            this.WeightTextBox.Name = "WeightTextBox";
            this.WeightTextBox.Size = new System.Drawing.Size(82, 30);
            this.WeightTextBox.TabIndex = 1;
            // 
            // WeightUnitLabel
            // 
            this.WeightUnitLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.WeightUnitLabel.AutoSize = true;
            this.WeightUnitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeightUnitLabel.Location = new System.Drawing.Point(228, 40);
            this.WeightUnitLabel.Name = "WeightUnitLabel";
            this.WeightUnitLabel.Size = new System.Drawing.Size(33, 25);
            this.WeightUnitLabel.TabIndex = 0;
            this.WeightUnitLabel.Text = "kg";
            // 
            // MyHeightLabel
            // 
            this.MyHeightLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.MyHeightLabel.AutoSize = true;
            this.MyHeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyHeightLabel.Location = new System.Drawing.Point(28, 5);
            this.MyHeightLabel.Name = "MyHeightLabel";
            this.MyHeightLabel.Size = new System.Drawing.Size(106, 25);
            this.MyHeightLabel.TabIndex = 0;
            this.MyHeightLabel.Text = "My Height:";
            this.MyHeightLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // HeightUnitLabel
            // 
            this.HeightUnitLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.HeightUnitLabel.AutoSize = true;
            this.HeightUnitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeightUnitLabel.Location = new System.Drawing.Point(228, 5);
            this.HeightUnitLabel.Name = "HeightUnitLabel";
            this.HeightUnitLabel.Size = new System.Drawing.Size(28, 25);
            this.HeightUnitLabel.TabIndex = 0;
            this.HeightUnitLabel.Text = "m";
            // 
            // CalculateBMIButton
            // 
            this.CalculateBMIButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateBMIButton.Location = new System.Drawing.Point(12, 169);
            this.CalculateBMIButton.Name = "CalculateBMIButton";
            this.CalculateBMIButton.Size = new System.Drawing.Size(281, 38);
            this.CalculateBMIButton.TabIndex = 3;
            this.CalculateBMIButton.Text = "Calculate BMI";
            this.CalculateBMIButton.UseVisualStyleBackColor = true;
            // 
            // ResultsLayoutPanel
            // 
            this.ResultsLayoutPanel.ColumnCount = 1;
            this.ResultsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ResultsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ResultsLayoutPanel.Controls.Add(this.ResultsLayoutPanel_sub, 0, 0);
            this.ResultsLayoutPanel.Controls.Add(this.BMIResultMultLineTextBox, 0, 1);
            this.ResultsLayoutPanel.Location = new System.Drawing.Point(12, 213);
            this.ResultsLayoutPanel.Name = "ResultsLayoutPanel";
            this.ResultsLayoutPanel.RowCount = 2;
            this.ResultsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.36364F));
            this.ResultsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.63636F));
            this.ResultsLayoutPanel.Size = new System.Drawing.Size(281, 164);
            this.ResultsLayoutPanel.TabIndex = 4;
            // 
            // ResultsLayoutPanel_sub
            // 
            this.ResultsLayoutPanel_sub.ColumnCount = 2;
            this.ResultsLayoutPanel_sub.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.02974F));
            this.ResultsLayoutPanel_sub.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.97026F));
            this.ResultsLayoutPanel_sub.Controls.Add(this.BMIResultLabel, 0, 0);
            this.ResultsLayoutPanel_sub.Controls.Add(this.BMIResultTextBox, 1, 0);
            this.ResultsLayoutPanel_sub.Location = new System.Drawing.Point(3, 3);
            this.ResultsLayoutPanel_sub.Name = "ResultsLayoutPanel_sub";
            this.ResultsLayoutPanel_sub.RowCount = 1;
            this.ResultsLayoutPanel_sub.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ResultsLayoutPanel_sub.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.ResultsLayoutPanel_sub.Size = new System.Drawing.Size(275, 53);
            this.ResultsLayoutPanel_sub.TabIndex = 0;
            // 
            // BMIResultLabel
            // 
            this.BMIResultLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BMIResultLabel.AutoSize = true;
            this.BMIResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BMIResultLabel.Location = new System.Drawing.Point(66, 14);
            this.BMIResultLabel.Name = "BMIResultLabel";
            this.BMIResultLabel.Size = new System.Drawing.Size(118, 25);
            this.BMIResultLabel.TabIndex = 0;
            this.BMIResultLabel.Text = "Your BMI is:";
            this.BMIResultLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // BMIResultTextBox
            // 
            this.BMIResultTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BMIResultTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BMIResultTextBox.Location = new System.Drawing.Point(190, 11);
            this.BMIResultTextBox.Name = "BMIResultTextBox";
            this.BMIResultTextBox.Size = new System.Drawing.Size(81, 30);
            this.BMIResultTextBox.TabIndex = 1;
            // 
            // BMIResultMultLineTextBox
            // 
            this.BMIResultMultLineTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BMIResultMultLineTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BMIResultMultLineTextBox.Location = new System.Drawing.Point(3, 62);
            this.BMIResultMultLineTextBox.Multiline = true;
            this.BMIResultMultLineTextBox.Name = "BMIResultMultLineTextBox";
            this.BMIResultMultLineTextBox.Size = new System.Drawing.Size(275, 99);
            this.BMIResultMultLineTextBox.TabIndex = 1;
            // 
            // ResetButton
            // 
            this.ResetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetButton.Location = new System.Drawing.Point(155, 383);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(139, 38);
            this.ResetButton.TabIndex = 3;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            // 
            // SetUnitsGroupBox
            // 
            this.SetUnitsGroupBox.Controls.Add(this.SetUnitsTableLayout_sub);
            this.SetUnitsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetUnitsGroupBox.Location = new System.Drawing.Point(12, 12);
            this.SetUnitsGroupBox.Name = "SetUnitsGroupBox";
            this.SetUnitsGroupBox.Size = new System.Drawing.Size(282, 74);
            this.SetUnitsGroupBox.TabIndex = 5;
            this.SetUnitsGroupBox.TabStop = false;
            this.SetUnitsGroupBox.Text = "Set Units";
            // 
            // BMICalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 433);
            this.Controls.Add(this.SetUnitsGroupBox);
            this.Controls.Add(this.ResultsLayoutPanel);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.CalculateBMIButton);
            this.Controls.Add(this.UserInputLayoutPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(7);
            this.MaximizeBox = false;
            this.Name = "BMICalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator";
            this.SetUnitsTableLayout_sub.ResumeLayout(false);
            this.SetUnitsTableLayout_sub.PerformLayout();
            this.UserInputLayoutPanel.ResumeLayout(false);
            this.UserInputLayoutPanel.PerformLayout();
            this.ResultsLayoutPanel.ResumeLayout(false);
            this.ResultsLayoutPanel.PerformLayout();
            this.ResultsLayoutPanel_sub.ResumeLayout(false);
            this.ResultsLayoutPanel_sub.PerformLayout();
            this.SetUnitsGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel SetUnitsTableLayout_sub;
        private System.Windows.Forms.RadioButton ImperialRadioBtn;
        private System.Windows.Forms.RadioButton MetricRadioBtn;
        private System.Windows.Forms.TableLayoutPanel UserInputLayoutPanel;
        private System.Windows.Forms.Label MyHeightLabel;
        private System.Windows.Forms.Label HeightUnitLabel;
        private System.Windows.Forms.Label MyWeightLabel;
        private System.Windows.Forms.TextBox HeightTextBox;
        private System.Windows.Forms.TextBox WeightTextBox;
        private System.Windows.Forms.Label WeightUnitLabel;
        private System.Windows.Forms.Button CalculateBMIButton;
        private System.Windows.Forms.TableLayoutPanel ResultsLayoutPanel;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.TableLayoutPanel ResultsLayoutPanel_sub;
        private System.Windows.Forms.Label BMIResultLabel;
        private System.Windows.Forms.TextBox BMIResultTextBox;
        private System.Windows.Forms.TextBox BMIResultMultLineTextBox;
        private System.Windows.Forms.GroupBox SetUnitsGroupBox;
    }
}

