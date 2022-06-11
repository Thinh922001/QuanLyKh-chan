using DXApplication1.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication1
{
    public class LoadData
    {
        DataClasses1DataContext data;
        public LoadData()
        {
            data = new DataClasses1DataContext();
        }
        public List<Tang> getAllFloor()
        {
            return data.Tangs.ToList();
        }
        public List<Phong> geAllRoomByCode(string matang)
        {
            return data.Phongs.Where(phong => phong.MaTang.Equals(matang)).ToList();
        }
    }
}
