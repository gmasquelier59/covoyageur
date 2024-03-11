using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EVS.Api.Migrations
{
    /// <inheritdoc />
    public partial class RidesSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "user",
                keyColumn: "id",
                keyValue: new Guid("27e90885-8a13-481d-8f43-60019ec76d94"));

            migrationBuilder.DeleteData(
                table: "user",
                keyColumn: "id",
                keyValue: new Guid("3628effd-4cec-45c2-8e04-b58c71f0ef82"));

            migrationBuilder.DeleteData(
                table: "user",
                keyColumn: "id",
                keyValue: new Guid("57ec6360-36d9-433e-bb9a-b577795df782"));

            migrationBuilder.DeleteData(
                table: "user",
                keyColumn: "id",
                keyValue: new Guid("6c3b3940-e702-4c6a-bb33-2fb3312f9e95"));

            migrationBuilder.DeleteData(
                table: "user",
                keyColumn: "id",
                keyValue: new Guid("b67887af-08d6-4d1f-b05a-4fe3345e2e51"));

            migrationBuilder.DeleteData(
                table: "user",
                keyColumn: "id",
                keyValue: new Guid("fd9e8826-ea40-4de0-a70a-376fae19b340"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { new Guid("27e90885-8a13-481d-8f43-60019ec76d94"), new DateTime(1998, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Daewoo", "naldren0@webeden.co.uk", "Amye", "Colchett", "aB0.oB?iBy\\", "0337862430", "", "acolchett0" },
                    { new Guid("3628effd-4cec-45c2-8e04-b58c71f0ef82"), new DateTime(1997, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "BMW", "cgrigorkin4@theatlantic.com", "Carlota", "Grigorkin", "tZ9\\4s(DQvnvE", "0494223557", "", "cgrigorkin4" },
                    { new Guid("57ec6360-36d9-433e-bb9a-b577795df782"), new DateTime(1974, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lexus", "ddroogan1@thetimes.co.uk", "Nap", "Droogan", "tH0)I/Mt<xZwz2", "0322458382", "", "ddroogan1" },
                    { new Guid("6c3b3940-e702-4c6a-bb33-2fb3312f9e95"), new DateTime(1984, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Austin", "lhair3@wikipedia.org", "Lindsey", "Hair", "eE0'6STA~9O#Suj{", "0162842195", "", "lhair3" },
                    { new Guid("b67887af-08d6-4d1f-b05a-4fe3345e2e51"), new DateTime(1988, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jeep", "kpedwell2@icq.com", "Kordula", "Pedwell", "pH3+&{WpvdT", "0903434966", "", "kpedwell2" },
                    { new Guid("fd9e8826-ea40-4de0-a70a-376fae19b340"), new DateTime(2024, 3, 11, 11, 50, 42, 962, DateTimeKind.Local).AddTicks(5491), "", "admin@envoituresimone.com", "Admin", "Admin", "admin", "0102030405", "", "admin" }
                });
        }
    }
}
