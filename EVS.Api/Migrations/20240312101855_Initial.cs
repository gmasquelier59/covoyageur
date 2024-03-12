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
                    { new Guid("4e199bcf-cd69-4f29-8dff-9222388e9988"), false, false, false, false, false, new DateTime(2024, 3, 12, 11, 18, 54, 980, DateTimeKind.Local).AddTicks(9306), "", "admin@envoituresimone.com", "Admin", true, "Admin", "admin", "0102030405", "https://this-person-does-not-exist.com/img/avatar-gen485cbb48758f0bbe06ed361e18f34d9c.jpg", "admin" },
                    { new Guid("588adbff-9da6-4230-8eaf-ffea4582a67e"), false, true, true, false, false, new DateTime(1988, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jeep", "kpedwell2@icq.com", "Kordula", false, "Pedwell", "pH3+&{WpvdT", "0903434966", "https://this-person-does-not-exist.com/img/avatar-gen7b7dfa2a253e45ffa4925acc349ffcdc.jpg", "kpedwell2" },
                    { new Guid("80bcd0ab-ed65-4e39-8c51-b5a16b0cda77"), false, true, false, true, true, new DateTime(1974, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lexus", "ddroogan1@thetimes.co.uk", "Nap", false, "Droogan", "tH0)I/Mt<xZwz2", "0322458382", "https://this-person-does-not-exist.com/img/avatar-genc4f3be92e510666c0f16aeee2435ed90.jpg", "ddroogan1" },
                    { new Guid("9ce2d194-ea60-4af0-a7dc-4498d6b049ef"), true, true, false, false, false, new DateTime(1998, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Daewoo", "naldren0@webeden.co.uk", "Amye", false, "Colchett", "aB0.oB?iBy\\", "0337862430", "https://this-person-does-not-exist.com/img/avatar-gen1175da31458c1a38f5c53205c1d40c49.jpg", "acolchett0" },
                    { new Guid("bc98b4a9-afa0-49c1-9fc6-8457af77758a"), true, true, false, false, false, new DateTime(1984, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Austin", "lhair3@wikipedia.org", "Lindsey", false, "Hair", "eE0'6STA~9O#Suj{", "0162842195", "https://this-person-does-not-exist.com/img/avatar-gen1131946bc643d6ef1643496115dade90.jpg", "lhair3" },
                    { new Guid("c9469a26-87f5-4019-9d8f-9fa7de4e8050"), true, false, false, false, false, new DateTime(1997, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "BMW", "cgrigorkin4@theatlantic.com", "Carlota", false, "Grigorkin", "tZ9\\4s(DQvnvE", "0494223557", "https://this-person-does-not-exist.com/img/avatar-gen376a50c7287a78e549d58d13a864d15f.jpg", "cgrigorkin4" }
                });

            migrationBuilder.InsertData(
                table: "ride",
                columns: new[] { "id", "departure", "distance", "end_city", "end_latitude", "end_longitude", "price", "seats", "start_city", "start_latitude", "start_longitude", "user_id" },
                values: new object[,]
                {
                    { new Guid("716016f8-a49d-483e-a219-1c530091ecf8"), new DateTime(2024, 3, 8, 8, 0, 0, 0, DateTimeKind.Local), 699, "Lille", 50.631073299999997, 50.631073299999997, 52.0, 2, "Bordeaux", 44.841225000000001, -0.580036, new Guid("c9469a26-87f5-4019-9d8f-9fa7de4e8050") },
                    { new Guid("78602c13-f524-4a98-8f29-1dcf7c112796"), new DateTime(2024, 3, 29, 5, 0, 0, 0, DateTimeKind.Local), 660, "Marseille", 43.280226999999996, 5.2158397000000001, 39.0, 1, "Paris", 48.858825500000002, 2.2646343999999998, new Guid("c9469a26-87f5-4019-9d8f-9fa7de4e8050") },
                    { new Guid("8d4a638d-13b6-4cc3-ab3c-58af25cd208f"), new DateTime(2024, 3, 18, 11, 0, 0, 0, DateTimeKind.Local), 204, "Paris", 48.858825500000002, 2.2646343999999998, 18.0, 2, "Lille", 50.631073299999997, 3.0056983000000002, new Guid("588adbff-9da6-4230-8eaf-ffea4582a67e") },
                    { new Guid("b2d8e9b1-2e72-40ee-9d07-a1478b743dc0"), new DateTime(2024, 3, 21, 4, 0, 0, 0, DateTimeKind.Local), 435, "Bordeaux", 44.841225000000001, -0.580036, 46.0, 3, "Lyon", 45.757814000000003, 4.8320109999999996, new Guid("c9469a26-87f5-4019-9d8f-9fa7de4e8050") },
                    { new Guid("be408512-a07c-4c8e-818e-78b2e6ae4da4"), new DateTime(2024, 3, 22, 17, 0, 0, 0, DateTimeKind.Local), 204, "Lille", 50.631073299999997, 3.0056983000000002, 23.0, 4, "Paris", 48.858825500000002, 2.2646343999999998, new Guid("80bcd0ab-ed65-4e39-8c51-b5a16b0cda77") },
                    { new Guid("d95ee668-9841-4875-8f66-b2489ba6557b"), new DateTime(2024, 3, 17, 7, 0, 0, 0, DateTimeKind.Local), 204, "Paris", 48.858825500000002, 2.2646343999999998, 20.0, 3, "Lille", 50.631073299999997, 3.0056983000000002, new Guid("9ce2d194-ea60-4af0-a7dc-4498d6b049ef") }
                });

            migrationBuilder.InsertData(
                table: "feedback",
                columns: new[] { "id", "comments", "note", "ride_id", "user_id" },
                values: new object[,]
                {
                    { new Guid("21830793-ab65-4f07-a76c-b0980ef81c0a"), "En Voiture Simone qui m'envoie une notif pour me dire que je suis éligible à la prime de l'Etat de 100€ pour encourager le convoiturage mdrrr ok il me manque juste le permis mais sinon ok je suis éligible 😭", 5, new Guid("716016f8-a49d-483e-a219-1c530091ecf8"), new Guid("80bcd0ab-ed65-4e39-8c51-b5a16b0cda77") },
                    { new Guid("af3bd3d6-9216-4989-b22f-0941d3452045"), "suis dans mon EVS il a fermé les fenetres j’ose pas dire que j’ai des cheveux coincés dedans je peux pas bouger omg", 3, new Guid("716016f8-a49d-483e-a219-1c530091ecf8"), new Guid("bc98b4a9-afa0-49c1-9fc6-8457af77758a") },
                    { new Guid("cc6f01f8-10f2-483d-8c7d-e0766a11ab06"), "J'ai pris un EVS à cause de la grève sncf. Au bout de dix minutes de discussion, il y a un passager qui dit \"Eh ca vous dis pas un covoiturage où tout le monde ferme sa gueule ?\"\r\nGrand silence depuis, plus personne ose parler.", 4, new Guid("716016f8-a49d-483e-a219-1c530091ecf8"), new Guid("9ce2d194-ea60-4af0-a7dc-4498d6b049ef") }
                });

            migrationBuilder.InsertData(
                table: "reservation",
                columns: new[] { "id", "reservation_date", "ride_id", "status", "user_id" },
                values: new object[,]
                {
                    { new Guid("27c76aec-4ea1-4f87-89fa-25590edd9b0f"), new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Local), new Guid("be408512-a07c-4c8e-818e-78b2e6ae4da4"), 2, new Guid("c9469a26-87f5-4019-9d8f-9fa7de4e8050") },
                    { new Guid("8cebb3e5-88ac-46d2-95e0-c4aeeebc26c9"), new DateTime(2024, 3, 11, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8d4a638d-13b6-4cc3-ab3c-58af25cd208f"), 1, new Guid("bc98b4a9-afa0-49c1-9fc6-8457af77758a") },
                    { new Guid("aa6e4a82-e796-4361-9416-e2d92cc07c79"), new DateTime(2024, 3, 9, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8d4a638d-13b6-4cc3-ab3c-58af25cd208f"), 1, new Guid("588adbff-9da6-4230-8eaf-ffea4582a67e") }
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
