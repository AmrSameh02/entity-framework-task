using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Task.Entities
{
    internal class Department
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }



        [Required]
        [StringLength(50, MinimumLength = 10)]
        [MaxLength(50)]
        [Column(TypeName = "varchar")]
        public string DepartmentName { get; set; }

        //navigational property [many]
        [InverseProperty("Department")]
        public IEnumerable<Employee> Employees { get; set; } = new HashSet<Employee>();

        public
    }
}
