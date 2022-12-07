namespace Bai08
{
    partial class Form8
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
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sotaikhoan = new System.Windows.Forms.TextBox();
            this.tenkh = new System.Windows.Forms.TextBox();
            this.diachi = new System.Windows.Forms.TextBox();
            this.sotien = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.them = new System.Windows.Forms.Button();
            this.xoa = new System.Windows.Forms.Button();
            this.thoat = new System.Windows.Forms.Button();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.listView_show = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(149, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "STK";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(68, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên khách hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(128, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(17, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Số tiền trong tài khoản";
            // 
            // sotaikhoan
            // 
            this.sotaikhoan.Location = new System.Drawing.Point(191, 75);
            this.sotaikhoan.Name = "sotaikhoan";
            this.sotaikhoan.Size = new System.Drawing.Size(465, 23);
            this.sotaikhoan.TabIndex = 5;
            // 
            // tenkh
            // 
            this.tenkh.Location = new System.Drawing.Point(191, 104);
            this.tenkh.Name = "tenkh";
            this.tenkh.Size = new System.Drawing.Size(465, 23);
            this.tenkh.TabIndex = 6;
            // 
            // diachi
            // 
            this.diachi.Location = new System.Drawing.Point(191, 133);
            this.diachi.Name = "diachi";
            this.diachi.Size = new System.Drawing.Size(465, 23);
            this.diachi.TabIndex = 7;
            // 
            // sotien
            // 
            this.sotien.Location = new System.Drawing.Point(191, 161);
            this.sotien.Name = "sotien";
            this.sotien.Size = new System.Drawing.Size(465, 23);
            this.sotien.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(113, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(620, 54);
            this.label5.TabIndex = 9;
            this.label5.Text = "QUẢN LÝ THÔNG TIN TÀI KHOẢN";
            // 
            // them
            // 
            this.them.Location = new System.Drawing.Point(352, 190);
            this.them.Name = "them";
            this.them.Size = new System.Drawing.Size(111, 28);
            this.them.TabIndex = 10;
            this.them.Text = "Thêm/ Cập nhật";
            this.them.UseVisualStyleBackColor = true;
            this.them.Click += new System.EventHandler(this.them_Click);
            // 
            // xoa
            // 
            this.xoa.Location = new System.Drawing.Point(482, 190);
            this.xoa.Name = "xoa";
            this.xoa.Size = new System.Drawing.Size(68, 28);
            this.xoa.TabIndex = 11;
            this.xoa.Text = "Xoá";
            this.xoa.UseVisualStyleBackColor = true;
            this.xoa.Click += new System.EventHandler(this.xoa_Click);
            // 
            // thoat
            // 
            this.thoat.Location = new System.Drawing.Point(565, 190);
            this.thoat.Name = "thoat";
            this.thoat.Size = new System.Drawing.Size(91, 28);
            this.thoat.TabIndex = 12;
            this.thoat.Text = "Thoát";
            this.thoat.UseVisualStyleBackColor = true;
            this.thoat.Click += new System.EventHandler(this.thoat_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Tag = "0";
            this.columnHeader1.Text = "STT";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Mã khách hàng";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 110;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tên khách hàng";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Địa chỉ";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 320;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Số tiền";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 100;
            // 
            // listView_show
            // 
            this.listView_show.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView_show.AutoArrange = false;
            this.listView_show.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView_show.FullRowSelect = true;
            this.listView_show.HoverSelection = true;
            listViewItem2.StateImageIndex = 0;
           // this.listView_show.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            //listViewItem2});
            this.listView_show.Location = new System.Drawing.Point(12, 224);
            this.listView_show.Name = "listView_show";
            this.listView_show.Size = new System.Drawing.Size(785, 214);
            this.listView_show.TabIndex = 13;
            this.listView_show.UseCompatibleStateImageBehavior = false;
            this.listView_show.View = System.Windows.Forms.View.Details;
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView_show);
            this.Controls.Add(this.thoat);
            this.Controls.Add(this.xoa);
            this.Controls.Add(this.them);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.sotien);
            this.Controls.Add(this.diachi);
            this.Controls.Add(this.tenkh);
            this.Controls.Add(this.sotaikhoan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form8";
            this.Text = "Form8";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox sotaikhoan;
        private System.Windows.Forms.TextBox tenkh;
        private System.Windows.Forms.TextBox diachi;
        private System.Windows.Forms.TextBox sotien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button them;
        private System.Windows.Forms.Button xoa;
        private System.Windows.Forms.Button thoat;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ListView listView_show;
    }
}