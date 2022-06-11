using DXApplication1.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication1
{
    class CHITIETDATPHONG1
    {
        DataClasses1DataContext data;
        public CHITIETDATPHONG1()
        {
            data = new DataClasses1DataContext();
        }
        public void Them(CHITIETDATPHONG ct)
        {
            try
            {
                data.CHITIETDATPHONGs.InsertOnSubmit(ct);
                data.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw new Exception("Có Lỗi xảy ra trong quá trình xử lý dữ liệu" + ex); ;
            }
        }
        public void deleteAll(int madatphong)
        {
            try
            {
                var list = data.CHITIETDATPHONGs.Where(ctdp => ctdp.MaDatPhong.Equals(madatphong)).ToList();
                data.CHITIETDATPHONGs.DeleteAllOnSubmit(list);
                data.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi "+ex);
            }
        }

        public List<CHITIETDATPHONG> dsChiTietDatPhong(int madatphong)
        {
            return data.CHITIETDATPHONGs.Where(ctdp => ctdp.MaDatPhong.Equals(madatphong)).ToList();
        }
        public CHITIETDATPHONG getDatPhong(string maph)
        {
            return data.CHITIETDATPHONGs.OrderByDescending(ctdp => ctdp.MaDatPhong).FirstOrDefault(ctdp => ctdp.MAPH.Equals(maph));
        }
       //
        public CHITIETDATPHONG getCTDP(string maph,int madp)
        {
            return data.CHITIETDATPHONGs.Where(t => t.MaDatPhong.Equals(madp) && t.MAPH.Equals(maph)).FirstOrDefault();
        }
        public void update(string maphcu,string maphongmoi,int madp,double dongiaPHmoi)
        {
            var _ct = data.CHITIETDATPHONGs.Where(t => t.MaDatPhong.Equals(madp) && t.MAPH.Equals(maphcu)).FirstOrDefault();
            _ct.MAPH = maphongmoi;
            _ct.DonGia = dongiaPHmoi;
            _ct.ThanhTien = _ct.DonGia * _ct.SoNgayO;
            data.SubmitChanges();
        }   
        
        public List<CHITIETDATPHONG> getALL()
        {
            return data.CHITIETDATPHONGs.ToList();
        }

        
    }
}
