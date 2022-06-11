
namespace DXApplication1
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup3 = new DevExpress.XtraNavBar.NavBarGroup();
            this.tang = new DevExpress.XtraNavBar.NavBarItem();
            this.phong = new DevExpress.XtraNavBar.NavBarItem();
            this.loaiphong = new DevExpress.XtraNavBar.NavBarItem();
            this.sanpham = new DevExpress.XtraNavBar.NavBarItem();
            this.thietbi = new DevExpress.XtraNavBar.NavBarItem();
            this.khachhang = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup2 = new DevExpress.XtraNavBar.NavBarGroup();
            this.matkhau = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.datphong = new DevExpress.XtraNavBar.NavBarItem();
            this.baocao = new DevExpress.XtraNavBar.NavBarItem();
            this.galleryControl1 = new DevExpress.XtraBars.Ribbon.GalleryControl();
            this.galleryControlClient1 = new DevExpress.XtraBars.Ribbon.GalleryControlClient();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.btndatphong = new DevExpress.XtraBars.BarButtonItem();
            this.btnthanhtoan = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryControl1)).BeginInit();
            this.galleryControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1223, 59);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(78, 56);
            this.toolStripButton1.Text = "Hệ Thống";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(76, 56);
            this.toolStripButton2.Text = "Thống Kê";
            this.toolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(51, 56);
            this.toolStripButton3.Text = "Thoát";
            this.toolStripButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 59);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.navBarControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.galleryControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1223, 426);
            this.splitContainerControl1.SplitterPosition = 179;
            this.splitContainerControl1.TabIndex = 1;
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navBarGroup3;
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup3,
            this.navBarGroup2,
            this.navBarGroup1});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.tang,
            this.phong,
            this.loaiphong,
            this.sanpham,
            this.thietbi,
            this.khachhang,
            this.matkhau,
            this.datphong,
            this.baocao});
            this.navBarControl1.Location = new System.Drawing.Point(0, 0);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 179;
            this.navBarControl1.Size = new System.Drawing.Size(179, 426);
            this.navBarControl1.TabIndex = 0;
            this.navBarControl1.Text = "navBarControl1";
            this.navBarControl1.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarControl1_LinkClicked);
            this.navBarControl1.Click += new System.EventHandler(this.navBarControl1_Click);
            // 
            // navBarGroup3
            // 
            this.navBarGroup3.Caption = "Quản Lý";
            this.navBarGroup3.Expanded = true;
            this.navBarGroup3.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("navBarGroup3.ImageOptions.SvgImage")));
            this.navBarGroup3.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.tang),
            new DevExpress.XtraNavBar.NavBarItemLink(this.phong),
            new DevExpress.XtraNavBar.NavBarItemLink(this.loaiphong),
            new DevExpress.XtraNavBar.NavBarItemLink(this.sanpham),
            new DevExpress.XtraNavBar.NavBarItemLink(this.thietbi),
            new DevExpress.XtraNavBar.NavBarItemLink(this.khachhang)});
            this.navBarGroup3.Name = "navBarGroup3";
            // 
            // tang
            // 
            this.tang.Caption = "Tầng ";
            this.tang.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("tang.ImageOptions.LargeImage")));
            this.tang.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("tang.ImageOptions.SmallImage")));
            this.tang.Name = "tang";
            // 
            // phong
            // 
            this.phong.Caption = "Phòng";
            this.phong.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("phong.ImageOptions.LargeImage")));
            this.phong.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("phong.ImageOptions.SmallImage")));
            this.phong.Name = "phong";
            // 
            // loaiphong
            // 
            this.loaiphong.Caption = "Loại Phòng";
            this.loaiphong.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("loaiphong.ImageOptions.LargeImage")));
            this.loaiphong.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("loaiphong.ImageOptions.SmallImage")));
            this.loaiphong.Name = "loaiphong";
            // 
            // sanpham
            // 
            this.sanpham.Caption = "Sản Phẩm";
            this.sanpham.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("sanpham.ImageOptions.LargeImage")));
            this.sanpham.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("sanpham.ImageOptions.SmallImage")));
            this.sanpham.Name = "sanpham";
            // 
            // thietbi
            // 
            this.thietbi.Caption = "Thiết Bị";
            this.thietbi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("thietbi.ImageOptions.LargeImage")));
            this.thietbi.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("thietbi.ImageOptions.SmallImage")));
            this.thietbi.Name = "thietbi";
            // 
            // khachhang
            // 
            this.khachhang.Caption = "Khách Hàng";
            this.khachhang.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("khachhang.ImageOptions.LargeImage")));
            this.khachhang.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("khachhang.ImageOptions.SmallImage")));
            this.khachhang.Name = "khachhang";
            // 
            // navBarGroup2
            // 
            this.navBarGroup2.Caption = "Hệ Thống";
            this.navBarGroup2.Expanded = true;
            this.navBarGroup2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("navBarGroup2.ImageOptions.SvgImage")));
            this.navBarGroup2.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.matkhau)});
            this.navBarGroup2.Name = "navBarGroup2";
            // 
            // matkhau
            // 
            this.matkhau.Caption = "Thay Đổi Mật Khẩu";
            this.matkhau.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("matkhau.ImageOptions.LargeImage")));
            this.matkhau.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("matkhau.ImageOptions.SmallImage")));
            this.matkhau.Name = "matkhau";
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "Chức Năng";
            this.navBarGroup1.Expanded = true;
            this.navBarGroup1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarGroup1.ImageOptions.LargeImage")));
            this.navBarGroup1.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarGroup1.ImageOptions.SmallImage")));
            this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.datphong),
            new DevExpress.XtraNavBar.NavBarItemLink(this.baocao)});
            this.navBarGroup1.Name = "navBarGroup1";
            // 
            // datphong
            // 
            this.datphong.Caption = "Đặt Phòng";
            this.datphong.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("datphong.ImageOptions.LargeImage")));
            this.datphong.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("datphong.ImageOptions.SmallImage")));
            this.datphong.Name = "datphong";
            // 
            // baocao
            // 
            this.baocao.Caption = "Báo Cáo";
            this.baocao.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("baocao.ImageOptions.LargeImage")));
            this.baocao.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("baocao.ImageOptions.SmallImage")));
            this.baocao.Name = "baocao";
            // 
            // galleryControl1
            // 
            this.galleryControl1.Controls.Add(this.galleryControlClient1);
            this.galleryControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.galleryControl1.Location = new System.Drawing.Point(0, 0);
            this.galleryControl1.Name = "galleryControl1";
            this.barManager1.SetPopupContextMenu(this.galleryControl1, this.popupMenu1);
            this.galleryControl1.Size = new System.Drawing.Size(1032, 426);
            this.galleryControl1.TabIndex = 0;
            this.galleryControl1.Text = "galleryControl1";
            // 
            // galleryControlClient1
            // 
            this.galleryControlClient1.GalleryControl = this.galleryControl1;
            this.galleryControlClient1.Location = new System.Drawing.Point(2, 2);
            this.galleryControlClient1.Size = new System.Drawing.Size(1007, 422);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "output-onlinepngtools (1).png");
            this.imageList1.Images.SetKeyName(1, "output-onlinepngtools.png");
            // 
            // popupMenu1
            // 
            this.popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btndatphong),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnthanhtoan),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem2)});
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            this.popupMenu1.Popup += new System.EventHandler(this.popupMenu1_Popup);
            // 
            // btndatphong
            // 
            this.btndatphong.Caption = "Đặt Phòng";
            this.btndatphong.Id = 0;
            this.btndatphong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btndatphong.ImageOptions.Image")));
            this.btndatphong.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btndatphong.ImageOptions.LargeImage")));
            this.btndatphong.Name = "btndatphong";
            this.btndatphong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btndatphong_ItemClick);
            // 
            // btnthanhtoan
            // 
            this.btnthanhtoan.Caption = "Thanh Toán";
            this.btnthanhtoan.Id = 1;
            this.btnthanhtoan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnthanhtoan.ImageOptions.Image")));
            this.btnthanhtoan.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnthanhtoan.ImageOptions.LargeImage")));
            this.btnthanhtoan.Name = "btnthanhtoan";
            this.btnthanhtoan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnthanhtoan_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Đổi Phòng";
            this.barButtonItem1.Id = 2;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Thêm Và Cập Nhật Dịch Vụ";
            this.barButtonItem2.Id = 3;
            this.barButtonItem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.barButtonItem2.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.LargeImage")));
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btndatphong,
            this.btnthanhtoan,
            this.barButtonItem1,
            this.barButtonItem2});
            this.barManager1.MaxItemId = 4;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1223, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 485);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1223, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 485);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1223, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 485);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 485);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Khách Sạn";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryControl1)).EndInit();
            this.galleryControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup3;
        private DevExpress.XtraNavBar.NavBarItem tang;
        private DevExpress.XtraNavBar.NavBarItem phong;
        private DevExpress.XtraNavBar.NavBarItem loaiphong;
        private DevExpress.XtraNavBar.NavBarItem sanpham;
        private DevExpress.XtraNavBar.NavBarItem thietbi;
        private DevExpress.XtraNavBar.NavBarItem khachhang;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup2;
        private DevExpress.XtraNavBar.NavBarItem matkhau;
        private DevExpress.XtraBars.Ribbon.GalleryControlClient galleryControlClient1;
        private System.Windows.Forms.ImageList imageList1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btndatphong;
        private DevExpress.XtraBars.BarButtonItem btnthanhtoan;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraNavBar.NavBarItem datphong;
        private DevExpress.XtraNavBar.NavBarItem baocao;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        public DevExpress.XtraBars.Ribbon.GalleryControl galleryControl1;
    }
}