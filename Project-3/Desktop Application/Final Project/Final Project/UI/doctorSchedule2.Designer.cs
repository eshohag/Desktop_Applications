namespace Final_Project
{
    partial class doctorSchedule2
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
            this.lbl_title = new System.Windows.Forms.Label();
            this.gb_doctorInformation = new System.Windows.Forms.GroupBox();
            this.cmb_department = new System.Windows.Forms.ComboBox();
            this.txt_NameOfDoctors = new System.Windows.Forms.TextBox();
            this.txt_doctorEducation = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_doctorName = new System.Windows.Forms.Label();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.lbl_shift = new System.Windows.Forms.Label();
            this.lbl_department1 = new System.Windows.Forms.Label();
            this.cmb_shift = new System.Windows.Forms.ComboBox();
            this.lbl_doctorId = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_doctorId = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_SearchDoctor = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.gb_doctorInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.BackColor = System.Drawing.Color.Lime;
            this.lbl_title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_title.Font = new System.Drawing.Font("Monotype Corsiva", 33.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(90, 39);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(1183, 80);
            this.lbl_title.TabIndex = 168;
            this.lbl_title.Tag = "";
            this.lbl_title.Text = "Doctor  Schedule  Collection  /  Update  Doctor  Schedule";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gb_doctorInformation
            // 
            this.gb_doctorInformation.Controls.Add(this.cmb_department);
            this.gb_doctorInformation.Controls.Add(this.txt_NameOfDoctors);
            this.gb_doctorInformation.Controls.Add(this.txt_doctorEducation);
            this.gb_doctorInformation.Controls.Add(this.label1);
            this.gb_doctorInformation.Controls.Add(this.lbl_doctorName);
            this.gb_doctorInformation.Controls.Add(this.btn_update);
            this.gb_doctorInformation.Controls.Add(this.btn_back);
            this.gb_doctorInformation.Controls.Add(this.btn_add);
            this.gb_doctorInformation.Controls.Add(this.lbl_shift);
            this.gb_doctorInformation.Controls.Add(this.lbl_department1);
            this.gb_doctorInformation.Controls.Add(this.cmb_shift);
            this.gb_doctorInformation.Controls.Add(this.lbl_doctorId);
            this.gb_doctorInformation.Controls.Add(this.btn_search);
            this.gb_doctorInformation.Controls.Add(this.txt_doctorId);
            this.gb_doctorInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_doctorInformation.ForeColor = System.Drawing.Color.Black;
            this.gb_doctorInformation.Location = new System.Drawing.Point(102, 152);
            this.gb_doctorInformation.Margin = new System.Windows.Forms.Padding(4);
            this.gb_doctorInformation.Name = "gb_doctorInformation";
            this.gb_doctorInformation.Padding = new System.Windows.Forms.Padding(4);
            this.gb_doctorInformation.Size = new System.Drawing.Size(571, 264);
            this.gb_doctorInformation.TabIndex = 0;
            this.gb_doctorInformation.TabStop = false;
            this.gb_doctorInformation.Text = "Doctor Schedule";
            // 
            // cmb_department
            // 
            this.cmb_department.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_department.FormattingEnabled = true;
            this.cmb_department.Items.AddRange(new object[] {
            "--Select Department--",
            "Cardiology",
            "Medicine",
            "General Surgery",
            "Haematology",
            "Gynaecology",
            "Microbiology",
            "Neurology",
            "Urology"});
            this.cmb_department.Location = new System.Drawing.Point(158, 135);
            this.cmb_department.Name = "cmb_department";
            this.cmb_department.Size = new System.Drawing.Size(329, 24);
            this.cmb_department.TabIndex = 4;
            // 
            // txt_NameOfDoctors
            // 
            this.txt_NameOfDoctors.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NameOfDoctors.Location = new System.Drawing.Point(158, 65);
            this.txt_NameOfDoctors.Margin = new System.Windows.Forms.Padding(4);
            this.txt_NameOfDoctors.Name = "txt_NameOfDoctors";
            this.txt_NameOfDoctors.Size = new System.Drawing.Size(329, 22);
            this.txt_NameOfDoctors.TabIndex = 2;
            // 
            // txt_doctorEducation
            // 
            this.txt_doctorEducation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_doctorEducation.Location = new System.Drawing.Point(158, 98);
            this.txt_doctorEducation.Margin = new System.Windows.Forms.Padding(4);
            this.txt_doctorEducation.Name = "txt_doctorEducation";
            this.txt_doctorEducation.Size = new System.Drawing.Size(329, 22);
            this.txt_doctorEducation.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 22);
            this.label1.TabIndex = 128;
            this.label1.Text = "Doctor Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_doctorName
            // 
            this.lbl_doctorName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_doctorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_doctorName.Location = new System.Drawing.Point(33, 98);
            this.lbl_doctorName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_doctorName.Name = "lbl_doctorName";
            this.lbl_doctorName.Size = new System.Drawing.Size(115, 22);
            this.lbl_doctorName.TabIndex = 128;
            this.lbl_doctorName.Text = "Education";
            this.lbl_doctorName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_update
            // 
            this.btn_update.ForeColor = System.Drawing.Color.Black;
            this.btn_update.Location = new System.Drawing.Point(379, 209);
            this.btn_update.Margin = new System.Windows.Forms.Padding(4);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(108, 32);
            this.btn_update.TabIndex = 7;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.Color.Black;
            this.btn_back.Location = new System.Drawing.Point(158, 208);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(104, 33);
            this.btn_back.TabIndex = 8;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_add
            // 
            this.btn_add.ForeColor = System.Drawing.Color.Black;
            this.btn_add.Location = new System.Drawing.Point(269, 208);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(102, 33);
            this.btn_add.TabIndex = 6;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // lbl_shift
            // 
            this.lbl_shift.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_shift.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_shift.Location = new System.Drawing.Point(33, 167);
            this.lbl_shift.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_shift.Name = "lbl_shift";
            this.lbl_shift.Size = new System.Drawing.Size(115, 22);
            this.lbl_shift.TabIndex = 130;
            this.lbl_shift.Text = "Shift";
            this.lbl_shift.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_department1
            // 
            this.lbl_department1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_department1.ForeColor = System.Drawing.Color.Black;
            this.lbl_department1.Location = new System.Drawing.Point(34, 135);
            this.lbl_department1.Name = "lbl_department1";
            this.lbl_department1.Size = new System.Drawing.Size(114, 22);
            this.lbl_department1.TabIndex = 121;
            this.lbl_department1.Text = "Department";
            this.lbl_department1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_shift
            // 
            this.cmb_shift.FormattingEnabled = true;
            this.cmb_shift.Items.AddRange(new object[] {
            "--Select Shift--",
            "Morning ",
            "Evening",
            "Night"});
            this.cmb_shift.Location = new System.Drawing.Point(158, 164);
            this.cmb_shift.Name = "cmb_shift";
            this.cmb_shift.Size = new System.Drawing.Size(329, 28);
            this.cmb_shift.TabIndex = 5;
            // 
            // lbl_doctorId
            // 
            this.lbl_doctorId.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_doctorId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_doctorId.Location = new System.Drawing.Point(33, 31);
            this.lbl_doctorId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_doctorId.Name = "lbl_doctorId";
            this.lbl_doctorId.Size = new System.Drawing.Size(117, 22);
            this.lbl_doctorId.TabIndex = 127;
            this.lbl_doctorId.Text = "Dotor ID";
            this.lbl_doctorId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_search
            // 
            this.btn_search.ForeColor = System.Drawing.Color.Black;
            this.btn_search.Location = new System.Drawing.Point(379, 27);
            this.btn_search.Margin = new System.Windows.Forms.Padding(4);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(108, 29);
            this.btn_search.TabIndex = 1;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_doctorId
            // 
            this.txt_doctorId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_doctorId.Location = new System.Drawing.Point(158, 31);
            this.txt_doctorId.Margin = new System.Windows.Forms.Padding(4);
            this.txt_doctorId.Multiline = true;
            this.txt_doctorId.Name = "txt_doctorId";
            this.txt_doctorId.Size = new System.Drawing.Size(213, 24);
            this.txt_doctorId.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(759, 327);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(442, 164);
            this.dataGridView1.TabIndex = 170;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.btn_SearchDoctor);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(681, 162);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(571, 158);
            this.groupBox1.TabIndex = 169;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Doctor Schedule";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(196, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 32);
            this.button1.TabIndex = 131;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "--Select Department--",
            "Cardiology",
            "Medicine",
            "General Surgery",
            "Haematology",
            "Gynaecology",
            "Microbiology",
            "Neurology",
            "Urology"});
            this.comboBox1.Location = new System.Drawing.Point(162, 43);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(329, 24);
            this.comboBox1.TabIndex = 4;
            // 
            // btn_SearchDoctor
            // 
            this.btn_SearchDoctor.ForeColor = System.Drawing.Color.Black;
            this.btn_SearchDoctor.Location = new System.Drawing.Point(383, 107);
            this.btn_SearchDoctor.Margin = new System.Windows.Forms.Padding(4);
            this.btn_SearchDoctor.Name = "btn_SearchDoctor";
            this.btn_SearchDoctor.Size = new System.Drawing.Size(108, 32);
            this.btn_SearchDoctor.TabIndex = 7;
            this.btn_SearchDoctor.Text = "Search";
            this.btn_SearchDoctor.UseVisualStyleBackColor = true;
            this.btn_SearchDoctor.Click += new System.EventHandler(this.btn_SearchDoctor_Click);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 22);
            this.label2.TabIndex = 130;
            this.label2.Text = "Shift";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(38, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 22);
            this.label3.TabIndex = 121;
            this.label3.Text = "Department";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "--Select Shift--",
            "Morning ",
            "Evening",
            "Night"});
            this.comboBox2.Location = new System.Drawing.Point(162, 72);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(329, 28);
            this.comboBox2.TabIndex = 5;
            // 
            // doctorSchedule2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(1354, 733);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gb_doctorInformation);
            this.Controls.Add(this.lbl_title);
            this.Name = "doctorSchedule2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doctor Schedule2";
            this.Load += new System.EventHandler(this.doctorSchedule2_Load);
            this.gb_doctorInformation.ResumeLayout(false);
            this.gb_doctorInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.GroupBox gb_doctorInformation;
        private System.Windows.Forms.ComboBox cmb_department;
        private System.Windows.Forms.TextBox txt_doctorEducation;
        private System.Windows.Forms.Label lbl_doctorName;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label lbl_shift;
        private System.Windows.Forms.Label lbl_department1;
        private System.Windows.Forms.ComboBox cmb_shift;
        private System.Windows.Forms.Label lbl_doctorId;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_doctorId;
        private System.Windows.Forms.TextBox txt_NameOfDoctors;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_SearchDoctor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}