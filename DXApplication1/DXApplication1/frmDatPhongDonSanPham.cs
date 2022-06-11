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
    public partial class frmDatPhongDonSanPham : DevExpress.XtraEditors.XtraForm
    {
        DATPHONG dp;
        CHITIETDATPHONG1 ct;
        DATPHONSP dpsp;
        KHACHHANG kh;
        List<DatPhong_Dat> ldp;
        List<DatPhongSanPham> list;
        SANPHAM sp;
        int _iddp = 0;
        bool them = false;
        public frmDatPhongDonSanPham()
        {
            dp = new DATPHONG();
            ct = new CHITIETDATPHONG1();
            dpsp = new DATPHONSP();
            kh = new KHACHHANG();
            ldp = new List<DatPhong_Dat>();
            list = new List<DatPhongSanPham>();
            sp = new SANPHAM();
            InitializeComponent();
        }
        void loadCBX()
        {
            cboKhachHang.DataSource = kh.getAllKhachHang();
            cboKhachHang.DisplayMember = "TenKH";
            cboKhachHang.ValueMember = "MaKH";
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
            _iddp = _dp.MaDatPhong;
            cboKhachHang.SelectedItem = _dp.MaKH;
            txtGhiChu.Text = _dp.ghichu;
            if (_dp.TinhTrang==true)
            {
                rdbThanhToan.Checked = true;
            }
            else
            {
                rdbChuaThanhToan.Checked = true;
            }
            txtTongTien.Text = _dp.TongTien.Value.ToString("N0");
            SoNgayThue.Text = (_dp.NgayTra.Value.Day - _dp.NgayDat.Value.Day).ToString();
            load_Gird_DatPhongSanPham(_dp.MaDatPhong);
        }

        private void frmDatPhongDonSanPham_Load(object sender, EventArgs e)
        {
            loadData();
            loadCBX();
            loadSPDV();
            deleteAllDP_SP();
        }
        public void loadSPDV()
        {
            dsSanPham.DataSource = sp.getAllSanPham();
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
        void deleteAllDP_SP()
        {
            if (_iddp==0)
            {
                Application.Exit();
            }
            else
            {
                dpsp.DeleteAll(_iddp);
            }    
        }
        private void gridView3_Click(object sender, EventArgs e)
        {
            PHONG p = new PHONG();
            var kq = p.getPhong(TryVanDuLieu.maph);
            DatPhongSanPham dsp = new DatPhongSanPham();
            dsp.MASP = gridView3.GetFocusedRowCellValue("MASP").ToString();
            dsp.TenSP = gridView3.GetFocusedRowCellValue("TENSP").ToString();
            dsp.soLuong = 1;
            dsp.MaPH = kq.MaPH;
            dsp.tenPH = kq.TenPH;
            dsp.donGia = double.Parse(gridView3.GetFocusedRowCellValue("DONGIA").ToString());
            dsp.thanhTien = dsp.soLuong * dsp.donGia;
            foreach (var item in list)
            {
                if (item.MaPH == kq.MaPH && item.MASP == dsp.MASP)
                {
                    item.soLuong += 1;
                    item.thanhTien = item.soLuong * item.donGia;
                    load_DatPhong_SanPham();
                    return;
                }
            }
            list.Add(dsp);
            load_DatPhong_SanPham();
        }
        void saveData()
        {
            if (gridView5.RowCount > 0)
            {
                for (int i = 0; i < gridView5.RowCount; i++)
                {
                    DatPhong_SanPham _dpsp = new DatPhong_SanPham();
                    _dpsp.MASP = gridView5.GetRowCellValue(i, "MASP").ToString();
                    _dpsp.SoLuong = int.Parse(gridView5.GetRowCellValue(i, "soLuong").ToString());
                    _dpsp.MaDatPhong = _iddp;
                    _dpsp.MAPH = TryVanDuLieu.maph;
                    _dpsp.Ngay = DateTime.Now;
                    _dpsp.DonGia = double.Parse(gridView5.GetRowCellValue(i, "donGia").ToString());
                    _dpsp.ThanhTien = _dpsp.SoLuong * _dpsp.DonGia;
                    dpsp.Them(_dpsp);
                }
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            saveData();
            them = !them;
            MessageBox.Show("Lưu Thành Công");
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
        private void frmDatPhongDonSanPham_Leave(object sender, EventArgs e)
        {
            MessageBox.Show("Leave");
        }

        private void frmDatPhongDonSanPham_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!them)
            {
                DialogResult r = MessageBox.Show("Bạn Phải lưu dữ liệu trước khi thoát",
                                   "Cảnh Báo", MessageBoxButtons.YesNo,
                                   MessageBoxIcon.Warning,
                                   MessageBoxDefaultButton.Button1);
                if (DialogResult.Yes == r)
                {
                    saveData();
                }
            }
           
            
        }
    }
}