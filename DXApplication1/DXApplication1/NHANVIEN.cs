using DXApplication1.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication1
{
  public  class NHANVIEN
    {
        DataClasses1DataContext data;
        public NHANVIEN()
        {
            data = new DataClasses1DataContext();
        }
        public bool checkDN(string manv,string mk)
        {
            List<NhanVien> nv = data.NhanViens.Where(t => t.MaNV.Equals(manv) && t.MatKhau.Equals(mk)).ToList();
            if (nv.Count>0)
            {
                return true;
            }
            return false;
        }
        public bool isAdmin(string manv)
        {
            var kq = data.NhanViens.Where(t => t.MaNV.Equals(manv)).FirstOrDefault();
            if (kq.quyen.Equals("admin"))
            {
                return true;
            }
            return false;
        }
        public List<NhanVien> getAllNhanVien()
        {
            return data.NhanViens.ToList();
        }
        public void Them(NhanVien nv)
        {
            try
            {
                data.NhanViens.InsertOnSubmit(nv);
                data.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi "+ex);
            }
        }
        public void Delete(string manv)
        {
            try
            {
                var kq = data.NhanViens.FirstOrDefault(t => t.MaNV.Equals(manv));
                data.NhanViens.DeleteOnSubmit(kq);
                data.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi "+ex);
            }
        }
        public void Edit(NhanVien nv)
        {
            try
            {
                var kq = data.NhanViens.FirstOrDefault(t => t.MaNV.Equals(nv.MaNV));
                kq.HoTen = nv.HoTen;
                kq.MatKhau = nv.MatKhau;
                data.SubmitChanges();
            }
            catch (Exception ex) 
            {

                throw new Exception("Lỗi "+ex);
            }
          
        }
        public bool doiMK(string manv,string mkHienTai,string mkM,string xacNhanMKMoi)
        {
            var kq = data.NhanViens.FirstOrDefault(t => t.MaNV.Equals(manv)&&t.MatKhau.Equals(mkHienTai));
            if (!mkM.Equals(xacNhanMKMoi)||kq==null)
            {
                return false;
            }
            else
            {
                kq.MatKhau = xacNhanMKMoi;
                try
                {
                    data.SubmitChanges();
                }
                catch (Exception ex)
                {

                    throw new Exception("Lỗi "+ex);
                }
                
            }
            return true;
        }
    }
}
