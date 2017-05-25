namespace AddNumberUI
{
    partial class AddNumberUI
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
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.Addbutton = new System.Windows.Forms.Button();
            this.showListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number";
            // 
            // numberTextBox
            // 
            this.numberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberTextBox.Location = new System.Drawing.Point(149, 13);
            this.numberTextBox.Multiline = true;
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(327, 28);
            this.numberTextBox.TabIndex = 1;
            // 
            // Addbutton
            // 
            this.Addbutton.BackColor = System.Drawing.Color.Maroon;
            this.Addbutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Addbutton.Location = new System.Drawing.Point(385, 47);
            this.Addbutton.Name = "Addbutton";
            this.Addbutton.Size = new System.Drawing.Size(91, 34);
            this.Addbutton.TabIndex = 3;
            this.Addbutton.Text = "Add";
            this.Addbutton.UseVisualStyleBackColor = false;
            this.Addbutton.Click += new System.EventHandler(this.Addbutton_Click);
            // 
            // showListBox
            // 
            this.showListBox.FormattingEnabled = true;
            this.showListBox.ItemHeight = 25;
            this.showListBox.Location = new System.Drawing.Point(35, 87);
            this.showListBox.Name = "showListBox";
            this.showListBox.Size = new System.Drawing.Size(441, 254);
            this.showListBox.TabIndex = 4;
            // 
            // AddNumberUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 368);
            this.Controls.Add(this.showListBox);
            this.Controls.Add(this.Addbutton);
            this.Controls.Add(this.numberTextBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "AddNumberUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Number Add";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.Button Addbutton;
        private System.Windows.Forms.ListBox showListBox;

    }
}

