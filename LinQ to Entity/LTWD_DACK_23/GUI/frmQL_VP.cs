using System;
using System.Windows.Forms;
using BUS;

namespace GUI
{
    public partial class frmQL_VP : DevExpress.XtraEditors.XtraForm
    {
        private ViPhamBUS vpBUS;
        private SinhVienBUS svBUS;
        bool Them;

        public frmQL_VP()
        {
            vpBUS = new ViPhamBUS();
            svBUS = new SinhVienBUS();
            InitializeComponent();
            LoadData();
        }
        #region Methods

        private int kTraDLNhapVao()
        {
            if (this.txtMaSV.Text == "")
                return 1;
            else
            {
                if (this.txtNoiDung.Text == "")
                    return 2;
                else
                {
                    if (this.txtHTKyLuat.Text == "")
                        return 3;
                    else
                    {
                        if (this.txtNgayViPham.Text == "")
                            return 4;
                    }
                }
            }
            return 0;
        }

        private bool kTraTrungID()
        {
            var vp = vpBUS.getVPByAllKey(this.txtMaSV.Text, this.txtNoiDung.Text, this.txtHTKyLuat.Text, Convert.ToDateTime(this.txtNgayViPham.Text));
            if (vp.Count != 0)
                return true;
            return false;
        }

        private void LuuDL()
        {
            int kt = kTraDLNhapVao();

            if (kt == 0)
            {
                if (Them)
                {
                    bool ktID = kTraTrungID();
                    if (!ktID)
                    {
                        if(vpBUS.themViPham(this.txtMaSV.Text, this.txtNoiDung.Text, this.txtHTKyLuat.Text, Convert.ToDateTime(this.txtNgayViPham.Text)))
                        {
                            MessageBox.Show("Đã thêm xong!");
                            LoadData();
                        }
                        else
                            MessageBox.Show("Khong them duoc. Loi !!!", "THONG BAO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Vi phạm đã bị trùng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    string maSV = dgvViPham.GetFocusedRowCellValue(MaSV).ToString();
                    string noiDung = dgvViPham.GetFocusedRowCellValue(NoiDung).ToString();
                    string htkl = dgvViPham.GetFocusedRowCellValue(HinhThucKL).ToString();
                    DateTime ngayVP = Convert.ToDateTime(dgvViPham.GetFocusedRowCellValue(NgayViPham));

                    if (vpBUS.xoaViPham(maSV, noiDung, htkl, ngayVP) &&
                        vpBUS.themViPham(this.txtMaSV.Text, this.txtNoiDung.Text, this.txtHTKyLuat.Text,
                            Convert.ToDateTime(this.txtNgayViPham.Text)))
                    {
                        MessageBox.Show("Đã sửa xong!");
                        LoadData();
                    }
                    else
                        MessageBox.Show("Khong them duoc. Loi !!!", "THONG BAO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (kt == 1)
                    MessageBox.Show("Mã SINH VIÊN không được để trống.", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    if (kt == 2)
                        MessageBox.Show("NỘI DUNG không được để trống.", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                    {
                        if(kt == 3)
                            MessageBox.Show("HÌNH THỨC KỶ LUẬT không được để trống.", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        else
                            MessageBox.Show("NGÀY VI PHẠM không được để trống.", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void LoadData()
        {
            this.txtMaSV.ResetText();
            this.txtNoiDung.ResetText();
            this.txtNgayViPham.ResetText();
            this.txtHTKyLuat.ResetText();

            this.lcgNhap.Enabled = false;
            this.btnLuu.Enabled = false;
            this.btnHuy.Enabled = false;

            this.btnThem.Enabled = true;
            this.btnSua.Enabled = true;
            this.btnXoa.Enabled = true;
            this.txtMaSV.Enabled = true;

            this.dgcViPham.DataSource = vpBUS.getViPham();
        }
        #endregion

        #region Events

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Them = true;

            // Cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;
            this.lcgNhap.Enabled = true;

            // Không cho thao tác trên các nút Thêm / Xóa
            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;

            // Them du lieu goi y cho textbox
            this.txtMaSV.AutoCompleteMode = AutoCompleteMode.Suggest;
            this.txtMaSV.AutoCompleteSource = AutoCompleteSource.CustomSource;

            // Them goi y cho textbox Nhap MaSV
            var lstMSSV = svBUS.getMSSV();
            AutoCompleteStringCollection AutoComp = new AutoCompleteStringCollection();
            foreach (var sv in lstMSSV)
                AutoComp.Add(sv);

            this.txtMaSV.AutoCompleteCustomSource = AutoComp;

            // Đưa con trỏ đến TextField txtMaKH
            this.txtMaSV.Focus();
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Kích hoạt biến Sửa
            Them = false;

            //  Các đối tượng trong panel
            this.txtMaSV.Enabled = false;

            // Chuyển thông tin lên panel
            this.txtMaSV.Text = dgvViPham.GetFocusedRowCellValue(MaSV).ToString();
            this.txtNoiDung.Text = dgvViPham.GetFocusedRowCellValue(NoiDung).ToString();
            this.txtHTKyLuat.Text = dgvViPham.GetFocusedRowCellValue(HinhThucKL).ToString();
            this.txtNgayViPham.Text = dgvViPham.GetFocusedRowCellValue(NgayViPham).ToString();

            // Cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;
            this.lcgNhap.Enabled = true;

            // Không cho thao tác trên các nút Thêm / Xóa / Tìm / ID
            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;

            // Đưa con trỏ đến TextField
            this.txtNoiDung.Focus();
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult traloi = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (traloi == DialogResult.OK)
            {
                string maSV = dgvViPham.GetFocusedRowCellValue(MaSV).ToString();
                string noiDung = dgvViPham.GetFocusedRowCellValue(NoiDung).ToString();
                string htkl = dgvViPham.GetFocusedRowCellValue(HinhThucKL).ToString();
                DateTime ngayVP = Convert.ToDateTime(dgvViPham.GetFocusedRowCellValue(NgayViPham));

                if (vpBUS.xoaViPham(maSV, noiDung, htkl, ngayVP))
                {
                    MessageBox.Show("Đã xóa xong.");
                    LoadData();
                }
                else
                    MessageBox.Show("Khong Xoa duoc. Loi !!!", "THONG BAO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LuuDL();
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadData();
        }

        private void txtNgayViPham_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue == 13)
                LuuDL();
        }
        #endregion
    }
}
