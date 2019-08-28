using System.Collections.Generic;
using System.Linq;
using DAO;

namespace BUS
{
    public class MonHocBUS
    {
        DBQuanLySinhVienEntities db = new DBQuanLySinhVienEntities();

        public List<spGetMonHoc_Result> getMonHoc()
        {
            return db.spGetMonHoc().ToList();
        }

        public List<spGetMHTheoMaMH_Result> getMHTheoMaMH(string maMH)
        {
            return db.spGetMHTheoMaMH(maMH).ToList();
        }

        public bool xoaMonHoc(string MaMH)
        {
            try
            {
                db.spXoaMonHoc(MaMH);
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool themMonHoc(string MaMH, string TenMH)
        {
            try
            {
                db.spThemMonHoc(MaMH, TenMH);
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool suaMonHoc(string MaMH, string TenMH)
        {
            try
            {
                db.spSuaMonHoc(MaMH, TenMH);
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}
