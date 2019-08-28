using System.Collections.Generic;
using System.Linq;
using DAO;

namespace BUS
{
    public class HocPhanBUS
    {
        DBQuanLySinhVienEntities db = new DBQuanLySinhVienEntities();

        public List<spGetMHTrongHP_Result> getMHTrongHP()
        {
            return db.spGetMHTrongHP().ToList();
        }

        public List<spGetMHTrongHPTheoGV_Result> getMHTrongHPTheoGV(string maGV)
        {
            return db.spGetMHTrongHPTheoGV(maGV).ToList();
        }

        public List<spGetHPTheoMH_Result> getHPTheoMH(string maMH)
        {
            return db.spGetHPTheoMH(maMH).ToList();
        }

        public List<spGetHPTheoMaHP_Result> getHPTheoMaHP(string maMH)
        {
            return db.spGetHPTheoMaHP(maMH).ToList();
        }

        public List<spGetHPByMaSV_Result> getHPByMaSV(string maSV)
        {
            return db.spGetHPByMaSV(maSV).ToList();
        }

        public List<System.Nullable<int>> getTongNoHPByMaSV(string maSV)
        {
            return db.spGetTongNoHPByMaSV(maSV).ToList();
        }

        public List<string> getNamHoc()
        {
            return db.spGetNamHoc().ToList();
        }

        public List<System.Nullable<int>> getHocKy()
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
