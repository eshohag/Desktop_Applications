namespace HelloWorldApp
{
    partial class MainUI
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
            this.showButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.foodComboBox = new System.Windows.Forms.ComboBox();
            this.displayButton = new System.Windows.Forms.Button();
            this.oddRadioButton = new System.Windows.Forms.RadioButton();
            this.evenRadioButton = new System.Windows.Forms.RadioButton();
            this.oddCheckBox = new System.Windows.Forms.CheckBox();
            this.evenCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(196, 48);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(75, 23);
            this.showButton.TabIndex = 1;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(88, 48);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(88, 22);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(183, 20);
            this.nameTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cancelButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.showButton);
            this.groupBox1.Controls.Add(this.nameTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 93);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // foodComboBox
            // 
            this.foodComboBox.FormattingEnabled = true;
            this.foodComboBox.Items.AddRange(new object[] {
            "Pizza",
            "Shwarma",
            "Burger",
            "Ice Cream",
            "Sandwich",
            "Cafe Mocha"});
            this.foodComboBox.Location = new System.Drawing.Point(342, 34);
            this.foodComboBox.Name = "foodComboBox";
            this.foodComboBox.Size = new System.Drawing.Size(213, 21);
            this.foodComboBox.TabIndex = 5;
            // 
            // displayButton
            // 
            this.displayButton.Location = new System.Drawing.Point(470, 178);
            this.displayButton.Name = "displayButton";
            this.displayButton.Size = new System.Drawing.Size(75, 23);
            this.displayButton.TabIndex = 6;
            this.displayButton.Text = "Display";
            this.displayButton.UseVisualStyleBackColor = true;
            this.displayButton.Click += new System.EventHandler(this.displayButton_Click);
            // 
            // oddRadioButton
            // 
            this.oddRadioButton.AutoSize = true;
            this.oddRadioButton.Location = new System.Drawing.Point(342, 77);
            this.oddRadioButton.Name = "oddRadioButton";
            this.oddRadioButton.Size = new System.Drawing.Size(45, 17);
            this.oddRadioButton.TabIndex = 7;
            this.oddRadioButton.TabStop = true;
            this.oddRadioButton.Text = "Odd";
            this.oddRadioButton.UseVisualStyleBackColor = true;
            // 
            // evenRadioButton
            // 
            this.evenRadioButton.AutoSize = true;
            this.evenRadioButton.Location = new System.Drawing.Point(470, 77);
            this.evenRadioButton.Name = "evenRadioButton";
            this.evenRadioButton.Size = new System.Drawing.Size(50, 17);
            this.evenRadioButton.TabIndex = 8;
            this.evenRadioButton.TabStop = true;
            this.evenRadioButton.Text = "Even";
            this.evenRadioButton.UseVisualStyleBackColor = true;
            // 
            // oddCheckBox
            // 
            this.oddCheckBox.AutoSize = true;
            this.oddCheckBox.Location = new System.Drawing.Point(342, 117);
            this.oddCheckBox.Name = "oddCheckBox";
            this.oddCheckBox.Size = new System.Drawing.Size(46, 17);
            this.oddCheckBox.TabIndex = 9;
            this.oddCheckBox.Text = "Odd";
            this.oddCheckBox.UseVisualStyleBackColor = true;
            // 
            // evenCheckBox
            // 
            this.evenCheckBox.AutoSize = true;
            this.evenCheckBox.Location = new System.Drawing.Point(465, 117);
            this.evenCheckBox.Name = "evenCheckBox";
            this.evenCheckBox.Size = new System.Drawing.Size(51, 17);
            this.evenCheckBox.TabIndex = 10;
            this.evenCheckBox.Text = "Even";
            this.evenCheckBox.UseVisualStyleBackColor = true;
            // 
            // MainUI
            // 
            this.AcceptButton = this.showButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 266);
            this.Controls.Add(this.evenCheckBox);
            this.Controls.Add(this.oddCheckBox);
            this.Controls.Add(this.evenRadioButton);
            this.Controls.Add(this.oddRadioButton);
            this.Controls.Add(this.displayButton);
            this.Controls.Add(this.foodComboBox);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox foodComboBox;
        private System.Windows.Forms.Button displayButton;
        private System.Windows.Forms.RadioButton oddRadioButton;
        private System.Windows.Forms.RadioButton evenRadioButton;
        private System.Windows.Forms.CheckBox oddCheckBox;
        private System.Windows.Forms.CheckBox evenCheckBox;
    }
}

