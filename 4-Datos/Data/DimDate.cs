//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class DimDate
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DimDate()
        {
            this.FactExchangeRate = new HashSet<FactExchangeRate>();
            this.FactInventory = new HashSet<FactInventory>();
            this.FactITMachine = new HashSet<FactITMachine>();
            this.FactITSLA = new HashSet<FactITSLA>();
            this.FactSales = new HashSet<FactSales>();
            this.FactSalesQuota = new HashSet<FactSalesQuota>();
            this.FactStrategyPlan = new HashSet<FactStrategyPlan>();
        }
    
        public System.DateTime Datekey { get; set; }
        public string FullDateLabel { get; set; }
        public string DateDescription { get; set; }
        public int CalendarYear { get; set; }
        public string CalendarYearLabel { get; set; }
        public int CalendarHalfYear { get; set; }
        public string CalendarHalfYearLabel { get; set; }
        public int CalendarQuarter { get; set; }
        public string CalendarQuarterLabel { get; set; }
        public int CalendarMonth { get; set; }
        public string CalendarMonthLabel { get; set; }
        public int CalendarWeek { get; set; }
        public string CalendarWeekLabel { get; set; }
        public int CalendarDayOfWeek { get; set; }
        public string CalendarDayOfWeekLabel { get; set; }
        public int FiscalYear { get; set; }
        public string FiscalYearLabel { get; set; }
        public int FiscalHalfYear { get; set; }
        public string FiscalHalfYearLabel { get; set; }
        public int FiscalQuarter { get; set; }
        public string FiscalQuarterLabel { get; set; }
        public int FiscalMonth { get; set; }
        public string FiscalMonthLabel { get; set; }
        public string IsWorkDay { get; set; }
        public int IsHoliday { get; set; }
        public string HolidayName { get; set; }
        public string EuropeSeason { get; set; }
        public string NorthAmericaSeason { get; set; }
        public string AsiaSeason { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FactExchangeRate> FactExchangeRate { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FactInventory> FactInventory { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FactITMachine> FactITMachine { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FactITSLA> FactITSLA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FactSales> FactSales { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FactSalesQuota> FactSalesQuota { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FactStrategyPlan> FactStrategyPlan { get; set; }
    }
}
