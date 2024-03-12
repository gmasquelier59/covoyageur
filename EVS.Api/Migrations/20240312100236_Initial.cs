using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EVS.Api.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "user",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    lastname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    firstname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    pseudo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    password = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    phone_number = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    birthday = table.Column<DateTime>(type: "datetime2", nullable: false),
                    photo = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    car_description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    is_admin = table.Column<bool>(type: "bit", nullable: false),
                    accept_smoker = table.Column<bool>(type: "bit", nullable: false),
                    accept_pet = table.Column<bool>(type: "bit", nullable: false),
                    accept_talk = table.Column<bool>(type: "bit", nullable: false),
                    accept_music = table.Column<bool>(type: "bit", nullable: false),
                    accept_food = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ride",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    user_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    start_city = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    start_latitude = table.Column<double>(type: "float", nullable: false),
                    start_longitude = table.Column<double>(type: "float", nullable: false),
                    end_city = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    end_latitude = table.Column<double>(type: "float", nullable: false),
                    end_longitude = table.Column<double>(type: "float", nullable: false),
                    distance = table.Column<int>(type: "int", nullable: false),
                    departure = table.Column<DateTime>(type: "datetime2", nullable: false),
                    price = table.Column<double>(type: "float", nullable: false),
                    seats = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ride", x => x.id);
                    table.ForeignKey(
                        name: "FK_ride_user_user_id",
                        column: x => x.user_id,
                        principalTable: "user",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "feedback",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ride_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    user_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    note = table.Column<int>(type: "int", nullable: false),
                    comments = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_feedback", x => x.id);
                    table.ForeignKey(
                        name: "FK_feedback_ride_ride_id",
                        column: x => x.ride_id,
                        principalTable: "ride",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_feedback_user_user_id",
                        column: x => x.user_id,
                        principalTable: "user",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "reservation",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ride_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    user_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    reservation_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_reservation", x => x.id);
                    table.ForeignKey(
                        name: "FK_reservation_ride_ride_id",
                        column: x => x.ride_id,
                        principalTable: "ride",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_reservation_user_user_id",
                        column: x => x.user_id,
                        principalTable: "user",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "user",
                columns: new[] { "id", "accept_food", "accept_music", "accept_pet", "accept_talk", "accept_smoker", "birthday", "car_description", "email", "firstname", "is_admin", "lastname", "password", "phone_number", "photo", "pseudo" },
                values: new object[,]
                {
                    { new Guid("24c952e2-dd86-4ca5-9308-771f2ab597fd"), false, false, false, false, false, new DateTime(1997, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "BMW", "cgrigorkin4@theatlantic.com", "Carlota", false, "Grigorkin", "tZ9\\4s(DQvnvE", "0494223557", "https://thispersondoesnotexist.com/", "cgrigorkin4" },
                    { new Guid("2c08f978-5efd-4471-b487-6df11f5ebd37"), false, false, false, false, false, new DateTime(1988, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jeep", "kpedwell2@icq.com", "Kordula", false, "Pedwell", "pH3+&{WpvdT", "0903434966", "https://thispersondoesnotexist.com/", "kpedwell2" },
                    { new Guid("485e4e29-6217-415c-b438-3d4f114f24d6"), false, false, false, false, false, new DateTime(1984, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Austin", "lhair3@wikipedia.org", "Lindsey", false, "Hair", "eE0'6STA~9O#Suj{", "0162842195", "https://thispersondoesnotexist.com/", "lhair3" },
                    { new Guid("8b2d4c69-f3d5-4d00-b02b-103bd26dd550"), false, false, false, false, false, new DateTime(1998, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Daewoo", "naldren0@webeden.co.uk", "Amye", false, "Colchett", "aB0.oB?iBy\\", "0337862430", "https://thispersondoesnotexist.com/", "acolchett0" },
                    { new Guid("b897d47e-7b3b-4dc0-a028-05d8e2c69659"), false, false, false, false, false, new DateTime(1974, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lexus", "ddroogan1@thetimes.co.uk", "Nap", false, "Droogan", "tH0)I/Mt<xZwz2", "0322458382", "https://thispersondoesnotexist.com/", "ddroogan1" },
                    { new Guid("dca01717-e66d-4aaf-9d66-e4e32847b4b9"), false, false, false, false, false, new DateTime(2024, 3, 12, 11, 2, 35, 171, DateTimeKind.Local).AddTicks(8029), "", "admin@envoituresimone.com", "Admin", true, "Admin", "admin", "0102030405", "https://thispersondoesnotexist.com/", "admin" }
                });

            migrationBuilder.InsertData(
                table: "ride",
                columns: new[] { "id", "departure", "distance", "end_city", "end_latitude", "end_longitude", "price", "seats", "start_city", "start_latitude", "start_longitude", "user_id" },
                values: new object[,]
                {
                    { new Guid("19c699fd-f005-415f-b655-3e8edc9fa9e4"), new DateTime(2024, 3, 21, 4, 0, 0, 0, DateTimeKind.Local), 435, "Bordeaux", 44.841225000000001, -0.580036, 46.0, 3, "Lyon", 45.757814000000003, 4.8320109999999996, new Guid("24c952e2-dd86-4ca5-9308-771f2ab597fd") },
                    { new Guid("2810f5bb-cddf-4f72-854d-4b84a2cf8e02"), new DateTime(2024, 3, 17, 7, 0, 0, 0, DateTimeKind.Local), 204, "Paris", 48.858825500000002, 2.2646343999999998, 20.0, 3, "Lille", 50.631073299999997, 3.0056983000000002, new Guid("8b2d4c69-f3d5-4d00-b02b-103bd26dd550") },
                    { new Guid("3742a581-a8a9-4dca-b95e-8f1b9391e436"), new DateTime(2024, 3, 8, 8, 0, 0, 0, DateTimeKind.Local), 699, "Lille", 50.631073299999997, 50.631073299999997, 52.0, 2, "Bordeaux", 44.841225000000001, -0.580036, new Guid("24c952e2-dd86-4ca5-9308-771f2ab597fd") },
                    { new Guid("4fd3c98e-f891-44be-a932-8b8ab1f07c72"), new DateTime(2024, 3, 29, 5, 0, 0, 0, DateTimeKind.Local), 660, "Marseille", 43.280226999999996, 5.2158397000000001, 39.0, 1, "Paris", 48.858825500000002, 2.2646343999999998, new Guid("24c952e2-dd86-4ca5-9308-771f2ab597fd") },
                    { new Guid("57ab4f5a-31e4-44a4-bd92-b664136b65be"), new DateTime(2024, 3, 18, 11, 0, 0, 0, DateTimeKind.Local), 204, "Paris", 48.858825500000002, 2.2646343999999998, 18.0, 2, "Lille", 50.631073299999997, 3.0056983000000002, new Guid("2c08f978-5efd-4471-b487-6df11f5ebd37") },
                    { new Guid("7d712d7e-f6f8-47b7-9176-8145b4480159"), new DateTime(2024, 3, 22, 17, 0, 0, 0, DateTimeKind.Local), 204, "Lille", 50.631073299999997, 3.0056983000000002, 23.0, 4, "Paris", 48.858825500000002, 2.2646343999999998, new Guid("b897d47e-7b3b-4dc0-a028-05d8e2c69659") }
                });

            migrationBuilder.InsertData(
                table: "feedback",
                columns: new[] { "id", "comments", "note", "ride_id", "user_id" },
                values: new object[,]
                {
                    { new Guid("44e9f84d-5933-481e-97fe-15e1b967855e"), "suis dans mon EVS il a fermé les fenetres j’ose pas dire que j’ai des cheveux coincés dedans je peux pas bouger omg", 3, new Guid("3742a581-a8a9-4dca-b95e-8f1b9391e436"), new Guid("485e4e29-6217-415c-b438-3d4f114f24d6") },
                    { new Guid("799c85fa-a3ec-4ee5-8e2c-fec660893ba7"), "En Voiture Simone qui m'envoie une notif pour me dire que je suis éligible à la prime de l'Etat de 100€ pour encourager le convoiturage mdrrr ok il me manque juste le permis mais sinon ok je suis éligible 😭", 5, new Guid("3742a581-a8a9-4dca-b95e-8f1b9391e436"), new Guid("b897d47e-7b3b-4dc0-a028-05d8e2c69659") },
                    { new Guid("ceb2dd01-4944-44d3-b4db-99a4b6fb032d"), "J'ai pris un EVS à cause de la grève sncf. Au bout de dix minutes de discussion, il y a un passager qui dit \"Eh ca vous dis pas un covoiturage où tout le monde ferme sa gueule ?\"\r\nGrand silence depuis, plus personne ose parler.", 4, new Guid("3742a581-a8a9-4dca-b95e-8f1b9391e436"), new Guid("8b2d4c69-f3d5-4d00-b02b-103bd26dd550") }
                });

            migrationBuilder.InsertData(
                table: "reservation",
                columns: new[] { "id", "reservation_date", "ride_id", "status", "user_id" },
                values: new object[,]
                {
                    { new Guid("804dd9b0-0361-4a40-880a-5d6c5f2e1364"), new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Local), new Guid("7d712d7e-f6f8-47b7-9176-8145b4480159"), 2, new Guid("24c952e2-dd86-4ca5-9308-771f2ab597fd") },
                    { new Guid("ad65bde4-5b18-4dbc-bd85-2c09b669ab8b"), new DateTime(2024, 3, 9, 0, 0, 0, 0, DateTimeKind.Local), new Guid("57ab4f5a-31e4-44a4-bd92-b664136b65be"), 1, new Guid("2c08f978-5efd-4471-b487-6df11f5ebd37") },
                    { new Guid("bea20ab2-b7d9-46d4-bfb7-611035e3ae82"), new DateTime(2024, 3, 11, 0, 0, 0, 0, DateTimeKind.Local), new Guid("57ab4f5a-31e4-44a4-bd92-b664136b65be"), 1, new Guid("485e4e29-6217-415c-b438-3d4f114f24d6") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_feedback_ride_id",
                table: "feedback",
                column: "ride_id");

            migrationBuilder.CreateIndex(
                name: "IX_feedback_user_id",
                table: "feedback",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_reservation_ride_id",
                table: "reservation",
                column: "ride_id");

            migrationBuilder.CreateIndex(
                name: "IX_reservation_user_id",
                table: "reservation",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_ride_user_id",
                table: "ride",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_user_email",
                table: "user",
                column: "email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_user_pseudo",
                table: "user",
                column: "pseudo",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "feedback");

            migrationBuilder.DropTable(
                name: "reservation");

            migrationBuilder.DropTable(
                name: "ride");

            migrationBuilder.DropTable(
                name: "user");
        }
    }
}
