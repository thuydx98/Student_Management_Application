using System.Collections.Generic;
using System.Linq;
using DAO;

namespace BUS
{
    public class LopBUS
    {
        DBQuanLySinhVienEntities db = new DBQuanLySinhVienEntities();

        public List<spGetLop_Result> getLop()
        {
            return db.spGetLop().ToList();
        }

        public List<spGetLopTheoChuyenNganh_Result> getLopTheoChuyenNganh(string maCN)
        {
            return db.spGetLopTheoChuyenNganh(maCN).ToList();
        }

        public List<spGetLopTheoMaLop_Result> getLopTheoMaLop(string maLop)
        {
            return db.spGetLopTheoMaLop(maLop).ToList();
        }

         public bool xoaLop(string maLop)
        {
            try
            {
                db.spXoaLop(maLop);
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool themLop(string maLop, string chuyenNganh)
        {
            try
            {
                db.spThemLop(maLop, chuyenNganh);
            }
            catch
            {
                return false;
            }
            
            return true;
        }

        public bool suaLop(string maLop, string chuyenNganh)
        {
            try
            {
                db.spSuaLop(maLop, chuyenNganh);
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}
