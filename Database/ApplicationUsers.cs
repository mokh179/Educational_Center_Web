using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Database
{
   public class ApplicationUsers: IdentityUser
    {
        [Required, MaxLength(50)]
        public string FirstName { get; set; }
        [Required, MaxLength(50)]
        public string LastName { get; set; }
        [Required, MaxLength(50)]
        public string Gender { get; set; }
        public byte[] ProfilePic { get; set; }
       
        [ForeignKey("Departments")]
        public int Dept { get; set; }
        public Department Departments { get; set; }
        public List<StudentCourses> StudentCourses { get; set; }
    }
}
