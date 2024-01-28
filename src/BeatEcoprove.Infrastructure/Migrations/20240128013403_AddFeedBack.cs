using System;
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
                    { new Guid("358c0c9e-d4ca-4fb0-832a-f5df8573e67f"), "...", null, "Salsa" },
                    { new Guid("383236e1-98a4-4c20-8073-5790df27ef2b"), "...", null, "MO" },
                    { new Guid("a19fa5c3-2f24-4ec4-98a4-fc4d2594df5c"), "...", null, "Tifosi" }
                });

            migrationBuilder.InsertData(
                table: "colors",
                columns: new[] { "id", "deleted_at", "hex", "name" },
                values: new object[,]
                {
                    { new Guid("030fd739-a8d6-4003-b523-a6ce10206cee"), null, "FFF58221", "Laranja" },
                    { new Guid("076ea164-f1d4-49ec-ada6-d3a40f6bd4ad"), null, "FFF2E7D4", "Amarelo Bebê" },
                    { new Guid("15060c17-660e-415b-8a0d-a8ccd2c15ca0"), null, "FF509C75", "Verde" },
                    { new Guid("2acdf3db-293d-4742-8aad-e70b86a84aae"), null, "FF4A2D16", "Castanho" },
                    { new Guid("39bf6f23-db0b-4c9b-b932-c38bda5d508f"), null, "FFD62598", "Roxo" },
                    { new Guid("44f68b3b-0d35-408e-aaa4-ae0a193b0f7c"), null, "FF98B3C8", "Azul Claro" },
                    { new Guid("4d0f278e-336c-423e-9f43-b4ac724a89c4"), null, "FFBE5967", "Rosa" },
                    { new Guid("4fa22ac0-07f1-432e-9ede-d7bdc2314874"), null, "FFF9C7C4", "Rosa Claro" },
                    { new Guid("50be5b5c-4eba-443a-98ac-8bd7fa036aaa"), null, "FFC2BC8B", "Verde Lima" },
                    { new Guid("558bd853-82ad-4dc5-90b4-5677e61e2e45"), null, "FFDA252E", "Vermelho" },
                    { new Guid("65ed1c70-591f-4fe0-8a21-8113e85d5c75"), null, "FFFFE69F", "Amarelo" },
                    { new Guid("89916d3e-0c98-40b5-a980-9c4f86b2bc07"), null, "FFFF6D6D", "Vermelho Claro" },
                    { new Guid("9913d1f5-b30c-472d-9c55-e02cfd3071b9"), null, "FF29394A", "Azul Escuro" },
                    { new Guid("a419d36f-3cdc-4f52-9df2-9212377b585f"), null, "FF4C4C4C", "Cinzento Claro" },
                    { new Guid("b26e5f74-590e-449f-97eb-c4e1ca2dfb01"), null, "FF8B5F3C", "Castanho Bebê" },
                    { new Guid("bbb490e0-6628-440d-85ed-23e26a1bf72e"), null, "FF000000", "Black" },
                    { new Guid("bd0e6713-e99e-443b-84ff-94ae86e0fb70"), null, "FFFFFFFF", "White" },
                    { new Guid("c0da8d3f-ea54-4789-ba08-07b519512c7e"), null, "FFD2AAC5", "Roxo Claro" },
                    { new Guid("c44f0eeb-77b0-404e-8f20-8922f6bf2466"), null, "FF948066", "Castanho Claro" },
                    { new Guid("e8863111-7e2d-4bc8-b72f-9402f2d0ed7c"), null, "FFC0C0C0", "Cinzento Bebê" },
                    { new Guid("fa296354-923b-4c9e-9f4d-85c81ca39712"), null, "FFC3A572", "Amarelo Claro" }
                });

            migrationBuilder.InsertData(
                table: "maintenance_services",
                columns: new[] { "id", "badge", "deleted_at", "description", "title" },
                values: new object[,]
                {
                    { new Guid("160eebab-0637-44d3-93c2-95f489bdde05"), "public/default/wash.png", null, "De que forma pertende lavar?", "Lavar" },
                    { new Guid("3e4bdfbe-60b9-40f3-b18a-4e32ebaafdcb"), "public/default/iron.png", null, "De que forma pertende engomar?", "Engomar" },
                    { new Guid("b2f472cd-e9e7-47c2-aa7e-b16efef77ba4"), "public/default/repair.png", null, "De que forma pertende arranjar a peça?", "Engomar" },
                    { new Guid("d5103db1-f131-4697-a46b-27420efe0d31"), "public/default/dry.png", null, "De que forma pertende secar?", "Secar" }
                });

            migrationBuilder.InsertData(
                table: "maintenance_service_actions",
                columns: new[] { "id", "badge", "deleted_at", "Description", "eco_score", "maintenance_service_id", "sustainable_points", "title" },
                values: new object[,]
                {
                    { new Guid("0b438b43-e689-4f46-a8df-eb30d47827c5"), "public/default/dry/air.png", null, "Secar ao ar livre", 10, new Guid("d5103db1-f131-4697-a46b-27420efe0d31"), 100, "Ao ar livre" },
                    { new Guid("1357a98d-bd3c-4778-8db7-0b28f8f5e551"), "public/default/dry/machine.png", null, "Secar na máquina", 10, new Guid("d5103db1-f131-4697-a46b-27420efe0d31"), 100, "Na máquina" },
                    { new Guid("24aa2c85-814d-4a75-84d3-bbf2149d63db"), "public/default/wash/less30.png", null, "Lavar a menos de 30ºC", 10, new Guid("160eebab-0637-44d3-93c2-95f489bdde05"), 100, "A menos de 30ºC" },
                    { new Guid("282e853f-8756-479c-aa73-69524fccacf9"), "public/default/wash/less95.png", null, "Lavar a menos de 95ºC", 10, new Guid("160eebab-0637-44d3-93c2-95f489bdde05"), 100, "A menos de 95ºC" },
                    { new Guid("35a9b903-5cae-4f87-9eb5-2013894d83b6"), "public/default/wash/dry.png", null, "Lavar a seco", 10, new Guid("160eebab-0637-44d3-93c2-95f489bdde05"), 100, "A seco" },
                    { new Guid("3bf4a050-2459-41aa-9ce4-5d7c6787b6f1"), "public/default/iron/less110.png", null, "Engomar a menos de 110ºC", 10, new Guid("3e4bdfbe-60b9-40f3-b18a-4e32ebaafdcb"), 100, "A menos de 110ºC" },
                    { new Guid("3c50a62f-22d2-4715-9178-b73ad34a695e"), "public/default/wash/less70.png", null, "Lavar a menos de 70ºC", 10, new Guid("160eebab-0637-44d3-93c2-95f489bdde05"), 100, "A menos de 70ºC" },
                    { new Guid("3e30c923-7b5a-46d3-a955-63a18c0f703e"), "public/default/wash/hand.png", null, "Lavar à mão com água e sabão", 10, new Guid("160eebab-0637-44d3-93c2-95f489bdde05"), 100, "Lavar à mão" },
                    { new Guid("6c3c4dec-282f-45b5-a447-516b28118256"), "public/default/service.png", null, "Escolhe uma lavandaria", 10, new Guid("160eebab-0637-44d3-93c2-95f489bdde05"), 100, "Serviço de lavandaria" },
                    { new Guid("6d16bb2f-b1cc-4ed7-b08b-860cf43a496a"), "public/default/wash/less50.png", null, "Lavar a menos de 50ºC", 10, new Guid("160eebab-0637-44d3-93c2-95f489bdde05"), 100, "A menos de 50ºC" },
                    { new Guid("8d49528d-cef9-4227-bbbb-5c563c9ae3fe"), "public/default/iron/less150.png", null, "Engomar a menos de 150ºC", 10, new Guid("3e4bdfbe-60b9-40f3-b18a-4e32ebaafdcb"), 100, "A menos de 150ºC" },
                    { new Guid("b346b607-89bb-4dd5-b4b6-521124bf6cb3"), "public/default/repair.png", null, "Arranjar a peça pelo próprio", 10, new Guid("b2f472cd-e9e7-47c2-aa7e-b16efef77ba4"), 100, "Pelo Próprio" },
                    { new Guid("b4419cf7-1d2f-4f9d-96e3-f7e1ff0d0a40"), "public/default/service.png", null, "Escolhe um serviço de secagem", 10, new Guid("d5103db1-f131-4697-a46b-27420efe0d31"), 100, "Serviço de Secagem" },
                    { new Guid("cc865535-d90a-4f8b-8c48-e03a6f579b9f"), "public/default/service.png", null, "Escolhe um serviço de engomadoria", 10, new Guid("3e4bdfbe-60b9-40f3-b18a-4e32ebaafdcb"), 100, "Serviço de Engomadoria" },
                    { new Guid("f0dffef0-3c3f-427e-b276-3c2680ccb3a9"), "public/default/iron/less200.png", null, "Engomar a menos de 200ºC", 10, new Guid("3e4bdfbe-60b9-40f3-b18a-4e32ebaafdcb"), 100, "A menos de 200ºC" },
                    { new Guid("fee067d2-f82f-4f60-863f-b23919733216"), "public/default/service.png", null, "Escolhe um serviço de Reparação", 10, new Guid("b2f472cd-e9e7-47c2-aa7e-b16efef77ba4"), 100, "Serviço de Reparação" }
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
                keyValue: new Guid("358c0c9e-d4ca-4fb0-832a-f5df8573e67f"));

            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: new Guid("383236e1-98a4-4c20-8073-5790df27ef2b"));

            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: new Guid("a19fa5c3-2f24-4ec4-98a4-fc4d2594df5c"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("030fd739-a8d6-4003-b523-a6ce10206cee"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("076ea164-f1d4-49ec-ada6-d3a40f6bd4ad"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("15060c17-660e-415b-8a0d-a8ccd2c15ca0"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("2acdf3db-293d-4742-8aad-e70b86a84aae"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("39bf6f23-db0b-4c9b-b932-c38bda5d508f"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("44f68b3b-0d35-408e-aaa4-ae0a193b0f7c"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("4d0f278e-336c-423e-9f43-b4ac724a89c4"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("4fa22ac0-07f1-432e-9ede-d7bdc2314874"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("50be5b5c-4eba-443a-98ac-8bd7fa036aaa"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("558bd853-82ad-4dc5-90b4-5677e61e2e45"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("65ed1c70-591f-4fe0-8a21-8113e85d5c75"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("89916d3e-0c98-40b5-a980-9c4f86b2bc07"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("9913d1f5-b30c-472d-9c55-e02cfd3071b9"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("a419d36f-3cdc-4f52-9df2-9212377b585f"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("b26e5f74-590e-449f-97eb-c4e1ca2dfb01"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("bbb490e0-6628-440d-85ed-23e26a1bf72e"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("bd0e6713-e99e-443b-84ff-94ae86e0fb70"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("c0da8d3f-ea54-4789-ba08-07b519512c7e"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("c44f0eeb-77b0-404e-8f20-8922f6bf2466"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("e8863111-7e2d-4bc8-b72f-9402f2d0ed7c"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("fa296354-923b-4c9e-9f4d-85c81ca39712"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("0b438b43-e689-4f46-a8df-eb30d47827c5"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("1357a98d-bd3c-4778-8db7-0b28f8f5e551"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("24aa2c85-814d-4a75-84d3-bbf2149d63db"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("282e853f-8756-479c-aa73-69524fccacf9"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("35a9b903-5cae-4f87-9eb5-2013894d83b6"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("3bf4a050-2459-41aa-9ce4-5d7c6787b6f1"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("3c50a62f-22d2-4715-9178-b73ad34a695e"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("3e30c923-7b5a-46d3-a955-63a18c0f703e"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("6c3c4dec-282f-45b5-a447-516b28118256"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("6d16bb2f-b1cc-4ed7-b08b-860cf43a496a"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("8d49528d-cef9-4227-bbbb-5c563c9ae3fe"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("b346b607-89bb-4dd5-b4b6-521124bf6cb3"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("b4419cf7-1d2f-4f9d-96e3-f7e1ff0d0a40"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("cc865535-d90a-4f8b-8c48-e03a6f579b9f"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("f0dffef0-3c3f-427e-b276-3c2680ccb3a9"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("fee067d2-f82f-4f60-863f-b23919733216"));

            migrationBuilder.DeleteData(
                table: "maintenance_services",
                keyColumn: "id",
                keyValue: new Guid("160eebab-0637-44d3-93c2-95f489bdde05"));

            migrationBuilder.DeleteData(
                table: "maintenance_services",
                keyColumn: "id",
                keyValue: new Guid("3e4bdfbe-60b9-40f3-b18a-4e32ebaafdcb"));

            migrationBuilder.DeleteData(
                table: "maintenance_services",
                keyColumn: "id",
                keyValue: new Guid("b2f472cd-e9e7-47c2-aa7e-b16efef77ba4"));

            migrationBuilder.DeleteData(
                table: "maintenance_services",
                keyColumn: "id",
                keyValue: new Guid("d5103db1-f131-4697-a46b-27420efe0d31"));

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
                    { new Guid("2835ffbd-7599-4e9b-b4ee-b7d901ce901d"), "public/default/repair.png", null, "De que forma pertende arranjar a peça?", "Engomar" },
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
