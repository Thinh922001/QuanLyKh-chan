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
using ExcelApp = Microsoft.Office.Interop.Excel;
namespace DXApplication1
{
    public partial class frmSP : DevExpress.XtraEditors.XtraForm
    {
        SANPHAM sp;
        public frmSP()
        {
            sp = new SANPHAM();
            InitializeComponent();
        }
        bool them = false;
        bool xoa = false;
        bool sua = false;
        void TatVaMoControl(bool t)
        {
            btnThem.Enabled = t;
            btnSua.Enabled = t;
            btnXoa.Enabled = t;
           
            btnLuu.Enabled = !t;
        }
        void clearAllTextBox()
        {
            txtDonGia.Text = "";
            txtMa.Text = "";
            txtTenSP.Text = "";
        }
        void Enable(bool t)
        {
            txtTenSP.Enabled = t;
            txtMa.Enabled = t;
            txtDonGia.Enabled = t;
        }
        void loadTextBox()
        {
            if (gridView1.RowCount>0)
            {
                txtDonGia.Text = gridView1.GetFocusedRowCellValue("DONGIA").ToString();
                txtMa.Text = gridView1.GetFocusedRowCellValue("MASP").ToString();
                txtTenSP.Text = gridView1.GetFocusedRowCellValue("TENSP").ToString();
            }
        }
        public void loadData()
        {
            gridControl1.DataSource = sp.getAllSanPham();
        }    
        private void frmSP_Load(object sender, EventArgs e)
        {
            loadData();
            Enable(false);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            TatVaMoControl(false);
            clearAllTextBox();
            Enable(true);
            them = !them;

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            TatVaMoControl(false);
            loadTextBox();
            Enable(false);
            xoa = !xoa;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            TatVaMoControl(false);
            Enable(true);
            loadTextBox();
            sua = !sua;
        
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            TatVaMoControl(true);
            if (them)
            {
                if (!string.IsNullOrWhiteSpace(txtMa.Text) || !string.IsNullOrWhiteSpace(txtTenSP.Text) || !string.IsNullOrWhiteSpace(txtDonGia.Text))
                {
                    SanPham _sp = new SanPham();
                    _sp.MASP = txtMa.Text;
                    _sp.TENSP = txtTenSP.Text;
                    _sp.DONGIA = double.Parse(txtDonGia.Text);
                    sp.Them(_sp);
                    MessageBox.Show("Thêm Thành Công");
                    loadData();
                }
                else
                {
                    MessageBox.Show("Mời Bạn Nhập Đầy Đủ Thông Tin");
                }
                them = !them;
            }
            else if (xoa)
            {
                if (gridView1.RowCount>0)
                {
                    string masp = gridView1.GetFocusedRowCellValue("MASP").ToString();
                    sp.Xoa(masp);
                    loadData();
                    MessageBox.Show("Xóa Thành Công");
                }
                else
                {
                    MessageBox.Show("Mời Bạn Chọn Sản Phẩm trên Lưới Để Xóa");
                    return;
                }
                xoa = !xoa;
            }
            else if(sua)
            {
                if (!string.IsNullOrWhiteSpace(txtMa.Text) || !string.IsNullOrWhiteSpace(txtTenSP.Text) || !string.IsNullOrWhiteSpace(txtDonGia.Text))
                {
                    sp.Edit(txtMa.Text, txtTenSP.Text, double.Parse(txtDonGia.Text));
                    loadData();
                    MessageBox.Show("Sửa Thành Công");
                }
            }    
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            TatVaMoControl(true);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            DataTable tb = new DataTable();
            string path;
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "Chọn file Excel";
            op.Filter = "Excel(*.xlsx)|*.xlsx";
            if (op.ShowDialog() == DialogResult.OK)
            {
                path = op.FileName;
                ExcelApp.Application excelApp = new ExcelApp.Application();
                DataRow myNewRow;
                DataTable myTable;


                if (excelApp == null)
                {
                    Console.WriteLine("Excel is not installed!!");
                    return;
                }

                //
                ExcelApp.Workbook excelBook = excelApp.Workbooks.Open(path);
                ExcelApp._Worksheet excelSheet = excelBook.Sheets[1];
                ExcelApp.Range excelRange = excelSheet.UsedRange;

                int rows = excelRange.Rows.Count;
                int cols = excelRange.Columns.Count;

                //Set DataTable Name and Columns Name
                myTable = new DataTable("MyDataTable");
                myTable.Columns.Add("MASP", typeof(string));
                myTable.Columns.Add("TENSP", typeof(string));
                myTable.Columns.Add("DONGIA", typeof(double));
               

                //first row using for heading, start second row for data
                for (int i = 2; i <= rows; i++)
                {
                    myNewRow = myTable.NewRow();
                    myNewRow["MASP"] = excelRange.Cells[i, 1].Value2.ToString(); //string
                    myNewRow["TENSP"] = excelRange.Cells[i, 2].Value2.ToString(); //string
                    myNewRow["DONGIA"] = excelRange.Cells[i, 3].Value2.ToString(); //integer
               
                    myTable.Rows.Add(myNewRow);
                }

                // Thêm và duyệt list ở đây
                foreach (DataRow dr in myTable.Rows)
                {
                    //Console.WriteLine("First Name : {0}\t Last Name : {1} \t Age : {2} \t", dr[0], dr[1], dr[2]);
                    SanPham _sp = new SanPham();
                    _sp.MASP = dr[0].ToString();
                    _sp.TENSP = dr[1].ToString();
                    _sp.DONGIA = double.Parse(dr[2].ToString());
                    // MessageBox.Show($"MAKH {dr[0]} TenKH {dr[1]} CMND {dr[2]} dienthoai {dr[3]} email {dr[4]} dia chi {dr[5]}");
                    sp.Them(_sp);
                }
                //after reading, relaase the excel project
                excelApp.Quit();
                System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);
            }
            loadData();
            MessageBox.Show("Thêm Thành Công");
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}