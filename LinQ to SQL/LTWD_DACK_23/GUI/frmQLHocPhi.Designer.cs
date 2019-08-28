namespace GUI
{
    partial class frmQLHocPhi
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
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnLuu = new DevExpress.XtraBars.BarButtonItem();
            this.btnHuy = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.txtMSSV = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.dgcDSHP = new DevExpress.XtraGrid.GridControl();
            this.dgvDSHP = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaSV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HoTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaHP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DaDongHP = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgcDSHP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHP)).BeginInit();
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
            this.btnSua,
            this.btnLuu,
            this.btnHuy});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLuu, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnHuy, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Sửa Tình Trạng Học Phí";
            this.btnSua.Enabled = false;
            this.btnSua.Id = 0;
            this.btnSua.ImageOptions.Image = global::GUI.Properties.Resources.Sua;
            this.btnSua.Name = "btnSua";
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_ItemClick);
            // 
            // btnLuu
            // 
            this.btnLuu.Caption = "Lưu";
            this.btnLuu.Enabled = false;
            this.btnLuu.Id = 1;
            this.btnLuu.ImageOptions.Image = global::GUI.Properties.Resources.Luu;
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLuu_ItemClick);
            // 
            // btnHuy
            // 
            this.btnHuy.Caption = "Hủy";
            this.btnHuy.Enabled = false;
            this.btnHuy.Id = 2;
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
            this.layoutControl1.Controls.Add(this.txtMSSV);
            this.layoutControl1.Controls.Add(this.btnTimKiem);
            this.layoutControl1.Controls.Add(this.label1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutControl1.Location = new System.Drawing.Point(0, 32);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(800, 54);
            this.layoutControl1.TabIndex = 4;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txtMSSV
            // 
            this.txtMSSV.Location = new System.Drawing.Point(73, 12);
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.Size = new System.Drawing.Size(405, 20);
            this.txtMSSV.TabIndex = 7;
            this.txtMSSV.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMSSV_KeyDown);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.ImageOptions.Image = global::GUI.Properties.Resources.TimKiem;
            this.btnTimKiem.Location = new System.Drawing.Point(482, 12);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(105, 30);
            this.btnTimKiem.StyleController = this.layoutControl1;
            this.btnTimKiem.TabIndex = 6;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(591, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 30);
            this.label1.TabIndex = 5;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(800, 54);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.label1;
            this.layoutControlItem2.Location = new System.Drawing.Point(579, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(201, 34);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnTimKiem;
            this.layoutControlItem3.Location = new System.Drawing.Point(470, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(109, 34);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.txtMSSV;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(470, 34);
            this.layoutControlItem4.Text = "Nhập MSSV:";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(58, 13);
            // 
            // dgcDSHP
            // 
            this.dgcDSHP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgcDSHP.Location = new System.Drawing.Point(0, 86);
            this.dgcDSHP.MainView = this.dgvDSHP;
            this.dgcDSHP.MenuManager = this.barManager1;
            this.dgcDSHP.Name = "dgcDSHP";
            this.dgcDSHP.Size = new System.Drawing.Size(800, 364);
            this.dgcDSHP.TabIndex = 5;
            this.dgcDSHP.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvDSHP});
            // 
            // dgvDSHP
            // 
            this.dgvDSHP.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaSV,
            this.HoTen,
            this.MaHP,
            this.DaDongHP});
            this.dgvDSHP.GridControl = this.dgcDSHP;
            this.dgvDSHP.Name = "dgvDSHP";
            this.dgvDSHP.OptionsBehavior.Editable = false;
            // 
            // MaSV
            // 
            this.MaSV.Caption = "Mã Sinh Viên";
            this.MaSV.FieldName = "MaSV";
            this.MaSV.Name = "MaSV";
            this.MaSV.Visible = true;
            this.MaSV.VisibleIndex = 0;
            // 
            // HoTen
            // 
            this.HoTen.Caption = "Họ Tên";
            this.HoTen.FieldName = "HoTen";
            this.HoTen.Name = "HoTen";
            this.HoTen.Visible = true;
            this.HoTen.VisibleIndex = 1;
            // 
            // MaHP
            // 
            this.MaHP.Caption = "Mã Học Phần";
            this.MaHP.FieldName = "MaHP";
            this.MaHP.Name = "MaHP";
            this.MaHP.Visible = true;
            this.MaHP.VisibleIndex = 2;
            // 
            // DaDongHP
            // 
            this.DaDongHP.Caption = "Tình Trạng Học Phí";
            this.DaDongHP.FieldName = "DaDongHP";
            this.DaDongHP.Name = "DaDongHP";
            this.DaDongHP.Visible = true;
            this.DaDongHP.VisibleIndex = 3;
            // 
            // frmQLHocPhi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgcDSHP);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmQLHocPhi";
            this.Text = "Quản Lý Học Phí";
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgcDSHP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnLuu;
        private DevExpress.XtraBars.BarButtonItem btnHuy;
        private DevExpress.XtraGrid.GridControl dgcDSHP;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvDSHP;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton btnTimKiem;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraGrid.Columns.GridColumn MaSV;
        private DevExpress.XtraGrid.Columns.GridColumn DaDongHP;
        private DevExpress.XtraGrid.Columns.GridColumn HoTen;
        private DevExpress.XtraGrid.Columns.GridColumn MaHP;
        private System.Windows.Forms.TextBox txtMSSV;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
    }
}