using DXApplication1.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication1
{
    public class LOAIPHONG
    {
        DataClasses1DataContext data;
        public LOAIPHONG()
        {
            data = new DataClasses1DataContext();
        }
        public List<LoaiPhong> getAll_LoaiPhong()
        {
            return data.LoaiPhongs.ToList();
        }
        public void Them(LoaiPhong lp)
        {
            try
            {
                
                data.LoaiPhongs.InsertOnSubmit(lp);
                data.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw new Exception("Có Lỗi Xảy ra " + ex);

            }
        }

        public void Delete(string malp)
        {
            try
            {
                LoaiPhong p = data.LoaiPhongs.Where(lp => lp.MaLP.Equals(malp)).FirstOrDefault();

                data.LoaiPhongs.DeleteOnSubmit(p);
                data.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw new Exception("Có Lỗi xảy ra trong quá trình xóa dữ liệu "+ ex);
            }
            

        }
        public void Edit(string malp,string tenlp,int songuoi,int sogiuong,int dongia)
        {
            try
            {
                LoaiPhong p = data.LoaiPhongs.FirstOrDefault(lp => lp.MaLP.Equals(malp));
                p.MaLP = malp;
                p.TenPhong = tenlp;
                p.SoNguoi = songuoi;
                p.SoGiuong = sogiuong;
                p.DonGia = dongia;
                data.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi trong quá trình sữa thông tin "+ex);
            }
          

        }
    }
}
