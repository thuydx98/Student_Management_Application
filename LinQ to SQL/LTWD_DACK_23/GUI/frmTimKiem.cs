using System;
using BUS;

namespace GUI
{
    public partial class frmTimKiem : DevExpress.XtraEditors.XtraForm
    {
        int ktButton;
        SinhVienBUS svBUS;
        HocPhanBUS hpBUS;

        public frmTimKiem()
        {
            ktButton = frmMain.ktButtonClick;
            svBUS = new SinhVienBUS();
            hpBUS = new HocPhanBUS();

            InitializeComponent();
            kiemTra();
            LoadData();
        }

        #region Methods

        private void kiemTra()
        {
            if (frmMain.ktButtonClick == 1)
                this.Text = "Search HBNL";
            else
            {
                if (frmMain.ktButtonClick == 2)
                    this.Text = "Search HBG";
                else
                {
                    if (frmMain.ktButtonClick == 3)
                        this.Text = "Search HBK";
                    else
                    {
                        lcgNho.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;

                        if (frmMain.ktButtonClick == 4)
                            this.Text = "Search CBHV";
                        else
                        {
                            if (frmMain.ktButtonClick == 5)
                                this.Text = "Search CTXH";
                            else
                                this.Text = "Search NoHP";
                        }
                    }
                }
            }
        }

        private void LoadData()
        {
            if (ktButton == 1 || ktButton == 2 || ktButton == 3)
            {
                this.cbbChonNamHoc.DataSource = hpBUS.getNamHoc();
                this.cbbChonNamHoc.DisplayMember = "NamHoc";
                this.cbbChonNamHoc.ValueMember = "NamHoc";

                this.cbbChonHocKy.DataSource = hpBUS.getHocKy();
                this.cbbChonHocKy.DisplayMember = "HocKy";
                this.cbbChonHocKy.ValueMember = "HocKy";
            }
            else
            {
                if (ktButton == 4)
                    this.dgcTimKiem.DataSource = svBUS.getDSSVCanhBaoHV();
                else
                {
                    if (ktButton == 5)
                        this.dgcTimKiem.DataSource = svBUS.getSVThieuDiemCTXH();
                    else
                        this.dgcTimKiem.DataSource = svBUS.getSVNoHocPhi();
                }

                this.btnReLoad.Enabled = true;
                this.btnIn.Enabled = true;
            }
        }
        #endregion

        #region Events

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if(ktButton == 1)
                this.dgcTimKiem.DataSource = svBUS.getDSSVHBNhatLop(this.cbbChonNamHoc.Text, Convert.ToInt32(this.cbbChonHocKy.Text));
            else
            {
                if(ktButton == 2)
                    this.dgcTimKiem.DataSource = svBUS.getDSSVHBGioi(this.cbbChonNamHoc.Text, Convert.ToInt32(this.cbbChonHocKy.Text));
                else
                    this.dgcTimKiem.DataSource = svBUS.getDSSVHBKha(this.cbbChonNamHoc.Text, Convert.ToInt32(this.cbbChonHocKy.Text));
            }

            this.btnReLoad.Enabled = true;
            this.btnIn.Enabled = true;
        }

        private void btnReLoad_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            frmReport f;
            if(ktButton == 1 || ktButton == 2 || ktButton == 3)
                f = new frmReport(this.cbbChonNamHoc.Text, Convert.ToInt32(this.cbbChonHocKy.Text), ktButton);
            else
                f = new frmReport(ktButton);
            f.ShowDialog();
        }
        #endregion
    }
}
