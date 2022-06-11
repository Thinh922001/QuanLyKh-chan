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
    public partial class frmloaiphong : DevExpress.XtraEditors.XtraForm
    {
        LOAIPHONG p;
        LoaiPhong lp;
        public frmloaiphong()
        {
            p = new LOAIPHONG();
            lp = new LoaiPhong();
            InitializeComponent();
            TatVaMoControl(true);
            soNguoi.Value = 0;
            soGiuong.Value = 0;
        }
        bool them;
        bool xoa;
        bool sua = false;
        string malp = "";
        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        void TatVaMoControl(bool t)
        {
            btnThem.Enabled = t;
            btnSua.Enabled = t;
            btnXoa.Enabled = t;
            btnIn.Enabled = t;
            btnLuu.Enabled = !t;
        }
        void loadLoaiPhong()
        {
            dsLoaiPhong.DataSource = p.getAll_LoaiPhong();
            
        }
        void clearAllTextBox()
        {
            txtMaLP.Text = "";
            txtenPhong.Text = "";
            txtDonGia.Text = "";
            soNguoi.Value = 0;
            soGiuong.Value = 0;
        }
        void showValue()
        {
            txtMaLP.Text = gridView1.GetFocusedRowCellValue("MaLP").ToString();
            malp = txtMaLP.Text;
            txtenPhong.Text = gridView1.GetFocusedRowCellValue("TenPhong").ToString();
            txtDonGia.Text = gridView1.GetFocusedRowCellValue("DonGia").ToString();
            //soNguoi.Value =  gridView1.GetFocusedRowCellValue("SN").ToString();
            //soGiuong.Value = decimal.Parse(gridView1.GetFocusedRowCellValue("SG").ToString());
            soNguoi.Value = decimal.Parse(gridView1.GetFocusedRowCellValue("SoNguoi").ToString());
            soGiuong.Value = decimal.Parse(gridView1.GetFocusedRowCellValue("SoGiuong").ToString());
        }
        private void frmloaiphong_Load(object sender, EventArgs e)
        {
            loadLoaiPhong();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            them = true;
            xoa = false;
            TatVaMoControl(false);
            clearAllTextBox();

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            them = false;
            xoa = true;
            TatVaMoControl(false);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            them = false;
            sua = true;
            TatVaMoControl(false);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (them)
            {
                string malp = txtMaLP.Text;
                string tenlp = txtenPhong.Text;
                int songuoilp = (int)soNguoi.Value;
                int sogiuonglp = (int)soGiuong.Value;
                int dongia = Convert.ToInt32(txtDonGia.Text);
                lp = new LoaiPhong(malp,tenlp,songuoilp,sogiuonglp,dongia);
                p.Them(lp);
                MessageBox.Show("Thêm Thành Công");
                them = !them;
                loadLoaiPhong();
            }
            else if(xoa)
            {
                p.Delete(malp);
                MessageBox.Show("Xóa Thành công");
                xoa = !xoa;
                loadLoaiPhong();
            }
            else if (sua)
            {
                string malp = txtMaLP.Text;
                string tenlp = txtenPhong.Text;
                int songuoilp = (int)soNguoi.Value;
                int sogiuonglp = (int)soGiuong.Value;
                int dongia = Convert.ToInt32(txtDonGia.Text);
                lp = new LoaiPhong(malp, tenlp, songuoilp, sogiuonglp, dongia);
                p.Edit(malp,tenlp,songuoilp,sogiuonglp,dongia);
                MessageBox.Show("Thêm Thành Công");
                sua = !sua;
                loadLoaiPhong();
            }
            TatVaMoControl(true);
        }
        
        private void btnIn_Click(object sender, EventArgs e)
        {

        }

        private void dsLoaiPhong_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void dsLoaiPhong_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridView1.RowCount > 0)
                {
                    showValue();
                }
            }
            catch (Exception)
            {

                return;
            }


           
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            TatVaMoControl(true);
        }
    }
}