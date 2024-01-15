using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BeatEcoprove.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SwitchSustaineblePointsFromActionToService : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_maintenance_services_maintenance_activities_MaintenanceActi~",
                table: "maintenance_services");

            migrationBuilder.DropIndex(
                name: "IX_maintenance_services_MaintenanceActivityId",
                table: "maintenance_services");

            migrationBuilder.DropColumn(
                name: "MaintenanceActivityId",
                table: "maintenance_services");

            migrationBuilder.DropColumn(
                name: "badge",
                table: "maintenance_activities");

            migrationBuilder.DropColumn(
                name: "title",
                table: "maintenance_activities");

            migrationBuilder.RenameColumn(
                name: "points_of_sustainability",
                table: "maintenance_activities",
                newName: "sustainable_points");

            migrationBuilder.AddColumn<int>(
                name: "sustainable_points",
                table: "maintenance_service_actions",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<Guid>(
                name: "action_id",
                table: "maintenance_activities",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "service_id",
                table: "maintenance_activities",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_maintenance_service_actions_maintenance_service_id",
                table: "maintenance_service_actions",
                column: "maintenance_service_id");

            migrationBuilder.CreateIndex(
                name: "IX_maintenance_activities_action_id",
                table: "maintenance_activities",
                column: "action_id");

            migrationBuilder.CreateIndex(
                name: "IX_maintenance_activities_service_id",
                table: "maintenance_activities",
                column: "service_id");

            migrationBuilder.AddForeignKey(
                name: "FK_maintenance_activities_maintenance_service_actions_action_id",
                table: "maintenance_activities",
                column: "action_id",
                principalTable: "maintenance_service_actions",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_maintenance_activities_maintenance_services_service_id",
                table: "maintenance_activities",
                column: "service_id",
                principalTable: "maintenance_services",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_maintenance_service_actions_maintenance_services_maintenanc~",
                table: "maintenance_service_actions",
                column: "maintenance_service_id",
                principalTable: "maintenance_services",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_maintenance_activities_maintenance_service_actions_action_id",
                table: "maintenance_activities");

            migrationBuilder.DropForeignKey(
                name: "FK_maintenance_activities_maintenance_services_service_id",
                table: "maintenance_activities");

            migrationBuilder.DropForeignKey(
                name: "FK_maintenance_service_actions_maintenance_services_maintenanc~",
                table: "maintenance_service_actions");

            migrationBuilder.DropIndex(
                name: "IX_maintenance_service_actions_maintenance_service_id",
                table: "maintenance_service_actions");

            migrationBuilder.DropIndex(
                name: "IX_maintenance_activities_action_id",
                table: "maintenance_activities");

            migrationBuilder.DropIndex(
                name: "IX_maintenance_activities_service_id",
                table: "maintenance_activities");

            migrationBuilder.DropColumn(
                name: "sustainable_points",
                table: "maintenance_service_actions");

            migrationBuilder.DropColumn(
                name: "action_id",
                table: "maintenance_activities");

            migrationBuilder.DropColumn(
                name: "service_id",
                table: "maintenance_activities");

            migrationBuilder.RenameColumn(
                name: "sustainable_points",
                table: "maintenance_activities",
                newName: "points_of_sustainability");

            migrationBuilder.AddColumn<Guid>(
                name: "MaintenanceActivityId",
                table: "maintenance_services",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "badge",
                table: "maintenance_activities",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "title",
                table: "maintenance_activities",
                type: "character varying(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_maintenance_services_MaintenanceActivityId",
                table: "maintenance_services",
                column: "MaintenanceActivityId");

            migrationBuilder.AddForeignKey(
                name: "FK_maintenance_services_maintenance_activities_MaintenanceActi~",
                table: "maintenance_services",
                column: "MaintenanceActivityId",
                principalTable: "maintenance_activities",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
