//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLMB.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class HuyHopDong
    {
        public System.DateTime NgayLamDon { get; set; }
        public string LyDo { get; set; }
        public Nullable<System.DateTime> NgayDuyet { get; set; }
        public string MaHD { get; set; }
        public string MaNV { get; set; }
        public short MATT { get; set; }
    
        public virtual HopDong HopDong { get; set; }
        public virtual NhanVien NhanVien { get; set; }
        public virtual TinhTrang TinhTrang { get; set; }
    }
}