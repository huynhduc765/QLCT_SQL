﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class QuanLyChiTieuEntities : DbContext
    {
        public QuanLyChiTieuEntities()
            : base("name=QuanLyChiTieuEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<DanhSachChiTieu> DanhSachChiTieux { get; set; }
        public virtual DbSet<LoaiChiTieu> LoaiChiTieux { get; set; }
    }
}
