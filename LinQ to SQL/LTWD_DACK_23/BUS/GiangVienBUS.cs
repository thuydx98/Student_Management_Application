using System.Collections.Generic;
using System.Linq;
using DAO;

namespace BUS
{
    public class GiangVienBUS
    {
        DBQuanLySVDataContext db = new DBQuanLySVDataContext();

        public List<spGetMaGVResult> getMaGV()
        {
            return db.spGetMaGV().ToList();
        }

        public List<spGetGVTheoMaGVResult> getGVTheoMaGV(string maGV)
        {
            return db.spGetGVTheoMaGV(maGV).ToList();
        }

        public List<spGetGVTheoMaKhoaResult> getGVTheoMaKhoa(string maKhoa)
        {
            return db.spGetGVTheoMaKhoa(maKhoa).ToList();
        }

        public bool themGiangVien(string maGV, string hoTen, string hocVi, string diaChi, string sdt, string maKhoa)
        {
            try
            {
                db.spThemGiangVien(maGV, hoTen, maKhoa, hocVi, diaChi, sdt);
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool suaGiangVien(string maGV, string hoTen, string hocVi, string diaChi, string sdt, string maKhoa)
        {
            try
            {
                db.spSuaGiangVien(maGV, hoTen, maKhoa, hocVi, diaChi, sdt);
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool xoaGiangVien(string maGV)
        {
            try
            {
                db.spXoaGiangVien(maGV);
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}
