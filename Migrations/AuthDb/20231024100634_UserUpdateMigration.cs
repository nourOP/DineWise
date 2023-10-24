using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DineWise.Migrations.AuthDb
{
    /// <inheritdoc />
    public partial class UserUpdateMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "547D384E-EE3D-4053-AB1B-D0F524B77707",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dcfe3797-7db6-4b65-9ebb-cfb96887e41d", "AQAAAAIAAYagAAAAEJwyB9U6ooGyjtvnVM+xevzJcwikJFNCWXvrMbYr8iWKGQrhRUZTm6vZwzljd85eZg==", "17e2a52f-ad88-40ca-ba5d-9ff4f991325c" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "547D384E-EE3D-4053-AB1B-D0F524B77707",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "692c1cee-dc78-4d93-835c-897220022ab5", "AQAAAAIAAYagAAAAEKZG4H1R5N4uXOSGSkqCoL6RFyaF9o1qgRgeirqkwBgfFXQ2cDVbNAibDcz4bKQwzw==", "ad94aac5-dc26-44b8-9a5f-35449ee5e160" });
        }
    }
}
