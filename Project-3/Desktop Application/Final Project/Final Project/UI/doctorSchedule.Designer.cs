namespace Final_Project
{
    partial class doctorSchedule
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
            this.components = new System.ComponentModel.Container();
            this.lbl_title = new System.Windows.Forms.Label();
            this.gb_doctorInformation = new System.Windows.Forms.GroupBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.cmb_department = new System.Windows.Forms.ComboBox();
            this.btn_SearchDoctor = new System.Windows.Forms.Button();
            this.lbl_shift = new System.Windows.Forms.Label();
            this.lbl_department1 = new System.Windows.Forms.Label();
            this.cmb_shift = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specialityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shiftDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorScheduleUserViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.diagnosesCenterDBDataSet = new Final_Project.DiagnosesCenterDBDataSet();
            this.doctorScheduleUserViewTableAdapter = new Final_Project.DiagnosesCenterDBDataSetTableAdapters.DoctorScheduleUserViewTableAdapter();
            this.gb_doctorInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorScheduleUserViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosesCenterDBDataSet)).BeginInit();
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
            this.lbl_title.TabIndex = 139;
            this.lbl_title.Tag = "";
            this.lbl_title.Text = "Doctor  Schedule  Collection  /  Update  Doctor  Schedule";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gb_doctorInformation
            // 
            this.gb_doctorInformation.Controls.Add(this.btn_back);
            this.gb_doctorInformation.Controls.Add(this.cmb_department);
            this.gb_doctorInformation.Controls.Add(this.btn_SearchDoctor);
            this.gb_doctorInformation.Controls.Add(this.lbl_shift);
            this.gb_doctorInformation.Controls.Add(this.lbl_department1);
            this.gb_doctorInformation.Controls.Add(this.cmb_shift);
            this.gb_doctorInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_doctorInformation.ForeColor = System.Drawing.Color.Black;
            this.gb_doctorInformation.Location = new System.Drawing.Point(416, 136);
            this.gb_doctorInformation.Margin = new System.Windows.Forms.Padding(4);
            this.gb_doctorInformation.Name = "gb_doctorInformation";
            this.gb_doctorInformation.Padding = new System.Windows.Forms.Padding(4);
            this.gb_doctorInformation.Size = new System.Drawing.Size(571, 158);
            this.gb_doctorInformation.TabIndex = 0;
            this.gb_doctorInformation.TabStop = false;
            this.gb_doctorInformation.Text = "Doctor Schedule";
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(196, 107);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 32);
            this.btn_back.TabIndex = 131;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click_1);
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
            this.cmb_department.Location = new System.Drawing.Point(162, 43);
            this.cmb_department.Name = "cmb_department";
            this.cmb_department.Size = new System.Drawing.Size(329, 24);
            this.cmb_department.TabIndex = 4;
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
            // lbl_shift
            // 
            this.lbl_shift.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_shift.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_shift.Location = new System.Drawing.Point(37, 75);
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
            this.lbl_department1.Location = new System.Drawing.Point(38, 43);
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
            this.cmb_shift.Location = new System.Drawing.Point(162, 72);
            this.cmb_shift.Name = "cmb_shift";
            this.cmb_shift.Size = new System.Drawing.Size(329, 28);
            this.cmb_shift.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.specialityDataGridViewTextBoxColumn,
            this.departmentDataGridViewTextBoxColumn,
            this.shiftDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.doctorScheduleUserViewBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(494, 301);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(442, 164);
            this.dataGridView1.TabIndex = 144;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // specialityDataGridViewTextBoxColumn
            // 
            this.specialityDataGridViewTextBoxColumn.DataPropertyName = "Speciality";
            this.specialityDataGridViewTextBoxColumn.HeaderText = "Speciality";
            this.specialityDataGridViewTextBoxColumn.Name = "specialityDataGridViewTextBoxColumn";
            // 
            // departmentDataGridViewTextBoxColumn
            // 
            this.departmentDataGridViewTextBoxColumn.DataPropertyName = "Department";
            this.departmentDataGridViewTextBoxColumn.HeaderText = "Department";
            this.departmentDataGridViewTextBoxColumn.Name = "departmentDataGridViewTextBoxColumn";
            // 
            // shiftDataGridViewTextBoxColumn
            // 
            this.shiftDataGridViewTextBoxColumn.DataPropertyName = "Shift";
            this.shiftDataGridViewTextBoxColumn.HeaderText = "Shift";
            this.shiftDataGridViewTextBoxColumn.Name = "shiftDataGridViewTextBoxColumn";
            // 
            // doctorScheduleUserViewBindingSource
            // 
            this.doctorScheduleUserViewBindingSource.DataMember = "DoctorScheduleUserView";
            this.doctorScheduleUserViewBindingSource.DataSource = this.diagnosesCenterDBDataSet;
            // 
            // diagnosesCenterDBDataSet
            // 
            this.diagnosesCenterDBDataSet.DataSetName = "DiagnosesCenterDBDataSet";
            this.diagnosesCenterDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // doctorScheduleUserViewTableAdapter
            // 
            this.doctorScheduleUserViewTableAdapter.ClearBeforeFill = true;
            // 
            // doctorSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(1354, 733);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gb_doctorInformation);
            this.Controls.Add(this.lbl_title);
            this.Name = "doctorSchedule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doctor Schedule";
            this.Load += new System.EventHandler(this.doctorSchedule_Load);
            this.gb_doctorInformation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorScheduleUserViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosesCenterDBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.GroupBox gb_doctorInformation;
        private System.Windows.Forms.ComboBox cmb_department;
        private System.Windows.Forms.Button btn_SearchDoctor;
        private System.Windows.Forms.Label lbl_department1;
        private System.Windows.Forms.Label lbl_shift;
        private System.Windows.Forms.ComboBox cmb_shift;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DiagnosesCenterDBDataSet diagnosesCenterDBDataSet;
        private System.Windows.Forms.BindingSource doctorScheduleUserViewBindingSource;
        private DiagnosesCenterDBDataSetTableAdapters.DoctorScheduleUserViewTableAdapter doctorScheduleUserViewTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn specialityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shiftDataGridViewTextBoxColumn;
    }
}