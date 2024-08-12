using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Task.Entities
{

    internal class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //(1,1)
        public int EmpId { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        [StringLength(50, MinimumLength = 10)]
        public string? EmpName { get; set; }

        //navigitional property [one]
        [InverseProperty("Employees")]
        public Department Department { get; set; }
        

        public int? DepartmentId {  get; set; } //foreign key
        #region Other Properties

        //public double Salary { get; set; }

        //[Range(22,60)]
        //public int? Age { get; set; }

        //[EmailAddress]
        //public string? Email {  get; set; }

        //[DataType(DataType.PhoneNumber)]
        //public string? PhoneNumber { get; set; } 
        #endregion
    }
}
