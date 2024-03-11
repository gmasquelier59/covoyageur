using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EVS.Api.Migrations
{
    /// <inheritdoc />
    public partial class RideHours : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("1a284bf2-84bd-48da-89b4-ceaff5540001"), new DateTime(1984, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Austin", "lhair3@wikipedia.org", "Lindsey", "Hair", "eE0'6STA~9O#Suj{", "0162842195", "https://thispersondoesnotexist.com/", "lhair3" },
                    { new Guid("1ecfb3f3-cbd1-4645-a9c4-786545285bec"), new DateTime(2024, 3, 11, 15, 17, 23, 206, DateTimeKind.Local).AddTicks(3130), "", "admin@envoituresimone.com", "Admin", "Admin", "admin", "0102030405", "https://thispersondoesnotexist.com/", "admin" },
                    { new Guid("3ed49088-8824-47c8-9005-5f7526e92099"), new DateTime(1974, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lexus", "ddroogan1@thetimes.co.uk", "Nap", "Droogan", "tH0)I/Mt<xZwz2", "0322458382", "https://thispersondoesnotexist.com/", "ddroogan1" },
                    { new Guid("76b74fd2-186a-4fc2-a4e3-00995f5adb4a"), new DateTime(1997, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "BMW", "cgrigorkin4@theatlantic.com", "Carlota", "Grigorkin", "tZ9\\4s(DQvnvE", "0494223557", "https://thispersondoesnotexist.com/", "cgrigorkin4" },
                    { new Guid("7db3addc-9bc1-4b11-96e8-c6863c4dfb7b"), new DateTime(1998, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Daewoo", "naldren0@webeden.co.uk", "Amye", "Colchett", "aB0.oB?iBy\\", "0337862430", "https://thispersondoesnotexist.com/", "acolchett0" },
                    { new Guid("9b2e221b-c01a-405d-84b5-5f38fbe956b2"), new DateTime(1988, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jeep", "kpedwell2@icq.com", "Kordula", "Pedwell", "pH3+&{WpvdT", "0903434966", "https://thispersondoesnotexist.com/", "kpedwell2" }
                });

            migrationBuilder.InsertData(
                table: "ride",
                columns: new[] { "id", "departure", "distance", "end_city", "end_latitude", "end_longitude", "price", "seats", "start_city", "start_latitude", "start_longitude", "user_id" },
                values: new object[,]
                {
                    { new Guid("3996f952-72ba-46c3-9818-beee4257f3a1"), new DateTime(2024, 3, 28, 5, 0, 0, 0, DateTimeKind.Local), 660, "Marseille", 43.280226999999996, 5.2158397000000001, 39.0, 1, "Paris", 48.858825500000002, 2.2646343999999998, new Guid("76b74fd2-186a-4fc2-a4e3-00995f5adb4a") },
                    { new Guid("67a94c3d-f0d2-483a-ac9b-d140c5d28cd8"), new DateTime(2024, 3, 7, 8, 0, 0, 0, DateTimeKind.Local), 699, "Lille", 50.631073299999997, 50.631073299999997, 52.0, 2, "Bordeaux", 44.841225000000001, -0.580036, new Guid("76b74fd2-186a-4fc2-a4e3-00995f5adb4a") },
                    { new Guid("906a4c29-eccf-4f68-abb4-65a3d1307662"), new DateTime(2024, 3, 16, 7, 0, 0, 0, DateTimeKind.Local), 204, "Paris", 48.858825500000002, 2.2646343999999998, 20.0, 3, "Lille", 50.631073299999997, 3.0056983000000002, new Guid("7db3addc-9bc1-4b11-96e8-c6863c4dfb7b") },
                    { new Guid("97bf8059-5dd3-47aa-b4b2-122030dd08fd"), new DateTime(2024, 3, 20, 4, 0, 0, 0, DateTimeKind.Local), 435, "Bordeaux", 44.841225000000001, -0.580036, 46.0, 3, "Lyon", 45.757814000000003, 4.8320109999999996, new Guid("76b74fd2-186a-4fc2-a4e3-00995f5adb4a") },
                    { new Guid("b75690bc-d5bd-4b8f-923d-5c434355b34f"), new DateTime(2024, 3, 21, 17, 0, 0, 0, DateTimeKind.Local), 204, "Lille", 50.631073299999997, 3.0056983000000002, 23.0, 4, "Paris", 48.858825500000002, 2.2646343999999998, new Guid("3ed49088-8824-47c8-9005-5f7526e92099") },
                    { new Guid("fd77fe65-b625-4a38-bdac-da1735c726c7"), new DateTime(2024, 3, 17, 11, 0, 0, 0, DateTimeKind.Local), 204, "Paris", 48.858825500000002, 2.2646343999999998, 18.0, 2, "Lille", 50.631073299999997, 3.0056983000000002, new Guid("9b2e221b-c01a-405d-84b5-5f38fbe956b2") }
                });

            migrationBuilder.InsertData(
                table: "feedback",
                columns: new[] { "id", "comments", "note", "ride_id", "user_id" },
                values: new object[,]
                {
                    { new Guid("214e5f7f-482b-44b3-9fd3-94d8d21dced3"), "J'ai pris un EVS à cause de la grève sncf. Au bout de dix minutes de discussion, il y a un passager qui dit \"Eh ca vous dis pas un covoiturage où tout le monde ferme sa gueule ?\"\r\nGrand silence depuis, plus personne ose parler.", 4, new Guid("67a94c3d-f0d2-483a-ac9b-d140c5d28cd8"), new Guid("7db3addc-9bc1-4b11-96e8-c6863c4dfb7b") },
                    { new Guid("69ec4c86-8d1d-45c7-87f4-35f96c3480e1"), "En Voiture Simone qui m'envoie une notif pour me dire que je suis éligible à la prime de l'Etat de 100€ pour encourager le convoiturage mdrrr ok il me manque juste le permis mais sinon ok je suis éligible 😭", 5, new Guid("67a94c3d-f0d2-483a-ac9b-d140c5d28cd8"), new Guid("3ed49088-8824-47c8-9005-5f7526e92099") },
                    { new Guid("935d27c5-0a28-4b8d-bcb8-a90b4d56ccdc"), "suis dans mon EVS il a fermé les fenetres j’ose pas dire que j’ai des cheveux coincés dedans je peux pas bouger omg", 3, new Guid("67a94c3d-f0d2-483a-ac9b-d140c5d28cd8"), new Guid("1a284bf2-84bd-48da-89b4-ceaff5540001") }
                });

            migrationBuilder.InsertData(
                table: "reservation",
                columns: new[] { "id", "reservation_date", "ride_id", "status", "user_id" },
                values: new object[,]
                {
                    { new Guid("32cc63f8-d43f-49c2-b72e-263bb5ebc379"), new DateTime(2024, 3, 9, 0, 0, 0, 0, DateTimeKind.Local), new Guid("b75690bc-d5bd-4b8f-923d-5c434355b34f"), 2, new Guid("76b74fd2-186a-4fc2-a4e3-00995f5adb4a") },
                    { new Guid("579f0bfa-f54c-42da-92c5-84c18654392a"), new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Local), new Guid("fd77fe65-b625-4a38-bdac-da1735c726c7"), 1, new Guid("1a284bf2-84bd-48da-89b4-ceaff5540001") },
                    { new Guid("6211ca80-cdc4-4bf5-b67a-3c9ea0bd3540"), new DateTime(2024, 3, 8, 0, 0, 0, 0, DateTimeKind.Local), new Guid("fd77fe65-b625-4a38-bdac-da1735c726c7"), 1, new Guid("9b2e221b-c01a-405d-84b5-5f38fbe956b2") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "feedback",
                keyColumn: "id",
                keyValue: new Guid("214e5f7f-482b-44b3-9fd3-94d8d21dced3"));

            migrationBuilder.DeleteData(
                table: "feedback",
                keyColumn: "id",
                keyValue: new Guid("69ec4c86-8d1d-45c7-87f4-35f96c3480e1"));

            migrationBuilder.DeleteData(
                table: "feedback",
                keyColumn: "id",
                keyValue: new Guid("935d27c5-0a28-4b8d-bcb8-a90b4d56ccdc"));

            migrationBuilder.DeleteData(
                table: "reservation",
                keyColumn: "id",
                keyValue: new Guid("32cc63f8-d43f-49c2-b72e-263bb5ebc379"));

            migrationBuilder.DeleteData(
                table: "reservation",
                keyColumn: "id",
                keyValue: new Guid("579f0bfa-f54c-42da-92c5-84c18654392a"));

            migrationBuilder.DeleteData(
                table: "reservation",
                keyColumn: "id",
                keyValue: new Guid("6211ca80-cdc4-4bf5-b67a-3c9ea0bd3540"));

            migrationBuilder.DeleteData(
                table: "ride",
                keyColumn: "id",
                keyValue: new Guid("3996f952-72ba-46c3-9818-beee4257f3a1"));

            migrationBuilder.DeleteData(
                table: "ride",
                keyColumn: "id",
                keyValue: new Guid("906a4c29-eccf-4f68-abb4-65a3d1307662"));

            migrationBuilder.DeleteData(
                table: "ride",
                keyColumn: "id",
                keyValue: new Guid("97bf8059-5dd3-47aa-b4b2-122030dd08fd"));

            migrationBuilder.DeleteData(
                table: "user",
                keyColumn: "id",
                keyValue: new Guid("1ecfb3f3-cbd1-4645-a9c4-786545285bec"));

            migrationBuilder.DeleteData(
                table: "ride",
                keyColumn: "id",
                keyValue: new Guid("67a94c3d-f0d2-483a-ac9b-d140c5d28cd8"));

            migrationBuilder.DeleteData(
                table: "ride",
                keyColumn: "id",
                keyValue: new Guid("b75690bc-d5bd-4b8f-923d-5c434355b34f"));

            migrationBuilder.DeleteData(
                table: "ride",
                keyColumn: "id",
                keyValue: new Guid("fd77fe65-b625-4a38-bdac-da1735c726c7"));

            migrationBuilder.DeleteData(
                table: "user",
                keyColumn: "id",
                keyValue: new Guid("1a284bf2-84bd-48da-89b4-ceaff5540001"));

            migrationBuilder.DeleteData(
                table: "user",
                keyColumn: "id",
                keyValue: new Guid("7db3addc-9bc1-4b11-96e8-c6863c4dfb7b"));

            migrationBuilder.DeleteData(
                table: "user",
                keyColumn: "id",
                keyValue: new Guid("3ed49088-8824-47c8-9005-5f7526e92099"));

            migrationBuilder.DeleteData(
                table: "user",
                keyColumn: "id",
                keyValue: new Guid("76b74fd2-186a-4fc2-a4e3-00995f5adb4a"));

            migrationBuilder.DeleteData(
                table: "user",
                keyColumn: "id",
                keyValue: new Guid("9b2e221b-c01a-405d-84b5-5f38fbe956b2"));

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
    }
}
