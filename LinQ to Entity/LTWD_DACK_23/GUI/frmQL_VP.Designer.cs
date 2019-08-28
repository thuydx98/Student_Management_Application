namespace GUI
{
    partial class frmQL_VP
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
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnLuu = new DevExpress.XtraBars.BarButtonItem();
            this.btnHuy = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.txtNgayViPham = new DevExpress.XtraEditors.DateEdit();
            this.txtHTKyLuat = new DevExpress.XtraEditors.TextEdit();
            this.txtNoiDung = new DevExpress.XtraEditors.TextEdit();
            this.lcgNhap = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.dgcViPham = new DevExpress.XtraGrid.GridControl();
            this.dgvViPham = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaSV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NoiDung = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HinhThucKL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayViPham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayViPham.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayViPham.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHTKyLuat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoiDung.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgcViPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnSua,
            this.btnXoa,
            this.btnLuu,
            this.btnHuy});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 7;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLuu, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnHuy, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 2;
            this.btnThem.ImageOptions.Image = global::GUI.Properties.Resources.Them;
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Sửa";
            this.btnSua.Id = 3;
            this.btnSua.ImageOptions.Image = global::GUI.Properties.Resources.Sua;
            this.btnSua.Name = "btnSua";
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 4;
            this.btnXoa.ImageOptions.Image = global::GUI.Properties.Resources.Xoa;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnLuu
            // 
            this.btnLuu.Caption = "Lưu";
            this.btnLuu.Id = 5;
            this.btnLuu.ImageOptions.Image = global::GUI.Properties.Resources.Luu;
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLuu_ItemClick);
            // 
            // btnHuy
            // 
            this.btnHuy.Caption = "Hủy";
            this.btnHuy.Id = 6;
            this.btnHuy.ImageOptions.Image = global::GUI.Properties.Resources.Huy;
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHuy_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(800, 32);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 450);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(800, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 32);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 418);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(800, 32);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 418);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txtMaSV);
            this.layoutControl1.Controls.Add(this.txtNgayViPham);
            this.layoutControl1.Controls.Add(this.txtHTKyLuat);
            this.layoutControl1.Controls.Add(this.txtNoiDung);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutControl1.Location = new System.Drawing.Point(0, 32);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.lcgNhap;
            this.layoutControl1.Size = new System.Drawing.Size(800, 69);
            this.layoutControl1.TabIndex = 4;
            this.layoutControl1.Text = "lcgNhapTT";
            // 
            // txtNgayViPham
            // 
            this.txtNgayViPham.EditValue = null;
            this.txtNgayViPham.Location = new System.Drawing.Point(586, 36);
            this.txtNgayViPham.MenuManager = this.barManager1;
            this.txtNgayViPham.Name = "txtNgayViPham";
            this.txtNgayViPham.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNgayViPham.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNgayViPham.Size = new System.Drawing.Size(202, 20);
            this.txtNgayViPham.StyleController = this.layoutControl1;
            this.txtNgayViPham.TabIndex = 7;
            this.txtNgayViPham.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNgayViPham_KeyDown);
            // 
            // txtHTKyLuat
            // 
            this.txtHTKyLuat.Location = new System.Drawing.Point(106, 36);
            this.txtHTKyLuat.MenuManager = this.barManager1;
            this.txtHTKyLuat.Name = "txtHTKyLuat";
            this.txtHTKyLuat.Size = new System.Drawing.Size(382, 20);
            this.txtHTKyLuat.StyleController = this.layoutControl1;
            this.txtHTKyLuat.TabIndex = 6;
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Location = new System.Drawing.Point(367, 12);
            this.txtNoiDung.MenuManager = this.barManager1;
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(421, 20);
            this.txtNoiDung.StyleController = this.layoutControl1;
            this.txtNoiDung.TabIndex = 5;
            // 
            // lcgNhap
            // 
            this.lcgNhap.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.lcgNhap.GroupBordersVisible = false;
            this.lcgNhap.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5});
            this.lcgNhap.Name = "lcgNhap";
            this.lcgNhap.Size = new System.Drawing.Size(800, 69);
            this.lcgNhap.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtNoiDung;
            this.layoutControlItem2.Location = new System.Drawing.Point(261, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(519, 24);
            this.layoutControlItem2.Text = "Nội Dung:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(91, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txtHTKyLuat;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(480, 25);
            this.layoutControlItem3.Text = "Hình Thức Kỷ Luật:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(91, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.txtNgayViPham;
            this.layoutControlItem4.Location = new System.Drawing.Point(480, 24);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(300, 25);
            this.layoutControlItem4.Text = "Ngày Vi Phạm:";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(91, 13);
            // 
            // dgcViPham
            // 
            this.dgcViPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgcViPham.Location = new System.Drawing.Point(0, 101);
            this.dgcViPham.MainView = this.dgvViPham;
            this.dgcViPham.MenuManager = this.barManager1;
            this.dgcViPham.Name = "dgcViPham";
            this.dgcViPham.Size = new System.Drawing.Size(800, 349);
            this.dgcViPham.TabIndex = 5;
            this.dgcViPham.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvViPham});
            // 
            // dgvViPham
            // 
            this.dgvViPham.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaSV,
            this.NoiDung,
            this.HinhThucKL,
            this.NgayViPham});
            this.dgvViPham.GridControl = this.dgcViPham;
            this.dgvViPham.Name = "dgvViPham";
            // 
            // MaSV
            // 
            this.MaSV.Caption = "Mã Sinh Viên";
            this.MaSV.FieldName = "MaSV";
            this.MaSV.Name = "MaSV";
            this.MaSV.Visible = true;
            this.MaSV.VisibleIndex = 0;
            // 
            // NoiDung
            // 
            this.NoiDung.Caption = "Nội Dung";
            this.NoiDung.FieldName = "NoiDung";
            this.NoiDung.Name = "NoiDung";
            this.NoiDung.Visible = true;
            this.NoiDung.VisibleIndex = 1;
            // 
            // HinhThucKL
            // 
            this.HinhThucKL.Caption = "Hình Thức Kỷ Luật";
            this.HinhThucKL.FieldName = "HinhThucKL";
            this.HinhThucKL.Name = "HinhThucKL";
            this.HinhThucKL.Visible = true;
            this.HinhThucKL.VisibleIndex = 2;
            // 
            // NgayViPham
            // 
            this.NgayViPham.Caption = "Ngày Vi Phạm";
            this.NgayViPham.FieldName = "NgayViPham";
            this.NgayViPham.Name = "NgayViPham";
            this.NgayViPham.Visible = true;
            this.NgayViPham.VisibleIndex = 3;
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(106, 12);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(163, 20);
            this.txtMaSV.TabIndex = 8;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.txtMaSV;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(261, 24);
            this.layoutControlItem5.Text = "Mã Sinh Viên:";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(91, 13);
            // 
            // frmQL_VP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgcViPham);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmQL_VP";
            this.Text = "Quản Lý Vi Phạm";
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayViPham.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayViPham.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHTKyLuat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoiDung.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgcViPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnLuu;
        private DevExpress.XtraBars.BarButtonItem btnHuy;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.GridControl dgcViPham;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvViPham;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.DateEdit txtNgayViPham;
        private DevExpress.XtraEditors.TextEdit txtHTKyLuat;
        private DevExpress.XtraEditors.TextEdit txtNoiDung;
        private DevExpress.XtraLayout.LayoutControlGroup lcgNhap;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraGrid.Columns.GridColumn MaSV;
        private DevExpress.XtraGrid.Columns.GridColumn NoiDung;
        private DevExpress.XtraGrid.Columns.GridColumn HinhThucKL;
        private DevExpress.XtraGrid.Columns.GridColumn NgayViPham;
        private System.Windows.Forms.TextBox txtMaSV;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
    }
}