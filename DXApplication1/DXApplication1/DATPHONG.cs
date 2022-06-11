using DXApplication1.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication1
{
  public  class DATPHONG
    {
        DataClasses1DataContext data;
        public DATPHONG()
        {
            data = new DataClasses1DataContext();
        }
        public DatPhong Them(DatPhong dp)
        {
            try
            {
                data.DatPhongs.InsertOnSubmit(dp);
                data.SubmitChanges();
                return dp;
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi trong quá trình xử lý dữ liệu "+ex);
            }
        }
        public void Delete(string madp)
        {
            try
            {
                var datphong = data.DatPhongs.FirstOrDefault(dp => dp.MaDatPhong.Equals(madp));
                data.DatPhongs.DeleteOnSubmit(datphong);
                data.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi trong quá trình xử lý dữ liệu " + ex);
            }
        }

        public DatPhong Edit(DatPhong p)
        {
            try
            {
                var _p = data.DatPhongs.Where(ph => ph.MaDatPhong.Equals(p.MaDatPhong)).FirstOrDefault();
                _p.MaKH = p.MaKH;
                
                _p.MaNV = p.MaNV;
                _p.NgayDat = p.NgayDat;
                _p.NgayTra = p.NgayTra;
                _p.SoNguoiO = p.SoNguoiO;
                _p.TongTien = p.TongTien;
                _p.TinhTrang = p.TinhTrang;
                _p.Theodoan = p.Theodoan;
                _p.ghichu = p.ghichu;
                data.SubmitChanges();
                return _p;
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi " + ex);
            }


        } 
        public List<DatPhong> getAllDatPhong()
        {
            return data.DatPhongs.ToList();
        }

        public List<Object_DatPhong> getAllDatPhong(DateTime tuNgay,DateTime denNgay)
        {
            var list_dp= data.DatPhongs.Where(dp1 => dp1.NgayDat >= tuNgay && dp1.NgayDat < denNgay).ToList();
            List<Object_DatPhong> list = new List<Object_DatPhong>();
            Object_DatPhong dp;
            foreach (var item in list_dp)
            {
                dp = new Object_DatPhong();
                dp.MaDatPhong = item.MaDatPhong;
                dp.MaKH = item.MaKH;
                var kq = data.KhachHangs.Where(kh => kh.MAKH.Equals(item.MaKH)).FirstOrDefault();
                dp.Hoten = kq.TenKH;
                dp.manv = item.MaNV;
                dp.soNguoiO = item.SoNguoiO;
                dp.theoDoan = item.Theodoan;
                dp.NgayDat = item.NgayDat;
                dp.NgayTra = item.NgayTra;
                dp.soTien = item.TongTien;
                dp.ghiChu = item.ghichu;
                dp.TinhTrang = item.TinhTrang;
                list.Add(dp);
            }
            return list;
        }

        public DatPhong getDatPhong(int madp)
        {
            return data.DatPhongs.Where(dp => dp.MaDatPhong.Equals(madp)).FirstOrDefault();
        }

        public void UpdateTinhTrang(int madp)
        {
            var datphong = data.DatPhongs.Where(t => t.MaDatPhong.Equals(madp)).FirstOrDefault();
            datphong.TinhTrang = true;
            try
            {
                data.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw new Exception("Có lỗi "+ex);
            }
          
        }
        public void updateTongTien(int madp,double? tongtien)
        {
            var kq = data.DatPhongs.FirstOrDefault(t => t.MaDatPhong.Equals(madp));
            kq.TongTien = tongtien;
            try
            {
                data.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi "+ex);
            }
           
        }    
    }
}
