﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace eticaret.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class eTicaretDBEntities : DbContext
    {
        public eTicaretDBEntities()
            : base("name=eTicaretDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<BagProducts> BagProducts { get; set; }
        public virtual DbSet<Bags> Bags { get; set; }
        public virtual DbSet<Categories> Categories { get; set; }
        public virtual DbSet<Comments> Comments { get; set; }
        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<Editors> Editors { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<SoldProducts> SoldProducts { get; set; }
        public virtual DbSet<Admins> Admins { get; set; }
        public virtual DbSet<Logs> Logs { get; set; }
        public virtual DbSet<ProductImages> ProductImages { get; set; }
    }
}
