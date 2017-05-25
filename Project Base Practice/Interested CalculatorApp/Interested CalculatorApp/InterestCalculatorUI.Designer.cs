namespace Interested_CalculatorApp
{
    partial class InterestCalculatorUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.bankNameComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timeYearTextBox = new System.Windows.Forms.TextBox();
            this.YourBalanceTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.calculateInterestButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.interestShowTextBox = new System.Windows.Forms.TextBox();
            this.resetButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bank Name";
            // 
            // bankNameComboBox
            // 
            this.bankNameComboBox.FormattingEnabled = true;
            this.bankNameComboBox.Items.AddRange(new object[] {
            "BRAC",
            "IBBL",
            "DBBL",
            "HSBC"});
            this.bankNameComboBox.Location = new System.Drawing.Point(196, 24);
            this.bankNameComboBox.Name = "bankNameComboBox";
            this.bankNameComboBox.Size = new System.Drawing.Size(184, 33);
            this.bankNameComboBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Time (In Year)";
            // 
            // timeYearTextBox
            // 
            this.timeYearTextBox.Location = new System.Drawing.Point(196, 96);
            this.timeYearTextBox.Name = "timeYearTextBox";
            this.timeYearTextBox.Size = new System.Drawing.Size(184, 31);
            this.timeYearTextBox.TabIndex = 3;
            // 
            // YourBalanceTextBox
            // 
            this.YourBalanceTextBox.Location = new System.Drawing.Point(196, 169);
            this.YourBalanceTextBox.Name = "YourBalanceTextBox";
            this.YourBalanceTextBox.Size = new System.Drawing.Size(184, 31);
            this.YourBalanceTextBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Your Balance";
            // 
            // calculateInterestButton
            // 
            this.calculateInterestButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.calculateInterestButton.Location = new System.Drawing.Point(25, 248);
            this.calculateInterestButton.Name = "calculateInterestButton";
            this.calculateInterestButton.Size = new System.Drawing.Size(355, 48);
            this.calculateInterestButton.TabIndex = 6;
            this.calculateInterestButton.Text = "Calculate Interest";
            this.calculateInterestButton.UseVisualStyleBackColor = false;
            this.calculateInterestButton.Click += new System.EventHandler(this.calculateInterestButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Interest = ";
            // 
            // interestShowTextBox
            // 
            this.interestShowTextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.interestShowTextBox.Location = new System.Drawing.Point(127, 296);
            this.interestShowTextBox.Name = "interestShowTextBox";
            this.interestShowTextBox.Size = new System.Drawing.Size(237, 31);
            this.interestShowTextBox.TabIndex = 8;
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(25, 344);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(355, 38);
            this.resetButton.TabIndex = 9;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.Red;
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.Color.White;
            this.cancelButton.Location = new System.Drawing.Point(25, 388);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(355, 38);
            this.cancelButton.TabIndex = 10;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // InterestCalculatorUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 437);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.interestShowTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.calculateInterestButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.YourBalanceTextBox);
            this.Controls.Add(this.timeYearTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bankNameComboBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "InterestCalculatorUI";
            this.Text = "Interest Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox bankNameComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox timeYearTextBox;
        private System.Windows.Forms.TextBox YourBalanceTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button calculateInterestButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox interestShowTextBox;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button cancelButton;
    }
}

