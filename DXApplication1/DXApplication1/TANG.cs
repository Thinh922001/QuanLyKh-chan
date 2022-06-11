using DXApplication1.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication1
{
   public class TANG
    {
        DataClasses1DataContext data;
        public TANG()
        {
            data = new DataClasses1DataContext();
        }
        public List<Tang> LoadAllTang()
        {
            return data.Tangs.ToList();
        }

        public void Them(Tang t)
        {
            try
            {
                data.Tangs.InsertOnSubmit(t);
                data.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw new Exception("Có lỗi trong quá trình thêm tầng "+ex);
            }
        }
        public void Delete(int matang)
        {
            try
            {
                Tang t = data.Tangs.FirstOrDefault(ta => ta.MATANG.Equals(matang));
                data.Tangs.DeleteOnSubmit(t);
                data.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw new Exception("Có lỗi trong quá trình xóa tầng "+ex);
            }
        }
        public void Edit(int matang,string tentang)
        {
            try
            {
                var tang = data.Tangs.FirstOrDefault(t => t.MATANG.Equals(matang));
                tang.TenTang = tentang;
                data.SubmitChanges();

            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi trong quá trình xóa tầng "+ex);
            }
        }
    }
}
