using System.Collections.Generic;
using System.Linq;
using DAO;

namespace BUS
{
    public class DIemThiBUS
    {
        DBQuanLySVDataContext db = new DBQuanLySVDataContext();

        public List<spGetDiemTheoMSSVResult> getDiemTheoMSSV(string maSV)
        {
            return db.spGetDiemTheoMSSV(maSV).ToList();
        }

        public List<spGetDiemTheoMSSV_MaHPResult> getDiemTheoMSSV_MaHP(string maSV, string maHP)
        {
            return db.spGetDiemTheoMSSV_MaHP(maSV, maHP).ToList();
        }

        public bool suaDiemThi(string maSV, string maHP, decimal diemGK, decimal diemCK)
        {
            db.spSuaDiemThi(maSV, maHP, diemGK, diemCK);
            return true;
        }

        public bool suaTinhTrangHP(string maSV, string maHP, bool daDongHP)
        {
            try
            {
                db.spSuaTinhTrangHP(maSV, maHP, daDongHP);
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool themDiemThi(string maSV, string maHP)
        {
            try
            {
                db.spThemDiemThi(maHP, maSV);
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool xoaDiemThi(string maSV, string maHP)
        {
            try
            {
                db.spXoaDiemThi(maSV, maHP);
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}
