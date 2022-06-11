using DevExpress.Utils.Drawing;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Ribbon.ViewInfo;
using DevExpress.XtraEditors;
using DevExpress.XtraNavBar;
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
    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {
        LoadData data;
        TANG _tang;
        PHONG _phong;
        NHANVIEN _nv;
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
        public frmMain()
        {
            data = new LoadData();
            _tang = new TANG();
            _phong = new PHONG();
            _nv = new NHANVIEN();
            InitializeComponent();
            
        }
        GalleryItem item = null;
       
        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        public void loadTang()
        {
            _tang = new TANG();
            _phong = new PHONG();
            galleryControl1.Gallery.Groups.Clear();
            List<Tang> dsTang = _tang.LoadAllTang();
            galleryControl1.Gallery.ItemImageLayout =ImageLayoutMode.ZoomInside;
            galleryControl1.Gallery.ImageSize = new Size(64, 64);
            galleryControl1.Gallery.ShowItemText = true;
            galleryControl1.Gallery.ShowGroupCaption = true;
           
            foreach (Tang item in dsTang)
            {
                GalleryItemGroup group = new GalleryItemGroup();
                group.Caption = item.TenTang;
                group.CaptionAlignment = GalleryItemGroupCaptionAlignment.Stretch;
                List<Phong> dsPhong = _phong.geAllRoomByCode(item.MATANG.ToString());
                foreach (Phong p in dsPhong)
                {
                    GalleryItem galleryItem = new GalleryItem();
                    galleryItem.Caption = p.TenPH;
                    galleryItem.Value = p.MaPH;

                    if (p.TrangThai.Equals("Còn"))
                    {
                        galleryItem.ImageOptions.Image = imageList1.Images[0];
                    }
                    else
                    {
                        galleryItem.ImageOptions.Image = imageList1.Images[1];
                    }

                    group.Items.Add(galleryItem);
                }
                galleryControl1.Gallery.Groups.Add(group);
            }
        }
        private void navBarControl1_Click(object sender, EventArgs e)
        {

        }

        private void navBarControl1_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            string link_name = e.Link.Item.Name.ToString();
            switch (link_name)
            {
                case "phong": { frmPhong p = new frmPhong(); p.Show(); break; }
                case "loaiphong": { frmloaiphong p = new frmloaiphong(); p.Show(); this.Hide(); break; }
                case "khachhang": { frmKH p = new frmKH(); p.Show(); break;  }
                case "sanpham": { frmSP p = new frmSP(); p.Show(); break; }
                case "tang": { frmTang p = new frmTang(); p.Show(); break;  }
                case "thietbi": { frmThietBi p = new frmThietBi(); p.Show(); break; }
                case "matkhau": { frmDoiMatKhau p = new frmDoiMatKhau(); p.Show(); break; }
                case "datphong": { frmDatPhong dp = new frmDatPhong(); dp.Show();  break; }
                case "QLNV": { frmNhanVien dp = new frmNhanVien(); dp.Show(); break; }
                default:
                    break;
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            loadTang();
            // navBarGroup3
            
            NavBarItem item = new NavBarItem();
            if (_nv.isAdmin(TryVanDuLieu._manvDangNhap))
            {
                item.Name = "QLNV";
                item.Caption = "Nhân Viên";
                item.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("sanpham.ImageOptions.LargeImage")));
                item.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("phong.ImageOptions.SmallImage")));
                navBarGroup3.ItemLinks.Add(item);
            }
            
           
        }

        private void popupMenu1_Popup(object sender, EventArgs e)
        {
            Point point = galleryControl1.PointToClient(Control.MousePosition);
            RibbonHitInfo hitInfo = galleryControl1.CalcHitInfo(point);
            if (hitInfo.InGalleryItem || hitInfo.HitTest == RibbonHitTest.GalleryImage)
                 item = hitInfo.GalleryItem;
        }

        private void btndatphong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                var gc_item = new GalleryItem();        
                string ma = item.Value.ToString();
                frmDatPhongDon frm = new frmDatPhongDon();
                TryVanDuLieu.maph = ma;
                PHONG p = new PHONG();
                var phong = p.getPhong(ma);
                if (phong.TrangThai=="Hết")
                {
                    MessageBox.Show("Phòng này có người đặt rồi");
                    return;
                }
                else
                {
                    frm.ShowDialog();
                }    
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(""+ex);
                return;
            }
           
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
               /* PHONG p = new PHONG();
                var gc_item = new GalleryItem();
                string ma = item.Value.ToString();
                p.UpdateStatusPhong(ma);
                loadTang();
               */

                var gc_item = new GalleryItem();
                string ma = item.Value.ToString();
                TryVanDuLieu.maph = ma;
                PHONG p = new PHONG();
                var kq = p.getPhong(TryVanDuLieu.maph);
                if (kq.TrangThai=="Hết")
                {
                    frmChuyenPhong frm = new frmChuyenPhong();
                    frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Phòng này chưa có người Thuê");
                    return;
                }    
                
            }
            catch (Exception)
            {

                throw;
            }
           
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var gc_item = new GalleryItem();
            string ma = item.Value.ToString();
            
            TryVanDuLieu.maph = ma;
            frmDatPhongDonSanPham drm = new frmDatPhongDonSanPham();

            drm.ShowDialog();
        }

        private void btnthanhtoan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var gc_item = new GalleryItem();
            string ma = item.Value.ToString();
            TryVanDuLieu.maph = ma;
            PHONG p = new PHONG();
            var kq = p.getPhong(TryVanDuLieu.maph);
            if (kq.TrangThai == "Hết")
            {
                frmThanhToan tt = new frmThanhToan();
                tt.ShowDialog();
            }
            else
            {
                MessageBox.Show("Phòng Này chưa Có Người Đặt");
                return;
            }    
            
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            frmThongKe tk = new frmThongKe();
            tk.ShowDialog();
        }
    }
}