namespace MyCalculator
{
    partial class CalculatorUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculatorUI));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonExp = new System.Windows.Forms.Button();
            this.dividedButton = new System.Windows.Forms.Button();
            this.multiplyButton = new System.Windows.Forms.Button();
            this.minusButton = new System.Windows.Forms.Button();
            this.operatorButton = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.persentButton = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.expButton = new System.Windows.Forms.Button();
            this.pointButton = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.displayTextBox = new System.Windows.Forms.TextBox();
            this.equationLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.buttonExp);
            this.groupBox1.Controls.Add(this.dividedButton);
            this.groupBox1.Controls.Add(this.multiplyButton);
            this.groupBox1.Controls.Add(this.minusButton);
            this.groupBox1.Controls.Add(this.operatorButton);
            this.groupBox1.Controls.Add(this.button11);
            this.groupBox1.Controls.Add(this.clearButton);
            this.groupBox1.Controls.Add(this.persentButton);
            this.groupBox1.Controls.Add(this.button10);
            this.groupBox1.Controls.Add(this.expButton);
            this.groupBox1.Controls.Add(this.pointButton);
            this.groupBox1.Controls.Add(this.button0);
            this.groupBox1.Controls.Add(this.button9);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button8);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.displayTextBox);
            this.groupBox1.Controls.Add(this.equationLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 403);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calculator";
            // 
            // buttonExp
            // 
            this.buttonExp.BackColor = System.Drawing.SystemColors.GrayText;
            this.buttonExp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonExp.Location = new System.Drawing.Point(25, 346);
            this.buttonExp.Name = "buttonExp";
            this.buttonExp.Size = new System.Drawing.Size(75, 36);
            this.buttonExp.TabIndex = 2;
            this.buttonExp.Text = "EXP";
            this.buttonExp.UseVisualStyleBackColor = false;
            // 
            // dividedButton
            // 
            this.dividedButton.BackColor = System.Drawing.SystemColors.GrayText;
            this.dividedButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dividedButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dividedButton.Location = new System.Drawing.Point(106, 304);
            this.dividedButton.Name = "dividedButton";
            this.dividedButton.Size = new System.Drawing.Size(75, 36);
            this.dividedButton.TabIndex = 2;
            this.dividedButton.Text = "/";
            this.dividedButton.UseVisualStyleBackColor = false;
            this.dividedButton.Click += new System.EventHandler(this.operatorButton_Click);
            // 
            // multiplyButton
            // 
            this.multiplyButton.BackColor = System.Drawing.SystemColors.GrayText;
            this.multiplyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplyButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.multiplyButton.Location = new System.Drawing.Point(25, 304);
            this.multiplyButton.Name = "multiplyButton";
            this.multiplyButton.Size = new System.Drawing.Size(75, 36);
            this.multiplyButton.TabIndex = 2;
            this.multiplyButton.Text = "*";
            this.multiplyButton.UseVisualStyleBackColor = false;
            this.multiplyButton.Click += new System.EventHandler(this.operatorButton_Click);
            // 
            // minusButton
            // 
            this.minusButton.BackColor = System.Drawing.SystemColors.GrayText;
            this.minusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.minusButton.Location = new System.Drawing.Point(106, 262);
            this.minusButton.Name = "minusButton";
            this.minusButton.Size = new System.Drawing.Size(75, 36);
            this.minusButton.TabIndex = 2;
            this.minusButton.Text = "-";
            this.minusButton.UseVisualStyleBackColor = false;
            this.minusButton.Click += new System.EventHandler(this.operatorButton_Click);
            // 
            // operatorButton
            // 
            this.operatorButton.BackColor = System.Drawing.SystemColors.GrayText;
            this.operatorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operatorButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.operatorButton.Location = new System.Drawing.Point(25, 262);
            this.operatorButton.Name = "operatorButton";
            this.operatorButton.Size = new System.Drawing.Size(75, 36);
            this.operatorButton.TabIndex = 2;
            this.operatorButton.Text = "+";
            this.operatorButton.UseVisualStyleBackColor = false;
            this.operatorButton.Click += new System.EventHandler(this.operatorButton_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.SystemColors.GrayText;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button11.Location = new System.Drawing.Point(187, 303);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 36);
            this.button11.TabIndex = 2;
            this.button11.Text = "C";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.buttonC_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.SystemColors.GrayText;
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.clearButton.Location = new System.Drawing.Point(187, 261);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 36);
            this.clearButton.TabIndex = 2;
            this.clearButton.Text = "CE";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // persentButton
            // 
            this.persentButton.BackColor = System.Drawing.SystemColors.GrayText;
            this.persentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.persentButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.persentButton.Location = new System.Drawing.Point(187, 219);
            this.persentButton.Name = "persentButton";
            this.persentButton.Size = new System.Drawing.Size(75, 36);
            this.persentButton.TabIndex = 2;
            this.persentButton.Text = "%";
            this.persentButton.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.SystemColors.GrayText;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button10.Location = new System.Drawing.Point(106, 346);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(156, 36);
            this.button10.TabIndex = 2;
            this.button10.Text = "=";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.equalButton_Click);
            // 
            // expButton
            // 
            this.expButton.BackColor = System.Drawing.SystemColors.GrayText;
            this.expButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.expButton.Location = new System.Drawing.Point(25, 346);
            this.expButton.Name = "expButton";
            this.expButton.Size = new System.Drawing.Size(75, 36);
            this.expButton.TabIndex = 2;
            this.expButton.Text = "EXP";
            this.expButton.UseVisualStyleBackColor = false;
            // 
            // pointButton
            // 
            this.pointButton.BackColor = System.Drawing.SystemColors.GrayText;
            this.pointButton.Font = new System.Drawing.Font("Wide Latin", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pointButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pointButton.Location = new System.Drawing.Point(106, 220);
            this.pointButton.Name = "pointButton";
            this.pointButton.Size = new System.Drawing.Size(75, 36);
            this.pointButton.TabIndex = 2;
            this.pointButton.Text = ".";
            this.pointButton.UseVisualStyleBackColor = false;
            // 
            // button0
            // 
            this.button0.BackColor = System.Drawing.SystemColors.GrayText;
            this.button0.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button0.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button0.Location = new System.Drawing.Point(25, 220);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(75, 36);
            this.button0.TabIndex = 2;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = false;
            this.button0.Click += new System.EventHandler(this.button_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.GrayText;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button9.Location = new System.Drawing.Point(187, 178);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 36);
            this.button9.TabIndex = 2;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.GrayText;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button6.Location = new System.Drawing.Point(187, 136);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 36);
            this.button6.TabIndex = 2;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.GrayText;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button8.Location = new System.Drawing.Point(106, 178);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 36);
            this.button8.TabIndex = 2;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.GrayText;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(187, 94);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 36);
            this.button3.TabIndex = 2;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.GrayText;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button7.Location = new System.Drawing.Point(25, 178);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 36);
            this.button7.TabIndex = 2;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.GrayText;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Location = new System.Drawing.Point(106, 136);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 36);
            this.button5.TabIndex = 2;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.GrayText;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(25, 136);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 36);
            this.button4.TabIndex = 2;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GrayText;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(106, 94);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 36);
            this.button2.TabIndex = 2;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GrayText;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(25, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button_Click);
            // 
            // displayTextBox
            // 
            this.displayTextBox.Location = new System.Drawing.Point(6, 57);
            this.displayTextBox.Name = "displayTextBox";
            this.displayTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.displayTextBox.Size = new System.Drawing.Size(275, 31);
            this.displayTextBox.TabIndex = 1;
            this.displayTextBox.Text = "0";
            // 
            // equationLabel
            // 
            this.equationLabel.AutoSize = true;
            this.equationLabel.Location = new System.Drawing.Point(111, 29);
            this.equationLabel.Name = "equationLabel";
            this.equationLabel.Size = new System.Drawing.Size(0, 25);
            this.equationLabel.TabIndex = 0;
            // 
            // CalculatorUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(311, 424);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CalculatorUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonExp;
        private System.Windows.Forms.Button dividedButton;
        private System.Windows.Forms.Button multiplyButton;
        private System.Windows.Forms.Button minusButton;
        private System.Windows.Forms.Button operatorButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button persentButton;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button expButton;
        private System.Windows.Forms.Button pointButton;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox displayTextBox;
        private System.Windows.Forms.Label equationLabel;
        private System.Windows.Forms.Button button11;
    }
}

