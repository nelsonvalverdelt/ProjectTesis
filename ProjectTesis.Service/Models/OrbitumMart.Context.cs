﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjectTesis.Service.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class OrbitumMartConnection : DbContext
    {
        public OrbitumMartConnection()
            : base("name=OrbitumMartConnection")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Dim_Cliente> Dim_Cliente { get; set; }
        public virtual DbSet<Dim_Empleado> Dim_Empleado { get; set; }
        public virtual DbSet<Dim_Producto> Dim_Producto { get; set; }
        public virtual DbSet<Dim_Tiempo> Dim_Tiempo { get; set; }
        public virtual DbSet<Fac_Ventas> Fac_Ventas { get; set; }
    }
}
