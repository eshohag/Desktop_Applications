namespace Final_Project
{
    partial class payment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(payment));
            this.lbl_advancePaid = new System.Windows.Forms.Label();
            this.btn_print = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_advancePaid = new System.Windows.Forms.TextBox();
            this.txt_patientId2 = new System.Windows.Forms.TextBox();
            this.lbl_patientId2 = new System.Windows.Forms.Label();
            this.txt_discount = new System.Windows.Forms.TextBox();
            this.lbl_discount = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_Calculate2 = new System.Windows.Forms.Button();
            this.btn_Calculate3 = new System.Windows.Forms.Button();
            this.txt_due = new System.Windows.Forms.TextBox();
            this.lbl_due = new System.Windows.Forms.Label();
            this.lbl_title = new System.Windows.Forms.Label();
            this.txt_netPayment = new System.Windows.Forms.TextBox();
            this.txt_totalCost = new System.Windows.Forms.TextBox();
            this.txt_diagnosesCost = new System.Windows.Forms.TextBox();
            this.txt_instrumentalCost = new System.Windows.Forms.TextBox();
            this.txt_clinicalCost = new System.Windows.Forms.TextBox();
            this.txt_cabinCost = new System.Windows.Forms.TextBox();
            this.txt_treatmentCost = new System.Windows.Forms.TextBox();
            this.txt_patientName = new System.Windows.Forms.TextBox();
            this.lbl_netPayment = new System.Windows.Forms.Label();
            this.lbl_totalCost = new System.Windows.Forms.Label();
            this.lbl_diagnosesCost = new System.Windows.Forms.Label();
            this.lbl_instrumentalCost = new System.Windows.Forms.Label();
            this.lbl_clinicalCost = new System.Windows.Forms.Label();
            this.lbl_cabinCost = new System.Windows.Forms.Label();
            this.lbl_treatmentCost = new System.Windows.Forms.Label();
            this.lbl_patientName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_advancePaid
            // 
            this.lbl_advancePaid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_advancePaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_advancePaid.Location = new System.Drawing.Point(76, 356);
            this.lbl_advancePaid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_advancePaid.Name = "lbl_advancePaid";
            this.lbl_advancePaid.Size = new System.Drawing.Size(130, 22);
            this.lbl_advancePaid.TabIndex = 156;
            this.lbl_advancePaid.Text = "Advance Paid";
            this.lbl_advancePaid.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_print
            // 
            this.btn_print.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_print.ForeColor = System.Drawing.Color.Black;
            this.btn_print.Location = new System.Drawing.Point(455, 415);
            this.btn_print.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(93, 40);
            this.btn_print.TabIndex = 17;
            this.btn_print.Text = "Print";
            this.btn_print.UseVisualStyleBackColor = true;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.Color.Black;
            this.btn_search.Location = new System.Drawing.Point(465, 37);
            this.btn_search.Margin = new System.Windows.Forms.Padding(4);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(83, 28);
            this.btn_search.TabIndex = 2;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_advancePaid
            // 
            this.txt_advancePaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_advancePaid.Location = new System.Drawing.Point(219, 356);
            this.txt_advancePaid.Margin = new System.Windows.Forms.Padding(4);
            this.txt_advancePaid.Name = "txt_advancePaid";
            this.txt_advancePaid.Size = new System.Drawing.Size(329, 22);
            this.txt_advancePaid.TabIndex = 13;
            // 
            // txt_patientId2
            // 
            this.txt_patientId2.ForeColor = System.Drawing.Color.Black;
            this.txt_patientId2.Location = new System.Drawing.Point(219, 37);
            this.txt_patientId2.Margin = new System.Windows.Forms.Padding(4);
            this.txt_patientId2.Multiline = true;
            this.txt_patientId2.Name = "txt_patientId2";
            this.txt_patientId2.Size = new System.Drawing.Size(238, 25);
            this.txt_patientId2.TabIndex = 1;
            // 
            // lbl_patientId2
            // 
            this.lbl_patientId2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_patientId2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_patientId2.ForeColor = System.Drawing.Color.Black;
            this.lbl_patientId2.Location = new System.Drawing.Point(76, 37);
            this.lbl_patientId2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_patientId2.Name = "lbl_patientId2";
            this.lbl_patientId2.Size = new System.Drawing.Size(130, 25);
            this.lbl_patientId2.TabIndex = 120;
            this.lbl_patientId2.Text = "Patient ID";
            this.lbl_patientId2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_discount
            // 
            this.txt_discount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_discount.Location = new System.Drawing.Point(219, 294);
            this.txt_discount.Margin = new System.Windows.Forms.Padding(4);
            this.txt_discount.Name = "txt_discount";
            this.txt_discount.Size = new System.Drawing.Size(228, 22);
            this.txt_discount.TabIndex = 10;
            // 
            // lbl_discount
            // 
            this.lbl_discount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_discount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_discount.Location = new System.Drawing.Point(76, 294);
            this.lbl_discount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_discount.Name = "lbl_discount";
            this.lbl_discount.Size = new System.Drawing.Size(130, 22);
            this.lbl_discount.TabIndex = 154;
            this.lbl_discount.Text = "Discount ";
            this.lbl_discount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.Color.Black;
            this.btn_back.Location = new System.Drawing.Point(219, 415);
            this.btn_back.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(107, 40);
            this.btn_back.TabIndex = 18;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.Color.Black;
            this.btn_add.Location = new System.Drawing.Point(347, 415);
            this.btn_add.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(100, 40);
            this.btn_add.TabIndex = 16;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_Calculate2
            // 
            this.btn_Calculate2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Calculate2.ForeColor = System.Drawing.Color.Black;
            this.btn_Calculate2.Location = new System.Drawing.Point(455, 323);
            this.btn_Calculate2.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Calculate2.Name = "btn_Calculate2";
            this.btn_Calculate2.Size = new System.Drawing.Size(93, 27);
            this.btn_Calculate2.TabIndex = 11;
            this.btn_Calculate2.Text = "Calculate";
            this.btn_Calculate2.UseVisualStyleBackColor = true;
            this.btn_Calculate2.Click += new System.EventHandler(this.btn_Calculate2_Click);
            // 
            // btn_Calculate3
            // 
            this.btn_Calculate3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Calculate3.ForeColor = System.Drawing.Color.Black;
            this.btn_Calculate3.Location = new System.Drawing.Point(455, 383);
            this.btn_Calculate3.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Calculate3.Name = "btn_Calculate3";
            this.btn_Calculate3.Size = new System.Drawing.Size(93, 27);
            this.btn_Calculate3.TabIndex = 14;
            this.btn_Calculate3.Text = "Calculate";
            this.btn_Calculate3.UseVisualStyleBackColor = true;
            this.btn_Calculate3.Click += new System.EventHandler(this.btn_Calculate3_Click);
            // 
            // txt_due
            // 
            this.txt_due.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_due.Location = new System.Drawing.Point(219, 386);
            this.txt_due.Margin = new System.Windows.Forms.Padding(4);
            this.txt_due.Name = "txt_due";
            this.txt_due.Size = new System.Drawing.Size(228, 22);
            this.txt_due.TabIndex = 15;
            // 
            // lbl_due
            // 
            this.lbl_due.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_due.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_due.Location = new System.Drawing.Point(76, 386);
            this.lbl_due.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_due.Name = "lbl_due";
            this.lbl_due.Size = new System.Drawing.Size(130, 22);
            this.lbl_due.TabIndex = 148;
            this.lbl_due.Text = "Due ";
            this.lbl_due.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_title
            // 
            this.lbl_title.BackColor = System.Drawing.Color.Olive;
            this.lbl_title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_title.Font = new System.Drawing.Font("Monotype Corsiva", 33.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_title.Location = new System.Drawing.Point(90, 39);
            this.lbl_title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(1183, 92);
            this.lbl_title.TabIndex = 147;
            this.lbl_title.Tag = "";
            this.lbl_title.Text = " Payment  And  Delivery Receipt";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_netPayment
            // 
            this.txt_netPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_netPayment.Location = new System.Drawing.Point(219, 326);
            this.txt_netPayment.Margin = new System.Windows.Forms.Padding(4);
            this.txt_netPayment.Name = "txt_netPayment";
            this.txt_netPayment.Size = new System.Drawing.Size(228, 22);
            this.txt_netPayment.TabIndex = 12;
            // 
            // txt_totalCost
            // 
            this.txt_totalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_totalCost.Location = new System.Drawing.Point(219, 264);
            this.txt_totalCost.Margin = new System.Windows.Forms.Padding(4);
            this.txt_totalCost.Name = "txt_totalCost";
            this.txt_totalCost.Size = new System.Drawing.Size(329, 22);
            this.txt_totalCost.TabIndex = 9;
            // 
            // txt_diagnosesCost
            // 
            this.txt_diagnosesCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_diagnosesCost.Location = new System.Drawing.Point(219, 234);
            this.txt_diagnosesCost.Margin = new System.Windows.Forms.Padding(4);
            this.txt_diagnosesCost.Name = "txt_diagnosesCost";
            this.txt_diagnosesCost.Size = new System.Drawing.Size(329, 22);
            this.txt_diagnosesCost.TabIndex = 8;
            // 
            // txt_instrumentalCost
            // 
            this.txt_instrumentalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_instrumentalCost.Location = new System.Drawing.Point(219, 204);
            this.txt_instrumentalCost.Margin = new System.Windows.Forms.Padding(4);
            this.txt_instrumentalCost.Name = "txt_instrumentalCost";
            this.txt_instrumentalCost.Size = new System.Drawing.Size(329, 22);
            this.txt_instrumentalCost.TabIndex = 7;
            // 
            // txt_clinicalCost
            // 
            this.txt_clinicalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_clinicalCost.Location = new System.Drawing.Point(219, 174);
            this.txt_clinicalCost.Margin = new System.Windows.Forms.Padding(4);
            this.txt_clinicalCost.Name = "txt_clinicalCost";
            this.txt_clinicalCost.Size = new System.Drawing.Size(329, 22);
            this.txt_clinicalCost.TabIndex = 6;
            // 
            // txt_cabinCost
            // 
            this.txt_cabinCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cabinCost.Location = new System.Drawing.Point(219, 144);
            this.txt_cabinCost.Margin = new System.Windows.Forms.Padding(4);
            this.txt_cabinCost.Name = "txt_cabinCost";
            this.txt_cabinCost.Size = new System.Drawing.Size(329, 22);
            this.txt_cabinCost.TabIndex = 5;
            // 
            // txt_treatmentCost
            // 
            this.txt_treatmentCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_treatmentCost.Location = new System.Drawing.Point(219, 114);
            this.txt_treatmentCost.Margin = new System.Windows.Forms.Padding(4);
            this.txt_treatmentCost.Name = "txt_treatmentCost";
            this.txt_treatmentCost.Size = new System.Drawing.Size(329, 22);
            this.txt_treatmentCost.TabIndex = 4;
            // 
            // txt_patientName
            // 
            this.txt_patientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_patientName.Location = new System.Drawing.Point(219, 84);
            this.txt_patientName.Margin = new System.Windows.Forms.Padding(4);
            this.txt_patientName.Name = "txt_patientName";
            this.txt_patientName.Size = new System.Drawing.Size(329, 22);
            this.txt_patientName.TabIndex = 3;
            // 
            // lbl_netPayment
            // 
            this.lbl_netPayment.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_netPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_netPayment.Location = new System.Drawing.Point(76, 326);
            this.lbl_netPayment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_netPayment.Name = "lbl_netPayment";
            this.lbl_netPayment.Size = new System.Drawing.Size(130, 22);
            this.lbl_netPayment.TabIndex = 137;
            this.lbl_netPayment.Text = "Net Payment";
            this.lbl_netPayment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_totalCost
            // 
            this.lbl_totalCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_totalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totalCost.Location = new System.Drawing.Point(76, 264);
            this.lbl_totalCost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_totalCost.Name = "lbl_totalCost";
            this.lbl_totalCost.Size = new System.Drawing.Size(130, 22);
            this.lbl_totalCost.TabIndex = 136;
            this.lbl_totalCost.Text = "Total Cost";
            this.lbl_totalCost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_diagnosesCost
            // 
            this.lbl_diagnosesCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_diagnosesCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_diagnosesCost.Location = new System.Drawing.Point(76, 234);
            this.lbl_diagnosesCost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_diagnosesCost.Name = "lbl_diagnosesCost";
            this.lbl_diagnosesCost.Size = new System.Drawing.Size(130, 22);
            this.lbl_diagnosesCost.TabIndex = 135;
            this.lbl_diagnosesCost.Text = "Diagnoses Cost";
            this.lbl_diagnosesCost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_instrumentalCost
            // 
            this.lbl_instrumentalCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_instrumentalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_instrumentalCost.Location = new System.Drawing.Point(76, 204);
            this.lbl_instrumentalCost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_instrumentalCost.Name = "lbl_instrumentalCost";
            this.lbl_instrumentalCost.Size = new System.Drawing.Size(130, 22);
            this.lbl_instrumentalCost.TabIndex = 134;
            this.lbl_instrumentalCost.Text = "Instrumental Cost";
            this.lbl_instrumentalCost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_clinicalCost
            // 
            this.lbl_clinicalCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_clinicalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_clinicalCost.Location = new System.Drawing.Point(76, 174);
            this.lbl_clinicalCost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_clinicalCost.Name = "lbl_clinicalCost";
            this.lbl_clinicalCost.Size = new System.Drawing.Size(130, 22);
            this.lbl_clinicalCost.TabIndex = 133;
            this.lbl_clinicalCost.Text = "Clinical Cost";
            this.lbl_clinicalCost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_cabinCost
            // 
            this.lbl_cabinCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_cabinCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cabinCost.Location = new System.Drawing.Point(76, 144);
            this.lbl_cabinCost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_cabinCost.Name = "lbl_cabinCost";
            this.lbl_cabinCost.Size = new System.Drawing.Size(130, 22);
            this.lbl_cabinCost.TabIndex = 132;
            this.lbl_cabinCost.Text = "Cabin Cost";
            this.lbl_cabinCost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_treatmentCost
            // 
            this.lbl_treatmentCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_treatmentCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_treatmentCost.Location = new System.Drawing.Point(76, 114);
            this.lbl_treatmentCost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_treatmentCost.Name = "lbl_treatmentCost";
            this.lbl_treatmentCost.Size = new System.Drawing.Size(130, 22);
            this.lbl_treatmentCost.TabIndex = 131;
            this.lbl_treatmentCost.Text = "Treatment Cost";
            this.lbl_treatmentCost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_patientName
            // 
            this.lbl_patientName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_patientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_patientName.Location = new System.Drawing.Point(76, 84);
            this.lbl_patientName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_patientName.Name = "lbl_patientName";
            this.lbl_patientName.Size = new System.Drawing.Size(130, 22);
            this.lbl_patientName.TabIndex = 130;
            this.lbl_patientName.Text = "Patient Name";
            this.lbl_patientName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_patientName);
            this.groupBox1.Controls.Add(this.btn_search);
            this.groupBox1.Controls.Add(this.txt_patientId2);
            this.groupBox1.Controls.Add(this.lbl_patientName);
            this.groupBox1.Controls.Add(this.lbl_patientId2);
            this.groupBox1.Controls.Add(this.lbl_advancePaid);
            this.groupBox1.Controls.Add(this.lbl_treatmentCost);
            this.groupBox1.Controls.Add(this.lbl_cabinCost);
            this.groupBox1.Controls.Add(this.btn_print);
            this.groupBox1.Controls.Add(this.lbl_clinicalCost);
            this.groupBox1.Controls.Add(this.lbl_instrumentalCost);
            this.groupBox1.Controls.Add(this.btn_back);
            this.groupBox1.Controls.Add(this.lbl_diagnosesCost);
            this.groupBox1.Controls.Add(this.txt_advancePaid);
            this.groupBox1.Controls.Add(this.lbl_totalCost);
            this.groupBox1.Controls.Add(this.txt_discount);
            this.groupBox1.Controls.Add(this.lbl_netPayment);
            this.groupBox1.Controls.Add(this.lbl_discount);
            this.groupBox1.Controls.Add(this.txt_treatmentCost);
            this.groupBox1.Controls.Add(this.btn_Calculate2);
            this.groupBox1.Controls.Add(this.txt_cabinCost);
            this.groupBox1.Controls.Add(this.btn_add);
            this.groupBox1.Controls.Add(this.txt_clinicalCost);
            this.groupBox1.Controls.Add(this.txt_instrumentalCost);
            this.groupBox1.Controls.Add(this.btn_Calculate3);
            this.groupBox1.Controls.Add(this.txt_diagnosesCost);
            this.groupBox1.Controls.Add(this.txt_due);
            this.groupBox1.Controls.Add(this.txt_totalCost);
            this.groupBox1.Controls.Add(this.lbl_due);
            this.groupBox1.Controls.Add(this.txt_netPayment);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(355, 150);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(630, 483);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Payment Section";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(451, 294);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 20);
            this.label1.TabIndex = 158;
            this.label1.Text = "%";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // payment
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Document;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(1354, 733);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_title);
            this.Name = "payment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.payment_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_advancePaid;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_advancePaid;
        private System.Windows.Forms.TextBox txt_patientId2;
        private System.Windows.Forms.Label lbl_patientId2;
        private System.Windows.Forms.TextBox txt_discount;
        private System.Windows.Forms.Label lbl_discount;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_Calculate2;
        private System.Windows.Forms.Button btn_Calculate3;
        private System.Windows.Forms.TextBox txt_due;
        private System.Windows.Forms.Label lbl_due;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.TextBox txt_netPayment;
        private System.Windows.Forms.TextBox txt_totalCost;
        private System.Windows.Forms.TextBox txt_diagnosesCost;
        private System.Windows.Forms.TextBox txt_instrumentalCost;
        private System.Windows.Forms.TextBox txt_clinicalCost;
        private System.Windows.Forms.TextBox txt_cabinCost;
        private System.Windows.Forms.TextBox txt_treatmentCost;
        private System.Windows.Forms.TextBox txt_patientName;
        private System.Windows.Forms.Label lbl_netPayment;
        private System.Windows.Forms.Label lbl_totalCost;
        private System.Windows.Forms.Label lbl_diagnosesCost;
        private System.Windows.Forms.Label lbl_instrumentalCost;
        private System.Windows.Forms.Label lbl_clinicalCost;
        private System.Windows.Forms.Label lbl_cabinCost;
        private System.Windows.Forms.Label lbl_treatmentCost;
        private System.Windows.Forms.Label lbl_patientName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}