﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DB_GIFTGROUPEntities41 : DbContext
    {
        public DB_GIFTGROUPEntities41()
            : base("name=DB_GIFTGROUPEntities41")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<category> category { get; set; }
        public virtual DbSet<gifts> gifts { get; set; }
        public virtual DbSet<groups> groups { get; set; }
        public virtual DbSet<manager> manager { get; set; }
        public virtual DbSet<parents> parents { get; set; }
        public virtual DbSet<pictures> pictures { get; set; }
        public virtual DbSet<products> products { get; set; }
        public virtual DbSet<shops> shops { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
    }
}
