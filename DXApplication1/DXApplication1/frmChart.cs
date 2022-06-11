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
    public partial class frmChart : DevExpress.XtraEditors.XtraForm
    {
        CHITIETDATPHONG1 ct;
        DataClasses1DataContext data;
        public frmChart()
        {
            ct = new CHITIETDATPHONG1();
            data = new DataClasses1DataContext();
            InitializeComponent();
        }
       
        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void frmChart_Load(object sender, EventArgs e)
        {
            try
            {
                chart1.DataSource = data.Phongs.ToList();
                chart1.Series["Phong"].XValueMember = "MAPH";
                chart1.Series["Phong"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
                chart1.Series["Phong"].YValueMembers = "DonGia";
                chart1.Series["Phong"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            }
            catch (Exception ex)
            {

                throw new Exception(" "+ex);
            }

        }
    }
}