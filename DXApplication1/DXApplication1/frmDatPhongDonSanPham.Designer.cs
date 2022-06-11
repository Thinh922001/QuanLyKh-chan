
namespace DXApplication1
{
    partial class frmDatPhongDonSanPham
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDatPhongDonSanPham));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnThem = new System.Windows.Forms.ToolStripButton();
            this.btnIn = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.dsSanPham = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MASP1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenSP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DonGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl5 = new DevExpress.XtraEditors.GroupControl();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.lbTongTien = new System.Windows.Forms.Label();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.gcSPDV = new DevExpress.XtraGrid.GridControl();
            this.gridView5 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Phong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MAPH1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.label1 = new System.Windows.Forms.Label();
            this.SoNgayThue = new DevExpress.XtraEditors.SpinEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.soNguoi = new DevExpress.XtraEditors.SpinEdit();
            this.label9 = new System.Windows.Forms.Label();
            this.cboKhachHang = new System.Windows.Forms.ComboBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.rdbChuaThanhToan = new System.Windows.Forms.RadioButton();
            this.rdbThanhToan = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).BeginInit();
            this.groupControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcSPDV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SoNgayThue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soNguoi.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThem,
            this.btnIn,
            this.toolStripButton6});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1061, 59);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnThem
            // 
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(37, 56);
            this.btnThem.Text = "Lưu";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnIn
            // 
            this.btnIn.Image = ((System.Drawing.Image)(resources.GetObject("btnIn.Image")));
            this.btnIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(36, 56);
            this.btnIn.Text = "In";
            this.btnIn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(51, 56);
            this.toolStripButton6.Text = "Thoát";
            this.toolStripButton6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 59);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.groupControl2);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.groupControl5);
            this.splitContainerControl1.Panel2.Controls.Add(this.groupControl4);
            this.splitContainerControl1.Panel2.Controls.Add(this.groupControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1061, 692);
            this.splitContainerControl1.SplitterPosition = 410;
            this.splitContainerControl1.TabIndex = 3;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.dsSanPham);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(410, 692);
            this.groupControl2.TabIndex = 3;
            this.groupControl2.Text = "Danh Sách Dịch Vụ";
            // 
            // dsSanPham
            // 
            this.dsSanPham.AllowDrop = true;
            this.dsSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dsSanPham.Location = new System.Drawing.Point(2, 28);
            this.dsSanPham.MainView = this.gridView3;
            this.dsSanPham.Name = "dsSanPham";
            this.dsSanPham.Size = new System.Drawing.Size(406, 662);
            this.dsSanPham.TabIndex = 0;
            this.dsSanPham.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MASP1,
            this.TenSP,
            this.DonGia});
            this.gridView3.GridControl = this.dsSanPham;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsBehavior.Editable = false;
            this.gridView3.Click += new System.EventHandler(this.gridView3_Click);
            // 
            // MASP1
            // 
            this.MASP1.Caption = "Mã Sản Phẩm";
            this.MASP1.FieldName = "MASP";
            this.MASP1.MinWidth = 25;
            this.MASP1.Name = "MASP1";
            this.MASP1.Visible = true;
            this.MASP1.VisibleIndex = 0;
            this.MASP1.Width = 94;
            // 
            // TenSP
            // 
            this.TenSP.Caption = "Tên Sản Phẩm";
            this.TenSP.FieldName = "TENSP";
            this.TenSP.MinWidth = 25;
            this.TenSP.Name = "TenSP";
            this.TenSP.Visible = true;
            this.TenSP.VisibleIndex = 1;
            this.TenSP.Width = 94;
            // 
            // DonGia
            // 
            this.DonGia.Caption = "Đơn Giá";
            this.DonGia.FieldName = "DONGIA";
            this.DonGia.MinWidth = 25;
            this.DonGia.Name = "DonGia";
            this.DonGia.Visible = true;
            this.DonGia.VisibleIndex = 2;
            this.DonGia.Width = 94;
            // 
            // groupControl5
            // 
            this.groupControl5.Controls.Add(this.txtTongTien);
            this.groupControl5.Controls.Add(this.lbTongTien);
            this.groupControl5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl5.Location = new System.Drawing.Point(0, 573);
            this.groupControl5.Name = "groupControl5";
            this.groupControl5.Size = new System.Drawing.Size(639, 119);
            this.groupControl5.TabIndex = 4;
            this.groupControl5.Text = "Thanh Toán";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(173, 46);
            this.txtTongTien.Multiline = true;
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(397, 51);
            this.txtTongTien.TabIndex = 1;
            // 
            // lbTongTien
            // 
            this.lbTongTien.AutoSize = true;
            this.lbTongTien.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongTien.ForeColor = System.Drawing.Color.Lime;
            this.lbTongTien.Location = new System.Drawing.Point(5, 57);
            this.lbTongTien.Name = "lbTongTien";
            this.lbTongTien.Size = new System.Drawing.Size(162, 40);
            this.lbTongTien.TabIndex = 0;
            this.lbTongTien.Text = "Tổng Tiền";
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.gcSPDV);
            this.groupControl4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl4.Location = new System.Drawing.Point(0, 328);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(639, 245);
            this.groupControl4.TabIndex = 3;
            this.groupControl4.Text = "Danh Sách Sản Phẩm Dịch Vụ";
            // 
            // gcSPDV
            // 
            this.gcSPDV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcSPDV.Location = new System.Drawing.Point(2, 28);
            this.gcSPDV.MainView = this.gridView5;
            this.gcSPDV.Name = "gcSPDV";
            this.gcSPDV.Size = new System.Drawing.Size(635, 215);
            this.gcSPDV.TabIndex = 0;
            this.gcSPDV.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView5});
            // 
            // gridView5
            // 
            this.gridView5.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Phong,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn2,
            this.MAPH1,
            this.gridColumn9});
            this.gridView5.GridControl = this.gcSPDV;
            this.gridView5.Name = "gridView5";
            this.gridView5.OptionsView.ShowFooter = true;
            this.gridView5.DoubleClick += new System.EventHandler(this.gridView5_DoubleClick);
            // 
            // Phong
            // 
            this.Phong.Caption = "Tên Phòng";
            this.Phong.FieldName = "tenPH";
            this.Phong.MinWidth = 25;
            this.Phong.Name = "Phong";
            this.Phong.Visible = true;
            this.Phong.VisibleIndex = 0;
            this.Phong.Width = 94;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Sản Phẩm ";
            this.gridColumn3.FieldName = "TenSP";
            this.gridColumn3.MinWidth = 25;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            this.gridColumn3.Width = 94;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Số Lượng";
            this.gridColumn4.FieldName = "soLuong";
            this.gridColumn4.MinWidth = 25;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "soLuong", "{0:0.##}")});
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            this.gridColumn4.Width = 94;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Đơn Giá";
            this.gridColumn5.FieldName = "donGia";
            this.gridColumn5.MinWidth = 25;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 3;
            this.gridColumn5.Width = 94;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Thành Tiền";
            this.gridColumn2.FieldName = "thanhTien";
            this.gridColumn2.MinWidth = 25;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "thanhTien", "{0:n0}")});
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 4;
            this.gridColumn2.Width = 94;
            // 
            // MAPH1
            // 
            this.MAPH1.Caption = "Mã phòng";
            this.MAPH1.FieldName = "MaPH";
            this.MAPH1.MinWidth = 25;
            this.MAPH1.Name = "MAPH1";
            this.MAPH1.Width = 94;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "MaSP";
            this.gridColumn9.FieldName = "MASP";
            this.gridColumn9.MinWidth = 25;
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 5;
            this.gridColumn9.Width = 94;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.SoNgayThue);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.soNguoi);
            this.groupControl1.Controls.Add(this.label9);
            this.groupControl1.Controls.Add(this.cboKhachHang);
            this.groupControl1.Controls.Add(this.txtGhiChu);
            this.groupControl1.Controls.Add(this.label7);
            this.groupControl1.Controls.Add(this.button1);
            this.groupControl1.Controls.Add(this.rdbChuaThanhToan);
            this.groupControl1.Controls.Add(this.rdbThanhToan);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(639, 328);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Thông Tin Đặt Phòng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(105, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 29);
            this.label1.TabIndex = 29;
            this.label1.Text = "Thông Tin";
            // 
            // SoNgayThue
            // 
            this.SoNgayThue.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.SoNgayThue.Location = new System.Drawing.Point(483, 163);
            this.SoNgayThue.Name = "SoNgayThue";
            this.SoNgayThue.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.SoNgayThue.Size = new System.Drawing.Size(125, 24);
            this.SoNgayThue.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(327, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 17);
            this.label4.TabIndex = 27;
            this.label4.Text = "Số Ngày Thuê";
            // 
            // soNguoi
            // 
            this.soNguoi.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.soNguoi.Location = new System.Drawing.Point(159, 166);
            this.soNguoi.Name = "soNguoi";
            this.soNguoi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.soNguoi.Size = new System.Drawing.Size(125, 24);
            this.soNguoi.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(43, 173);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 17);
            this.label9.TabIndex = 25;
            this.label9.Text = "Số Người";
            // 
            // cboKhachHang
            // 
            this.cboKhachHang.FormattingEnabled = true;
            this.cboKhachHang.Location = new System.Drawing.Point(159, 91);
            this.cboKhachHang.Name = "cboKhachHang";
            this.cboKhachHang.Size = new System.Drawing.Size(327, 24);
            this.cboKhachHang.TabIndex = 24;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(170, 286);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(327, 23);
            this.txtGhiChu.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 292);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 17);
            this.label7.TabIndex = 22;
            this.label7.Text = "Ghi Chú";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(533, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // rdbChuaThanhToan
            // 
            this.rdbChuaThanhToan.AutoSize = true;
            this.rdbChuaThanhToan.Location = new System.Drawing.Point(320, 232);
            this.rdbChuaThanhToan.Name = "rdbChuaThanhToan";
            this.rdbChuaThanhToan.Size = new System.Drawing.Size(140, 21);
            this.rdbChuaThanhToan.TabIndex = 20;
            this.rdbChuaThanhToan.TabStop = true;
            this.rdbChuaThanhToan.Text = "Chưa Thanh Toán";
            this.rdbChuaThanhToan.UseVisualStyleBackColor = true;
            // 
            // rdbThanhToan
            // 
            this.rdbThanhToan.AutoSize = true;
            this.rdbThanhToan.Location = new System.Drawing.Point(173, 232);
            this.rdbThanhToan.Name = "rdbThanhToan";
            this.rdbThanhToan.Size = new System.Drawing.Size(124, 21);
            this.rdbThanhToan.TabIndex = 19;
            this.rdbThanhToan.TabStop = true;
            this.rdbThanhToan.Text = "Đã Thanh Toán";
            this.rdbThanhToan.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Thanh Toán";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Khách Hàng";
            // 
            // frmDatPhongDonSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 751);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmDatPhongDonSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDatPhongDonSanPham";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmDatPhongDonSanPham_FormClosed);
            this.Load += new System.EventHandler(this.frmDatPhongDonSanPham_Load);
            this.Leave += new System.EventHandler(this.frmDatPhongDonSanPham_Leave);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).EndInit();
            this.groupControl5.ResumeLayout(false);
            this.groupControl5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcSPDV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SoNgayThue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soNguoi.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnThem;
        private System.Windows.Forms.ToolStripButton btnIn;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl dsSanPham;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn MASP1;
        private DevExpress.XtraGrid.Columns.GridColumn TenSP;
        private DevExpress.XtraGrid.Columns.GridColumn DonGia;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SpinEdit SoNgayThue;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.SpinEdit soNguoi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboKhachHang;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rdbChuaThanhToan;
        private System.Windows.Forms.RadioButton rdbThanhToan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraGrid.GridControl gcSPDV;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView5;
        private DevExpress.XtraGrid.Columns.GridColumn Phong;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn MAPH1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraEditors.GroupControl groupControl5;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label lbTongTien;
    }
}