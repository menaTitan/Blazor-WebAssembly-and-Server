using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookStoreApp.API.Migrations
{
    /// <inheritdoc />
    public partial class SeedDefaultUserAndRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "766138f9-78b7-4532-b645-cd13546d34b7", null, "User", "USER" },
                    { "7b0267c1-1201-4d53-9593-1a0b8fcb2164", null, "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "3fa1e9d3-a5bc-4814-b99e-4aee267df933", 0, "86d99b80-b602-4254-a48c-2b02611335f9", "admin@bookstore.com", false, "System", "Admin", false, null, "ADMIN@BOOKSTORE.COM", "ADMIN@BOOKSTORE.COM", "AQAAAAIAAYagAAAAEOObB252AAtZFyezR51dxSip09MRoPaapWZTKeQLowyNkXcxQ6q74QUMaUuOVhuWAg==", null, false, "fab5cdef-234f-450d-8d78-082074d6f55b", false, "admin@bookstore.com" },
                    { "6df13166-3e6c-483f-a34b-b507718ee505", 0, "d83d8615-733c-4e9d-8864-207d2775cc05", "user@bookstore.com", false, "System", "User", false, null, "USER@BOOKSTORE.COM", "USER@BOOKSTORE.COM", "AQAAAAIAAYagAAAAEJpfZU1eT8OHFmhy5Ypi5nLw3veF1BUdF74SWMNGnUsdFZyy4RVmoxzPAAKryeKOyg==", null, false, "509f54cc-294c-43d1-a831-2067573c4321", false, "user@bookstore.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "7b0267c1-1201-4d53-9593-1a0b8fcb2164", "3fa1e9d3-a5bc-4814-b99e-4aee267df933" },
                    { "766138f9-78b7-4532-b645-cd13546d34b7", "6df13166-3e6c-483f-a34b-b507718ee505" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7b0267c1-1201-4d53-9593-1a0b8fcb2164", "3fa1e9d3-a5bc-4814-b99e-4aee267df933" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "766138f9-78b7-4532-b645-cd13546d34b7", "6df13166-3e6c-483f-a34b-b507718ee505" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "766138f9-78b7-4532-b645-cd13546d34b7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7b0267c1-1201-4d53-9593-1a0b8fcb2164");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3fa1e9d3-a5bc-4814-b99e-4aee267df933");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6df13166-3e6c-483f-a34b-b507718ee505");
        }
    }
}
