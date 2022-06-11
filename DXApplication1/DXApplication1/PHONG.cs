using DXApplication1.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication1
{
   public class PHONG
    {
        DataClasses1DataContext data;
        public PHONG()
        {
            data = new DataClasses1DataContext();
        }
        public List<Phong> getAllPhong()
        {
           return data.Phongs.ToList();
        }
        public List<Phong> getPhongTrong()
        {
            return data.Phongs.Where(p => p.TrangThai.Equals("Còn")).ToList();
        }
        public void UpdateStatusPhong(string maph)
        {
            try
            {
                var phong = data.Phongs.FirstOrDefault(p => p.MaPH.Equals(maph));
                if (phong.TrangThai == "Còn")
                {
                    phong.TrangThai = "Hết";
                }
                else
                {
                    phong.TrangThai = "Còn";
                }
                data.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw new Exception("Có lỗi trong quá trình xử lý dữ liệu "+ex);
            }
            
        }
        public long? getDonGiaFromPhong(string maph)
        {
            var kq = data.Phongs.Where(p => p.MaPH == maph).FirstOrDefault();
            var kq1 = data.LoaiPhongs.FirstOrDefault(lp => lp.MaLP.Equals(kq.MALP));
            return kq1.DonGia;
                   
        }
        public List<Phong> geAllRoomByCode(string matang)
        {
            return data.Phongs.Where(phong => phong.MaTang.Equals(matang)).ToList();
        }
        public Phong getPhong(string maph)
        {
            return data.Phongs.Where(p => p.MaPH.Equals(maph)).FirstOrDefault();

        } 
        
        public void Them(Phong p)
        {
            try
            {
                data.Phongs.InsertOnSubmit(p);
                data.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi "+ex);
            }
        }
        public void Xoa(string maph)
        {
            try
            {
                var kq = data.Phongs.FirstOrDefault(t => t.MaPH.Equals(maph));
                data.Phongs.DeleteOnSubmit(kq);
                data.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi "+ex);
            }
        }
        public void Edit(Phong p)
        {
            try
            {
                var kq = data.Phongs.FirstOrDefault(t => t.MaPH.Equals(p.MaPH));
                kq.LoaiPhong = p.LoaiPhong;
                kq.TenPH = p.TenPH;
                kq.TrangThai = p.TrangThai;
                kq.TenPH = p.TenPH;
                data.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi "+ex);
            }
         
        }
    }
}
