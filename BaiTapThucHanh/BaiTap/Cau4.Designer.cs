
namespace BaiTap
{
    partial class Cau4
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
            this.btClose = new System.Windows.Forms.Button();
            this.txtNumber2 = new System.Windows.Forms.TextBox();
            this.txtNumber1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdAdd = new System.Windows.Forms.RadioButton();
            this.rdSub = new System.Windows.Forms.RadioButton();
            this.rdMul = new System.Windows.Forms.RadioButton();
            this.rdDiv = new System.Windows.Forms.RadioButton();
            this.rdMod = new System.Windows.Forms.RadioButton();
            this.lbResult = new System.Windows.Forms.TextBox();
            this.btTotal = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btClose
            // 
            this.btClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btClose.ForeColor = System.Drawing.Color.Blue;
            this.btClose.Location = new System.Drawing.Point(429, 386);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(102, 40);
            this.btClose.TabIndex = 21;
            this.btClose.Text = "Đóng";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // txtNumber2
            // 
            this.txtNumber2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtNumber2.Location = new System.Drawing.Point(537, 127);
            this.txtNumber2.Name = "txtNumber2";
            this.txtNumber2.Size = new System.Drawing.Size(100, 28);
            this.txtNumber2.TabIndex = 15;
            // 
            // txtNumber1
            // 
            this.txtNumber1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtNumber1.Location = new System.Drawing.Point(239, 127);
            this.txtNumber1.Name = "txtNumber1";
            this.txtNumber1.Size = new System.Drawing.Size(100, 28);
            this.txtNumber1.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(455, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Số thứ 2:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(152, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Số thứ 1: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(203, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 32);
            this.label1.TabIndex = 11;
            this.label1.Text = "CÁC PHÉP TÍNH ĐƠN GIẢN";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdMod);
            this.groupBox1.Controls.Add(this.rdDiv);
            this.groupBox1.Controls.Add(this.rdMul);
            this.groupBox1.Controls.Add(this.rdSub);
            this.groupBox1.Controls.Add(this.rdAdd);
            this.groupBox1.Location = new System.Drawing.Point(156, 178);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(481, 100);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn phép tính";
            // 
            // rdAdd
            // 
            this.rdAdd.AutoSize = true;
            this.rdAdd.Checked = true;
            this.rdAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdAdd.ForeColor = System.Drawing.Color.Red;
            this.rdAdd.Location = new System.Drawing.Point(40, 49);
            this.rdAdd.Name = "rdAdd";
            this.rdAdd.Size = new System.Drawing.Size(41, 24);
            this.rdAdd.TabIndex = 0;
            this.rdAdd.TabStop = true;
            this.rdAdd.Text = "+";
            this.rdAdd.UseVisualStyleBackColor = true;
            // 
            // rdSub
            // 
            this.rdSub.AutoSize = true;
            this.rdSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdSub.ForeColor = System.Drawing.Color.Red;
            this.rdSub.Location = new System.Drawing.Point(119, 49);
            this.rdSub.Name = "rdSub";
            this.rdSub.Size = new System.Drawing.Size(37, 24);
            this.rdSub.TabIndex = 1;
            this.rdSub.Text = "-";
            this.rdSub.UseVisualStyleBackColor = true;
            // 
            // rdMul
            // 
            this.rdMul.AutoSize = true;
            this.rdMul.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdMul.ForeColor = System.Drawing.Color.Red;
            this.rdMul.Location = new System.Drawing.Point(210, 49);
            this.rdMul.Name = "rdMul";
            this.rdMul.Size = new System.Drawing.Size(42, 24);
            this.rdMul.TabIndex = 2;
            this.rdMul.Text = "X";
            this.rdMul.UseVisualStyleBackColor = true;
            // 
            // rdDiv
            // 
            this.rdDiv.AutoSize = true;
            this.rdDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdDiv.ForeColor = System.Drawing.Color.Red;
            this.rdDiv.Location = new System.Drawing.Point(314, 49);
            this.rdDiv.Name = "rdDiv";
            this.rdDiv.Size = new System.Drawing.Size(36, 24);
            this.rdDiv.TabIndex = 3;
            this.rdDiv.Text = "/";
            this.rdDiv.UseVisualStyleBackColor = true;
            // 
            // rdMod
            // 
            this.rdMod.AutoSize = true;
            this.rdMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdMod.ForeColor = System.Drawing.Color.Red;
            this.rdMod.Location = new System.Drawing.Point(401, 49);
            this.rdMod.Name = "rdMod";
            this.rdMod.Size = new System.Drawing.Size(46, 24);
            this.rdMod.TabIndex = 4;
            this.rdMod.Text = "%";
            this.rdMod.UseVisualStyleBackColor = true;
            // 
            // lbResult
            // 
            this.lbResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbResult.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbResult.Location = new System.Drawing.Point(156, 306);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(481, 34);
            this.lbResult.TabIndex = 24;
            this.lbResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btTotal
            // 
            this.btTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btTotal.ForeColor = System.Drawing.Color.Blue;
            this.btTotal.Location = new System.Drawing.Point(275, 386);
            this.btTotal.Name = "btTotal";
            this.btTotal.Size = new System.Drawing.Size(102, 40);
            this.btTotal.TabIndex = 25;
            this.btTotal.Text = "Tính";
            this.btTotal.UseVisualStyleBackColor = true;
            this.btTotal.Click += new System.EventHandler(this.btTotal_Click);
            // 
            // Cau4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btTotal);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.txtNumber2);
            this.Controls.Add(this.txtNumber1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Cau4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cau4";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.TextBox txtNumber2;
        private System.Windows.Forms.TextBox txtNumber1;
        protected internal System.Windows.Forms.Label label3;
        protected internal System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdMod;
        private System.Windows.Forms.RadioButton rdDiv;
        private System.Windows.Forms.RadioButton rdMul;
        private System.Windows.Forms.RadioButton rdSub;
        private System.Windows.Forms.RadioButton rdAdd;
        private System.Windows.Forms.TextBox lbResult;
        private System.Windows.Forms.Button btTotal;
    }
}