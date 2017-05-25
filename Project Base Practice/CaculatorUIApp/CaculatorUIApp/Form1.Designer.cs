namespace CaculatorUIApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.firstNumberTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.secondNumberTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.additionButton = new System.Windows.Forms.Button();
            this.substractionButton = new System.Windows.Forms.Button();
            this.divitionButton = new System.Windows.Forms.Button();
            this.multiplyButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Number";
            // 
            // firstNumberTextBox
            // 
            this.firstNumberTextBox.Location = new System.Drawing.Point(207, 25);
            this.firstNumberTextBox.Name = "firstNumberTextBox";
            this.firstNumberTextBox.Size = new System.Drawing.Size(172, 31);
            this.firstNumberTextBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Second  Number";
            // 
            // secondNumberTextBox
            // 
            this.secondNumberTextBox.Location = new System.Drawing.Point(207, 62);
            this.secondNumberTextBox.Name = "secondNumberTextBox";
            this.secondNumberTextBox.Size = new System.Drawing.Size(172, 31);
            this.secondNumberTextBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 99);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Result";
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(207, 99);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(172, 31);
            this.resultTextBox.TabIndex = 2;
            // 
            // additionButton
            // 
            this.additionButton.Location = new System.Drawing.Point(31, 159);
            this.additionButton.Name = "additionButton";
            this.additionButton.Size = new System.Drawing.Size(167, 37);
            this.additionButton.TabIndex = 3;
            this.additionButton.Text = "Addition";
            this.additionButton.UseVisualStyleBackColor = true;
            this.additionButton.Click += new System.EventHandler(this.additionButton_Click);
            // 
            // substractionButton
            // 
            this.substractionButton.Location = new System.Drawing.Point(207, 159);
            this.substractionButton.Name = "substractionButton";
            this.substractionButton.Size = new System.Drawing.Size(172, 37);
            this.substractionButton.TabIndex = 4;
            this.substractionButton.Text = "Substraction";
            this.substractionButton.UseVisualStyleBackColor = true;
            this.substractionButton.Click += new System.EventHandler(this.substractionButton_Click);
            // 
            // divitionButton
            // 
            this.divitionButton.Location = new System.Drawing.Point(207, 202);
            this.divitionButton.Name = "divitionButton";
            this.divitionButton.Size = new System.Drawing.Size(172, 37);
            this.divitionButton.TabIndex = 6;
            this.divitionButton.Text = "Divition";
            this.divitionButton.UseVisualStyleBackColor = true;
            this.divitionButton.Click += new System.EventHandler(this.divitionButton_Click);
            // 
            // multiplyButton
            // 
            this.multiplyButton.Location = new System.Drawing.Point(31, 202);
            this.multiplyButton.Name = "multiplyButton";
            this.multiplyButton.Size = new System.Drawing.Size(167, 37);
            this.multiplyButton.TabIndex = 5;
            this.multiplyButton.Text = "Multiplay";
            this.multiplyButton.UseVisualStyleBackColor = true;
            this.multiplyButton.Click += new System.EventHandler(this.multiplyButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.resetButton.Location = new System.Drawing.Point(31, 245);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(348, 43);
            this.resetButton.TabIndex = 7;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // CalculatorUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 308);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.multiplyButton);
            this.Controls.Add(this.divitionButton);
            this.Controls.Add(this.substractionButton);
            this.Controls.Add(this.additionButton);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.secondNumberTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.firstNumberTextBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "CalculatorUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caculator ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox firstNumberTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox secondNumberTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Button additionButton;
        private System.Windows.Forms.Button substractionButton;
        private System.Windows.Forms.Button divitionButton;
        private System.Windows.Forms.Button multiplyButton;
        private System.Windows.Forms.Button resetButton;
    }
}

