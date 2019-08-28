using System;
using System.Collections.Generic;
using System.Linq;
using DAO;

namespace BUS
{
    public class RenLuyenBUS
    {
        DBQuanLySinhVienEntities db = new DBQuanLySinhVienEntities();

        DSSV_RLBUS dsRLBUS = new DSSV_RLBUS();

        public List<string> getMaHDRL()
        {
            return db.spGetMaHDRL().ToList();
        }

        public List<spGetHDRLByMaSV_NamHoc_HocKy_Result> getHDRLByMaSV_NamHoc_HocKy(string maSV, string namHoc, int hocKy)
        {
            return db.spGetHDRLByMaSV_NamHoc_HocKy(maSV, namHoc, hocKy).ToList();
        }

        public List<spGetHDRLByMaHD_Result> getHDRLByMaHD(string maHD)
        {
            return db.spGetHDRLByMaHD(maHD).ToList();
        }

        public bool themRL(string maCTXH, string TenCTXH, string DiaDiem, DateTime ngayTC, string namHoc, int hocKy, int soDiem)
        {
            try
            {
                db.spThemRL(maCTXH, TenCTXH, DiaDiem, ngayTC, namHoc, hocKy, soDiem);
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool suaRL(string maCTXH, string TenCTXH, string DiaDiem, DateTime ngayTC, string namHoc, int hocKy, int soDiem)
        {
            try
            {
                db.spSuaRL(maCTXH, TenCTXH, DiaDiem, ngayTC, namHoc, hocKy, soDiem);
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool xoaRL(string maRL)
        {
            try
            {
                var listSV = dsRLBUS.getSVByMaRL(maRL);
                for (int i = 0; i < listSV.Count; i++)
                    dsRLBUS.xoaDSSV_HDRL(listSV[i].MaSV, maRL);
                db.spXoaRL(maRL);
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}
