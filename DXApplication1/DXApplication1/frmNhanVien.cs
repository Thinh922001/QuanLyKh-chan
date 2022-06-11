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
    public partial class frmNhanVien : DevExpress.XtraEditors.XtraForm
    {
        NHANVIEN nv;
        bool them = false;
        bool xoa = false;
        bool sua = false;
        public frmNhanVien()
        {
            nv = new NHANVIEN();
           
            InitializeComponent();
        }
        void TatVaMoControl(bool t)
        {
            btnThem.Enabled = t;
            btnSua.Enabled = t;
            btnXoa.Enabled = t;
            btnLuu.Enabled = !t;
        }
        void EnableControl(bool t)
        {
            txtHoten.Enabled = t;
            txtManv.Enabled = t;
            txtMatKhau.Enabled = t;
            cboQuyen.Enabled = t;
        }
        void loadCBX()
        {
            cboQuyen.DataSource = Quyen.listQuyen();
            cboQuyen.DisplayMember = "Display";
            cboQuyen.ValueMember = "values";
        }    
        void loadNhanVien()
        {
            gridControl1.DataSource = nv.getAllNhanVien();
        }
        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            loadNhanVien();
            loadCBX();
            EnableControl(false);
        }
     
        private void btnThem_Click(object sender, EventArgs e)
        {
            TatVaMoControl(false);
            EnableControl(true);
            them = !them;

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            TatVaMoControl(false);
            EnableControl(false);
            xoa = !xoa;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            TatVaMoControl(false);
            EnableControl(true);
            sua = !sua;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            TatVaMoControl(true);
            if (them)
            {
                if (!string.IsNullOrWhiteSpace(txtHoten.Text)|| !string.IsNullOrWhiteSpace(txtManv.Text) || !string.IsNullOrWhiteSpace(txtMatKhau.Text))
                {
                    NhanVien _nv = new NhanVien();
                    _nv.HoTen = txtHoten.Text;
                    _nv.MatKhau = txtMatKhau.Text;
                    _nv.MaNV = txtManv.Text;
                    _nv.quyen = cboQuyen.SelectedValue.ToString();
                    nv.Them(_nv);
                    them = !them;
                    loadNhanVien();
                    MessageBox.Show("Thêm thành công");
                    
                }
                else
                {
                    MessageBox.Show("Hãy nhập đầy đủ thông tin");
                    return;
                }    
            }
            else if (xoa)
            {
                if (gridView1.RowCount>0)
                {
                    string ma = gridView1.GetFocusedRowCellValue("MaNV").ToString();
                    nv.Delete(ma);
                    xoa = !xoa;
                    loadNhanVien();
                    MessageBox.Show("Xóa Thành Công");
                }
                else
                {
                    MessageBox.Show("Hãy Chọn Dòng Nhân Viên Trên lưới để xóa");
                    return;
                }    
            }
            else if(sua)
            {
                if (!string.IsNullOrWhiteSpace(txtHoten.Text) || !string.IsNullOrWhiteSpace(txtManv.Text) || !string.IsNullOrWhiteSpace(txtMatKhau.Text))
                {
                    NhanVien _nv = new NhanVien();
                     _nv.MaNV = txtManv.Text;
                    _nv.HoTen = txtHoten.Text;
                    _nv.MatKhau = txtMatKhau.Text;
                }
            }    
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            TatVaMoControl(true);
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}