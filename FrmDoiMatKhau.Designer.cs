
namespace WindowsFormsApp1
{
    partial class FrmDoiMatKhau
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxMatKhauCu = new System.Windows.Forms.TextBox();
            this.tbxMatKhauMoi = new System.Windows.Forms.TextBox();
            this.tbxGoLaiMK = new System.Windows.Forms.TextBox();
            this.tbxTenDangNhap = new System.Windows.Forms.TextBox();
            this.btnHoanTat = new System.Windows.Forms.Button();
            this.btnNhapLai = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(323, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "ĐỔI MẬT KHẨU";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên đăng nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 176);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật khẩu cũ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(98, 249);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mật khẩu mới";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 319);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 28);
            this.label5.TabIndex = 4;
            this.label5.Text = "Gõ lại mật khẩu mới";
            // 
            // tbxMatKhauCu
            // 
            this.tbxMatKhauCu.Location = new System.Drawing.Point(329, 176);
            this.tbxMatKhauCu.Margin = new System.Windows.Forms.Padding(4);
            this.tbxMatKhauCu.Name = "tbxMatKhauCu";
            this.tbxMatKhauCu.Size = new System.Drawing.Size(170, 34);
            this.tbxMatKhauCu.TabIndex = 6;
            // 
            // tbxMatKhauMoi
            // 
            this.tbxMatKhauMoi.Location = new System.Drawing.Point(329, 249);
            this.tbxMatKhauMoi.Margin = new System.Windows.Forms.Padding(4);
            this.tbxMatKhauMoi.Name = "tbxMatKhauMoi";
            this.tbxMatKhauMoi.Size = new System.Drawing.Size(170, 34);
            this.tbxMatKhauMoi.TabIndex = 7;
            // 
            // tbxGoLaiMK
            // 
            this.tbxGoLaiMK.Location = new System.Drawing.Point(329, 319);
            this.tbxGoLaiMK.Margin = new System.Windows.Forms.Padding(4);
            this.tbxGoLaiMK.Name = "tbxGoLaiMK";
            this.tbxGoLaiMK.Size = new System.Drawing.Size(170, 34);
            this.tbxGoLaiMK.TabIndex = 8;
            // 
            // tbxTenDangNhap
            // 
            this.tbxTenDangNhap.Location = new System.Drawing.Point(329, 105);
            this.tbxTenDangNhap.Margin = new System.Windows.Forms.Padding(4);
            this.tbxTenDangNhap.Name = "tbxTenDangNhap";
            this.tbxTenDangNhap.Size = new System.Drawing.Size(170, 34);
            this.tbxTenDangNhap.TabIndex = 9;
            // 
            // btnHoanTat
            // 
            this.btnHoanTat.Location = new System.Drawing.Point(117, 390);
            this.btnHoanTat.Name = "btnHoanTat";
            this.btnHoanTat.Size = new System.Drawing.Size(116, 54);
            this.btnHoanTat.TabIndex = 10;
            this.btnHoanTat.Text = "Hoàn tất";
            this.btnHoanTat.UseVisualStyleBackColor = true;
            this.btnHoanTat.Click += new System.EventHandler(this.btnHoanTat_Click);
            // 
            // btnNhapLai
            // 
            this.btnNhapLai.Location = new System.Drawing.Point(313, 390);
            this.btnNhapLai.Name = "btnNhapLai";
            this.btnNhapLai.Size = new System.Drawing.Size(104, 54);
            this.btnNhapLai.TabIndex = 11;
            this.btnNhapLai.Text = "Nhập lại";
            this.btnNhapLai.UseVisualStyleBackColor = true;
            this.btnNhapLai.Click += new System.EventHandler(this.btnHuyBo_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(513, 390);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 54);
            this.btnThoat.TabIndex = 12;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // FrmDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 630);
            this.Controls.Add(this.tbxTenDangNhap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnNhapLai);
            this.Controls.Add(this.btnHoanTat);
            this.Controls.Add(this.tbxGoLaiMK);
            this.Controls.Add(this.tbxMatKhauMoi);
            this.Controls.Add(this.tbxMatKhauCu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmDoiMatKhau";
            this.Text = "FrmDoiMatKhau";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxMatKhauCu;
        private System.Windows.Forms.TextBox tbxMatKhauMoi;
        private System.Windows.Forms.TextBox tbxGoLaiMK;
        private System.Windows.Forms.TextBox tbxTenDangNhap;
        private System.Windows.Forms.Button btnHoanTat;
        private System.Windows.Forms.Button btnNhapLai;
        private System.Windows.Forms.Button btnThoat;
    }
}