using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EVS.Api.Migrations
{
    /// <inheritdoc />
    public partial class RidesSeed2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ride",
                keyColumn: "id",
                keyValue: new Guid("5e9dc88d-fbcb-48cb-b365-12f6abbcbaa4"));

            migrationBuilder.DeleteData(
                table: "user",
                keyColumn: "id",
                keyValue: new Guid("0d77cc32-06af-49b5-9f21-4d1065cc113c"));

            migrationBuilder.DeleteData(
                table: "user",
                keyColumn: "id",
                keyValue: new Guid("12266ec5-dc7a-490d-b189-b90995bbe497"));

            migrationBuilder.DeleteData(
                table: "user",
                keyColumn: "id",
                keyValue: new Guid("d0d542e2-a1e5-4ab9-8da0-7bed86314c82"));

            migrationBuilder.DeleteData(
                table: "user",
                keyColumn: "id",
                keyValue: new Guid("d8efbab7-1140-4b0a-bf04-a51e5542f874"));

            migrationBuilder.DeleteData(
                table: "user",
                keyColumn: "id",
                keyValue: new Guid("f86cf377-a0b1-47cc-a074-4487e6a6fe4b"));

            migrationBuilder.DeleteData(
                table: "user",
                keyColumn: "id",
                keyValue: new Guid("9e0b34e4-81ad-4425-960f-c2ccb88932b8"));

            migrationBuilder.InsertData(
                table: "user",
                columns: new[] { "id", "birthday", "car_description", "email", "firstname", "lastname", "password", "phone_number", "photo", "pseudo" },
                values: new object[,]
                {
                    { new Guid("063983f2-60ec-4900-af2c-a47845f5edf4"), new DateTime(1988, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jeep", "kpedwell2@icq.com", "Kordula", "Pedwell", "pH3+&{WpvdT", "0903434966", "", "kpedwell2" },
                    { new Guid("44a0b880-33bf-45be-a930-a4f105d75aa1"), new DateTime(2024, 3, 11, 12, 28, 37, 621, DateTimeKind.Local).AddTicks(7331), "", "admin@envoituresimone.com", "Admin", "Admin", "admin", "0102030405", "", "admin" },
                    { new Guid("7005279b-f7ec-4e30-a94a-d5e155059d6e"), new DateTime(1984, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Austin", "lhair3@wikipedia.org", "Lindsey", "Hair", "eE0'6STA~9O#Suj{", "0162842195", "", "lhair3" },
                    { new Guid("91dc47be-9d2b-4d64-b1a0-bc299c2eb87a"), new DateTime(1998, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Daewoo", "naldren0@webeden.co.uk", "Amye", "Colchett", "aB0.oB?iBy\\", "0337862430", "", "acolchett0" },
                    { new Guid("9e1727ce-2538-4690-aaa0-5918e3149141"), new DateTime(1974, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lexus", "ddroogan1@thetimes.co.uk", "Nap", "Droogan", "tH0)I/Mt<xZwz2", "0322458382", "", "ddroogan1" },
                    { new Guid("b2ec9189-fdcb-4fd9-b56e-c41c54cdbe4b"), new DateTime(1997, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "BMW", "cgrigorkin4@theatlantic.com", "Carlota", "Grigorkin", "tZ9\\4s(DQvnvE", "0494223557", "", "cgrigorkin4" }
                });

            migrationBuilder.InsertData(
                table: "ride",
                columns: new[] { "id", "departure", "distance", "end_city", "end_latitude", "end_longitude", "price", "seats", "start_city", "start_latitude", "start_longitude", "user_id" },
                values: new object[,]
                {
                    { new Guid("1e830ccd-86d5-450f-b970-8ac91f66f389"), new DateTime(2024, 3, 17, 0, 0, 0, 0, DateTimeKind.Local), 204, "Paris, France", 48.858825500000002, 2.2646343999999998, 18.0, 2, "Lille, France", 50.631073299999997, 3.0056983000000002, new Guid("063983f2-60ec-4900-af2c-a47845f5edf4") },
                    { new Guid("2d76d087-f7c7-4ed6-be1a-4f7f48d977f7"), new DateTime(2024, 3, 16, 0, 0, 0, 0, DateTimeKind.Local), 204, "Paris, France", 48.858825500000002, 2.2646343999999998, 20.0, 3, "Lille, France", 50.631073299999997, 3.0056983000000002, new Guid("91dc47be-9d2b-4d64-b1a0-bc299c2eb87a") },
                    { new Guid("54637b0b-e4c0-4d50-9a15-11c73b2a182b"), new DateTime(2024, 3, 21, 0, 0, 0, 0, DateTimeKind.Local), 204, "Lille, France", 50.631073299999997, 3.0056983000000002, 23.0, 4, "Paris, France", 48.858825500000002, 2.2646343999999998, new Guid("9e1727ce-2538-4690-aaa0-5918e3149141") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ride",
                keyColumn: "id",
                keyValue: new Guid("1e830ccd-86d5-450f-b970-8ac91f66f389"));

            migrationBuilder.DeleteData(
                table: "ride",
                keyColumn: "id",
                keyValue: new Guid("2d76d087-f7c7-4ed6-be1a-4f7f48d977f7"));

            migrationBuilder.DeleteData(
                table: "ride",
                keyColumn: "id",
                keyValue: new Guid("54637b0b-e4c0-4d50-9a15-11c73b2a182b"));

            migrationBuilder.DeleteData(
                table: "user",
                keyColumn: "id",
                keyValue: new Guid("44a0b880-33bf-45be-a930-a4f105d75aa1"));

            migrationBuilder.DeleteData(
                table: "user",
                keyColumn: "id",
                keyValue: new Guid("7005279b-f7ec-4e30-a94a-d5e155059d6e"));

            migrationBuilder.DeleteData(
                table: "user",
                keyColumn: "id",
                keyValue: new Guid("b2ec9189-fdcb-4fd9-b56e-c41c54cdbe4b"));

            migrationBuilder.DeleteData(
                table: "user",
                keyColumn: "id",
                keyValue: new Guid("063983f2-60ec-4900-af2c-a47845f5edf4"));

            migrationBuilder.DeleteData(
                table: "user",
                keyColumn: "id",
                keyValue: new Guid("91dc47be-9d2b-4d64-b1a0-bc299c2eb87a"));

            migrationBuilder.DeleteData(
                table: "user",
                keyColumn: "id",
                keyValue: new Guid("9e1727ce-2538-4690-aaa0-5918e3149141"));

            migrationBuilder.InsertData(
                table: "user",
                columns: new[] { "id", "birthday", "car_description", "email", "firstname", "lastname", "password", "phone_number", "photo", "pseudo" },
                values: new object[,]
                {
                    { new Guid("0d77cc32-06af-49b5-9f21-4d1065cc113c"), new DateTime(1974, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lexus", "ddroogan1@thetimes.co.uk", "Nap", "Droogan", "tH0)I/Mt<xZwz2", "0322458382", "", "ddroogan1" },
                    { new Guid("12266ec5-dc7a-490d-b189-b90995bbe497"), new DateTime(1984, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Austin", "lhair3@wikipedia.org", "Lindsey", "Hair", "eE0'6STA~9O#Suj{", "0162842195", "", "lhair3" },
                    { new Guid("9e0b34e4-81ad-4425-960f-c2ccb88932b8"), new DateTime(1998, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Daewoo", "naldren0@webeden.co.uk", "Amye", "Colchett", "aB0.oB?iBy\\", "0337862430", "", "acolchett0" },
                    { new Guid("d0d542e2-a1e5-4ab9-8da0-7bed86314c82"), new DateTime(1997, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "BMW", "cgrigorkin4@theatlantic.com", "Carlota", "Grigorkin", "tZ9\\4s(DQvnvE", "0494223557", "", "cgrigorkin4" },
                    { new Guid("d8efbab7-1140-4b0a-bf04-a51e5542f874"), new DateTime(1988, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jeep", "kpedwell2@icq.com", "Kordula", "Pedwell", "pH3+&{WpvdT", "0903434966", "", "kpedwell2" },
                    { new Guid("f86cf377-a0b1-47cc-a074-4487e6a6fe4b"), new DateTime(2024, 3, 11, 12, 25, 33, 498, DateTimeKind.Local).AddTicks(9027), "", "admin@envoituresimone.com", "Admin", "Admin", "admin", "0102030405", "", "admin" }
                });

            migrationBuilder.InsertData(
                table: "ride",
                columns: new[] { "id", "departure", "distance", "end_city", "end_latitude", "end_longitude", "price", "seats", "start_city", "start_latitude", "start_longitude", "user_id" },
                values: new object[] { new Guid("5e9dc88d-fbcb-48cb-b365-12f6abbcbaa4"), new DateTime(2024, 3, 16, 0, 0, 0, 0, DateTimeKind.Local), 204, "Paris, France", 48.858825500000002, 2.2646343999999998, 20.0, 3, "Lille, France", 50.631073299999997, 3.0056983000000002, new Guid("9e0b34e4-81ad-4425-960f-c2ccb88932b8") });
        }
    }
}
