﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StajProjesi_4.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DbBilgiKayitEntities1 : DbContext
    {
        public DbBilgiKayitEntities1()
            : base("name=DbBilgiKayitEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Admin> Admin { get; set; }
        public virtual DbSet<Bilgiler> Bilgiler { get; set; }
        public virtual DbSet<Departman> Departman { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
    }
}
