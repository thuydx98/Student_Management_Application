using System;
using System.Windows.Forms;
using BUS;

namespace GUI
{
    public partial class frmTK_HoatDong : DevExpress.XtraEditors.XtraForm
    {
        HocPhanBUS hpBUS;
        SinhVienBUS svBUS;
        CTXHBUS ctxhBUS;
        DSSV_CTXHBUS dsCTXHBUS;
        RenLuyenBUS rlBUS;
        DSSV_RLBUS dsRLBUS;
        ViPhamBUS vpBUS;
        int ktButton;

        public frmTK_HoatDong()
        {
            hpBUS = new HocPhanBUS();
            svBUS = new SinhVienBUS();
            ctxhBUS = new CTXHBUS();
            dsCTXHBUS = new DSSV_CTXHBUS();
            rlBUS = new RenLuyenBUS();
            dsRLBUS = new DSSV_RLBUS();
            vpBUS = new ViPhamBUS();
            ktButton = frmMain.ktButtonClick;

            InitializeComponent();
            kiemTra();
            if (frmMain.user.LoaiUser == "SinhVien")
            {
                this.txtNhapMSSV.Text = frmMain.user.Ma;
                this.txtNhapMSSV.Enabled = false;
                TimThongTin();
            }
            else
            {
                this.txtNhapMSSV.AutoCompleteMode = AutoCompleteMode.Suggest;
                this.txtNhapMSSV.AutoCompleteSource = AutoCompleteSource.CustomSource;

                var lstMSSV = svBUS.getMSSV();
                AutoCompleteStringCollection AutoComp = new AutoCompleteStringCollection();
                foreach (var sv in lstMSSV)
                    AutoComp.Add(sv.MaSV);

                this.txtNhapMSSV.AutoCompleteCustomSource = AutoComp;
            }
        }

        #region Methods

        private void kiemTra()
        {
            if (frmMain.ktButtonClick == 8)
            {
                this.Text = "TK HD Ren Luyen";
                this.lblTong.Text = "Tổng Điểm Rèn Luyện:";
                LoadData();
            }
            else
            {
                this.cbbHocKy.Enabled = false;
                this.cbbNamHoc.Enabled = false;
                this.txtXLRL.Enabled = false;

                if (frmMain.ktButtonClick == 7)
                {
                    this.Text = "TK CT Xa Hoi";
                    this.lblTong.Text = "Tổng Điểm CTXH:";
                }
                else
                {
                    if (frmMain.ktButtonClick == 12)
                    {
                        this.Text = "TK Hoc Phi";
                        this.lblTong.Text = "Tổng Nợ HP:";
                    }
                    else
                    {
                        this.Text = "TK Vi Pham";
                        this.txtTong.Enabled = false;
                    }
                }
            }
        }

        private void LoadData()
        {
            this.cbbNamHoc.DataSource = hpBUS.getNamHoc();
            this.cbbNamHoc.DisplayMember = "NamHoc";
            this.cbbNamHoc.ValueMember = "NamHoc";

            this.cbbHocKy.DataSource = hpBUS.getHocKy();
            this.cbbHocKy.DisplayMember = "HocKy";
            this.cbbHocKy.ValueMember = "HocKy";
        }

        private void TimThongTin()
        {
            var sv = svBUS.getSVTheoMaSV(this.txtNhapMSSV.Text);

            if (sv.Count == 0)
                MessageBox.Show("Không tìm thấy SINH VIÊN.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else
            {
                // Can use btnReload btnReport
                this.btnReLoad.Enabled = true;
                this.btnIn.Enabled = true;

                this.txtMSSV.Text = sv[0].MaSV;
                this.txtHoTen.Text = sv[0].HoTen;
                this.txtNgaySinh.Text = sv[0].NgaySinh.ToString();
                this.txtDiaChi.Text = sv[0].DiaChi;
                this.txtGioiTinh.Text = sv[0].GioiTinh;
                this.txtDanToc.Text = sv[0].DanToc;
                this.txtQueQuan.Text = sv[0].QueQuan;
                this.txtLop.Text = sv[0].MaLop;

                if(ktButton == 7)
                {
                    this.dgcTK_HoatDong.DataSource = ctxhBUS.getHDCTXHByMaSV(this.txtNhapMSSV.Text);

                    int? tong = dsCTXHBUS.getTongDiemHDCTXHByMaSV(this.txtMSSV.Text)[0].TongDiem;
                    this.txtTong.Text = tong.ToString();
                }
                else
                {
                    if (ktButton == 8)
                    {
                        this.dgcTK_HoatDong.DataSource = rlBUS.getHDRLByMaSV_NamHoc_HocKy(this.txtNhapMSSV.Text,
                            this.cbbNamHoc.SelectedValue.ToString(),
                            Convert.ToInt32(this.cbbHocKy.SelectedValue.ToString()));

                        int? tongDRL = 0;

                        int? diemCong = dsRLBUS.getTongDiemCongRLByMaSV_NamHoc_HocKy(this.txtMSSV.Text,
                            this.cbbNamHoc.SelectedValue.ToString(),
                            Convert.ToInt32(this.cbbHocKy.SelectedValue.ToString()))[0].DiemCong;
                        if (diemCong != null)
                            tongDRL += diemCong;

                        int? diemTru = dsRLBUS.getTongDiemTruRLByMaSV_NamHoc_HocKy(this.txtMSSV.Text,
                            this.cbbNamHoc.SelectedValue.ToString(),
                            Convert.ToInt32(this.cbbHocKy.SelectedValue.ToString()))[0].DiemTru;
                        if (diemTru != null)
                            tongDRL -= diemTru;
                        this.txtTong.Text = tongDRL.ToString();

                        if (tongDRL >= 90)
                            this.txtXLRL.Text = "Xuất sắc";
                        else
                        {
                            if (tongDRL >= 80)
                                this.txtXLRL.Text = "Tốt";
                            else
                            {
                                if (tongDRL >= 70)
                                    this.txtXLRL.Text = "Khá";
                                else
                                {
                                    if (tongDRL >= 50)
                                        this.txtXLRL.Text = "Trung Bình";
                                    else
                                        this.txtXLRL.Text = "Yếu";
                                }
                            }
                        }
                    }
                    else
                    {
                        if(ktButton == 12)
                        {
                            this.dgcTK_HoatDong.DataSource = hpBUS.getHPByMaSV(this.txtNhapMSSV.Text);
                            this.txtTong.Text = hpBUS.getTongNoHPByMaSV(this.txtNhapMSSV.Text)[0].TongNo.ToString() == "" 
                                ? "0" : hpBUS.getTongNoHPByMaSV(this.txtNhapMSSV.Text)[0].TongNo.ToString();
                        }
                        else
                            this.dgcTK_HoatDong.DataSource = vpBUS.getVPByMaSV(this.txtNhapMSSV.Text);
                    }
                }
            }
            this.txtNhapMSSV.SelectAll();
        }
        #endregion

        #region Events

        private void btnReLoad_Click(object sender, EventArgs e)
        {
            TimThongTin();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            frmReport f;

            if (frmMain.ktButtonClick == 8)
                f = new frmReport(this.txtMSSV.Text, this.txtHoTen.Text, this.txtLop.Text, this.cbbNamHoc.Text, Convert.ToInt32(this.cbbHocKy.Text),
                    this.txtTong.Text, this.txtXLRL.Text);
            else
                f = new frmReport(this.txtMSSV.Text, this.txtHoTen.Text, this.txtLop.Text, this.txtTong.Text, ktButton);

            f.ShowDialog();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            TimThongTin();
        }

        private void txtNhapMSSV_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue == 13)
                TimThongTin();
        }
        #endregion
    }
}
