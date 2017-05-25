namespace NumberEntryUI
{
    partial class NumberEntryUI
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
            this.enterNumberTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.showAllButton = new System.Windows.Forms.Button();
            this.sumResultTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.showListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Number";
            // 
            // enterNumberTextBox
            // 
            this.enterNumberTextBox.Location = new System.Drawing.Point(198, 19);
            this.enterNumberTextBox.Name = "enterNumberTextBox";
            this.enterNumberTextBox.Size = new System.Drawing.Size(435, 31);
            this.enterNumberTextBox.TabIndex = 1;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(198, 67);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(209, 37);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // showAllButton
            // 
            this.showAllButton.Location = new System.Drawing.Point(424, 67);
            this.showAllButton.Name = "showAllButton";
            this.showAllButton.Size = new System.Drawing.Size(209, 37);
            this.showAllButton.TabIndex = 2;
            this.showAllButton.Text = "Show All";
            this.showAllButton.UseVisualStyleBackColor = true;
            this.showAllButton.Click += new System.EventHandler(this.showAllButton_Click);
            // 
            // sumResultTextBox
            // 
            this.sumResultTextBox.Location = new System.Drawing.Point(354, 339);
            this.sumResultTextBox.Name = "sumResultTextBox";
            this.sumResultTextBox.Size = new System.Drawing.Size(279, 31);
            this.sumResultTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 345);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sum Result";
            // 
            // showListBox
            // 
            this.showListBox.FormattingEnabled = true;
            this.showListBox.ItemHeight = 25;
            this.showListBox.Location = new System.Drawing.Point(54, 121);
            this.showListBox.Name = "showListBox";
            this.showListBox.Size = new System.Drawing.Size(579, 179);
            this.showListBox.TabIndex = 6;
            // 
            // NumberEntryUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 395);
            this.Controls.Add(this.showListBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sumResultTextBox);
            this.Controls.Add(this.showAllButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.enterNumberTextBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "NumberEntryUI";
            this.Text = "Number Entry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox enterNumberTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button showAllButton;
        private System.Windows.Forms.TextBox sumResultTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox showListBox;
    }
}

