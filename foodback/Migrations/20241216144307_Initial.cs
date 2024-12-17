using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApiWithRoleAuthentication.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Blogs");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fb77147a-f088-448f-a1f3-0af14962363d");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "effee7e0-5aad-4151-aead-e354fb6e0490", "69b36612-938e-45a2-aa7f-b0e3eef8954b" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "effee7e0-5aad-4151-aead-e354fb6e0490");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "69b36612-938e-45a2-aa7f-b0e3eef8954b");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Blogs",
                columns: table => new
                {
                    BlogId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BlogDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BlogTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BlogsAuthor = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs", x => x.BlogId);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "effee7e0-5aad-4151-aead-e354fb6e0490", null, "Admin", "ADMIN" },
                    { "fb77147a-f088-448f-a1f3-0af14962363d", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "69b36612-938e-45a2-aa7f-b0e3eef8954b", 0, "d9d2f033-1d20-415f-a791-dac20c2fac9f", "admin@gmail.com", true, false, null, null, null, "AQAAAAIAAYagAAAAECmzYaEg69cEd8fjhhTSzBUsdx0JppAtQLkxtFseqe6HpIM6sgEM4B3ogBzfQM6Jqg==", null, false, "b7b90810-4112-4af6-9251-937312419efd", false, "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "effee7e0-5aad-4151-aead-e354fb6e0490", "69b36612-938e-45a2-aa7f-b0e3eef8954b" });
        }
    }
}
