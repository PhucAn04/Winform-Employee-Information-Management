using BusinessLayer;
using BusinessLayer.DTO;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;

namespace NHANSU.Reports
{
    public partial class rptDanhSachNhanVien : DevExpress.XtraReports.UI.XtraReport
    {
        public rptDanhSachNhanVien()
        {
            InitializeComponent();
        }
        List<NHANVIEN_DTO> _lstNV;
        public rptDanhSachNhanVien(List<NHANVIEN_DTO> lstNV)
        {
            InitializeComponent();
            this._lstNV = lstNV;
            this.DataSource = _lstNV;
            loadData();
        }
        void loadData()
        {
            lblMaNV.DataBindings.Add("Text", _lstNV, "MANV");
            lblHoTen.DataBindings.Add("Text", _lstNV, "HOTEN");
            lblGioiTinh.DataBindings.Add("Text", _lstNV, "GIOITINH", "{0:True;False;}");
            lblNgaySinh.DataBindings.Add("Text", _lstNV, "NGAYSINH", "{0:dd/MM/yyyy}");
            lblDienThoai.DataBindings.Add("Text", _lstNV, "DIENTHOAI");
            lblCCCD.DataBindings.Add("Text", _lstNV, "CCCD");
            lblDiaChi.DataBindings.Add("Text", _lstNV, "DIACHI");
            lblChucVu.DataBindings.Add("Text", _lstNV, "TENCV");
            lblPhongBan.DataBindings.Add("Text", _lstNV, "TENPB");
            lblBoPhan.DataBindings.Add("Text", _lstNV, "TENBP");
            lblTrinhDo.DataBindings.Add("Text", _lstNV, "TENTD");
            lblDanToc.DataBindings.Add("Text", _lstNV, "TENDT");
            lblTonGiao.DataBindings.Add("Text", _lstNV, "TENTG");
        }
    }
}
