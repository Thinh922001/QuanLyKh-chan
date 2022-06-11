using DXApplication1.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication1
{
   public class DATPHONSP 
    {
        DataClasses1DataContext data;
        public DATPHONSP()
        {
            data = new DataClasses1DataContext();
        }
        public void Them(DatPhong_SanPham dpsp)
        {
            try 
            {
                data.DatPhong_SanPhams.InsertOnSubmit(dpsp);
                data.SubmitChanges();
            }
            catch(Exception ex)
            {
                throw new Exception("Có Lỗi "+ex);
            }
           
        }
        public void Xoa(int madp)
        {
            try
            {
                var kq = data.DatPhong_SanPhams.Where(dpsp => dpsp.MaDatPhong.Equals(madp));
                data.DatPhong_SanPhams.DeleteAllOnSubmit(kq);
            }
            catch
            {

            }
        }
        public void DeleteAll(int madatphong)
        {
            var list_dp_sp = data.DatPhong_SanPhams.Where(dpsp => dpsp.MaDatPhong.Equals(madatphong)).ToList();
            try
            {
                data.DatPhong_SanPhams.DeleteAllOnSubmit(list_dp_sp);
                data.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi"+ex);
            }
        }

        public List<DatPhong_SanPham> getlistDP_SP(int madatphong)
        {
            return data.DatPhong_SanPhams.Where(dpsp => dpsp.MaDatPhong.Equals(madatphong)).ToList();
        }

        public void update(DatPhong_SanPham dpsp)
        {
            try
            {
                var _dpsp = data.DatPhong_SanPhams.Where(t => t.MaDatPhong.Equals(dpsp.MaDatPhong) && t.MASP.Equals(dpsp.MASP)).FirstOrDefault();
                _dpsp.MaDatPhong = dpsp.MaDatPhong;
                _dpsp.MASP = dpsp.MASP;
                _dpsp.MAPH = dpsp.MAPH;
                _dpsp.Ngay = dpsp.Ngay;
                _dpsp.SoLuong = dpsp.SoLuong;
                _dpsp.ThanhTien = dpsp.ThanhTien;
                _dpsp.DonGia = dpsp.DonGia;
                data.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi "+ex);
            }

           
        }
       
    }
}
