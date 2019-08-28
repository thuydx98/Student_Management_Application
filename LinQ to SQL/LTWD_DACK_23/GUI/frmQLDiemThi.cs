using System;
using System.Windows.Forms;
using BUS;

namespace GUI
{
    public partial class frmQLDiemThi : DevExpress.XtraEditors.XtraForm
    {
        DIemThiBUS dtBUS;
        HocPhanBUS hpBUS;
        SinhVienBUS svBUS;

        public frmQLDiemThi()
        {
            dtBUS = new DIemThiBUS();
            hpBUS = new HocPhanBUS();
            svBUS = new SinhVienBUS();
            InitializeComponent();
            LoadData();
        }

        #region Methods

        private void LoadData()
        {
            this.dgvDiemThi.OptionsBehavior.Editable = false;
            this.btnLuu.Enabled = false;
            this.btnHuy.Enabled = false;

            if (frmMain.user.LoaiUser == "Admin")
                this.cbbMonHoc.DataSource = hpBUS.getMHTrongHP();
            else
                this.cbbMonHoc.DataSource = hpBUS.getMHTrongHPTheoGV(frmMain.user.Ma);

            this.cbbMonHoc.DisplayMember = "TenMH";
            this.cbbMonHoc.ValueMember = "MaMH";
        }
        #endregion

        #region Events

        private void btnNhapDiem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;
            this.dgvDiemThi.OptionsBehavior.Editable = true;
            MaSV.OptionsColumn.AllowEdit = false;
            HoTen.OptionsColumn.AllowEdit = false;

            this.dgvDiemThi.FocusedColumn = DiemGiuaKy;
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool ktra = true;

            for (int i = 0; i < this.dgvDiemThi.RowCount; i++)
            {
                if (Convert.ToDecimal(this.dgvDiemThi.GetRowCellValue(i, DiemGiuaKy)) > 10 ||
                    Convert.ToDecimal(this.dgvDiemThi.GetRowCellValue(i, DiemGiuaKy)) < 0 ||
                    Convert.ToDecimal(this.dgvDiemThi.GetRowCellValue(i, DiemCuoiKy)) > 10 ||
                    Convert.ToDecimal(this.dgvDiemThi.GetRowCellValue(i, DiemCuoiKy)) < 0)
                {
                    MessageBox.Show(
                        "Điểm của SV " + this.dgvDiemThi.GetRowCellValue(i, MaSV).ToString() + " đã nhập sai.",
                        "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ktra = false;
                    break;
                }
            }

            if (ktra == true)
            {
                for (int i = 0; i < this.dgvDiemThi.RowCount; i++)
                {
                    if (!dtBUS.suaDiemThi(this.dgvDiemThi.GetRowCellValue(i, MaSV).ToString(), this.cbbHocPhan.Text,
                        Convert.ToDecimal(this.dgvDiemThi.GetRowCellValue(i, DiemGiuaKy) == null
                            ? 0
                            : this.dgvDiemThi.GetRowCellValue(i, DiemGiuaKy)),
                        Convert.ToDecimal(this.dgvDiemThi.GetRowCellValue(i, DiemCuoiKy) == null
                            ? 0
                            : this.dgvDiemThi.GetRowCellValue(i, DiemCuoiKy))))
                    {
                        MessageBox.Show("Khong Xoa duoc. Loi !!!", "THONG BAO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                }

                LoadData();
            }
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadData();
        }

        private void btnReLoad_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadData();
        }

        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmReport f = new frmReport(this.cbbHocPhan.Text, 13);
            f.ShowDialog();
        }

        private void cbbMonHoc_SelectedValueChanged(object sender, EventArgs e)
        {
            if (this.cbbMonHoc.Text != "")
            {
                var listHP = hpBUS.getHPTheoMH(this.cbbMonHoc.SelectedValue.ToString());

                this.cbbHocPhan.DataSource = listHP;
                this.cbbHocPhan.DisplayMember = "MaHP";
                this.cbbHocPhan.ValueMember = "MaHP";
            }
        }

        private void cbbHocPhan_SelectedValueChanged(object sender, EventArgs e)
        {
            
            if (this.cbbHocPhan.Text != "")
            {
                var hocPhan = hpBUS.getHPTheoMaHP(this.cbbHocPhan.SelectedValue.ToString());

                this.txtNamHoc.Text = hocPhan[0].NamHoc;
                this.txtHocKy.Text = hocPhan[0].HocKy.ToString();
                this.txtSoTC.Text = hocPhan[0].SoTC.ToString();
                this.txtMaGiaoVien.Text = hocPhan[0].MaGV.ToString();

                this.dgcDiemThi.DataSource = svBUS.getSVTheoMaHP(this.cbbHocPhan.SelectedValue.ToString());
            }
        }
        #endregion
    }
}
