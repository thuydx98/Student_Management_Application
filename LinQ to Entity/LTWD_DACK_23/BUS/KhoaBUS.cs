using System.Collections.Generic;
using System.Linq;
using DAO;

namespace BUS
{
    public class KhoaBUS
    {
        DBQuanLySinhVienEntities db = new DBQuanLySinhVienEntities();

        public List<spGetKhoa_Result> getKhoa()
        {
            return db.spGetKhoa().ToList();
        }

        public List<spGetKTheoMaKhoa_Result> getKTheoMaKhoa(string maKhoa)
        {
            return db.spGetKTheoMaKhoa(maKhoa).ToList();
        }

        public bool xoaKhoa(string maKhoa)
        {
            try
            {
                db.spXoaKhoa(maKhoa);
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool themKhoa(string maKhoa, string tenKhoa, string truongKhoa, string sdt)
        {
            try
            {
                db.spThemKhoa(maKhoa, tenKhoa, truongKhoa, sdt);
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool suaKhoa(string maKhoa, string tenKhoa, string truongKhoa, string sdt)
        {
            try
            {
                db.spSuaKhoa(maKhoa, tenKhoa, truongKhoa, sdt);
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}
