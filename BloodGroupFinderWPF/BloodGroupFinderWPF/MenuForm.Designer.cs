namespace BloodGroupFinderWPF
{
    partial class MenuForm
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
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.displayAllButton = new System.Windows.Forms.Button();
            this.SearchFormButton = new System.Windows.Forms.Button();
            this.donnerAddButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(195, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "Blood Group Finder Apps ";
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.displayAllButton);
            this.groupBox.Controls.Add(this.SearchFormButton);
            this.groupBox.Controls.Add(this.donnerAddButton);
            this.groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox.Location = new System.Drawing.Point(87, 70);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(511, 207);
            this.groupBox.TabIndex = 7;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Menu ";
            // 
            // displayAllButton
            // 
            this.displayAllButton.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayAllButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.displayAllButton.Location = new System.Drawing.Point(114, 130);
            this.displayAllButton.Name = "displayAllButton";
            this.displayAllButton.Size = new System.Drawing.Size(302, 38);
            this.displayAllButton.TabIndex = 2;
            this.displayAllButton.Text = "Display All";
            this.displayAllButton.UseVisualStyleBackColor = true;
            this.displayAllButton.Click += new System.EventHandler(this.displayAllButton_Click);
            // 
            // SearchFormButton
            // 
            this.SearchFormButton.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchFormButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SearchFormButton.Location = new System.Drawing.Point(114, 86);
            this.SearchFormButton.Name = "SearchFormButton";
            this.SearchFormButton.Size = new System.Drawing.Size(302, 38);
            this.SearchFormButton.TabIndex = 1;
            this.SearchFormButton.Text = "Search";
            this.SearchFormButton.UseVisualStyleBackColor = true;
            this.SearchFormButton.Click += new System.EventHandler(this.SearchFormButton_Click);
            // 
            // donnerAddButton
            // 
            this.donnerAddButton.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.donnerAddButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.donnerAddButton.Location = new System.Drawing.Point(114, 42);
            this.donnerAddButton.Name = "donnerAddButton";
            this.donnerAddButton.Size = new System.Drawing.Size(302, 38);
            this.donnerAddButton.TabIndex = 0;
            this.donnerAddButton.Text = "Blood Donner Add";
            this.donnerAddButton.UseVisualStyleBackColor = true;
            this.donnerAddButton.Click += new System.EventHandler(this.donnerAddButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(312, 287);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 8;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(696, 322);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.label1);
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Form";
            this.groupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Button displayAllButton;
        private System.Windows.Forms.Button SearchFormButton;
        private System.Windows.Forms.Button donnerAddButton;
        private System.Windows.Forms.Button backButton;
    }
}