namespace GUI
{
    partial class frmQuanLyNguoiDung
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar4 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnTim = new DevExpress.XtraBars.BarSubItem();
            this.TheoTaiKhoan = new DevExpress.XtraBars.BarButtonItem();
            this.TheoLoaiTK = new DevExpress.XtraBars.BarButtonItem();
            this.TheoMaGV = new DevExpress.XtraBars.BarButtonItem();
            this.btnThucThi = new DevExpress.XtraBars.BarButtonItem();
            this.btnHuyBo = new DevExpress.XtraBars.BarButtonItem();
            this.btnReLoad = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.cbbLoaiTK = new System.Windows.Forms.ComboBox();
            this.txtMatKhau = new DevExpress.XtraEditors.TextEdit();
            this.pnNhapTT = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.dgcQuanLyNguoiDung = new DevExpress.XtraGrid.GridControl();
            this.dgvQuanLyNguoiDung = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.TaiKhoan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MatKhau = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LoaiUser = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Ma = new DevExpress.XtraGrid.Columns.GridColumn();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMatKhau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnNhapTT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgcQuanLyNguoiDung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLyNguoiDung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.FloatLocation = new System.Drawing.Point(267, 130);
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // bar1
            // 
            this.bar1.BarName = "Main menu";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.FloatLocation = new System.Drawing.Point(267, 130);
            this.bar1.OptionsBar.MultiLine = true;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Main menu";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar4});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnSua,
            this.btnXoa,
            this.btnThucThi,
            this.btnHuyBo,
            this.btnTim,
            this.barButtonItem1,
            this.barButtonItem2,
            this.TheoTaiKhoan,
            this.TheoLoaiTK,
            this.TheoMaGV,
            this.btnReLoad});
            this.barManager1.MainMenu = this.bar4;
            this.barManager1.MaxItemId = 18;
            // 
            // bar4
            // 
            this.bar4.BarName = "Main menu";
            this.bar4.DockCol = 0;
            this.bar4.DockRow = 0;
            this.bar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar4.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnTim, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThucThi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnHuyBo, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnReLoad, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar4.OptionsBar.MultiLine = true;
            this.bar4.OptionsBar.UseWholeRow = true;
            this.bar4.Text = "Main menu";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.Image = global::GUI.Properties.Resources.Them;
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Sửa";
            this.btnSua.Id = 2;
            this.btnSua.ImageOptions.Image = global::GUI.Properties.Resources.Sua;
            this.btnSua.Name = "btnSua";
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 3;
            this.btnXoa.ImageOptions.Image = global::GUI.Properties.Resources.Xoa;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnTim
            // 
            this.btnTim.Caption = "Tìm Kiếm";
            this.btnTim.Id = 9;
            this.btnTim.ImageOptions.Image = global::GUI.Properties.Resources.TimKiem;
            this.btnTim.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.TheoTaiKhoan),
            new DevExpress.XtraBars.LinkPersistInfo(this.TheoLoaiTK),
            new DevExpress.XtraBars.LinkPersistInfo(this.TheoMaGV)});
            this.btnTim.Name = "btnTim";
            // 
            // TheoTaiKhoan
            // 
            this.TheoTaiKhoan.Caption = "Theo Tài Khoản";
            this.TheoTaiKhoan.Id = 13;
            this.TheoTaiKhoan.Name = "TheoTaiKhoan";
            this.TheoTaiKhoan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.TheoTaiKhoan_ItemClick);
            // 
            // TheoLoaiTK
            // 
            this.TheoLoaiTK.Caption = "Theo Loại Tài Khoản";
            this.TheoLoaiTK.Id = 14;
            this.TheoLoaiTK.Name = "TheoLoaiTK";
            this.TheoLoaiTK.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.TheoLoaiTK_ItemClick);
            // 
            // TheoMaGV
            // 
            this.TheoMaGV.Caption = "Theo Mã GV / SV";
            this.TheoMaGV.Id = 15;
            this.TheoMaGV.Name = "TheoMaGV";
            this.TheoMaGV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.TheoMaGV_ItemClick);
            // 
            // btnThucThi
            // 
            this.btnThucThi.Caption = "Thực Thi";
            this.btnThucThi.Id = 5;
            this.btnThucThi.ImageOptions.Image = global::GUI.Properties.Resources.Luu;
            this.btnThucThi.Name = "btnThucThi";
            this.btnThucThi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThucThi_ItemClick);
            // 
            // btnHuyBo
            // 
            this.btnHuyBo.Caption = "Hủy Bỏ";
            this.btnHuyBo.Id = 6;
            this.btnHuyBo.ImageOptions.Image = global::GUI.Properties.Resources.Huy;
            this.btnHuyBo.Name = "btnHuyBo";
            this.btnHuyBo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHuyBo_ItemClick);
            // 
            // btnReLoad
            // 
            this.btnReLoad.Caption = "ReLoad";
            this.btnReLoad.Id = 17;
            this.btnReLoad.ImageOptions.Image = global::GUI.Properties.Resources.LamMoi;
            this.btnReLoad.Name = "btnReLoad";
            this.btnReLoad.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReLoad_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(903, 32);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 488);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(903, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 32);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 456);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(903, 32);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 456);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 10;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "barButtonItem2";
            this.barButtonItem2.Id = 11;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // popupMenu1
            // 
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txtMa);
            this.layoutControl1.Controls.Add(this.txtTaiKhoan);
            this.layoutControl1.Controls.Add(this.cbbLoaiTK);
            this.layoutControl1.Controls.Add(this.txtMatKhau);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutControl1.Location = new System.Drawing.Point(0, 32);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.pnNhapTT;
            this.layoutControl1.Size = new System.Drawing.Size(903, 79);
            this.layoutControl1.TabIndex = 7;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // cbbLoaiTK
            // 
            this.cbbLoaiTK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLoaiTK.FormattingEnabled = true;
            this.cbbLoaiTK.Location = new System.Drawing.Point(88, 36);
            this.cbbLoaiTK.Name = "cbbLoaiTK";
            this.cbbLoaiTK.Size = new System.Drawing.Size(360, 21);
            this.cbbLoaiTK.TabIndex = 8;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(528, 12);
            this.txtMatKhau.MenuManager = this.barManager1;
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(363, 20);
            this.txtMatKhau.StyleController = this.layoutControl1;
            this.txtMatKhau.TabIndex = 5;
            // 
            // pnNhapTT
            // 
            this.pnNhapTT.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.pnNhapTT.GroupBordersVisible = false;
            this.pnNhapTT.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem5,
            this.layoutControlItem4,
            this.layoutControlItem1});
            this.pnNhapTT.Name = "pnNhapTT";
            this.pnNhapTT.Size = new System.Drawing.Size(903, 79);
            this.pnNhapTT.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtMatKhau;
            this.layoutControlItem2.Location = new System.Drawing.Point(440, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(443, 24);
            this.layoutControlItem2.Text = "Mật Khẩu:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(73, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.cbbLoaiTK;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(440, 35);
            this.layoutControlItem5.Text = "Loại Tài Khoản:";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(73, 13);
            // 
            // dgcQuanLyNguoiDung
            // 
            this.dgcQuanLyNguoiDung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgcQuanLyNguoiDung.Location = new System.Drawing.Point(0, 111);
            this.dgcQuanLyNguoiDung.MainView = this.dgvQuanLyNguoiDung;
            this.dgcQuanLyNguoiDung.MenuManager = this.barManager1;
            this.dgcQuanLyNguoiDung.Name = "dgcQuanLyNguoiDung";
            this.dgcQuanLyNguoiDung.Size = new System.Drawing.Size(903, 377);
            this.dgcQuanLyNguoiDung.TabIndex = 8;
            this.dgcQuanLyNguoiDung.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvQuanLyNguoiDung});
            // 
            // dgvQuanLyNguoiDung
            // 
            this.dgvQuanLyNguoiDung.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.TaiKhoan,
            this.MatKhau,
            this.LoaiUser,
            this.Ma});
            this.dgvQuanLyNguoiDung.GridControl = this.dgcQuanLyNguoiDung;
            this.dgvQuanLyNguoiDung.Name = "dgvQuanLyNguoiDung";
            this.dgvQuanLyNguoiDung.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgvQuanLyNguoiDung.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgvQuanLyNguoiDung.OptionsBehavior.Editable = false;
            // 
            // TaiKhoan
            // 
            this.TaiKhoan.Caption = "Tài Khoản";
            this.TaiKhoan.FieldName = "TaiKhoan";
            this.TaiKhoan.Name = "TaiKhoan";
            this.TaiKhoan.Visible = true;
            this.TaiKhoan.VisibleIndex = 0;
            // 
            // MatKhau
            // 
            this.MatKhau.Caption = "Mật Khẩu";
            this.MatKhau.FieldName = "MatKhau";
            this.MatKhau.Name = "MatKhau";
            this.MatKhau.Visible = true;
            this.MatKhau.VisibleIndex = 1;
            // 
            // LoaiUser
            // 
            this.LoaiUser.Caption = "Loại Tài Khoản";
            this.LoaiUser.FieldName = "LoaiUser";
            this.LoaiUser.Name = "LoaiUser";
            this.LoaiUser.Visible = true;
            this.LoaiUser.VisibleIndex = 2;
            // 
            // Ma
            // 
            this.Ma.Caption = "Mã Giáo Viên / Sinh Viên";
            this.Ma.FieldName = "Ma";
            this.Ma.Name = "Ma";
            this.Ma.Visible = true;
            this.Ma.VisibleIndex = 3;
            // 
            // saveFile
            // 
            this.saveFile.Filter = "Excel File | *.xlsx";
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Location = new System.Drawing.Point(88, 12);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(360, 20);
            this.txtTaiKhoan.TabIndex = 10;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.txtTaiKhoan;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(440, 24);
            this.layoutControlItem4.Text = "Tài Khoản:";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(73, 13);
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(528, 36);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(363, 20);
            this.txtMa.TabIndex = 11;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtMa;
            this.layoutControlItem1.Location = new System.Drawing.Point(440, 24);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(443, 35);
            this.layoutControlItem1.Text = "Mã GV / SV:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(73, 13);
            // 
            // frmQuanLyNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 488);
            this.Controls.Add(this.dgcQuanLyNguoiDung);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmQuanLyNguoiDung";
            this.Text = "Quản Lý Người Dùng";
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtMatKhau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnNhapTT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgcQuanLyNguoiDung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLyNguoiDung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar4;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnThucThi;
        private DevExpress.XtraBars.BarButtonItem btnHuyBo;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit txtMatKhau;
        private DevExpress.XtraLayout.LayoutControlGroup pnNhapTT;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraGrid.GridControl dgcQuanLyNguoiDung;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvQuanLyNguoiDung;
        private System.Windows.Forms.SaveFileDialog saveFile;
        private DevExpress.XtraGrid.Columns.GridColumn TaiKhoan;
        private DevExpress.XtraGrid.Columns.GridColumn MatKhau;
        private DevExpress.XtraGrid.Columns.GridColumn LoaiUser;
        private DevExpress.XtraGrid.Columns.GridColumn Ma;
        private System.Windows.Forms.ComboBox cbbLoaiTK;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.BarSubItem btnTim;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem TheoTaiKhoan;
        private DevExpress.XtraBars.BarButtonItem TheoLoaiTK;
        private DevExpress.XtraBars.BarButtonItem TheoMaGV;
        private DevExpress.XtraBars.BarButtonItem btnReLoad;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    }
}