namespace NHANSU
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnDanToc = new DevExpress.XtraBars.BarButtonItem();
            this.btnTonGiao = new DevExpress.XtraBars.BarButtonItem();
            this.btnTrinhDo = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnNhanVien = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhongBan = new DevExpress.XtraBars.BarButtonItem();
            this.btnHopDong = new DevExpress.XtraBars.BarButtonItem();
            this.btnKhenThuong = new DevExpress.XtraBars.BarButtonItem();
            this.btnDieuChuyen = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoiViec = new DevExpress.XtraBars.BarButtonItem();
            this.btnUngLuong = new DevExpress.XtraBars.BarButtonItem();
            this.tbnDoiMatKhau = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.BtnPhucHoiDuLieu = new DevExpress.XtraBars.BarButtonItem();
            this.btnSaoLuuDuLieu = new DevExpress.XtraBars.BarButtonItem();
            this.btnCongTy = new DevExpress.XtraBars.BarButtonItem();
            this.btnBoPhan = new DevExpress.XtraBars.BarButtonItem();
            this.btnChucVu = new DevExpress.XtraBars.BarButtonItem();
            this.btnQuanLyLuong = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbon_DANH_MUC_CHUNG = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbon_NGHIEP_VU = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.documentManager1 = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.tabbedView1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(45, 49, 45, 49);
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnDanToc,
            this.btnTonGiao,
            this.btnTrinhDo,
            this.barButtonItem1,
            this.btnNhanVien,
            this.btnPhongBan,
            this.btnHopDong,
            this.btnKhenThuong,
            this.btnDieuChuyen,
            this.btnThoiViec,
            this.btnUngLuong,
            this.tbnDoiMatKhau,
            this.btnThoat,
            this.BtnPhucHoiDuLieu,
            this.btnSaoLuuDuLieu,
            this.btnCongTy,
            this.btnBoPhan,
            this.btnChucVu,
            this.btnQuanLyLuong});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(5);
            this.ribbonControl1.MaxItemId = 29;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.OptionsMenuMinWidth = 495;
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage2});
            this.ribbonControl1.Size = new System.Drawing.Size(1587, 193);
            // 
            // btnDanToc
            // 
            this.btnDanToc.Caption = "Dân tộc";
            this.btnDanToc.Id = 1;
            this.btnDanToc.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDanToc.ImageOptions.SvgImage")));
            this.btnDanToc.Name = "btnDanToc";
            this.btnDanToc.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnDanToc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDanToc_ItemClick);
            // 
            // btnTonGiao
            // 
            this.btnTonGiao.Caption = "Tôn giáo";
            this.btnTonGiao.Id = 2;
            this.btnTonGiao.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnTonGiao.ImageOptions.SvgImage")));
            this.btnTonGiao.Name = "btnTonGiao";
            this.btnTonGiao.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnTonGiao.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTonGiao_ItemClick);
            // 
            // btnTrinhDo
            // 
            this.btnTrinhDo.Caption = "Trình Độ";
            this.btnTrinhDo.Id = 3;
            this.btnTrinhDo.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnTrinhDo.ImageOptions.SvgImage")));
            this.btnTrinhDo.Name = "btnTrinhDo";
            this.btnTrinhDo.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnTrinhDo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTrinhDo_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Nhân Viên";
            this.barButtonItem1.Id = 4;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.Caption = "Nhân Viên";
            this.btnNhanVien.Id = 5;
            this.btnNhanVien.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnNhanVien.ImageOptions.SvgImage")));
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnNhanVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNhanVien_ItemClick);
            // 
            // btnPhongBan
            // 
            this.btnPhongBan.Caption = "Phòng Ban";
            this.btnPhongBan.Id = 6;
            this.btnPhongBan.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPhongBan.ImageOptions.SvgImage")));
            this.btnPhongBan.Name = "btnPhongBan";
            this.btnPhongBan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhongBan_ItemClick);
            // 
            // btnHopDong
            // 
            this.btnHopDong.Caption = "Hợp Đồng";
            this.btnHopDong.Id = 7;
            this.btnHopDong.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnHopDong.ImageOptions.SvgImage")));
            this.btnHopDong.Name = "btnHopDong";
            this.btnHopDong.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnHopDong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHopDong_ItemClick);
            // 
            // btnKhenThuong
            // 
            this.btnKhenThuong.Caption = "Khen Thưởng";
            this.btnKhenThuong.Id = 8;
            this.btnKhenThuong.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnKhenThuong.ImageOptions.SvgImage")));
            this.btnKhenThuong.Name = "btnKhenThuong";
            this.btnKhenThuong.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnKhenThuong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKhenThuong_ItemClick);
            // 
            // btnDieuChuyen
            // 
            this.btnDieuChuyen.Caption = "Điều chuyển";
            this.btnDieuChuyen.Id = 9;
            this.btnDieuChuyen.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDieuChuyen.ImageOptions.SvgImage")));
            this.btnDieuChuyen.Name = "btnDieuChuyen";
            this.btnDieuChuyen.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnDieuChuyen.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDieuChuyen_ItemClick);
            // 
            // btnThoiViec
            // 
            this.btnThoiViec.Caption = "Thôi việc";
            this.btnThoiViec.Id = 11;
            this.btnThoiViec.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThoiViec.ImageOptions.SvgImage")));
            this.btnThoiViec.Name = "btnThoiViec";
            this.btnThoiViec.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnThoiViec.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoiViec_ItemClick);
            // 
            // btnUngLuong
            // 
            this.btnUngLuong.Caption = "Ứng lương";
            this.btnUngLuong.Id = 16;
            this.btnUngLuong.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnUngLuong.ImageOptions.SvgImage")));
            this.btnUngLuong.Name = "btnUngLuong";
            // 
            // tbnDoiMatKhau
            // 
            this.tbnDoiMatKhau.Caption = "Đổi mật khẩu";
            this.tbnDoiMatKhau.Id = 19;
            this.tbnDoiMatKhau.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("tbnDoiMatKhau.ImageOptions.SvgImage")));
            this.tbnDoiMatKhau.Name = "tbnDoiMatKhau";
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 20;
            this.btnThoat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThoat.ImageOptions.SvgImage")));
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // BtnPhucHoiDuLieu
            // 
            this.BtnPhucHoiDuLieu.Caption = "Phục Hồi Dữ Liệu";
            this.BtnPhucHoiDuLieu.Id = 21;
            this.BtnPhucHoiDuLieu.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnPhucHoiDuLieu.ImageOptions.SvgImage")));
            this.BtnPhucHoiDuLieu.Name = "BtnPhucHoiDuLieu";
            this.BtnPhucHoiDuLieu.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnSaoLuuDuLieu
            // 
            this.btnSaoLuuDuLieu.Caption = "Sao lưu dữ liệu";
            this.btnSaoLuuDuLieu.Id = 22;
            this.btnSaoLuuDuLieu.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSaoLuuDuLieu.ImageOptions.SvgImage")));
            this.btnSaoLuuDuLieu.Name = "btnSaoLuuDuLieu";
            this.btnSaoLuuDuLieu.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnCongTy
            // 
            this.btnCongTy.Caption = "Công Ty";
            this.btnCongTy.Id = 23;
            this.btnCongTy.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCongTy.ImageOptions.SvgImage")));
            this.btnCongTy.Name = "btnCongTy";
            this.btnCongTy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCongTy_ItemClick);
            // 
            // btnBoPhan
            // 
            this.btnBoPhan.Caption = "Bộ Phận ";
            this.btnBoPhan.Id = 24;
            this.btnBoPhan.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnBoPhan.ImageOptions.SvgImage")));
            this.btnBoPhan.Name = "btnBoPhan";
            this.btnBoPhan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBoPhan_ItemClick);
            // 
            // btnChucVu
            // 
            this.btnChucVu.Caption = "Chức vụ";
            this.btnChucVu.Id = 25;
            this.btnChucVu.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnChucVu.ImageOptions.SvgImage")));
            this.btnChucVu.Name = "btnChucVu";
            this.btnChucVu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnChucVu_ItemClick);
            // 
            // btnQuanLyLuong
            // 
            this.btnQuanLyLuong.Caption = "QL Lương";
            this.btnQuanLyLuong.Id = 28;
            this.btnQuanLyLuong.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnQuanLyLuong.ImageOptions.SvgImage")));
            this.btnQuanLyLuong.Name = "btnQuanLyLuong";
            this.btnQuanLyLuong.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnQuanLyLuong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnQuanLyLuong_ItemClick);
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbon_DANH_MUC_CHUNG,
            this.ribbon_NGHIEP_VU});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Quản lý nhân viên";
            // 
            // ribbon_DANH_MUC_CHUNG
            // 
            this.ribbon_DANH_MUC_CHUNG.ItemLinks.Add(this.btnDanToc);
            this.ribbon_DANH_MUC_CHUNG.ItemLinks.Add(this.btnTonGiao, true);
            this.ribbon_DANH_MUC_CHUNG.ItemLinks.Add(this.btnTrinhDo, true);
            this.ribbon_DANH_MUC_CHUNG.ItemLinks.Add(this.btnCongTy, true);
            this.ribbon_DANH_MUC_CHUNG.ItemLinks.Add(this.btnPhongBan, true);
            this.ribbon_DANH_MUC_CHUNG.ItemLinks.Add(this.btnBoPhan, true);
            this.ribbon_DANH_MUC_CHUNG.ItemLinks.Add(this.btnChucVu, true);
            this.ribbon_DANH_MUC_CHUNG.ItemLinks.Add(this.btnNhanVien, true);
            this.ribbon_DANH_MUC_CHUNG.Name = "ribbon_DANH_MUC_CHUNG";
            this.ribbon_DANH_MUC_CHUNG.Text = "DANH MỤC DÙNG CHUNG";
            // 
            // ribbon_NGHIEP_VU
            // 
            this.ribbon_NGHIEP_VU.ItemLinks.Add(this.btnHopDong, true);
            this.ribbon_NGHIEP_VU.ItemLinks.Add(this.btnQuanLyLuong, true);
            this.ribbon_NGHIEP_VU.ItemLinks.Add(this.btnKhenThuong, true);
            this.ribbon_NGHIEP_VU.ItemLinks.Add(this.btnDieuChuyen, true);
            this.ribbon_NGHIEP_VU.ItemLinks.Add(this.btnThoiViec, true);
            this.ribbon_NGHIEP_VU.Name = "ribbon_NGHIEP_VU";
            this.ribbon_NGHIEP_VU.Text = "NGHIỆP VỤ";
            // 
            // documentManager1
            // 
            this.documentManager1.MdiParent = this;
            this.documentManager1.MenuManager = this.ribbonControl1;
            this.documentManager1.View = this.tabbedView1;
            this.documentManager1.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tabbedView1});
            // 
            // MainForm
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1587, 699);
            this.Controls.Add(this.ribbonControl1);
            this.Font = new System.Drawing.Font("Tahoma", 10F);
            this.IconOptions.Image = global::NHANSU.Properties.Resources.Black_Text_Icons_Icon_Set1;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MainForm";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ỨNG DỤNG QUẢN LÝ NHÂN VIÊN";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem btnDanToc;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbon_DANH_MUC_CHUNG;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbon_NGHIEP_VU;
        private DevExpress.XtraBars.BarButtonItem btnTonGiao;
        private DevExpress.XtraBars.BarButtonItem btnTrinhDo;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem btnNhanVien;
        private DevExpress.XtraBars.BarButtonItem btnPhongBan;
        private DevExpress.XtraBars.BarButtonItem btnHopDong;
        private DevExpress.XtraBars.BarButtonItem btnKhenThuong;
        private DevExpress.XtraBars.BarButtonItem btnDieuChuyen;
        private DevExpress.XtraBars.BarButtonItem btnThoiViec;
        private DevExpress.XtraBars.BarButtonItem btnUngLuong;
        private DevExpress.XtraBars.BarButtonItem tbnDoiMatKhau;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.BarButtonItem BtnPhucHoiDuLieu;
        private DevExpress.XtraBars.BarButtonItem btnSaoLuuDuLieu;
        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager1;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView1;
        private DevExpress.XtraBars.BarButtonItem btnCongTy;
        private DevExpress.XtraBars.BarButtonItem btnBoPhan;
        private DevExpress.XtraBars.BarButtonItem btnChucVu;
        private DevExpress.XtraBars.BarButtonItem btnQuanLyLuong;
    }
}

