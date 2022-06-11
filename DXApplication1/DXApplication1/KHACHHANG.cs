using DXApplication1.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication1
{
  public  class KHACHHANG
    {
        DataClasses1DataContext data;
        public KHACHHANG()
        {
            data = new DataClasses1DataContext();
        }
        public List<KhachHang> getAllKhachHang()
        {
            return data.KhachHangs.ToList();
        }
        public KhachHang getKHfromCode(string makh)
        {
            return data.KhachHangs.FirstOrDefault(kh => kh.MAKH.Equals(makh));
        }
        public void Them(KhachHang kh)
        {
            try
            {
                data.KhachHangs.InsertOnSubmit(kh);
                data.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi trong quá trình thêm khách hàng "+ex);
            }
        }
        public void Delete(string mak)
        {
            try
            {
                var khachang = data.KhachHangs.FirstOrDefault(kh => kh.MAKH.Equals(mak));
                data.KhachHangs.DeleteOnSubmit(khachang);
                data.SubmitChanges();

            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi trong quá trình xóa khách hàng " + ex);
            }
        }
        public void Edit(string makh,string tenkh,string cmnd,string dienthoai,string email,string diachi)
        {
            try
            {
                var khachang = data.KhachHangs.FirstOrDefault(kh => kh.MAKH.EndsWith(makh));
                khachang.TenKH = tenkh;
                khachang.CMND = cmnd;
                khachang.DienThoai = dienthoai;
                khachang.Email = email;
                khachang.DiaChi = diachi;
                data.SubmitChanges();

            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi trong quá trình sữa khách hàng " + ex);
            }
        }
    }
}
