using System;
using System.Windows.Forms;
using DAO;
using DevExpress.XtraSplashScreen;

namespace GUI
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public static TAIKHOAN user = new TAIKHOAN();
        public static int ktButtonClick = 0;

        public frmMain()
        {
            Login();
            InitializeComponent();          
            btnDangNhap.Enabled = false;
            phanQuyen();
            System.Media.SoundPlayer sp = new System.Media.SoundPlayer("XinChao.wav");
            sp.Play();
        }

        #region Methods

        private void Login()
        {
            Form frm = new frmDangNhap();
            frm.ShowDialog();
        }

        private Form kiemTraTonTai(Type fType)
        {
            foreach (Form f in MdiChildren)
                if (f.GetType() == fType)
                    return f;
            return null;
        }

        private Form kiemTraTonTaiCungForm(string tenForm)
        {
            foreach (Form f in MdiChildren)
                if (f.Text == tenForm)
                    return f;
            return null;
        }

        private void phanQuyen()
        {
            if (user.LoaiUser == "GiangVien")
            {
                this.btnQuanLyNguoiDung.Enabled = false;
                this.btnQLSV.Enabled = false;
                this.btnQLGiangVien.Enabled = false;
                this.btnQLHocPhan.Enabled = false;
                this.btnQLHocPhi.Enabled = false;
                this.btnQLCTXH.Enabled = false;
                this.btnQLHDRL.Enabled = false;
                this.btnQLVP.Enabled = false;
                this.btnTimKiem.Visible = false;
            }
            if (user.LoaiUser == "SinhVien")
            {
                this.btnQuanLyNguoiDung.Enabled = false;
                this.btnQuanLy.Visible = false;
                this.btnTimKiem.Visible = false;
            }
        }
        #endregion

        #region Events

        private void btnDangNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Login();
        }

        private void btnDoiMatKhau_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDoiMatKhau f = new frmDoiMatKhau();
            f.ShowDialog();
        }

        private void btnDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Hide();
            Form frmMain = new frmMain();
            frmMain.ShowDialog();
        }

        private void btnThoat_ItemPressed(object sender, DevExpress.XtraBars.Ribbon.BackstageViewItemEventArgs e)
        {
            Application.Exit();
        }

        private void btnQuanLyNguoiDung_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.kiemTraTonTai(typeof(frmQuanLyNguoiDung));
            if (frm != null)
                frm.Activate();
            else
            {
                SplashScreenManager.ShowForm(typeof(WaitForm1));
                frmQuanLyNguoiDung f = new frmQuanLyNguoiDung();
                f.MdiParent = this;
                SplashScreenManager.CloseForm();
                f.Show();
            }
        }


        private void btnQLSV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.kiemTraTonTai(typeof(frmSinhVien));
            if (frm != null)
                frm.Activate();
            else
            {
                SplashScreenManager.ShowForm(typeof(WaitForm1));
                frmSinhVien f = new frmSinhVien();
                f.MdiParent = this;
                SplashScreenManager.CloseForm();
                f.Show();
            }
        }

        private void btnQLGiangVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.kiemTraTonTai(typeof(frmQLGiangVien));
            if (frm != null)
                frm.Activate();
            else
            {
                SplashScreenManager.ShowForm(typeof(WaitForm1));
                frmQLGiangVien f = new frmQLGiangVien();
                f.MdiParent = this;
                SplashScreenManager.CloseForm();
                f.Show();
            }
        }

        private void btnDiemThi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.kiemTraTonTai(typeof(frmQLDiemThi));
            if (frm != null)
                frm.Activate();
            else
            {
                SplashScreenManager.ShowForm(typeof(WaitForm1));
                frmQLDiemThi f = new frmQLDiemThi();
                f.MdiParent = this;
                SplashScreenManager.CloseForm();
                f.Show();
            }
        }

        private void btnHocPhan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.kiemTraTonTai(typeof(frmQLHocPhan));
            if (frm != null)
                frm.Activate();
            else
            {
                SplashScreenManager.ShowForm(typeof(WaitForm1));
                frmQLHocPhan f = new frmQLHocPhan();
                f.MdiParent = this;
                SplashScreenManager.CloseForm();
                f.Show();
            }
        }

        private void btnQLHocPhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.kiemTraTonTai(typeof(frmQLHocPhi));
            if (frm != null)
                frm.Activate();
            else
            {
                SplashScreenManager.ShowForm(typeof(WaitForm1));
                frmQLHocPhi f = new frmQLHocPhi();
                f.MdiParent = this;
                SplashScreenManager.CloseForm();
                f.Show();
            }
        }

        private void btnQLCTXH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ktButtonClick = 10;
            Form frm = this.kiemTraTonTaiCungForm("Quan Ly CTXH");
            if (frm != null)
                frm.Activate();
            else
            {
                SplashScreenManager.ShowForm(typeof(WaitForm1));
                frmQL_CTXH_HDRL f = new frmQL_CTXH_HDRL();
                f.MdiParent = this;
                SplashScreenManager.CloseForm();
                f.Show();
            }
        }

        private void btnQLHDRL_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ktButtonClick = 11;
            Form frm = this.kiemTraTonTaiCungForm("Quan Ly HDRL");
            if (frm != null)
                frm.Activate();
            else
            {
                SplashScreenManager.ShowForm(typeof(WaitForm1));
                frmQL_CTXH_HDRL f = new frmQL_CTXH_HDRL();
                f.MdiParent = this;
                SplashScreenManager.CloseForm();
                f.Show();
            }
        }

        private void btnQLVP_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.kiemTraTonTai(typeof(frmQL_VP));
            if (frm != null)
                frm.Activate();
            else
            {
                SplashScreenManager.ShowForm(typeof(WaitForm1));
                frmQL_VP f = new frmQL_VP();
                f.MdiParent = this;
                SplashScreenManager.CloseForm();
                f.Show();
            }
        }


        private void btnSearch_HBNL_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ktButtonClick = 1;
            Form frm = this.kiemTraTonTaiCungForm("Search HBNL");
            if (frm != null)
                frm.Activate();
            else
            {
                SplashScreenManager.ShowForm(typeof(WaitForm1));
                frmTimKiem f = new frmTimKiem();
                f.MdiParent = this;
                SplashScreenManager.CloseForm();
                f.Show();
            }
        }

        private void btnSearch_HBGioi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ktButtonClick = 2;
            Form frm = this.kiemTraTonTaiCungForm("Search HBG");
            if (frm != null)
                frm.Activate();
            else
            {
                SplashScreenManager.ShowForm(typeof(WaitForm1));
                frmTimKiem f = new frmTimKiem();
                f.MdiParent = this;
                SplashScreenManager.CloseForm();
                f.Show();
            }
        }

        private void btnSearch_HBKha_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ktButtonClick = 3;
            Form frm = this.kiemTraTonTaiCungForm("Search HBK");
            if (frm != null)
                frm.Activate();
            else
            {
                SplashScreenManager.ShowForm(typeof(WaitForm1));
                frmTimKiem f = new frmTimKiem();
                f.MdiParent = this;
                SplashScreenManager.CloseForm();
                f.Show();
            }
        }

        private void btnSearch_CBHV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ktButtonClick = 4;
            Form frm = this.kiemTraTonTaiCungForm("Search CBHV");
            if (frm != null)
                frm.Activate();
            else
            {
                SplashScreenManager.ShowForm(typeof(WaitForm1));
                frmTimKiem f = new frmTimKiem();
                f.MdiParent = this;
                SplashScreenManager.CloseForm();
                f.Show();
            }
        }

        private void btnSearch_CTXH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ktButtonClick = 5;
            Form frm = this.kiemTraTonTaiCungForm("Search CTXH");
            if (frm != null)
                frm.Activate();
            else
            {
                SplashScreenManager.ShowForm(typeof(WaitForm1));
                frmTimKiem f = new frmTimKiem();
                f.MdiParent = this;
                SplashScreenManager.CloseForm();
                f.Show();
            }
        }

        private void btnSearch_NoHP_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ktButtonClick = 6;
            Form frm = this.kiemTraTonTaiCungForm("Search NoHP");
            if (frm != null)
                frm.Activate();
            else
            {
                SplashScreenManager.ShowForm(typeof(WaitForm1));
                frmTimKiem f = new frmTimKiem();
                f.MdiParent = this;
                SplashScreenManager.CloseForm();
                f.Show();
            }
        }


        private void btnTKDiemThi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.kiemTraTonTai(typeof(frmTKDiemThi));
            if (frm != null)
                frm.Activate();
            else
            {
                SplashScreenManager.ShowForm(typeof(WaitForm1));
                frmTKDiemThi f = new frmTKDiemThi();
                f.MdiParent = this;
                SplashScreenManager.CloseForm();
                f.Show();
            }
        }

        private void btnTKHocPhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ktButtonClick = 12;
            Form frm = this.kiemTraTonTaiCungForm("TK Hoc Phi");
            if (frm != null)
                frm.Activate();
            else
            {
                SplashScreenManager.ShowForm(typeof(WaitForm1));
                frmTK_HoatDong f = new frmTK_HoatDong();
                f.MdiParent = this;
                SplashScreenManager.CloseForm();
                f.Show();
            }
        }

        private void btnTK_VP_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ktButtonClick = 9;
            Form frm = this.kiemTraTonTaiCungForm("TK Vi Pham");
            if (frm != null)
                frm.Activate();
            else
            {
                SplashScreenManager.ShowForm(typeof(WaitForm1));
                frmTK_HoatDong f = new frmTK_HoatDong();
                f.MdiParent = this;
                SplashScreenManager.CloseForm();
                f.Show();
            }
        }

        private void btnTK_CTXH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ktButtonClick = 7;
            Form frm = this.kiemTraTonTaiCungForm("TK CT Xa Hoi");
            if (frm != null)
                frm.Activate();
            else
            {
                SplashScreenManager.ShowForm(typeof(WaitForm1));
                frmTK_HoatDong f = new frmTK_HoatDong();
                f.MdiParent = this;
                SplashScreenManager.CloseForm();
                f.Show();
            }
        }

        private void btnTK_HDRL_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ktButtonClick = 8;
            Form frm = this.kiemTraTonTaiCungForm("TK HD Ren Luyen");
            if (frm != null)
                frm.Activate();
            else
            {
                SplashScreenManager.ShowForm(typeof(WaitForm1));
                frmTK_HoatDong f = new frmTK_HoatDong();
                f.MdiParent = this;
                SplashScreenManager.CloseForm();
                f.Show();
            }
        }
        #endregion
    }
}
