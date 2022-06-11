using DevExpress.XtraEditors;
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
    public partial class frmThanhToan : DevExpress.XtraEditors.XtraForm
    {
        DATPHONG dp;
        CHITIETDATPHONG1 ct;
        DATPHONSP dpsp;
        KHACHHANG kh;
        List<DatPhong_Dat> ldp;
        List<DatPhongSanPham> list;
        SANPHAM sp;
        PHONG _p;
        int _iddp = 0;
        string makh;
        frmMain objMain = (frmMain)Application.OpenForms["frmMain"];
        public frmThanhToan()
        {
            dp = new DATPHONG();
            ct = new CHITIETDATPHONG1();
            dpsp = new DATPHONSP();
            kh = new KHACHHANG();
            ldp = new List<DatPhong_Dat>();
            list = new List<DatPhongSanPham>();
            sp = new SANPHAM();
            _p = new PHONG();
            InitializeComponent();
        }
        public void loadKH()
        {
            cboKhachHang.DataSource = kh.getAllKhachHang();
            cboKhachHang.DisplayMember = "TenKH";
            cboKhachHang.ValueMember = "MaKH";
        }
        public void loadData()
        {
            string maph = TryVanDuLieu.maph;
            var _ct = ct.getDatPhong(maph);
            if (_ct == null)
            {
                MessageBox.Show("Phòng này chưa có ai sử dụng");
                this.Close();
                return;
            }
            var _dp = dp.getDatPhong(_ct.MaDatPhong);
            makh = _dp.MaKH;
           
            _iddp = _dp.MaDatPhong;
            cboKhachHang.SelectedItem = _dp.MaKH;
            txtGhiChu.Text = _dp.ghichu;
            
            lbTongTien.Text +=" "+ _dp.TongTien.Value.ToString("N0")+" Đ";
          //  SoNgayThue.Text = (_dp.NgayTra.Value.Day - _dp.NgayDat.Value.Day).ToString();
            soNguoi.Text = _dp.SoNguoiO.ToString();
            TimeSpan? t = _dp.NgayTra - _dp.NgayDat;
            SoNgayThue.Text = t.Value.Days.ToString();
            PHONG p = new PHONG();
            var _p = p.getPhong(maph);
            label1.Text += " "+_p.TenPH+" Đơn Giá "+_p.LoaiPhong.DonGia.Value.ToString("N0")+" Đ";
            load_Gird_DatPhongSanPham(_dp.MaDatPhong);
        }
        void load_Gird_DatPhongSanPham(int madp)
        {
            list.Clear();
            DATPHONSP dp = new DATPHONSP();
            var listdpsp = dp.getlistDP_SP(madp);
            DatPhongSanPham sp;
            SANPHAM sanpham;
            PHONG p;
            foreach (var item in listdpsp)
            {
                sanpham = new SANPHAM();
                sp = new DatPhongSanPham();
                p = new PHONG();
                sp.MaDatPhong = item.MaDatPhong.ToString();
                sp.MaPH = item.MAPH;
                sp.MASP = item.MASP;
                var _sanpham = sanpham.getSanPham(sp.MASP);
                var _p = p.getPhong(sp.MaPH);
                sp.soLuong = item.SoLuong;
                sp.thanhTien = item.ThanhTien;
                sp.TenSP = _sanpham.TENSP;
                sp.donGia = _sanpham.DONGIA;
                sp.tenPH = _p.TenPH;
                list.Add(sp);
            }
            load_DatPhong_SanPham();
        }
        void load_DatPhong_SanPham()
        {
            List<DatPhongSanPham> ldp = new List<DatPhongSanPham>();
            foreach (var item in list)
            {
                ldp.Add(item);
            }
            gcSPDV.DataSource = ldp;
        }

        private void frmThanhToan_Load(object sender, EventArgs e)
        {
            loadData();
            loadKH();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            dp.UpdateTinhTrang(_iddp);
           
            _p.UpdateStatusPhong(TryVanDuLieu.maph);
            var _ct = ct.getDatPhong(TryVanDuLieu.maph);
            var datphong = dp.getDatPhong(_ct.MaDatPhong);
            string makh = datphong.MaKH;
            KHACHHANG KH = new KHACHHANG();
            var _kh = kh.getKHfromCode(makh);
            string content = $@"Cám ơn khách hàng {_kh.TenKH} đã đến đặt phòng khách sạn chúng tôi với mã phòng là {_ct.MAPH,1} và tổng thanh toán là {datphong.TongTien,1} cảm ơn quý khách Hẹn gặp quý khách lần sau";
            string to = _kh.Email;
            string from = "lecuongthinh2001@gmail.com";
            string pass = "0967611122T";
            SendMail.sendMail(from, to, content, pass);
            MessageBox.Show("Thanh Toán Thành Công");
            objMain.loadTang();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            if (_iddp == 0)
            {
                MessageBox.Show("Hãy Đặt Phòng Trước Khi In Hóa Đơn");
                return;
            }
            else
            {
                frmShowChiTietHoaDon frm = new frmShowChiTietHoaDon();
                TryVanDuLieu.madatphong = _iddp;
                frm.ShowDialog();
            }
        }
    }
}