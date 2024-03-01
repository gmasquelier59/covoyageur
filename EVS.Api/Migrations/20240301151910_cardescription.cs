using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EVS.Api.Migrations
{
    /// <inheritdoc />
    public partial class cardescription : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "user",
                keyColumn: "id",
                keyValue: new Guid("3a408642-5cc6-436d-bb51-1fb3bb537065"));

            migrationBuilder.InsertData(
                table: "user",
                columns: new[] { "id", "birthday", "car_description", "email", "firstname", "lastname", "password", "phone_number", "photo", "pseudo" },
                values: new object[] { new Guid("54823d83-934f-4735-b4ea-06d9b3a283ac"), new DateTime(2024, 3, 1, 16, 19, 10, 3, DateTimeKind.Local).AddTicks(3702), "", "admin@envoituresimone.com", "Admin", "Admin", "123456789", "0102030405", "", "admin" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "user",
                keyColumn: "id",
                keyValue: new Guid("54823d83-934f-4735-b4ea-06d9b3a283ac"));

            migrationBuilder.InsertData(
                table: "user",
                columns: new[] { "id", "birthday", "car_description", "email", "firstname", "lastname", "password", "phone_number", "photo", "pseudo" },
                values: new object[] { new Guid("3a408642-5cc6-436d-bb51-1fb3bb537065"), new DateTime(2024, 3, 1, 13, 56, 52, 318, DateTimeKind.Local).AddTicks(8560), "", "admin@envoituresimone.com", "Admin", "Admin", "123456789", "0102030405", "", "admin" });
        }
    }
}
