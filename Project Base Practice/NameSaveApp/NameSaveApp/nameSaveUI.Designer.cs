namespace NameSaveApp
{
    partial class nameSaveUI
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
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.showAllButton = new System.Windows.Forms.Button();
            this.showAllNameTextBox = new System.Windows.Forms.TextBox();
            this.totalNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Your Name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(213, 27);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(323, 31);
            this.nameTextBox.TabIndex = 1;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(213, 64);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(161, 36);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // showAllButton
            // 
            this.showAllButton.Location = new System.Drawing.Point(380, 64);
            this.showAllButton.Name = "showAllButton";
            this.showAllButton.Size = new System.Drawing.Size(156, 36);
            this.showAllButton.TabIndex = 2;
            this.showAllButton.Text = "Show All";
            this.showAllButton.UseVisualStyleBackColor = true;
            this.showAllButton.Click += new System.EventHandler(this.showAllButton_Click);
            // 
            // showAllNameTextBox
            // 
            this.showAllNameTextBox.Location = new System.Drawing.Point(29, 125);
            this.showAllNameTextBox.Multiline = true;
            this.showAllNameTextBox.Name = "showAllNameTextBox";
            this.showAllNameTextBox.Size = new System.Drawing.Size(507, 238);
            this.showAllNameTextBox.TabIndex = 3;
            // 
            // totalNameTextBox
            // 
            this.totalNameTextBox.Location = new System.Drawing.Point(213, 377);
            this.totalNameTextBox.Multiline = true;
            this.totalNameTextBox.Name = "totalNameTextBox";
            this.totalNameTextBox.Size = new System.Drawing.Size(323, 36);
            this.totalNameTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 380);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Total Name";
            // 
            // nameSaveUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 425);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.totalNameTextBox);
            this.Controls.Add(this.showAllNameTextBox);
            this.Controls.Add(this.showAllButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "nameSaveUI";
            this.Text = "Name Save";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button showAllButton;
        private System.Windows.Forms.TextBox showAllNameTextBox;
        private System.Windows.Forms.TextBox totalNameTextBox;
        private System.Windows.Forms.Label label2;
    }
}

