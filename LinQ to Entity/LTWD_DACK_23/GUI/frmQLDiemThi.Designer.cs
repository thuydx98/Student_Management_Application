namespace GUI
{
    partial class frmQLDiemThi
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
            this.btnNhapDiem = new DevExpress.XtraBars.BarButtonItem();
            this.btnLuu = new DevExpress.XtraBars.BarButtonItem();
            this.btnHuy = new DevExpress.XtraBars.BarButtonItem();
            this.btnReLoad = new DevExpress.XtraBars.BarButtonItem();
            this.btnIn = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.txtHocKy = new DevExpress.XtraEditors.TextEdit();
            this.txtNamHoc = new DevExpress.XtraEditors.TextEdit();
            this.txtMaGiaoVien = new System.Windows.Forms.TextBox();
            this.txtSoTC = new System.Windows.Forms.TextBox();
            this.cbbHocPhan = new System.Windows.Forms.ComboBox();
            this.cbbMonHoc = new System.Windows.Forms.ComboBox();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.dgcDiemThi = new DevExpress.XtraGrid.GridControl();
            this.dgvDiemThi = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaSV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HoTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DiemGiuaKy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DiemCuoiKy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHocKy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNamHoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgcDiemThi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiemThi)).BeginInit();
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
            this.barButtonItem1,
            this.btnNhapDiem,
            this.btnLuu,
            this.btnHuy,
            this.btnReLoad,
            this.btnIn});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 10;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnNhapDiem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLuu, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnHuy, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnReLoad, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnIn, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnNhapDiem
            // 
            this.btnNhapDiem.Caption = "Nhập Điểm";
            this.btnNhapDiem.Id = 3;
            this.btnNhapDiem.ImageOptions.Image = global::GUI.Properties.Resources.NhapDiem;
            this.btnNhapDiem.Name = "btnNhapDiem";
            this.btnNhapDiem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNhapDiem_ItemClick);
            // 
            // btnLuu
            // 
            this.btnLuu.Caption = "Lưu";
            this.btnLuu.Id = 4;
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
            // btnReLoad
            // 
            this.btnReLoad.Caption = "ReLoad";
            this.btnReLoad.Id = 7;
            this.btnReLoad.ImageOptions.Image = global::GUI.Properties.Resources.LamMoi;
            this.btnReLoad.Name = "btnReLoad";
            this.btnReLoad.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReLoad_ItemClick);
            // 
            // btnIn
            // 
            this.btnIn.Caption = "In";
            this.btnIn.Id = 9;
            this.btnIn.ImageOptions.Image = global::GUI.Properties.Resources.In;
            this.btnIn.Name = "btnIn";
            this.btnIn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnIn_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(857, 32);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 610);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(857, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 32);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 578);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(857, 32);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 578);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Môn Học";
            this.barButtonItem1.Id = 2;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txtHocKy);
            this.layoutControl1.Controls.Add(this.txtNamHoc);
            this.layoutControl1.Controls.Add(this.txtMaGiaoVien);
            this.layoutControl1.Controls.Add(this.txtSoTC);
            this.layoutControl1.Controls.Add(this.cbbHocPhan);
            this.layoutControl1.Controls.Add(this.cbbMonHoc);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutControl1.Location = new System.Drawing.Point(0, 32);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(857, 70);
            this.layoutControl1.TabIndex = 4;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txtHocKy
            // 
            this.txtHocKy.Location = new System.Drawing.Point(323, 37);
            this.txtHocKy.MenuManager = this.barManager1;
            this.txtHocKy.Name = "txtHocKy";
            this.txtHocKy.Size = new System.Drawing.Size(50, 20);
            this.txtHocKy.StyleController = this.layoutControl1;
            this.txtHocKy.TabIndex = 11;
            // 
            // txtNamHoc
            // 
            this.txtNamHoc.Location = new System.Drawing.Point(81, 37);
            this.txtNamHoc.MenuManager = this.barManager1;
            this.txtNamHoc.Name = "txtNamHoc";
            this.txtNamHoc.Size = new System.Drawing.Size(169, 20);
            this.txtNamHoc.StyleController = this.layoutControl1;
            this.txtNamHoc.TabIndex = 10;
            // 
            // txtMaGiaoVien
            // 
            this.txtMaGiaoVien.Location = new System.Drawing.Point(446, 37);
            this.txtMaGiaoVien.Name = "txtMaGiaoVien";
            this.txtMaGiaoVien.Size = new System.Drawing.Size(285, 20);
            this.txtMaGiaoVien.TabIndex = 9;
            // 
            // txtSoTC
            // 
            this.txtSoTC.Location = new System.Drawing.Point(804, 37);
            this.txtSoTC.Name = "txtSoTC";
            this.txtSoTC.Size = new System.Drawing.Size(41, 20);
            this.txtSoTC.TabIndex = 8;
            // 
            // cbbHocPhan
            // 
            this.cbbHocPhan.FormattingEnabled = true;
            this.cbbHocPhan.Location = new System.Drawing.Point(479, 12);
            this.cbbHocPhan.Name = "cbbHocPhan";
            this.cbbHocPhan.Size = new System.Drawing.Size(366, 21);
            this.cbbHocPhan.TabIndex = 5;
            this.cbbHocPhan.SelectedValueChanged += new System.EventHandler(this.cbbHocPhan_SelectedValueChanged);
            // 
            // cbbMonHoc
            // 
            this.cbbMonHoc.FormattingEnabled = true;
            this.cbbMonHoc.Location = new System.Drawing.Point(81, 12);
            this.cbbMonHoc.Name = "cbbMonHoc";
            this.cbbMonHoc.Size = new System.Drawing.Size(325, 21);
            this.cbbMonHoc.TabIndex = 4;
            this.cbbMonHoc.SelectedValueChanged += new System.EventHandler(this.cbbMonHoc_SelectedValueChanged);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.layoutControlItem3});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(857, 70);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.cbbMonHoc;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(398, 25);
            this.layoutControlItem1.Text = "Môn Học:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(66, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.cbbHocPhan;
            this.layoutControlItem2.Location = new System.Drawing.Point(398, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(439, 25);
            this.layoutControlItem2.Text = "Mã Học Phần:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(66, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.txtSoTC;
            this.layoutControlItem5.Location = new System.Drawing.Point(723, 25);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(114, 25);
            this.layoutControlItem5.Text = "Số Tín Chỉ:";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(66, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.txtMaGiaoVien;
            this.layoutControlItem6.Location = new System.Drawing.Point(365, 25);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(358, 25);
            this.layoutControlItem6.Text = "Mã Giáo Viên:";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(66, 13);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.txtNamHoc;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 25);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(242, 25);
            this.layoutControlItem7.Text = "Năm Học:";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(66, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txtHocKy;
            this.layoutControlItem3.Location = new System.Drawing.Point(242, 25);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(123, 25);
            this.layoutControlItem3.Text = "Học Kỳ:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(66, 13);
            // 
            // dgcDiemThi
            // 
            this.dgcDiemThi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgcDiemThi.EmbeddedNavigator.Enabled = false;
            this.dgcDiemThi.Location = new System.Drawing.Point(0, 102);
            this.dgcDiemThi.MainView = this.dgvDiemThi;
            this.dgcDiemThi.MenuManager = this.barManager1;
            this.dgcDiemThi.Name = "dgcDiemThi";
            this.dgcDiemThi.Size = new System.Drawing.Size(857, 508);
            this.dgcDiemThi.TabIndex = 5;
            this.dgcDiemThi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvDiemThi});
            // 
            // dgvDiemThi
            // 
            this.dgvDiemThi.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaSV,
            this.HoTen,
            this.DiemGiuaKy,
            this.DiemCuoiKy});
            this.dgvDiemThi.GridControl = this.dgcDiemThi;
            this.dgvDiemThi.Name = "dgvDiemThi";
            this.dgvDiemThi.OptionsBehavior.Editable = false;
            // 
            // MaSV
            // 
            this.MaSV.Caption = "Mã Sinh Viên";
            this.MaSV.FieldName = "MaSV";
            this.MaSV.Name = "MaSV";
            this.MaSV.Visible = true;
            this.MaSV.VisibleIndex = 0;
            this.MaSV.Width = 168;
            // 
            // HoTen
            // 
            this.HoTen.Caption = "Họ Tên";
            this.HoTen.FieldName = "HoTen";
            this.HoTen.Name = "HoTen";
            this.HoTen.Visible = true;
            this.HoTen.VisibleIndex = 1;
            this.HoTen.Width = 271;
            // 
            // DiemGiuaKy
            // 
            this.DiemGiuaKy.Caption = "Điểm Giữa Kỳ";
            this.DiemGiuaKy.FieldName = "DiemGiuaKy";
            this.DiemGiuaKy.Name = "DiemGiuaKy";
            this.DiemGiuaKy.Visible = true;
            this.DiemGiuaKy.VisibleIndex = 2;
            this.DiemGiuaKy.Width = 194;
            // 
            // DiemCuoiKy
            // 
            this.DiemCuoiKy.Caption = "Điểm Cuối Kỳ";
            this.DiemCuoiKy.FieldName = "DiemCuoiKy";
            this.DiemCuoiKy.Name = "DiemCuoiKy";
            this.DiemCuoiKy.Visible = true;
            this.DiemCuoiKy.VisibleIndex = 3;
            this.DiemCuoiKy.Width = 205;
            // 
            // saveFile
            // 
            this.saveFile.Filter = "Excel File | *.xlsx";
            // 
            // frmQLDiemThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 610);
            this.Controls.Add(this.dgcDiemThi);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmQLDiemThi";
            this.Text = "Điểm Thi";
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtHocKy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNamHoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgcDiemThi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiemThi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnNhapDiem;
        private DevExpress.XtraBars.BarButtonItem btnLuu;
        private DevExpress.XtraBars.BarButtonItem btnHuy;
        private DevExpress.XtraBars.BarButtonItem btnReLoad;
        private DevExpress.XtraBars.BarButtonItem btnIn;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraGrid.GridControl dgcDiemThi;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvDiemThi;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private System.Windows.Forms.TextBox txtSoTC;
        private System.Windows.Forms.ComboBox cbbHocPhan;
        private System.Windows.Forms.ComboBox cbbMonHoc;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private System.Windows.Forms.SaveFileDialog saveFile;
        private DevExpress.XtraGrid.Columns.GridColumn MaSV;
        private DevExpress.XtraGrid.Columns.GridColumn HoTen;
        private DevExpress.XtraGrid.Columns.GridColumn DiemGiuaKy;
        private DevExpress.XtraGrid.Columns.GridColumn DiemCuoiKy;
        private System.Windows.Forms.TextBox txtMaGiaoVien;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraEditors.TextEdit txtHocKy;
        private DevExpress.XtraEditors.TextEdit txtNamHoc;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    }
}