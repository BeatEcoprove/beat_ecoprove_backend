using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BeatEcoprove.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddMainteneceActivity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EndAt",
                table: "activities",
                newName: "end_at");

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "deleted_at",
                table: "profiles",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "deleted_at",
                table: "colors",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "deleted_at",
                table: "cloths",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "deleted_at",
                table: "cloth_entries",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "deleted_at",
                table: "buckets",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "deleted_at",
                table: "bucket_entries",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "deleted_at",
                table: "bucket_cloths",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "deleted_at",
                table: "brands",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "deleted_at",
                table: "auths",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "deleted_at",
                table: "activities",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "maintenance_activities",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    title = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: false),
                    badge = table.Column<string>(type: "text", nullable: false),
                    points_of_sustainability = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_maintenance_activities", x => x.id);
                    table.ForeignKey(
                        name: "FK_maintenance_activities_activities_id",
                        column: x => x.id,
                        principalTable: "activities",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "maintenance_services",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    maintenance_activity_id = table.Column<Guid>(type: "uuid", nullable: false),
                    badge = table.Column<string>(type: "text", nullable: false),
                    title = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: false),
                    description = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    deleted_at = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_maintenance_services", x => x.id);
                    table.ForeignKey(
                        name: "FK_maintenance_services_maintenance_activities_maintenance_act~",
                        column: x => x.maintenance_activity_id,
                        principalTable: "maintenance_activities",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_maintenance_services_maintenance_activity_id",
                table: "maintenance_services",
                column: "maintenance_activity_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "maintenance_services");

            migrationBuilder.DropTable(
                name: "maintenance_activities");

            migrationBuilder.DropColumn(
                name: "deleted_at",
                table: "profiles");

            migrationBuilder.DropColumn(
                name: "deleted_at",
                table: "colors");

            migrationBuilder.DropColumn(
                name: "deleted_at",
                table: "cloths");

            migrationBuilder.DropColumn(
                name: "deleted_at",
                table: "cloth_entries");

            migrationBuilder.DropColumn(
                name: "deleted_at",
                table: "buckets");

            migrationBuilder.DropColumn(
                name: "deleted_at",
                table: "bucket_entries");

            migrationBuilder.DropColumn(
                name: "deleted_at",
                table: "bucket_cloths");

            migrationBuilder.DropColumn(
                name: "deleted_at",
                table: "brands");

            migrationBuilder.DropColumn(
                name: "deleted_at",
                table: "auths");

            migrationBuilder.DropColumn(
                name: "deleted_at",
                table: "activities");

            migrationBuilder.RenameColumn(
                name: "end_at",
                table: "activities",
                newName: "EndAt");
        }
    }
}