using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BeatEcoprove.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddGroupInvitations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: new Guid("41dab51d-748b-4ac8-a381-bf962b59c753"));

            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: new Guid("b772688c-e78d-44a3-9477-37af1345cdf6"));

            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: new Guid("d3cddb6b-0565-4e34-9c79-c2dbe0459381"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("0bb4f382-fb84-4d61-b9f3-4b879274995e"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("16f4a625-d158-4148-a57e-7fb1e03c8313"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("2f948822-9df6-47ae-8668-23cd3fa1e147"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("447366c9-1e2b-44d6-bca6-5aa4be27deba"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("56332dc3-4854-45bc-bc35-d40777398fb8"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("5d56098e-8a05-40a3-83d2-2c5d08659698"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("5fa03383-3de8-4eca-a274-ee6793652c83"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("6bf1c442-8356-4942-bf7f-504d68a448f8"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("7040ae59-2f30-4dd4-8a01-be5d40f7f4f8"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("7224e010-9d45-44d2-a0d9-ae3776800f42"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("742002f8-545a-4561-8b58-f55387d871b4"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("890b0144-6f80-4658-83fa-ab05b2fd8314"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("899f20c0-17b6-4af4-a268-66d96819821b"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("a00bbcb7-5d48-4762-a0bd-e8fa4264e2f1"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("ab117e50-fbb6-454d-8617-d8ae354866c3"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("c885b72c-8d20-4288-8aea-153e41b93820"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("cf07615d-d51c-4961-82cd-b8e12a9eb5a8"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("d51a8cb1-b848-4262-a7fa-2c4b91fd094a"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("dc2d72b0-6c97-4717-beee-214e412c9050"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("e0170db6-31bb-4fae-b5d2-cef16cacaffb"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("f789dd8b-8f57-47ba-96e4-84daa1a199b6"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("3288aeb1-f78c-47db-9ac0-fe6a0b35e77a"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("3c8a7bf0-99bc-414d-9d34-c9797bf8b8fa"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("467ab08c-d8c0-471d-88f2-9d35c1613cf2"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("65e96587-39a2-4bdf-9fa1-b585ae0daf56"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("7426d055-e4bb-4a5c-9103-e757ebdb5782"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("8ebb45b1-975f-47b5-82db-b4803b6d5814"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("8fc36728-f524-4166-86dd-1d68f264520e"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("904067b4-676c-4966-b5ec-c91d391f300b"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("98edd1da-b0b8-4994-8ae8-507fae36d79b"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("ab11baf1-c6db-4d25-a0df-fd0155426226"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("b0d49301-91c8-498d-ae27-fd0facf49763"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("b77e9adb-7806-49d7-a0da-953cd5969f5f"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("c7744c97-44c3-4817-a7f2-0308db1dbced"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("c9266531-a232-4e79-b368-7d57dc15caae"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("d7a1abd6-e947-4ff5-a743-c4e4f4ad5c30"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("f425487a-acb2-47cf-90c9-d1be4ff3d7f1"));

            migrationBuilder.DeleteData(
                table: "maintenance_services",
                keyColumn: "id",
                keyValue: new Guid("039ad0a0-d245-4a9a-8e77-0af7ca025bf4"));

            migrationBuilder.DeleteData(
                table: "maintenance_services",
                keyColumn: "id",
                keyValue: new Guid("211847d3-346d-4692-961b-293587fc5ed1"));

            migrationBuilder.DeleteData(
                table: "maintenance_services",
                keyColumn: "id",
                keyValue: new Guid("3fa3f6d7-0165-4daa-b00e-d09ce56c7e1c"));

            migrationBuilder.DeleteData(
                table: "maintenance_services",
                keyColumn: "id",
                keyValue: new Guid("f59193cd-a717-466b-b5ff-ffdfd5206419"));

            migrationBuilder.AddColumn<Guid>(
                name: "GroupId",
                table: "group_members",
                type: "uuid",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "group_invites",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    target_id = table.Column<Guid>(type: "uuid", nullable: false),
                    group_id = table.Column<Guid>(type: "uuid", nullable: false),
                    inviter_id = table.Column<Guid>(type: "uuid", nullable: false),
                    permission = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    accepted_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    declined_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeletedAt = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_group_invites", x => x.id);
                    table.ForeignKey(
                        name: "FK_group_invites_profiles_inviter_id",
                        column: x => x.inviter_id,
                        principalTable: "profiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_group_invites_profiles_target_id",
                        column: x => x.target_id,
                        principalTable: "profiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "brands",
                columns: new[] { "id", "brand_avatar", "deleted_at", "name" },
                values: new object[,]
                {
                    { new Guid("58842ef7-4552-4081-a90d-71506268d7c7"), "...", null, "Tifosi" },
                    { new Guid("60b14858-40d0-48e3-a554-dc02ffcfbe89"), "...", null, "MO" },
                    { new Guid("64faedc6-ef5d-4927-a863-42aaf08bff2f"), "...", null, "Salsa" }
                });

            migrationBuilder.InsertData(
                table: "colors",
                columns: new[] { "id", "deleted_at", "hex", "name" },
                values: new object[,]
                {
                    { new Guid("1070141a-ac5b-49b9-a852-0bfc3c351fae"), null, "FFFF6D6D", "Vermelho Claro" },
                    { new Guid("1121ec8e-5faf-40d7-9054-f2d270959199"), null, "FFDA252E", "Vermelho" },
                    { new Guid("1410fb71-478a-4de4-af97-a76e67b57362"), null, "FFD62598", "Roxo" },
                    { new Guid("37a0e97f-3a43-48d4-acb2-87840bcf3f59"), null, "FF509C75", "Verde" },
                    { new Guid("37bcbdbc-3034-4ddd-8b79-546d3b9b4a69"), null, "FF000000", "Black" },
                    { new Guid("64caec4b-7ea2-49f1-b332-6eddc76618f0"), null, "FFF9C7C4", "Rosa Claro" },
                    { new Guid("741bd6db-acac-49ea-910b-79be5046dc93"), null, "FFD2AAC5", "Roxo Claro" },
                    { new Guid("7dc5c429-afb3-42ed-a84b-8e4f5701b9b0"), null, "FFC0C0C0", "Cinzento Bebê" },
                    { new Guid("84f59ceb-8e42-4de4-9162-8d2749985a7f"), null, "FF8B5F3C", "Castanho Bebê" },
                    { new Guid("8594d168-8f4d-407f-a620-0ba583688126"), null, "FF4A2D16", "Castanho" },
                    { new Guid("87375553-c075-4b15-92ae-028510b5a820"), null, "FFFFFFFF", "White" },
                    { new Guid("88ca2c07-c224-463c-a586-30c05ee1c30f"), null, "FF948066", "Castanho Claro" },
                    { new Guid("8b40d81c-f282-44d5-88b9-29f8379969a3"), null, "FFFFE69F", "Amarelo" },
                    { new Guid("8e23b400-4fac-4d9f-b659-539e57fa0a79"), null, "FFF58221", "Laranja" },
                    { new Guid("a8372d07-7955-4c24-902f-50596dc19a50"), null, "FF29394A", "Azul Escuro" },
                    { new Guid("c3fb954f-2d79-4e37-8fe1-a61e8c22cfcd"), null, "FFBE5967", "Rosa" },
                    { new Guid("d599c503-7593-453b-9694-a4b2b3eac59a"), null, "FFC3A572", "Amarelo Claro" },
                    { new Guid("dc85c673-cf78-49b4-af3c-dc564de42d57"), null, "FF4C4C4C", "Cinzento Claro" },
                    { new Guid("dd60d2ea-a430-4b1d-8f1e-340dcd707d1d"), null, "FFF2E7D4", "Amarelo Bebê" },
                    { new Guid("de50aa23-3926-458d-b309-5b9832819ba9"), null, "FF98B3C8", "Azul Claro" },
                    { new Guid("e2bf3195-7e00-4d16-8485-716bb7fe302f"), null, "FFC2BC8B", "Verde Lima" }
                });

            migrationBuilder.InsertData(
                table: "maintenance_services",
                columns: new[] { "id", "badge", "deleted_at", "description", "title" },
                values: new object[,]
                {
                    { new Guid("2835ffbd-7599-4e9b-b4ee-b7d901ce901d"), "public/default/repair.png", null, "De que forma pertende arranjar a peça?", "Reparar" },
                    { new Guid("65ea8980-bb69-4c39-8c69-29c9a9cd7975"), "public/default/iron.png", null, "De que forma pertende engomar?", "Engomar" },
                    { new Guid("6c58ab4f-3ac8-42a7-8ee3-d676d77f528a"), "public/default/wash.png", null, "De que forma pertende lavar?", "Lavar" },
                    { new Guid("76c44e7c-ffa6-4ab2-90fa-037b54418fb0"), "public/default/dry.png", null, "De que forma pertende secar?", "Secar" }
                });

            migrationBuilder.InsertData(
                table: "maintenance_service_actions",
                columns: new[] { "id", "badge", "deleted_at", "Description", "eco_score", "maintenance_service_id", "sustainable_points", "title" },
                values: new object[,]
                {
                    { new Guid("059593ea-882d-457b-b087-1ebbe0019e7b"), "public/default/wash/hand.png", null, "Lavar à mão com água e sabão", 10, new Guid("6c58ab4f-3ac8-42a7-8ee3-d676d77f528a"), 100, "Lavar à mão" },
                    { new Guid("1d25e9b2-9b25-4c7d-8a95-690b44b0d2ec"), "public/default/service.png", null, "Escolhe uma lavandaria", 10, new Guid("6c58ab4f-3ac8-42a7-8ee3-d676d77f528a"), 100, "Serviço de lavandaria" },
                    { new Guid("25a02ab7-9872-4a44-b8bf-05f8d6e42bb2"), "public/default/wash/less30.png", null, "Lavar a menos de 30ºC", 10, new Guid("6c58ab4f-3ac8-42a7-8ee3-d676d77f528a"), 100, "A menos de 30ºC" },
                    { new Guid("2be28ff0-f6d4-4267-8887-9b5ea3a8b3b2"), "public/default/wash/less50.png", null, "Lavar a menos de 50ºC", 10, new Guid("6c58ab4f-3ac8-42a7-8ee3-d676d77f528a"), 100, "A menos de 50ºC" },
                    { new Guid("51d4710f-d07a-4de6-a1a0-0fcb78ca2302"), "public/default/dry/machine.png", null, "Secar na máquina", 10, new Guid("76c44e7c-ffa6-4ab2-90fa-037b54418fb0"), 100, "Na máquina" },
                    { new Guid("60df9931-4e7a-4d32-970c-1e3e288d58bc"), "public/default/iron/less150.png", null, "Engomar a menos de 150ºC", 10, new Guid("65ea8980-bb69-4c39-8c69-29c9a9cd7975"), 100, "A menos de 150ºC" },
                    { new Guid("9199a437-16fe-4779-a59d-c34455dab48b"), "public/default/service.png", null, "Escolhe um serviço de Reparação", 10, new Guid("2835ffbd-7599-4e9b-b4ee-b7d901ce901d"), 100, "Serviço de Reparação" },
                    { new Guid("97fbdc16-a5d3-4082-bfb6-c92b1dc8f441"), "public/default/service.png", null, "Escolhe um serviço de secagem", 10, new Guid("76c44e7c-ffa6-4ab2-90fa-037b54418fb0"), 100, "Serviço de Secagem" },
                    { new Guid("a8acb90d-4076-428c-89ba-76f7c24deaba"), "public/default/wash/less70.png", null, "Lavar a menos de 70ºC", 10, new Guid("6c58ab4f-3ac8-42a7-8ee3-d676d77f528a"), 100, "A menos de 70ºC" },
                    { new Guid("b88e3438-43c8-4a14-a529-ca375111a90a"), "public/default/wash/dry.png", null, "Lavar a seco", 10, new Guid("6c58ab4f-3ac8-42a7-8ee3-d676d77f528a"), 100, "A seco" },
                    { new Guid("bec110dd-de06-44dc-805e-45d86c69da77"), "public/default/repair.png", null, "Arranjar a peça pelo próprio", 10, new Guid("2835ffbd-7599-4e9b-b4ee-b7d901ce901d"), 100, "Pelo Próprio" },
                    { new Guid("c197947f-cf1e-4c08-85dc-81115cdc29cd"), "public/default/dry/air.png", null, "Secar ao ar livre", 10, new Guid("76c44e7c-ffa6-4ab2-90fa-037b54418fb0"), 100, "Ao ar livre" },
                    { new Guid("c93e70bb-ed23-4065-899a-1124447a1d17"), "public/default/iron/less110.png", null, "Engomar a menos de 110ºC", 10, new Guid("65ea8980-bb69-4c39-8c69-29c9a9cd7975"), 100, "A menos de 110ºC" },
                    { new Guid("cffb2fc6-5eda-470a-a40d-436ae2b34d0b"), "public/default/service.png", null, "Escolhe um serviço de engomadoria", 10, new Guid("65ea8980-bb69-4c39-8c69-29c9a9cd7975"), 100, "Serviço de Engomadoria" },
                    { new Guid("d8e2c63a-fc6a-4cf7-8efa-a44acedbf823"), "public/default/wash/less95.png", null, "Lavar a menos de 95ºC", 10, new Guid("6c58ab4f-3ac8-42a7-8ee3-d676d77f528a"), 100, "A menos de 95ºC" },
                    { new Guid("efc486ea-1286-4052-a9fe-80c351806ab7"), "public/default/iron/less200.png", null, "Engomar a menos de 200ºC", 10, new Guid("65ea8980-bb69-4c39-8c69-29c9a9cd7975"), 100, "A menos de 200ºC" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_group_members_GroupId",
                table: "group_members",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_group_invites_inviter_id",
                table: "group_invites",
                column: "inviter_id");

            migrationBuilder.CreateIndex(
                name: "IX_group_invites_target_id",
                table: "group_invites",
                column: "target_id");

            migrationBuilder.AddForeignKey(
                name: "FK_group_members_groups_GroupId",
                table: "group_members",
                column: "GroupId",
                principalTable: "groups",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_group_members_groups_GroupId",
                table: "group_members");

            migrationBuilder.DropTable(
                name: "group_invites");

            migrationBuilder.DropIndex(
                name: "IX_group_members_GroupId",
                table: "group_members");

            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: new Guid("58842ef7-4552-4081-a90d-71506268d7c7"));

            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: new Guid("60b14858-40d0-48e3-a554-dc02ffcfbe89"));

            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: new Guid("64faedc6-ef5d-4927-a863-42aaf08bff2f"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("1070141a-ac5b-49b9-a852-0bfc3c351fae"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("1121ec8e-5faf-40d7-9054-f2d270959199"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("1410fb71-478a-4de4-af97-a76e67b57362"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("37a0e97f-3a43-48d4-acb2-87840bcf3f59"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("37bcbdbc-3034-4ddd-8b79-546d3b9b4a69"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("64caec4b-7ea2-49f1-b332-6eddc76618f0"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("741bd6db-acac-49ea-910b-79be5046dc93"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("7dc5c429-afb3-42ed-a84b-8e4f5701b9b0"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("84f59ceb-8e42-4de4-9162-8d2749985a7f"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("8594d168-8f4d-407f-a620-0ba583688126"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("87375553-c075-4b15-92ae-028510b5a820"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("88ca2c07-c224-463c-a586-30c05ee1c30f"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("8b40d81c-f282-44d5-88b9-29f8379969a3"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("8e23b400-4fac-4d9f-b659-539e57fa0a79"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("a8372d07-7955-4c24-902f-50596dc19a50"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("c3fb954f-2d79-4e37-8fe1-a61e8c22cfcd"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("d599c503-7593-453b-9694-a4b2b3eac59a"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("dc85c673-cf78-49b4-af3c-dc564de42d57"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("dd60d2ea-a430-4b1d-8f1e-340dcd707d1d"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("de50aa23-3926-458d-b309-5b9832819ba9"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("e2bf3195-7e00-4d16-8485-716bb7fe302f"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("059593ea-882d-457b-b087-1ebbe0019e7b"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("1d25e9b2-9b25-4c7d-8a95-690b44b0d2ec"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("25a02ab7-9872-4a44-b8bf-05f8d6e42bb2"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("2be28ff0-f6d4-4267-8887-9b5ea3a8b3b2"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("51d4710f-d07a-4de6-a1a0-0fcb78ca2302"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("60df9931-4e7a-4d32-970c-1e3e288d58bc"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("9199a437-16fe-4779-a59d-c34455dab48b"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("97fbdc16-a5d3-4082-bfb6-c92b1dc8f441"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("a8acb90d-4076-428c-89ba-76f7c24deaba"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("b88e3438-43c8-4a14-a529-ca375111a90a"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("bec110dd-de06-44dc-805e-45d86c69da77"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("c197947f-cf1e-4c08-85dc-81115cdc29cd"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("c93e70bb-ed23-4065-899a-1124447a1d17"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("cffb2fc6-5eda-470a-a40d-436ae2b34d0b"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("d8e2c63a-fc6a-4cf7-8efa-a44acedbf823"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("efc486ea-1286-4052-a9fe-80c351806ab7"));

            migrationBuilder.DeleteData(
                table: "maintenance_services",
                keyColumn: "id",
                keyValue: new Guid("2835ffbd-7599-4e9b-b4ee-b7d901ce901d"));

            migrationBuilder.DeleteData(
                table: "maintenance_services",
                keyColumn: "id",
                keyValue: new Guid("65ea8980-bb69-4c39-8c69-29c9a9cd7975"));

            migrationBuilder.DeleteData(
                table: "maintenance_services",
                keyColumn: "id",
                keyValue: new Guid("6c58ab4f-3ac8-42a7-8ee3-d676d77f528a"));

            migrationBuilder.DeleteData(
                table: "maintenance_services",
                keyColumn: "id",
                keyValue: new Guid("76c44e7c-ffa6-4ab2-90fa-037b54418fb0"));

            migrationBuilder.DropColumn(
                name: "GroupId",
                table: "group_members");

            migrationBuilder.InsertData(
                table: "brands",
                columns: new[] { "id", "brand_avatar", "deleted_at", "name" },
                values: new object[,]
                {
                    { new Guid("41dab51d-748b-4ac8-a381-bf962b59c753"), "...", null, "Salsa" },
                    { new Guid("b772688c-e78d-44a3-9477-37af1345cdf6"), "...", null, "MO" },
                    { new Guid("d3cddb6b-0565-4e34-9c79-c2dbe0459381"), "...", null, "Tifosi" }
                });

            migrationBuilder.InsertData(
                table: "colors",
                columns: new[] { "id", "deleted_at", "hex", "name" },
                values: new object[,]
                {
                    { new Guid("0bb4f382-fb84-4d61-b9f3-4b879274995e"), null, "FF948066", "Castanho Claro" },
                    { new Guid("16f4a625-d158-4148-a57e-7fb1e03c8313"), null, "FFFF6D6D", "Vermelho Claro" },
                    { new Guid("2f948822-9df6-47ae-8668-23cd3fa1e147"), null, "FFBE5967", "Rosa" },
                    { new Guid("447366c9-1e2b-44d6-bca6-5aa4be27deba"), null, "FF509C75", "Verde" },
                    { new Guid("56332dc3-4854-45bc-bc35-d40777398fb8"), null, "FFC0C0C0", "Cinzento Bebê" },
                    { new Guid("5d56098e-8a05-40a3-83d2-2c5d08659698"), null, "FFFFE69F", "Amarelo" },
                    { new Guid("5fa03383-3de8-4eca-a274-ee6793652c83"), null, "FFC2BC8B", "Verde Lima" },
                    { new Guid("6bf1c442-8356-4942-bf7f-504d68a448f8"), null, "FFF58221", "Laranja" },
                    { new Guid("7040ae59-2f30-4dd4-8a01-be5d40f7f4f8"), null, "FF29394A", "Azul Escuro" },
                    { new Guid("7224e010-9d45-44d2-a0d9-ae3776800f42"), null, "FFF9C7C4", "Rosa Claro" },
                    { new Guid("742002f8-545a-4561-8b58-f55387d871b4"), null, "FFF2E7D4", "Amarelo Bebê" },
                    { new Guid("890b0144-6f80-4658-83fa-ab05b2fd8314"), null, "FF4A2D16", "Castanho" },
                    { new Guid("899f20c0-17b6-4af4-a268-66d96819821b"), null, "FF4C4C4C", "Cinzento Claro" },
                    { new Guid("a00bbcb7-5d48-4762-a0bd-e8fa4264e2f1"), null, "FFC3A572", "Amarelo Claro" },
                    { new Guid("ab117e50-fbb6-454d-8617-d8ae354866c3"), null, "FFDA252E", "Vermelho" },
                    { new Guid("c885b72c-8d20-4288-8aea-153e41b93820"), null, "FF98B3C8", "Azul Claro" },
                    { new Guid("cf07615d-d51c-4961-82cd-b8e12a9eb5a8"), null, "FFFFFFFF", "White" },
                    { new Guid("d51a8cb1-b848-4262-a7fa-2c4b91fd094a"), null, "FFD2AAC5", "Roxo Claro" },
                    { new Guid("dc2d72b0-6c97-4717-beee-214e412c9050"), null, "FF8B5F3C", "Castanho Bebê" },
                    { new Guid("e0170db6-31bb-4fae-b5d2-cef16cacaffb"), null, "FF000000", "Black" },
                    { new Guid("f789dd8b-8f57-47ba-96e4-84daa1a199b6"), null, "FFD62598", "Roxo" }
                });

            migrationBuilder.InsertData(
                table: "maintenance_services",
                columns: new[] { "id", "badge", "deleted_at", "description", "title" },
                values: new object[,]
                {
                    { new Guid("039ad0a0-d245-4a9a-8e77-0af7ca025bf4"), "public/default/dry.png", null, "De que forma pertende secar?", "Secar" },
                    { new Guid("211847d3-346d-4692-961b-293587fc5ed1"), "public/default/iron.png", null, "De que forma pertende engomar?", "Engomar" },
                    { new Guid("3fa3f6d7-0165-4daa-b00e-d09ce56c7e1c"), "public/default/wash.png", null, "De que forma pertende lavar?", "Lavar" },
                    { new Guid("f59193cd-a717-466b-b5ff-ffdfd5206419"), "public/default/repair.png", null, "De que forma pertende arranjar a peça?", "Reparar" }
                });

            migrationBuilder.InsertData(
                table: "maintenance_service_actions",
                columns: new[] { "id", "badge", "deleted_at", "Description", "eco_score", "maintenance_service_id", "sustainable_points", "title" },
                values: new object[,]
                {
                    { new Guid("3288aeb1-f78c-47db-9ac0-fe6a0b35e77a"), "public/default/wash/less95.png", null, "Lavar a menos de 95ºC", 10, new Guid("3fa3f6d7-0165-4daa-b00e-d09ce56c7e1c"), 100, "A menos de 95ºC" },
                    { new Guid("3c8a7bf0-99bc-414d-9d34-c9797bf8b8fa"), "public/default/wash/less50.png", null, "Lavar a menos de 50ºC", 10, new Guid("3fa3f6d7-0165-4daa-b00e-d09ce56c7e1c"), 100, "A menos de 50ºC" },
                    { new Guid("467ab08c-d8c0-471d-88f2-9d35c1613cf2"), "public/default/wash/hand.png", null, "Lavar à mão com água e sabão", 10, new Guid("3fa3f6d7-0165-4daa-b00e-d09ce56c7e1c"), 100, "Lavar à mão" },
                    { new Guid("65e96587-39a2-4bdf-9fa1-b585ae0daf56"), "public/default/service.png", null, "Escolhe um serviço de Reparação", 10, new Guid("f59193cd-a717-466b-b5ff-ffdfd5206419"), 100, "Serviço de Reparação" },
                    { new Guid("7426d055-e4bb-4a5c-9103-e757ebdb5782"), "public/default/repair.png", null, "Arranjar a peça pelo próprio", 10, new Guid("f59193cd-a717-466b-b5ff-ffdfd5206419"), 100, "Pelo Próprio" },
                    { new Guid("8ebb45b1-975f-47b5-82db-b4803b6d5814"), "public/default/iron/less150.png", null, "Engomar a menos de 150ºC", 10, new Guid("211847d3-346d-4692-961b-293587fc5ed1"), 100, "A menos de 150ºC" },
                    { new Guid("8fc36728-f524-4166-86dd-1d68f264520e"), "public/default/service.png", null, "Escolhe uma lavandaria", 10, new Guid("3fa3f6d7-0165-4daa-b00e-d09ce56c7e1c"), 100, "Serviço de lavandaria" },
                    { new Guid("904067b4-676c-4966-b5ec-c91d391f300b"), "public/default/wash/less30.png", null, "Lavar a menos de 30ºC", 10, new Guid("3fa3f6d7-0165-4daa-b00e-d09ce56c7e1c"), 100, "A menos de 30ºC" },
                    { new Guid("98edd1da-b0b8-4994-8ae8-507fae36d79b"), "public/default/wash/dry.png", null, "Lavar a seco", 10, new Guid("3fa3f6d7-0165-4daa-b00e-d09ce56c7e1c"), 100, "A seco" },
                    { new Guid("ab11baf1-c6db-4d25-a0df-fd0155426226"), "public/default/iron/less200.png", null, "Engomar a menos de 200ºC", 10, new Guid("211847d3-346d-4692-961b-293587fc5ed1"), 100, "A menos de 200ºC" },
                    { new Guid("b0d49301-91c8-498d-ae27-fd0facf49763"), "public/default/dry/machine.png", null, "Secar na máquina", 10, new Guid("039ad0a0-d245-4a9a-8e77-0af7ca025bf4"), 100, "Na máquina" },
                    { new Guid("b77e9adb-7806-49d7-a0da-953cd5969f5f"), "public/default/iron/less110.png", null, "Engomar a menos de 110ºC", 10, new Guid("211847d3-346d-4692-961b-293587fc5ed1"), 100, "A menos de 110ºC" },
                    { new Guid("c7744c97-44c3-4817-a7f2-0308db1dbced"), "public/default/dry/air.png", null, "Secar ao ar livre", 10, new Guid("039ad0a0-d245-4a9a-8e77-0af7ca025bf4"), 100, "Ao ar livre" },
                    { new Guid("c9266531-a232-4e79-b368-7d57dc15caae"), "public/default/wash/less70.png", null, "Lavar a menos de 70ºC", 10, new Guid("3fa3f6d7-0165-4daa-b00e-d09ce56c7e1c"), 100, "A menos de 70ºC" },
                    { new Guid("d7a1abd6-e947-4ff5-a743-c4e4f4ad5c30"), "public/default/service.png", null, "Escolhe um serviço de secagem", 10, new Guid("039ad0a0-d245-4a9a-8e77-0af7ca025bf4"), 100, "Serviço de Secagem" },
                    { new Guid("f425487a-acb2-47cf-90c9-d1be4ff3d7f1"), "public/default/service.png", null, "Escolhe um serviço de engomadoria", 10, new Guid("211847d3-346d-4692-961b-293587fc5ed1"), 100, "Serviço de Engomadoria" }
                });
        }
    }
}