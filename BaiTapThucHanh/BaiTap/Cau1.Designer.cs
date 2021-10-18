
namespace BaiTap
{
    partial class frmMain
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
            this.lbNhapSoA = new System.Windows.Forms.Label();
            this.lbNhapSoB = new System.Windows.Forms.Label();
            this.lbKetQua = new System.Windows.Forms.Label();
            this.btnSoSanh = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.txtSoA = new System.Windows.Forms.TextBox();
            this.txtSoB = new System.Windows.Forms.TextBox();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbNhapSoA
            // 
            this.lbNhapSoA.AutoSize = true;
            this.lbNhapSoA.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbNhapSoA.Location = new System.Drawing.Point(44, 69);
            this.lbNhapSoA.Name = "lbNhapSoA";
            this.lbNhapSoA.Size = new System.Drawing.Size(92, 21);
            this.lbNhapSoA.TabIndex = 0;
            this.lbNhapSoA.Text = "Nhập số A:";
            this.lbNhapSoA.Click += new System.EventHandler(this.lbNhapSoA_Click);
            // 
            // lbNhapSoB
            // 
            this.lbNhapSoB.AutoSize = true;
            this.lbNhapSoB.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbNhapSoB.Location = new System.Drawing.Point(44, 134);
            this.lbNhapSoB.Name = "lbNhapSoB";
            this.lbNhapSoB.Size = new System.Drawing.Size(91, 21);
            this.lbNhapSoB.TabIndex = 1;
            this.lbNhapSoB.Text = "Nhập số B:";
            this.lbNhapSoB.Click += new System.EventHandler(this.lbNhapSoB_Click);
            // 
            // lbKetQua
            // 
            this.lbKetQua.AutoSize = true;
            this.lbKetQua.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbKetQua.Location = new System.Drawing.Point(62, 199);
            this.lbKetQua.Name = "lbKetQua";
            this.lbKetQua.Size = new System.Drawing.Size(73, 21);
            this.lbKetQua.TabIndex = 2;
            this.lbKetQua.Text = "Kết quả:";
            this.lbKetQua.Click += new System.EventHandler(this.lbKetQua_Click);
            // 
            // btnSoSanh
            // 
            this.btnSoSanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSoSanh.Location = new System.Drawing.Point(165, 283);
            this.btnSoSanh.Name = "btnSoSanh";
            this.btnSoSanh.Size = new System.Drawing.Size(105, 33);
            this.btnSoSanh.TabIndex = 3;
            this.btnSoSanh.Text = "So Sánh";
            this.btnSoSanh.UseVisualStyleBackColor = true;
            this.btnSoSanh.Click += new System.EventHandler(this.btnSoSanh_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnHuy.Location = new System.Drawing.Point(276, 283);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(102, 33);
            this.btnHuy.TabIndex = 4;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // txtSoA
            // 
            this.txtSoA.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSoA.Location = new System.Drawing.Point(165, 62);
            this.txtSoA.Name = "txtSoA";
            this.txtSoA.Size = new System.Drawing.Size(213, 28);
            this.txtSoA.TabIndex = 5;
            this.txtSoA.TextChanged += new System.EventHandler(this.txtSoA_TextChanged);
            // 
            // txtSoB
            // 
            this.txtSoB.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSoB.Location = new System.Drawing.Point(165, 134);
            this.txtSoB.Name = "txtSoB";
            this.txtSoB.Size = new System.Drawing.Size(213, 28);
            this.txtSoB.TabIndex = 6;
            this.txtSoB.TextChanged += new System.EventHandler(this.txtSoB_TextChanged);
            // 
            // txtKetQua
            // 
            this.txtKetQua.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtKetQua.Location = new System.Drawing.Point(165, 199);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(213, 28);
            this.txtKetQua.TabIndex = 7;
            this.txtKetQua.TextChanged += new System.EventHandler(this.txtKetQua_TextChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 346);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.txtSoB);
            this.Controls.Add(this.txtSoA);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnSoSanh);
            this.Controls.Add(this.lbKetQua);
            this.Controls.Add(this.lbNhapSoB);
            this.Controls.Add(this.lbNhapSoA);
            this.Name = "frmMain";
            this.Text = "Tìm số lớn nhất";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNhapSoA;
        private System.Windows.Forms.Label lbNhapSoB;
        private System.Windows.Forms.Label lbKetQua;
        private System.Windows.Forms.Button btnSoSanh;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.TextBox txtSoA;
        private System.Windows.Forms.TextBox txtSoB;
        private System.Windows.Forms.TextBox txtKetQua;
    }
}

