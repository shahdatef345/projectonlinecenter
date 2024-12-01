using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class assignTeacherAllrole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(" INSERT INTO [dbo].[AspNetUserRoles] (UserId, RoleId)\r\nSELECT '426256df-46d8-4fd7-b626-cf4bc436808d', Id FROM [dbo].[AspNetRoles]");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(" DELETE FROM[dbo].[AspNetUserRoles]\r\n WHERE UserId = '426256df-46d8-4fd7-b626-cf4bc436808d';");
          

        }
    }
}
