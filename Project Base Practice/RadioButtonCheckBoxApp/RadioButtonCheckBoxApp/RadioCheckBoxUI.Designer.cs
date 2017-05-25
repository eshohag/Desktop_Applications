namespace RadioButtonCheckBoxApp
{
    partial class RadioCheckBoxUI
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.showAnsRadioButton = new System.Windows.Forms.Button();
            this.noRadioButton = new System.Windows.Forms.RadioButton();
            this.yesRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.showAnsCheckBoxButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.noCheckBox = new System.Windows.Forms.CheckBox();
            this.yesCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.showAnsRadioButton);
            this.groupBox1.Controls.Add(this.noRadioButton);
            this.groupBox1.Controls.Add(this.yesRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 160);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Radio Button";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Confirm Your Identity?";
            // 
            // showAnsRadioButton
            // 
            this.showAnsRadioButton.Location = new System.Drawing.Point(102, 106);
            this.showAnsRadioButton.Name = "showAnsRadioButton";
            this.showAnsRadioButton.Size = new System.Drawing.Size(208, 41);
            this.showAnsRadioButton.TabIndex = 4;
            this.showAnsRadioButton.Text = "Show Your Ans";
            this.showAnsRadioButton.UseVisualStyleBackColor = true;
            this.showAnsRadioButton.Click += new System.EventHandler(this.showAnsRadioButton_Click);
            // 
            // noRadioButton
            // 
            this.noRadioButton.AutoSize = true;
            this.noRadioButton.Location = new System.Drawing.Point(277, 70);
            this.noRadioButton.Name = "noRadioButton";
            this.noRadioButton.Size = new System.Drawing.Size(57, 30);
            this.noRadioButton.TabIndex = 1;
            this.noRadioButton.Text = "No";
            this.noRadioButton.UseVisualStyleBackColor = true;
            // 
            // yesRadioButton
            // 
            this.yesRadioButton.AutoSize = true;
            this.yesRadioButton.Location = new System.Drawing.Point(113, 70);
            this.yesRadioButton.Name = "yesRadioButton";
            this.yesRadioButton.Size = new System.Drawing.Size(59, 30);
            this.yesRadioButton.TabIndex = 0;
            this.yesRadioButton.Text = "Yes";
            this.yesRadioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.showAnsCheckBoxButton);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.noCheckBox);
            this.groupBox2.Controls.Add(this.yesCheckBox);
            this.groupBox2.Location = new System.Drawing.Point(13, 179);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(386, 161);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Checkbox";
            // 
            // showAnsCheckBoxButton
            // 
            this.showAnsCheckBoxButton.Location = new System.Drawing.Point(102, 114);
            this.showAnsCheckBoxButton.Name = "showAnsCheckBoxButton";
            this.showAnsCheckBoxButton.Size = new System.Drawing.Size(208, 41);
            this.showAnsCheckBoxButton.TabIndex = 3;
            this.showAnsCheckBoxButton.Text = "Show Your Ans";
            this.showAnsCheckBoxButton.UseVisualStyleBackColor = true;
            this.showAnsCheckBoxButton.Click += new System.EventHandler(this.showAnsCheckBoxButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Are You 18+ years old?";
            // 
            // noCheckBox
            // 
            this.noCheckBox.AutoSize = true;
            this.noCheckBox.Location = new System.Drawing.Point(287, 77);
            this.noCheckBox.Name = "noCheckBox";
            this.noCheckBox.Size = new System.Drawing.Size(58, 30);
            this.noCheckBox.TabIndex = 1;
            this.noCheckBox.Text = "No";
            this.noCheckBox.UseVisualStyleBackColor = true;
            // 
            // yesCheckBox
            // 
            this.yesCheckBox.AutoSize = true;
            this.yesCheckBox.Location = new System.Drawing.Point(97, 77);
            this.yesCheckBox.Name = "yesCheckBox";
            this.yesCheckBox.Size = new System.Drawing.Size(60, 30);
            this.yesCheckBox.TabIndex = 0;
            this.yesCheckBox.Text = "Yes";
            this.yesCheckBox.UseVisualStyleBackColor = true;
            // 
            // RadioCheckBoxUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 356);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "RadioCheckBoxUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Radio & Check Box";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox yesCheckBox;
        private System.Windows.Forms.CheckBox noCheckBox;
        private System.Windows.Forms.Button showAnsRadioButton;
        private System.Windows.Forms.RadioButton noRadioButton;
        private System.Windows.Forms.RadioButton yesRadioButton;
        private System.Windows.Forms.Button showAnsCheckBoxButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

