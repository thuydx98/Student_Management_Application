using System;
using System.Collections.Generic;
using System.Linq;
using DAO;

namespace BUS
{
    public class SinhVienBUS
    {
        DBQuanLySVDataContext db = new DBQuanLySVDataContext();

        public List<spGetMSSVResult> getMSSV()
        {
            return db.spGetMSSV().ToList();
        }

        public List<spGetSVTheoMaSVResult> getSVTheoMaSV(string maSV)
        {
            return db.spGetSVTheoMaSV(maSV).ToList();
        }

        public List<spGetSVTheoMaHPResult> getSVTheoMaHP(string maHP)
        {
            return db.spGetSVTheoMaHP(maHP).ToList();
        }

        public List<spGetSVTheoMaLopResult> getSVTheoMaLop(string maLop)
        {
            return db.spGetSVTheoMaLop(maLop).ToList();
        }

        public List<spGetSiSoLopResult> getSiSoLop(string maLop)
        {
            return db.spGetSiSoLop(maLop).ToList();
        }

        public List<spGetDSSVCanhBaoHVResult> getDSSVCanhBaoHV()
        {
            return db.spGetDSSVCanhBaoHV().ToList();
        }

        public List<spGetDiemTB_SoTCResult> getDiemTB_SoTC(string maSV)
        {
            return db.spGetDiemTB_SoTC(maSV).ToList();
        }

        public List<spGetDiemTBTL_SoTCTLResult> getDiemTBTL_SoTCTL(string maSV)
        {
            return db.spGetDiemTBTL_SoTCTL(maSV).ToList();
        }

        public List<spGetSVThieuDiemCTXHResult> getSVThieuDiemCTXH()
        {
            return db.spGetSVThieuDiemCTXH().ToList();
        }

        public List<spGetSVNoHocPhiResult> getSVNoHocPhi()
        {
            return db.spGetSVNoHocPhi().ToList();
        }

        public List<spGetHBNhatLop_NamHoc_HocKyResult> getDSSVHBNhatLop(string namHoc, int hocKy)
        {
            return db.spGetHBNhatLop_NamHoc_HocKy(namHoc, hocKy).ToList();
        }

        public List<spGetHBGioi_NamHoc_HocKyResult> getDSSVHBGioi(string namHoc, int hocKy)
        {
            return db.spGetHBGioi_NamHoc_HocKy(namHoc, hocKy).ToList();
        }

        public List<spGetHBKha_NamHoc_HocKyResult> getDSSVHBKha(string namHoc, int hocKy)
        {
            return db.spGetHBKha_NamHoc_HocKy(namHoc, hocKy).ToList();
        }

        public bool themSinhVien(string maSV, string hoTen, string diaChi, string ngaySinh, string gioiTinh, string danToc, string queQuan, string maLop)
        {
            try
            {
                db.spThemSinhVien(maSV, hoTen, diaChi, Convert.ToDateTime(ngaySinh), gioiTinh, danToc, queQuan, maLop);
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool suaSinhVien(string maSV, string hoTen, string diaChi, string ngaySinh, string gioiTinh, string danToc, string queQuan, string maLop)
        {
            try
            {
                db.spSuaSinhVien(maSV, hoTen, diaChi, Convert.ToDateTime(ngaySinh), gioiTinh, danToc, queQuan, maLop);
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool xoaSinhVien(string maSV)
        {
            try
            {
                db.spXoaSinhVien(maSV);
            }
            catch
            {
                return false;
            }

            return true;
        }
    }
}
