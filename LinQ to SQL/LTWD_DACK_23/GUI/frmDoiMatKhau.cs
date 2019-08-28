using System;
using System.Windows.Forms;
using BUS;

namespace GUI
{
    public partial class frmDoiMatKhau : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private TaiKhoanBUS tkBUS;

        public frmDoiMatKhau()
        {
            tkBUS = new TaiKhoanBUS();
            InitializeComponent();
        }

        #region Events

        private void pctThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (this.txtMKCu.Text != frmMain.user.MatKhau)
                MessageBox.Show("Bạn đã nhập SAI mật khẩu cũ!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (this.txtMKMoi.Text != this.txtNhapLaiMKMoi.Text)
                    MessageBox.Show("Mật khẩu mới không khớp. Mời bạn nhập mại Mật Khẩu mới.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    if (this.txtMKCu.Text == this.txtMKMoi.Text)
                        MessageBox.Show("Mật khẩu mới phải khác mật khẩu cũ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        if (this.txtMKMoi.Text == "")
                            MessageBox.Show("Bạn chưa nhập Mật Khẩu mới.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                        {
                            if(tkBUS.suaTaiKhoan(frmMain.user.TaiKhoan1, this.txtMKMoi.Text, frmMain.user.LoaiUser, frmMain.user.Ma))
                            {
                                frmMain.user.MatKhau = this.txtMKMoi.Text;
                                this.Close();
                            }
                            else
                                MessageBox.Show("Không thể Sửa. Lỗi !!!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void txtMKCu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
                this.txtMKMoi.Focus();
        }

        private void txtMKMoi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
                this.txtNhapLaiMKMoi.Focus();
        }

        private void txtNhapLaiMKMoi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
                this.btnLuu_Click(sender, e);
        }
        #endregion
    }
}
