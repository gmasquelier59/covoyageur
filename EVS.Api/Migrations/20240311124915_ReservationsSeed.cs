using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EVS.Api.Migrations
{
    /// <inheritdoc />
    public partial class ReservationsSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("51879bb5-18cc-4aeb-b2ce-7ff92b4bd1ba"), new DateTime(1974, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lexus", "ddroogan1@thetimes.co.uk", "Nap", "Droogan", "tH0)I/Mt<xZwz2", "0322458382", "", "ddroogan1" },
                    { new Guid("58eef135-100d-45da-9cbc-dabe6288f162"), new DateTime(2024, 3, 11, 13, 49, 14, 714, DateTimeKind.Local).AddTicks(9156), "", "admin@envoituresimone.com", "Admin", "Admin", "admin", "0102030405", "", "admin" },
                    { new Guid("7b456ebb-0cb0-4a3f-8262-4a48cddee710"), new DateTime(1997, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "BMW", "cgrigorkin4@theatlantic.com", "Carlota", "Grigorkin", "tZ9\\4s(DQvnvE", "0494223557", "", "cgrigorkin4" },
                    { new Guid("a935d881-1d6e-4c0b-a36d-26b4ae371e7f"), new DateTime(1998, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Daewoo", "naldren0@webeden.co.uk", "Amye", "Colchett", "aB0.oB?iBy\\", "0337862430", "", "acolchett0" },
                    { new Guid("a9fa0a54-8e2c-46d4-a457-9c51367ddfca"), new DateTime(1988, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jeep", "kpedwell2@icq.com", "Kordula", "Pedwell", "pH3+&{WpvdT", "0903434966", "", "kpedwell2" },
                    { new Guid("b9cfbd1d-f40c-447d-8270-1a7b3c64ca45"), new DateTime(1984, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Austin", "lhair3@wikipedia.org", "Lindsey", "Hair", "eE0'6STA~9O#Suj{", "0162842195", "", "lhair3" }
                });

            migrationBuilder.InsertData(
                table: "ride",
                columns: new[] { "id", "departure", "distance", "end_city", "end_latitude", "end_longitude", "price", "seats", "start_city", "start_latitude", "start_longitude", "user_id" },
                values: new object[,]
                {
                    { new Guid("0c3dfda0-1d21-479e-a95a-df4ec7762751"), new DateTime(2024, 3, 7, 0, 0, 0, 0, DateTimeKind.Local), 699, "Lille, France", 50.631073299999997, 50.631073299999997, 52.0, 2, "Bordeaux, France", 44.841225000000001, -0.580036, new Guid("7b456ebb-0cb0-4a3f-8262-4a48cddee710") },
                    { new Guid("59ebc358-4602-4a7e-ac4a-8eeaabebadf7"), new DateTime(2024, 3, 17, 0, 0, 0, 0, DateTimeKind.Local), 204, "Paris, France", 48.858825500000002, 2.2646343999999998, 18.0, 2, "Lille, France", 50.631073299999997, 3.0056983000000002, new Guid("a9fa0a54-8e2c-46d4-a457-9c51367ddfca") },
                    { new Guid("68c98202-5674-4d3a-bb9e-3fe11807ebfc"), new DateTime(2024, 3, 21, 0, 0, 0, 0, DateTimeKind.Local), 204, "Lille, France", 50.631073299999997, 3.0056983000000002, 23.0, 4, "Paris, France", 48.858825500000002, 2.2646343999999998, new Guid("51879bb5-18cc-4aeb-b2ce-7ff92b4bd1ba") },
                    { new Guid("6e408262-db26-49a6-addd-ca06744955ba"), new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Local), 435, "Bordeaux, France", 44.841225000000001, -0.580036, 46.0, 3, "Lyon, France", 45.757814000000003, 4.8320109999999996, new Guid("7b456ebb-0cb0-4a3f-8262-4a48cddee710") },
                    { new Guid("72580adb-0b5c-4c6d-a6b8-86e3900e418d"), new DateTime(2024, 3, 16, 0, 0, 0, 0, DateTimeKind.Local), 204, "Paris, France", 48.858825500000002, 2.2646343999999998, 20.0, 3, "Lille, France", 50.631073299999997, 3.0056983000000002, new Guid("a935d881-1d6e-4c0b-a36d-26b4ae371e7f") },
                    { new Guid("bad0b23c-da84-4cd8-a18f-7ffd5d77df67"), new DateTime(2024, 3, 28, 0, 0, 0, 0, DateTimeKind.Local), 660, "Marseille, France", 43.280226999999996, 5.2158397000000001, 39.0, 1, "Paris, France", 48.858825500000002, 2.2646343999999998, new Guid("7b456ebb-0cb0-4a3f-8262-4a48cddee710") }
                });

            migrationBuilder.InsertData(
                table: "reservation",
                columns: new[] { "id", "reservation_date", "ride_id", "status", "user_id" },
                values: new object[,]
                {
                    { new Guid("645d7f57-ef9c-467a-b431-89be2d5907b2"), new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Local), new Guid("0c3dfda0-1d21-479e-a95a-df4ec7762751"), 1, new Guid("b9cfbd1d-f40c-447d-8270-1a7b3c64ca45") },
                    { new Guid("8b12721f-042e-4436-ad57-f8ac7f9b7c55"), new DateTime(2024, 3, 9, 0, 0, 0, 0, DateTimeKind.Local), new Guid("0c3dfda0-1d21-479e-a95a-df4ec7762751"), 2, new Guid("7b456ebb-0cb0-4a3f-8262-4a48cddee710") },
                    { new Guid("8c7e1005-1612-49da-9f37-34197f6609fa"), new DateTime(2024, 3, 8, 0, 0, 0, 0, DateTimeKind.Local), new Guid("0c3dfda0-1d21-479e-a95a-df4ec7762751"), 1, new Guid("7b456ebb-0cb0-4a3f-8262-4a48cddee710") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "reservation",
                keyColumn: "id",
                keyValue: new Guid("645d7f57-ef9c-467a-b431-89be2d5907b2"));

            migrationBuilder.DeleteData(
                table: "reservation",
                keyColumn: "id",
                keyValue: new Guid("8b12721f-042e-4436-ad57-f8ac7f9b7c55"));

            migrationBuilder.DeleteData(
                table: "reservation",
                keyColumn: "id",
                keyValue: new Guid("8c7e1005-1612-49da-9f37-34197f6609fa"));

            migrationBuilder.DeleteData(
                table: "ride",
                keyColumn: "id",
                keyValue: new Guid("59ebc358-4602-4a7e-ac4a-8eeaabebadf7"));

            migrationBuilder.DeleteData(
                table: "ride",
                keyColumn: "id",
                keyValue: new Guid("68c98202-5674-4d3a-bb9e-3fe11807ebfc"));

            migrationBuilder.DeleteData(
                table: "ride",
                keyColumn: "id",
                keyValue: new Guid("6e408262-db26-49a6-addd-ca06744955ba"));

            migrationBuilder.DeleteData(
                table: "ride",
                keyColumn: "id",
                keyValue: new Guid("72580adb-0b5c-4c6d-a6b8-86e3900e418d"));

            migrationBuilder.DeleteData(
                table: "ride",
                keyColumn: "id",
                keyValue: new Guid("bad0b23c-da84-4cd8-a18f-7ffd5d77df67"));

            migrationBuilder.DeleteData(
                table: "user",
                keyColumn: "id",
                keyValue: new Guid("58eef135-100d-45da-9cbc-dabe6288f162"));

            migrationBuilder.DeleteData(
                table: "ride",
                keyColumn: "id",
                keyValue: new Guid("0c3dfda0-1d21-479e-a95a-df4ec7762751"));

            migrationBuilder.DeleteData(
                table: "user",
                keyColumn: "id",
                keyValue: new Guid("51879bb5-18cc-4aeb-b2ce-7ff92b4bd1ba"));

            migrationBuilder.DeleteData(
                table: "user",
                keyColumn: "id",
                keyValue: new Guid("a935d881-1d6e-4c0b-a36d-26b4ae371e7f"));

            migrationBuilder.DeleteData(
                table: "user",
                keyColumn: "id",
                keyValue: new Guid("a9fa0a54-8e2c-46d4-a457-9c51367ddfca"));

            migrationBuilder.DeleteData(
                table: "user",
                keyColumn: "id",
                keyValue: new Guid("b9cfbd1d-f40c-447d-8270-1a7b3c64ca45"));

            migrationBuilder.DeleteData(
                table: "user",
                keyColumn: "id",
                keyValue: new Guid("7b456ebb-0cb0-4a3f-8262-4a48cddee710"));

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
    }
}
