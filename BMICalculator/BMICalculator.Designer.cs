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
            this.SetUnitsTableLayout = new System.Windows.Forms.TableLayoutPanel();
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
            this.BMIResultMultiLineTextBox = new System.Windows.Forms.TextBox();
            this.ResultsLayoutPanel_sub = new System.Windows.Forms.TableLayoutPanel();
            this.BMIResultLabel = new System.Windows.Forms.Label();
            this.BMIResultTextBox = new System.Windows.Forms.TextBox();
            this.ResetButton = new System.Windows.Forms.Button();
            this.SetUnitsGroupBox = new System.Windows.Forms.GroupBox();
            this.BMICalculatorMenuStrip = new System.Windows.Forms.MenuStrip();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SetUnitsTableLayout.SuspendLayout();
            this.UserInputLayoutPanel.SuspendLayout();
            this.ResultsLayoutPanel.SuspendLayout();
            this.ResultsLayoutPanel_sub.SuspendLayout();
            this.SetUnitsGroupBox.SuspendLayout();
            this.BMICalculatorMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // SetUnitsTableLayout
            // 
            this.SetUnitsTableLayout.ColumnCount = 2;
            this.SetUnitsTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.SetUnitsTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.SetUnitsTableLayout.Controls.Add(this.ImperialRadioBtn, 0, 0);
            this.SetUnitsTableLayout.Controls.Add(this.MetricRadioBtn, 1, 0);
            this.SetUnitsTableLayout.Location = new System.Drawing.Point(0, 29);
            this.SetUnitsTableLayout.Name = "SetUnitsTableLayout";
            this.SetUnitsTableLayout.RowCount = 1;
            this.SetUnitsTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SetUnitsTableLayout.Size = new System.Drawing.Size(282, 33);
            this.SetUnitsTableLayout.TabIndex = 0;
            // 
            // ImperialRadioBtn
            // 
            this.ImperialRadioBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ImperialRadioBtn.AutoSize = true;
            this.ImperialRadioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImperialRadioBtn.ForeColor = System.Drawing.Color.White;
            this.ImperialRadioBtn.Location = new System.Drawing.Point(3, 3);
            this.ImperialRadioBtn.Name = "ImperialRadioBtn";
            this.ImperialRadioBtn.Size = new System.Drawing.Size(101, 27);
            this.ImperialRadioBtn.TabIndex = 0;
            this.ImperialRadioBtn.TabStop = true;
            this.ImperialRadioBtn.Text = "Imperial";
            this.ImperialRadioBtn.UseVisualStyleBackColor = true;
            this.ImperialRadioBtn.CheckedChanged += new System.EventHandler(this.ImperialRadioBtn_CheckedChanged);
            // 
            // MetricRadioBtn
            // 
            this.MetricRadioBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.MetricRadioBtn.AutoSize = true;
            this.MetricRadioBtn.Checked = true;
            this.MetricRadioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MetricRadioBtn.ForeColor = System.Drawing.Color.White;
            this.MetricRadioBtn.Location = new System.Drawing.Point(144, 3);
            this.MetricRadioBtn.Name = "MetricRadioBtn";
            this.MetricRadioBtn.Size = new System.Drawing.Size(86, 27);
            this.MetricRadioBtn.TabIndex = 0;
            this.MetricRadioBtn.TabStop = true;
            this.MetricRadioBtn.Text = "Metric";
            this.MetricRadioBtn.UseVisualStyleBackColor = true;
            this.MetricRadioBtn.CheckedChanged += new System.EventHandler(this.MetricRadioBtn_CheckedChanged);
            // 
            // UserInputLayoutPanel
            // 
            this.UserInputLayoutPanel.ColumnCount = 3;
            this.UserInputLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.98655F));
            this.UserInputLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.01345F));
            this.UserInputLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.UserInputLayoutPanel.Controls.Add(this.MyWeightLabel, 0, 1);
            this.UserInputLayoutPanel.Controls.Add(this.HeightTextBox, 1, 0);
            this.UserInputLayoutPanel.Controls.Add(this.WeightTextBox, 1, 1);
            this.UserInputLayoutPanel.Controls.Add(this.WeightUnitLabel, 2, 1);
            this.UserInputLayoutPanel.Controls.Add(this.MyHeightLabel, 0, 0);
            this.UserInputLayoutPanel.Controls.Add(this.HeightUnitLabel, 2, 0);
            this.UserInputLayoutPanel.Location = new System.Drawing.Point(12, 110);
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
            this.MyWeightLabel.Location = new System.Drawing.Point(13, 40);
            this.MyWeightLabel.Name = "MyWeightLabel";
            this.MyWeightLabel.Size = new System.Drawing.Size(112, 25);
            this.MyWeightLabel.TabIndex = 0;
            this.MyWeightLabel.Text = "My Weight:";
            this.MyWeightLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // HeightTextBox
            // 
            this.HeightTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.HeightTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.HeightTextBox.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeightTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(235)))), ((int)(((byte)(21)))));
            this.HeightTextBox.Location = new System.Drawing.Point(131, 4);
            this.HeightTextBox.MaxLength = 5;
            this.HeightTextBox.Name = "HeightTextBox";
            this.HeightTextBox.Size = new System.Drawing.Size(76, 27);
            this.HeightTextBox.TabIndex = 1;
            this.HeightTextBox.TextChanged += new System.EventHandler(this.HeightTextBox_TextChanged);
            // 
            // WeightTextBox
            // 
            this.WeightTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.WeightTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.WeightTextBox.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeightTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(235)))), ((int)(((byte)(21)))));
            this.WeightTextBox.Location = new System.Drawing.Point(131, 39);
            this.WeightTextBox.MaxLength = 5;
            this.WeightTextBox.Name = "WeightTextBox";
            this.WeightTextBox.Size = new System.Drawing.Size(76, 27);
            this.WeightTextBox.TabIndex = 2;
            this.WeightTextBox.TextChanged += new System.EventHandler(this.WeightTextBox_TextChanged);
            // 
            // WeightUnitLabel
            // 
            this.WeightUnitLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.WeightUnitLabel.AutoSize = true;
            this.WeightUnitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeightUnitLabel.Location = new System.Drawing.Point(213, 40);
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
            this.MyHeightLabel.Location = new System.Drawing.Point(19, 5);
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
            this.HeightUnitLabel.Location = new System.Drawing.Point(213, 5);
            this.HeightUnitLabel.Name = "HeightUnitLabel";
            this.HeightUnitLabel.Size = new System.Drawing.Size(28, 25);
            this.HeightUnitLabel.TabIndex = 0;
            this.HeightUnitLabel.Text = "m";
            // 
            // CalculateBMIButton
            // 
            this.CalculateBMIButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.CalculateBMIButton.Enabled = false;
            this.CalculateBMIButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CalculateBMIButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateBMIButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(235)))), ((int)(((byte)(21)))));
            this.CalculateBMIButton.Location = new System.Drawing.Point(12, 187);
            this.CalculateBMIButton.Name = "CalculateBMIButton";
            this.CalculateBMIButton.Size = new System.Drawing.Size(281, 59);
            this.CalculateBMIButton.TabIndex = 5;
            this.CalculateBMIButton.Text = "Calculate BMI";
            this.CalculateBMIButton.UseVisualStyleBackColor = false;
            this.CalculateBMIButton.Click += new System.EventHandler(this.CalculateBMIButton_Click);
            // 
            // ResultsLayoutPanel
            // 
            this.ResultsLayoutPanel.ColumnCount = 1;
            this.ResultsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ResultsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ResultsLayoutPanel.Controls.Add(this.BMIResultMultiLineTextBox, 0, 1);
            this.ResultsLayoutPanel.Controls.Add(this.ResultsLayoutPanel_sub, 0, 0);
            this.ResultsLayoutPanel.Location = new System.Drawing.Point(12, 252);
            this.ResultsLayoutPanel.Name = "ResultsLayoutPanel";
            this.ResultsLayoutPanel.RowCount = 2;
            this.ResultsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.65734F));
            this.ResultsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.34266F));
            this.ResultsLayoutPanel.Size = new System.Drawing.Size(281, 125);
            this.ResultsLayoutPanel.TabIndex = 4;
            // 
            // BMIResultMultiLineTextBox
            // 
            this.BMIResultMultiLineTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BMIResultMultiLineTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.BMIResultMultiLineTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.BMIResultMultiLineTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BMIResultMultiLineTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(182)))), ((int)(((byte)(182)))));
            this.BMIResultMultiLineTextBox.Location = new System.Drawing.Point(3, 56);
            this.BMIResultMultiLineTextBox.Multiline = true;
            this.BMIResultMultiLineTextBox.Name = "BMIResultMultiLineTextBox";
            this.BMIResultMultiLineTextBox.ReadOnly = true;
            this.BMIResultMultiLineTextBox.Size = new System.Drawing.Size(275, 66);
            this.BMIResultMultiLineTextBox.TabIndex = 1;
            // 
            // ResultsLayoutPanel_sub
            // 
            this.ResultsLayoutPanel_sub.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ResultsLayoutPanel_sub.ColumnCount = 2;
            this.ResultsLayoutPanel_sub.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.02974F));
            this.ResultsLayoutPanel_sub.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.97026F));
            this.ResultsLayoutPanel_sub.Controls.Add(this.BMIResultLabel, 0, 0);
            this.ResultsLayoutPanel_sub.Controls.Add(this.BMIResultTextBox, 1, 0);
            this.ResultsLayoutPanel_sub.Location = new System.Drawing.Point(3, 3);
            this.ResultsLayoutPanel_sub.Name = "ResultsLayoutPanel_sub";
            this.ResultsLayoutPanel_sub.RowCount = 1;
            this.ResultsLayoutPanel_sub.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ResultsLayoutPanel_sub.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.ResultsLayoutPanel_sub.Size = new System.Drawing.Size(275, 47);
            this.ResultsLayoutPanel_sub.TabIndex = 0;
            // 
            // BMIResultLabel
            // 
            this.BMIResultLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BMIResultLabel.AutoSize = true;
            this.BMIResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BMIResultLabel.Location = new System.Drawing.Point(66, 11);
            this.BMIResultLabel.Name = "BMIResultLabel";
            this.BMIResultLabel.Size = new System.Drawing.Size(118, 25);
            this.BMIResultLabel.TabIndex = 0;
            this.BMIResultLabel.Text = "Your BMI is:";
            this.BMIResultLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // BMIResultTextBox
            // 
            this.BMIResultTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BMIResultTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.BMIResultTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.BMIResultTextBox.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BMIResultTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(235)))), ((int)(((byte)(21)))));
            this.BMIResultTextBox.Location = new System.Drawing.Point(190, 10);
            this.BMIResultTextBox.Name = "BMIResultTextBox";
            this.BMIResultTextBox.ReadOnly = true;
            this.BMIResultTextBox.Size = new System.Drawing.Size(81, 27);
            this.BMIResultTextBox.TabIndex = 1;
            this.BMIResultTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ResetButton
            // 
            this.ResetButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.ResetButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ResetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(22)))));
            this.ResetButton.Location = new System.Drawing.Point(155, 383);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(139, 38);
            this.ResetButton.TabIndex = 3;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = false;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // SetUnitsGroupBox
            // 
            this.SetUnitsGroupBox.Controls.Add(this.SetUnitsTableLayout);
            this.SetUnitsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetUnitsGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(182)))), ((int)(((byte)(182)))));
            this.SetUnitsGroupBox.Location = new System.Drawing.Point(12, 30);
            this.SetUnitsGroupBox.Name = "SetUnitsGroupBox";
            this.SetUnitsGroupBox.Size = new System.Drawing.Size(282, 74);
            this.SetUnitsGroupBox.TabIndex = 5;
            this.SetUnitsGroupBox.TabStop = false;
            this.SetUnitsGroupBox.Text = "Set Units";
            // 
            // BMICalculatorMenuStrip
            // 
            this.BMICalculatorMenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.BMICalculatorMenuStrip.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BMICalculatorMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.BMICalculatorMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutToolStripMenuItem});
            this.BMICalculatorMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.BMICalculatorMenuStrip.Name = "BMICalculatorMenuStrip";
            this.BMICalculatorMenuStrip.Size = new System.Drawing.Size(302, 28);
            this.BMICalculatorMenuStrip.TabIndex = 6;
            this.BMICalculatorMenuStrip.Text = "BMICalculatorMenuStrip";
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.AboutToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(182)))), ((int)(((byte)(182)))));
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.AboutToolStripMenuItem.Text = "&About";
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // BMICalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(302, 433);
            this.Controls.Add(this.SetUnitsGroupBox);
            this.Controls.Add(this.ResultsLayoutPanel);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.CalculateBMIButton);
            this.Controls.Add(this.UserInputLayoutPanel);
            this.Controls.Add(this.BMICalculatorMenuStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.BMICalculatorMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(7);
            this.MaximizeBox = false;
            this.Name = "BMICalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BMICalculator_FormClosed);
            this.Load += new System.EventHandler(this.BMICalculator_Load);
            this.SetUnitsTableLayout.ResumeLayout(false);
            this.SetUnitsTableLayout.PerformLayout();
            this.UserInputLayoutPanel.ResumeLayout(false);
            this.UserInputLayoutPanel.PerformLayout();
            this.ResultsLayoutPanel.ResumeLayout(false);
            this.ResultsLayoutPanel.PerformLayout();
            this.ResultsLayoutPanel_sub.ResumeLayout(false);
            this.ResultsLayoutPanel_sub.PerformLayout();
            this.SetUnitsGroupBox.ResumeLayout(false);
            this.BMICalculatorMenuStrip.ResumeLayout(false);
            this.BMICalculatorMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel SetUnitsTableLayout;
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
        private System.Windows.Forms.TextBox BMIResultMultiLineTextBox;
        private System.Windows.Forms.GroupBox SetUnitsGroupBox;
        private System.Windows.Forms.MenuStrip BMICalculatorMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
    }
}

