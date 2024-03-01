using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

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
                    car_description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
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
                columns: new[] { "id", "birthday", "car_description", "email", "firstname", "lastname", "password", "phone_number", "photo", "pseudo" },
                values: new object[] { new Guid("89acddfa-00d9-4213-b47d-d821a283e5ba"), new DateTime(2024, 3, 1, 11, 49, 59, 653, DateTimeKind.Local).AddTicks(1369), "", "admin@envoituresimone.com", "Admin", "Admin", "123456789", "0102030405", "", "admin" });

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
