using System;
using System.Windows.Forms;
using BUS;

namespace GUI
{
    public partial class frmQLGiangVien : DevExpress.XtraEditors.XtraForm
    {
        int check = 0;
        KhoaBUS khoaBUS;
        GiangVienBUS gvBUS;

        public frmQLGiangVien()
        {
            khoaBUS = new KhoaBUS();
            gvBUS = new GiangVienBUS();
            InitializeComponent();
            LoadData();
        }

        #region Methods

        private void LoadData()
        {
            // Đưa dữ liệu lên combobox
            this.cbbChonKhoa.DataSource = khoaBUS.getKhoa();
            this.cbbChonKhoa.DisplayMember = "TenKhoa";
            this.cbbChonKhoa.ValueMember = "MaKhoa";

            this.cbbThuocKhoa.DataSource = khoaBUS.getKhoa();
            this.cbbThuocKhoa.DisplayMember = "TenKhoa";
            this.cbbThuocKhoa.ValueMember = "MaKhoa";

            // Không cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnThucThi.Enabled = false;
            this.btnHuy.Enabled = false;
            this.lcgGiangVien.Enabled = false;
            // Mở cho thao tác những cái trong Panel
            this.cbbChonKhoa.Enabled = true;
            this.txtMaGV.Enabled = true;
            this.txtHoTen.Enabled = true;
            this.txtHocVi.Enabled = true;
            this.txtDiaChi.Enabled = true;
            this.txtSDT.Enabled = true;
            this.cbbThuocKhoa.Enabled = true;
            // Cho thao tác trên các nút Thêm / Sửa / Xóa / Tìm Kiếm
            this.btnThem.Enabled = true;
            this.btnSua.Enabled = true;
            this.btnXoa.Enabled = true;
            this.btnTim.Enabled = true;
        }

        private void DataBind()
        {
            this.txtMaGV.DataBindings.Clear();
            this.txtHoTen.DataBindings.Clear();
            this.txtHocVi.DataBindings.Clear();
            this.txtDiaChi.DataBindings.Clear();
            this.txtSDT.DataBindings.Clear();
            this.cbbThuocKhoa.DataBindings.Clear();

            this.txtMaGV.DataBindings.Add("Text", dgcGiaoVien.DataSource, "MaGV");
            this.txtHoTen.DataBindings.Add("Text", dgcGiaoVien.DataSource, "TenGV");
            this.txtHocVi.DataBindings.Add("Text", dgcGiaoVien.DataSource, "HocVi");
            this.txtDiaChi.DataBindings.Add("Text", dgcGiaoVien.DataSource, "DiaChi");
            this.txtSDT.DataBindings.Add("Text", dgcGiaoVien.DataSource, "SDT");
            this.cbbThuocKhoa.DataBindings.Add("SelectedValue", dgcGiaoVien.DataSource, "ThuocMaKhoa");
        }

        private int kTraDLNhapVao()
        {
            if (this.txtMaGV.Text == "")
                return 1;
            if (this.txtHoTen.Text == "")
                return 2;

            string sdt = this.txtSDT.Text;
            if (sdt.Length > 11 && sdt.Length > 0)
                return 3;

            for (int i = 0; i < sdt.Length; i++)
                if (Convert.ToInt32(sdt[i]) < 48 || Convert.ToInt32(sdt[i]) > 57)
                    return 3;

            return 0;
        }

        private bool kTraTrungID()
        {
            if (gvBUS.getGVTheoMaGV(this.txtMaGV.Text).Count == 0)
                return false;
            return true;
        }

        private void thucThi()
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
                            if (gvBUS.themGiangVien(this.txtMaGV.Text, this.txtHoTen.Text, this.txtHocVi.Text,
                                this.txtDiaChi.Text, this.txtSDT.Text,
                                this.cbbThuocKhoa.SelectedValue.ToString()))
                            {
                                MessageBox.Show("Đã thêm xong!");
                                LoadData();
                            }
                            else
                                MessageBox.Show("Khong them duoc. Loi !!!", "THONG BAO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                            MessageBox.Show("Mã Giảng Viên đã bị trùng.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    if (check == 2)
                    {
                        if (gvBUS.suaGiangVien(this.txtMaGV.Text, this.txtHoTen.Text, this.txtHocVi.Text,
                            this.txtDiaChi.Text, this.txtSDT.Text,
                            this.cbbThuocKhoa.SelectedValue.ToString()))
                        {
                            MessageBox.Show("Đã sửa xong!");
                            LoadData();
                        }
                        else
                            MessageBox.Show("Khong SUA duoc. Loi !!!", "THONG BAO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (kt == 1)
                        MessageBox.Show("Mã Giảng Viên không được để trống.", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                    {
                        if (kt == 2)
                            MessageBox.Show("Tên Giảng Viên không được để trống.", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        else
                            MessageBox.Show("Số điện thoại nhập vào đã bị sai.", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                dgcGiaoVien.DataSource = gvBUS.getGVTheoMaGV(this.txtMaGV.Text);
            }
        }
        #endregion

        #region Events

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            check = 1;

            // Xóa trống các đối tượng trong panel
            this.txtMaGV.ResetText();
            this.txtHoTen.ResetText();
            this.txtHocVi.ResetText();
            this.txtDiaChi.ResetText();
            this.txtSDT.ResetText();

            // Cho thao tác trên các nút Lưu / Hủy
            this.btnThucThi.Enabled = true;
            this.btnHuy.Enabled = true;
            this.lcgGiangVien.Enabled = true;

            // Không cho thao tác trên các nút Thêm / Xóa / Find
            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnTim.Enabled = false;
            this.cbbChonKhoa.Enabled = false;

            // Đưa con trỏ đến TextField txtMaGV
            this.txtMaGV.Focus();
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            check = 2;

            // Cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnThucThi.Enabled = true;
            this.btnHuy.Enabled = true;
            this.lcgGiangVien.Enabled = true;

            // Không cho thao tác trên các nút Thêm / Xóa / Tìm / ID
            this.txtMaGV.Enabled = false;
            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnTim.Enabled = false;

            // Đưa con trỏ đến TextField
            this.txtHoTen.Focus();
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult traloi = MessageBox.Show("Bạn có chắc chắn muốn xóa GIẢNG VIÊN " + this.txtMaGV.Text + " không?", "Trả lời", 
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (traloi == DialogResult.OK)
            {
                if (gvBUS.xoaGiangVien(this.txtMaGV.Text))
                {
                    MessageBox.Show("Đã xóa xong.");
                    LoadData();
                }
                else
                    MessageBox.Show("Khong XOA duoc. Loi !!!", "THONG BAO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTim_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            check = 3;

            this.lcgGiangVien.Enabled = true;
            this.txtMaGV.Enabled = true;
            this.txtHoTen.Enabled = false;
            this.txtHocVi.Enabled = false;
            this.txtDiaChi.Enabled = false;
            this.txtSDT.Enabled = false;
            this.cbbChonKhoa.Enabled = false;

            this.txtMaGV.ResetText();

            this.btnThucThi.Enabled = true;
            this.btnHuy.Enabled = true;

            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnTim.Enabled = false;

            this.txtMaGV.Focus();
        }

        private void btnThucThi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            thucThi();
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
            frmReport f = new frmReport(this.cbbChonKhoa.SelectedValue.ToString(), 12);
            f.ShowDialog();
        }

        private void cbbChonKhoa_SelectedValueChanged(object sender, EventArgs e)
        {
            if(this.cbbChonKhoa.Text != "")
            {
                this.dgcGiaoVien.DataSource = gvBUS.getGVTheoMaKhoa(this.cbbChonKhoa.SelectedValue.ToString());
                DataBind();
            }
        }

        private void txtMaGV_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
                thucThi();
        }
        #endregion
    }
}
