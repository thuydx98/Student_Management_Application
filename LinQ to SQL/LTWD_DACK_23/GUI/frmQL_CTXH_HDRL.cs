using System;
using System.Windows.Forms;
using BUS;

namespace GUI
{
    public partial class frmQL_CTXH_HDRL : DevExpress.XtraEditors.XtraForm
    {
        int ktButton;
        bool Them;
        CTXHBUS ctxhBUS;
        RenLuyenBUS rlBUS;
        SinhVienBUS svBUS;
        DSSV_CTXHBUS dsCTXHBUS;
        DSSV_RLBUS dsRLBUS;

        public frmQL_CTXH_HDRL()
        {
            ktButton = frmMain.ktButtonClick;
            ctxhBUS = new CTXHBUS();
            rlBUS = new RenLuyenBUS();
            svBUS = new SinhVienBUS();
            dsCTXHBUS = new DSSV_CTXHBUS();
            dsRLBUS = new DSSV_RLBUS();

            InitializeComponent();
            kiemTra();
            Clear();

            this.txtNhapMaSV.AutoCompleteMode = AutoCompleteMode.Suggest;
            this.txtNhapMaSV.AutoCompleteSource = AutoCompleteSource.CustomSource;

            var lstMSSV = svBUS.getMSSV();
            AutoCompleteStringCollection AutoComp = new AutoCompleteStringCollection();
            foreach (var sv in lstMSSV)
                AutoComp.Add(sv.MaSV);

            this.txtNhapMaSV.AutoCompleteCustomSource = AutoComp;
        }

        #region Methods

        private void kiemTra()
        {
            AutoCompleteStringCollection AutoComp = new AutoCompleteStringCollection();
            this.txtNhapMaHD.AutoCompleteMode = AutoCompleteMode.Suggest;
            this.txtNhapMaHD.AutoCompleteSource = AutoCompleteSource.CustomSource;

            if (frmMain.ktButtonClick == 10)
            {
                this.Text = "Quan Ly CTXH";
                this.txtHocKy.Enabled = false;
                this.txtNamHoc.Enabled = false;
                this.ckbCoMat.Enabled = false;

                var lstMaHD = ctxhBUS.getMaHDCTXH();
                foreach (var hd in lstMaHD)
                    AutoComp.Add(hd.MaHDCTXH);
            }
            else
            {
                this.Text = "Quan Ly HDRL";

                var lstMaHD = rlBUS.getMaHDRL();
                foreach (var hd in lstMaHD)
                    AutoComp.Add(hd.MaHDRL);
            }

            this.txtNhapMaHD.AutoCompleteCustomSource = AutoComp;
        }

        private int kiemTraID()
        {
            if (this.txtMaHD.Text == "") return 1;

            if(ktButton == 10)
            {
                if (ctxhBUS.getHDByMaHD(this.txtMaHD.Text).Count != 0)
                    return 2;
            }
            else
            {
                if (rlBUS.getHDRLByMaHD(this.txtMaHD.Text).Count != 0)
                    return 2;
            }

            return 0;
        }

        private void Clear()
        {
            // 3 panel for infor
            this.lcgTTHD.Enabled = false;
            this.lcgNhapSV.Enabled = false;
            this.lcgNhap.Enabled = true;

            // Reset all textboc
            this.txtNhapMaHD.ResetText();
            this.txtMaHD.ResetText();
            this.txtTenHD.ResetText();
            this.txtNgayTC.ResetText();
            this.txtDiaDiem.ResetText();
            this.txtSoDiemCong.ResetText();
            this.txtNamHoc.ResetText();
            this.txtHocKy.ResetText();
            this.txtNhapMaSV.ResetText();

            this.txtMaHD.Enabled = false;

            // Khong Cho thao tác trên các nút Lưu / Hủy
            this.btnLuu.Enabled = false;
            this.btnHuy.Enabled = false;

            // cho thao tác trên các nút Thêm / Xóa / Find
            this.btnThem.Enabled = true;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;

            this.dgcDSSV.DataSource = null;

            this.txtNhapMaHD.Focus();
        }

        private void DataBinding()
        {
            this.txtNhapMaSV.DataBindings.Clear();
            this.txtNhapMaSV.DataBindings.Add("Text", dgcDSSV.DataSource, "MaSV");

            this.txtNhapMaSV.Focus();
            this.txtNhapMaSV.SelectAll();
        }

        private void TimThongTin()
        {
            if(ktButton == 10)
            {
                var listCTXH = ctxhBUS.getHDByMaHD(this.txtNhapMaHD.Text);

                if (listCTXH.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy Hoạt Động Công Tác Xã Hội", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtNhapMaHD.SelectAll();
                }
                else
                {
                    this.lcgTTHD.Enabled = true;
                    this.lcgNhapSV.Enabled = true;

                    this.txtMaHD.Enabled = false;

                    this.txtMaHD.Text = listCTXH[0].MaHDCTXH;
                    this.txtTenHD.Text = listCTXH[0].TenHDCTXH;
                    this.txtNgayTC.Text = listCTXH[0].NgayTC.ToString();
                    this.txtDiaDiem.Text = listCTXH[0].DiaDiem;
                    this.txtSoDiemCong.Text = listCTXH[0].SoDiemCTXH.ToString();

                    this.dgcDSSV.DataSource = dsCTXHBUS.getSVByMaCTXH(this.txtNhapMaHD.Text);
                    this.btnXoa.Enabled = true;
                    this.btnSua.Enabled = true;

                    this.btnReLoad.Enabled = true;
                    this.btnIn.Enabled = true;

                    DataBinding();
                }
            }
            else
            {
                var listRL = rlBUS.getHDRLByMaHD(this.txtNhapMaHD.Text);

                if (listRL.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy Hoạt Động Rền Luyện", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtNhapMaHD.SelectAll();
                }
                else
                {
                    this.lcgTTHD.Enabled = true;
                    this.lcgNhapSV.Enabled = true;

                    this.txtMaHD.Enabled = false;

                    this.txtMaHD.Text = listRL[0].MaHDRL;
                    this.txtTenHD.Text = listRL[0].TenHDRL;
                    this.txtNgayTC.Text = listRL[0].NgayTC.ToString();
                    this.txtDiaDiem.Text = listRL[0].DiaDiem;
                    this.txtSoDiemCong.Text = listRL[0].SoDiemRL.ToString();
                    this.txtNamHoc.Text = listRL[0].NamHoc;
                    this.txtHocKy.Text = listRL[0].HocKy.ToString();

                    this.dgcDSSV.DataSource = dsRLBUS.getSVByMaRL(this.txtNhapMaHD.Text);
                    this.btnXoa.Enabled = true;
                    this.btnSua.Enabled = true;

                    this.btnReLoad.Enabled = true;
                    this.btnIn.Enabled = true;

                    DataBinding();
                }
            }
        }

        private void LuuHoatDong()
        {
            if (Them)
            {
                if (ktButton == 10)
                {
                    int ktID = kiemTraID();
                    if(ktID == 1)
                    {
                        MessageBox.Show("Mã Hoạt Động không được để trống.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.txtMaHD.Focus();
                        this.txtMaHD.SelectAll();
                    }
                    else
                    {
                        if(ktID == 2)
                        {
                            MessageBox.Show("Mã Hoạt Động đã tồn tại.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.txtMaHD.Focus();
                            this.txtMaHD.SelectAll();
                        }
                        else
                        {
                            if(ctxhBUS.themCTXH(this.txtMaHD.Text, this.txtTenHD.Text, this.txtDiaDiem.Text, this.txtNgayTC.Text == "" ?
                                DateTime.Today : Convert.ToDateTime(this.txtNgayTC.Text), this.txtSoDiemCong.Text == "" ? 0 : Convert.ToInt32(this.txtSoDiemCong.Text)))
                            {
                                MessageBox.Show("Đã thêm xong");
                                Clear();
                            }
                            else
                                MessageBox.Show("Không thêm được. Lỗi !!!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);                      
                        }
                    }
                }
                else
                {
                    int ktID = kiemTraID();
                    if (ktID == 1)
                    {
                        MessageBox.Show("Mã Hoạt Động không được để trống.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.txtMaHD.Focus();
                        this.txtMaHD.SelectAll();
                    }
                    else
                    {
                        if (ktID == 2)
                        {
                            MessageBox.Show("Mã Hoạt Động đã tồn tại.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.txtMaHD.Focus();
                            this.txtMaHD.SelectAll();
                        }
                        else
                        {
                            if(rlBUS.themRL(this.txtMaHD.Text, this.txtTenHD.Text, this.txtDiaDiem.Text, this.txtNgayTC.Text == "" ?
                                DateTime.Today : Convert.ToDateTime(this.txtNgayTC.Text), this.txtNamHoc.Text, this.txtHocKy.Text == "" ? 0 : Convert.ToInt32(this.txtHocKy.Text),
                                this.txtSoDiemCong.Text == "" ? 0 : Convert.ToInt32(this.txtSoDiemCong.Text)))
                            {
                                MessageBox.Show("Đã thêm xong");
                                Clear();
                            }
                            else
                                MessageBox.Show("Không thêm được. Lỗi !!!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);                      
                        }
                    }
                }
            }
            else
            {
                if (ktButton == 10)
                {
                    if(ctxhBUS.suaCTXH(this.txtMaHD.Text, this.txtTenHD.Text, this.txtDiaDiem.Text, this.txtNgayTC.Text == "" ?
                                DateTime.Today : Convert.ToDateTime(this.txtNgayTC.Text), this.txtSoDiemCong.Text == "" ? 0 : Convert.ToInt32(this.txtSoDiemCong.Text)))
                    {
                        MessageBox.Show("Đã sửa xong");
                        Clear();
                    }
                    else
                        MessageBox.Show("Không sửa được. Lỗi !!!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if(rlBUS.suaRL(this.txtMaHD.Text, this.txtTenHD.Text, this.txtDiaDiem.Text, this.txtNgayTC.Text == "" ?
                                DateTime.Today : Convert.ToDateTime(this.txtNgayTC.Text), this.txtNamHoc.Text, this.txtHocKy.Text == "" ? 0 : Convert.ToInt32(this.txtHocKy.Text),
                                this.txtSoDiemCong.Text == "" ? 0 : Convert.ToInt32(this.txtSoDiemCong.Text)))
                    {
                        MessageBox.Show("Đã sửa xong");
                        Clear();
                    }
                    else
                        MessageBox.Show("Không sửa được. Lỗi !!!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ThemSV()
        {
            var sv = svBUS.getSVTheoMaSV(this.txtNhapMaSV.Text);

            if (sv.Count == 0)
                MessageBox.Show("Sinh Viên không tồn tại.", "Thống Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (ktButton == 10)
                {
                    if (dsCTXHBUS.getSVByMaSV_MaHDCTXH(this.txtMaHD.Text, this.txtNhapMaSV.Text).Count != 0)
                    {
                        MessageBox.Show("Sinh Viên đã được thêm trong Hoạt Động CÔNG TÁC XÃ HỘI này.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if(dsCTXHBUS.themDSSV_HDCTXH(this.txtNhapMaSV.Text, this.txtMaHD.Text))
                        {
                            MessageBox.Show("Đã thêm xong");
                            this.dgcDSSV.DataSource = dsCTXHBUS.getSVByMaCTXH(this.txtNhapMaHD.Text);
                        }
                        else
                            MessageBox.Show("Không thêm được. Lỗi !!!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);                                
                    }
                }
                else
                {
                    if (dsRLBUS.getSVByMaSV_MaHDRL(this.txtMaHD.Text, this.txtNhapMaSV.Text).Count != 0)
                        MessageBox.Show("Sinh Viên đã được thêm trong Hoạt Động RÈN LUYỆN này.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        if(dsRLBUS.themDSSV_HDRL(this.txtNhapMaSV.Text, this.txtMaHD.Text, this.ckbCoMat.CheckState == CheckState.Checked ? true : false))
                        {
                        MessageBox.Show("Đã thêm xong");
                        this.dgcDSSV.DataSource = dsRLBUS.getSVByMaRL(this.txtNhapMaHD.Text);
                        }
                        else
                            MessageBox.Show("Không thêm được. Lỗi !!!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                    }
                }
            }
            DataBinding();
        }
        #endregion

        #region Events

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Them = true;

            this.lcgNhap.Enabled = false;
            this.lcgNhapSV.Enabled = false;
            this.lcgTTHD.Enabled = true;

            this.txtMaHD.ResetText();
            this.txtTenHD.ResetText();
            this.txtNgayTC.ResetText();
            this.txtDiaDiem.ResetText();
            this.txtSoDiemCong.ResetText();
            this.txtNamHoc.ResetText();
            this.txtHocKy.ResetText();

            this.txtMaHD.Enabled = true;

            // Cho thao tác trên các nút Lưu / Hủy
            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;

            // Không cho thao tác trên các nút Thêm / Xóa / Find
            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;

            this.txtMaHD.Focus();
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Them = false;

            // Cho phép thao tác trên Panel / Các đối tượng trong panel
            this.lcgNhap.Enabled = false;
            this.lcgNhapSV.Enabled = false;

            this.txtMaHD.Enabled = false;

            // Cho thao tác trên các nút Lưu / Hủy
            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;

            // Không cho thao tác trên các nút Thêm / Xóa / Find
            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;

            // Đưa con trỏ đến TextField
            this.txtTenHD.Focus();
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult traloi = MessageBox.Show("Bạn có chắc chắn muốn xóa HOẠT ĐỘNG " + this.txtMaHD.Text + " không? \nLƯU Ý: " +
                "Việc xóa HOẠT ĐỘNG sẽ xóa TOÀN BỘ SINH VIÊN trong HOẠT ĐỘNG đó.", 
                "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (traloi == DialogResult.OK)
            {
                if (ktButton == 10)
                {               
                    if(ctxhBUS.xoaCTXH(this.txtMaHD.Text))
                    {
                        MessageBox.Show("Đã xóa xong.");
                        Clear();
                    }
                    else
                        MessageBox.Show("Không xoá được. Lỗi !!!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if(rlBUS.xoaRL(this.txtMaHD.Text))
                    {
                        MessageBox.Show("Đã xóa xong.");
                        Clear();
                    }
                    else
                        MessageBox.Show("Không xoá được. Lỗi !!!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LuuHoatDong();
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Clear();
        }

        private void btnReLoad_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            TimThongTin();
        }

        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmReport f = new frmReport(this.txtMaHD.Text, ktButton);
            f.ShowDialog();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            TimThongTin();
        }

        private void txtNhapMaHD_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue == 13)
                TimThongTin();
        }

        private void btnThemSV_Click(object sender, EventArgs e)
        {
            ThemSV();
        }

        private void txtNhapMaSV_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
                ThemSV();
        }

        private void btnXoaSV_Click(object sender, EventArgs e)
        {
            DialogResult traloi = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (traloi == DialogResult.OK)
            {
                string maSV = dgvDSSV.GetFocusedRowCellValue("MaSV").ToString();

                if(ktButton == 10)
                {
                    if(dsCTXHBUS.xoaDSSV_HDCTXH(maSV, this.txtMaHD.Text))
                    {
                        MessageBox.Show("Đã xóa xong.");
                        this.dgcDSSV.DataSource = dsCTXHBUS.getSVByMaCTXH(this.txtNhapMaHD.Text);
                        DataBinding();
                    }
                    else
                        MessageBox.Show("Không xoá được. Lỗi !!!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if(dsRLBUS.xoaDSSV_HDRL(maSV, this.txtMaHD.Text))
                    {
                        MessageBox.Show("Đã xóa xong.");
                        this.dgcDSSV.DataSource = dsRLBUS.getSVByMaRL(this.txtMaHD.Text);
                        DataBinding();
                    }
                    else
                        MessageBox.Show("Không xoá được. Lỗi !!!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion
    }
}
