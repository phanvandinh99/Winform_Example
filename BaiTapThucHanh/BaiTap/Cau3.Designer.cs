
namespace BaiTap
{
    partial class Cau3
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoThu1 = new System.Windows.Forms.TextBox();
            this.txtSoThu2 = new System.Windows.Forms.TextBox();
            this.btnCong = new System.Windows.Forms.Button();
            this.btnTru = new System.Windows.Forms.Button();
            this.btnNhan = new System.Windows.Forms.Button();
            this.btnChia = new System.Windows.Forms.Button();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(103, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "CÁC PHÉP TÍNH ĐƠN GIẢN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(67, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số thứ 1: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label3.Location = new System.Drawing.Point(336, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số thứ 2:";
            // 
            // txtSoThu1
            // 
            this.txtSoThu1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSoThu1.Location = new System.Drawing.Point(142, 118);
            this.txtSoThu1.Name = "txtSoThu1";
            this.txtSoThu1.Size = new System.Drawing.Size(100, 28);
            this.txtSoThu1.TabIndex = 3;
            // 
            // txtSoThu2
            // 
            this.txtSoThu2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSoThu2.Location = new System.Drawing.Point(440, 122);
            this.txtSoThu2.Name = "txtSoThu2";
            this.txtSoThu2.Size = new System.Drawing.Size(100, 28);
            this.txtSoThu2.TabIndex = 4;
            // 
            // btnCong
            // 
            this.btnCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCong.ForeColor = System.Drawing.Color.Red;
            this.btnCong.Location = new System.Drawing.Point(142, 212);
            this.btnCong.Name = "btnCong";
            this.btnCong.Size = new System.Drawing.Size(58, 31);
            this.btnCong.TabIndex = 5;
            this.btnCong.Text = "+";
            this.btnCong.UseVisualStyleBackColor = true;
            this.btnCong.Click += new System.EventHandler(this.btnCong_Click);
            // 
            // btnTru
            // 
            this.btnTru.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTru.ForeColor = System.Drawing.Color.Red;
            this.btnTru.Location = new System.Drawing.Point(246, 212);
            this.btnTru.Name = "btnTru";
            this.btnTru.Size = new System.Drawing.Size(58, 31);
            this.btnTru.TabIndex = 6;
            this.btnTru.Text = "-";
            this.btnTru.UseVisualStyleBackColor = true;
            this.btnTru.Click += new System.EventHandler(this.btnTru_Click);
            // 
            // btnNhan
            // 
            this.btnNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnNhan.ForeColor = System.Drawing.Color.Red;
            this.btnNhan.Location = new System.Drawing.Point(343, 212);
            this.btnNhan.Name = "btnNhan";
            this.btnNhan.Size = new System.Drawing.Size(58, 31);
            this.btnNhan.TabIndex = 7;
            this.btnNhan.Text = "x";
            this.btnNhan.UseVisualStyleBackColor = true;
            this.btnNhan.Click += new System.EventHandler(this.btnNhan_Click);
            // 
            // btnChia
            // 
            this.btnChia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnChia.ForeColor = System.Drawing.Color.Red;
            this.btnChia.Location = new System.Drawing.Point(440, 212);
            this.btnChia.Name = "btnChia";
            this.btnChia.Size = new System.Drawing.Size(58, 31);
            this.btnChia.TabIndex = 8;
            this.btnChia.Text = "/";
            this.btnChia.UseVisualStyleBackColor = true;
            this.btnChia.Click += new System.EventHandler(this.btnChia_Click);
            // 
            // txtKetQua
            // 
            this.txtKetQua.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtKetQua.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtKetQua.Location = new System.Drawing.Point(235, 291);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(157, 28);
            this.txtKetQua.TabIndex = 9;
            this.txtKetQua.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnClose.ForeColor = System.Drawing.Color.Blue;
            this.btnClose.Location = new System.Drawing.Point(268, 353);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(102, 40);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Cau3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(632, 416);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.btnChia);
            this.Controls.Add(this.btnNhan);
            this.Controls.Add(this.btnTru);
            this.Controls.Add(this.btnCong);
            this.Controls.Add(this.txtSoThu2);
            this.Controls.Add(this.txtSoThu1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Name = "Cau3";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                                                      Cac phep tinh";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        protected internal System.Windows.Forms.Label label2;
        protected internal System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSoThu1;
        private System.Windows.Forms.TextBox txtSoThu2;
        private System.Windows.Forms.Button btnCong;
        private System.Windows.Forms.Button btnTru;
        private System.Windows.Forms.Button btnNhan;
        private System.Windows.Forms.Button btnChia;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.Button btnClose;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}