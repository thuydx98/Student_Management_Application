using System.Collections.Generic;
using System.Linq;
using DAO;

namespace BUS
{
    public class DSSV_RLBUS
    {
        DBQuanLySinhVienEntities db = new DBQuanLySinhVienEntities();

        public List<spGetSVByMaRL_Result> getSVByMaRL(string maHD)
        {
            return db.spGetSVByMaRL(maHD).ToList();
        }

        public List<spGetSVByMaSV_MaHDRL_Result> getSVByMaSV_MaHDRL(string maHD, string maSV)
        {
            return db.spGetSVByMaSV_MaHDRL(maSV, maHD).ToList();
        }

        public List<System.Nullable<int>> getTongDiemCongRLByMaSV_NamHoc_HocKy(string maSV, string namHoc, int hocKy)
        {
            return db.spGetTongDiemCongRLByMaSV_NamHoc_HocKy(maSV, namHoc, hocKy).ToList();
        }

        public List<System.Nullable<int>> getTongDiemTruRLByMaSV_NamHoc_HocKy(string maSV, string namHoc, int hocKy)
        {
            return db.spGetTongDiemTruRLByMaSV_NamHoc_HocKy(maSV, namHoc, hocKy).ToList();
        }

        public bool themDSSV_HDRL(string maSV, string maHD, bool coMat)
        {
            try
            {
                db.spThemDSSV_HDRL(maSV, maHD, coMat);
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool xoaDSSV_HDRL(string maSV, string maHD)
        {
            try
            {
                db.spXoaDSSV_HDRL(maSV, maHD);
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}
