
namespace DXApplication1
{
    partial class frmloaiphong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmloaiphong));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnThem = new System.Windows.Forms.ToolStripButton();
            this.btnXoa = new System.Windows.Forms.ToolStripButton();
            this.btnSua = new System.Windows.Forms.ToolStripButton();
            this.btnLuu = new System.Windows.Forms.ToolStripButton();
            this.btnIn = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.dsLoaiPhong = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaLP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenLP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoNguoi1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoGiuong1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DonGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.soGiuong = new DevExpress.XtraEditors.SpinEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.soNguoi = new DevExpress.XtraEditors.SpinEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.txtenPhong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaLP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsLoaiPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.soGiuong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soNguoi.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThem,
            this.btnXoa,
            this.btnSua,
            this.btnLuu,
            this.btnIn,
            this.toolStripButton1,
            this.toolStripButton6});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1211, 59);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnThem
            // 
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(50, 56);
            this.btnThem.Text = "Thêm";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(39, 56);
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(38, 56);
            this.btnSua.Text = "Sữa";
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(37, 56);
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnIn
            // 
            this.btnIn.Image = ((System.Drawing.Image)(resources.GetObject("btnIn.Image")));
            this.btnIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(59, 56);
            this.btnIn.Text = "Xem In";
            this.btnIn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(69, 56);
            this.toolStripButton1.Text = "Bỏ Chọn";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(51, 56);
            this.toolStripButton6.Text = "Thoát";
            this.toolStripButton6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton6.Click += new System.EventHandler(this.toolStripButton6_Click);
            // 
            // dsLoaiPhong
            // 
            this.dsLoaiPhong.Location = new System.Drawing.Point(0, 69);
            this.dsLoaiPhong.MainView = this.gridView1;
            this.dsLoaiPhong.Name = "dsLoaiPhong";
            this.dsLoaiPhong.Size = new System.Drawing.Size(1211, 296);
            this.dsLoaiPhong.TabIndex = 1;
            this.dsLoaiPhong.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.dsLoaiPhong.Click += new System.EventHandler(this.dsLoaiPhong_Click);
            this.dsLoaiPhong.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dsLoaiPhong_MouseClick);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaLP,
            this.TenLP,
            this.SoNguoi1,
            this.SoGiuong1,
            this.DonGia});
            this.gridView1.GridControl = this.dsLoaiPhong;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AlignGroupSummaryInGroupRow = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // MaLP
            // 
            this.MaLP.Caption = "Mã Loại Phòng";
            this.MaLP.FieldName = "MaLP";
            this.MaLP.MinWidth = 25;
            this.MaLP.Name = "MaLP";
            this.MaLP.Visible = true;
            this.MaLP.VisibleIndex = 0;
            this.MaLP.Width = 94;
            // 
            // TenLP
            // 
            this.TenLP.Caption = "Tên Loại Phòng";
            this.TenLP.FieldName = "TenPhong";
            this.TenLP.MinWidth = 25;
            this.TenLP.Name = "TenLP";
            this.TenLP.Visible = true;
            this.TenLP.VisibleIndex = 1;
            this.TenLP.Width = 94;
            // 
            // SoNguoi1
            // 
            this.SoNguoi1.Caption = "Số Người";
            this.SoNguoi1.FieldName = "SoNguoi";
            this.SoNguoi1.MinWidth = 25;
            this.SoNguoi1.Name = "SoNguoi1";
            this.SoNguoi1.Visible = true;
            this.SoNguoi1.VisibleIndex = 2;
            this.SoNguoi1.Width = 94;
            // 
            // SoGiuong1
            // 
            this.SoGiuong1.Caption = "Số Giường";
            this.SoGiuong1.FieldName = "SoGiuong";
            this.SoGiuong1.MinWidth = 25;
            this.SoGiuong1.Name = "SoGiuong1";
            this.SoGiuong1.Visible = true;
            this.SoGiuong1.VisibleIndex = 3;
            this.SoGiuong1.Width = 94;
            // 
            // DonGia
            // 
            this.DonGia.Caption = "Đơn Giá";
            this.DonGia.FieldName = "DonGia";
            this.DonGia.MinWidth = 25;
            this.DonGia.Name = "DonGia";
            this.DonGia.Visible = true;
            this.DonGia.VisibleIndex = 4;
            this.DonGia.Width = 94;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtDonGia);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.soGiuong);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.soNguoi);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.txtenPhong);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.txtMaLP);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 362);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1211, 192);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Loại Phòng";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(702, 106);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(249, 23);
            this.txtDonGia.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(615, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Đơn Giá";
            // 
            // soGiuong
            // 
            this.soGiuong.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.soGiuong.Location = new System.Drawing.Point(452, 105);
            this.soGiuong.Name = "soGiuong";
            this.soGiuong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.soGiuong.Size = new System.Drawing.Size(109, 24);
            this.soGiuong.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(316, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Số Giường";
            // 
            // soNguoi
            // 
            this.soNguoi.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.soNguoi.Location = new System.Drawing.Point(143, 105);
            this.soNguoi.Name = "soNguoi";
            this.soNguoi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.soNguoi.Size = new System.Drawing.Size(83, 24);
            this.soNguoi.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Số Người";
            // 
            // txtenPhong
            // 
            this.txtenPhong.Location = new System.Drawing.Point(452, 48);
            this.txtenPhong.Name = "txtenPhong";
            this.txtenPhong.Size = new System.Drawing.Size(754, 23);
            this.txtenPhong.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(316, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Loại Phòng";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtMaLP
            // 
            this.txtMaLP.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtMaLP.Location = new System.Drawing.Point(143, 45);
            this.txtMaLP.Name = "txtMaLP";
            this.txtMaLP.Size = new System.Drawing.Size(83, 23);
            this.txtMaLP.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Loại Phòng";
            // 
            // frmloaiphong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 554);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.dsLoaiPhong);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmloaiphong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "loaiPhong";
            this.Load += new System.EventHandler(this.frmloaiphong_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsLoaiPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.soGiuong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soNguoi.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnThem;
        private System.Windows.Forms.ToolStripButton btnXoa;
        private System.Windows.Forms.ToolStripButton btnSua;
        private System.Windows.Forms.ToolStripButton btnLuu;
        private System.Windows.Forms.ToolStripButton btnIn;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private DevExpress.XtraGrid.GridControl dsLoaiPhong;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SpinEdit soNguoi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtenPhong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaLP;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SpinEdit soGiuong;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraGrid.Columns.GridColumn MaLP;
        private DevExpress.XtraGrid.Columns.GridColumn TenLP;
        private DevExpress.XtraGrid.Columns.GridColumn SoNguoi1;
        private DevExpress.XtraGrid.Columns.GridColumn SoGiuong1;
        private DevExpress.XtraGrid.Columns.GridColumn DonGia;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}