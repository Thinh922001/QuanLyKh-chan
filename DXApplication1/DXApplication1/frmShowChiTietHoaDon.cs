using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DXApplication1
{
    public partial class frmShowChiTietHoaDon : DevExpress.XtraEditors.XtraForm
    {

        string sqlconnectstring = @"Data Source=DELL;
                             Initial Catalog=QL_Khach_San;
                             User ID=sa;Password=sa2019";
        rptChiTietHoaDon rpt;
        SqlCommand lenh = new SqlCommand();
        void taoKetNoi()
        {
          
            

        }
        public frmShowChiTietHoaDon()
        {

            InitializeComponent();
        }

        private void frmShowChiTietHoaDon_Load(object sender, EventArgs e)
        {
            string sqlconnectstring = @"Data Source=DELL;
                             Initial Catalog=QL_Khach_San;
                             User ID=sa;Password=sa2019";
            var connection = new SqlConnection(sqlconnectstring);

            SqlDataAdapter da = new SqlDataAdapter(lenh);
            lenh.CommandType = CommandType.StoredProcedure;
            lenh.Connection = connection;
            lenh.CommandText = "PHIEUDATPHONG";
            lenh.Parameters.Clear();
            lenh.Parameters.AddWithValue("@MADATPHONG", TryVanDuLieu.madatphong);
            DataTable dt = new DataTable();
            da.SelectCommand = lenh;
            da.Fill(dt);
            rpt = new rptChiTietHoaDon();
            rpt.SetDataSource(dt);
            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.DisplayStatusBar = false;
            crystalReportViewer1.DisplayToolbar = true;
            rpt.SetDatabaseLogon("sa", "sa2019", "DELL", "QL_Khach_San");
            crystalReportViewer1.Refresh();
        }
    }
}