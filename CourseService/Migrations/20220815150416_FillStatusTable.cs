using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CourseService.Migrations
{
    public partial class FillStatusTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("insert into status(Name) values ('Not Applied'), ('Applied'), ('Accepted'), ('Rejected')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
