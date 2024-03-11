using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EVS.Api.Migrations
{
    /// <inheritdoc />
    public partial class RideCitiesRemoveCountry : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "feedback",
                keyColumn: "id",
                keyValue: new Guid("0889e272-b4dc-4d28-be1b-7de4e3b91052"));

            migrationBuilder.DeleteData(
                table: "feedback",
                keyColumn: "id",
                keyValue: new Guid("92b87608-1b4c-46a5-9ace-510a23968f43"));

            migrationBuilder.DeleteData(
                table: "feedback",
                keyColumn: "id",
                keyValue: new Guid("b3c288c6-40fb-45fe-8d2c-c80bcefc3d34"));

            migrationBuilder.DeleteData(
                table: "reservation",
                keyColumn: "id",
                keyValue: new Guid("03d2a42a-75f1-406b-ba56-d79f95b00a32"));

            migrationBuilder.DeleteData(
                table: "reservation",
                keyColumn: "id",
                keyValue: new Guid("23e6f72c-14b1-4711-9c3b-726b0d4307f1"));

            migrationBuilder.DeleteData(
                table: "reservation",
                keyColumn: "id",
                keyValue: new Guid("eb1e438e-d58b-48a7-b1ea-a6e1b8702099"));

            migrationBuilder.DeleteData(
                table: "ride",
                keyColumn: "id",
                keyValue: new Guid("027bb1a5-3b3a-4c45-859b-08b7bc348066"));

            migrationBuilder.DeleteData(
                table: "ride",
                keyColumn: "id",
                keyValue: new Guid("67bbec32-0215-462e-b3a4-9be1c8a2d76a"));

            migrationBuilder.DeleteData(
                table: "ride",
                keyColumn: "id",
                keyValue: new Guid("cca30e4b-df1e-4d9d-8f0a-c873a5b8c62b"));

            migrationBuilder.DeleteData(
                table: "user",
                keyColumn: "id",
                keyValue: new Guid("b0a18210-e7f5-4958-afa4-add6487493d5"));

            migrationBuilder.DeleteData(
                table: "ride",
                keyColumn: "id",
                keyValue: new Guid("61b5b763-d75c-4427-b682-0ea1122acff9"));

            migrationBuilder.DeleteData(
                table: "ride",
                keyColumn: "id",
                keyValue: new Guid("7378c9f9-d9c8-423d-9772-ecfca262275b"));

            migrationBuilder.DeleteData(
                table: "ride",
                keyColumn: "id",
                keyValue: new Guid("a1f6a354-291c-4e28-b3bf-4af55e61117d"));

            migrationBuilder.DeleteData(
                table: "user",
                keyColumn: "id",
                keyValue: new Guid("344798dd-0fae-464b-a786-fe36c5bfab81"));

            migrationBuilder.DeleteData(
                table: "user",
                keyColumn: "id",
                keyValue: new Guid("b34f675c-7cfa-4fa1-a41b-e212c1c9b23f"));

            migrationBuilder.DeleteData(
                table: "user",
                keyColumn: "id",
                keyValue: new Guid("2a3248c5-61ce-44ec-b90d-f92ff0413f26"));

            migrationBuilder.DeleteData(
                table: "user",
                keyColumn: "id",
                keyValue: new Guid("2dd093b9-1d5a-47d8-be08-e1cea5a614dc"));

            migrationBuilder.DeleteData(
                table: "user",
                keyColumn: "id",
                keyValue: new Guid("9f34ba54-c9d3-462b-adad-aefc13e9b53f"));

            migrationBuilder.InsertData(
                table: "user",
                columns: new[] { "id", "birthday", "car_description", "email", "firstname", "lastname", "password", "phone_number", "photo", "pseudo" },
                values: new object[,]
                {
                    { new Guid("13f06521-e031-44ef-9706-7010a42632e3"), new DateTime(1974, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lexus", "ddroogan1@thetimes.co.uk", "Nap", "Droogan", "tH0)I/Mt<xZwz2", "0322458382", "https://thispersondoesnotexist.com/", "ddroogan1" },
                    { new Guid("1b91145c-99ce-4fc3-93f8-96101ad9051c"), new DateTime(1997, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "BMW", "cgrigorkin4@theatlantic.com", "Carlota", "Grigorkin", "tZ9\\4s(DQvnvE", "0494223557", "https://thispersondoesnotexist.com/", "cgrigorkin4" },
                    { new Guid("2a9863cf-594e-457d-b66b-d8aca5910f03"), new DateTime(1984, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Austin", "lhair3@wikipedia.org", "Lindsey", "Hair", "eE0'6STA~9O#Suj{", "0162842195", "https://thispersondoesnotexist.com/", "lhair3" },
                    { new Guid("b4057738-115f-4f5b-be4a-fac4b4bc2973"), new DateTime(1998, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Daewoo", "naldren0@webeden.co.uk", "Amye", "Colchett", "aB0.oB?iBy\\", "0337862430", "https://thispersondoesnotexist.com/", "acolchett0" },
                    { new Guid("b723946a-cac5-4057-8599-84456b7810bd"), new DateTime(2024, 3, 11, 14, 38, 5, 318, DateTimeKind.Local).AddTicks(2558), "", "admin@envoituresimone.com", "Admin", "Admin", "admin", "0102030405", "https://thispersondoesnotexist.com/", "admin" },
                    { new Guid("df5c8c86-1208-4c11-837b-096e5714028f"), new DateTime(1988, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jeep", "kpedwell2@icq.com", "Kordula", "Pedwell", "pH3+&{WpvdT", "0903434966", "https://thispersondoesnotexist.com/", "kpedwell2" }
                });

            migrationBuilder.InsertData(
                table: "ride",
                columns: new[] { "id", "departure", "distance", "end_city", "end_latitude", "end_longitude", "price", "seats", "start_city", "start_latitude", "start_longitude", "user_id" },
                values: new object[,]
                {
                    { new Guid("06fd92f4-0780-4546-9f2b-7d10dadd3cf1"), new DateTime(2024, 3, 17, 0, 0, 0, 0, DateTimeKind.Local), 204, "Paris", 48.858825500000002, 2.2646343999999998, 18.0, 2, "Lille", 50.631073299999997, 3.0056983000000002, new Guid("df5c8c86-1208-4c11-837b-096e5714028f") },
                    { new Guid("13eeeb6b-c8cf-4e6e-9787-7bfb201277d9"), new DateTime(2024, 3, 21, 0, 0, 0, 0, DateTimeKind.Local), 204, "Lille", 50.631073299999997, 3.0056983000000002, 23.0, 4, "Paris", 48.858825500000002, 2.2646343999999998, new Guid("13f06521-e031-44ef-9706-7010a42632e3") },
                    { new Guid("33d38d13-1585-4ec9-a386-abfb7a72eb0d"), new DateTime(2024, 3, 7, 0, 0, 0, 0, DateTimeKind.Local), 699, "Lille", 50.631073299999997, 50.631073299999997, 52.0, 2, "Bordeaux", 44.841225000000001, -0.580036, new Guid("1b91145c-99ce-4fc3-93f8-96101ad9051c") },
                    { new Guid("47082532-3371-45c8-a370-f8207e2deb05"), new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Local), 435, "Bordeaux", 44.841225000000001, -0.580036, 46.0, 3, "Lyon", 45.757814000000003, 4.8320109999999996, new Guid("1b91145c-99ce-4fc3-93f8-96101ad9051c") },
                    { new Guid("4ae3ccf2-b310-412a-be25-5cd9d3f343af"), new DateTime(2024, 3, 28, 0, 0, 0, 0, DateTimeKind.Local), 660, "Marseille", 43.280226999999996, 5.2158397000000001, 39.0, 1, "Paris", 48.858825500000002, 2.2646343999999998, new Guid("1b91145c-99ce-4fc3-93f8-96101ad9051c") },
                    { new Guid("776df38f-38ea-409c-ac94-34748893411d"), new DateTime(2024, 3, 16, 0, 0, 0, 0, DateTimeKind.Local), 204, "Paris", 48.858825500000002, 2.2646343999999998, 20.0, 3, "Lille", 50.631073299999997, 3.0056983000000002, new Guid("b4057738-115f-4f5b-be4a-fac4b4bc2973") }
                });

            migrationBuilder.InsertData(
                table: "feedback",
                columns: new[] { "id", "comments", "note", "ride_id", "user_id" },
                values: new object[,]
                {
                    { new Guid("2a9669e7-7177-4462-8f0f-4b63b6bcdbed"), "En Voiture Simone qui m'envoie une notif pour me dire que je suis éligible à la prime de l'Etat de 100€ pour encourager le convoiturage mdrrr ok il me manque juste le permis mais sinon ok je suis éligible 😭", 5, new Guid("33d38d13-1585-4ec9-a386-abfb7a72eb0d"), new Guid("13f06521-e031-44ef-9706-7010a42632e3") },
                    { new Guid("992fb456-ac93-49cf-84de-cd7f58d9a1af"), "J'ai pris un EVS à cause de la grève sncf. Au bout de dix minutes de discussion, il y a un passager qui dit \"Eh ca vous dis pas un covoiturage où tout le monde ferme sa gueule ?\"\r\nGrand silence depuis, plus personne ose parler.", 4, new Guid("33d38d13-1585-4ec9-a386-abfb7a72eb0d"), new Guid("b4057738-115f-4f5b-be4a-fac4b4bc2973") },
                    { new Guid("c8c4959e-e9c8-414e-a42a-3350abfa4027"), "suis dans mon EVS il a fermé les fenetres j’ose pas dire que j’ai des cheveux coincés dedans je peux pas bouger omg", 3, new Guid("33d38d13-1585-4ec9-a386-abfb7a72eb0d"), new Guid("2a9863cf-594e-457d-b66b-d8aca5910f03") }
                });

            migrationBuilder.InsertData(
                table: "reservation",
                columns: new[] { "id", "reservation_date", "ride_id", "status", "user_id" },
                values: new object[,]
                {
                    { new Guid("16e642de-0662-414f-974f-84df85bd713d"), new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Local), new Guid("06fd92f4-0780-4546-9f2b-7d10dadd3cf1"), 1, new Guid("2a9863cf-594e-457d-b66b-d8aca5910f03") },
                    { new Guid("62238bf6-fdd7-4a01-91b0-a7edd35d2b4a"), new DateTime(2024, 3, 9, 0, 0, 0, 0, DateTimeKind.Local), new Guid("13eeeb6b-c8cf-4e6e-9787-7bfb201277d9"), 2, new Guid("1b91145c-99ce-4fc3-93f8-96101ad9051c") },
                    { new Guid("ac0f6065-0ff4-4884-b7a2-44d00ea4d42d"), new DateTime(2024, 3, 8, 0, 0, 0, 0, DateTimeKind.Local), new Guid("06fd92f4-0780-4546-9f2b-7d10dadd3cf1"), 1, new Guid("df5c8c86-1208-4c11-837b-096e5714028f") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "feedback",
                keyColumn: "id",
                keyValue: new Guid("2a9669e7-7177-4462-8f0f-4b63b6bcdbed"));

            migrationBuilder.DeleteData(
                table: "feedback",
                keyColumn: "id",
                keyValue: new Guid("992fb456-ac93-49cf-84de-cd7f58d9a1af"));

            migrationBuilder.DeleteData(
                table: "feedback",
                keyColumn: "id",
                keyValue: new Guid("c8c4959e-e9c8-414e-a42a-3350abfa4027"));

            migrationBuilder.DeleteData(
                table: "reservation",
                keyColumn: "id",
                keyValue: new Guid("16e642de-0662-414f-974f-84df85bd713d"));

            migrationBuilder.DeleteData(
                table: "reservation",
                keyColumn: "id",
                keyValue: new Guid("62238bf6-fdd7-4a01-91b0-a7edd35d2b4a"));

            migrationBuilder.DeleteData(
                table: "reservation",
                keyColumn: "id",
                keyValue: new Guid("ac0f6065-0ff4-4884-b7a2-44d00ea4d42d"));

            migrationBuilder.DeleteData(
                table: "ride",
                keyColumn: "id",
                keyValue: new Guid("47082532-3371-45c8-a370-f8207e2deb05"));

            migrationBuilder.DeleteData(
                table: "ride",
                keyColumn: "id",
                keyValue: new Guid("4ae3ccf2-b310-412a-be25-5cd9d3f343af"));

            migrationBuilder.DeleteData(
                table: "ride",
                keyColumn: "id",
                keyValue: new Guid("776df38f-38ea-409c-ac94-34748893411d"));

            migrationBuilder.DeleteData(
                table: "user",
                keyColumn: "id",
                keyValue: new Guid("b723946a-cac5-4057-8599-84456b7810bd"));

            migrationBuilder.DeleteData(
                table: "ride",
                keyColumn: "id",
                keyValue: new Guid("06fd92f4-0780-4546-9f2b-7d10dadd3cf1"));

            migrationBuilder.DeleteData(
                table: "ride",
                keyColumn: "id",
                keyValue: new Guid("13eeeb6b-c8cf-4e6e-9787-7bfb201277d9"));

            migrationBuilder.DeleteData(
                table: "ride",
                keyColumn: "id",
                keyValue: new Guid("33d38d13-1585-4ec9-a386-abfb7a72eb0d"));

            migrationBuilder.DeleteData(
                table: "user",
                keyColumn: "id",
                keyValue: new Guid("2a9863cf-594e-457d-b66b-d8aca5910f03"));

            migrationBuilder.DeleteData(
                table: "user",
                keyColumn: "id",
                keyValue: new Guid("b4057738-115f-4f5b-be4a-fac4b4bc2973"));

            migrationBuilder.DeleteData(
                table: "user",
                keyColumn: "id",
                keyValue: new Guid("13f06521-e031-44ef-9706-7010a42632e3"));

            migrationBuilder.DeleteData(
                table: "user",
                keyColumn: "id",
                keyValue: new Guid("1b91145c-99ce-4fc3-93f8-96101ad9051c"));

            migrationBuilder.DeleteData(
                table: "user",
                keyColumn: "id",
                keyValue: new Guid("df5c8c86-1208-4c11-837b-096e5714028f"));

            migrationBuilder.InsertData(
                table: "user",
                columns: new[] { "id", "birthday", "car_description", "email", "firstname", "lastname", "password", "phone_number", "photo", "pseudo" },
                values: new object[,]
                {
                    { new Guid("2a3248c5-61ce-44ec-b90d-f92ff0413f26"), new DateTime(1974, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lexus", "ddroogan1@thetimes.co.uk", "Nap", "Droogan", "tH0)I/Mt<xZwz2", "0322458382", "https://thispersondoesnotexist.com/", "ddroogan1" },
                    { new Guid("2dd093b9-1d5a-47d8-be08-e1cea5a614dc"), new DateTime(1997, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "BMW", "cgrigorkin4@theatlantic.com", "Carlota", "Grigorkin", "tZ9\\4s(DQvnvE", "0494223557", "https://thispersondoesnotexist.com/", "cgrigorkin4" },
                    { new Guid("344798dd-0fae-464b-a786-fe36c5bfab81"), new DateTime(1998, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Daewoo", "naldren0@webeden.co.uk", "Amye", "Colchett", "aB0.oB?iBy\\", "0337862430", "https://thispersondoesnotexist.com/", "acolchett0" },
                    { new Guid("9f34ba54-c9d3-462b-adad-aefc13e9b53f"), new DateTime(1988, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jeep", "kpedwell2@icq.com", "Kordula", "Pedwell", "pH3+&{WpvdT", "0903434966", "https://thispersondoesnotexist.com/", "kpedwell2" },
                    { new Guid("b0a18210-e7f5-4958-afa4-add6487493d5"), new DateTime(2024, 3, 11, 14, 23, 40, 494, DateTimeKind.Local).AddTicks(8752), "", "admin@envoituresimone.com", "Admin", "Admin", "admin", "0102030405", "https://thispersondoesnotexist.com/", "admin" },
                    { new Guid("b34f675c-7cfa-4fa1-a41b-e212c1c9b23f"), new DateTime(1984, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Austin", "lhair3@wikipedia.org", "Lindsey", "Hair", "eE0'6STA~9O#Suj{", "0162842195", "https://thispersondoesnotexist.com/", "lhair3" }
                });

            migrationBuilder.InsertData(
                table: "ride",
                columns: new[] { "id", "departure", "distance", "end_city", "end_latitude", "end_longitude", "price", "seats", "start_city", "start_latitude", "start_longitude", "user_id" },
                values: new object[,]
                {
                    { new Guid("027bb1a5-3b3a-4c45-859b-08b7bc348066"), new DateTime(2024, 3, 16, 0, 0, 0, 0, DateTimeKind.Local), 204, "Paris, France", 48.858825500000002, 2.2646343999999998, 20.0, 3, "Lille, France", 50.631073299999997, 3.0056983000000002, new Guid("344798dd-0fae-464b-a786-fe36c5bfab81") },
                    { new Guid("61b5b763-d75c-4427-b682-0ea1122acff9"), new DateTime(2024, 3, 17, 0, 0, 0, 0, DateTimeKind.Local), 204, "Paris, France", 48.858825500000002, 2.2646343999999998, 18.0, 2, "Lille, France", 50.631073299999997, 3.0056983000000002, new Guid("9f34ba54-c9d3-462b-adad-aefc13e9b53f") },
                    { new Guid("67bbec32-0215-462e-b3a4-9be1c8a2d76a"), new DateTime(2024, 3, 28, 0, 0, 0, 0, DateTimeKind.Local), 660, "Marseille, France", 43.280226999999996, 5.2158397000000001, 39.0, 1, "Paris, France", 48.858825500000002, 2.2646343999999998, new Guid("2dd093b9-1d5a-47d8-be08-e1cea5a614dc") },
                    { new Guid("7378c9f9-d9c8-423d-9772-ecfca262275b"), new DateTime(2024, 3, 21, 0, 0, 0, 0, DateTimeKind.Local), 204, "Lille, France", 50.631073299999997, 3.0056983000000002, 23.0, 4, "Paris, France", 48.858825500000002, 2.2646343999999998, new Guid("2a3248c5-61ce-44ec-b90d-f92ff0413f26") },
                    { new Guid("a1f6a354-291c-4e28-b3bf-4af55e61117d"), new DateTime(2024, 3, 7, 0, 0, 0, 0, DateTimeKind.Local), 699, "Lille, France", 50.631073299999997, 50.631073299999997, 52.0, 2, "Bordeaux, France", 44.841225000000001, -0.580036, new Guid("2dd093b9-1d5a-47d8-be08-e1cea5a614dc") },
                    { new Guid("cca30e4b-df1e-4d9d-8f0a-c873a5b8c62b"), new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Local), 435, "Bordeaux, France", 44.841225000000001, -0.580036, 46.0, 3, "Lyon, France", 45.757814000000003, 4.8320109999999996, new Guid("2dd093b9-1d5a-47d8-be08-e1cea5a614dc") }
                });

            migrationBuilder.InsertData(
                table: "feedback",
                columns: new[] { "id", "comments", "note", "ride_id", "user_id" },
                values: new object[,]
                {
                    { new Guid("0889e272-b4dc-4d28-be1b-7de4e3b91052"), "En Voiture Simone qui m'envoie une notif pour me dire que je suis éligible à la prime de l'Etat de 100€ pour encourager le convoiturage mdrrr ok il me manque juste le permis mais sinon ok je suis éligible 😭", 5, new Guid("a1f6a354-291c-4e28-b3bf-4af55e61117d"), new Guid("2a3248c5-61ce-44ec-b90d-f92ff0413f26") },
                    { new Guid("92b87608-1b4c-46a5-9ace-510a23968f43"), "suis dans mon EVS il a fermé les fenetres j’ose pas dire que j’ai des cheveux coincés dedans je peux pas bouger omg", 3, new Guid("a1f6a354-291c-4e28-b3bf-4af55e61117d"), new Guid("b34f675c-7cfa-4fa1-a41b-e212c1c9b23f") },
                    { new Guid("b3c288c6-40fb-45fe-8d2c-c80bcefc3d34"), "J'ai pris un EVS à cause de la grève sncf. Au bout de dix minutes de discussion, il y a un passager qui dit \"Eh ca vous dis pas un covoiturage où tout le monde ferme sa gueule ?\"\r\nGrand silence depuis, plus personne ose parler.", 4, new Guid("a1f6a354-291c-4e28-b3bf-4af55e61117d"), new Guid("344798dd-0fae-464b-a786-fe36c5bfab81") }
                });

            migrationBuilder.InsertData(
                table: "reservation",
                columns: new[] { "id", "reservation_date", "ride_id", "status", "user_id" },
                values: new object[,]
                {
                    { new Guid("03d2a42a-75f1-406b-ba56-d79f95b00a32"), new DateTime(2024, 3, 8, 0, 0, 0, 0, DateTimeKind.Local), new Guid("61b5b763-d75c-4427-b682-0ea1122acff9"), 1, new Guid("9f34ba54-c9d3-462b-adad-aefc13e9b53f") },
                    { new Guid("23e6f72c-14b1-4711-9c3b-726b0d4307f1"), new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Local), new Guid("61b5b763-d75c-4427-b682-0ea1122acff9"), 1, new Guid("b34f675c-7cfa-4fa1-a41b-e212c1c9b23f") },
                    { new Guid("eb1e438e-d58b-48a7-b1ea-a6e1b8702099"), new DateTime(2024, 3, 9, 0, 0, 0, 0, DateTimeKind.Local), new Guid("7378c9f9-d9c8-423d-9772-ecfca262275b"), 2, new Guid("2dd093b9-1d5a-47d8-be08-e1cea5a614dc") }
                });
        }
    }
}
