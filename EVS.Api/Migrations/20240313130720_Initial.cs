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
                    { new Guid("14e5576b-bea6-47a7-963a-a4bd357815be"), true, true, false, false, false, new DateTime(1984, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Austin", "chloechloe@gmail.com", "Chloé", false, "Laurent", "456dffg456", "0162842195", "https://this-person-does-not-exist.com/img/avatar-gen1131946bc643d6ef1643496115dade90.jpg", "chloechloe" },
                    { new Guid("21d95147-04a8-4e9c-8cb7-d52f3247960c"), true, true, false, false, false, new DateTime(1998, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Daewoo", "angedu59@gmail.com", "Ange", false, "Lefebvre", "df45dfh4", "0337862430", "https://this-person-does-not-exist.com/img/avatar-gen1175da31458c1a38f5c53205c1d40c49.jpg", "angedu59" },
                    { new Guid("224779c4-2d81-4c46-b450-0b0d66368e28"), false, false, false, false, false, new DateTime(2024, 3, 13, 14, 7, 20, 5, DateTimeKind.Local).AddTicks(8205), "", "admin@envoituresimone.com", "Admin", true, "Admin", "admin", "0102030405", "https://this-person-does-not-exist.com/img/avatar-gen485cbb48758f0bbe06ed361e18f34d9c.jpg", "admin" },
                    { new Guid("5f429d6d-238a-42ed-865c-7d9b5974e2e2"), true, false, false, false, false, new DateTime(1997, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "BMW", "malolesbains@plage.org", "Malo", false, "Guérin", "zer234efz42", "0494223557", "https://this-person-does-not-exist.com/img/avatar-gen376a50c7287a78e549d58d13a864d15f.jpg", "malolesbains" },
                    { new Guid("656c8201-b6d9-4ae3-b27a-a666de79c41a"), false, true, true, false, false, new DateTime(1988, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jeep", "pokedex@gmail.com", "Agathe", false, "Klein", "fg456gf546", "0903434966", "https://this-person-does-not-exist.com/img/avatar-gen7b7dfa2a253e45ffa4925acc349ffcdc.jpg", "pokemonlover" },
                    { new Guid("915e388f-1196-449a-890e-955058631f11"), false, true, false, true, true, new DateTime(1974, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lexus", "nath@gmail.com", "Nathanaël", false, "Leroy", "456df456fg", "0322458382", "https://this-person-does-not-exist.com/img/avatar-genc4f3be92e510666c0f16aeee2435ed90.jpg", "n@thleroy" }
                });

            migrationBuilder.InsertData(
                table: "ride",
                columns: new[] { "id", "departure", "distance", "end_city", "end_latitude", "end_longitude", "price", "seats", "start_city", "start_latitude", "start_longitude", "user_id" },
                values: new object[,]
                {
                    { new Guid("0600743a-5d3f-4939-a1f3-e65bb26b577e"), new DateTime(2024, 3, 19, 11, 0, 0, 0, DateTimeKind.Local), 204, "Paris", 48.858825500000002, 2.2646343999999998, 18.0, 2, "Lille", 50.631073299999997, 3.0056983000000002, new Guid("656c8201-b6d9-4ae3-b27a-a666de79c41a") },
                    { new Guid("276df4d1-8f8a-4987-8e5e-5f04abca04a3"), new DateTime(2024, 3, 30, 5, 0, 0, 0, DateTimeKind.Local), 660, "Marseille", 43.280226999999996, 5.2158397000000001, 39.0, 1, "Paris", 48.858825500000002, 2.2646343999999998, new Guid("5f429d6d-238a-42ed-865c-7d9b5974e2e2") },
                    { new Guid("4061b41d-8da6-4eb0-949c-aa249e98f764"), new DateTime(2024, 3, 9, 8, 0, 0, 0, DateTimeKind.Local), 699, "Lille", 50.631073299999997, 50.631073299999997, 52.0, 2, "Bordeaux", 44.841225000000001, -0.580036, new Guid("5f429d6d-238a-42ed-865c-7d9b5974e2e2") },
                    { new Guid("4472491c-9e56-4215-a6af-64f0ea2d7359"), new DateTime(2024, 3, 22, 4, 0, 0, 0, DateTimeKind.Local), 435, "Bordeaux", 44.841225000000001, -0.580036, 46.0, 3, "Lyon", 45.757814000000003, 4.8320109999999996, new Guid("5f429d6d-238a-42ed-865c-7d9b5974e2e2") },
                    { new Guid("596bfa1f-ff4f-4390-b6ef-0a32450a2db1"), new DateTime(2024, 3, 18, 7, 0, 0, 0, DateTimeKind.Local), 204, "Paris", 48.858825500000002, 2.2646343999999998, 20.0, 3, "Lille", 50.631073299999997, 3.0056983000000002, new Guid("21d95147-04a8-4e9c-8cb7-d52f3247960c") },
                    { new Guid("85091d80-0d08-48c1-962e-4879f4bde263"), new DateTime(2024, 3, 31, 8, 0, 0, 0, DateTimeKind.Local), 646, "Bordeaux", 44.841225000000001, -0.580036, 45.0, 5, "Marseille", 43.280226999999996, 5.2158397000000001, new Guid("915e388f-1196-449a-890e-955058631f11") },
                    { new Guid("9eaaa699-3336-4ab5-aa5d-ab373f929c07"), new DateTime(2024, 3, 23, 17, 0, 0, 0, DateTimeKind.Local), 204, "Lille", 50.631073299999997, 3.0056983000000002, 23.0, 4, "Paris", 48.858825500000002, 2.2646343999999998, new Guid("915e388f-1196-449a-890e-955058631f11") }
                });

            migrationBuilder.InsertData(
                table: "feedback",
                columns: new[] { "id", "comments", "note", "ride_id", "user_id" },
                values: new object[,]
                {
                    { new Guid("0421c69b-74df-41e5-b88f-d3f1f63cef52"), "suis dans mon EVS il a fermé les fenetres j’ose pas dire que j’ai des cheveux coincés dedans je peux pas bouger omg", 3, new Guid("4061b41d-8da6-4eb0-949c-aa249e98f764"), new Guid("14e5576b-bea6-47a7-963a-a4bd357815be") },
                    { new Guid("1d50af06-45c9-4f7f-9594-dfad606482b5"), "J'ai pris un EVS à cause de la grève sncf. Au bout de dix minutes de discussion, il y a un passager qui dit \"Eh ca vous dis pas un covoiturage où tout le monde ferme sa gueule ?\"\r\nGrand silence depuis, plus personne ose parler.", 4, new Guid("4061b41d-8da6-4eb0-949c-aa249e98f764"), new Guid("21d95147-04a8-4e9c-8cb7-d52f3247960c") },
                    { new Guid("6eaf1501-c41b-47ea-8e74-86fe3cd4bb3b"), "En Voiture Simone qui m'envoie une notif pour me dire que je suis éligible à la prime de l'Etat de 100€ pour encourager le convoiturage mdrrr ok il me manque juste le permis mais sinon ok je suis éligible 😭", 5, new Guid("4061b41d-8da6-4eb0-949c-aa249e98f764"), new Guid("915e388f-1196-449a-890e-955058631f11") }
                });

            migrationBuilder.InsertData(
                table: "reservation",
                columns: new[] { "id", "reservation_date", "ride_id", "status", "user_id" },
                values: new object[,]
                {
                    { new Guid("51302a35-9573-4463-9dac-ba23a2817246"), new DateTime(2024, 3, 11, 0, 0, 0, 0, DateTimeKind.Local), new Guid("9eaaa699-3336-4ab5-aa5d-ab373f929c07"), 2, new Guid("5f429d6d-238a-42ed-865c-7d9b5974e2e2") },
                    { new Guid("63892a8f-4966-481f-b03d-41a22be36496"), new DateTime(2024, 3, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("0600743a-5d3f-4939-a1f3-e65bb26b577e"), 1, new Guid("14e5576b-bea6-47a7-963a-a4bd357815be") },
                    { new Guid("b099e54d-106b-4f25-803b-328c05e7d25f"), new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Local), new Guid("0600743a-5d3f-4939-a1f3-e65bb26b577e"), 1, new Guid("656c8201-b6d9-4ae3-b27a-a666de79c41a") }
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
