using System.Windows.Forms;
using BUS;

namespace GUI
{
    public partial class frmQuanLyNguoiDung : Form
    {
        int check = 0;
        GiangVienBUS gvBUS;
        SinhVienBUS svBUS;
        TaiKhoanBUS tkBUS;

        public frmQuanLyNguoiDung()
        {
            gvBUS = new GiangVienBUS();
            svBUS = new SinhVienBUS();
            tkBUS = new TaiKhoanBUS();
            InitializeComponent();
            LoadData();
        }

        #region Methods

        private void LoadData()
        {
            // Xóa trống các đối tượng trong Panel
            this.txtTaiKhoan.ResetText();
            this.txtMatKhau.ResetText();
            this.cbbLoaiTK.ResetText();
            this.txtMa.ResetText();
            // Không cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnThucThi.Enabled = false;
            this.btnHuyBo.Enabled = false;
            this.pnNhapTT.Enabled = false;
            // Mở cho thao tác những cái trong Panel
            this.txtTaiKhoan.Enabled = true;
            this.txtMatKhau.Enabled = true;
            this.cbbLoaiTK.Enabled = true;
            this.txtMa.Enabled = true;
            // Cho thao tác trên các nút Thêm / Sửa / Xóa / Tìm Kiếm / Thoát
            this.btnThem.Enabled = true;
            this.btnSua.Enabled = true;
            this.btnXoa.Enabled = true;
            this.btnTim.Enabled = true;

            dgcQuanLyNguoiDung.DataSource = tkBUS.getTaiKhoan();

            string[] loaiTK = { "Admin", "GiangVien", "SinhVien" };

            cbbLoaiTK.DataSource = loaiTK;
        }

        private int kTraDLNhapVao()
        {
            if (this.txtTaiKhoan.Text == "")
                return 1;
            if(this.txtMatKhau.Text == "")
                return 2;
            if ((this.cbbLoaiTK.Text == "SinhVien" && svBUS.getSVTheoMaSV(this.txtMa.Text).Count == 0) || ((this.cbbLoaiTK.Text == "GiangVien" || this.cbbLoaiTK.Text == "Admin") && gvBUS.getGVTheoMaGV(this.txtMa.Text).Count == 0))
                return 3;
            return 0;
        }

        private bool kTraTrungID()
        {
            if (tkBUS.getTKTheoTK(this.txtTaiKhoan.Text).Count == 0)
                return false;
            return true;
        }
        #endregion

        #region Events

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            check = 1;

            // Xóa trống các đối tượng trong panel
            this.txtMatKhau.ResetText();
            this.txtTaiKhoan.ResetText();
            this.txtMa.ResetText();

            // Cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnThucThi.Enabled = true;
            this.btnHuyBo.Enabled = true;
            this.pnNhapTT.Enabled = true;

            // Không cho thao tác trên các nút Thêm / Xóa / Find
            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnTim.Enabled = false;

            // Đưa con trỏ đến TextField txtMaKH
            this.txtTaiKhoan.Focus();
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Kích hoạt biến Sửa
            check = 2;

            // Cho phép thao tác trên Panel / Các đối tượng trong panel
            this.pnNhapTT.Enabled = true;
            this.txtMatKhau.Enabled = true;
            this.cbbLoaiTK.Enabled = true;
            this.txtMa.Enabled = true;

            // Chuyển thông tin lên panel
            this.txtTaiKhoan.Text = dgvQuanLyNguoiDung.GetFocusedRowCellValue(TaiKhoan).ToString();
            this.txtMatKhau.Text = dgvQuanLyNguoiDung.GetFocusedRowCellValue(MatKhau).ToString();
            this.cbbLoaiTK.SelectedItem = dgvQuanLyNguoiDung.GetFocusedRowCellValue(LoaiUser).ToString();
            this.txtMa.Text = dgvQuanLyNguoiDung.GetFocusedRowCellValue(Ma).ToString();

            // Cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnThucThi.Enabled = true;
            this.btnHuyBo.Enabled = true;
            this.pnNhapTT.Enabled = true;

            // Không cho thao tác trên các nút Thêm / Xóa / Tìm / ID
            this.txtTaiKhoan.Enabled = false;
            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnTim.Enabled = false;

            // Đưa con trỏ đến TextField
            this.txtMatKhau.Focus();
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult traloi = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (traloi == DialogResult.OK)
            {
                string maTaiKhoan = dgvQuanLyNguoiDung.GetFocusedRowCellValue(TaiKhoan).ToString();

                if (tkBUS.xoaTaiKhoan(maTaiKhoan))
                {
                    LoadData();
                    MessageBox.Show("Đã xóa xong.");
                }
                else
                    MessageBox.Show("Không xóa được. Lỗi!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TheoTaiKhoan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            check = 3;

            this.pnNhapTT.Enabled = true;
            this.txtTaiKhoan.Enabled = true;
            this.txtMatKhau.Enabled = false;
            this.cbbLoaiTK.Enabled = false;
            this.txtMa.Enabled = false;

            this.txtTaiKhoan.ResetText();

            this.btnThucThi.Enabled = true;
            this.btnHuyBo.Enabled = true;

            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnTim.Enabled = false;

            this.txtTaiKhoan.AutoCompleteMode = AutoCompleteMode.Suggest;
            this.txtTaiKhoan.AutoCompleteSource = AutoCompleteSource.CustomSource;

            var lstTK = tkBUS.getTaiKhoan();
            AutoCompleteStringCollection AutoComp = new AutoCompleteStringCollection();
            foreach (var tk in lstTK)
                AutoComp.Add(tk.TaiKhoan);

            this.txtTaiKhoan.AutoCompleteCustomSource = AutoComp;

            this.txtTaiKhoan.Focus();
        }

        private void TheoLoaiTK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            check = 4;

            this.pnNhapTT.Enabled = true;
            this.txtTaiKhoan.Enabled = false;
            this.txtMatKhau.Enabled = false;
            this.cbbLoaiTK.Enabled = true;
            this.txtMa.Enabled = false;

            this.cbbLoaiTK.ResetText();

            this.btnThucThi.Enabled = true;
            this.btnHuyBo.Enabled = true;
            this.pnNhapTT.Enabled = true;

            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnTim.Enabled = false;

            this.cbbLoaiTK.Focus();
        }

        private void TheoMaGV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            check = 5;

            this.pnNhapTT.Enabled = true;
            this.txtTaiKhoan.Enabled = false;
            this.txtMatKhau.Enabled = false;
            this.cbbLoaiTK.Enabled = false;
            this.txtMa.Enabled = true;

            this.txtMa.ResetText();

            this.btnThucThi.Enabled = true;
            this.btnHuyBo.Enabled = true;
            
            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnTim.Enabled = false;

            this.txtMa.AutoCompleteMode = AutoCompleteMode.Suggest;
            this.txtMa.AutoCompleteSource = AutoCompleteSource.CustomSource;

            var lstGV = gvBUS.getMaGV(); 
            var lstSV = svBUS.getMSSV();

            AutoCompleteStringCollection AutoComp = new AutoCompleteStringCollection();
            foreach (var gv in lstGV)
                AutoComp.Add(gv);
            foreach (var sv in lstSV)
                AutoComp.Add(sv);

            this.txtMa.AutoCompleteCustomSource = AutoComp;

            this.txtMa.Focus();
        }

        private void btnThucThi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (check == 1 || check == 2)
            {
                int kt = kTraDLNhapVao();

                if (kt == 0)
                {
                    if (check == 1)
                    {
                        bool ktID = kTraTrungID();
                        if (!ktID)
                        {
                            if (tkBUS.themTaiKhoan(this.txtTaiKhoan.Text, this.txtMatKhau.Text, this.cbbLoaiTK.Text, this.txtMa.Text))
                            {
                                MessageBox.Show("Đã thêm xong!");
                                LoadData();
                            }
                            else
                                MessageBox.Show("Không thêm được. Lỗi!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                            MessageBox.Show("Tài Khoản đã bị trùng.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    if (check == 2)
                    {
                        if (tkBUS.suaTaiKhoan(this.txtTaiKhoan.Text, this.txtMatKhau.Text, this.cbbLoaiTK.Text, this.txtMa.Text))
                        {
                            MessageBox.Show("Đã sửa xong!");
                            LoadData();
                        }
                        else
                            MessageBox.Show("Không sửa được. Lỗi!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (kt == 1)
                        MessageBox.Show("Tài khoản không được để trống.", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                    {
                        if(kt == 2)
                            MessageBox.Show("Mật Khẩu không được để trống.", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        else
                            MessageBox.Show("Mã Giảng Viên / Sinh Viên không tồn tại.", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                btnSua.Enabled = true;
                btnXoa.Enabled = true;

                if (check == 3)
                    dgcQuanLyNguoiDung.DataSource = tkBUS.getTKTheoTK(this.txtTaiKhoan.Text);
                else
                {
                    if (check == 4)
                        dgcQuanLyNguoiDung.DataSource = tkBUS.getTKTheoLoaiUser(this.cbbLoaiTK.Text);
                    else
                        dgcQuanLyNguoiDung.DataSource = tkBUS.getTKTheoMaGV(this.txtMa.Text);
                }
            }
        }

        private void btnHuyBo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadData();
        }

        private void btnReLoad_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadData();
        }
        #endregion
    }
}
