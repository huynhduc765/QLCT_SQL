//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLCT
{
    using System;
    using System.Collections.Generic;
    
    public partial class LoaiChiTieu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LoaiChiTieu()
        {
            this.DanhSachChiTieux = new HashSet<DanhSachChiTieu>();
        }
    
        public int MaLoai { get; set; }
        public string TenLoaiChiTieu { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DanhSachChiTieu> DanhSachChiTieux { get; set; }
    }
}
