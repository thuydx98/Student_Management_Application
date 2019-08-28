using System;
using System.Collections.Generic;
using System.Linq;
using DAO;

namespace BUS
{
    public class SinhVienBUS
    {
        DBQuanLySinhVienEntities db = new DBQuanLySinhVienEntities();

        public List<string> getMSSV()
        {
            return db.spGetMSSV().ToList();
        }

        public List<spGetSVTheoMaSV_Result> getSVTheoMaSV(string maSV)
        {
            return db.spGetSVTheoMaSV(maSV).ToList();
        }

        public List<spGetSVTheoMaHP_Result> getSVTheoMaHP(string maHP)
        {
            return db.spGetSVTheoMaHP(maHP).ToList();
        }

        public List<spGetSVTheoMaLop_Result> getSVTheoMaLop(string maLop)
        {
            return db.spGetSVTheoMaLop(maLop).ToList();
        }

        public List<System.Nullable<int>> getSiSoLop(string maLop)
        {
            return db.spGetSiSoLop(maLop).ToList();
        }

        public List<spGetDSSVCanhBaoHV_Result> getDSSVCanhBaoHV()
        {
            return db.spGetDSSVCanhBaoHV().ToList();
        }

        public List<spGetDiemTB_SoTC_Result> getDiemTB_SoTC(string maSV)
        {
            return db.spGetDiemTB_SoTC(maSV).ToList();
        }

        public List<spGetDiemTBTL_SoTCTL_Result> getDiemTBTL_SoTCTL(string maSV)
        {
            return db.spGetDiemTBTL_SoTCTL(maSV).ToList();
        }

        public List<spGetSVThieuDiemCTXH_Result> getSVThieuDiemCTXH()
        {
            return db.spGetSVThieuDiemCTXH().ToList();
        }

        public List<spGetSVNoHocPhi_Result> getSVNoHocPhi()
        {
            return db.spGetSVNoHocPhi().ToList();
        }

        public List<spGetHBNhatLop_NamHoc_HocKy_Result> getDSSVHBNhatLop(string namHoc, int hocKy)
        {
            return db.spGetHBNhatLop_NamHoc_HocKy(namHoc, hocKy).ToList();
        }

        public List<spGetHBGioi_NamHoc_HocKy_Result> getDSSVHBGioi(string namHoc, int hocKy)
        {
            return db.spGetHBGioi_NamHoc_HocKy(namHoc, hocKy).ToList();
        }

        public List<spGetHBKha_NamHoc_HocKy_Result> getDSSVHBKha(string namHoc, int hocKy)
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
