
namespace BaiTap
{
    partial class Cau2
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
            this.txtTong = new System.Windows.Forms.TextBox();
            this.txtN = new System.Windows.Forms.TextBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnTinhTong = new System.Windows.Forms.Button();
            this.lbTong = new System.Windows.Forms.Label();
            this.lbNhapN = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTong
            // 
            this.txtTong.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTong.Location = new System.Drawing.Point(175, 125);
            this.txtTong.Name = "txtTong";
            this.txtTong.Size = new System.Drawing.Size(232, 28);
            this.txtTong.TabIndex = 15;
            // 
            // txtN
            // 
            this.txtN.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtN.Location = new System.Drawing.Point(175, 60);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(232, 28);
            this.txtN.TabIndex = 13;
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnHuy.Location = new System.Drawing.Point(305, 189);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(102, 33);
            this.btnHuy.TabIndex = 12;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnTinhTong
            // 
            this.btnTinhTong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTinhTong.Location = new System.Drawing.Point(175, 189);
            this.btnTinhTong.Name = "btnTinhTong";
            this.btnTinhTong.Size = new System.Drawing.Size(105, 33);
            this.btnTinhTong.TabIndex = 11;
            this.btnTinhTong.Text = "Tính Tổng";
            this.btnTinhTong.UseVisualStyleBackColor = true;
            this.btnTinhTong.Click += new System.EventHandler(this.btnTinhTong_Click);
            // 
            // lbTong
            // 
            this.lbTong.AutoSize = true;
            this.lbTong.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTong.Location = new System.Drawing.Point(72, 125);
            this.lbTong.Name = "lbTong";
            this.lbTong.Size = new System.Drawing.Size(53, 21);
            this.lbTong.TabIndex = 10;
            this.lbTong.Text = "Tổng:";
            // 
            // lbNhapN
            // 
            this.lbNhapN.AutoSize = true;
            this.lbNhapN.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbNhapN.Location = new System.Drawing.Point(55, 63);
            this.lbNhapN.Name = "lbNhapN";
            this.lbNhapN.Size = new System.Drawing.Size(70, 21);
            this.lbNhapN.TabIndex = 8;
            this.lbNhapN.Text = "Nhập N:";
            // 
            // Cau2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 273);
            this.Controls.Add(this.txtTong);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnTinhTong);
            this.Controls.Add(this.lbTong);
            this.Controls.Add(this.lbNhapN);
            this.Name = "Cau2";
            this.Text = "Tính tổng S";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTong;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnTinhTong;
        private System.Windows.Forms.Label lbTong;
        private System.Windows.Forms.Label lbNhapN;
    }
}