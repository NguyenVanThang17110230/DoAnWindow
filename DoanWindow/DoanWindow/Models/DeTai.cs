//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DoanWindow.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DeTai
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DeTai()
        {
            this.BaoCaos = new HashSet<BaoCao>();
            this.SinhViens = new HashSet<SinhVien>();
        }
    
        public string ID { get; set; }
        public string TenDeTai { get; set; }
        public string LoaiDeTai { get; set; }
        public string GiaoVienHuongDan { get; set; }
        public string MoTa { get; set; }
        public Nullable<int> SoLuongSinhVien { get; set; }
        public Nullable<System.DateTime> ThoiGianBatDau { get; set; }
        public Nullable<System.DateTime> ThoiGianKetThuc { get; set; }
        public Nullable<int> SoLanBaoCao { get; set; }
        public Nullable<bool> TinhTrang { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BaoCao> BaoCaos { get; set; }
        public virtual GiaoVien GiaoVien { get; set; }
        public virtual LoaiDeTai LoaiDeTai1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SinhVien> SinhViens { get; set; }
    }
}
