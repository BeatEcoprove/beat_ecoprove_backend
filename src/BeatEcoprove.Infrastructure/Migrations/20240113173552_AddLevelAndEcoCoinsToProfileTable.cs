using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BeatEcoprove.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddLevelAndEcoCoinsToProfileTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_maintenance_services_maintenance_activities_maintenance_act~",
                table: "maintenance_services");

            migrationBuilder.RenameColumn(
                name: "maintenance_activity_id",
                table: "maintenance_services",
                newName: "MaintenanceActivityId");

            migrationBuilder.RenameIndex(
                name: "IX_maintenance_services_maintenance_activity_id",
                table: "maintenance_services",
                newName: "IX_maintenance_services_MaintenanceActivityId");

            migrationBuilder.AddColumn<int>(
                name: "eco_coins",
                table: "profiles",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "level",
                table: "profiles",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "maintenance_service_actions",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    maintenance_service_id = table.Column<Guid>(type: "uuid", nullable: false),
                    title = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    badge = table.Column<string>(type: "text", nullable: false),
                    deleted_at = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_maintenance_service_actions", x => x.id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_maintenance_services_maintenance_activities_MaintenanceActi~",
                table: "maintenance_services",
                column: "MaintenanceActivityId",
                principalTable: "maintenance_activities",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_maintenance_services_maintenance_activities_MaintenanceActi~",
                table: "maintenance_services");

            migrationBuilder.DropTable(
                name: "maintenance_service_actions");

            migrationBuilder.DropColumn(
                name: "eco_coins",
                table: "profiles");

            migrationBuilder.DropColumn(
                name: "level",
                table: "profiles");

            migrationBuilder.RenameColumn(
                name: "MaintenanceActivityId",
                table: "maintenance_services",
                newName: "maintenance_activity_id");

            migrationBuilder.RenameIndex(
                name: "IX_maintenance_services_MaintenanceActivityId",
                table: "maintenance_services",
                newName: "IX_maintenance_services_maintenance_activity_id");

            migrationBuilder.AddForeignKey(
                name: "FK_maintenance_services_maintenance_activities_maintenance_act~",
                table: "maintenance_services",
                column: "maintenance_activity_id",
                principalTable: "maintenance_activities",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
