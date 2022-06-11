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
    public partial class frmTang : DevExpress.XtraEditors.XtraForm
    {
        public frmTang()
        {
            InitializeComponent();
            TatVaMoControl(true);
            main = new frmMain();
        }
        TANG t = new TANG();
        bool them = false;
        bool xoa = false;
        bool sua = false;
        int matang;
        string tenTang;
        frmMain main;
        private void frmTang_Load(object sender, EventArgs e)
        {
            loadTang();
        }
        void TatVaMoControl(bool t)
        {
            btnThem.Enabled = t;
            btnSua.Enabled = t;
            btnXoa.Enabled = t;
            btnIn.Enabled = t;
            btnLuu.Enabled = !t;
        }
        void loadTang()
        {
            dsTang.DataSource = t.LoadAllTang();
        }
        void clearAllTextBox()
        {
            txtMaTang.Text="";
            txtTenTang.Text = "";

        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            them = !them;
            clearAllTextBox();
            TatVaMoControl(false);
        }
        void loadAlltextBox()
        {
           
            txtMaTang.Text= gridView1.GetFocusedRowCellValue("MATANG").ToString();
            txtTenTang.Text= gridView1.GetFocusedRowCellValue("TenTang").ToString();
            matang = int.Parse(txtMaTang.Text);
            tenTang = txtTenTang.Text;
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            xoa = !xoa;
            TatVaMoControl(false);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            sua = !sua;
            TatVaMoControl(false);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (them)
            {
                int maTang = int.Parse(txtMaTang.Text);
                string tenTang = txtTenTang.Text;
                Tang ta = new Tang(maTang, tenTang);
                t.Them(ta);
                them = !them;
                MessageBox.Show("Thêm " + tenTang + "Thành Công");
                loadTang();
                
                
            }
            else if (xoa)
            {
                t.Delete(matang);
                xoa = !xoa;
                MessageBox.Show("Xóa Tầng" + matang + "Thành Công");
                loadTang();
               
            }
            else if (sua)
            {
                t.Edit(matang, txtTenTang.Text);
                sua = !sua;
                MessageBox.Show("Sữa " + matang + "Thành công");
                loadTang();
               
            }

            TatVaMoControl(true);
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            TatVaMoControl(false);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            TatVaMoControl(true);
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount>0)
            {
                loadAlltextBox();
            }
        }

        private void frmTang_FormClosed(object sender, FormClosedEventArgs e)
        {
            main.Show();
        }
    }
}