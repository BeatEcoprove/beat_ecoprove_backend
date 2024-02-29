using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BeatEcoprove.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddGroupEntity : Migration
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
                name: "groups",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    description = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false),
                    members_count = table.Column<int>(type: "integer", nullable: false),
                    sustainable_points = table.Column<int>(type: "integer", nullable: false),
                    xp = table.Column<double>(type: "double precision", nullable: false),
                    is_public = table.Column<bool>(type: "boolean", nullable: false),
                    avatar_picture = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false),
                    creator_id = table.Column<Guid>(type: "uuid", nullable: false),
                    DeletedAt = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_groups", x => x.id);
                    table.ForeignKey(
                        name: "FK_groups_profiles_creator_id",
                        column: x => x.creator_id,
                        principalTable: "profiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.CreateTable(
                name: "group_members",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    profile_id = table.Column<Guid>(type: "uuid", nullable: false),
                    group_id = table.Column<Guid>(type: "uuid", nullable: false),
                    permission = table.Column<int>(type: "integer", nullable: false),
                    DeletedAt = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_group_members", x => x.id);
                    table.ForeignKey(
                        name: "FK_group_members_groups_group_id",
                        column: x => x.group_id,
                        principalTable: "groups",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_group_members_profiles_profile_id",
                        column: x => x.profile_id,
                        principalTable: "profiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "group_text_messages",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    DeletedAt = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    group_id = table.Column<Guid>(type: "uuid", nullable: false),
                    sender_id = table.Column<Guid>(type: "uuid", nullable: false),
                    content = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_group_text_messages", x => x.id);
                    table.ForeignKey(
                        name: "FK_group_text_messages_group_members_sender_id",
                        column: x => x.sender_id,
                        principalTable: "group_members",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_group_text_messages_groups_group_id",
                        column: x => x.group_id,
                        principalTable: "groups",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_group_members_group_id",
                table: "group_members",
                column: "group_id");

            migrationBuilder.CreateIndex(
                name: "IX_group_members_profile_id",
                table: "group_members",
                column: "profile_id");

            migrationBuilder.CreateIndex(
                name: "IX_group_text_messages_group_id",
                table: "group_text_messages",
                column: "group_id");

            migrationBuilder.CreateIndex(
                name: "IX_group_text_messages_sender_id",
                table: "group_text_messages",
                column: "sender_id");

            migrationBuilder.CreateIndex(
                name: "IX_groups_creator_id",
                table: "groups",
                column: "creator_id");

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
                name: "group_text_messages");

            migrationBuilder.DropTable(
                name: "maintenance_service_actions");

            migrationBuilder.DropTable(
                name: "group_members");

            migrationBuilder.DropTable(
                name: "groups");

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