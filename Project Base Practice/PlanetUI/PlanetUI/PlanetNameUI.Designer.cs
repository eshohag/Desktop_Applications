namespace PlanetUI
{
    partial class PlanetNameUI
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
            this.planetNameComboBoxText = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.showPlanetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // planetNameComboBoxText
            // 
            this.planetNameComboBoxText.FormattingEnabled = true;
            this.planetNameComboBoxText.Items.AddRange(new object[] {
            "March",
            "Earth ",
            "Moon ",
            "Maron",
            "Shohag"});
            this.planetNameComboBoxText.Location = new System.Drawing.Point(151, 15);
            this.planetNameComboBoxText.Margin = new System.Windows.Forms.Padding(6);
            this.planetNameComboBoxText.Name = "planetNameComboBoxText";
            this.planetNameComboBoxText.Size = new System.Drawing.Size(219, 32);
            this.planetNameComboBoxText.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Planet Name";
            // 
            // showPlanetButton
            // 
            this.showPlanetButton.Location = new System.Drawing.Point(28, 93);
            this.showPlanetButton.Name = "showPlanetButton";
            this.showPlanetButton.Size = new System.Drawing.Size(342, 39);
            this.showPlanetButton.TabIndex = 2;
            this.showPlanetButton.Text = "Show Planet Your Choice";
            this.showPlanetButton.UseVisualStyleBackColor = true;
            this.showPlanetButton.Click += new System.EventHandler(this.showPlanetButton_Click);
            // 
            // PlanetNameUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 190);
            this.Controls.Add(this.showPlanetButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.planetNameComboBoxText);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "PlanetNameUI";
            this.Text = "Planet Name";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox planetNameComboBoxText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button showPlanetButton;
    }
}

