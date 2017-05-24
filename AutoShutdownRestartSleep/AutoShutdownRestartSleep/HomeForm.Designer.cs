namespace AutoShutdownRestartSleep
{
    partial class HomeForm
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
            this.comboBox_Option = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_stopProgram = new System.Windows.Forms.Button();
            this.cmb_Hours = new System.Windows.Forms.ComboBox();
            this.cmb_Minites = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox_Option
            // 
            this.comboBox_Option.BackColor = System.Drawing.Color.DarkSlateGray;
            this.comboBox_Option.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox_Option.ForeColor = System.Drawing.Color.White;
            this.comboBox_Option.FormattingEnabled = true;
            this.comboBox_Option.Items.AddRange(new object[] {
            "--Select Your Mode if you want--",
            "Shutdown",
            "Restart",
            "Sleep"});
            this.comboBox_Option.Location = new System.Drawing.Point(18, 28);
            this.comboBox_Option.Name = "comboBox_Option";
            this.comboBox_Option.Size = new System.Drawing.Size(312, 30);
            this.comboBox_Option.TabIndex = 0;
            this.comboBox_Option.TextChanged += new System.EventHandler(this.comboBox_Option_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmb_Minites);
            this.groupBox1.Controls.Add(this.cmb_Hours);
            this.groupBox1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(31, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 78);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Timer Setting";
            // 
            // btn_stopProgram
            // 
            this.btn_stopProgram.BackColor = System.Drawing.Color.Lavender;
            this.btn_stopProgram.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_stopProgram.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_stopProgram.Location = new System.Drawing.Point(124, 37);
            this.btn_stopProgram.Name = "btn_stopProgram";
            this.btn_stopProgram.Size = new System.Drawing.Size(100, 36);
            this.btn_stopProgram.TabIndex = 4;
            this.btn_stopProgram.Text = "Pause";
            this.btn_stopProgram.UseVisualStyleBackColor = false;
            // 
            // cmb_Hours
            // 
            this.cmb_Hours.FormattingEnabled = true;
            this.cmb_Hours.Items.AddRange(new object[] {
            "Select Hours"});
            this.cmb_Hours.Location = new System.Drawing.Point(28, 28);
            this.cmb_Hours.Name = "cmb_Hours";
            this.cmb_Hours.Size = new System.Drawing.Size(148, 30);
            this.cmb_Hours.TabIndex = 5;
            // 
            // cmb_Minites
            // 
            this.cmb_Minites.FormattingEnabled = true;
            this.cmb_Minites.Items.AddRange(new object[] {
            "Select Minutes"});
            this.cmb_Minites.Location = new System.Drawing.Point(182, 28);
            this.cmb_Minites.Name = "cmb_Minites";
            this.cmb_Minites.Size = new System.Drawing.Size(148, 30);
            this.cmb_Minites.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox_Option);
            this.groupBox2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(31, 108);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(345, 79);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Action Setting";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.btn_stopProgram);
            this.groupBox3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox3.Location = new System.Drawing.Point(31, 194);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(345, 91);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Excution Setting";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lavender;
            this.button1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(18, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 36);
            this.button1.TabIndex = 5;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Lavender;
            this.button2.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(230, 37);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 36);
            this.button2.TabIndex = 7;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkMagenta;
            this.ClientSize = new System.Drawing.Size(403, 316);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auto Shutdown, Restart, Sleep after your time limit";
            this.Load += new System.EventHandler(this.HomeForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_Option;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_stopProgram;
        private System.Windows.Forms.ComboBox cmb_Minites;
        private System.Windows.Forms.ComboBox cmb_Hours;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

