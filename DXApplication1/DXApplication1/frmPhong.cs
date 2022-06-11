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
    public partial class frmPhong : DevExpress.XtraEditors.XtraForm
    {
        TryVanDuLieu tryVanDuLieu;
        TANG tang;
        LOAIPHONG lp;
        bool them = false;
        bool xoa = false;
        bool sua = false;
        PHONG p;
        frmMain objMain = (frmMain)Application.OpenForms["frmMain"];
        public frmPhong()
        {
            tryVanDuLieu = new TryVanDuLieu();
            tang = new TANG();
            lp = new LOAIPHONG();
            p = new PHONG();
            InitializeComponent();
        }
        void loadCBX()
        {
            cboTang.DataSource = tang.LoadAllTang();
            cboTang.DisplayMember = "TenTang";
            cboTang.ValueMember = "MATANG";
            cboLoaiPhong.DataSource = lp.getAll_LoaiPhong();
            cboLoaiPhong.DisplayMember = "TenPhong";
            cboLoaiPhong.ValueMember = "MaLP";
        }
        void loadData()
        {
            DataTable tb = tryVanDuLieu.truyvan("select phong.MaPH,phong.TenPH,phong.TrangThai,tang.TenTang,LoaiPhong.TenPhong from Phong,Tang,LoaiPhong where phong.MALP = LoaiPhong.MaLP and Phong.MaTang = tang.MATANG");
            gridControl1.DataSource = tb;
           
        }
        void EnableControl(bool t)
        {
            txtMapH.Enabled = t;
            txtTenPH.Enabled = t;
            cboLoaiPhong.Enabled = t;
            cboTang.Enabled = t;
        }
        void TatVaMoControl(bool t)
        {
            btnThem.Enabled = t;
            btnSua.Enabled = t;
            btnXoa.Enabled = t;
            btnIn.Enabled = t;
            btnLuu.Enabled = !t;
        }
        private void frmPhong_Load(object sender, EventArgs e)
        {
            loadData();
            loadCBX();
            EnableControl(false);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            TatVaMoControl(false);
            them = !them;
            EnableControl(true);
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

        private void btnLuu_Click(object sender, EventArgs e)
        {
            TatVaMoControl(true);
            EnableControl(false);
            if (them)
            {
                if (!string.IsNullOrWhiteSpace(txtMapH.Text)|| !string.IsNullOrWhiteSpace(txtMapH.Text))
                {
                    Phong _p = new Phong();
                    _p.MaPH = txtMapH.Text;
                    _p.TenPH = txtTenPH.Text;
                    _p.MaTang = int.Parse(cboTang.SelectedValue.ToString());
                    _p.MALP = cboLoaiPhong.SelectedValue.ToString();
                    _p.TrangThai = "Còn";
                    p.Them(_p);
                    loadData();
                    them = !them;
                    objMain.loadTang();
                    MessageBox.Show("Thêm Thành Công");
                    

                }
                else
                {
                    MessageBox.Show("Hãy Nhập Đầy Đủ Thông Tin Phòng");
                }    
            }
            else if (xoa)
            {
                if (gridView1.RowCount>0)
                {
                    string maph = gridView1.GetFocusedRowCellValue("MaPH").ToString();
                    p.Xoa(maph);
                    loadData();
                    xoa = !xoa;
                    objMain.loadTang();
                    MessageBox.Show("Xóa Thành Công");

                }
                else
                {
                    MessageBox.Show("Hãy Chọn Chọn Cột Cần Xóa");
                    return;
                }    
            }
            else if (sua)
            {
                if (!string.IsNullOrWhiteSpace(txtMapH.Text) || !string.IsNullOrWhiteSpace(txtMapH.Text))
                {
                    if (gridView1.RowCount>0)
                    {
                        txtMapH.Text = gridView1.GetFocusedRowCellValue("MaPH").ToString();
                        txtTenPH.Text = gridView1.GetFocusedRowCellValue("TenPH").ToString();
                        Phong _p = new Phong();
                        _p.MaPH = txtMapH.Text;
                        _p.TenPH = txtTenPH.Text;
                        _p.MaTang = int.Parse(cboTang.SelectedValue.ToString());
                        _p.MALP = cboLoaiPhong.SelectedValue.ToString();
                        p.Edit(_p);
                        loadData();
                        MessageBox.Show("Sửa Thành Công");
                        sua = !sua;

                    }

                }
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            TatVaMoControl(false);
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}