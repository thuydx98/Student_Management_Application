using System;
using System.Windows.Forms;
using BUS;

namespace GUI
{
    public partial class frmQLHocPhi : DevExpress.XtraEditors.XtraForm
    {
        DIemThiBUS dtBUS;
        SinhVienBUS svBUS;

        public frmQLHocPhi()
        {
            dtBUS = new DIemThiBUS();
            svBUS = new SinhVienBUS();
            InitializeComponent();


            this.txtMSSV.AutoCompleteMode = AutoCompleteMode.Suggest;
            this.txtMSSV.AutoCompleteSource = AutoCompleteSource.CustomSource;

            var lstMSSV = svBUS.getMSSV();
            AutoCompleteStringCollection AutoComp = new AutoCompleteStringCollection();
            foreach (var sv in lstMSSV)
                AutoComp.Add(sv);

            this.txtMSSV.AutoCompleteCustomSource = AutoComp;
        }

        #region Methods

        private void TimKiem()
        {
            if(svBUS.getSVTheoMaSV(this.txtMSSV.Text).Count != 0)
                this.dgcDSHP.DataSource = dtBUS.getDiemTheoMSSV(this.txtMSSV.Text);
            else
                MessageBox.Show("MÃ SINH VIÊN không tồn tại.", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);

            this.btnSua.Enabled = true;

            this.txtMSSV.Focus();
            this.txtMSSV.SelectAll();
        }
        #endregion

        #region Events

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.dgvDSHP.OptionsBehavior.Editable = true;
            MaSV.OptionsColumn.AllowEdit = false;
            HoTen.OptionsColumn.AllowEdit = false;
            MaHP.OptionsColumn.AllowEdit = false;
            this.dgvDSHP.FocusedColumn = DaDongHP;

            this.btnSua.Enabled = false;
            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            for (int i = 0; i < dgvDSHP.RowCount; i++)
            {
                if (!dtBUS.suaTinhTrangHP(this.dgvDSHP.GetRowCellValue(i, MaSV).ToString(),
                    this.dgvDSHP.GetRowCellValue(i, MaHP).ToString(),
                    Convert.ToBoolean(this.dgvDSHP.GetRowCellValue(i, DaDongHP).ToString())))
                {
                    MessageBox.Show("Khong SUA duoc. Loi !!!", "THONG BAO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
            }

            this.dgcDSHP.DataSource = dtBUS.getDiemTheoMSSV(this.txtMSSV.Text);

            this.dgvDSHP.OptionsBehavior.Editable = false;
            this.btnSua.Enabled = true;
            this.btnLuu.Enabled = false;
            this.btnHuy.Enabled = false;
            this.txtMSSV.Focus();
            this.txtMSSV.SelectAll();
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.btnSua.Enabled = false; ;
            this.btnLuu.Enabled = false;
            this.btnHuy.Enabled = false;

            this.dgcDSHP.DataSource = null;
            this.txtMSSV.Focus();
            this.txtMSSV.SelectAll();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            TimKiem();
        }

        private void txtMSSV_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
                TimKiem();
        }
        #endregion
    }
}
