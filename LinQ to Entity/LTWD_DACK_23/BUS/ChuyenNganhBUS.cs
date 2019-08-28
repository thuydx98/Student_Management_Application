using System.Collections.Generic;
using System.Linq;
using DAO;

namespace BUS
{
    public class ChuyenNganhBUS
    {
        DBQuanLySinhVienEntities db = new DBQuanLySinhVienEntities();

        public List<spGetChuyenNganh_Result> getChuyenNganh()
        {
            return db.spGetChuyenNganh().ToList();
        }

        public List<spGetCNTheoKhoa_Result> getCNTheoKhoa(string maKhoa)
        {
            return db.spGetCNTheoKhoa(maKhoa).ToList();
        }

        public List<spGetCNTheoMaCN_Result> getCNTheoMaCN(string maCN)
        {
            return db.spGetCNTheoMaCN(maCN).ToList();
        }

        public bool xoaChuyenNganh(string maChuyenNganh)
        {
            try
            {
                db.spXoaChuyenNganh(maChuyenNganh);
            }
            catch
            {
                return false;
            }           
            return true;
        }

        public bool themChuyenNganh(string maCN, string tenChuyenNganh, string maKhoa)
        {
            try
            {
                db.spThemChuyenNganh(maCN, tenChuyenNganh, maKhoa);
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool suaChuyenNganh(string maCN, string tenChuyenNganh, string maKhoa)
        {
            try
            {
                db.spSuaChuyenNganh(maCN, tenChuyenNganh, maKhoa);
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}
