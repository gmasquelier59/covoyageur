using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EVS.Api.Migrations
{
    /// <inheritdoc />
    public partial class RidesSeed4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("0da12042-b8cc-46ab-8772-97f87dd38422"), new DateTime(1998, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Daewoo", "naldren0@webeden.co.uk", "Amye", "Colchett", "aB0.oB?iBy\\", "0337862430", "", "acolchett0" },
                    { new Guid("194a1de0-1ade-4d5d-a6d9-329c6ec38d5a"), new DateTime(1997, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "BMW", "cgrigorkin4@theatlantic.com", "Carlota", "Grigorkin", "tZ9\\4s(DQvnvE", "0494223557", "", "cgrigorkin4" },
                    { new Guid("883f59e6-f6db-47ac-b101-dcfb539f6201"), new DateTime(2024, 3, 11, 13, 36, 28, 293, DateTimeKind.Local).AddTicks(6635), "", "admin@envoituresimone.com", "Admin", "Admin", "admin", "0102030405", "", "admin" },
                    { new Guid("8ed6bde4-5d15-42e0-bfd4-2e258ce8223a"), new DateTime(1984, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Austin", "lhair3@wikipedia.org", "Lindsey", "Hair", "eE0'6STA~9O#Suj{", "0162842195", "", "lhair3" },
                    { new Guid("c57082c7-84c4-476e-9227-8626661e59cc"), new DateTime(1974, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lexus", "ddroogan1@thetimes.co.uk", "Nap", "Droogan", "tH0)I/Mt<xZwz2", "0322458382", "", "ddroogan1" },
                    { new Guid("f3942431-2ecf-4045-b8d4-1073fba65490"), new DateTime(1988, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jeep", "kpedwell2@icq.com", "Kordula", "Pedwell", "pH3+&{WpvdT", "0903434966", "", "kpedwell2" }
                });

            migrationBuilder.InsertData(
                table: "ride",
                columns: new[] { "id", "departure", "distance", "end_city", "end_latitude", "end_longitude", "price", "seats", "start_city", "start_latitude", "start_longitude", "user_id" },
                values: new object[,]
                {
                    { new Guid("35c84905-e877-43ea-a06e-8d17bc50ec41"), new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Local), 435, "Bordeaux, France", 44.841225000000001, -0.580036, 46.0, 3, "Lyon, France", 45.757814000000003, 4.8320109999999996, new Guid("194a1de0-1ade-4d5d-a6d9-329c6ec38d5a") },
                    { new Guid("46a946ba-8f98-4d76-b4a7-c97e766bc332"), new DateTime(2024, 3, 16, 0, 0, 0, 0, DateTimeKind.Local), 204, "Paris, France", 48.858825500000002, 2.2646343999999998, 20.0, 3, "Lille, France", 50.631073299999997, 3.0056983000000002, new Guid("0da12042-b8cc-46ab-8772-97f87dd38422") },
                    { new Guid("53af2b5c-d6b2-4078-9ca9-58d25bbf86c6"), new DateTime(2024, 3, 28, 0, 0, 0, 0, DateTimeKind.Local), 660, "Marseille, France", 43.280226999999996, 5.2158397000000001, 39.0, 1, "Paris, France", 48.858825500000002, 2.2646343999999998, new Guid("194a1de0-1ade-4d5d-a6d9-329c6ec38d5a") },
                    { new Guid("7e3130ce-2da7-455f-b7dd-4121dd79e5b8"), new DateTime(2024, 3, 21, 0, 0, 0, 0, DateTimeKind.Local), 204, "Lille, France", 50.631073299999997, 3.0056983000000002, 23.0, 4, "Paris, France", 48.858825500000002, 2.2646343999999998, new Guid("c57082c7-84c4-476e-9227-8626661e59cc") },
                    { new Guid("91820b26-4317-4037-8b6c-1b911d885aee"), new DateTime(2024, 3, 17, 0, 0, 0, 0, DateTimeKind.Local), 204, "Paris, France", 48.858825500000002, 2.2646343999999998, 18.0, 2, "Lille, France", 50.631073299999997, 3.0056983000000002, new Guid("f3942431-2ecf-4045-b8d4-1073fba65490") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ride",
                keyColumn: "id",
                keyValue: new Guid("35c84905-e877-43ea-a06e-8d17bc50ec41"));

            migrationBuilder.DeleteData(
                table: "ride",
                keyColumn: "id",
                keyValue: new Guid("46a946ba-8f98-4d76-b4a7-c97e766bc332"));

            migrationBuilder.DeleteData(
                table: "ride",
                keyColumn: "id",
                keyValue: new Guid("53af2b5c-d6b2-4078-9ca9-58d25bbf86c6"));

            migrationBuilder.DeleteData(
                table: "ride",
                keyColumn: "id",
                keyValue: new Guid("7e3130ce-2da7-455f-b7dd-4121dd79e5b8"));

            migrationBuilder.DeleteData(
                table: "ride",
                keyColumn: "id",
                keyValue: new Guid("91820b26-4317-4037-8b6c-1b911d885aee"));

            migrationBuilder.DeleteData(
                table: "user",
                keyColumn: "id",
                keyValue: new Guid("883f59e6-f6db-47ac-b101-dcfb539f6201"));

            migrationBuilder.DeleteData(
                table: "user",
                keyColumn: "id",
                keyValue: new Guid("8ed6bde4-5d15-42e0-bfd4-2e258ce8223a"));

            migrationBuilder.DeleteData(
                table: "user",
                keyColumn: "id",
                keyValue: new Guid("0da12042-b8cc-46ab-8772-97f87dd38422"));

            migrationBuilder.DeleteData(
                table: "user",
                keyColumn: "id",
                keyValue: new Guid("194a1de0-1ade-4d5d-a6d9-329c6ec38d5a"));

            migrationBuilder.DeleteData(
                table: "user",
                keyColumn: "id",
                keyValue: new Guid("c57082c7-84c4-476e-9227-8626661e59cc"));

            migrationBuilder.DeleteData(
                table: "user",
                keyColumn: "id",
                keyValue: new Guid("f3942431-2ecf-4045-b8d4-1073fba65490"));

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
    }
}
