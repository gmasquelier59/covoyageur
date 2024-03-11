using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EVS.Api.Migrations
{
    /// <inheritdoc />
    public partial class RidesSeed3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("4490da7e-5df3-4172-b561-7bcc8466b652"), new DateTime(1984, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Austin", "lhair3@wikipedia.org", "Lindsey", "Hair", "eE0'6STA~9O#Suj{", "0162842195", "", "lhair3" },
                    { new Guid("469c998f-dc2b-4ae5-a0c0-bdb7c95d1c58"), new DateTime(1988, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jeep", "kpedwell2@icq.com", "Kordula", "Pedwell", "pH3+&{WpvdT", "0903434966", "", "kpedwell2" },
                    { new Guid("953885b2-3981-44c6-bede-ac08235e3f6d"), new DateTime(1974, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lexus", "ddroogan1@thetimes.co.uk", "Nap", "Droogan", "tH0)I/Mt<xZwz2", "0322458382", "", "ddroogan1" },
                    { new Guid("b38c2338-d1d7-4517-9bd5-e9eabffe7abc"), new DateTime(1998, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Daewoo", "naldren0@webeden.co.uk", "Amye", "Colchett", "aB0.oB?iBy\\", "0337862430", "", "acolchett0" },
                    { new Guid("d9cb2561-4334-4d70-87b9-4eca57c71a8d"), new DateTime(1997, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "BMW", "cgrigorkin4@theatlantic.com", "Carlota", "Grigorkin", "tZ9\\4s(DQvnvE", "0494223557", "", "cgrigorkin4" },
                    { new Guid("dea90259-90fb-4fd2-b5e2-3f4425450188"), new DateTime(2024, 3, 11, 12, 32, 18, 57, DateTimeKind.Local).AddTicks(4895), "", "admin@envoituresimone.com", "Admin", "Admin", "admin", "0102030405", "", "admin" }
                });

            migrationBuilder.InsertData(
                table: "ride",
                columns: new[] { "id", "departure", "distance", "end_city", "end_latitude", "end_longitude", "price", "seats", "start_city", "start_latitude", "start_longitude", "user_id" },
                values: new object[,]
                {
                    { new Guid("66ca49c2-d569-49a6-9398-212e4b0f7b61"), new DateTime(2024, 3, 16, 0, 0, 0, 0, DateTimeKind.Local), 204, "Paris, France", 48.858825500000002, 2.2646343999999998, 20.0, 3, "Lille, France", 50.631073299999997, 3.0056983000000002, new Guid("b38c2338-d1d7-4517-9bd5-e9eabffe7abc") },
                    { new Guid("7e3b043f-0687-4d4a-83ce-9cf74e36efb0"), new DateTime(2024, 3, 21, 0, 0, 0, 0, DateTimeKind.Local), 204, "Lille, France", 50.631073299999997, 3.0056983000000002, 23.0, 4, "Paris, France", 48.858825500000002, 2.2646343999999998, new Guid("953885b2-3981-44c6-bede-ac08235e3f6d") },
                    { new Guid("94078d46-868f-4625-8b72-aea3035f7919"), new DateTime(2024, 3, 28, 0, 0, 0, 0, DateTimeKind.Local), 660, "Marseille, France", 43.280226999999996, 43.280226999999996, 39.0, 1, "Paris, France", 48.858825500000002, 2.2646343999999998, new Guid("d9cb2561-4334-4d70-87b9-4eca57c71a8d") },
                    { new Guid("cac31fa3-6d46-4205-9064-0351d593421a"), new DateTime(2024, 3, 17, 0, 0, 0, 0, DateTimeKind.Local), 204, "Paris, France", 48.858825500000002, 2.2646343999999998, 18.0, 2, "Lille, France", 50.631073299999997, 3.0056983000000002, new Guid("469c998f-dc2b-4ae5-a0c0-bdb7c95d1c58") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ride",
                keyColumn: "id",
                keyValue: new Guid("66ca49c2-d569-49a6-9398-212e4b0f7b61"));

            migrationBuilder.DeleteData(
                table: "ride",
                keyColumn: "id",
                keyValue: new Guid("7e3b043f-0687-4d4a-83ce-9cf74e36efb0"));

            migrationBuilder.DeleteData(
                table: "ride",
                keyColumn: "id",
                keyValue: new Guid("94078d46-868f-4625-8b72-aea3035f7919"));

            migrationBuilder.DeleteData(
                table: "ride",
                keyColumn: "id",
                keyValue: new Guid("cac31fa3-6d46-4205-9064-0351d593421a"));

            migrationBuilder.DeleteData(
                table: "user",
                keyColumn: "id",
                keyValue: new Guid("4490da7e-5df3-4172-b561-7bcc8466b652"));

            migrationBuilder.DeleteData(
                table: "user",
                keyColumn: "id",
                keyValue: new Guid("dea90259-90fb-4fd2-b5e2-3f4425450188"));

            migrationBuilder.DeleteData(
                table: "user",
                keyColumn: "id",
                keyValue: new Guid("469c998f-dc2b-4ae5-a0c0-bdb7c95d1c58"));

            migrationBuilder.DeleteData(
                table: "user",
                keyColumn: "id",
                keyValue: new Guid("953885b2-3981-44c6-bede-ac08235e3f6d"));

            migrationBuilder.DeleteData(
                table: "user",
                keyColumn: "id",
                keyValue: new Guid("b38c2338-d1d7-4517-9bd5-e9eabffe7abc"));

            migrationBuilder.DeleteData(
                table: "user",
                keyColumn: "id",
                keyValue: new Guid("d9cb2561-4334-4d70-87b9-4eca57c71a8d"));

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
    }
}
