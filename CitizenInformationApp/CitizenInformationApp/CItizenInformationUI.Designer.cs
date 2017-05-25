namespace CitizenInformationApp
{
    partial class CItizenInformationUI
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
            this.showListBox = new System.Windows.Forms.ListBox();
            this.addButton = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nidTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.findShowListBox = new System.Windows.Forms.ListBox();
            this.findButton = new System.Windows.Forms.Button();
            this.findTextBox = new System.Windows.Forms.TextBox();
            this.nameRadioButton = new System.Windows.Forms.RadioButton();
            this.nidRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.showListBox);
            this.groupBox1.Controls.Add(this.addButton);
            this.groupBox1.Controls.Add(this.nameTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nidTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(24, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 461);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Citizen Info ";
            // 
            // showListBox
            // 
            this.showListBox.FormattingEnabled = true;
            this.showListBox.ItemHeight = 24;
            this.showListBox.Location = new System.Drawing.Point(14, 141);
            this.showListBox.Name = "showListBox";
            this.showListBox.Size = new System.Drawing.Size(311, 292);
            this.showListBox.TabIndex = 3;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.Olive;
            this.addButton.Font = new System.Drawing.Font("Castellar", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addButton.Location = new System.Drawing.Point(220, 100);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(105, 35);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(92, 65);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(233, 29);
            this.nameTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name";
            // 
            // nidTextBox
            // 
            this.nidTextBox.Location = new System.Drawing.Point(92, 30);
            this.nidTextBox.Name = "nidTextBox";
            this.nidTextBox.Size = new System.Drawing.Size(233, 29);
            this.nidTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "NID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.findShowListBox);
            this.groupBox2.Controls.Add(this.findButton);
            this.groupBox2.Controls.Add(this.findTextBox);
            this.groupBox2.Controls.Add(this.nameRadioButton);
            this.groupBox2.Controls.Add(this.nidRadioButton);
            this.groupBox2.Location = new System.Drawing.Point(390, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(347, 461);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Find Citizen Info";
            // 
            // findShowListBox
            // 
            this.findShowListBox.FormattingEnabled = true;
            this.findShowListBox.ItemHeight = 24;
            this.findShowListBox.Location = new System.Drawing.Point(18, 141);
            this.findShowListBox.Name = "findShowListBox";
            this.findShowListBox.Size = new System.Drawing.Size(311, 292);
            this.findShowListBox.TabIndex = 4;
            // 
            // findButton
            // 
            this.findButton.BackColor = System.Drawing.Color.Olive;
            this.findButton.Font = new System.Drawing.Font("Castellar", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.findButton.Location = new System.Drawing.Point(211, 100);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(105, 35);
            this.findButton.TabIndex = 3;
            this.findButton.Text = "Find";
            this.findButton.UseVisualStyleBackColor = false;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // findTextBox
            // 
            this.findTextBox.Location = new System.Drawing.Point(32, 63);
            this.findTextBox.Name = "findTextBox";
            this.findTextBox.Size = new System.Drawing.Size(284, 29);
            this.findTextBox.TabIndex = 2;
            // 
            // nameRadioButton
            // 
            this.nameRadioButton.AutoSize = true;
            this.nameRadioButton.Location = new System.Drawing.Point(189, 35);
            this.nameRadioButton.Name = "nameRadioButton";
            this.nameRadioButton.Size = new System.Drawing.Size(79, 28);
            this.nameRadioButton.TabIndex = 1;
            this.nameRadioButton.TabStop = true;
            this.nameRadioButton.Text = "Name";
            this.nameRadioButton.UseVisualStyleBackColor = true;
            // 
            // nidRadioButton
            // 
            this.nidRadioButton.AutoSize = true;
            this.nidRadioButton.Location = new System.Drawing.Point(32, 35);
            this.nidRadioButton.Name = "nidRadioButton";
            this.nidRadioButton.Size = new System.Drawing.Size(59, 28);
            this.nidRadioButton.TabIndex = 0;
            this.nidRadioButton.TabStop = true;
            this.nidRadioButton.Text = "NID";
            this.nidRadioButton.UseVisualStyleBackColor = true;
            // 
            // CItizenInformationUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(763, 496);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CItizenInformationUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Citizen Information Keeper";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox showListBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nidTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox findShowListBox;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.TextBox findTextBox;
        private System.Windows.Forms.RadioButton nameRadioButton;
        private System.Windows.Forms.RadioButton nidRadioButton;
    }
}

