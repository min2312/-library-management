namespace CK_Final
{
    partial class MainForm
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
            this.cbb_Book = new System.Windows.Forms.ComboBox();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.but_Search = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.but_Add = new System.Windows.Forms.Button();
            this.but_Edit = new System.Windows.Forms.Button();
            this.but_Del = new System.Windows.Forms.Button();
            this.but_Sort = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbb_Book
            // 
            this.cbb_Book.FormattingEnabled = true;
            this.cbb_Book.Location = new System.Drawing.Point(107, 22);
            this.cbb_Book.Name = "cbb_Book";
            this.cbb_Book.Size = new System.Drawing.Size(150, 21);
            this.cbb_Book.TabIndex = 0;
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(385, 23);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(116, 20);
            this.txt_Search.TabIndex = 1;
            // 
            // but_Search
            // 
            this.but_Search.Location = new System.Drawing.Point(540, 23);
            this.but_Search.Name = "but_Search";
            this.but_Search.Size = new System.Drawing.Size(75, 23);
            this.but_Search.TabIndex = 2;
            this.but_Search.Text = "Search";
            this.but_Search.UseVisualStyleBackColor = true;
            this.but_Search.Click += new System.EventHandler(this.but_Search_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(732, 174);
            this.dataGridView1.TabIndex = 3;
            // 
            // but_Add
            // 
            this.but_Add.Location = new System.Drawing.Point(55, 288);
            this.but_Add.Name = "but_Add";
            this.but_Add.Size = new System.Drawing.Size(60, 23);
            this.but_Add.TabIndex = 4;
            this.but_Add.Text = "Add";
            this.but_Add.UseVisualStyleBackColor = true;
            this.but_Add.Click += new System.EventHandler(this.but_Add_Click);
            // 
            // but_Edit
            // 
            this.but_Edit.Location = new System.Drawing.Point(144, 288);
            this.but_Edit.Name = "but_Edit";
            this.but_Edit.Size = new System.Drawing.Size(59, 23);
            this.but_Edit.TabIndex = 5;
            this.but_Edit.Text = "Edit";
            this.but_Edit.UseVisualStyleBackColor = true;
            this.but_Edit.Click += new System.EventHandler(this.but_Edit_Click);
            // 
            // but_Del
            // 
            this.but_Del.Location = new System.Drawing.Point(233, 288);
            this.but_Del.Name = "but_Del";
            this.but_Del.Size = new System.Drawing.Size(58, 23);
            this.but_Del.TabIndex = 6;
            this.but_Del.Text = "Delete";
            this.but_Del.UseVisualStyleBackColor = true;
            this.but_Del.Click += new System.EventHandler(this.but_Del_Click);
            // 
            // but_Sort
            // 
            this.but_Sort.Location = new System.Drawing.Point(322, 288);
            this.but_Sort.Name = "but_Sort";
            this.but_Sort.Size = new System.Drawing.Size(59, 23);
            this.but_Sort.TabIndex = 7;
            this.but_Sort.Text = "Sort";
            this.but_Sort.UseVisualStyleBackColor = true;
            this.but_Sort.Click += new System.EventHandler(this.but_Sort_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(416, 288);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(94, 21);
            this.comboBox2.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tên Sách";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.but_Sort);
            this.Controls.Add(this.but_Del);
            this.Controls.Add(this.but_Edit);
            this.Controls.Add(this.but_Add);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.but_Search);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.cbb_Book);
            this.Name = "MainForm";
            this.Text = "Main Form";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbb_Book;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Button but_Search;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button but_Add;
        private System.Windows.Forms.Button but_Edit;
        private System.Windows.Forms.Button but_Del;
        private System.Windows.Forms.Button but_Sort;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
    }
}

