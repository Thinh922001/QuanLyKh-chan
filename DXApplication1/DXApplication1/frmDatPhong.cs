using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
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
    public partial class frmDatPhong : DevExpress.XtraEditors.XtraForm
    {
        DATPHONG dp;
        PHONG p;
        SANPHAM sp;
       // GridHitInfo downhitInfo = null;
        DataTable tb;
        List<DatPhong_Dat> ldp;
        List<DatPhongSanPham> list;
        KHACHHANG kh;
        bool them = false;
        bool sua = false;
        bool xoa = false;
        int _idp;
        frmMain objMain = (frmMain)Application.OpenForms["frmMain"];
        public frmDatPhong()
        {
            dp = new DATPHONG();
            p = new PHONG();
            sp = new SANPHAM();
            list = new List<DatPhongSanPham>();
            ldp = new List<DatPhong_Dat>();
            kh = new KHACHHANG();
            InitializeComponent();
        }
       
        string maph;
        string tenph;
        void loadNgay()
        {
            DenNgay.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 6);
            TuNgay.Value =  new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
        }
        void loadDatphong()
        {
            dsDatPhong.DataSource = dp.getAllDatPhong(TuNgay.Value, DenNgay.Value.AddDays(1));
        }
        private void frmDatPhong_Load(object sender, EventArgs e)
        {
            loadNgay();
            loadDatphong();
            // dsPhongTrong.DataSource = p.getPhongTrong();
            LoadTang();
            dsSanPham.DataSource = sp.getAllSanPham();
           
            loadKH();
            resetTextBox();
           
            

        }
       public void loadKH()
        {
            kh = new KHACHHANG();
            cboKhachHang.DataSource = kh.getAllKhachHang();
            cboKhachHang.DisplayMember = "TenKH";
            cboKhachHang.ValueMember = "MAKH";
        }
        public void LoadTang()
        {
            tb = new TryVanDuLieu().truyvan("select TenPH,TenTang,DonGia,MaPH,t.MATANG  from Phong p, Tang t,LoaiPhong lp where p.MaTang=t.MATANG and p.MALP=lp.MaLP and p.TrangThai=N'Còn'");
            gcPhong1.DataSource = tb;
            
        }
        public void Enabale(bool t)
        {
            cboKhachHang.Enabled = t;
            txtGhiChu.Enabled = t;
            rdbThanhToan.Enabled = t;
            rdbChuaThanhToan.Enabled = t;
            SoNgayThue.Enabled = t;
            soNguoi.Enabled = t;
        }
        void TatVaMoControl(bool t)
        {
            btnThem.Enabled = t;
            btnSua.Enabled = t;
            btnXoa.Enabled = t;
            btnIn.Enabled = t;
            btnLuu.Enabled = !t;
        }
        void resetTextBox()
        {
            txtGhiChu.Text = "";
            soNguoi.Text = "1";
            rdbThanhToan.Checked = true;
            SoNgayThue.Text = "1";

        }
        private void dateTimePicker4_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xtraTabControl1.SelectedTabPage = xtraTabPage2;
            them = !them;
            TatVaMoControl(false);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            TatVaMoControl(false);
            xoa = !xoa;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            TatVaMoControl(false);
            sua = !sua;
        }
        bool checkThanhToan()
        {
            return rdbThanhToan.Checked ? true : false;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            SaveData();
            objMain.galleryControl1.Gallery.Groups.Clear();
            objMain.loadTang();
            TatVaMoControl(false);
        }
       
        void SaveData()
        {
            DATPHONG tdp = new DATPHONG();
            CHITIETDATPHONG1 ct;
            DATPHONSP dpsp;
            if (them)
            {

                DatPhong dp = new DatPhong();
                dp.NgayDat = DateTime.Now;
                int sonnt = (int)SoNgayThue.Value;
                dp.NgayTra = DateTime.Now.AddDays(sonnt);
                dp.SoNguoiO = (int)soNguoi.Value;
                dp.TinhTrang = checkThanhToan();
                dp.MaKH = cboKhachHang.SelectedValue.ToString();
                dp.TongTien = double.Parse(txtTongTien.Text);
                dp.ghichu = txtGhiChu.Text;
                dp.Theodoan = true;
                dp.MaNV = TryVanDuLieu._manvDangNhap;
                var datp = tdp.Them(dp);
              //  _idp = datp.MaDatPhong;
                for (int i = 0; i < gvDatPhong1.RowCount; i++)
                {
                    ct = new CHITIETDATPHONG1();
                    CHITIETDATPHONG _ct = new CHITIETDATPHONG();
                    _ct.MaDatPhong = datp.MaDatPhong;
                    _ct.MAPH = gvDatPhong1.GetRowCellValue(i, "MaPH").ToString();
                    _ct.DonGia = double.Parse(gvDatPhong1.GetRowCellValue(i, "DONGIA").ToString());
                    _ct.SoNgayO = (int)SoNgayThue.Value;
                    _ct.ThanhTien = _ct.DonGia * _ct.SoNgayO;
                    _ct.Ngay = DateTime.Now;
                    ct.Them(_ct);
                    p.UpdateStatusPhong(_ct.MAPH);
                    if (gridView5.RowCount < 0)
                    {
                        dpsp = new DATPHONSP();
                        DatPhong_SanPham _dpsp = new DatPhong_SanPham();
                        _dpsp.MAPH = _ct.MAPH;
                        _dpsp.MaDatPhong = dp.MaDatPhong;
                        dpsp.Them(_dpsp);
                    }
                   

                }
                if (gridView5.RowCount > 0)
                {
                    for (int j = 0; j < gridView5.RowCount; j++)
                    {
                        dpsp = new DATPHONSP();
                        DatPhong_SanPham _dpsp = new DatPhong_SanPham();
                        _dpsp.MaDatPhong = datp.MaDatPhong;
                        _dpsp.MAPH = gridView5.GetRowCellValue(j, "MaPH").ToString();
                        _dpsp.Ngay = DateTime.Now;
                        _dpsp.MASP = gridView5.GetRowCellValue(j, "MASP").ToString();
                        _dpsp.SoLuong = int.Parse(gridView5.GetRowCellValue(j, "soLuong").ToString());
                        _dpsp.DonGia = double.Parse(gridView5.GetRowCellValue(j, "donGia").ToString());
                        _dpsp.ThanhTien = _dpsp.SoLuong * _dpsp.DonGia;
                        dpsp.Them(_dpsp);
                    }
                }

                MessageBox.Show("Đặt phòng thành công");
                LoadTang();
                them = !them;
                loadDatphong();

            }
            else if (sua)
            {
                DATPHONG _dp = new DATPHONG();
                DatPhong dp = _dp.getDatPhong(_idp);
                dp.NgayDat = DateTime.Now;
                int sonnt = (int)SoNgayThue.Value;
                dp.NgayTra = DateTime.Now.AddDays(sonnt);
                dp.SoNguoiO = (int)soNguoi.Value;
                dp.TinhTrang = checkThanhToan();
                dp.MaKH = cboKhachHang.SelectedValue.ToString();
                dp.TongTien = double.Parse(txtTongTien.Text);
                dp.ghichu = txtGhiChu.Text;
                dp.Theodoan = true;
                dp.MaNV = "NV01";

                var datp = _dp.Edit(dp);
                ct = new CHITIETDATPHONG1();
                dpsp = new DATPHONSP();
                ct.deleteAll(datp.MaDatPhong);
                dpsp.DeleteAll(datp.MaDatPhong);
                for (int i = 0; i < gvDatPhong1.RowCount; i++)
                {
                    ct = new CHITIETDATPHONG1();
                    CHITIETDATPHONG _ct = new CHITIETDATPHONG();
                    _ct.MaDatPhong = datp.MaDatPhong;
                    _ct.MAPH = gvDatPhong1.GetRowCellValue(i, "MaPH").ToString();
                    _ct.DonGia = double.Parse(gvDatPhong1.GetRowCellValue(i, "DONGIA").ToString());
                    _ct.SoNgayO = (int)SoNgayThue.Value;
                    _ct.ThanhTien = _ct.DonGia * _ct.SoNgayO;
                    _ct.Ngay = DateTime.Now;
                    ct.Them(_ct);
                    p.UpdateStatusPhong(_ct.MAPH);
                    if (gridView5.RowCount < 0)
                    {
                        dpsp = new DATPHONSP();
                        DatPhong_SanPham _dpsp = new DatPhong_SanPham();
                        _dpsp.MAPH = _ct.MAPH;
                        _dpsp.MaDatPhong = dp.MaDatPhong;
                        dpsp.Them(_dpsp);
                    }
                   

                }
                if (gridView5.RowCount > 0)
                {
                    for (int j = 0; j < gridView5.RowCount; j++)
                    {
                        dpsp = new DATPHONSP();
                        DatPhong_SanPham _dpsp = new DatPhong_SanPham();
                        _dpsp.MaDatPhong = datp.MaDatPhong;
                        _dpsp.MAPH = gridView5.GetRowCellValue(j, "MaPH").ToString();
                        _dpsp.Ngay = DateTime.Now;
                        _dpsp.MASP = gridView5.GetRowCellValue(j, "MASP").ToString();
                        _dpsp.SoLuong = int.Parse(gridView5.GetRowCellValue(j, "soLuong").ToString());
                        _dpsp.DonGia = double.Parse(gridView5.GetRowCellValue(j, "donGia").ToString());
                        _dpsp.ThanhTien = _dpsp.SoLuong * _dpsp.DonGia;
                        dpsp.Them(_dpsp);
                    }
                }
                MessageBox.Show("Sữa Đặt phòng Thành Công");
                sua = !sua;
                capNhatTrangThai();
               loadDatphong();
            }
            else if(xoa)
            {
                if (gridView1.RowCount>0)
                {
                    int madp = int.Parse(gridView1.GetFocusedRowCellValue("MaDatPhong").ToString());
                    DATPHONSP sp = new DATPHONSP();
                    CHITIETDATPHONG1 ctdp = new CHITIETDATPHONG1();
                    DATPHONG dp = new DATPHONG();
                    sp.DeleteAll(madp);
                    ctdp.deleteAll(madp);
                    dp.Delete(madp.ToString());
                }
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            frmShowChiTietHoaDon frm = new frmShowChiTietHoaDon();
            if (gridView1.RowCount>0)
            {
                TryVanDuLieu.madatphong = int.Parse(gridView1.GetFocusedRowCellValue("MaDatPhong").ToString());
            }
            else 
            {
                MessageBox.Show("Hãy Chọn mã Chi Tiết Hóa Đơn mà bạn muốn in");
                return;
            }
             
            frm.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            TatVaMoControl(true);
        }

        private void gcDatPhong_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void gcDatPhong_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void dsPhongTrong_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void dsPhongTrong_MouseDown(object sender, MouseEventArgs e)
        {
           
        }
        // gv Phong
        private void gridView2_MouseDown(object sender, MouseEventArgs e)
        {
          
        }

        // gv Phong
        private void gridView2_MouseMove(object sender, MouseEventArgs e)
        {
        
        }

        // gv DatPhong
        private void gridView4_MouseDown(object sender, MouseEventArgs e)
        {
         
        }

        // gv Dat Phong
        private void gridView4_MouseMove(object sender, MouseEventArgs e)
        {
          
        }

        private void dsPhongTrong_DragDrop(object sender, DragEventArgs e)
        {
            //GridControl grid = sender as GridControl;
            //DataTable table = grid.DataSource as DataTable;
            //DataRow row = e.Data.GetData(typeof(DataRow)) as DataRow;
            //if (row != null && table != null && row.Table != null)
            //{
            //    table.ImportRow(row);
            //    row.Delete();
            //}
        }



        private void gcDatPhong_DragOver(object sender, DragEventArgs e)
        {
            //if (e.Data.GetDataPresent(typeof(DataRow)))
            //{
            //    e.Effect = DragDropEffects.Move;
            //}
            //else
            //{
            //    e.Effect = DragDropEffects.None;
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmKH kh = new frmKH();
            kh.ShowDialog();
        }

        private void gvPhong_MouseDown(object sender, MouseEventArgs e)
        {
            //GridView view = sender as GridView;
            //downhitInfo = null;
            //GridHitInfo hitinfi = view.CalcHitInfo(new Point(e.X, e.Y));
            //if (Control.ModifierKeys == Keys.None) return;
            //if (e.Button == MouseButtons.Left && hitinfi.RowHandle >= 0)
            //{
            //    downhitInfo = hitinfi;
            //}
           
            
        }

        private void gvPhong_MouseMove(object sender, MouseEventArgs e)
        {
            //GridView view = sender as GridView;
            //if (e.Button == MouseButtons.Left && downhitInfo != null)
            //{
            //    Size dragSize = SystemInformation.DragSize;
            //    Rectangle dragRect = new Rectangle(new Point(downhitInfo.HitPoint.X - dragSize.Width / 2, downhitInfo.HitPoint.Y - dragSize.Height / 2), dragSize);
            //    if (!dragRect.Contains(new Point(e.X, e.Y)))
            //    {
            //        DataRow row = view.GetDataRow(downhitInfo.RowHandle);
            //        view.GridControl.DoDragDrop(row, DragDropEffects.Move);
            //        downhitInfo = null;
            //        DevExpress.Utils.DXMouseEventArgs.GetMouseArgs(e).Handled = true;
            //    }
            //}
        }

        private void gvDatPhong1_MouseDown(object sender, MouseEventArgs e)
        {
            if (gvDatPhong1.GetFocusedRowCellValue("MaPH") != null)
            {
                maph = gvDatPhong1.GetFocusedRowCellValue("MaPH").ToString();
                tenph = gvDatPhong1.GetFocusedRowCellValue("TenPH").ToString();
               

            }
            //GridView view = sender as GridView;
            //downhitInfo = null;
            //GridHitInfo hitInfo = view.CalcHitInfo(new Point(e.X, e.Y));
            //if (Control.ModifierKeys != Keys.None) return;
            //if (e.Button == MouseButtons.Left && hitInfo.RowHandle >= 0)
            //{
            //    downhitInfo = hitInfo;
            //}
        }

        private void gvDatPhong1_MouseMove(object sender, MouseEventArgs e)
        {
            //GridView view = sender as GridView;
            //if (e.Button == MouseButtons.Left && downhitInfo != null)
            //{
            //    Size dragSize = SystemInformation.DragSize;
            //    Rectangle dragRect = new Rectangle(new Point(downhitInfo.HitPoint.X - dragSize.Width / 2, downhitInfo.HitPoint.Y - dragSize.Height / 2), dragSize);
            //    if (!dragRect.Contains(new Point(e.X, e.Y)))
            //    {
            //        DataRow row = view.GetDataRow(downhitInfo.RowHandle);
            //        view.GridControl.DoDragDrop(row, DragDropEffects.Move);
            //        downhitInfo = null;
            //        DevExpress.Utils.DXMouseEventArgs.GetMouseArgs(e).Handled = true;
            //    }
            //}
        }

        private void gcPhong1_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(DataRow)))
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void gcPhong1_DragOver(object sender, DragEventArgs e)
        {
            //GridControl grid = sender as GridControl;
            //DataTable table = grid.DataSource as DataTable;
            //DataRow row = e.Data.GetData(typeof(DataRow)) as DataRow;
            //if (row != null && table != null && row.Table != null)
            //{
            //    table.ImportRow(row);
            //    row.Delete();
            //}
        }
        // Update trạng thái khi sửa một khách hàng có thể cập nhật lại tình trạng phòng
        void capNhatTrangThai()
        {
            PHONG p = new PHONG();
            for (int i = 0; i < gvPhong.RowCount; i++)
            {
                string maph = gvPhong.GetRowCellValue(i, "MaPH").ToString();
                p.UpdateStatusPhong(maph);
            }
        }
        private void gcPhong1_Click(object sender, EventArgs e)
        {
            if (gvPhong.RowCount>0)
            {
                string maph1;
                maph1 = gvPhong.GetFocusedRowCellValue("MaPH").ToString();
                //TryVanDuLieu dl = new TryVanDuLieu();
                //DataTable tb1 = new DataTable();
                //DataTable tb = dl.truyvan("select TenPH,TenTang,DonGia,MaPH,t.MATANG  from Phong p, Tang t,LoaiPhong lp where p.MaTang=t.MATANG and p.MALP=lp.MaLP and p.TrangThai=N'Còn' and p.MaPH='" + maph + "'");
                //gcDatPhong1.DataSource = tb;
                DatPhong_Dat dp = new DatPhong_Dat();
                dp.MaPH = maph1;
                dp.TenPH = gvPhong.GetFocusedRowCellValue("TenPH").ToString();
                dp.DONGIA = double.Parse(gvPhong.GetFocusedRowCellValue("DonGia").ToString());
                try
                {
                    for (int i = tb.Rows.Count - 1; i >= 0; i--)
                    {
                        DataRow dr = tb.Rows[i];
                        if (dr["MaPH"].Equals(maph1))
                            dr.Delete();
                        tb.AcceptChanges();
                    }
                    //LoadTang();
                }
                catch (Exception)
                {

                    return;
                }
                // LoadTang();
                //dt.AcceptChanges();
                ldp.Add(dp);
                load_DatPhong();
                double tongdongiaPhong = (double)gvDatPhong1.Columns["DONGIA"].SummaryItem.SummaryValue;
                int songay = (int)SoNgayThue.Value;
                double tongtien = tongdongiaPhong * songay;
                txtTongTien.Text = tongtien.ToString();
            }
           
        }
        bool CheckMP(string map)
        {
            return true;
        }
        void load_DatPhong()
        {
            List<DatPhong_Dat> listt = new List<DatPhong_Dat>();
            foreach (var item in ldp)
            {
                listt.Add(item);
            }
            gcDatPhong1.DataSource = listt;
        }

        private void dsSanPham_DoubleClick(object sender, EventArgs e)
        {

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

        private void dsSanPham_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(maph)||maph=="")
            {
                MessageBox.Show("Vui Lòng chọn mã phòng");
                return;
            }
            else if (gvPhong.GetFocusedRowCellValue("MaPH") != null)
            {
                DatPhongSanPham dsp = new DatPhongSanPham();
                dsp.MASP = gridView3.GetFocusedRowCellValue("MASP").ToString();
                dsp.TenSP = gridView3.GetFocusedRowCellValue("TENSP").ToString();
                dsp.soLuong = 1;
                dsp.MaPH = maph;
                dsp.tenPH = tenph;
                dsp.donGia = double.Parse(gridView3.GetFocusedRowCellValue("DONGIA").ToString());
                dsp.thanhTien = dsp.soLuong * dsp.donGia;
                foreach (var item in list)
                {
                    if (item.MaPH == maph && item.MASP == dsp.MASP)
                    {
                        item.soLuong += 1;
                        item.thanhTien = item.soLuong * item.donGia;
                        load_DatPhong_SanPham();
                        return;
                    }
                }
                list.Add(dsp);
            }

            load_DatPhong_SanPham();
            txtTongTien.ForeColor = Color.Green;
           // txtTongTien.Size = new Size(20, 20);
            txtTongTien.Text = ((double)(gridView5.Columns["thanhTien"].SummaryItem.SummaryValue) + (double)gvDatPhong1.Columns["DONGIA"].SummaryItem.SummaryValue).ToString("N0");
           
        }

        private void gvDatPhong1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
           
        }

        private void gridView5_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "soLuong")
            {
                int sl = int.Parse(e.Value.ToString());
                if (sl != 0)
                {
                    double gia = double.Parse(gridView5.GetRowCellValue(gridView5.FocusedRowHandle, "donGia").ToString());
                    gridView5.SetRowCellValue(gridView5.FocusedRowHandle, "thanhTien", sl * gia);
                }
                else
                {
                    gridView5.SetRowCellValue(gridView5.FocusedRowHandle, "thanhTien", 0);
                }    
            }
            gridView5.UpdateTotalSummary();
        }

        private void gvDatPhong1_DoubleClick(object sender, EventArgs e)
        {
            if (gvDatPhong1.RowCount>0)
            {
                string maph2 = gvDatPhong1.GetFocusedRowCellValue("MaPH").ToString();
                
                TryVanDuLieu tv = new TryVanDuLieu();
                DataTable tb1 = tv.truyvan("select TenPH, TenTang, DonGia, MaPH, t.MATANG  from Phong p, Tang t, LoaiPhong lp where p.MaTang = t.MATANG and p.MALP = lp.MaLP and p.TrangThai = N'Còn' and MaPH='" + maph2 + "'");
                tb.Merge(tb1);
                tb.AcceptChanges();
                var DatPhong_d= ldp.Where(dp => dp.MaPH.Equals(maph2)).FirstOrDefault();
                if (DatPhong_d!=null)
                {
                    ldp.Remove(DatPhong_d);
                    load_DatPhong();
                }
                else
                {
                    MessageBox.Show("Lỗi");
                }    
                
            }
        }

        private void gridView5_DoubleClick(object sender, EventArgs e)
        {
            if (gridView5.RowCount>0)
            {
                string masp = gridView5.GetFocusedRowCellValue("MASP").ToString();
                var dpsp = list.Where(dp => dp.MASP.Equals(masp)).FirstOrDefault();
                list.Remove(dpsp);
                load_DatPhong_SanPham();
            }
        }
        public void setKhachHang(string makh)
        {
            var _kh = kh.getKHfromCode(makh);
            cboKhachHang.SelectedValue = _kh.MAKH;
            cboKhachHang.Text = _kh.TenKH;

        }

        private void xtraTabPage2_Click(object sender, EventArgs e)
        {
            them = !them;
            MessageBox.Show(them.ToString());
        }

        private void TuNgay_ValueChanged(object sender, EventArgs e)
        {
            if (TuNgay.Value>DenNgay.Value)
            {
                MessageBox.Show("Ngày Không Hợp Lệ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                loadDatphong();
            }    
        }

        private void TuNgay_Leave(object sender, EventArgs e)
        {
            if (TuNgay.Value > DenNgay.Value)
            {
                MessageBox.Show("Ngày Không Hợp Lệ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                loadDatphong();
            }
        }

        private void DenNgay_ValueChanged(object sender, EventArgs e)
        {
            if (TuNgay.Value > DenNgay.Value)
            {
                MessageBox.Show("Ngày Không Hợp Lệ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                loadDatphong();
            }
        }

        private void DenNgay_Leave(object sender, EventArgs e)
        {
            if (TuNgay.Value > DenNgay.Value)
            {
                MessageBox.Show("Ngày Không Hợp Lệ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                loadDatphong();
            }
        }
        void loadsDatPhong()
        {
            if (gridView1.RowCount > 0)
            {
                int madp = int.Parse(gridView1.GetFocusedRowCellValue("MaDatPhong").ToString());
                _idp = madp;
                DATPHONG dp = new DATPHONG();
                var _dp = dp.getDatPhong(madp);
                cboKhachHang.SelectedValue = _dp.MaKH;
                DateTime? ngayd = _dp.NgayDat;
                DateTime? ngayt = _dp.NgayTra;
                int? song = _dp.SoNguoiO;
                soNguoi.Text = song.ToString();

                int sn = ngayt.Value.Day - ngayd.Value.Day;
                SoNgayThue.Text = sn.ToString();
                bool? tt = _dp.TinhTrang;
                if (tt == true)
                {
                    rdbThanhToan.Checked = true;
                }
                else if (tt == false)
                {
                    rdbChuaThanhToan.Checked = true;
                }
                else
                {
                    return;
                }
                txtGhiChu.Text = _dp.ghichu;
                txtTongTien.Text = _dp.TongTien.Value.ToString("N0");
                xtraTabControl1.SelectedTabPage = xtraTabPage2;
                load_Grid_DP(_dp.MaDatPhong);
                load_Gird_DatPhongSanPham(_dp.MaDatPhong);
            }
        }
        private void gridView1_Click(object sender, EventArgs e)
        {
      
        }
        void load_Grid_DP(int madp)
        {
            ldp.Clear();
            CHITIETDATPHONG1 ct = new CHITIETDATPHONG1();
            var listCTDP = ct.dsChiTietDatPhong(madp);
            DatPhong_Dat dat;
            PHONG p;
            foreach (var item in listCTDP)
            {
                p = new PHONG();
                dat = new DatPhong_Dat();
                var _p = p.getPhong(item.MAPH);
                dat.MaPH = item.MAPH;
                dat.TenPH = _p.TenPH;
                dat.DONGIA = (double)p.getDonGiaFromPhong(item.MAPH);
                ldp.Add(dat);
            }
            load_DatPhong();
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

        private void dsSanPham_ClientSizeChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            loadsDatPhong();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "Excel 2007 or higher(.xlsx) | *.xlsx";
            if (sf.ShowDialog()==DialogResult.OK)
            {
                gridView1.ExportToXlsx(sf.FileName);
            }
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "pdf 2007 or higher(.pdf) | *.pdf";
            if (sf.ShowDialog() == DialogResult.OK)
            {
                gridView1.ExportToPdf(sf.FileName);
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "DOCX 2007 or higher(.docx) | *.docx";
            if (sf.ShowDialog() == DialogResult.OK)
            {
                gridView1.ExportToDocx(sf.FileName);
            }
        }
    }
}