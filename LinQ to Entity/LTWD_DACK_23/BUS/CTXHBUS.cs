using System;
using System.Collections.Generic;
using System.Linq;
using DAO;

namespace BUS
{
    public class CTXHBUS
    {
        DBQuanLySinhVienEntities db = new DBQuanLySinhVienEntities();
        SinhVienBUS svBUS = new SinhVienBUS();
        DSSV_CTXHBUS dsCTXHBUS = new DSSV_CTXHBUS();

        public List<string> getMaHDCTXH()
        {
            return db.spGetMaHDCTXH().ToList();
        }

        public List<spGetHDCTXHByMaSV_Result> getHDCTXHByMaSV(string maSV)
        {
            return db.spGetHDCTXHByMaSV(maSV).ToList();
        }

        public List<spgetHDByMaHD_Result> getHDByMaHD(string maHD)
        {
            return db.spgetHDByMaHD(maHD).ToList();
        }

        public bool themCTXH(string maCTXH, string TenCTXH, string DiaDiem, DateTime ngayTC, int soDiem)
        {
            try
            {
                db.spThemCTXH(maCTXH, TenCTXH, DiaDiem, ngayTC, soDiem);
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool suaCTXH(string maCTXH, string TenCTXH, string DiaDiem, DateTime ngayTC, int soDiem)
        {
            try
            {
                db.spSuaCTXH(maCTXH, TenCTXH, DiaDiem, ngayTC, soDiem);
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool xoaCTXH(string maCTXH)
        {
            try 
            {
                var listSV = dsCTXHBUS.getSVByMaCTXH(maCTXH);
                for (int i = 0; i < listSV.Count; i++)
                    dsCTXHBUS.xoaDSSV_HDCTXH(listSV[i].MaSV, maCTXH);
                db.spXoaCTXH(maCTXH);
            }
            catch
            {
                return false; 
            }
            return true;
        }
    }
}
