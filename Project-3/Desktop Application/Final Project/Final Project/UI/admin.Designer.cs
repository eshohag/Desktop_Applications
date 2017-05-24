namespace Final_Project
{
    partial class admin
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
            this.btn_nurseSchedula = new System.Windows.Forms.Button();
            this.btn_nurse = new System.Windows.Forms.Button();
            this.gb_administrarorOperation = new System.Windows.Forms.GroupBox();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_doctor = new System.Windows.Forms.Button();
            this.btn_doctorSchedule = new System.Windows.Forms.Button();
            this.btn_diagnosesCost = new System.Windows.Forms.Button();
            this.btn_instrumentalCost = new System.Windows.Forms.Button();
            this.btn_payment = new System.Windows.Forms.Button();
            this.btn_clinicalCost = new System.Windows.Forms.Button();
            this.btn_cabin = new System.Windows.Forms.Button();
            this.btn_drug = new System.Windows.Forms.Button();
            this.btn_treatment = new System.Windows.Forms.Button();
            this.btn_patient = new System.Windows.Forms.Button();
            this.lbl_title = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gb_administrarorOperation.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_nurseSchedula
            // 
            this.btn_nurseSchedula.ForeColor = System.Drawing.Color.Black;
            this.btn_nurseSchedula.Location = new System.Drawing.Point(386, 188);
            this.btn_nurseSchedula.Name = "btn_nurseSchedula";
            this.btn_nurseSchedula.Size = new System.Drawing.Size(346, 38);
            this.btn_nurseSchedula.TabIndex = 11;
            this.btn_nurseSchedula.Text = "Nurse Schedule";
            this.btn_nurseSchedula.UseVisualStyleBackColor = true;
            this.btn_nurseSchedula.Click += new System.EventHandler(this.btn_nurseSchedula_Click);
            // 
            // btn_nurse
            // 
            this.btn_nurse.ForeColor = System.Drawing.Color.Black;
            this.btn_nurse.Location = new System.Drawing.Point(210, 100);
            this.btn_nurse.Name = "btn_nurse";
            this.btn_nurse.Size = new System.Drawing.Size(170, 38);
            this.btn_nurse.TabIndex = 5;
            this.btn_nurse.Text = "Nurse ";
            this.btn_nurse.UseVisualStyleBackColor = true;
            this.btn_nurse.Click += new System.EventHandler(this.btn_nurse_Click);
            // 
            // gb_administrarorOperation
            // 
            this.gb_administrarorOperation.BackColor = System.Drawing.Color.Olive;
            this.gb_administrarorOperation.Controls.Add(this.btn_nurseSchedula);
            this.gb_administrarorOperation.Controls.Add(this.btn_nurse);
            this.gb_administrarorOperation.Controls.Add(this.btn_exit);
            this.gb_administrarorOperation.Controls.Add(this.btn_doctor);
            this.gb_administrarorOperation.Controls.Add(this.btn_doctorSchedule);
            this.gb_administrarorOperation.Controls.Add(this.btn_diagnosesCost);
            this.gb_administrarorOperation.Controls.Add(this.btn_instrumentalCost);
            this.gb_administrarorOperation.Controls.Add(this.btn_payment);
            this.gb_administrarorOperation.Controls.Add(this.btn_clinicalCost);
            this.gb_administrarorOperation.Controls.Add(this.btn_cabin);
            this.gb_administrarorOperation.Controls.Add(this.btn_drug);
            this.gb_administrarorOperation.Controls.Add(this.btn_treatment);
            this.gb_administrarorOperation.Controls.Add(this.btn_patient);
            this.gb_administrarorOperation.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_administrarorOperation.ForeColor = System.Drawing.Color.White;
            this.gb_administrarorOperation.Location = new System.Drawing.Point(299, 234);
            this.gb_administrarorOperation.Name = "gb_administrarorOperation";
            this.gb_administrarorOperation.Size = new System.Drawing.Size(773, 291);
            this.gb_administrarorOperation.TabIndex = 1;
            this.gb_administrarorOperation.TabStop = false;
            this.gb_administrarorOperation.Text = "Administrator Operation";
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.DarkRed;
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.Color.Transparent;
            this.btn_exit.Location = new System.Drawing.Point(302, 232);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(170, 38);
            this.btn_exit.TabIndex = 12;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_doctor
            // 
            this.btn_doctor.ForeColor = System.Drawing.Color.Black;
            this.btn_doctor.Location = new System.Drawing.Point(34, 100);
            this.btn_doctor.Name = "btn_doctor";
            this.btn_doctor.Size = new System.Drawing.Size(170, 38);
            this.btn_doctor.TabIndex = 4;
            this.btn_doctor.Text = "Doctor";
            this.btn_doctor.UseVisualStyleBackColor = true;
            this.btn_doctor.Click += new System.EventHandler(this.btn_doctor_Click);
            // 
            // btn_doctorSchedule
            // 
            this.btn_doctorSchedule.ForeColor = System.Drawing.Color.Black;
            this.btn_doctorSchedule.Location = new System.Drawing.Point(34, 188);
            this.btn_doctorSchedule.Name = "btn_doctorSchedule";
            this.btn_doctorSchedule.Size = new System.Drawing.Size(346, 38);
            this.btn_doctorSchedule.TabIndex = 10;
            this.btn_doctorSchedule.Text = "Doctor Schedule";
            this.btn_doctorSchedule.UseVisualStyleBackColor = true;
            this.btn_doctorSchedule.Click += new System.EventHandler(this.btn_doctorSchedule_Click);
            // 
            // btn_diagnosesCost
            // 
            this.btn_diagnosesCost.ForeColor = System.Drawing.Color.Black;
            this.btn_diagnosesCost.Location = new System.Drawing.Point(386, 144);
            this.btn_diagnosesCost.Name = "btn_diagnosesCost";
            this.btn_diagnosesCost.Size = new System.Drawing.Size(346, 38);
            this.btn_diagnosesCost.TabIndex = 9;
            this.btn_diagnosesCost.Text = "Diagnoses Cost";
            this.btn_diagnosesCost.UseVisualStyleBackColor = true;
            this.btn_diagnosesCost.Click += new System.EventHandler(this.btn_diagnosesCost_Click);
            // 
            // btn_instrumentalCost
            // 
            this.btn_instrumentalCost.ForeColor = System.Drawing.Color.Black;
            this.btn_instrumentalCost.Location = new System.Drawing.Point(34, 144);
            this.btn_instrumentalCost.Name = "btn_instrumentalCost";
            this.btn_instrumentalCost.Size = new System.Drawing.Size(346, 38);
            this.btn_instrumentalCost.TabIndex = 8;
            this.btn_instrumentalCost.Text = "Instrumental Cost";
            this.btn_instrumentalCost.UseVisualStyleBackColor = true;
            this.btn_instrumentalCost.Click += new System.EventHandler(this.btn_instrumentalCost_Click);
            // 
            // btn_payment
            // 
            this.btn_payment.ForeColor = System.Drawing.Color.Black;
            this.btn_payment.Location = new System.Drawing.Point(562, 100);
            this.btn_payment.Name = "btn_payment";
            this.btn_payment.Size = new System.Drawing.Size(170, 38);
            this.btn_payment.TabIndex = 7;
            this.btn_payment.Text = "Payment";
            this.btn_payment.UseVisualStyleBackColor = true;
            this.btn_payment.Click += new System.EventHandler(this.btn_payment_Click);
            // 
            // btn_clinicalCost
            // 
            this.btn_clinicalCost.ForeColor = System.Drawing.Color.Black;
            this.btn_clinicalCost.Location = new System.Drawing.Point(386, 100);
            this.btn_clinicalCost.Name = "btn_clinicalCost";
            this.btn_clinicalCost.Size = new System.Drawing.Size(170, 38);
            this.btn_clinicalCost.TabIndex = 6;
            this.btn_clinicalCost.Text = "Clinical Cost";
            this.btn_clinicalCost.UseVisualStyleBackColor = true;
            this.btn_clinicalCost.Click += new System.EventHandler(this.btn_clinicalCost_Click);
            // 
            // btn_cabin
            // 
            this.btn_cabin.ForeColor = System.Drawing.Color.Black;
            this.btn_cabin.Location = new System.Drawing.Point(210, 56);
            this.btn_cabin.Name = "btn_cabin";
            this.btn_cabin.Size = new System.Drawing.Size(170, 38);
            this.btn_cabin.TabIndex = 1;
            this.btn_cabin.Text = "Cabin";
            this.btn_cabin.UseVisualStyleBackColor = true;
            this.btn_cabin.Click += new System.EventHandler(this.btn_cabin_Click);
            // 
            // btn_drug
            // 
            this.btn_drug.ForeColor = System.Drawing.Color.Black;
            this.btn_drug.Location = new System.Drawing.Point(386, 56);
            this.btn_drug.Name = "btn_drug";
            this.btn_drug.Size = new System.Drawing.Size(170, 38);
            this.btn_drug.TabIndex = 2;
            this.btn_drug.Text = "Drug";
            this.btn_drug.UseVisualStyleBackColor = true;
            this.btn_drug.Click += new System.EventHandler(this.btn_drug_Click);
            // 
            // btn_treatment
            // 
            this.btn_treatment.ForeColor = System.Drawing.Color.Black;
            this.btn_treatment.Location = new System.Drawing.Point(562, 56);
            this.btn_treatment.Name = "btn_treatment";
            this.btn_treatment.Size = new System.Drawing.Size(170, 38);
            this.btn_treatment.TabIndex = 3;
            this.btn_treatment.Text = "Treatment";
            this.btn_treatment.UseVisualStyleBackColor = true;
            this.btn_treatment.Click += new System.EventHandler(this.btn_treatment_Click);
            // 
            // btn_patient
            // 
            this.btn_patient.ForeColor = System.Drawing.Color.Black;
            this.btn_patient.Location = new System.Drawing.Point(34, 56);
            this.btn_patient.Name = "btn_patient";
            this.btn_patient.Size = new System.Drawing.Size(170, 38);
            this.btn_patient.TabIndex = 0;
            this.btn_patient.Text = "Patient ";
            this.btn_patient.UseVisualStyleBackColor = true;
            this.btn_patient.Click += new System.EventHandler(this.btn_patient_Click);
            // 
            // lbl_title
            // 
            this.lbl_title.BackColor = System.Drawing.Color.Lime;
            this.lbl_title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(299, 152);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(773, 57);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Tag = "";
            this.lbl_title.Text = "Admin Panel";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(165, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1063, 69);
            this.label5.TabIndex = 0;
            this.label5.Text = "Interactive Solution of Clinical Decision";
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(1354, 733);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.gb_administrarorOperation);
            this.Controls.Add(this.lbl_title);
            this.Name = "admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.admin_Load);
            this.gb_administrarorOperation.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_nurseSchedula;
        private System.Windows.Forms.Button btn_nurse;
        private System.Windows.Forms.GroupBox gb_administrarorOperation;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_doctor;
        private System.Windows.Forms.Button btn_doctorSchedule;
        private System.Windows.Forms.Button btn_diagnosesCost;
        private System.Windows.Forms.Button btn_instrumentalCost;
        private System.Windows.Forms.Button btn_payment;
        private System.Windows.Forms.Button btn_clinicalCost;
        private System.Windows.Forms.Button btn_cabin;
        private System.Windows.Forms.Button btn_drug;
        private System.Windows.Forms.Button btn_treatment;
        private System.Windows.Forms.Button btn_patient;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label label5;


    }
}