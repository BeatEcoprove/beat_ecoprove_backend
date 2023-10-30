using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BeatEcoprove.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "app_users",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    email = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false),
                    name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false),
                    password = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false),
                    phone = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false),
                    phone_country_code = table.Column<string>(type: "character varying(4)", maxLength: 4, nullable: false),
                    avatar_url = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false),
                    type = table.Column<int>(type: "integer", nullable: false),
                    username = table.Column<string>(type: "text", nullable: true),
                    type_option = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    street = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    port = table.Column<int>(type: "integer", nullable: true),
                    locality = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    postal_code = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    sustainability_points = table.Column<int>(type: "integer", nullable: true),
                    xp = table.Column<double>(type: "double precision", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_app_users", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "profiles",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    consumer_id = table.Column<Guid>(type: "uuid", nullable: true),
                    username = table.Column<string>(type: "text", nullable: false),
                    gender = table.Column<int>(type: "integer", nullable: false),
                    xp = table.Column<double>(type: "double precision", nullable: false),
                    born_date = table.Column<DateOnly>(type: "date", nullable: false),
                    sustainability_points = table.Column<double>(type: "double precision", nullable: false),
                    eco_score = table.Column<double>(type: "double precision", nullable: false),
                    avatar_url = table.Column<string>(type: "text", nullable: false),
                    is_main_profile = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_profiles", x => x.id);
                    table.ForeignKey(
                        name: "FK_profiles_app_users_consumer_id",
                        column: x => x.consumer_id,
                        principalTable: "app_users",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "garments",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    profile = table.Column<Guid>(type: "uuid", nullable: false),
                    name = table.Column<string>(type: "text", nullable: false),
                    type = table.Column<int>(type: "integer", nullable: false),
                    size = table.Column<int>(type: "integer", nullable: false),
                    brand = table.Column<string>(type: "text", nullable: false),
                    color = table.Column<string>(type: "text", nullable: false),
                    is_blocked = table.Column<bool>(type: "boolean", nullable: false),
                    ecscore = table.Column<double>(type: "double precision", nullable: false),
                    cloth_avatar = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_garments", x => x.id);
                    table.ForeignKey(
                        name: "FK_garments_profiles_profile",
                        column: x => x.profile,
                        principalTable: "profiles",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_garments_profile",
                table: "garments",
                column: "profile");

            migrationBuilder.CreateIndex(
                name: "IX_profiles_consumer_id",
                table: "profiles",
                column: "consumer_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "garments");

            migrationBuilder.DropTable(
                name: "profiles");

            migrationBuilder.DropTable(
                name: "app_users");
        }
    }
}
