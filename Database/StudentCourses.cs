using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Database
{
    public class StudentCourses
    {
        [Key]
        [Column(Order = 0)]
        [ForeignKey("Student")]

        public int StudentId { get; set; }

        [Key]
        [Column(Order = 1)]
        [ForeignKey("Course")]

        public int Crs_Id { get; set; }

        public int? Degree { get; set; }
        public ApplicationUsers Users { get; set; }

        public Course Courses { get; set; }
    }
}
