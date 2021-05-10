using Database;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppCore.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUsers>
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<DepartmentCourses> DepartmentCourses { get; set; }
        public DbSet<StudentCourses> StudentCourses { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<DepartmentCourses>().HasKey(e => new { e.crsID, e.depNo });
            builder.Entity<StudentCourses>().HasKey(e => new { e.StudentId, e.Crs_Id });
            builder.Entity<ApplicationUsers>().ToTable("Users").Ignore(e => e.PhoneNumberConfirmed);
            builder.Entity<IdentityRole>().ToTable("roles");
            builder.Entity<IdentityUserRole<string>>().ToTable("UserRoles");
            builder.Entity<IdentityRoleClaim<string>>().ToTable("RolesClaims");
            builder.Entity<IdentityUserClaim<string>>().ToTable("UserClaims");
            builder.Entity<IdentityUserLogin<string>>().ToTable("UserLogin");
            builder.Entity<IdentityUserToken<string>>().ToTable("UserTokens");
        }
    }
}
