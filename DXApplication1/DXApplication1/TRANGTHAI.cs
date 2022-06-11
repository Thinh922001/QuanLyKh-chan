using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication1
{
   public class TRANGTHAI 
    {
        bool _values { get; set; }
        string _display { get; set; }
        public TRANGTHAI()
        {

        }
        public TRANGTHAI(bool values,string trangthai)
        {
            _values = values;
            _display = trangthai;
        }
       
    }

    public class Quyen
    {
      public  string values { get; set; }
       public string Display { get; set; }

        public Quyen(string _values,string _display)
        {
            this.values = _values;
            this.Display = _display;
        }
        public Quyen()
        {
    
        }
        public static List<Quyen> listQuyen()
        {
            List<Quyen> list = new List<Quyen>()
            {
                new Quyen("nv","Nhân Viên"),
                new Quyen("admin","Quản Lý")
            };

            return list;
        }
    }
}
