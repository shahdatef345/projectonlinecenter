using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addAdmin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO [dbo].[AspNetUsers] ([Id], [Discriminator], [Address], [Image], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [AdminId], [AssistantId], [StudentId], [TeacherId]) VALUES (N'426256df-46d8-4fd7-b626-cf4bc436808d', N'ApplicationUser', N'street103', NULL, N'Teacher1@test.com', N'TEACHER1@TEST.COM', N'Teacher1@test.com', N'TEACHER1@TEST.COM', 0, N'AQAAAAIAAYagAAAAEKnwBgtpuiWmFBzy+n8QpMSB6+zKUwcsNQrFmb+smngmRJ74Olk+i3o3fy0VdZ8IhQ==', N'4YU5XGPIC3I3ZQFUTSEUBIAMIWIIUVVK', N'e81bc381-598b-4570-b3bb-84defbe86d8f', NULL, 0, 0, NULL, 1, 0, NULL, NULL, NULL, NULL)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM  [dbo].[AspNetUsers] WHERE Id='426256df-46d8-4fd7-b626-cf4bc436808d'");
        }
    }
}
