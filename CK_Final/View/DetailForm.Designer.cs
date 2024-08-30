namespace CK_Final.View
{
    partial class DetailForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_MSSV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Rb_Female = new System.Windows.Forms.RadioButton();
            this.Rb_Male = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.but_Ok = new System.Windows.Forms.Button();
            this.but_Cancel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Cbb_Book = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp_NS = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "MSSV";
            // 
            // txt_MSSV
            // 
            this.txt_MSSV.Location = new System.Drawing.Point(96, 23);
            this.txt_MSSV.Name = "txt_MSSV";
            this.txt_MSSV.Size = new System.Drawing.Size(132, 20);
            this.txt_MSSV.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(96, 78);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(132, 20);
            this.txt_Name.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Rb_Female);
            this.groupBox1.Controls.Add(this.Rb_Male);
            this.groupBox1.Location = new System.Drawing.Point(35, 192);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gender";
            // 
            // Rb_Female
            // 
            this.Rb_Female.AutoSize = true;
            this.Rb_Female.Location = new System.Drawing.Point(104, 42);
            this.Rb_Female.Name = "Rb_Female";
            this.Rb_Female.Size = new System.Drawing.Size(59, 17);
            this.Rb_Female.TabIndex = 7;
            this.Rb_Female.TabStop = true;
            this.Rb_Female.Text = "Female";
            this.Rb_Female.UseVisualStyleBackColor = true;
            // 
            // Rb_Male
            // 
            this.Rb_Male.AutoSize = true;
            this.Rb_Male.Location = new System.Drawing.Point(19, 42);
            this.Rb_Male.Name = "Rb_Male";
            this.Rb_Male.Size = new System.Drawing.Size(48, 17);
            this.Rb_Male.TabIndex = 6;
            this.Rb_Male.TabStop = true;
            this.Rb_Male.Text = "Male";
            this.Rb_Male.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(424, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Ngày Mượn";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(517, 135);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 24;
            // 
            // but_Ok
            // 
            this.but_Ok.Location = new System.Drawing.Point(185, 312);
            this.but_Ok.Name = "but_Ok";
            this.but_Ok.Size = new System.Drawing.Size(75, 23);
            this.but_Ok.TabIndex = 25;
            this.but_Ok.Text = "OK";
            this.but_Ok.UseVisualStyleBackColor = true;
            this.but_Ok.Click += new System.EventHandler(this.but_Ok_Click);
            // 
            // but_Cancel
            // 
            this.but_Cancel.Location = new System.Drawing.Point(438, 312);
            this.but_Cancel.Name = "but_Cancel";
            this.but_Cancel.Size = new System.Drawing.Size(75, 23);
            this.but_Cancel.TabIndex = 26;
            this.but_Cancel.Text = "Cancel";
            this.but_Cancel.UseVisualStyleBackColor = true;
            this.but_Cancel.Click += new System.EventHandler(this.but_Cancel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(424, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Tên Sách";
            // 
            // Cbb_Book
            // 
            this.Cbb_Book.FormattingEnabled = true;
            this.Cbb_Book.Location = new System.Drawing.Point(517, 20);
            this.Cbb_Book.Name = "Cbb_Book";
            this.Cbb_Book.Size = new System.Drawing.Size(200, 21);
            this.Cbb_Book.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Năm Sinh";
            // 
            // dtp_NS
            // 
            this.dtp_NS.Location = new System.Drawing.Point(96, 143);
            this.dtp_NS.Name = "dtp_NS";
            this.dtp_NS.Size = new System.Drawing.Size(198, 20);
            this.dtp_NS.TabIndex = 29;
            // 
            // DetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtp_NS);
            this.Controls.Add(this.Cbb_Book);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.but_Cancel);
            this.Controls.Add(this.but_Ok);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_MSSV);
            this.Controls.Add(this.label1);
            this.Name = "DetailForm";
            this.Text = "DetailForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_MSSV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Rb_Female;
        private System.Windows.Forms.RadioButton Rb_Male;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button but_Ok;
        private System.Windows.Forms.Button but_Cancel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Cbb_Book;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtp_NS;
    }
}