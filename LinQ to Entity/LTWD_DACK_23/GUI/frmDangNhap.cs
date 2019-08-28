using System;
using System.Windows.Forms;
using BUS;

namespace GUI
{
    public partial class frmDangNhap : DevExpress.XtraEditors.XtraForm
    {
        TaiKhoanBUS tkBUS;

        public frmDangNhap()
        {
            tkBUS = new TaiKhoanBUS();
            InitializeComponent();
        }

        #region Methods

        private bool KiemTra(string user, string pass)
        {
            var tk = tkBUS.getTKDangNhap(user, pass);
            if (tk.Count == 0)
                return false;
            if (tk[0].TaiKhoan == user && tk[0].MatKhau == pass)
            {
                frmMain.user.TaiKhoan1 = tk[0].TaiKhoan;
                frmMain.user.MatKhau = tk[0].MatKhau;
                frmMain.user.LoaiUser = tk[0].LoaiUser;
                frmMain.user.Ma = tk[0].Ma;
                return true;
            }
            return false;
        }

        #endregion


        #region Events

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (KiemTra(txtUser.Text, txtPass.Text) == true)
                this.Close();
            else
            {
                MessageBox.Show("Tên người dùng hoặc mật khẩu không đúng !!!", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                this.txtUser.Focus();
                this.txtUser.SelectAll();
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult traloi = MessageBox.Show("Bạn muốn thoát chương trình?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (traloi == DialogResult.OK)
                Application.Exit();
            else
            {
                Form frm = new frmDangNhap();
                frm.ShowDialog();
            }
        }

        private void txtUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13 || e.KeyValue == 9)
            {
                txtPass.Focus();
                txtPass.SelectAll();
            }
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
                this.btnLogin_Click(sender,e);
        }

        #endregion
    }
}
