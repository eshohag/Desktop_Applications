namespace BookApp
{
    partial class BookInfoUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookInfoUI));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addButton = new System.Windows.Forms.Button();
            this.bookDetailsAddTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.isbnAddtextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.findButton = new System.Windows.Forms.Button();
            this.bookDetailsSearchTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.isbnSearchTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addButton);
            this.groupBox1.Controls.Add(this.bookDetailsAddTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.isbnAddtextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(17, 19);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(547, 188);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Book Info";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(399, 114);
            this.addButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(100, 33);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // bookDetailsAddTextBox
            // 
            this.bookDetailsAddTextBox.Location = new System.Drawing.Point(179, 81);
            this.bookDetailsAddTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bookDetailsAddTextBox.Multiline = true;
            this.bookDetailsAddTextBox.Name = "bookDetailsAddTextBox";
            this.bookDetailsAddTextBox.Size = new System.Drawing.Size(211, 66);
            this.bookDetailsAddTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Book Details";
            // 
            // isbnAddtextBox
            // 
            this.isbnAddtextBox.Location = new System.Drawing.Point(179, 43);
            this.isbnAddtextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.isbnAddtextBox.Name = "isbnAddtextBox";
            this.isbnAddtextBox.Size = new System.Drawing.Size(211, 25);
            this.isbnAddtextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "ISBN";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.findButton);
            this.groupBox2.Controls.Add(this.bookDetailsSearchTextBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.isbnSearchTextBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(17, 217);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(547, 188);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search Book";
            // 
            // findButton
            // 
            this.findButton.Location = new System.Drawing.Point(399, 40);
            this.findButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(100, 33);
            this.findButton.TabIndex = 1;
            this.findButton.Text = "Find";
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // bookDetailsSearchTextBox
            // 
            this.bookDetailsSearchTextBox.Location = new System.Drawing.Point(179, 81);
            this.bookDetailsSearchTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bookDetailsSearchTextBox.Multiline = true;
            this.bookDetailsSearchTextBox.Name = "bookDetailsSearchTextBox";
            this.bookDetailsSearchTextBox.Size = new System.Drawing.Size(211, 66);
            this.bookDetailsSearchTextBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 85);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Book Details";
            // 
            // isbnSearchTextBox
            // 
            this.isbnSearchTextBox.Location = new System.Drawing.Point(179, 43);
            this.isbnSearchTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.isbnSearchTextBox.Name = "isbnSearchTextBox";
            this.isbnSearchTextBox.Size = new System.Drawing.Size(211, 25);
            this.isbnSearchTextBox.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(96, 47);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "ISBN";
            // 
            // BookInfoUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 432);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BookInfoUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookInfoUI";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox bookDetailsAddTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox isbnAddtextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.TextBox bookDetailsSearchTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox isbnSearchTextBox;
        private System.Windows.Forms.Label label4;
    }
}

