using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Data.Migrations
{
    public partial class IntialOne : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Dept_No",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "AspNetUsers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Img",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Course_No = table.Column<int>(type: "int", nullable: false),
                    Course_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Course_Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Course_No);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Dept_No = table.Column<int>(type: "int", nullable: false),
                    DeptName = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Dept_No);
                });

            migrationBuilder.CreateTable(
                name: "StudentCourses",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    Crs_Id = table.Column<int>(type: "int", nullable: false),
                    Degree = table.Column<int>(type: "int", nullable: true),
                    UsersId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CoursesCourse_No = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentCourses", x => new { x.StudentId, x.Crs_Id });
                    table.ForeignKey(
                        name: "FK_StudentCourses_AspNetUsers_UsersId",
                        column: x => x.UsersId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StudentCourses_Courses_CoursesCourse_No",
                        column: x => x.CoursesCourse_No,
                        principalTable: "Courses",
                        principalColumn: "Course_No",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DepartmentCourses",
                columns: table => new
                {
                    depNo = table.Column<int>(type: "int", nullable: false),
                    crsID = table.Column<int>(type: "int", nullable: false),
                    CoursesCourse_No = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepartmentCourses", x => new { x.crsID, x.depNo });
                    table.ForeignKey(
                        name: "FK_DepartmentCourses_Courses_CoursesCourse_No",
                        column: x => x.CoursesCourse_No,
                        principalTable: "Courses",
                        principalColumn: "Course_No",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DepartmentCourses_Departments_depNo",
                        column: x => x.depNo,
                        principalTable: "Departments",
                        principalColumn: "Dept_No",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_Dept_No",
                table: "AspNetUsers",
                column: "Dept_No");

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentCourses_CoursesCourse_No",
                table: "DepartmentCourses",
                column: "CoursesCourse_No");

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentCourses_depNo",
                table: "DepartmentCourses",
                column: "depNo");

            migrationBuilder.CreateIndex(
                name: "IX_StudentCourses_CoursesCourse_No",
                table: "StudentCourses",
                column: "CoursesCourse_No");

            migrationBuilder.CreateIndex(
                name: "IX_StudentCourses_UsersId",
                table: "StudentCourses",
                column: "UsersId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Departments_Dept_No",
                table: "AspNetUsers",
                column: "Dept_No",
                principalTable: "Departments",
                principalColumn: "Dept_No",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Departments_Dept_No",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "DepartmentCourses");

            migrationBuilder.DropTable(
                name: "StudentCourses");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_Dept_No",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Dept_No",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Img",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");
        }
    }
}
