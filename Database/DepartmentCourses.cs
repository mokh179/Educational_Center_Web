using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class DepartmentCourses
    {
        [Key]
        [Column(Order = 0)]
        [ForeignKey("Department")]
        public int depNo { get; set; }
        [Key]
        [Column(Order = 1)]
        [ForeignKey("Course")]
        public int crsID { get; set; }
        public Department Department { get; set; }
        public Course Courses { get; set; }
    }
}
