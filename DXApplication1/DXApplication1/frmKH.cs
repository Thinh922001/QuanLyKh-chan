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
using DevExpress.DataAccess.Excel;
using DevExpress.XtraGrid;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.IO;
using ExcelDataReader;
using OfficeOpenXml;
using ClosedXML.Excel;
using ExcelApp = Microsoft.Office.Interop.Excel;

namespace DXApplication1
{
    public partial class frmKH : DevExpress.XtraEditors.XtraForm
    {
        KHACHHANG kh;
        public frmKH()
        {
            kh = new KHACHHANG();
            InitializeComponent();
        }
        frmDatPhong KHDP = (frmDatPhong)Application.OpenForms["frmDatPhong"];
        frmDatPhongDon KHDPD = (frmDatPhongDon)Application.OpenForms["frmDatPhongDon"];
        frmDatPhongDonSanPham DPSP = (frmDatPhongDonSanPham)Application.OpenForms["frmDatPhongDonSanPham"];
        bool them = false;
        bool sua = false;
        bool xoa = false;
        string makh;
        string tenkh;
        string CC;
        string sdt;
        string diachi;
        string email;
        bool chechkNullValues()
        {
            if (string.IsNullOrEmpty(makh) || string.IsNullOrEmpty(CC) || string.IsNullOrEmpty(diachi) || string.IsNullOrEmpty(sdt) || string.IsNullOrEmpty(email))
                return false;
            return true;
        }
        void loadKhachHang()
        {
            gridControl1.DataSource = kh.getAllKhachHang();
        } 
        void loadTextBox()
        {
            txtMakH.Text = gridView1.GetFocusedRowCellValue("MAKH").ToString();
            txtTenKH.Text = gridView1.GetFocusedRowCellValue("TenKH").ToString();
            txtCC.Text = gridView1.GetFocusedRowCellValue("CMND").ToString();
            txtDiaChi.Text = gridView1.GetFocusedRowCellValue("DiaChi").ToString();
            txtEmail.Text = gridView1.GetFocusedRowCellValue("Email").ToString();
            txtSDT.Text = gridView1.GetFocusedRowCellValue("DienThoai").ToString();
           
        }
        void clearAllTextBox()
        {
            txtTenKH.Text = "";
            txtSDT.Text = "";
            txtEmail.Text = "";
            txtCC.Text = "";
            txtDiaChi.Text = "";
            txtMakH.Text = "";
        }
        void Enable(bool t)
        {
            txtDiaChi.Enabled = t;
            txtEmail.Enabled = t;
            txtTenKH.Enabled = t;
            txtSDT.Enabled = t;
            txtCC.Enabled = t;
            txtMakH.Enabled = t;
        }

        void TatVaMoControl(bool t)
        {
            btnThem.Enabled = t;
            btnSua.Enabled = t;
            btnXoa.Enabled = t;
            btnIn.Enabled = t;
            btnLuu.Enabled = !t;
            toolStripButton1.Enabled = !t;
        }
        private void frmKH_Load(object sender, EventArgs e)
        {
            loadKhachHang();
            TatVaMoControl(true);
            Enable(false);
            
        }
        void GanGiaTri()
        {
            makh = txtMakH.Text;
            tenkh = txtTenKH.Text;
            diachi = txtDiaChi.Text;
            sdt = txtSDT.Text;
            email = txtEmail.Text;
            CC = txtCC.Text;
        }
        private void gridControl1_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount>0)
            {
                loadTextBox();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            TatVaMoControl(false);
            Enable(true);
            them = !them;
            clearAllTextBox();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            TatVaMoControl(false);
            Enable(false);
            xoa = !xoa;

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            TatVaMoControl(false);
            Enable(true);
            txtMakH.Enabled = false;
            sua = !sua;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            TatVaMoControl(true);
            Enable(false);
            if (them)
            {
                //GanGiaTri();
                string makh = txtMakH.Text;
                string tenkh = txtTenKH.Text;
                string diachi = txtDiaChi.Text;
                string email = txtEmail.Text;
                string txtCanCuoc = txtCC.Text;
                string sdt = txtSDT.Text;
                KhachHang kh1 = new KhachHang(makh,tenkh,txtCanCuoc,diachi,email,sdt);
                    kh.Them(kh1);
                    MessageBox.Show("Thêm Thành Công");
                    loadKhachHang();
                    them = !them;
            }
            else if (sua)
            {
                GanGiaTri();
                txtMakH.Enabled = true;
               
                kh.Edit(txtMakH.Text, txtTenKH.Text, txtCC.Text, txtSDT.Text, txtEmail.Text,txtDiaChi.Text);
                sua = !sua;
            }
            else if(xoa)
            {
                if (gridView1.RowCount>0)
                {
                    string makh = gridView1.GetFocusedRowCellValue("MAKH").ToString();
                    kh.Delete(makh);
                    MessageBox.Show("Xóa Thành Công");
                    loadKhachHang();
                }
                else
                {
                    MessageBox.Show("Hãy chọn nhân viên cần xóa");
                }
                xoa = !xoa;
            }    
        }

        private void btnIn_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            TatVaMoControl(true);
            Enable(false);
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            if (gridView1.GetFocusedRowCellValue("MAKH")!=null&&KHDP!=null)
            {
                KHDP.loadKH();
                KHDP.setKhachHang(gridView1.GetFocusedRowCellValue("MAKH").ToString());
                this.Close();
            }
            else if(gridView1.GetFocusedRowCellValue("MAKH") != null && KHDPD != null)
            {
                KHDPD.loadKH();
                KHDPD.setKhachHang(gridView1.GetFocusedRowCellValue("MAKH").ToString());
                this.Close();
            }
            else if(gridView1.GetFocusedRowCellValue("MAKH") != null && DPSP != null)
            {
                DPSP.loadKH();
                DPSP.setKhachHang(gridView1.GetFocusedRowCellValue("MAKH").ToString());
                this.Close();
            }    
            
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
           
            DataTable tb = new DataTable();
            string path;
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "Chọn file Excel";
            op.Filter = "Excel(*.xlsx)|*.xlsx";
            if (op.ShowDialog()==DialogResult.OK)
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
                myTable.Columns.Add("MAKH", typeof(string));
                myTable.Columns.Add("TENKH", typeof(string));
                myTable.Columns.Add("CMND", typeof(string));
                myTable.Columns.Add("DIENTHOAI", typeof(string));
                myTable.Columns.Add("EMAIL", typeof(string));
                myTable.Columns.Add("DIACHI", typeof(string));

                //first row using for heading, start second row for data
                for (int i = 2; i <= rows; i++)
                {
                    myNewRow = myTable.NewRow();
                    myNewRow["MAKH"] = excelRange.Cells[i, 1].Value2.ToString(); //string
                    myNewRow["TENKH"] = excelRange.Cells[i, 2].Value2.ToString(); //string
                    myNewRow["CMND"] = excelRange.Cells[i, 3].Value2.ToString(); //integer
                    myNewRow["DIENTHOAI"] = excelRange.Cells[i, 4].Value2.ToString();
                    myNewRow["EMAIL"] = excelRange.Cells[i, 5].Value2.ToString();
                    myNewRow["DIACHI"] = excelRange.Cells[i, 6].Value2.ToString();
                    myTable.Rows.Add(myNewRow);
                }

                // Thêm và duyệt list ở đây
                foreach (DataRow dr in myTable.Rows)
                {
                    //Console.WriteLine("First Name : {0}\t Last Name : {1} \t Age : {2} \t", dr[0], dr[1], dr[2]);
                    KhachHang khachHang = new KhachHang(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[5].ToString(), dr[4].ToString(), dr[3].ToString());
                    // MessageBox.Show($"MAKH {dr[0]} TenKH {dr[1]} CMND {dr[2]} dienthoai {dr[3]} email {dr[4]} dia chi {dr[5]}");
                    kh.Them(khachHang);
                }


                //after reading, relaase the excel project
                excelApp.Quit();
                System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);

                

            }
            loadKhachHang();
            MessageBox.Show("Thêm Thành Công");
           
        }
       
       
    }
}