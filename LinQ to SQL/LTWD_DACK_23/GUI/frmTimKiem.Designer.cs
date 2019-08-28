namespace GUI
{
    partial class frmTimKiem
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
            this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControl4 = new DevExpress.XtraLayout.LayoutControl();
            this.btnIn = new DevExpress.XtraEditors.SimpleButton();
            this.btnReLoad = new DevExpress.XtraEditors.SimpleButton();
            this.lcgNho2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lcgNho1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnTimKiem = new DevExpress.XtraEditors.SimpleButton();
            this.cbbChonHocKy = new System.Windows.Forms.ComboBox();
            this.cbbChonNamHoc = new System.Windows.Forms.ComboBox();
            this.lcgNho = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lcgTo = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.dgcTimKiem = new DevExpress.XtraGrid.GridControl();
            this.dgvTimKiem = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlItem12 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem11 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
            this.layoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl4)).BeginInit();
            this.layoutControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lcgNho2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgNho1)).BeginInit();
            this.lcgNho1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lcgNho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgcTimKiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimKiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl2
            // 
            this.layoutControl2.Controls.Add(this.layoutControl4);
            this.layoutControl2.Controls.Add(this.lcgNho1);
            this.layoutControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutControl2.Location = new System.Drawing.Point(0, 0);
            this.layoutControl2.Name = "layoutControl2";
            this.layoutControl2.Root = this.lcgTo;
            this.layoutControl2.Size = new System.Drawing.Size(800, 78);
            this.layoutControl2.TabIndex = 2;
            this.layoutControl2.Text = "layoutControl2";
            // 
            // layoutControl4
            // 
            this.layoutControl4.Controls.Add(this.btnIn);
            this.layoutControl4.Controls.Add(this.btnReLoad);
            this.layoutControl4.Location = new System.Drawing.Point(541, 12);
            this.layoutControl4.Name = "layoutControl4";
            this.layoutControl4.Root = this.lcgNho2;
            this.layoutControl4.Size = new System.Drawing.Size(247, 54);
            this.layoutControl4.TabIndex = 5;
            this.layoutControl4.Text = "layoutControl4";
            // 
            // btnIn
            // 
            this.btnIn.Enabled = false;
            this.btnIn.ImageOptions.Image = global::GUI.Properties.Resources.In;
            this.btnIn.Location = new System.Drawing.Point(125, 12);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(110, 30);
            this.btnIn.StyleController = this.layoutControl4;
            this.btnIn.TabIndex = 6;
            this.btnIn.Text = "In";
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnReLoad
            // 
            this.btnReLoad.Enabled = false;
            this.btnReLoad.ImageOptions.Image = global::GUI.Properties.Resources.LamMoi;
            this.btnReLoad.Location = new System.Drawing.Point(12, 12);
            this.btnReLoad.Name = "btnReLoad";
            this.btnReLoad.Size = new System.Drawing.Size(109, 30);
            this.btnReLoad.StyleController = this.layoutControl4;
            this.btnReLoad.TabIndex = 4;
            this.btnReLoad.Text = "Reload";
            this.btnReLoad.Click += new System.EventHandler(this.btnReLoad_Click);
            // 
            // lcgNho2
            // 
            this.lcgNho2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.lcgNho2.GroupBordersVisible = false;
            this.lcgNho2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.lcgNho2.Name = "lcgNho2";
            this.lcgNho2.Size = new System.Drawing.Size(247, 54);
            this.lcgNho2.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.btnReLoad;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(113, 34);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnIn;
            this.layoutControlItem2.Location = new System.Drawing.Point(113, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(114, 34);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // lcgNho1
            // 
            this.lcgNho1.Controls.Add(this.btnTimKiem);
            this.lcgNho1.Controls.Add(this.cbbChonHocKy);
            this.lcgNho1.Controls.Add(this.cbbChonNamHoc);
            this.lcgNho1.Location = new System.Drawing.Point(12, 12);
            this.lcgNho1.Name = "lcgNho1";
            this.lcgNho1.Root = this.lcgNho;
            this.lcgNho1.Size = new System.Drawing.Size(525, 54);
            this.lcgNho1.TabIndex = 4;
            this.lcgNho1.Text = "layoutControl3";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.ImageOptions.Image = global::GUI.Properties.Resources.TimKiem;
            this.btnTimKiem.Location = new System.Drawing.Point(390, 12);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(123, 30);
            this.btnTimKiem.StyleController = this.lcgNho1;
            this.btnTimKiem.TabIndex = 6;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // cbbChonHocKy
            // 
            this.cbbChonHocKy.FormattingEnabled = true;
            this.cbbChonHocKy.Location = new System.Drawing.Point(327, 12);
            this.cbbChonHocKy.Name = "cbbChonHocKy";
            this.cbbChonHocKy.Size = new System.Drawing.Size(59, 21);
            this.cbbChonHocKy.TabIndex = 5;
            // 
            // cbbChonNamHoc
            // 
            this.cbbChonNamHoc.FormattingEnabled = true;
            this.cbbChonNamHoc.Location = new System.Drawing.Point(89, 12);
            this.cbbChonNamHoc.Name = "cbbChonNamHoc";
            this.cbbChonNamHoc.Size = new System.Drawing.Size(157, 21);
            this.cbbChonNamHoc.TabIndex = 4;
            // 
            // lcgNho
            // 
            this.lcgNho.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.lcgNho.GroupBordersVisible = false;
            this.lcgNho.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem8,
            this.layoutControlItem9,
            this.layoutControlItem10});
            this.lcgNho.Name = "lcgNho";
            this.lcgNho.Size = new System.Drawing.Size(525, 54);
            this.lcgNho.TextVisible = false;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.cbbChonNamHoc;
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(238, 34);
            this.layoutControlItem8.Text = "Chọn Năm Học:";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(74, 13);
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.cbbChonHocKy;
            this.layoutControlItem9.Location = new System.Drawing.Point(238, 0);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(140, 34);
            this.layoutControlItem9.Text = "Chọn Học Kỳ:";
            this.layoutControlItem9.TextSize = new System.Drawing.Size(74, 13);
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.btnTimKiem;
            this.layoutControlItem10.Location = new System.Drawing.Point(378, 0);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(127, 34);
            this.layoutControlItem10.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem10.TextVisible = false;
            // 
            // lcgTo
            // 
            this.lcgTo.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.lcgTo.GroupBordersVisible = false;
            this.lcgTo.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem6,
            this.layoutControlItem7});
            this.lcgTo.Name = "lcgTo";
            this.lcgTo.Size = new System.Drawing.Size(800, 78);
            this.lcgTo.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.lcgNho1;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(529, 58);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.layoutControl4;
            this.layoutControlItem7.Location = new System.Drawing.Point(529, 0);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(251, 58);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // dgcTimKiem
            // 
            this.dgcTimKiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgcTimKiem.Location = new System.Drawing.Point(0, 78);
            this.dgcTimKiem.MainView = this.dgvTimKiem;
            this.dgcTimKiem.Name = "dgcTimKiem";
            this.dgcTimKiem.Size = new System.Drawing.Size(800, 372);
            this.dgcTimKiem.TabIndex = 3;
            this.dgcTimKiem.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvTimKiem});
            // 
            // dgvTimKiem
            // 
            this.dgvTimKiem.GridControl = this.dgcTimKiem;
            this.dgvTimKiem.Name = "dgvTimKiem";
            this.dgvTimKiem.OptionsBehavior.Editable = false;
            // 
            // layoutControlItem12
            // 
            this.layoutControlItem12.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem12.Name = "layoutControlItem12";
            this.layoutControlItem12.Size = new System.Drawing.Size(143, 131);
            this.layoutControlItem12.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem12.TextVisible = false;
            // 
            // layoutControlItem11
            // 
            this.layoutControlItem11.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem11.Name = "layoutControlItem11";
            this.layoutControlItem11.Size = new System.Drawing.Size(90, 131);
            this.layoutControlItem11.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem11.TextVisible = false;
            // 
            // frmTimKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgcTimKiem);
            this.Controls.Add(this.layoutControl2);
            this.Name = "frmTimKiem";
            this.Text = "Tìm Kiếm";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
            this.layoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl4)).EndInit();
            this.layoutControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lcgNho2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgNho1)).EndInit();
            this.lcgNho1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lcgNho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgcTimKiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimKiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl2;
        private DevExpress.XtraLayout.LayoutControl lcgNho1;
        private DevExpress.XtraEditors.SimpleButton btnTimKiem;
        private System.Windows.Forms.ComboBox cbbChonHocKy;
        private System.Windows.Forms.ComboBox cbbChonNamHoc;
        private DevExpress.XtraLayout.LayoutControlGroup lcgNho;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        private DevExpress.XtraLayout.LayoutControlGroup lcgTo;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraGrid.GridControl dgcTimKiem;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvTimKiem;
        private DevExpress.XtraLayout.LayoutControl layoutControl4;
        private DevExpress.XtraEditors.SimpleButton btnIn;
        private DevExpress.XtraEditors.SimpleButton btnReLoad;
        private DevExpress.XtraLayout.LayoutControlGroup lcgNho2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem12;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem11;
    }
}