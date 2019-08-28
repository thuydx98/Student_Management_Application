namespace GUI
{
    partial class frmDoiMatKhau
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
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.pctThoat = new System.Windows.Forms.PictureBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNhapLaiMKMoi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMKMoi = new System.Windows.Forms.TextBox();
            this.txtMKCu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctThoat)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "ribbonPage3";
            // 
            // pctThoat
            // 
            this.pctThoat.Image = global::GUI.Properties.Resources.Xoa;
            this.pctThoat.Location = new System.Drawing.Point(553, 12);
            this.pctThoat.Name = "pctThoat";
            this.pctThoat.Size = new System.Drawing.Size(27, 27);
            this.pctThoat.TabIndex = 0;
            this.pctThoat.TabStop = false;
            this.pctThoat.Click += new System.EventHandler(this.pctThoat_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.Snow;
            this.btnHuy.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnHuy.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.Blue;
            this.btnHuy.Image = global::GUI.Properties.Resources.Huy48x48;
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.Location = new System.Drawing.Point(362, 311);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(148, 53);
            this.btnHuy.TabIndex = 10;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnLuu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.Red;
            this.btnLuu.Image = global::GUI.Properties.Resources.Luu48x48;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(79, 310);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(142, 54);
            this.btnLuu.TabIndex = 9;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(194, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 48);
            this.label1.TabIndex = 7;
            this.label1.Text = "Đổi Mật Khẩu";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtNhapLaiMKMoi);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtMKMoi);
            this.panel1.Controls.Add(this.txtMKCu);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(13, 148);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(567, 157);
            this.panel1.TabIndex = 8;
            // 
            // txtNhapLaiMKMoi
            // 
            this.txtNhapLaiMKMoi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNhapLaiMKMoi.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhapLaiMKMoi.Location = new System.Drawing.Point(233, 109);
            this.txtNhapLaiMKMoi.Name = "txtNhapLaiMKMoi";
            this.txtNhapLaiMKMoi.PasswordChar = '*';
            this.txtNhapLaiMKMoi.Size = new System.Drawing.Size(305, 32);
            this.txtNhapLaiMKMoi.TabIndex = 6;
            this.txtNhapLaiMKMoi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNhapLaiMKMoi_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(215, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nhập Lại Mật khẩu Mới:";
            // 
            // txtMKMoi
            // 
            this.txtMKMoi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMKMoi.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMKMoi.Location = new System.Drawing.Point(233, 65);
            this.txtMKMoi.Name = "txtMKMoi";
            this.txtMKMoi.PasswordChar = '*';
            this.txtMKMoi.Size = new System.Drawing.Size(305, 32);
            this.txtMKMoi.TabIndex = 4;
            this.txtMKMoi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMKMoi_KeyDown);
            // 
            // txtMKCu
            // 
            this.txtMKCu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMKCu.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMKCu.Location = new System.Drawing.Point(233, 22);
            this.txtMKCu.Name = "txtMKCu";
            this.txtMKCu.PasswordChar = '*';
            this.txtMKCu.Size = new System.Drawing.Size(305, 32);
            this.txtMKCu.TabIndex = 3;
            this.txtMKCu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMKCu_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật khẩu Mới:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật Khẩu Cũ:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.hcmute;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(595, 144);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // frmDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 368);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pctThoat);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDoiMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDoiMatKhau";
            ((System.ComponentModel.ISupportInitialize)(this.pctThoat)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private System.Windows.Forms.PictureBox pctThoat;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNhapLaiMKMoi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMKMoi;
        private System.Windows.Forms.TextBox txtMKCu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}