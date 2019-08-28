using DAO;
using System.Collections.Generic;
using System.Linq;

namespace BUS
{
    public class TaiKhoanBUS
    {
        DBQuanLySinhVienEntities db = new DBQuanLySinhVienEntities();

        public List<spGetTaiKhoan_Result> getTaiKhoan()
        {
            return db.spGetTaiKhoan().ToList();
        }

        public List<spGetUserByIDPass_Result> getTKDangNhap(string user, string pass)
        {
            return db.spGetUserByIDPass(user, pass).ToList();
        }

        public List<spGetTKTheoTK_Result> getTKTheoTK(string user)
        {
            return db.spGetTKTheoTK(user).ToList();
        }

        public List<spGetTKTheoLoaiUser_Result> getTKTheoLoaiUser(string loaiUser)
        {
            return db.spGetTKTheoLoaiUser(loaiUser).ToList();
        }

        public List<spGetTKTheoMa_Result> getTKTheoMaGV(string ma)
        {
            return db.spGetTKTheoMa(ma).ToList();
        }

        public bool xoaTaiKhoan(string user)
        {
            try
            {
                db.spXoaTaiKhoan(user);
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool themTaiKhoan(string tk, string mk, string loai, string magv)
        {
            try
            {
                db.spThemTaiKhoan(tk, mk, loai, magv);
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool suaTaiKhoan(string tk, string mk, string loai, string magv)
        {
            try
            {
            db.spSuaTaiKhoan(tk, mk, loai, magv);
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}
