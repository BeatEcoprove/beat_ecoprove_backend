using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BeatEcoprove.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddFeedBack : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_group_members_groups_GroupId",
                table: "group_members");

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

            migrationBuilder.CreateTable(
                name: "feedbacks",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    sender_id = table.Column<Guid>(type: "uuid", nullable: false),
                    title = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    deleted_at = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_feedbacks", x => x.id);
                    table.ForeignKey(
                        name: "FK_feedbacks_profiles_sender_id",
                        column: x => x.sender_id,
                        principalTable: "profiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "brands",
                columns: new[] { "id", "brand_avatar", "deleted_at", "name" },
                values: new object[,]
                {
                    { new Guid("72ebdcd9-4d9f-4911-8a70-84f7e8d08079"), "...", null, "MO" },
                    { new Guid("a9aeec63-3220-42d0-a045-7a8239d9582e"), "...", null, "Salsa" },
                    { new Guid("cf98502f-54a9-410b-bdf8-e6f79e635de4"), "...", null, "Tifosi" }
                });

            migrationBuilder.InsertData(
                table: "colors",
                columns: new[] { "id", "deleted_at", "hex", "name" },
                values: new object[,]
                {
                    { new Guid("003685cc-db4f-4f8e-b99c-0747e53965ba"), null, "FFFFE69F", "Amarelo" },
                    { new Guid("0cb02dcb-85f1-41b0-ac14-c5696fd044e0"), null, "FFF9C7C4", "Rosa Claro" },
                    { new Guid("137de7c2-7340-4997-af40-8a3c72e97868"), null, "FFBE5967", "Rosa" },
                    { new Guid("1868efde-5e58-4533-a266-957f81c0cec2"), null, "FFF2E7D4", "Amarelo Bebê" },
                    { new Guid("2dd686e7-8598-4352-9f8e-9e2f392d3eaf"), null, "FFFFFFFF", "White" },
                    { new Guid("3eb4ba0c-ca6e-45d5-b23c-2b74bc45a9cf"), null, "FFD62598", "Roxo" },
                    { new Guid("49b4e34d-6f76-4560-96c4-573075a2fb26"), null, "FF98B3C8", "Azul Claro" },
                    { new Guid("4c3b6209-9872-4c30-99f0-4d1398c16d14"), null, "FF8B5F3C", "Castanho Bebê" },
                    { new Guid("58e4291e-1f2d-4783-beb8-cd5cb8034866"), null, "FF948066", "Castanho Claro" },
                    { new Guid("6117d603-2d02-4365-9148-60066d2d6ebb"), null, "FFD2AAC5", "Roxo Claro" },
                    { new Guid("6aea3d42-1667-4dfe-8fbe-4934e6cf385a"), null, "FF509C75", "Verde" },
                    { new Guid("7d5eec0f-86b0-4b11-b336-41d2b31b081a"), null, "FF4C4C4C", "Cinzento Claro" },
                    { new Guid("8f0cb390-b665-4e3c-8266-a6d43c392bf6"), null, "FFFF6D6D", "Vermelho Claro" },
                    { new Guid("90b31ed8-59f4-414f-87d2-027aeddc6722"), null, "FF29394A", "Azul Escuro" },
                    { new Guid("c0f4bbd9-4ec5-47c8-9eaa-6b192190106b"), null, "FF000000", "Black" },
                    { new Guid("c5ddcae0-d5cb-4505-948f-737af834e2ea"), null, "FFDA252E", "Vermelho" },
                    { new Guid("c7282c01-5cf1-4434-9c2b-d9b2e0effa85"), null, "FFC3A572", "Amarelo Claro" },
                    { new Guid("cbb3d13e-35b3-46ee-81cf-515a51d49164"), null, "FFC2BC8B", "Verde Lima" },
                    { new Guid("ce9b77b2-4923-4be3-8a10-7b61a8f2925b"), null, "FFC0C0C0", "Cinzento Bebê" },
                    { new Guid("d339b83f-dd89-440f-9c98-50adbe848ae9"), null, "FF4A2D16", "Castanho" },
                    { new Guid("fc796230-5458-4fff-8956-d2467a6ec769"), null, "FFF58221", "Laranja" }
                });

            migrationBuilder.InsertData(
                table: "maintenance_services",
                columns: new[] { "id", "badge", "deleted_at", "description", "title" },
                values: new object[,]
                {
                    { new Guid("0a912017-037a-4387-bb48-f81cb00ee2ca"), "public/default/wash.png", null, "De que forma pertende lavar?", "Lavar" },
                    { new Guid("1faa30c0-8ee3-4084-944d-2cbd8c669c16"), "public/default/iron.png", null, "De que forma pertende engomar?", "Engomar" },
                    { new Guid("29ba13a8-bb75-44b9-8703-3f6379eb81d3"), "public/default/dry.png", null, "De que forma pertende secar?", "Secar" },
                    { new Guid("89632620-3f8f-476c-a977-796f50696c8d"), "public/default/repair.png", null, "De que forma pertende arranjar a peça?", "Reparar" }
                });

            migrationBuilder.InsertData(
                table: "maintenance_service_actions",
                columns: new[] { "id", "badge", "deleted_at", "Description", "eco_score", "maintenance_service_id", "sustainable_points", "title" },
                values: new object[,]
                {
                    { new Guid("125893b0-f0ac-484f-b2cc-d232db32145f"), "public/default/iron/less200.png", null, "Engomar a menos de 200ºC", 10, new Guid("1faa30c0-8ee3-4084-944d-2cbd8c669c16"), 100, "A menos de 200ºC" },
                    { new Guid("13b00c78-04ea-42f4-8454-ee69696a4830"), "public/default/wash/less50.png", null, "Lavar a menos de 50ºC", 10, new Guid("0a912017-037a-4387-bb48-f81cb00ee2ca"), 100, "A menos de 50ºC" },
                    { new Guid("32a8b41c-a3de-4db3-abb7-0d1cb6972a4e"), "public/default/dry/machine.png", null, "Secar na máquina", 10, new Guid("29ba13a8-bb75-44b9-8703-3f6379eb81d3"), 100, "Na máquina" },
                    { new Guid("347a08be-9246-49a3-a53a-116d5de74c45"), "public/default/wash/less30.png", null, "Lavar a menos de 30ºC", 10, new Guid("0a912017-037a-4387-bb48-f81cb00ee2ca"), 100, "A menos de 30ºC" },
                    { new Guid("47046061-3afb-4848-a281-b57e1eb0574a"), "public/default/wash/hand.png", null, "Lavar à mão com água e sabão", 10, new Guid("0a912017-037a-4387-bb48-f81cb00ee2ca"), 100, "Lavar à mão" },
                    { new Guid("513a3d39-74bb-453f-a612-4046fac9fc89"), "public/default/wash/less70.png", null, "Lavar a menos de 70ºC", 10, new Guid("0a912017-037a-4387-bb48-f81cb00ee2ca"), 100, "A menos de 70ºC" },
                    { new Guid("5a59cc3e-1839-4ebe-829a-922fb5342289"), "public/default/service.png", null, "Escolhe um serviço de engomadoria", 10, new Guid("1faa30c0-8ee3-4084-944d-2cbd8c669c16"), 100, "Serviço de Engomadoria" },
                    { new Guid("7cb3c017-17b1-4f1e-8282-5084669fe86e"), "public/default/wash/less95.png", null, "Lavar a menos de 95ºC", 10, new Guid("0a912017-037a-4387-bb48-f81cb00ee2ca"), 100, "A menos de 95ºC" },
                    { new Guid("803cab24-050d-4ded-a376-496834ec7ac5"), "public/default/dry/air.png", null, "Secar ao ar livre", 10, new Guid("29ba13a8-bb75-44b9-8703-3f6379eb81d3"), 100, "Ao ar livre" },
                    { new Guid("89ea57e1-342f-4923-8065-1c0dcdc266ba"), "public/default/repair.png", null, "Arranjar a peça pelo próprio", 10, new Guid("89632620-3f8f-476c-a977-796f50696c8d"), 100, "Pelo Próprio" },
                    { new Guid("8a85a7c6-a9c2-4a93-b970-3001ef5d4fbb"), "public/default/iron/less150.png", null, "Engomar a menos de 150ºC", 10, new Guid("1faa30c0-8ee3-4084-944d-2cbd8c669c16"), 100, "A menos de 150ºC" },
                    { new Guid("bb30e2ff-5615-4547-ad99-5c78783c0935"), "public/default/service.png", null, "Escolhe uma lavandaria", 10, new Guid("0a912017-037a-4387-bb48-f81cb00ee2ca"), 100, "Serviço de lavandaria" },
                    { new Guid("d1c3fef6-fba5-422b-bc0b-37660512bff1"), "public/default/service.png", null, "Escolhe um serviço de secagem", 10, new Guid("29ba13a8-bb75-44b9-8703-3f6379eb81d3"), 100, "Serviço de Secagem" },
                    { new Guid("e3d8ffac-8a67-4baf-ad8b-ea2066477d12"), "public/default/wash/dry.png", null, "Lavar a seco", 10, new Guid("0a912017-037a-4387-bb48-f81cb00ee2ca"), 100, "A seco" },
                    { new Guid("ea2ad035-d372-43d5-b30e-15b3b9759881"), "public/default/iron/less110.png", null, "Engomar a menos de 110ºC", 10, new Guid("1faa30c0-8ee3-4084-944d-2cbd8c669c16"), 100, "A menos de 110ºC" },
                    { new Guid("f8c2c544-18d1-4edd-820f-16e2d228efe4"), "public/default/service.png", null, "Escolhe um serviço de Reparação", 10, new Guid("89632620-3f8f-476c-a977-796f50696c8d"), 100, "Serviço de Reparação" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_group_invites_group_id",
                table: "group_invites",
                column: "group_id");

            migrationBuilder.CreateIndex(
                name: "IX_feedbacks_sender_id",
                table: "feedbacks",
                column: "sender_id");

            migrationBuilder.AddForeignKey(
                name: "FK_group_invites_groups_group_id",
                table: "group_invites",
                column: "group_id",
                principalTable: "groups",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_group_invites_groups_group_id",
                table: "group_invites");

            migrationBuilder.DropTable(
                name: "feedbacks");

            migrationBuilder.DropIndex(
                name: "IX_group_invites_group_id",
                table: "group_invites");

            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: new Guid("72ebdcd9-4d9f-4911-8a70-84f7e8d08079"));

            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: new Guid("a9aeec63-3220-42d0-a045-7a8239d9582e"));

            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: new Guid("cf98502f-54a9-410b-bdf8-e6f79e635de4"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("003685cc-db4f-4f8e-b99c-0747e53965ba"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("0cb02dcb-85f1-41b0-ac14-c5696fd044e0"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("137de7c2-7340-4997-af40-8a3c72e97868"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("1868efde-5e58-4533-a266-957f81c0cec2"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("2dd686e7-8598-4352-9f8e-9e2f392d3eaf"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("3eb4ba0c-ca6e-45d5-b23c-2b74bc45a9cf"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("49b4e34d-6f76-4560-96c4-573075a2fb26"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("4c3b6209-9872-4c30-99f0-4d1398c16d14"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("58e4291e-1f2d-4783-beb8-cd5cb8034866"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("6117d603-2d02-4365-9148-60066d2d6ebb"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("6aea3d42-1667-4dfe-8fbe-4934e6cf385a"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("7d5eec0f-86b0-4b11-b336-41d2b31b081a"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("8f0cb390-b665-4e3c-8266-a6d43c392bf6"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("90b31ed8-59f4-414f-87d2-027aeddc6722"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("c0f4bbd9-4ec5-47c8-9eaa-6b192190106b"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("c5ddcae0-d5cb-4505-948f-737af834e2ea"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("c7282c01-5cf1-4434-9c2b-d9b2e0effa85"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("cbb3d13e-35b3-46ee-81cf-515a51d49164"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("ce9b77b2-4923-4be3-8a10-7b61a8f2925b"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("d339b83f-dd89-440f-9c98-50adbe848ae9"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("fc796230-5458-4fff-8956-d2467a6ec769"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("125893b0-f0ac-484f-b2cc-d232db32145f"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("13b00c78-04ea-42f4-8454-ee69696a4830"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("32a8b41c-a3de-4db3-abb7-0d1cb6972a4e"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("347a08be-9246-49a3-a53a-116d5de74c45"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("47046061-3afb-4848-a281-b57e1eb0574a"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("513a3d39-74bb-453f-a612-4046fac9fc89"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("5a59cc3e-1839-4ebe-829a-922fb5342289"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("7cb3c017-17b1-4f1e-8282-5084669fe86e"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("803cab24-050d-4ded-a376-496834ec7ac5"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("89ea57e1-342f-4923-8065-1c0dcdc266ba"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("8a85a7c6-a9c2-4a93-b970-3001ef5d4fbb"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("bb30e2ff-5615-4547-ad99-5c78783c0935"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("d1c3fef6-fba5-422b-bc0b-37660512bff1"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("e3d8ffac-8a67-4baf-ad8b-ea2066477d12"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("ea2ad035-d372-43d5-b30e-15b3b9759881"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("f8c2c544-18d1-4edd-820f-16e2d228efe4"));

            migrationBuilder.DeleteData(
                table: "maintenance_services",
                keyColumn: "id",
                keyValue: new Guid("0a912017-037a-4387-bb48-f81cb00ee2ca"));

            migrationBuilder.DeleteData(
                table: "maintenance_services",
                keyColumn: "id",
                keyValue: new Guid("1faa30c0-8ee3-4084-944d-2cbd8c669c16"));

            migrationBuilder.DeleteData(
                table: "maintenance_services",
                keyColumn: "id",
                keyValue: new Guid("29ba13a8-bb75-44b9-8703-3f6379eb81d3"));

            migrationBuilder.DeleteData(
                table: "maintenance_services",
                keyColumn: "id",
                keyValue: new Guid("89632620-3f8f-476c-a977-796f50696c8d"));

            migrationBuilder.AddColumn<Guid>(
                name: "GroupId",
                table: "group_members",
                type: "uuid",
                nullable: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_group_members_groups_GroupId",
                table: "group_members",
                column: "GroupId",
                principalTable: "groups",
                principalColumn: "id");
        }
    }
}