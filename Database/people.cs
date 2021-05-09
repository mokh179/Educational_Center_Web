using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Database
{
   public class people: IdentityUser
    {
        [Required, MaxLength(50)]
        public string FirstName { get; set; }
        [Required, MaxLength(50)]
        public string LastName { get; set; }
        [Required, MaxLength(50)]
        public string Gender { get; set; }
        public string Img { get; set; }
        [NotMapped]
        public IFormFile Image { get; set; }
        [ForeignKey("Departments")]
        public int Dept_No { get; set; }
        public Department Departments { get; set; }
        public List<StudentCourses> StudentCourses { get; set; }
    }
}
