using DevExpress.XtraEditors;
using DXApplication1.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DXApplication1
{
    public partial class frmThongKe : DevExpress.XtraEditors.XtraForm
    {
        DataClasses1DataContext data;
        public frmThongKe()
        {
            data = new DataClasses1DataContext();
            InitializeComponent();
        }
       
            
        
        private void label2_Click(object sender, EventArgs e)
        {
            
                   
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            var day = dateTimePicker1.Value;
            var kq = (from p in data.DatPhongs
                      join t in data.CHITIETDATPHONGs on p.MaDatPhong equals t.MaDatPhong
                      select new
                      {
                          p.MaDatPhong,
                          p.NgayDat,
                          p.TongTien,
                          t.MAPH
                      }).Where(t => t.NgayDat.Value.Day==(day.Day)).ToList();

            gridControl1.DataSource = kq.ToList();
            double? tongtien = kq.Sum(t => t.TongTien);
            lbTongTien.Text = tongtien.ToString();


        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
           
        }
    }
}