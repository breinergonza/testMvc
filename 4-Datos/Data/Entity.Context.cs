﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _4_Datos.Data
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Entitys : DbContext
    {
        public Entitys()
            : base("name=Entitys")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<DimAccount> DimAccount { get; set; }
        public virtual DbSet<DimChannel> DimChannel { get; set; }
        public virtual DbSet<DimCurrency> DimCurrency { get; set; }
        public virtual DbSet<DimCustomer> DimCustomer { get; set; }
        public virtual DbSet<DimDate> DimDate { get; set; }
        public virtual DbSet<DimEmployee> DimEmployee { get; set; }
        public virtual DbSet<DimEntity> DimEntity { get; set; }
        public virtual DbSet<DimGeography> DimGeography { get; set; }
        public virtual DbSet<DimMachine> DimMachine { get; set; }
        public virtual DbSet<DimOutage> DimOutage { get; set; }
        public virtual DbSet<DimProduct> DimProduct { get; set; }
        public virtual DbSet<DimProductCategory> DimProductCategory { get; set; }
        public virtual DbSet<DimProductSubcategory> DimProductSubcategory { get; set; }
        public virtual DbSet<DimPromotion> DimPromotion { get; set; }
        public virtual DbSet<DimSalesTerritory> DimSalesTerritory { get; set; }
        public virtual DbSet<DimScenario> DimScenario { get; set; }
        public virtual DbSet<DimStore> DimStore { get; set; }
        public virtual DbSet<FactExchangeRate> FactExchangeRate { get; set; }
        public virtual DbSet<FactInventory> FactInventory { get; set; }
        public virtual DbSet<FactITMachine> FactITMachine { get; set; }
        public virtual DbSet<FactITSLA> FactITSLA { get; set; }
        public virtual DbSet<FactOnlineSales> FactOnlineSales { get; set; }
        public virtual DbSet<FactSales> FactSales { get; set; }
        public virtual DbSet<FactSalesQuota> FactSalesQuota { get; set; }
        public virtual DbSet<FactStrategyPlan> FactStrategyPlan { get; set; }
    }
}