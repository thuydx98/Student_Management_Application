using System;
using Microsoft.Reporting.WinForms;
using BUS;

namespace GUI
{
    public partial class frmReport : DevExpress.XtraEditors.XtraForm
    {
        // Report DSSV
        public frmReport(string maKhoa, string maChuyenNganh, string maLop)
        {
            InitializeComponent();

            SinhVienBUS svBUS = new SinhVienBUS();

            ReportDataSource reportDataSource = new ReportDataSource();
            reportDataSource.Name = "dsSinhVien";
            reportDataSource.Value = svBUS.getSVTheoMaLop(maLop);
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);

            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GUI.ReportViews.rpDSSVTheoMaLop.rdlc";
            ReportParameter[] rp = new ReportParameter[3];
            rp[0] = new ReportParameter("MaLop", maLop);
            rp[1] = new ReportParameter("MaChuyenNganh", maChuyenNganh);
            rp[2] = new ReportParameter("MaKhoa", maKhoa);
            reportViewer1.LocalReport.SetParameters(rp);
        }

        // Report Thong ke HocPhi
        public frmReport(string maSV, string tb, string tbTL, string soTCTL, string xepLoai)
        {
            InitializeComponent();

            DIemThiBUS dtBUS = new DIemThiBUS();

            ReportDataSource reportDataSource = new ReportDataSource();
            reportDataSource.Name = "dsDiemThi_By_MSSV";
            reportDataSource.Value = dtBUS.getDiemTheoMSSV(maSV);
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);

            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GUI.ReportViews.rpDSDiemThiTheoSinhVien.rdlc";
            ReportParameter[] rp = new ReportParameter[4];
            rp[0] = new ReportParameter("TB", tb);
            rp[1] = new ReportParameter("TBTL", tbTL);
            rp[2] = new ReportParameter("SoTCTL", soTCTL);
            rp[3] = new ReportParameter("XepLoai", xepLoai);
            reportViewer1.LocalReport.SetParameters(rp);
        }

        // Report Thong Ke RenLuyen
        public frmReport(string maSV, string hoTen, string maLop, string namHoc, int hocKy, string tongDiem, string xepLoai)
        {
            InitializeComponent();

            RenLuyenBUS rlBUS = new RenLuyenBUS();

            ReportDataSource reportDataSource = new ReportDataSource();
            reportDataSource.Name = "dsRenLuyen_By_MSSV";
            reportDataSource.Value = rlBUS.getHDRLByMaSV_NamHoc_HocKy(maSV, namHoc, hocKy);
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);

            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GUI.ReportViews.rpRenLuyen_By_MSSV.rdlc";
            ReportParameter[] rp = new ReportParameter[7];
            rp[0] = new ReportParameter("MaSV", maSV);
            rp[1] = new ReportParameter("HoTen", hoTen);
            rp[2] = new ReportParameter("NamHoc", namHoc);
            rp[3] = new ReportParameter("HocKy", hocKy.ToString());
            rp[4] = new ReportParameter("TongDiem", tongDiem);
            rp[5] = new ReportParameter("XepLoai", xepLoai);
            rp[6] = new ReportParameter("MaLop", maLop);
            reportViewer1.LocalReport.SetParameters(rp);
        }

        // Report Thong Ke HocPhi, CTXH, ViPham
        public frmReport(string maSV, string hoTen, string maLop, string tong, int ktra)
        {
            InitializeComponent();

            if (ktra == 12)
            {
                HocPhanBUS hpBUS = new HocPhanBUS();

                ReportDataSource reportDataSource = new ReportDataSource();
                reportDataSource.Name = "dsNoHocPhi_By_MSSV";
                reportDataSource.Value = hpBUS.getHPByMaSV(maSV);
                reportViewer1.LocalReport.DataSources.Add(reportDataSource);

                this.reportViewer1.LocalReport.ReportEmbeddedResource = "GUI.ReportViews.rpNoHocPhi_By_MSSV.rdlc";
            }
            else
            {
                if (ktra == 7)
                {
                    CTXHBUS ctxhBUS = new CTXHBUS();

                    ReportDataSource reportDataSource = new ReportDataSource();
                    reportDataSource.Name = "dsCTXH_By_MSSV";
                    reportDataSource.Value = ctxhBUS.getHDCTXHByMaSV(maSV);
                    reportViewer1.LocalReport.DataSources.Add(reportDataSource);

                    this.reportViewer1.LocalReport.ReportEmbeddedResource = "GUI.ReportViews.rpCTXH_By_MSSV.rdlc";
                }
                else
                {
                    tong = "0";
                    ViPhamBUS vpBUS = new ViPhamBUS();

                    ReportDataSource reportDataSource = new ReportDataSource();
                    reportDataSource.Name = "dsViPham_By_MSSV";
                    reportDataSource.Value = vpBUS.getVPByMaSV(maSV);
                    reportViewer1.LocalReport.DataSources.Add(reportDataSource);

                    this.reportViewer1.LocalReport.ReportEmbeddedResource = "GUI.ReportViews.rpViPham_By_MSSV.rdlc";
                }
            }

            ReportParameter[] rp = new ReportParameter[4];
            rp[0] = new ReportParameter("MaSV", maSV);
            rp[1] = new ReportParameter("HoTen", hoTen);
            rp[2] = new ReportParameter("Tong", tong);
            rp[3] = new ReportParameter("MaLop", maLop);
            reportViewer1.LocalReport.SetParameters(rp);
        }

        // Report Quan Ly GiangVien / Diem Thi & HocPhan / CTXH / HDRL
        public frmReport(string ma, int ktra)
        {
            InitializeComponent();

            // QL CTXH
            if (ktra == 10)
            {
                DSSV_CTXHBUS dsCTXHBUS = new DSSV_CTXHBUS();

                ReportDataSource reportDataSource = new ReportDataSource();
                reportDataSource.Name = "dsQLCTXH";
                reportDataSource.Value = dsCTXHBUS.getSVByMaCTXH(ma);
                reportViewer1.LocalReport.DataSources.Add(reportDataSource);

                this.reportViewer1.LocalReport.ReportEmbeddedResource = "GUI.ReportViews.rpQLCTXH.rdlc";
            }
            else
            {
                // QL HDRL
                if (ktra == 11)
                {
                    DSSV_RLBUS dsHDRL = new DSSV_RLBUS();

                    ReportDataSource reportDataSource = new ReportDataSource();
                    reportDataSource.Name = "dsQLHDRL";
                    reportDataSource.Value = dsHDRL.getSVByMaRL(ma);
                    reportViewer1.LocalReport.DataSources.Add(reportDataSource);

                    this.reportViewer1.LocalReport.ReportEmbeddedResource = "GUI.ReportViews.rpQLHDRL.rdlc";
                }
                else
                {
                    // QL Giang Vien
                    if (ktra == 12)
                    {
                        GiangVienBUS gvBUS = new GiangVienBUS();

                        ReportDataSource reportDataSource = new ReportDataSource();
                        reportDataSource.Name = "dsQLGiangVien";
                        reportDataSource.Value = gvBUS.getGVTheoMaKhoa(ma);
                        reportViewer1.LocalReport.DataSources.Add(reportDataSource);

                        this.reportViewer1.LocalReport.ReportEmbeddedResource = "GUI.ReportViews.rpQLGiangVien.rdlc";
                    }
                    else
                    {
                        // QL Diem Thi
                        if (ktra == 13)
                        {
                            SinhVienBUS svBUS = new SinhVienBUS();

                            ReportDataSource reportDataSource = new ReportDataSource();
                            reportDataSource.Name = "dsDiemThi";
                            reportDataSource.Value = svBUS.getSVTheoMaHP(ma);
                            reportViewer1.LocalReport.DataSources.Add(reportDataSource);

                            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GUI.ReportViews.rpQLDiemThi.rdlc";
                        }
                        // QL Hoc Phan
                        else
                        {
                            SinhVienBUS svBUS = new SinhVienBUS();

                            ReportDataSource reportDataSource = new ReportDataSource();
                            reportDataSource.Name = "dsQLHocPhan";
                            reportDataSource.Value = svBUS.getSVTheoMaHP(ma);
                            reportViewer1.LocalReport.DataSources.Add(reportDataSource);

                            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GUI.ReportViews.rpQLHocPhan.rdlc";
                        }
                    }
                }
            }

            ReportParameter rp = new ReportParameter("Ma", ma);
            reportViewer1.LocalReport.SetParameters(rp);
        }

        // report Tim Kiem HocBong
        public frmReport(string namHoc, int hocKy, int ktra)
        {
            SinhVienBUS svBUS = new SinhVienBUS();
            InitializeComponent();

            // HB Nhat Lop
            if (ktra == 1)
            {
                ReportDataSource reportDataSource = new ReportDataSource();
                reportDataSource.Name = "dsSearchHocBong";
                reportDataSource.Value = svBUS.getDSSVHBNhatLop(namHoc, hocKy);
                reportViewer1.LocalReport.DataSources.Add(reportDataSource);

                this.reportViewer1.LocalReport.ReportEmbeddedResource = "GUI.ReportViews.rpSearchHBNhatLop.rdlc";
            }
            else
            {
                // HB Gioi
                if (ktra == 2)
                {
                    ReportDataSource reportDataSource = new ReportDataSource();
                    reportDataSource.Name = "dsSearchHocBong";
                    reportDataSource.Value = svBUS.getDSSVHBGioi(namHoc, hocKy);
                    reportViewer1.LocalReport.DataSources.Add(reportDataSource);

                    this.reportViewer1.LocalReport.ReportEmbeddedResource = "GUI.ReportViews.rpSearchHBGioi.rdlc";
                }
                // HB Kha
                else
                {
                    ReportDataSource reportDataSource = new ReportDataSource();
                    reportDataSource.Name = "dsSearchHocBong";
                    reportDataSource.Value = svBUS.getDSSVHBGioi(namHoc, hocKy);
                    reportViewer1.LocalReport.DataSources.Add(reportDataSource);

                    this.reportViewer1.LocalReport.ReportEmbeddedResource = "GUI.ReportViews.rpSearchHBKha.rdlc";
                }
            }

            ReportParameter[] rp = new ReportParameter[2];
            rp[0] = new ReportParameter("NamHoc", namHoc);
            rp[1] = new ReportParameter("HocKy", hocKy.ToString());
            reportViewer1.LocalReport.SetParameters(rp);
        }

        // Report Tim Kiem Canh Bao
        public frmReport(int ktra)
        {
            SinhVienBUS svBUS = new SinhVienBUS();
            InitializeComponent();
            ReportDataSource reportDataSource = new ReportDataSource();

            // Canh Bao Hoc Vu
            if (ktra == 4)
            { 
                reportDataSource.Name = "dsSearchCBHV";
                reportDataSource.Value = svBUS.getDSSVCanhBaoHV();
                reportViewer1.LocalReport.DataSources.Add(reportDataSource);

                this.reportViewer1.LocalReport.ReportEmbeddedResource = "GUI.ReportViews.rpSearchCBHV.rdlc";
            }
            else
            {
                // Diem CTXH
                if (ktra == 5)
                {
                    reportDataSource.Name = "dsSearchSVThieuDiemCTXH";
                    reportDataSource.Value = svBUS.getSVThieuDiemCTXH();
                    reportViewer1.LocalReport.DataSources.Add(reportDataSource);

                    this.reportViewer1.LocalReport.ReportEmbeddedResource = "GUI.ReportViews.rpSearchSVThieuDiemCTXH.rdlc";
                }
                // No Hoc Phi SV Toan truong
                else
                {
                    reportDataSource.Name = "dsSearchSVNoHP";
                    reportDataSource.Value = svBUS.getSVNoHocPhi();
                    reportViewer1.LocalReport.DataSources.Add(reportDataSource);

                    this.reportViewer1.LocalReport.ReportEmbeddedResource = "GUI.ReportViews.rpSearchSVNoHP.rdlc";
                }
            }
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }
    }
}
