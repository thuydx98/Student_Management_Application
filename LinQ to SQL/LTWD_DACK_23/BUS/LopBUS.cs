using System.Collections.Generic;
using System.Linq;
using DAO;

namespace BUS
{
    public class LopBUS
    {
        DBQuanLySVDataContext db = new DBQuanLySVDataContext();

        public List<spGetLopResult> getLop()
        {
            return db.spGetLop().ToList();
        }

        public List<spGetLopTheoChuyenNganhResult> getLopTheoChuyenNganh(string maCN)
        {
            return db.spGetLopTheoChuyenNganh(maCN).ToList();
        }

        public List<spGetLopTheoMaLopResult> getLopTheoMaLop(string maLop)
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
