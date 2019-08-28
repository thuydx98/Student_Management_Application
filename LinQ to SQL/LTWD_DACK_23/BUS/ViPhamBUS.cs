using System;
using System.Collections.Generic;
using System.Linq;
using DAO;

namespace BUS
{
    public class ViPhamBUS
    {
        DBQuanLySVDataContext db = new DBQuanLySVDataContext();

        public List<spGetViPhamResult> getViPham()
        {
            return db.spGetViPham().ToList();
        }

        public List<spGetVPByMaSVResult> getVPByMaSV(string maSV)
        {
            return db.spGetVPByMaSV(maSV).ToList();
        }

        public bool themViPham(string maSV, string noiDung, string htkl, DateTime ngayVP)
        {
            try
            {
                db.spThemViPham(maSV, noiDung, htkl, ngayVP);
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool xoaViPham(string maSV, string noiDung, string htkl, DateTime ngayVP)
        {
            try
            {
                db.spXoaViPham(maSV, noiDung, htkl, ngayVP);
            }
            catch
            {
                return false;
            }
            return true;
        }

        public List<spGetVPByAllKeyResult> getVPByAllKey(string maSV, string noiDung, string hinhthucKL, DateTime ngayVP)
        {
            return db.spGetVPByAllKey(maSV, noiDung, hinhthucKL, ngayVP).ToList();
        }
    }
}
