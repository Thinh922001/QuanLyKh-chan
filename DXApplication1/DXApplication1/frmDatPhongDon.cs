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
    public partial class frmDatPhongDon : DevExpress.XtraEditors.XtraForm
    {
        DATPHONG dp;
        PHONG p;
        CHITIETDATPHONG1 ct;
        DATPHONSP sp;
        KHACHHANG kh;
        List<DatPhongSanPham> list;
        string dpsp;
        frmMain objMain = (frmMain)Application.OpenForms["frmMain"];
        int madp = 0;
        public frmDatPhongDon()
        {
            dp = new DATPHONG();
            p = new PHONG();
            ct = new CHITIETDATPHONG1();
            sp = new DATPHONSP();
            kh = new KHACHHANG();
            list = new List<DatPhongSanPham>();
            //loadCBX();
            InitializeComponent();
        }
        void loadCBX()
        {
            cboKhachHang.DataSource = kh.getAllKhachHang();
            cboKhachHang.DisplayMember = "TenKH";
            cboKhachHang.ValueMember = "MaKH";
        }
        public void loadKH()
        {
            kh = new KHACHHANG();
            cboKhachHang.DataSource = kh.getAllKhachHang();
            cboKhachHang.DisplayMember = "TenKH";
            cboKhachHang.ValueMember = "MAKH";
        }
        public void setKhachHang(string makh)
        {
            var _kh = kh.getKHfromCode(makh);
            cboKhachHang.SelectedValue = _kh.MAKH;
            cboKhachHang.Text = _kh.TenKH;

        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            // Thêm Đặt Phòng
            double? sum = 0;
            PHONG p = new PHONG();
            var phong = p.getPhong(TryVanDuLieu.maph);
            string makh = cboKhachHang.SelectedValue.ToString();
            int songaythue= (int)SoNgayThue.Value;
             DateTime ngaydat = DateTime.Now;
            DateTime ngaytra = DateTime.Now.AddDays(songaythue);
            int soNguoiO = (int)soNguoi.Value;
            string maph = TryVanDuLieu.maph;
            bool tinhTrang = false;
            DatPhong _dp = new DatPhong();
            string ghichu = txtGhiChu.Text;
            long? donggia = p.getDonGiaFromPhong(maph);
            _dp.NgayDat = ngaydat;
            _dp.NgayTra = ngaytra;
            _dp.SoNguoiO = int.Parse(soNguoi.Text);
           // _dp.MAPH = maph;
            _dp.MaNV = TryVanDuLieu._manvDangNhap;
           _dp.ghichu = ghichu;
            _dp.MaKH = makh;
            _dp.TongTien = donggia * songaythue;
            sum += _dp.TongTien;
            _dp.Theodoan = false;
            _dp.TinhTrang = tinhTrang;
             var __dp= dp.Them(_dp);
            //_dp.MaDatPhong = madp;
            madp = _dp.MaDatPhong;
            CHITIETDATPHONG _ct = new CHITIETDATPHONG();
            _ct.MaDatPhong = __dp.MaDatPhong;
            _ct.Ngay = DateTime.Now;
            _ct.MAPH = phong.MaPH;
            _ct.DonGia = phong.LoaiPhong.DonGia;
            _ct.SoNgayO = (int)SoNgayThue.Value;
            _ct.ThanhTien = _ct.DonGia * songaythue;
            ct.Them(_ct);
            if (gridView5.RowCount>0)
            {
                for (int i = 0; i < gridView5.RowCount; i++)
                {
                    DatPhong_SanPham _dpsp = new DatPhong_SanPham();
                    _dpsp.MASP = gridView5.GetRowCellValue(i, "MASP").ToString();
                    _dpsp.SoLuong = int.Parse(gridView5.GetRowCellValue(i, "soLuong").ToString());
                    _dpsp.MaDatPhong = __dp.MaDatPhong;
                    _dpsp.MAPH = phong.MaPH;
                    _dpsp.Ngay = DateTime.Now;
                    _dpsp.DonGia = double.Parse(gridView5.GetRowCellValue(i, "donGia").ToString());
                    _dpsp.ThanhTien = _dpsp.SoLuong * _dpsp.DonGia;
                    sum += _dpsp.ThanhTien;
                    sp.Them(_dpsp);
                }
            }
            p.UpdateStatusPhong(TryVanDuLieu.maph);
            dp.updateTongTien(__dp.MaDatPhong, sum);
            objMain.loadTang();
            MessageBox.Show("Đặt Phòng Thành Công");

        }
        void loadSPDV()
        {
            SANPHAM sp = new SANPHAM();
            dsSanPham.DataSource = sp.getAllSanPham();
        }

        private void frmDatPhongDon_Load(object sender, EventArgs e)
        {
            var phong = p.getPhong(TryVanDuLieu.maph);
            label1.Text +=": Tên Phòng "+ phong.TenPH + " Đơn Giá " + phong.LoaiPhong.DonGia.Value.ToString("N0");
            loadCBX();
            loadSPDV();
            soNguoi.Text = "1";
            SoNgayThue.Text = "1";
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
        private void gridView3_Click(object sender, EventArgs e)
        {
            PHONG p = new PHONG();
            var phong = p.getPhong(TryVanDuLieu.maph);
                DatPhongSanPham dsp = new DatPhongSanPham();
                dsp.MASP = gridView3.GetFocusedRowCellValue("MASP").ToString();
                dsp.TenSP = gridView3.GetFocusedRowCellValue("TENSP").ToString();
                dsp.soLuong = 1;
                dsp.MaPH = TryVanDuLieu.maph;
                dsp.tenPH = phong.TenPH;
                dsp.donGia = double.Parse(gridView3.GetFocusedRowCellValue("DONGIA").ToString());
                dsp.thanhTien = dsp.soLuong * dsp.donGia;
            foreach (var item in list)
            {
                if (item.MaPH == TryVanDuLieu.maph && item.MASP == dsp.MASP)
                {
                    item.soLuong += 1;
                    item.thanhTien = item.soLuong * item.donGia;
                    load_DatPhong_SanPham();
                    return;
                }
            }
                list.Add(dsp);
            

            load_DatPhong_SanPham();
            txtTongTien.ForeColor = Color.Green;
            // txtTongTien.Size = new Size(20, 20);
            updateTongTien();
        }
        void updateTongTien()
        {
            PHONG p = new PHONG();
            double? thanhtien = 0;
            var phong = p.getPhong(TryVanDuLieu.maph);
            double? dongia = phong.LoaiPhong.DonGia;
            if (gridView5.RowCount>0)
            {
                thanhtien = (double)gridView5.Columns["thanhTien"].SummaryItem.SummaryValue;
            }
            else
            {
                thanhtien = 0;
            }    
           
            double? thanhTienPhong = dongia * (int)SoNgayThue.Value;

            txtTongTien.Text = (thanhtien + thanhTienPhong).Value.ToString("N0");
        }
        private void gridView3_DoubleClick(object sender, EventArgs e)
        {

        }

        private void SoNgayThue_EditValueChanged(object sender, EventArgs e)
        {
            updateTongTien();
        }

        private void SoNgayThue_Click(object sender, EventArgs e)
        {
            updateTongTien();
        }

        private void gridView5_DoubleClick(object sender, EventArgs e)
        {
            if (gridView5.RowCount > 0)
            {
                string masp = gridView5.GetFocusedRowCellValue("MASP").ToString();
                var dpsp = list.Where(dp => dp.MASP.Equals(masp)).FirstOrDefault();
                list.Remove(dpsp);
                load_DatPhong_SanPham();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmKH kh = new frmKH();
            kh.ShowDialog();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            if (madp==0)
            {
                MessageBox.Show("Hãy Đặt Phòng Trước Khi In Hóa Đơn");
                return;
            }
            else
            {
                frmShowChiTietHoaDon frm = new frmShowChiTietHoaDon();
                TryVanDuLieu.madatphong = madp;
                frm.ShowDialog();
            }    
           
        }
    }
}