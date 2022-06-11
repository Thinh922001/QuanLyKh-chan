using DXApplication1.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication1
{
  public class SANPHAM
    {
        DataClasses1DataContext data;
        public SANPHAM()
        {
            data = new DataClasses1DataContext();
        }
        public List<SanPham> getAllSanPham()
        {
            return data.SanPhams.ToList();
        }

        public void Them(SanPham sp)
        {
            try
            {
                data.SanPhams.InsertOnSubmit(sp);
                data.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw new Exception("Thêm Thất bại "+ex);
            }
        }
        public void Xoa(string masp)
        {
            try
            {
                var sanpham = data.SanPhams.FirstOrDefault(sp => sp.MASP.Equals(masp));
                data.SanPhams.DeleteOnSubmit(sanpham);
                data.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi trong quá trình xóa sản phẩm "+ex);
            }
        }
        public void Edit(string masp,string tensp,double dongia)
        {
            try
            {
                var sanpham = data.SanPhams.FirstOrDefault(sp => sp.MASP.Equals(masp));
                sanpham.TENSP = tensp;
                sanpham.DONGIA = dongia;
                data.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi trong quá trình sửa sản phẩm " + ex);
            }
        }
        public SanPham getSanPham(string masp)
        {
            return data.SanPhams.Where(sp => sp.MASP.Equals(masp)).FirstOrDefault();
        }
    }
}
