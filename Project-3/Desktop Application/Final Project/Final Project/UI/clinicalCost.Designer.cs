namespace Final_Project
{
    partial class clinicalCost
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
            this.txt_description = new System.Windows.Forms.TextBox();
            this.lbl_clinicalActivity = new System.Windows.Forms.Label();
            this.txt_clinicalCost = new System.Windows.Forms.TextBox();
            this.lbl_clinicalCost = new System.Windows.Forms.Label();
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_patientId2 = new System.Windows.Forms.Label();
            this.gb_clinicalCost = new System.Windows.Forms.GroupBox();
            this.txt_patientId1 = new System.Windows.Forms.TextBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1_Description = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_patientIDu = new System.Windows.Forms.TextBox();
            this.textBox3_Cost = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button3_Update = new System.Windows.Forms.Button();
            this.gb_clinicalCost.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_description
            // 
            this.txt_description.Location = new System.Drawing.Point(164, 114);
            this.txt_description.Multiline = true;
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(329, 134);
            this.txt_description.TabIndex = 166;
            // 
            // lbl_clinicalActivity
            // 
            this.lbl_clinicalActivity.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_clinicalActivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_clinicalActivity.Location = new System.Drawing.Point(36, 114);
            this.lbl_clinicalActivity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_clinicalActivity.Name = "lbl_clinicalActivity";
            this.lbl_clinicalActivity.Size = new System.Drawing.Size(122, 46);
            this.lbl_clinicalActivity.TabIndex = 160;
            this.lbl_clinicalActivity.Text = "Description of\r\nClinical Activity";
            this.lbl_clinicalActivity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_clinicalCost
            // 
            this.txt_clinicalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_clinicalCost.Location = new System.Drawing.Point(166, 85);
            this.txt_clinicalCost.Margin = new System.Windows.Forms.Padding(4);
            this.txt_clinicalCost.Name = "txt_clinicalCost";
            this.txt_clinicalCost.Size = new System.Drawing.Size(327, 22);
            this.txt_clinicalCost.TabIndex = 162;
            // 
            // lbl_clinicalCost
            // 
            this.lbl_clinicalCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_clinicalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_clinicalCost.Location = new System.Drawing.Point(35, 85);
            this.lbl_clinicalCost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_clinicalCost.Name = "lbl_clinicalCost";
            this.lbl_clinicalCost.Size = new System.Drawing.Size(122, 22);
            this.lbl_clinicalCost.TabIndex = 159;
            this.lbl_clinicalCost.Text = "Clinical Cost";
            this.lbl_clinicalCost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_title
            // 
            this.lbl_title.BackColor = System.Drawing.Color.Lime;
            this.lbl_title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_title.Font = new System.Drawing.Font("Monotype Corsiva", 33.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(90, 39);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(1183, 80);
            this.lbl_title.TabIndex = 164;
            this.lbl_title.Tag = "";
            this.lbl_title.Text = "Clinical  Cost    /  Update  Clinical  Cost";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_patientId2
            // 
            this.lbl_patientId2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_patientId2.ForeColor = System.Drawing.Color.Black;
            this.lbl_patientId2.Location = new System.Drawing.Point(33, 51);
            this.lbl_patientId2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_patientId2.Name = "lbl_patientId2";
            this.lbl_patientId2.Size = new System.Drawing.Size(125, 26);
            this.lbl_patientId2.TabIndex = 5;
            this.lbl_patientId2.Text = "Patient ID";
            this.lbl_patientId2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gb_clinicalCost
            // 
            this.gb_clinicalCost.Controls.Add(this.txt_description);
            this.gb_clinicalCost.Controls.Add(this.lbl_patientId2);
            this.gb_clinicalCost.Controls.Add(this.lbl_clinicalActivity);
            this.gb_clinicalCost.Controls.Add(this.txt_patientId1);
            this.gb_clinicalCost.Controls.Add(this.txt_clinicalCost);
            this.gb_clinicalCost.Controls.Add(this.btn_back);
            this.gb_clinicalCost.Controls.Add(this.lbl_clinicalCost);
            this.gb_clinicalCost.Controls.Add(this.btn_add);
            this.gb_clinicalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_clinicalCost.ForeColor = System.Drawing.Color.Black;
            this.gb_clinicalCost.Location = new System.Drawing.Point(135, 151);
            this.gb_clinicalCost.Margin = new System.Windows.Forms.Padding(4);
            this.gb_clinicalCost.Name = "gb_clinicalCost";
            this.gb_clinicalCost.Padding = new System.Windows.Forms.Padding(4);
            this.gb_clinicalCost.Size = new System.Drawing.Size(523, 332);
            this.gb_clinicalCost.TabIndex = 167;
            this.gb_clinicalCost.TabStop = false;
            this.gb_clinicalCost.Text = "Add Clinical Cost";
            // 
            // txt_patientId1
            // 
            this.txt_patientId1.Location = new System.Drawing.Point(166, 49);
            this.txt_patientId1.Margin = new System.Windows.Forms.Padding(4);
            this.txt_patientId1.Name = "txt_patientId1";
            this.txt_patientId1.Size = new System.Drawing.Size(327, 26);
            this.txt_patientId1.TabIndex = 4;
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.Color.Black;
            this.btn_back.Location = new System.Drawing.Point(166, 255);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(143, 42);
            this.btn_back.TabIndex = 154;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click_1);
            // 
            // btn_add
            // 
            this.btn_add.ForeColor = System.Drawing.Color.Black;
            this.btn_add.Location = new System.Drawing.Point(339, 255);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(154, 42);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox1_Description);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_patientIDu);
            this.groupBox1.Controls.Add(this.textBox3_Cost);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.button3_Update);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(726, 151);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(523, 332);
            this.groupBox1.TabIndex = 167;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Update Clinical Cost";
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(370, 49);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 28);
            this.button1.TabIndex = 6;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btn_searchPatientId_Click);
            // 
            // textBox1_Description
            // 
            this.textBox1_Description.Location = new System.Drawing.Point(164, 114);
            this.textBox1_Description.Multiline = true;
            this.textBox1_Description.Name = "textBox1_Description";
            this.textBox1_Description.Size = new System.Drawing.Size(329, 134);
            this.textBox1_Description.TabIndex = 166;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(33, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Patient ID";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 46);
            this.label2.TabIndex = 160;
            this.label2.Text = "Description of\r\nClinical Activity";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_patientIDu
            // 
            this.txt_patientIDu.Location = new System.Drawing.Point(166, 49);
            this.txt_patientIDu.Margin = new System.Windows.Forms.Padding(4);
            this.txt_patientIDu.Name = "txt_patientIDu";
            this.txt_patientIDu.Size = new System.Drawing.Size(196, 26);
            this.txt_patientIDu.TabIndex = 4;
            // 
            // textBox3_Cost
            // 
            this.textBox3_Cost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3_Cost.Location = new System.Drawing.Point(166, 85);
            this.textBox3_Cost.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3_Cost.Name = "textBox3_Cost";
            this.textBox3_Cost.Size = new System.Drawing.Size(329, 22);
            this.textBox3_Cost.TabIndex = 162;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(166, 255);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 42);
            this.button2.TabIndex = 154;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btn_back_Click_1);
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 85);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 22);
            this.label3.TabIndex = 159;
            this.label3.Text = "Clinical Cost";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button3_Update
            // 
            this.button3_Update.ForeColor = System.Drawing.Color.Black;
            this.button3_Update.Location = new System.Drawing.Point(352, 255);
            this.button3_Update.Margin = new System.Windows.Forms.Padding(4);
            this.button3_Update.Name = "button3_Update";
            this.button3_Update.Size = new System.Drawing.Size(141, 42);
            this.button3_Update.TabIndex = 2;
            this.button3_Update.Text = "Update";
            this.button3_Update.UseVisualStyleBackColor = true;
            this.button3_Update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // clinicalCost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(1354, 733);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gb_clinicalCost);
            this.Controls.Add(this.lbl_title);
            this.Name = "clinicalCost";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clinical Cost";
            this.gb_clinicalCost.ResumeLayout(false);
            this.gb_clinicalCost.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_description;
        private System.Windows.Forms.Label lbl_clinicalActivity;
        private System.Windows.Forms.TextBox txt_clinicalCost;
        private System.Windows.Forms.Label lbl_clinicalCost;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_patientId2;
        private System.Windows.Forms.GroupBox gb_clinicalCost;
        private System.Windows.Forms.TextBox txt_patientId1;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1_Description;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_patientIDu;
        private System.Windows.Forms.TextBox textBox3_Cost;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3_Update;
    }
}