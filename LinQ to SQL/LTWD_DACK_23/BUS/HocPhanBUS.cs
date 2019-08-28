using System.Collections.Generic;
using System.Linq;
using DAO;

namespace BUS
{
    public class HocPhanBUS
    {
        DBQuanLySVDataContext db = new DBQuanLySVDataContext();

        public List<spGetMHTrongHPResult> getMHTrongHP()
        {
            return db.spGetMHTrongHP().ToList();
        }

        public List<spGetMHTrongHPTheoGVResult> getMHTrongHPTheoGV(string maGV)
        {
            return db.spGetMHTrongHPTheoGV(maGV).ToList();
        }

        public List<spGetHPTheoMHResult> getHPTheoMH(string maMH)
        {
            return db.spGetHPTheoMH(maMH).ToList();
        }

        public List<spGetHPTheoMaHPResult> getHPTheoMaHP(string maMH)
        {
            return db.spGetHPTheoMaHP(maMH).ToList();
        }

        public List<spGetHPByMaSVResult> getHPByMaSV(string maSV)
        {
            return db.spGetHPByMaSV(maSV).ToList();
        }

        public List<spGetTongNoHPByMaSVResult> getTongNoHPByMaSV(string maSV)
        {
            return db.spGetTongNoHPByMaSV(maSV).ToList();
        }

        public List<spGetNamHocResult> getNamHoc()
        {
            return db.spGetNamHoc().ToList();
        }

        public List<spGetHocKyResult> getHocKy()
        {
            return db.spGetHocKy().ToList();
        }

        public bool xoaHocPhan(string maHP)
        {
            try
            {
                db.spXoaHocPhan(maHP);
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool themHocPhan(string maHP, string maMH, int HocKy, string NamHoc, string maGV, int SoTC, int HocPhi)
        {
            try
            {
                db.spThemHocPhan(maHP, maMH, HocKy, NamHoc, maGV, SoTC, HocPhi);
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool suaHocPhan(string maHP, string maMH, int HocKy, string NamHoc, string maGV, int SoTC, int HocPhi)
        {
            try
            {
                db.spSuaHocPhan(maHP, maMH, HocKy, NamHoc, maGV, SoTC, HocPhi);
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}
