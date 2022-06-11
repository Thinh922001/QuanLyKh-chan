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
    public partial class frmDangNhap : DevExpress.XtraEditors.XtraForm
    {
        NHANVIEN nv;
        public frmDangNhap()
        {
            nv = new NHANVIEN();
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string manv = txtTaiKhoan.Text;
            string mk = txtMatKhau.Text;
            if (string.IsNullOrEmpty(manv)|| string.IsNullOrEmpty(mk))
            {
                MessageBox.Show("Phải nhập đầy đủ thông tin");
                return;
            }
          bool kq= nv.checkDN(manv, mk);
            if (!kq)
            {
                MessageBox.Show("Đăng Nhập thất bại");
                return;
            }
           
                MessageBox.Show("Đăng Nhập thành công");
                frmMain frm = new frmMain();
                this.Hide();
                TryVanDuLieu._manvDangNhap = txtTaiKhoan.Text;
                frm.Show();
                
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}