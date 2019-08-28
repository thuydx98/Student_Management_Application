using System;
using System.Windows.Forms;
using BUS;
using DAO;


namespace GUI
{
    public partial class frmSinhVien : DevExpress.XtraEditors.XtraForm
    {
        int check = 0;
        LopBUS lopBUS;
        ChuyenNganhBUS cnBUS;
        GiangVienBUS gvBUS;
        KhoaBUS khoaBUS;
        SinhVienBUS svBUS;

        public frmSinhVien()
        {
            lopBUS = new LopBUS();
            cnBUS = new ChuyenNganhBUS();
            gvBUS = new GiangVienBUS();
            khoaBUS = new KhoaBUS();
            svBUS = new SinhVienBUS();
            InitializeComponent();
            LoadData();
        }

        #region Methods

        private void LoadData()
        {
            // Allow Them / Sua / Xoa / txtSiSo
            this.btnThem.Enabled = true;
            this.btnSua.Enabled = true;
            this.btnXoa.Enabled = true;
            this.txtSiSo.Enabled = true;
            this.txtMaSinhVien.Enabled = false;
            this.cbbTruongKhoa.Enabled = true;
            this.cbbMaKhoa.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbbMaKhoa.Enabled = true;
            this.cbbMaChuyenNganh.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbbMaChuyenNganh.Enabled = true;
            this.cbbMaLop.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbbMaLop.Enabled = true;

            // Can not use btnLuu btnHuy
            this.btnThucThi.Enabled = false;
            this.btnHuyBo.Enabled = false;

            //lcgKhoa
            this.cbbMaKhoa.DataSource = khoaBUS.getKhoa();
            this.cbbMaKhoa.DisplayMember = "MaKhoa";
            this.cbbMaKhoa.ValueMember = "MaKhoa";

            string[] gioiTinh = { "", "Nam", "Nu" };
            this.cbbGioiTinh.DataSource = gioiTinh;

            // Mở thao tác cho 4 panel
            this.lcgKhoa.Enabled = true;
            this.lcgChuyenNganh.Enabled = true;
            this.lcgLop.Enabled = true;
            this.lcgSV.Enabled = true;

            // Import DL cho ComBoBox
            this.cbbMaKhoa_ChuyenNganh.DataSource = khoaBUS.getKhoa();
            cbbMaKhoa_ChuyenNganh.DisplayMember = "TenKhoa";
            cbbMaKhoa_ChuyenNganh.ValueMember = "MaKhoa";

            this.cbbMaChuyenNganh_Lop.DataSource = cnBUS.getChuyenNganh();
            this.cbbMaChuyenNganh_Lop.DisplayMember = "TenChuyenNganh";
            this.cbbMaChuyenNganh_Lop.ValueMember = "MaChuyenNganh";

            this.cbbMaLop_SinhVien.DataSource = lopBUS.getLop();
            this.cbbMaLop_SinhVien.DisplayMember = "MaLop";
            this.cbbMaLop_SinhVien.ValueMember = "MaLop";
        }

        private void DataBind()
        {
            this.txtMaSinhVien.DataBindings.Clear();
            this.txtHoTen.DataBindings.Clear();
            this.txtNgaySinh.DataBindings.Clear();
            this.txtDiaChi.DataBindings.Clear();
            this.cbbGioiTinh.DataBindings.Clear();
            this.txtDanToc.DataBindings.Clear();
            this.txtQueQuan.DataBindings.Clear();

            this.txtMaSinhVien.DataBindings.Add("Text", dgcSinhVien.DataSource, "MaSV");
            this.txtHoTen.DataBindings.Add("Text", dgcSinhVien.DataSource, "HoTen");
            this.txtNgaySinh.DataBindings.Add("Text", dgcSinhVien.DataSource, "NgaySinh");
            this.txtDiaChi.DataBindings.Add("Text", dgcSinhVien.DataSource, "DiaChi");
            this.cbbGioiTinh.DataBindings.Add("SelectedItem", dgvSinhVien.DataSource, "GioiTinh");
            this.txtDanToc.DataBindings.Add("Text", dgcSinhVien.DataSource, "DanToc");
            this.txtQueQuan.DataBindings.Add("Text", dgcSinhVien.DataSource, "QueQuan");
        }

        private void funThemKhoa()
        {
            if (this.cbbMaKhoa.Text == "")
            {
                MessageBox.Show("Mã Khoa không được để trống.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.cbbMaKhoa.Focus();
            }
            else
            {
                if(khoaBUS.getKTheoMaKhoa(this.cbbMaKhoa.Text).Count != 0)
                {
                    MessageBox.Show("Mã Khoa đã tồn tại.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.cbbMaKhoa.Focus();
                }
                else
                {
                    if (khoaBUS.themKhoa(this.cbbMaKhoa.Text, this.txtTenKhoa.Text, null, this.txtSDTKhoa.Text))
                    {
                        MessageBox.Show("Đã thêm xong.");
                        LoadData();
                    }
                    else
                        MessageBox.Show("Không thể thêm. Lỗi!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void funThemChuyenNganh()
        {
            if (this.cbbMaChuyenNganh.Text == "")
            {
                MessageBox.Show("Mã Chuyên Ngành không được để trống.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.cbbMaChuyenNganh.Focus();
            }
            else
            {
                if (cnBUS.getCNTheoMaCN(this.cbbMaChuyenNganh.Text).Count != 0)
                {
                    MessageBox.Show("Mã Chuyên Ngành đã tồn tại.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.cbbMaChuyenNganh.Focus();
                }
                else
                {
                    if (cnBUS.themChuyenNganh(this.cbbMaChuyenNganh.Text, this.txtTenChuyenNganh.Text, this.cbbMaKhoa_ChuyenNganh.SelectedValue.ToString()))
                    {
                        MessageBox.Show("Đã thêm xong.");
                        LoadData();
                    }
                    else
                        MessageBox.Show("Không thể thêm. Lỗi!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void funThemLop()
        {
            if (this.cbbMaLop.Text == "")
            {
                MessageBox.Show("Mã Lớp không được để trống.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.cbbMaLop.Focus();
            }
            else
            {
                if (lopBUS.getLopTheoMaLop(this.cbbMaLop.Text).Count != 0)
                {
                    MessageBox.Show("Mã Lớp đã tồn tại.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.cbbMaLop.Focus();
                }
                else
                {
                    if (lopBUS.themLop(this.cbbMaLop.Text, this.cbbMaChuyenNganh_Lop.SelectedValue.ToString()))
                    {
                        MessageBox.Show("Đã thêm xong.");
                        LoadData();
                    }
                    else
                        MessageBox.Show("Không thể thêm. Lỗi!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void funThemSinhVien()
        {
            if (this.txtMaSinhVien.Text == "")
            {
                MessageBox.Show("Mã Sinh Viên không được để trống.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtMaSinhVien.Focus();
            }
            else
            {
                if (svBUS.getSVTheoMaSV(this.txtMaSinhVien.Text).Count != 0)
                {
                    MessageBox.Show("Mã Sinh Viên đã tồn tại.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.txtMaSinhVien.Focus();
                }
                else
                {
                    if (svBUS.themSinhVien(this.txtMaSinhVien.Text, this.txtHoTen.Text,this.txtDiaChi.Text, this.txtNgaySinh.Text == 
                        "" ? null : this.txtNgaySinh.Text, this.cbbGioiTinh.Text == "" ? null : this.cbbGioiTinh.Text, 
                        this.txtDanToc.Text, this.txtQueQuan.Text, this.cbbMaLop_SinhVien.SelectedValue.ToString()))
                    {
                        MessageBox.Show("Đã thêm xong.");
                        LoadData();
                    }
                    else
                        MessageBox.Show("Không thể thêm. Lỗi!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void funSuaKhoa()
        {
            if (khoaBUS.suaKhoa(this.cbbMaKhoa.Text, this.txtTenKhoa.Text, this.cbbTruongKhoa.SelectedValue.ToString() == "" 
                ? null : this.cbbTruongKhoa.SelectedValue.ToString(), this.txtSDTKhoa.Text))
            {
                MessageBox.Show("Đã sửa xong.");
                LoadData();
            }
            else
                MessageBox.Show("Không thể sửa. Lỗi!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void funSuaChuyenNganh()
        {
            if (cnBUS.suaChuyenNganh(this.cbbMaChuyenNganh.Text, this.txtTenChuyenNganh.Text, 
                this.cbbMaKhoa_ChuyenNganh.SelectedValue.ToString()))
            {
                MessageBox.Show("Đã sửa xong.");
                LoadData();
            }
            else
                MessageBox.Show("Không thể sửa. Lỗi!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void funSuaLop()
        {
            if (lopBUS.suaLop(this.cbbMaLop.Text, this.cbbMaChuyenNganh_Lop.SelectedValue.ToString()))
            {
                MessageBox.Show("Đã sửa xong.");
                LoadData();
            }
            else
                MessageBox.Show("Không thể sửa. Lỗi!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void funSuaSinhVien()
        {
            if (svBUS.suaSinhVien(this.txtMaSinhVien.Text, this.txtHoTen.Text, this.txtDiaChi.Text, this.txtNgaySinh.Text ==
                        "" ? null : this.txtNgaySinh.Text, this.cbbGioiTinh.Text == "" ? null : this.cbbGioiTinh.Text,
                        this.txtDanToc.Text, this.txtQueQuan.Text, this.cbbMaLop_SinhVien.SelectedValue.ToString()))
            {
                MessageBox.Show("Đã sửa xong.");
                LoadData();
            }
            else
                MessageBox.Show("Không thể sửa. Lỗi!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        #endregion

        #region Events

        private void btnReLoad_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadData();
        }

        private void btnInReport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmReport f = new frmReport(this.cbbMaKhoa.Text, this.cbbMaChuyenNganh.Text, this.cbbMaLop.Text);
            f.ShowDialog();
        }

        private void ThemKhoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            check = 1;

            this.cbbTruongKhoa.Enabled = false;

            // Thao tác cho 4 panel
            this.lcgKhoa.Enabled = true;
            this.lcgChuyenNganh.Enabled = false;
            this.lcgLop.Enabled = false;
            this.lcgSV.Enabled = false;

            // Xóa trống các đối tượng trong panel
            this.cbbMaKhoa.DropDownStyle = ComboBoxStyle.DropDown;
            this.cbbMaKhoa.ResetText();
            this.txtTenKhoa.ResetText();
            this.cbbTruongKhoa.ResetText();
            this.txtSDTKhoa.ResetText();

            // Cho thao tác trên các nút Lưu / Hủy
            this.btnThucThi.Enabled = true;
            this.btnHuyBo.Enabled = true;

            // Không cho thao tác trên các nút Thêm / Xóa / Find
            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;

            // Đưa con trỏ đến TextField txtMaKH
            this.cbbMaKhoa.Focus();
        }

        private void ThemChuyenNganh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            check = 2;

            // Thao tác cho 4 panel
            this.lcgKhoa.Enabled = false;
            this.lcgChuyenNganh.Enabled = true;
            this.lcgLop.Enabled = false;
            this.lcgSV.Enabled = false;

            // Xóa trống các đối tượng trong panel
            this.cbbMaChuyenNganh.DropDownStyle = ComboBoxStyle.DropDown;
            this.cbbMaChuyenNganh.ResetText();
            this.txtTenChuyenNganh.ResetText();
            this.cbbMaKhoa_ChuyenNganh.ResetText();

            // Cho thao tác trên các nút Lưu / Hủy
            this.btnThucThi.Enabled = true;
            this.btnHuyBo.Enabled = true;

            // Không cho thao tác trên các nút Thêm / Xóa / Find
            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;

            // Đưa con trỏ đến TextField txtMaKH
            this.cbbMaChuyenNganh.Focus();
        }

        private void ThemLop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            check = 3;

            // Thao tác cho 4 panel
            this.lcgKhoa.Enabled = false;
            this.lcgChuyenNganh.Enabled = false;
            this.lcgLop.Enabled = true;
            this.lcgSV.Enabled = false;

            // Xóa trống các đối tượng trong panel
            this.cbbMaLop.DropDownStyle = ComboBoxStyle.DropDown;
            this.cbbMaLop.ResetText();
            this.cbbMaChuyenNganh_Lop.ResetText();

            // Cho thao tác trên các nút Lưu / Hủy
            this.btnThucThi.Enabled = true;
            this.btnHuyBo.Enabled = true;

            // Không cho thao tác trên các nút Thêm / Xóa / txtSiSo
            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
            this.txtSiSo.Enabled = false;

            // Đưa con trỏ đến TextField txtMaKH
            this.cbbMaLop.Focus();
        }

        private void ThemSinhVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            check = 4;

            // Thao tác cho 4 panel
            this.lcgKhoa.Enabled = false;
            this.lcgChuyenNganh.Enabled = false;
            this.lcgLop.Enabled = false;
            this.lcgSV.Enabled = true;

            // Xóa trống các đối tượng trong panel
            this.txtMaSinhVien.Enabled = true;
            this.txtMaSinhVien.ResetText();
            this.txtHoTen.ResetText();
            this.txtNgaySinh.ResetText();
            this.txtDiaChi.ResetText();
            this.cbbGioiTinh.ResetText();
            this.txtDanToc.ResetText();
            this.txtQueQuan.ResetText();
            this.cbbMaLop_SinhVien.ResetText();

            // Cho thao tác trên các nút Lưu / Hủy
            this.btnThucThi.Enabled = true;
            this.btnHuyBo.Enabled = true;

            // Không cho thao tác trên các nút Thêm / Xóa / Find
            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;

            // Đưa con trỏ đến TextField txtMaKH
            this.txtMaSinhVien.Focus();
        }

        private void SuaKhoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Kích hoạt biến Sửa
            check = 5;

            // Thao tác cho 4 panel
            this.lcgKhoa.Enabled = true;
            this.lcgChuyenNganh.Enabled = false;
            this.lcgLop.Enabled = false;
            this.lcgSV.Enabled = false;

            // Cho thao tác trên các nút Lưu / Hủy
            this.btnThucThi.Enabled = true;
            this.btnHuyBo.Enabled = true;

            // Không cho thao tác trên các nút Thêm / Sửa / Xóa
            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
            this.cbbMaKhoa.Enabled = false;

            // Đưa con trỏ đến TextField
            this.cbbMaKhoa.Focus();
        }

        private void SuaChuyenNganh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Kích hoạt biến Sửa
            check = 6;

            // Thao tác cho 4 panel
            this.lcgKhoa.Enabled = false;
            this.lcgChuyenNganh.Enabled = true;
            this.lcgLop.Enabled = false;
            this.lcgSV.Enabled = false;

            // Cho thao tác trên các nút Lưu / Hủy
            this.btnThucThi.Enabled = true;
            this.btnHuyBo.Enabled = true;

            // Không cho thao tác trên các nút Thêm / Sửa / Xóa
            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
            this.cbbMaChuyenNganh.Enabled = false;

            // Đưa con trỏ đến TextField
            this.cbbMaChuyenNganh.Focus();
        }

        private void SuaLop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Kích hoạt biến Sửa
            check = 7;

            // Thao tác cho 4 panel
            this.lcgKhoa.Enabled = false;
            this.lcgChuyenNganh.Enabled = false;
            this.lcgLop.Enabled = true;
            this.lcgSV.Enabled = false;

            // Cho thao tác trên các nút Lưu / Hủy
            this.btnThucThi.Enabled = true;
            this.btnHuyBo.Enabled = true;

            // Không cho thao tác trên các nút Thêm / Sửa / Xóa
            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
            this.cbbMaLop.Enabled = false;
            this.txtSiSo.Enabled = false;

            // Đưa con trỏ đến TextField
            this.cbbMaLop.Focus();
        }

        private void SuaSinhVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Kích hoạt biến Sửa
            check = 8;

            // Thao tác cho 4 panel
            this.lcgKhoa.Enabled = false;
            this.lcgChuyenNganh.Enabled = false;
            this.lcgLop.Enabled = false;
            this.lcgSV.Enabled = true;

            // Cho thao tác trên các nút Lưu / Hủy
            this.btnThucThi.Enabled = true;
            this.btnHuyBo.Enabled = true;

            // Không cho thao tác trên các nút Thêm / Sửa / Xóa
            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;

            // Đưa con trỏ đến TextField
            this.txtHoTen.Focus();
        }

        private void XoaKhoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult traloi = MessageBox.Show("Bạn có chắc chắn muốn xóa KHOA " + this.txtTenKhoa.Text
                 + " không? \n LƯU Ý: Việc xóa KHOA đồng thời sẽ xóa Toàn Bộ SINH VIÊN, LỚP và CHUYÊN NGÀNH trong KHOA đó.",
                 "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (traloi == DialogResult.OK)
            {
                var listCN = cnBUS.getCNTheoKhoa(this.cbbMaKhoa.Text);

                foreach (var cn in listCN)
                {
                    var listLop = lopBUS.getLopTheoChuyenNganh(cn.MaChuyenNganh);

                    foreach (var lop in listLop)
                    {
                        var listSV = svBUS.getSVTheoMaLop(lop.MaLop);

                        foreach (var sv in listSV)
                            svBUS.xoaSinhVien(sv.MaSV);

                        lopBUS.xoaLop(lop.MaLop);
                    }
                    cnBUS.xoaChuyenNganh(cn.MaChuyenNganh);
                }

                khoaBUS.xoaKhoa(this.cbbMaKhoa.Text);
                MessageBox.Show("Đã xóa xong.");
                LoadData();
            }
        }

        private void XoaChuyenNganh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult traloi = MessageBox.Show("Bạn có chắc chắn muốn xóa CHUYÊN NGÀNH " + this.txtTenChuyenNganh.Text
                 + " không? \n LƯU Ý: Việc xóa CHUYÊN NGÀNH đồng thời sẽ xóa Toàn Bộ SINH VIÊN và LỚP trong CHUYÊN NGÀNH đó.",
                 "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (traloi == DialogResult.OK)
            {
                var listLop = lopBUS.getLopTheoChuyenNganh(this.cbbMaChuyenNganh.Text);

                foreach (var lop in listLop)
                {
                    var listSV = svBUS.getSVTheoMaLop(lop.MaLop);
                    foreach (var sv in listSV)
                        svBUS.xoaSinhVien(sv.MaSV);

                    lopBUS.xoaLop(lop.MaLop);
                }

                cnBUS.xoaChuyenNganh(this.cbbMaChuyenNganh.Text);
                MessageBox.Show("Đã xóa xong.");
                LoadData();
            }
        }

        private void XoaLop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult traloi = MessageBox.Show("Bạn có chắc chắn muốn xóa Lớp " + this.cbbMaLop.Text
                 + " không? \n LƯU Ý: Việc xóa LỚP đồng thời sẽ xóa Toàn Bộ Sinh Viên trong Lớp đó.",
                 "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (traloi == DialogResult.OK)
            {
                var listSV = svBUS.getSVTheoMaLop(this.cbbMaLop.Text);
                foreach (var item in listSV)
                    svBUS.xoaSinhVien(item.MaSV);

                lopBUS.xoaLop(this.cbbMaLop.Text);
                MessageBox.Show("Đã xóa xong.");
                LoadData();
            }
        }

        private void XoaSinhVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult traloi = MessageBox.Show("Bạn có chắc chắn muốn xóa Sinh Viên " + this.txtHoTen.Text 
                + " không?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (traloi == DialogResult.OK)
            {
                if (svBUS.xoaSinhVien(this.txtMaSinhVien.Text))
                {
                    MessageBox.Show("Đã xóa xong.");
                    LoadData();
                }
                else
                    MessageBox.Show("Không thể xóa Sinh Viên", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThucThi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(check == 1)
                funThemKhoa();
            else
            {
                if(check == 2)
                    funThemChuyenNganh();
                else
                {
                    if(check == 3)
                        funThemLop();
                    else
                    {
                        if(check == 4)
                            funThemSinhVien();
                        else
                        {
                            if(check == 5)
                                funSuaKhoa();
                            else
                            {
                                if(check == 6)
                                    funSuaChuyenNganh();
                                else
                                {
                                    if (check == 7)
                                        funSuaLop();
                                    else
                                        funSuaSinhVien();
                                }
                            }
                        }
                    }
                }
            }
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadData();
        }

        private void cbbMaKhoa_SelectedValueChanged(object sender, EventArgs e)
        {
            var k = khoaBUS.getKTheoMaKhoa(this.cbbMaKhoa.SelectedValue.ToString());

            if (k.Count != 0)
            {
                
                // lcg Khoa
                var trgKhoa = gvBUS.getGVTheoMaKhoa(k[0].MaKhoa);
                trgKhoa.Insert(0, new spGetGVTheoMaKhoaResult { MaGV = "", TenGV = "-- Select --" });
                this.cbbTruongKhoa.DataSource = trgKhoa;
                this.cbbTruongKhoa.DisplayMember = "TenGV";
                this.cbbTruongKhoa.ValueMember = "MaGV";

                this.txtTenKhoa.Text = k[0].TenKhoa;
                this.cbbTruongKhoa.SelectedValue = k[0].CNKhoa == null ? "" : k[0].CNKhoa;
                this.txtSDTKhoa.Text = k[0].SDTKhoa;
                this.cbbMaKhoa_ChuyenNganh.SelectedValue = k[0].MaKhoa;

                // lcg Chuyen Nganh
                var listCN = cnBUS.getCNTheoKhoa(k[0].MaKhoa);

                if (listCN.Count == 0)
                {
                    this.lcgChuyenNganh.Enabled = false;
                    this.cbbMaChuyenNganh.Text = "";
                    this.lcgLop.Enabled = false;
                    this.cbbMaLop.Text = "";
                    this.lcgSV.Enabled = false;
                    dgcSinhVien.DataSource = null;
                }
                else
                {
                    this.lcgChuyenNganh.Enabled = true;
                    this.cbbMaChuyenNganh.DataSource = listCN;
                    this.cbbMaChuyenNganh.DisplayMember = "MaChuyenNganh";
                    this.cbbMaChuyenNganh.ValueMember = "MaChuyenNganh";
                }
            }
        }

        private void cbbMaChuyenNganh_SelectedValueChanged(object sender, EventArgs e)
        {
            var cn = cnBUS.getCNTheoMaCN(this.cbbMaChuyenNganh.SelectedValue.ToString());

            if (cn.Count != 0)
            {
                // lcg ChuyenNganh
                this.txtTenChuyenNganh.Text = cn[0].TenChuyenNganh;
                this.cbbMaChuyenNganh_Lop.SelectedValue = cn[0].MaChuyenNganh;

                // lcg Lop
                var listLop = lopBUS.getLopTheoChuyenNganh(cn[0].MaChuyenNganh);
                if (listLop.Count == 0)
                {
                    this.lcgLop.Enabled = false;
                    this.cbbMaLop.Text = "";

                    this.lcgSV.Enabled = false;
                    dgcSinhVien.DataSource = null;
                }
                else
                {
                    this.lcgLop.Enabled = true;
                    this.cbbMaLop.DataSource = listLop;
                    this.cbbMaLop.DisplayMember = "MaLop";
                    this.cbbMaLop.ValueMember = "MaLop";
                }
            }
        }

        private void cbbMaLop_SelectedValueChanged(object sender, EventArgs e)
        {
            var l = lopBUS.getLopTheoMaLop(this.cbbMaLop.SelectedValue.ToString());

            if (l.Count != 0)
            {
                //lcg Lop && dgcSinhVien
                if (svBUS.getSVTheoMaLop(l[0].MaLop).Count == 0)
                {
                    this.lcgSV.Enabled = false;
                    dgcSinhVien.DataSource = null;
                }
                else
                {
                    this.lcgSV.Enabled = true;
                    this.txtSiSo.Text = svBUS.getSiSoLop(l[0].MaLop)[0].Column1.ToString();
                    this.cbbMaLop_SinhVien.SelectedValue = l[0].MaLop;
                    this.dgcSinhVien.DataSource = svBUS.getSVTheoMaLop(l[0].MaLop);
                    DataBind();
                }
            }
        }

        private void txtMaSinhVien_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
                funThemSinhVien();
        }
        #endregion
    }
}
