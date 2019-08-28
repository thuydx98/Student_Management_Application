using System;
using System.Collections.Generic;
using System.Linq;
using DAO;

namespace BUS
{
    public class DSSV_CTXHBUS
    {
        DBQuanLySinhVienEntities db = new DBQuanLySinhVienEntities();

        public List<spGetSVByMaSV_MaHDCTXH_Result> getSVByMaSV_MaHDCTXH(string maHD, string maSV)
        {
            return db.spGetSVByMaSV_MaHDCTXH(maHD, maSV).ToList();
        }

        public List<spGetSVByMaCTXH_Result> getSVByMaCTXH(string maHD)
        {
            return db.spGetSVByMaCTXH(maHD).ToList();
        }

        public List<Nullable<int>> getTongDiemHDCTXHByMaSV(string maSV)
        {
            return db.spGetTongDiemHDCTXHByMaSV(maSV).ToList();
        }

        public bool themDSSV_HDCTXH(string maSV, string maHD)
        {
            try
            {
                db.spThemDSSV_HDCTXH(maHD, maSV);
            }
            catch (System.Exception)
            {
                return false;
            }
            return true;
        }

        public bool xoaDSSV_HDCTXH(string maSV, string maHD)
        {
            try
            {
                db.spXoaDSSV_HDCTXH(maHD, maSV);
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}
