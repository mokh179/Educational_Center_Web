
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
namespace Database
{
    public class Department
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Dept_No { get; set; }
        [Required]
        public string DeptName { get; set; }
        public List<ApplicationUsers> Users { get; set; }
        public List<DepartmentCourses> DepartmentCourses { get; set; }
    }
}