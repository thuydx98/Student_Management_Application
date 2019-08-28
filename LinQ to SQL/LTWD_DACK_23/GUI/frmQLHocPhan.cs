using System;
using System.Windows.Forms;
using BUS;

namespace GUI
{
    public partial class frmQLHocPhan : DevExpress.XtraEditors.XtraForm
    {
        MonHocBUS mhBUS;
        HocPhanBUS hpBUS;
        SinhVienBUS svBUS;
        DIemThiBUS dtBUS;
        GiangVienBUS gvBUS;
        int check = 0;

        public frmQLHocPhan()
        {
            mhBUS = new MonHocBUS();
            hpBUS = new HocPhanBUS();
            svBUS = new SinhVienBUS();
            dtBUS = new DIemThiBUS();
            gvBUS = new GiangVienBUS();
            InitializeComponent();
            LoadData();

            this.txtMaSV.AutoCompleteMode = AutoCompleteMode.Suggest;
            this.txtMaSV.AutoCompleteSource = AutoCompleteSource.CustomSource;

            var lstMSSV = svBUS.getMSSV();
            AutoCompleteStringCollection AutoComp = new AutoCompleteStringCollection();
            foreach (var sv in lstMSSV)
                AutoComp.Add(sv.MaSV);

            this.txtMaSV.AutoCompleteCustomSource = AutoComp;
        }

        #region Methods

        private void LoadData()
        {
            this.cbbMaMH.DataSource = mhBUS.getMonHoc();
            this.cbbMaMH.DisplayMember = "MaMH";
            this.cbbMaMH.ValueMember = "MaMH";

            this.cbbMaMH_HP.DataSource = mhBUS.getMonHoc();
            this.cbbMaMH_HP.DisplayMember = "TenMH";
            this.cbbMaMH_HP.ValueMember = "MaMH";

            this.lcgNhapSinhVien.Enabled = true;
            this.lcgMonHoc.Enabled = true;
            this.lcgHocPhan.Enabled = true;
            this.cbbMaMH.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbbMaHP.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbbMaMH_HP.DropDownStyle = ComboBoxStyle.DropDownList;

            this.btnThem.Enabled = true;
            this.btnSua.Enabled = true;
            this.btnXoa.Enabled = true;
            this.btnLuu.Enabled = false;
            this.btnHuy.Enabled = false;
        }

        private void DataBinding()
        {
            this.txtMaSV.DataBindings.Clear();
            this.txtMaSV.DataBindings.Add("Text", dgcSinhVien.DataSource, "MaSV");

            this.txtMaSV.Focus();
            this.txtMaSV.SelectAll();
        }

        private void themMonHoc()
        {
            if(this.cbbMaMH.Text == "")
            {
                MessageBox.Show("Mã MÔN HỌC không được để trống.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.cbbMaMH.Focus();
            }
            else
            {
                var mh = mhBUS.getMHTheoMaMH(this.cbbMaMH.Text);
                if(mh.Count != 0)
                {
                    MessageBox.Show("Mã MÔN HỌC đã tồn tại.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.cbbMaMH.Focus();
                    this.cbbMaMH.SelectAll();
                }
                else
                {
                    if (mhBUS.themMonHoc(this.cbbMaMH.Text, this.txtTenMH.Text))
                    {
                        MessageBox.Show("Đã thêm xong.");
                        LoadData();
                    }
                    else
                        MessageBox.Show("Khong them duoc. Loi !!!", "THONG BAO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void themHocPhan()
        {
            if (this.cbbMaHP.Text == "")
            {
                MessageBox.Show("Mã HỌC PHẦN không được để trống.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.cbbMaHP.Focus();
            }
            else
            {
                var hp = hpBUS.getHPTheoMaHP(this.cbbMaHP.Text);
                if (hp.Count != 0)
                {
                    MessageBox.Show("Mã HỌC PHẦN đã tồn tại.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.cbbMaHP.Focus();
                    this.cbbMaHP.SelectAll();
                }
                else
                {
                    var gv = gvBUS.getGVTheoMaGV(this.txtGiangVien.Text);
                    
                    if (this.txtGiangVien.Text != "" && gv.Count == 0)
                    {
                        MessageBox.Show("GIẢNG VIÊN không tồn tại.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.txtGiangVien.Focus();
                        this.txtGiangVien.SelectAll();
                    }
                    else
                    {
                        if (hpBUS.themHocPhan(this.cbbMaHP.Text, this.cbbMaMH_HP.SelectedValue.ToString(),
                            this.txtHocKy.Text == "" ? 0 : Convert.ToInt32(this.txtHocKy.Text), this.txtNamHoc.Text,
                            this.txtGiangVien.Text == "" ? null : this.txtGiangVien.Text,
                            this.txtSoTC.Text == "" ? 0 : Convert.ToInt32(this.txtSoTC.Text),
                            this.txtHocPhi.Text == "" ? 0 : Convert.ToInt32(this.txtHocPhi.Text)))
                        {
                            MessageBox.Show("Đã thêm xong");
                            LoadData();
                        }
                        else
                            MessageBox.Show("Khong them duoc. Loi !!!", "THONG BAO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void themSV()
        {
            if (dtBUS.getDiemTheoMSSV_MaHP(this.txtMaSV.Text, this.cbbMaHP.Text).Count != 0)
                MessageBox.Show("Sinh Viên đã có trong HỌC PHẦN.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            else
            {
                var sv = svBUS.getSVTheoMaSV(this.txtMaSV.Text);

                if (sv.Count == 0)
                    MessageBox.Show("Sinh Viên không tồn tại.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    if (dtBUS.themDiemThi(this.txtMaSV.Text, this.cbbMaHP.Text))
                    {
                        MessageBox.Show("Đã Thêm Xong.");
                        this.dgcSinhVien.DataSource = svBUS.getSVTheoMaHP(this.cbbMaHP.SelectedValue.ToString());
                    }
                    else
                        MessageBox.Show("Khong them duoc. Loi !!!", "THONG BAO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            DataBinding();
            this.txtMaSV.SelectAll();
        }

        private void suaMonHoc()
        {
            if (mhBUS.suaMonHoc(this.cbbMaMH.Text, this.txtTenMH.Text))
            {
                MessageBox.Show("Đã sủa xong.");
                LoadData();
            }
            else
                MessageBox.Show("Khong SUA duoc. Loi !!!", "THONG BAO", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void suaHocPhan()
        {
            var gv = gvBUS.getGVTheoMaGV(this.txtGiangVien.Text);

            if (this.txtGiangVien.Text != "" && gv.Count == 0)
            {
                MessageBox.Show("GIẢNG VIÊN không tồn tại.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtGiangVien.Focus();
                this.txtGiangVien.SelectAll();
            }
            else
            {
                if (hpBUS.suaHocPhan(this.cbbMaHP.Text, this.cbbMaMH_HP.SelectedValue.ToString(),
                    this.txtHocKy.Text == "" ? 0 : Convert.ToInt32(this.txtHocKy.Text), this.txtNamHoc.Text,
                    this.txtGiangVien.Text == "" ? null : this.txtGiangVien.Text,
                    this.txtSoTC.Text == "" ? 0 : Convert.ToInt32(this.txtSoTC.Text),
                    this.txtHocPhi.Text == "" ? 0 : Convert.ToInt32(this.txtHocPhi.Text)))
                {
                    MessageBox.Show("Đã sửa xong");
                    LoadData();
                }
                else
                    MessageBox.Show("Khong SUA duoc. Loi !!!", "THONG BAO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Events

        private void btnThemMonHoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            check = 1;

            this.lcgMonHoc.Enabled = true;
            this.lcgHocPhan.Enabled = false;
            this.lcgNhapSinhVien.Enabled = false;

            this.cbbMaMH.DropDownStyle = ComboBoxStyle.DropDown;

            // Cho thao tác trên các nút Lưu / Hủy
            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;

            // Không cho thao tác trên các nút Thêm / Xóa / Find
            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;

            this.cbbMaMH.ResetText();
            this.txtTenMH.ResetText();
            this.cbbMaMH.Focus();
        }

        private void btnThemHocPhan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            check = 2;

            this.lcgMonHoc.Enabled = false;
            this.lcgHocPhan.Enabled = true;
            this.lcgNhapSinhVien.Enabled = false;

            this.cbbMaHP.DropDownStyle = ComboBoxStyle.DropDown;

            // Cho thao tác trên các nút Lưu / Hủy
            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;

            // Không cho thao tác trên các nút Thêm / Xóa / Find
            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;

            this.cbbMaHP.ResetText();
            this.txtNamHoc.ResetText();
            this.txtHocKy.ResetText();
            this.txtSoTC.ResetText();
            this.txtGiangVien.ResetText();
            this.txtHocPhi.ResetText();

            this.txtMaSV.Focus();
        }

        private void btnSuaMonHoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Kích hoạt biến Sửa
            check = 4;

            // Cho thao tác trên các nút Lưu / Hủy
            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;

            // Không cho thao tác trên các nút Thêm / Xóa / Tìm / ID
            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;

            // Đưa con trỏ đến TextField
            this.txtTenMH.Focus();
        }

        private void btnSuaHocPhan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Kích hoạt biến Sửa
            check = 5;

            // Cho thao tác trên các nút Lưu / Hủy
            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;

            // Không cho thao tác trên các nút Thêm / Xóa / Tìm / ID
            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;

            // Đưa con trỏ đến TextField
            this.txtNamHoc.Focus();
        }

        private void btnXoaMonHoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult traloi = MessageBox.Show("Bạn có chắc chắn muốn xóa MÔN HỌC " + this.cbbMaMH.Text
                + " không? \n LƯU Ý: Việc xóa MÔN HỌC sẽ xóa toàn bộ SINH VIÊN và HỌC PHẦN trong MÔN HỌC đó.", "Trả lời",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (traloi == DialogResult.OK)
            {
                var listHP = hpBUS.getHPTheoMH(this.cbbMaMH.Text);

                foreach (var hp in listHP)
                {
                    var listSV = svBUS.getSVTheoMaHP(hp.MaHP);
                    foreach (var sv in listSV)
                        dtBUS.xoaDiemThi(sv.MaSV, hp.MaHP);

                    hpBUS.xoaHocPhan(hp.MaHP);
                }

                mhBUS.xoaMonHoc(this.cbbMaMH.Text);
                MessageBox.Show("Đã xóa xong.");
                LoadData();
            }
        }

        private void btnXoaHocPhan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult traloi = MessageBox.Show("Bạn có chắc chắn muốn xóa HỌC PHẦN " + this.cbbMaHP.Text 
                + " không? \n LƯU Ý: Việc xóa HỌC PHẦN sẽ xóa toàn bộ SINH VIÊN trong HỌC PHẦN đó.", "Trả lời",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (traloi == DialogResult.OK)
            {
                var listSV = svBUS.getSVTheoMaHP(this.cbbMaHP.Text);
                foreach (var sv in listSV)
                    dtBUS.xoaDiemThi(sv.MaSV, this.cbbMaHP.Text);

                hpBUS.xoaHocPhan(this.cbbMaHP.Text);               
                MessageBox.Show("Đã xóa xong.");
                LoadData();
            }
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (check == 1)
                themMonHoc();
            else
            {
                if (check == 2)
                    themHocPhan();
                else
                {
                    if (check == 3)
                        themSV();
                    else
                    {
                        if (check == 4)
                            suaMonHoc();
                        else
                            suaHocPhan();
                    }
                }
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
            frmReport f = new frmReport(this.cbbMaHP.Text, 14);
            f.ShowDialog();
        }

        private void btnThemSV_Click(object sender, EventArgs e)
        {
            themSV();
        }

        private void btnXoaSV_Click(object sender, EventArgs e)
        {
            string maSV = dgvSinhVien.GetFocusedRowCellValue(MaSV).ToString();

            DialogResult traloi = MessageBox.Show("Bạn có chắc chắn muốn xóa Sinh Viên " + maSV + " không?", "Trả lời",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (traloi == DialogResult.OK)
            {
                if (dtBUS.xoaDiemThi(maSV, this.cbbMaHP.Text))
                {
                    this.dgcSinhVien.DataSource = svBUS.getSVTheoMaHP(this.cbbMaHP.SelectedValue.ToString());
                    MessageBox.Show("Đã xóa xong.");
                }
                else
                    MessageBox.Show("Khong XOA duoc. Loi !!!", "THONG BAO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DataBinding();
        }

        private void txtMaSV_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue == 13)
                themSV();
        }

        private void cbbMaMH_SelectedValueChanged(object sender, EventArgs e)
        {
            var listHP = hpBUS.getHPTheoMH(this.cbbMaMH.SelectedValue.ToString());

            if (listHP.Count != 0)
            {
                this.lcgHocPhan.Enabled = true;
                this.cbbMaHP.DataSource = listHP;
                this.cbbMaHP.DisplayMember = "MaHP";
                this.cbbMaHP.ValueMember = "MaHP";

                this.txtTenMH.Text = listHP[0].TenMH;
            }
            else
            {
                this.lcgHocPhan.Enabled = false;
                this.dgcSinhVien.DataSource = null;
            }
        }

        private void cbbMaHP_SelectedValueChanged(object sender, EventArgs e)
        {
            var hocPhan = hpBUS.getHPTheoMaHP(this.cbbMaHP.SelectedValue.ToString());

            if (hocPhan.Count != 0)
            {
                this.txtNamHoc.Text = hocPhan[0].NamHoc;
                this.txtHocKy.Text = hocPhan[0].HocKy.ToString();
                this.txtSoTC.Text = hocPhan[0].SoTC.ToString();
                this.txtGiangVien.Text = hocPhan[0].MaGV;
                this.txtHocPhi.Text = hocPhan[0].HocPhi.ToString();
                this.cbbMaMH_HP.SelectedValue = hocPhan[0].MaMH;

                this.dgcSinhVien.DataSource = svBUS.getSVTheoMaHP(this.cbbMaHP.SelectedValue.ToString());

                DataBinding();
            }
        }
        #endregion
    }
}
