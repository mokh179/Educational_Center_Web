using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Database
{
    public class Course
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Course_No { get; set; }
        [Required]
        public string Course_Name { get; set; }
        public string Course_Description { get; set; }
        public List<StudentCourses> StudentCourses { get; set; }
        public List<DepartmentCourses> DepartmentCourses { get; set; }
    }
}
