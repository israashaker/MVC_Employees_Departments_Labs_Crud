using crudoperationEmpDept.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace crudoperationEmpDept.Models.Entities
{
    [Table("Employee")]
    public class Employee
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [Range(10, 100)]
        public int Age { get; set; }
        public Gender Gender { get; set; }
        [ForeignKey("Department")]
        public int FK_DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}