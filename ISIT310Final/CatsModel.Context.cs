﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ISIT310Final
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CatsModelContainer : DbContext
    {
        public CatsModelContainer()
            : base("name=CatsModelContainer")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Cat> Cats { get; set; }
        public virtual DbSet<Playfullness> Playfullnesses { get; set; }
        public virtual DbSet<ActivityLevel> ActivityLevels { get; set; }
        public virtual DbSet<Color> Colors { get; set; }
    }
}
