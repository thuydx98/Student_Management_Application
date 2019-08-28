using System;
using System.Windows.Forms;
using BUS;

namespace GUI
{
    public partial class frmTKDiemThi : DevExpress.XtraEditors.XtraForm
    {
        DIemThiBUS dtBUS;
        SinhVienBUS svBUS;

        public frmTKDiemThi()
        {
            dtBUS = new DIemThiBUS();
            svBUS = new SinhVienBUS();
            InitializeComponent();
            if(frmMain.user.LoaiUser == "SinhVien")
            {
                this.txtNhapMSSV.Text = frmMain.user.Ma;
                TimThongTin();
                this.txtNhapMSSV.Enabled = false;
            }
            else
            {               
                this.txtNhapMSSV.AutoCompleteMode = AutoCompleteMode.Suggest;
                this.txtNhapMSSV.AutoCompleteSource = AutoCompleteSource.CustomSource;

                var lstMSSV = svBUS.getMSSV();
                AutoCompleteStringCollection AutoComp = new AutoCompleteStringCollection();
                foreach (var sv in lstMSSV)
                    AutoComp.Add(sv);

                this.txtNhapMSSV.AutoCompleteCustomSource = AutoComp;
            }
        }

        #region Methods

        private void TimThongTin()
        {
            var listDiemThi = dtBUS.getDiemTheoMSSV(this.txtNhapMSSV.Text);

            if (listDiemThi.Count == 0)
            {
                MessageBox.Show("Không tìm thấy SINH VIÊN.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtNhapMSSV.SelectAll();
            }
            else
            {
                this.btnReLoad.Enabled = true;
                this.btnInBangDiem.Enabled = true;

                this.dgcBangDiemSV.DataSource = listDiemThi;

                this.txtMSSV.Text = listDiemThi[0].MaSV;
                this.txtHoTen.Text = listDiemThi[0].HoTen;
                this.txtNgaySinh.Text = listDiemThi[0].NgaySinh.ToString();
                this.txtDiaChi.Text = listDiemThi[0].DiaChi;
                this.txtGioiTinh.Text = listDiemThi[0].GioiTinh;
                this.txtDanToc.Text = listDiemThi[0].DanToc;
                this.txtQueQuan.Text = listDiemThi[0].QueQuan;
                this.txtLop.Text = listDiemThi[0].MaLop;

                int? soTCTL = svBUS.getDiemTBTL_SoTCTL(this.txtMSSV.Text)[0].SoTCTL;
                double tbTL = Convert.ToDouble(svBUS.getDiemTBTL_SoTCTL(this.txtMSSV.Text)[0].DTBTL);
                this.txtTBTichLuy.Text = Math.Round(tbTL, 2).ToString();
                this.txtSoTCTichLuy.Text = soTCTL.ToString();

                double tb = Convert.ToDouble(svBUS.getDiemTB_SoTC(this.txtMSSV.Text)[0].DTB);
                int? soTC = svBUS.getDiemTB_SoTC(this.txtMSSV.Text)[0].SoTC;
                this.txtTBToanKhoa.Text = Math.Round(tb, 2).ToString();
                 
                if (tbTL >= 8.5)
                    this.txtXLHL.Text = "Giỏi";
                else
                {
                    if (tbTL >= 7)
                        this.txtXLHL.Text = "Khá";
                    else
                    {
                        if (tbTL >= 5)
                            this.txtXLHL.Text = "Trung Bình";
                        else
                        {
                            if (tbTL >= 3.5)
                                this.txtXLHL.Text = "Yếu";
                            else
                                this.txtXLHL.Text = "Kém";
                        }
                    }
                }
            }
        }
        #endregion

        #region Events

        private void txtNhapMSSV_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                TimThongTin();
                this.txtNhapMSSV.SelectAll();
            }
        }

        private void btnReLoad_Click(object sender, EventArgs e)
        {
            TimThongTin();
            this.txtNhapMSSV.SelectAll();
        }

        private void btnInBangDiem_Click(object sender, EventArgs e)
        {
            frmReport f = new frmReport(this.txtMSSV.Text, this.txtTBToanKhoa.Text, this.txtTBTichLuy.Text, this.txtSoTCTichLuy.Text, this.txtXLHL.Text);
            f.ShowDialog();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            TimThongTin();
        }
        #endregion
    }
}
