namespace Bai09
{
    partial class Form9
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.luu = new System.Windows.Forms.Button();
            this.msv = new System.Windows.Forms.TextBox();
            this.hoten = new System.Windows.Forms.TextBox();
            this.chuyennganh = new System.Windows.Forms.ComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.xoa = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gt_Nu = new System.Windows.Forms.CheckBox();
            this.gt_Nam = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(160, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Sinh Viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(205, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ Tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(160, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Chuyên Ngành";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(189, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giới Tính";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(91, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(230, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Chọn Các Môn Học Tham Gia";
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView.Location = new System.Drawing.Point(11, 337);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 25;
            this.dataGridView.Size = new System.Drawing.Size(776, 241);
            this.dataGridView.TabIndex = 5;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "MSSV";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Họ tên";
            this.Column2.Name = "Column2";
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Chuyên ngành";
            this.Column3.Name = "Column3";
            this.Column3.Width = 300;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Giới tính";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Số môn";
            this.Column5.Name = "Column5";
            // 
            // luu
            // 
            this.luu.Location = new System.Drawing.Point(248, 278);
            this.luu.Name = "luu";
            this.luu.Size = new System.Drawing.Size(121, 41);
            this.luu.TabIndex = 6;
            this.luu.Text = "Lưu Thông Tin";
            this.luu.UseVisualStyleBackColor = true;
            this.luu.Click += new System.EventHandler(this.luu_Click);
            // 
            // msv
            // 
            this.msv.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.msv.Location = new System.Drawing.Point(290, 22);
            this.msv.Name = "msv";
            this.msv.Size = new System.Drawing.Size(321, 29);
            this.msv.TabIndex = 8;
            // 
            // hoten
            // 
            this.hoten.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hoten.Location = new System.Drawing.Point(290, 58);
            this.hoten.Name = "hoten";
            this.hoten.Size = new System.Drawing.Size(321, 29);
            this.hoten.TabIndex = 9;
            // 
            // chuyennganh
            // 
            this.chuyennganh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chuyennganh.FormattingEnabled = true;
            this.chuyennganh.Items.AddRange(new object[] {
            "Hệ thống thông tin",
            "Công nghệ phần mềm",
            "Khoa học máy tính"});
            this.chuyennganh.Location = new System.Drawing.Point(290, 97);
            this.chuyennganh.Name = "chuyennganh";
            this.chuyennganh.Size = new System.Drawing.Size(321, 29);
            this.chuyennganh.TabIndex = 12;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(91, 187);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(255, 85);
            this.richTextBox1.TabIndex = 13;
            this.richTextBox1.Text = "Cơ Sở Dữ Liệu\nCơ Sở DL NC\nPTTK Hệ Thống Thông Tin\n";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(401, 187);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(235, 85);
            this.richTextBox2.TabIndex = 14;
            this.richTextBox2.Text = "";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(352, 193);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(43, 35);
            this.button3.TabIndex = 15;
            this.button3.Text = ">";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(352, 234);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(43, 38);
            this.button4.TabIndex = 16;
            this.button4.Text = "<";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // xoa
            // 
            this.xoa.Location = new System.Drawing.Point(387, 278);
            this.xoa.Name = "xoa";
            this.xoa.Size = new System.Drawing.Size(131, 39);
            this.xoa.TabIndex = 17;
            this.xoa.Text = "Xoá Chọn";
            this.xoa.UseVisualStyleBackColor = true;
            this.xoa.Click += new System.EventHandler(this.xoa_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gt_Nu);
            this.groupBox1.Controls.Add(this.gt_Nam);
            this.groupBox1.Controls.Add(this.xoa);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.richTextBox2);
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Controls.Add(this.chuyennganh);
            this.groupBox1.Controls.Add(this.hoten);
            this.groupBox1.Controls.Add(this.msv);
            this.groupBox1.Controls.Add(this.luu);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(16, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(771, 325);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Sinh Viên";
            // 
            // gt_Nu
            // 
            this.gt_Nu.AutoSize = true;
            this.gt_Nu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gt_Nu.Location = new System.Drawing.Point(387, 132);
            this.gt_Nu.Name = "gt_Nu";
            this.gt_Nu.Size = new System.Drawing.Size(50, 25);
            this.gt_Nu.TabIndex = 19;
            this.gt_Nu.Text = "Nữ";
            this.gt_Nu.UseVisualStyleBackColor = true;
            // 
            // gt_Nam
            // 
            this.gt_Nam.AutoSize = true;
            this.gt_Nam.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gt_Nam.Location = new System.Drawing.Point(290, 132);
            this.gt_Nam.Name = "gt_Nam";
            this.gt_Nam.Size = new System.Drawing.Size(63, 25);
            this.gt_Nam.TabIndex = 18;
            this.gt_Nam.Text = "Nam";
            this.gt_Nam.UseVisualStyleBackColor = true;
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 590);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView);
            this.Name = "Form9";
            this.Text = "Form9";
            this.Load += new System.EventHandler(this.Form9_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button luu;
        private System.Windows.Forms.TextBox msv;
        private System.Windows.Forms.TextBox hoten;
        private System.Windows.Forms.ComboBox chuyennganh;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button xoa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox gt_Nu;
        private System.Windows.Forms.CheckBox gt_Nam;
    }
}