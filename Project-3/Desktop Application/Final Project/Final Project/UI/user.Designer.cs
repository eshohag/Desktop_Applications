namespace Final_Project
{
    partial class user
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
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_doctor = new System.Windows.Forms.Button();
            this.btn_doctorSchedule = new System.Windows.Forms.Button();
            this.btn_payment = new System.Windows.Forms.Button();
            this.btn_patient = new System.Windows.Forms.Button();
            this.gb_userOperation = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button_NurseSchedule = new System.Windows.Forms.Button();
            this.gb_userOperation.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.BackColor = System.Drawing.Color.Lime;
            this.lbl_title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(331, 138);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(698, 57);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Tag = "";
            this.lbl_title.Text = "User  Panel";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Maroon;
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.Color.Transparent;
            this.btn_exit.Location = new System.Drawing.Point(349, 156);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(234, 42);
            this.btn_exit.TabIndex = 4;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_doctor
            // 
            this.btn_doctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_doctor.ForeColor = System.Drawing.Color.Black;
            this.btn_doctor.Location = new System.Drawing.Point(349, 98);
            this.btn_doctor.Name = "btn_doctor";
            this.btn_doctor.Size = new System.Drawing.Size(234, 52);
            this.btn_doctor.TabIndex = 3;
            this.btn_doctor.Text = "Doctor";
            this.btn_doctor.UseVisualStyleBackColor = true;
            this.btn_doctor.Click += new System.EventHandler(this.btn_doctor_Click);
            // 
            // btn_doctorSchedule
            // 
            this.btn_doctorSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_doctorSchedule.ForeColor = System.Drawing.Color.Black;
            this.btn_doctorSchedule.Location = new System.Drawing.Point(109, 98);
            this.btn_doctorSchedule.Name = "btn_doctorSchedule";
            this.btn_doctorSchedule.Size = new System.Drawing.Size(234, 52);
            this.btn_doctorSchedule.TabIndex = 2;
            this.btn_doctorSchedule.Text = "Doctor Schedule";
            this.btn_doctorSchedule.UseVisualStyleBackColor = true;
            this.btn_doctorSchedule.Click += new System.EventHandler(this.btn_doctorSchedule_Click);
            // 
            // btn_payment
            // 
            this.btn_payment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_payment.ForeColor = System.Drawing.Color.Black;
            this.btn_payment.Location = new System.Drawing.Point(349, 40);
            this.btn_payment.Name = "btn_payment";
            this.btn_payment.Size = new System.Drawing.Size(234, 52);
            this.btn_payment.TabIndex = 1;
            this.btn_payment.Text = "Payment";
            this.btn_payment.UseVisualStyleBackColor = true;
            this.btn_payment.Click += new System.EventHandler(this.btn_payment_Click);
            // 
            // btn_patient
            // 
            this.btn_patient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_patient.ForeColor = System.Drawing.Color.Black;
            this.btn_patient.Location = new System.Drawing.Point(109, 40);
            this.btn_patient.Name = "btn_patient";
            this.btn_patient.Size = new System.Drawing.Size(234, 52);
            this.btn_patient.TabIndex = 0;
            this.btn_patient.Text = "Patient ";
            this.btn_patient.UseVisualStyleBackColor = true;
            this.btn_patient.Click += new System.EventHandler(this.btn_patient_Click);
            // 
            // gb_userOperation
            // 
            this.gb_userOperation.BackColor = System.Drawing.Color.Olive;
            this.gb_userOperation.Controls.Add(this.button_NurseSchedule);
            this.gb_userOperation.Controls.Add(this.btn_exit);
            this.gb_userOperation.Controls.Add(this.btn_doctor);
            this.gb_userOperation.Controls.Add(this.btn_doctorSchedule);
            this.gb_userOperation.Controls.Add(this.btn_payment);
            this.gb_userOperation.Controls.Add(this.btn_patient);
            this.gb_userOperation.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_userOperation.ForeColor = System.Drawing.Color.White;
            this.gb_userOperation.Location = new System.Drawing.Point(354, 218);
            this.gb_userOperation.Name = "gb_userOperation";
            this.gb_userOperation.Size = new System.Drawing.Size(655, 215);
            this.gb_userOperation.TabIndex = 1;
            this.gb_userOperation.TabStop = false;
            this.gb_userOperation.Text = "User Operation";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(174, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1063, 69);
            this.label5.TabIndex = 0;
            this.label5.Text = "Interactive Solution of Clinical Decision";
            // 
            // button_NurseSchedule
            // 
            this.button_NurseSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_NurseSchedule.ForeColor = System.Drawing.Color.Black;
            this.button_NurseSchedule.Location = new System.Drawing.Point(109, 156);
            this.button_NurseSchedule.Name = "button_NurseSchedule";
            this.button_NurseSchedule.Size = new System.Drawing.Size(234, 42);
            this.button_NurseSchedule.TabIndex = 3;
            this.button_NurseSchedule.Text = "Nurse Schedule";
            this.button_NurseSchedule.UseVisualStyleBackColor = true;
            this.button_NurseSchedule.Click += new System.EventHandler(this.button_NurseSchedule_Click);
            // 
            // user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(1354, 733);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.gb_userOperation);
            this.Name = "user";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User";
            this.gb_userOperation.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_doctor;
        private System.Windows.Forms.Button btn_doctorSchedule;
        private System.Windows.Forms.Button btn_payment;
        private System.Windows.Forms.Button btn_patient;
        private System.Windows.Forms.GroupBox gb_userOperation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_NurseSchedule;
    }
}