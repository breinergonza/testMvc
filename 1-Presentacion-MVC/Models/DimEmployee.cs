using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace _1_Presentacion_MVC.Models
{
    [Table("DimEmployee")]
    public class DimEmployee 
    {
       
        public DimEmployee()
        {
            DimEmployee1 = new HashSet<DimEmployee>();
        }

        [Key] public int EmployeeKey { get; set; }

        public int? ParentEmployeeKey { get; set; }

        [Required] [StringLength(50)] public string FirstName { get; set; }

        [Required] [StringLength(50)] public string LastName { get; set; }

        [StringLength(50)] public string MiddleName { get; set; }

        [StringLength(50)] public string Title { get; set; }

        [Column(TypeName = "date")] public DateTime? HireDate { get; set; }

        [Column(TypeName = "date")] public DateTime? BirthDate { get; set; }

        [StringLength(50)] public string EmailAddress { get; set; }

        [StringLength(25)] public string Phone { get; set; }

        [StringLength(1)] public string MaritalStatus { get; set; }

        [StringLength(50)] public string EmergencyContactName { get; set; }

        [StringLength(25)] public string EmergencyContactPhone { get; set; }

        public bool? SalariedFlag { get; set; }

        [StringLength(1)] public string Gender { get; set; }

        public byte? PayFrequency { get; set; }

        [Column(TypeName = "money")] public decimal? BaseRate { get; set; }

        public short? VacationHours { get; set; }

        public bool CurrentFlag { get; set; }

        public bool SalesPersonFlag { get; set; }

        [StringLength(50)] public string DepartmentName { get; set; }

        [Column(TypeName = "date")] public DateTime? StartDate { get; set; }

        [Column(TypeName = "date")] public DateTime? EndDate { get; set; }

        [StringLength(50)] public string Status { get; set; }

        [StringLength(200)] public string ImageUrl { get; set; }

        [StringLength(200)] public string ProfileUrl { get; set; }

        public int? ETLLoadID { get; set; }

        public DateTime? LoadDate { get; set; }

        public DateTime? UpdateDate { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DimEmployee> DimEmployee1 { get; set; }

        public virtual DimEmployee DimEmployee2 { get; set; }
    }
}