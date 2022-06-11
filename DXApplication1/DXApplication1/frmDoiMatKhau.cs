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
    public partial class frmDoiMatKhau : DevExpress.XtraEditors.XtraForm
    {
        NHANVIEN nv;
        public frmDoiMatKhau()
        {
            nv = new NHANVIEN();
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtHienTai.Text)|| !string.IsNullOrWhiteSpace(txtMatKhauMoi.Text) || string.IsNullOrWhiteSpace(txtXacNhan.Text) )
            {
                bool kq = nv.doiMK(TryVanDuLieu._manvDangNhap, txtHienTai.Text, txtMatKhauMoi.Text, txtXacNhan.Text);
                if (kq)
                {
                    MessageBox.Show("Đổi Mật Khẩu Thành Công");
                    return;
                }
                else
                {
                    MessageBox.Show("Đổi Mật Khẩu Thất Bại");
                    return;
                }    
            }
            else
            {
                MessageBox.Show("Mời Bạn Nhập Đầy Đủ Thông Tin");
            }    
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}