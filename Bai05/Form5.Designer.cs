namespace Bai05
{
    partial class Form5
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.bAd = new System.Windows.Forms.Button();
            this.bSub = new System.Windows.Forms.Button();
            this.bMul = new System.Windows.Forms.Button();
            this.bDiv = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(93, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(93, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number 2:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBox1.Location = new System.Drawing.Point(238, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(264, 34);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBox2.Location = new System.Drawing.Point(236, 128);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(266, 34);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // bAd
            // 
            this.bAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.bAd.Location = new System.Drawing.Point(125, 183);
            this.bAd.Name = "bAd";
            this.bAd.Size = new System.Drawing.Size(71, 70);
            this.bAd.TabIndex = 4;
            this.bAd.Text = "+";
            this.bAd.UseVisualStyleBackColor = true;
            this.bAd.Click += new System.EventHandler(this.button1_Click);
            // 
            // bSub
            // 
            this.bSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.bSub.Location = new System.Drawing.Point(238, 183);
            this.bSub.Name = "bSub";
            this.bSub.Size = new System.Drawing.Size(71, 70);
            this.bSub.TabIndex = 5;
            this.bSub.Text = "-";
            this.bSub.UseVisualStyleBackColor = true;
            this.bSub.Click += new System.EventHandler(this.bSub_Click);
            // 
            // bMul
            // 
            this.bMul.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.bMul.Location = new System.Drawing.Point(358, 183);
            this.bMul.Name = "bMul";
            this.bMul.Size = new System.Drawing.Size(71, 70);
            this.bMul.TabIndex = 6;
            this.bMul.Text = "*";
            this.bMul.UseVisualStyleBackColor = true;
            this.bMul.Click += new System.EventHandler(this.bMul_Click);
            // 
            // bDiv
            // 
            this.bDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.bDiv.Location = new System.Drawing.Point(474, 183);
            this.bDiv.Name = "bDiv";
            this.bDiv.Size = new System.Drawing.Size(71, 70);
            this.bDiv.TabIndex = 7;
            this.bDiv.Text = "/";
            this.bDiv.UseVisualStyleBackColor = true;
            this.bDiv.Click += new System.EventHandler(this.bDiv_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(96, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "Answer";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBox3.Location = new System.Drawing.Point(236, 297);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(266, 34);
            this.textBox3.TabIndex = 9;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 388);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bDiv);
            this.Controls.Add(this.bMul);
            this.Controls.Add(this.bSub);
            this.Controls.Add(this.bAd);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button bAd;
        private System.Windows.Forms.Button bSub;
        private System.Windows.Forms.Button bMul;
        private System.Windows.Forms.Button bDiv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
    }
}

