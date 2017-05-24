namespace Final_Project
{
    partial class cabinInfo
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
            this.dtp_release = new System.Windows.Forms.DateTimePicker();
            this.dtp_joining = new System.Windows.Forms.DateTimePicker();
            this.cmb_cabinType = new System.Windows.Forms.ComboBox();
            this.lbl_title = new System.Windows.Forms.Label();
            this.btn_calculate = new System.Windows.Forms.Button();
            this.txt_amoutOfStay = new System.Windows.Forms.TextBox();
            this.txt_perDayCost = new System.Windows.Forms.TextBox();
            this.txt_totalCost = new System.Windows.Forms.TextBox();
            this.txt_location = new System.Windows.Forms.TextBox();
            this.txt_bedNumber = new System.Windows.Forms.TextBox();
            this.txt_cabinId = new System.Windows.Forms.TextBox();
            this.lbl_totalCost = new System.Windows.Forms.Label();
            this.lbl_perDayCost = new System.Windows.Forms.Label();
            this.lbl_amountOfstay = new System.Windows.Forms.Label();
            this.lbl_dateOfRelease = new System.Windows.Forms.Label();
            this.lbl_bedNumber = new System.Windows.Forms.Label();
            this.lbl_dateOfJoining = new System.Windows.Forms.Label();
            this.lbl_location = new System.Windows.Forms.Label();
            this.lbl_cabinType = new System.Windows.Forms.Label();
            this.lbl_cabinNo = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.lbl_patientId1 = new System.Windows.Forms.Label();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.gb_cabinInformation = new System.Windows.Forms.GroupBox();
            this.txt_patientId1 = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_patientCabinInfo = new System.Windows.Forms.TextBox();
            this.gb_cabinInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtp_release
            // 
            this.dtp_release.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_release.Location = new System.Drawing.Point(168, 274);
            this.dtp_release.Name = "dtp_release";
            this.dtp_release.Size = new System.Drawing.Size(328, 22);
            this.dtp_release.TabIndex = 8;
            // 
            // dtp_joining
            // 
            this.dtp_joining.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_joining.Location = new System.Drawing.Point(169, 241);
            this.dtp_joining.Name = "dtp_joining";
            this.dtp_joining.Size = new System.Drawing.Size(328, 22);
            this.dtp_joining.TabIndex = 7;
            // 
            // cmb_cabinType
            // 
            this.cmb_cabinType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_cabinType.FormattingEnabled = true;
            this.cmb_cabinType.Items.AddRange(new object[] {
            "General",
            "Single ",
            "Dual Delux",
            "V I P"});
            this.cmb_cabinType.Location = new System.Drawing.Point(168, 152);
            this.cmb_cabinType.Name = "cmb_cabinType";
            this.cmb_cabinType.Size = new System.Drawing.Size(329, 23);
            this.cmb_cabinType.TabIndex = 4;
            // 
            // lbl_title
            // 
            this.lbl_title.BackColor = System.Drawing.Color.Lime;
            this.lbl_title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_title.Font = new System.Drawing.Font("Monotype Corsiva", 33.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(90, 39);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(1183, 80);
            this.lbl_title.TabIndex = 130;
            this.lbl_title.Tag = "";
            this.lbl_title.Text = " Cabin  Information  Collection  /  Update  Cabin  Information  ";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_calculate
            // 
            this.btn_calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calculate.ForeColor = System.Drawing.Color.Black;
            this.btn_calculate.Location = new System.Drawing.Point(168, 365);
            this.btn_calculate.Name = "btn_calculate";
            this.btn_calculate.Size = new System.Drawing.Size(329, 40);
            this.btn_calculate.TabIndex = 11;
            this.btn_calculate.Text = "Calculate";
            this.btn_calculate.UseVisualStyleBackColor = true;
            this.btn_calculate.Click += new System.EventHandler(this.btn_calculate_Click);
            // 
            // txt_amoutOfStay
            // 
            this.txt_amoutOfStay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_amoutOfStay.Location = new System.Drawing.Point(168, 304);
            this.txt_amoutOfStay.Margin = new System.Windows.Forms.Padding(4);
            this.txt_amoutOfStay.Name = "txt_amoutOfStay";
            this.txt_amoutOfStay.Size = new System.Drawing.Size(328, 22);
            this.txt_amoutOfStay.TabIndex = 9;
            // 
            // txt_perDayCost
            // 
            this.txt_perDayCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_perDayCost.Location = new System.Drawing.Point(168, 336);
            this.txt_perDayCost.Margin = new System.Windows.Forms.Padding(4);
            this.txt_perDayCost.Name = "txt_perDayCost";
            this.txt_perDayCost.Size = new System.Drawing.Size(329, 22);
            this.txt_perDayCost.TabIndex = 10;
            // 
            // txt_totalCost
            // 
            this.txt_totalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_totalCost.Location = new System.Drawing.Point(168, 413);
            this.txt_totalCost.Margin = new System.Windows.Forms.Padding(4);
            this.txt_totalCost.Name = "txt_totalCost";
            this.txt_totalCost.Size = new System.Drawing.Size(329, 22);
            this.txt_totalCost.TabIndex = 12;
            // 
            // txt_location
            // 
            this.txt_location.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_location.Location = new System.Drawing.Point(168, 212);
            this.txt_location.Margin = new System.Windows.Forms.Padding(4);
            this.txt_location.Name = "txt_location";
            this.txt_location.Size = new System.Drawing.Size(329, 22);
            this.txt_location.TabIndex = 6;
            // 
            // txt_bedNumber
            // 
            this.txt_bedNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_bedNumber.Location = new System.Drawing.Point(168, 182);
            this.txt_bedNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txt_bedNumber.Name = "txt_bedNumber";
            this.txt_bedNumber.Size = new System.Drawing.Size(329, 22);
            this.txt_bedNumber.TabIndex = 5;
            // 
            // txt_cabinId
            // 
            this.txt_cabinId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cabinId.Location = new System.Drawing.Point(168, 123);
            this.txt_cabinId.Margin = new System.Windows.Forms.Padding(4);
            this.txt_cabinId.Name = "txt_cabinId";
            this.txt_cabinId.Size = new System.Drawing.Size(329, 22);
            this.txt_cabinId.TabIndex = 3;
            // 
            // lbl_totalCost
            // 
            this.lbl_totalCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_totalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totalCost.Location = new System.Drawing.Point(32, 413);
            this.lbl_totalCost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_totalCost.Name = "lbl_totalCost";
            this.lbl_totalCost.Size = new System.Drawing.Size(124, 22);
            this.lbl_totalCost.TabIndex = 121;
            this.lbl_totalCost.Text = "Total Cost";
            this.lbl_totalCost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_perDayCost
            // 
            this.lbl_perDayCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_perDayCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_perDayCost.Location = new System.Drawing.Point(32, 336);
            this.lbl_perDayCost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_perDayCost.Name = "lbl_perDayCost";
            this.lbl_perDayCost.Size = new System.Drawing.Size(124, 22);
            this.lbl_perDayCost.TabIndex = 120;
            this.lbl_perDayCost.Text = "Per day Cost";
            this.lbl_perDayCost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_amountOfstay
            // 
            this.lbl_amountOfstay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_amountOfstay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_amountOfstay.Location = new System.Drawing.Point(32, 306);
            this.lbl_amountOfstay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_amountOfstay.Name = "lbl_amountOfstay";
            this.lbl_amountOfstay.Size = new System.Drawing.Size(124, 22);
            this.lbl_amountOfstay.TabIndex = 119;
            this.lbl_amountOfstay.Text = "Amount of Stay";
            this.lbl_amountOfstay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_dateOfRelease
            // 
            this.lbl_dateOfRelease.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_dateOfRelease.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dateOfRelease.Location = new System.Drawing.Point(32, 274);
            this.lbl_dateOfRelease.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_dateOfRelease.Name = "lbl_dateOfRelease";
            this.lbl_dateOfRelease.Size = new System.Drawing.Size(124, 22);
            this.lbl_dateOfRelease.TabIndex = 118;
            this.lbl_dateOfRelease.Text = "Date of Release";
            this.lbl_dateOfRelease.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_bedNumber
            // 
            this.lbl_bedNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_bedNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bedNumber.Location = new System.Drawing.Point(32, 182);
            this.lbl_bedNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_bedNumber.Name = "lbl_bedNumber";
            this.lbl_bedNumber.Size = new System.Drawing.Size(124, 22);
            this.lbl_bedNumber.TabIndex = 115;
            this.lbl_bedNumber.Text = "Bed Number";
            this.lbl_bedNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_dateOfJoining
            // 
            this.lbl_dateOfJoining.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_dateOfJoining.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dateOfJoining.Location = new System.Drawing.Point(32, 242);
            this.lbl_dateOfJoining.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_dateOfJoining.Name = "lbl_dateOfJoining";
            this.lbl_dateOfJoining.Size = new System.Drawing.Size(124, 22);
            this.lbl_dateOfJoining.TabIndex = 117;
            this.lbl_dateOfJoining.Text = "Date of Joining";
            this.lbl_dateOfJoining.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_location
            // 
            this.lbl_location.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_location.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_location.Location = new System.Drawing.Point(32, 212);
            this.lbl_location.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_location.Name = "lbl_location";
            this.lbl_location.Size = new System.Drawing.Size(124, 22);
            this.lbl_location.TabIndex = 116;
            this.lbl_location.Text = "Location";
            this.lbl_location.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_cabinType
            // 
            this.lbl_cabinType.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_cabinType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cabinType.Location = new System.Drawing.Point(32, 152);
            this.lbl_cabinType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_cabinType.Name = "lbl_cabinType";
            this.lbl_cabinType.Size = new System.Drawing.Size(124, 22);
            this.lbl_cabinType.TabIndex = 114;
            this.lbl_cabinType.Text = "Cabin Type";
            this.lbl_cabinType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_cabinNo
            // 
            this.lbl_cabinNo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_cabinNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cabinNo.Location = new System.Drawing.Point(32, 123);
            this.lbl_cabinNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_cabinNo.Name = "lbl_cabinNo";
            this.lbl_cabinNo.Size = new System.Drawing.Size(124, 22);
            this.lbl_cabinNo.TabIndex = 113;
            this.lbl_cabinNo.Text = "Cabin No";
            this.lbl_cabinNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_search
            // 
            this.btn_search.ForeColor = System.Drawing.Color.Black;
            this.btn_search.Location = new System.Drawing.Point(296, 42);
            this.btn_search.Margin = new System.Windows.Forms.Padding(4);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(125, 28);
            this.btn_search.TabIndex = 1;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // lbl_patientId1
            // 
            this.lbl_patientId1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_patientId1.ForeColor = System.Drawing.Color.Black;
            this.lbl_patientId1.Location = new System.Drawing.Point(31, 42);
            this.lbl_patientId1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_patientId1.Name = "lbl_patientId1";
            this.lbl_patientId1.Size = new System.Drawing.Size(125, 26);
            this.lbl_patientId1.TabIndex = 5;
            this.lbl_patientId1.Text = "Patient ID";
            this.lbl_patientId1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_update
            // 
            this.btn_update.ForeColor = System.Drawing.Color.Black;
            this.btn_update.Location = new System.Drawing.Point(370, 443);
            this.btn_update.Margin = new System.Windows.Forms.Padding(4);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(125, 42);
            this.btn_update.TabIndex = 14;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.Color.Black;
            this.btn_back.Location = new System.Drawing.Point(105, 443);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(125, 42);
            this.btn_back.TabIndex = 15;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click_1);
            // 
            // gb_cabinInformation
            // 
            this.gb_cabinInformation.Controls.Add(this.btn_search);
            this.gb_cabinInformation.Controls.Add(this.dtp_release);
            this.gb_cabinInformation.Controls.Add(this.lbl_patientId1);
            this.gb_cabinInformation.Controls.Add(this.dtp_joining);
            this.gb_cabinInformation.Controls.Add(this.txt_patientId1);
            this.gb_cabinInformation.Controls.Add(this.cmb_cabinType);
            this.gb_cabinInformation.Controls.Add(this.btn_update);
            this.gb_cabinInformation.Controls.Add(this.btn_add);
            this.gb_cabinInformation.Controls.Add(this.btn_calculate);
            this.gb_cabinInformation.Controls.Add(this.btn_back);
            this.gb_cabinInformation.Controls.Add(this.txt_amoutOfStay);
            this.gb_cabinInformation.Controls.Add(this.txt_perDayCost);
            this.gb_cabinInformation.Controls.Add(this.txt_totalCost);
            this.gb_cabinInformation.Controls.Add(this.label1);
            this.gb_cabinInformation.Controls.Add(this.lbl_cabinNo);
            this.gb_cabinInformation.Controls.Add(this.txt_location);
            this.gb_cabinInformation.Controls.Add(this.lbl_cabinType);
            this.gb_cabinInformation.Controls.Add(this.txt_bedNumber);
            this.gb_cabinInformation.Controls.Add(this.lbl_location);
            this.gb_cabinInformation.Controls.Add(this.txt_patientCabinInfo);
            this.gb_cabinInformation.Controls.Add(this.txt_cabinId);
            this.gb_cabinInformation.Controls.Add(this.lbl_dateOfJoining);
            this.gb_cabinInformation.Controls.Add(this.lbl_bedNumber);
            this.gb_cabinInformation.Controls.Add(this.lbl_totalCost);
            this.gb_cabinInformation.Controls.Add(this.lbl_dateOfRelease);
            this.gb_cabinInformation.Controls.Add(this.lbl_perDayCost);
            this.gb_cabinInformation.Controls.Add(this.lbl_amountOfstay);
            this.gb_cabinInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_cabinInformation.ForeColor = System.Drawing.Color.Black;
            this.gb_cabinInformation.Location = new System.Drawing.Point(358, 147);
            this.gb_cabinInformation.Margin = new System.Windows.Forms.Padding(4);
            this.gb_cabinInformation.Name = "gb_cabinInformation";
            this.gb_cabinInformation.Padding = new System.Windows.Forms.Padding(4);
            this.gb_cabinInformation.Size = new System.Drawing.Size(600, 494);
            this.gb_cabinInformation.TabIndex = 0;
            this.gb_cabinInformation.TabStop = false;
            this.gb_cabinInformation.Text = "Cabin Information";
            // 
            // txt_patientId1
            // 
            this.txt_patientId1.Location = new System.Drawing.Point(164, 42);
            this.txt_patientId1.Margin = new System.Windows.Forms.Padding(4);
            this.txt_patientId1.Name = "txt_patientId1";
            this.txt_patientId1.Size = new System.Drawing.Size(125, 26);
            this.txt_patientId1.TabIndex = 0;
            // 
            // btn_add
            // 
            this.btn_add.ForeColor = System.Drawing.Color.Black;
            this.btn_add.Location = new System.Drawing.Point(237, 443);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(125, 42);
            this.btn_add.TabIndex = 13;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 93);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 22);
            this.label1.TabIndex = 113;
            this.label1.Text = "Patient Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_patientCabinInfo
            // 
            this.txt_patientCabinInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_patientCabinInfo.Location = new System.Drawing.Point(168, 93);
            this.txt_patientCabinInfo.Margin = new System.Windows.Forms.Padding(4);
            this.txt_patientCabinInfo.Name = "txt_patientCabinInfo";
            this.txt_patientCabinInfo.Size = new System.Drawing.Size(329, 22);
            this.txt_patientCabinInfo.TabIndex = 2;
            // 
            // cabinInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(1354, 733);
            this.Controls.Add(this.gb_cabinInformation);
            this.Controls.Add(this.lbl_title);
            this.Name = "cabinInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cabin Information";
            this.Load += new System.EventHandler(this.cabinInfo_Load);
            this.gb_cabinInformation.ResumeLayout(false);
            this.gb_cabinInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_release;
        private System.Windows.Forms.DateTimePicker dtp_joining;
        private System.Windows.Forms.ComboBox cmb_cabinType;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Button btn_calculate;
        private System.Windows.Forms.TextBox txt_amoutOfStay;
        private System.Windows.Forms.TextBox txt_perDayCost;
        private System.Windows.Forms.TextBox txt_totalCost;
        private System.Windows.Forms.TextBox txt_location;
        private System.Windows.Forms.TextBox txt_bedNumber;
        private System.Windows.Forms.TextBox txt_cabinId;
        private System.Windows.Forms.Label lbl_totalCost;
        private System.Windows.Forms.Label lbl_perDayCost;
        private System.Windows.Forms.Label lbl_amountOfstay;
        private System.Windows.Forms.Label lbl_dateOfRelease;
        private System.Windows.Forms.Label lbl_bedNumber;
        private System.Windows.Forms.Label lbl_dateOfJoining;
        private System.Windows.Forms.Label lbl_location;
        private System.Windows.Forms.Label lbl_cabinType;
        private System.Windows.Forms.Label lbl_cabinNo;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label lbl_patientId1;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.GroupBox gb_cabinInformation;
        private System.Windows.Forms.TextBox txt_patientId1;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_patientCabinInfo;
    }
}