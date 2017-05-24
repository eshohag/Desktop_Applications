namespace Final_Project
{
    partial class treatmentInfo
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
            this.txt_nameOfTreatment = new System.Windows.Forms.TextBox();
            this.txt_diseaseName = new System.Windows.Forms.TextBox();
            this.txt_cost = new System.Windows.Forms.TextBox();
            this.lbl_description = new System.Windows.Forms.Label();
            this.txt_description = new System.Windows.Forms.RichTextBox();
            this.lbl_cost = new System.Windows.Forms.Label();
            this.lbl_diseaseName = new System.Windows.Forms.Label();
            this.lbl_nameOfTreatment = new System.Windows.Forms.Label();
            this.lbl_patientId1 = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_patientId = new System.Windows.Forms.TextBox();
            this.gb_treatmentInfomation = new System.Windows.Forms.GroupBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.gb_treatmentInfomation.SuspendLayout();
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
            this.lbl_title.TabIndex = 93;
            this.lbl_title.Tag = "";
            this.lbl_title.Text = "Treatment Information Collection  / Update Treatment Collection ";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_nameOfTreatment
            // 
            this.txt_nameOfTreatment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nameOfTreatment.Location = new System.Drawing.Point(209, 82);
            this.txt_nameOfTreatment.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_nameOfTreatment.Name = "txt_nameOfTreatment";
            this.txt_nameOfTreatment.Size = new System.Drawing.Size(329, 22);
            this.txt_nameOfTreatment.TabIndex = 3;
            // 
            // txt_diseaseName
            // 
            this.txt_diseaseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_diseaseName.Location = new System.Drawing.Point(209, 112);
            this.txt_diseaseName.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_diseaseName.Name = "txt_diseaseName";
            this.txt_diseaseName.Size = new System.Drawing.Size(329, 22);
            this.txt_diseaseName.TabIndex = 4;
            // 
            // txt_cost
            // 
            this.txt_cost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cost.Location = new System.Drawing.Point(209, 142);
            this.txt_cost.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_cost.Name = "txt_cost";
            this.txt_cost.Size = new System.Drawing.Size(329, 22);
            this.txt_cost.TabIndex = 5;
            // 
            // lbl_description
            // 
            this.lbl_description.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_description.Location = new System.Drawing.Point(20, 174);
            this.lbl_description.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_description.Name = "lbl_description";
            this.lbl_description.Size = new System.Drawing.Size(175, 39);
            this.lbl_description.TabIndex = 87;
            this.lbl_description.Text = "Description of Treatment";
            this.lbl_description.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_description
            // 
            this.txt_description.Location = new System.Drawing.Point(209, 174);
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(329, 163);
            this.txt_description.TabIndex = 6;
            this.txt_description.Text = "";
            // 
            // lbl_cost
            // 
            this.lbl_cost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_cost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cost.Location = new System.Drawing.Point(20, 142);
            this.lbl_cost.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_cost.Name = "lbl_cost";
            this.lbl_cost.Size = new System.Drawing.Size(175, 22);
            this.lbl_cost.TabIndex = 86;
            this.lbl_cost.Text = "Cost";
            this.lbl_cost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_diseaseName
            // 
            this.lbl_diseaseName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_diseaseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_diseaseName.Location = new System.Drawing.Point(20, 112);
            this.lbl_diseaseName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_diseaseName.Name = "lbl_diseaseName";
            this.lbl_diseaseName.Size = new System.Drawing.Size(175, 22);
            this.lbl_diseaseName.TabIndex = 85;
            this.lbl_diseaseName.Text = "Disease Name";
            this.lbl_diseaseName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_nameOfTreatment
            // 
            this.lbl_nameOfTreatment.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_nameOfTreatment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nameOfTreatment.Location = new System.Drawing.Point(20, 82);
            this.lbl_nameOfTreatment.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_nameOfTreatment.Name = "lbl_nameOfTreatment";
            this.lbl_nameOfTreatment.Size = new System.Drawing.Size(175, 22);
            this.lbl_nameOfTreatment.TabIndex = 84;
            this.lbl_nameOfTreatment.Text = "Name of Treatment";
            this.lbl_nameOfTreatment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_patientId1
            // 
            this.lbl_patientId1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_patientId1.ForeColor = System.Drawing.Color.Black;
            this.lbl_patientId1.Location = new System.Drawing.Point(22, 42);
            this.lbl_patientId1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_patientId1.Name = "lbl_patientId1";
            this.lbl_patientId1.Size = new System.Drawing.Size(173, 26);
            this.lbl_patientId1.TabIndex = 84;
            this.lbl_patientId1.Text = "Patient ID";
            this.lbl_patientId1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_search
            // 
            this.btn_search.ForeColor = System.Drawing.Color.Black;
            this.btn_search.Location = new System.Drawing.Point(447, 42);
            this.btn_search.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(93, 28);
            this.btn_search.TabIndex = 2;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_patientId
            // 
            this.txt_patientId.ForeColor = System.Drawing.Color.Black;
            this.txt_patientId.Location = new System.Drawing.Point(211, 42);
            this.txt_patientId.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_patientId.Name = "txt_patientId";
            this.txt_patientId.Size = new System.Drawing.Size(226, 26);
            this.txt_patientId.TabIndex = 1;
            // 
            // gb_treatmentInfomation
            // 
            this.gb_treatmentInfomation.Controls.Add(this.lbl_patientId1);
            this.gb_treatmentInfomation.Controls.Add(this.btn_search);
            this.gb_treatmentInfomation.Controls.Add(this.txt_nameOfTreatment);
            this.gb_treatmentInfomation.Controls.Add(this.txt_patientId);
            this.gb_treatmentInfomation.Controls.Add(this.txt_diseaseName);
            this.gb_treatmentInfomation.Controls.Add(this.btn_back);
            this.gb_treatmentInfomation.Controls.Add(this.txt_cost);
            this.gb_treatmentInfomation.Controls.Add(this.btn_update);
            this.gb_treatmentInfomation.Controls.Add(this.lbl_description);
            this.gb_treatmentInfomation.Controls.Add(this.btn_add);
            this.gb_treatmentInfomation.Controls.Add(this.txt_description);
            this.gb_treatmentInfomation.Controls.Add(this.lbl_cost);
            this.gb_treatmentInfomation.Controls.Add(this.lbl_nameOfTreatment);
            this.gb_treatmentInfomation.Controls.Add(this.lbl_diseaseName);
            this.gb_treatmentInfomation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_treatmentInfomation.ForeColor = System.Drawing.Color.Black;
            this.gb_treatmentInfomation.Location = new System.Drawing.Point(331, 138);
            this.gb_treatmentInfomation.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gb_treatmentInfomation.Name = "gb_treatmentInfomation";
            this.gb_treatmentInfomation.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gb_treatmentInfomation.Size = new System.Drawing.Size(619, 431);
            this.gb_treatmentInfomation.TabIndex = 0;
            this.gb_treatmentInfomation.TabStop = false;
            this.gb_treatmentInfomation.Text = "Treatment Information";
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.Color.Black;
            this.btn_back.Location = new System.Drawing.Point(84, 356);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(146, 42);
            this.btn_back.TabIndex = 9;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click_1);
            // 
            // btn_update
            // 
            this.btn_update.ForeColor = System.Drawing.Color.Black;
            this.btn_update.Location = new System.Drawing.Point(392, 356);
            this.btn_update.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(146, 42);
            this.btn_update.TabIndex = 8;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_add
            // 
            this.btn_add.ForeColor = System.Drawing.Color.Black;
            this.btn_add.Location = new System.Drawing.Point(238, 356);
            this.btn_add.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(146, 42);
            this.btn_add.TabIndex = 7;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // treatmentInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(1354, 733);
            this.Controls.Add(this.gb_treatmentInfomation);
            this.Controls.Add(this.lbl_title);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "treatmentInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Treatment";
            this.gb_treatmentInfomation.ResumeLayout(false);
            this.gb_treatmentInfomation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.TextBox txt_nameOfTreatment;
        private System.Windows.Forms.TextBox txt_diseaseName;
        private System.Windows.Forms.TextBox txt_cost;
        private System.Windows.Forms.Label lbl_description;
        private System.Windows.Forms.RichTextBox txt_description;
        private System.Windows.Forms.Label lbl_cost;
        private System.Windows.Forms.Label lbl_diseaseName;
        private System.Windows.Forms.Label lbl_nameOfTreatment;
        private System.Windows.Forms.Label lbl_patientId1;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_patientId;
        private System.Windows.Forms.GroupBox gb_treatmentInfomation;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_add;
    }
}