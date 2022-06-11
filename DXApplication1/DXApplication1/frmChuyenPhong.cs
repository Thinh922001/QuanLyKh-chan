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
    public partial class frmChuyenPhong : DevExpress.XtraEditors.XtraForm
    {
        PHONG p;
        DATPHONSP dpsp;
        CHITIETDATPHONG1 ct;
        frmMain objMain = (frmMain)Application.OpenForms["frmMain"];
        DATPHONG dp;
        public frmChuyenPhong()
        {
            p = new PHONG();
            dpsp = new DATPHONSP();
            ct = new CHITIETDATPHONG1();
            dp = new DATPHONG();
            InitializeComponent();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void loaData()
        {
            var _dp = ct.getDatPhong(TryVanDuLieu.maph);
            var _datphong = dp.getDatPhong(_dp.MaDatPhong);
            KHACHHANG kh = new KHACHHANG();
            var kq1 = kh.getKHfromCode(_datphong.MaKH);
            var kq = p.getPhong(TryVanDuLieu.maph);
            nameP.Text +=" "+kq.TenPH;
            nameKH.Text +=" "+kq1.TenKH;
            var kq2 = p.getPhongTrong();
            cboP.DataSource = kq2;
            cboP.DisplayMember = "TenPH";
            cboP.ValueMember = "MaPH";

        }    
        private void frmChuyenPhong_Load(object sender, EventArgs e)
        {
            loaData();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            double? tt = 0;
            string maph = cboP.SelectedItem.ToString();
            if (string.IsNullOrEmpty(maph))
            {
                MessageBox.Show("Hãy Chọn phòng cần chuyển");
                return;
            }

          //Phòng cũ
          var p1 = p.getPhong(TryVanDuLieu.maph);
          //Phòng mới
           var p2 = p.getPhong(cboP.SelectedValue.ToString());
            
            // chi tiết phòng cũ
            var _dp = ct.getDatPhong(TryVanDuLieu.maph);
            // list dpsp phòng cũ
            var list_dpsp = dpsp.getlistDP_SP(_dp.MaDatPhong);
            // đặt phòng cũ
            var _datphong = dp.getDatPhong(_dp.MaDatPhong);
            // thêm đặt phòng 
            DatPhong datphong = new DatPhong();
            datphong.MaKH = _datphong.MaKH;
            datphong.ghichu = _datphong.ghichu;
            datphong.MaNV = _datphong.MaNV;
            datphong.NgayDat = _datphong.NgayDat;
            datphong.NgayTra = _datphong.NgayTra;
            datphong.TinhTrang = _datphong.Theodoan;
            datphong.Theodoan = _datphong.Theodoan;
            datphong.SoNguoiO = _datphong.SoNguoiO;
            datphong.TongTien = _datphong.TongTien;
             var ___dp= dp.Them(datphong);

            CHITIETDATPHONG chitiet = new CHITIETDATPHONG();
            chitiet.MAPH = p2.MaPH;
            chitiet.MaDatPhong = ___dp.MaDatPhong;
            chitiet.SoNgayO = _dp.SoNgayO;
            chitiet.DonGia = p2.LoaiPhong.DonGia;
            chitiet.ThanhTien = chitiet.SoNgayO * chitiet.DonGia;
            tt += chitiet.ThanhTien;
            chitiet.Ngay = _dp.Ngay;
            ct.Them(chitiet);
            foreach (var item in list_dpsp)
            {
                DatPhong_SanPham dpsp_ = new DatPhong_SanPham();
                dpsp_.MAPH = p2.MaPH;
                dpsp_.MaDatPhong = ___dp.MaDatPhong;
                dpsp_.Ngay = item.Ngay;
                dpsp_.MASP = item.MASP;
                dpsp_.SoLuong = item.SoLuong;
                dpsp_.DonGia = item.DonGia;
                dpsp_.ThanhTien = item.ThanhTien;
                tt += dpsp_.ThanhTien;
                dpsp.Them(dpsp_);
            }
            var datphong_ = dp.getDatPhong(___dp.MaDatPhong);
            datphong.TongTien = tt;
            dp.Edit(datphong_);
            p.UpdateStatusPhong(p1.MaPH);
            p.UpdateStatusPhong(p2.MaPH);
            ct.deleteAll(_dp.MaDatPhong);
            dpsp.DeleteAll(_dp.MaDatPhong);
            dp.Delete(_dp.MaDatPhong.ToString());

            objMain.loadTang();
            MessageBox.Show("Chuyển Phòng Thành Công");
            this.Close();
        }
    }
}