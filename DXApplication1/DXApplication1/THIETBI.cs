using DXApplication1.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication1
{
   public class THIETBI
    {
        DataClasses1DataContext data;
        public THIETBI()
        {
            data = new DataClasses1DataContext();
        }
        public List<ThietBi> getAllThietBi()
        {
            return data.ThietBis.ToList();
        }
        public void Them(ThietBi tb)
        {
            try
            {
                data.ThietBis.InsertOnSubmit(tb);
                data.SubmitChanges();

            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi trong quá trình xóa khách hàng " + ex);
            }
        }
        public void Xoa(string matb)
        {
            try
            {
                var thietbi = data.ThietBis.FirstOrDefault(tb => tb.MATB.Equals(matb));
                data.ThietBis.DeleteOnSubmit(thietbi);
                data.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi trong quá trình xóa Thiết bị "+ex);
            }
        }
        public void Sua(string matb,string tentb,double dongia)
        {
            try
            {
                var thietbi = data.ThietBis.FirstOrDefault(tb => tb.MATB.Equals(matb));
                thietbi.TenTB = tentb;
                thietbi.DonGia = dongia;
                data.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi trong quá trình sữa thiết bị "+ex);
            }
        }

    }
}
