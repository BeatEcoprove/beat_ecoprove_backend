using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BeatEcoprove.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddWorkersToStore : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: new Guid("0096181c-d722-4b50-ac62-f627c9bef4a6"));

            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: new Guid("161d571e-5c72-401f-9199-e1571963b408"));

            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: new Guid("3a12fca1-9b07-4f9b-abb3-d25fe55eeb98"));

            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: new Guid("c9571870-eea4-4161-9995-14a2c68111ef"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("02a23eb3-0b4a-4385-8e2e-5ab054bf9ec1"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("2c3dc5fa-d200-4dff-ae35-bf7f4a799763"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("48652000-2bcb-4e44-8bd0-16477e433064"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("513888c7-caad-48bb-9524-3512cfa69001"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("720b5b5a-5684-40ca-a466-4c73748003e0"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("7eef72d8-8f34-42e2-8ec1-c9798040d755"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("95d71e40-3988-4c0e-91cb-214fc33783ce"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("97636597-5751-407b-9ea8-d03efcb03fad"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("97a3ba7d-ca46-4001-a485-5615807e48ed"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("9e08cc8a-a9ff-4110-a14f-e825fd216834"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("aad149cd-e854-4ea5-b473-6668e83bc29e"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("b2b28c72-ea70-47a9-8973-8d6539cd745c"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("b8279caa-e59b-431f-a9c9-8e2fe8ee18d9"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("cde49ee6-36c7-465f-83bb-272782b815bc"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("d35dc6f6-895b-4929-bc89-2b6189b2339b"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("e0f3a1ff-bba6-4192-a587-0eb39421ead1"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("e1b408b0-6938-4304-a120-8d321f0398fe"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("e47ed693-2b80-4415-82ba-23165d7336f3"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("e5245c36-1c08-4cdb-91ce-247dce34fa3b"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("ea97c70a-e4a9-42c8-9ee9-3d182dc24e52"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("ebcb89dc-0598-4020-87f6-4cb0bea6d8a7"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("193fcff2-16d9-478b-8b56-dd823c182cb0"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("2b82e11d-ea01-481d-b11d-b687746db5e1"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("32999cf2-654f-4351-9116-8f0325521ea2"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("4ac0e147-d714-44a6-bb5a-59771a3e7f5d"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("54365680-ce72-4121-a1b8-c88ea2437084"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("5dfda032-c8ee-4033-ae76-593ea072f237"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("5f37f47b-95fd-484e-97c8-a057069a54a4"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("9462a987-f2a6-4528-8e5b-cd9530f99df6"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("9b19552a-e36a-4288-be29-b5f87c3702db"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("a0037ec4-d4bd-4205-b88e-7878e64d22f4"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("a797edd7-e33c-40ec-8bc7-fcea167230e6"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("ab8273a1-d2f8-4622-91a7-22603606d0f7"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("aeebca6a-9c35-4795-a0ca-cb83dfb9dae8"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("d2a45b21-3a45-4006-a3f0-71873769b699"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("d83e91bb-7706-49ab-810a-c799bb08b8b0"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("fc46dc94-5db8-4925-98b0-5b7c92675661"));

            migrationBuilder.DeleteData(
                table: "maintenance_services",
                keyColumn: "id",
                keyValue: new Guid("39d39f68-5c87-489f-9ccb-da6d6e13966e"));

            migrationBuilder.DeleteData(
                table: "maintenance_services",
                keyColumn: "id",
                keyValue: new Guid("3cd01305-e232-4931-8096-e3d2d51479b5"));

            migrationBuilder.DeleteData(
                table: "maintenance_services",
                keyColumn: "id",
                keyValue: new Guid("836e6abf-bb0f-48fe-8079-d6c94a1fc6d0"));

            migrationBuilder.DeleteData(
                table: "maintenance_services",
                keyColumn: "id",
                keyValue: new Guid("c722c2ce-1bbf-4e14-a458-319ab9660a77"));

            migrationBuilder.CreateTable(
                name: "workers",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    store = table.Column<Guid>(type: "uuid", nullable: false),
                    profile = table.Column<Guid>(type: "uuid", nullable: false),
                    role = table.Column<int>(type: "integer", nullable: false),
                    joined_at = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    exit_at = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    deleted_at = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_workers", x => x.id);
                    table.ForeignKey(
                        name: "FK_workers_profiles_profile",
                        column: x => x.profile,
                        principalTable: "profiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_workers_stores_store",
                        column: x => x.store,
                        principalTable: "stores",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "brands",
                columns: new[] { "id", "brand_avatar", "deleted_at", "name" },
                values: new object[,]
                {
                    { new Guid("425a08cc-2461-41bb-8675-b176bb123d17"), "public/default/brands/losan.png", null, "Losan" },
                    { new Guid("58333572-1aa2-4593-943a-561656cb5442"), "public/default/brands/mo.png", null, "MO" },
                    { new Guid("76f849ce-dea4-4be1-b382-8d58e2700397"), "public/default/brands/zippy.png", null, "Zippy" },
                    { new Guid("b654e9f3-eff8-4459-ac13-9f8de5410adb"), "public/default/brands/salsa.png", null, "Salsa" }
                });

            migrationBuilder.InsertData(
                table: "colors",
                columns: new[] { "id", "deleted_at", "hex", "name" },
                values: new object[,]
                {
                    { new Guid("01415c63-31c9-4c0e-871a-2c15eab5f310"), null, "FF4C4C4C", "Cinzento Claro" },
                    { new Guid("070ea6d3-97fe-4da8-9126-02ead99a3ece"), null, "FFBE5967", "Rosa" },
                    { new Guid("1951621c-fe5f-4862-be80-6aef862a8456"), null, "FFFFE69F", "Amarelo" },
                    { new Guid("1f3bee85-4ac2-41f1-a833-b25d0d8bbee8"), null, "FFF58221", "Laranja" },
                    { new Guid("29cfea6b-8f83-4393-80be-fbb4369a34f3"), null, "FFD62598", "Roxo" },
                    { new Guid("4d325138-a5bc-4eaf-8276-2eda182a8655"), null, "FF4A2D16", "Castanho" },
                    { new Guid("54d6d0b6-77e8-4701-89bc-9ae04a2c1e91"), null, "FF509C75", "Verde" },
                    { new Guid("6792374c-3fbe-4103-ac5c-53681b63dedb"), null, "FFDA252E", "Vermelho" },
                    { new Guid("6a02b907-456b-4e1e-96f6-dfb889d63897"), null, "FFF9C7C4", "Rosa Claro" },
                    { new Guid("6b49e020-594e-469d-bba3-439193d20f35"), null, "FFFF6D6D", "Vermelho Claro" },
                    { new Guid("6c1f1c50-189b-47e4-8d58-2648e2cf41eb"), null, "FF000000", "Black" },
                    { new Guid("6f7dfbd4-ab1f-45f6-a654-2f9e2346c9da"), null, "FF8B5F3C", "Castanho Bebê" },
                    { new Guid("8fd93f80-e27b-4ded-b7f5-a0681687ff78"), null, "FF98B3C8", "Azul Claro" },
                    { new Guid("99222e34-260b-4ff7-b992-473bc7781cd0"), null, "FFC3A572", "Amarelo Claro" },
                    { new Guid("a91ba19f-c014-4370-a575-1f1a44bc5d2b"), null, "FFF2E7D4", "Amarelo Bebê" },
                    { new Guid("ae0903f3-1ded-422b-88fa-a39d90b6e9eb"), null, "FF29394A", "Azul Escuro" },
                    { new Guid("b52e1c6e-5db8-4224-905c-acf2363c0248"), null, "FFC2BC8B", "Verde Lima" },
                    { new Guid("bc16833f-d275-4549-b37a-98ede7f9fdf7"), null, "FF948066", "Castanho Claro" },
                    { new Guid("becd4059-05b2-4daf-876a-2be7f7464a01"), null, "FFC0C0C0", "Cinzento Bebê" },
                    { new Guid("c1c908db-6402-4070-a34b-c3996082c99e"), null, "FFD2AAC5", "Roxo Claro" },
                    { new Guid("e9f77356-187c-47ac-8fc3-b5171e12b8ba"), null, "FFFFFFFF", "White" }
                });

            migrationBuilder.InsertData(
                table: "maintenance_services",
                columns: new[] { "id", "badge", "deleted_at", "description", "title" },
                values: new object[,]
                {
                    { new Guid("5c396f08-c679-4de4-b33f-cc9479339b65"), "public/default/iron.png", null, "De que forma pretende engomar?", "Engomar" },
                    { new Guid("b602935e-3aee-4f0d-9ca7-cfbb2fbdc30e"), "public/default/wash.png", null, "De que forma pretende lavar?", "Lavar" },
                    { new Guid("f213c179-9656-4966-9797-87cd47aaadc6"), "public/default/dry.png", null, "De que forma pretende secar?", "Secar" },
                    { new Guid("fcd97809-3160-4091-a3d5-219b557e3e00"), "public/default/repair.png", null, "De que forma pretende arranjar a peça?", "Reparar" }
                });

            migrationBuilder.InsertData(
                table: "maintenance_service_actions",
                columns: new[] { "id", "badge", "deleted_at", "Description", "eco_score", "maintenance_service_id", "sustainable_points", "title" },
                values: new object[,]
                {
                    { new Guid("05f03e3d-9e58-416b-b101-0f432d1f0ed0"), "public/default/wash/less30.png", null, "Lavar a menos de 30ºC", -1, new Guid("b602935e-3aee-4f0d-9ca7-cfbb2fbdc30e"), 2, "A menos de 30ºC" },
                    { new Guid("32934261-c460-4f4c-bdd8-ea0e2fcf05af"), "public/default/service.png", null, "Escolhe um serviço de Reparação", 10, new Guid("fcd97809-3160-4091-a3d5-219b557e3e00"), 100, "Serviço de Reparação" },
                    { new Guid("4571ac7e-39a5-410a-96c5-ee9904b89b82"), "public/default/dry/air.png", null, "Secar ao ar livre", 0, new Guid("f213c179-9656-4966-9797-87cd47aaadc6"), 2, "Ao ar livre" },
                    { new Guid("6c73427d-6353-4aef-bbc6-589e523cf7b1"), "public/default/wash/less95.png", null, "Lavar a menos de 95ºC", -2, new Guid("b602935e-3aee-4f0d-9ca7-cfbb2fbdc30e"), 1, "A menos de 95ºC" },
                    { new Guid("87bac1eb-24d4-4dce-a0df-0d0eacb1f646"), "public/default/iron/less110.png", null, "Engomar a menos de 110ºC", -1, new Guid("5c396f08-c679-4de4-b33f-cc9479339b65"), 1, "A menos de 110ºC" },
                    { new Guid("89c46e4c-8f46-4a27-b536-7cc0aaba5ebe"), "public/default/repair.png", null, "Arranjar a peça pelo próprio", 2, new Guid("fcd97809-3160-4091-a3d5-219b557e3e00"), 3, "Pelo Próprio" },
                    { new Guid("a001c879-f216-4f59-9c3f-4be92ae219ae"), "public/default/service.png", null, "Escolhe uma lavandaria", 10, new Guid("b602935e-3aee-4f0d-9ca7-cfbb2fbdc30e"), 100, "Serviço de lavandaria" },
                    { new Guid("a50d1561-f670-4a00-a024-195c0be5297b"), "public/default/iron/less150.png", null, "Engomar a menos de 150ºC", -1, new Guid("5c396f08-c679-4de4-b33f-cc9479339b65"), 1, "A menos de 150ºC" },
                    { new Guid("ac866e00-72b6-4bb3-b587-63367f734a3d"), "public/default/wash/less70.png", null, "Lavar a menos de 70ºC", -2, new Guid("b602935e-3aee-4f0d-9ca7-cfbb2fbdc30e"), 1, "A menos de 70ºC" },
                    { new Guid("b095ed57-75c0-485e-a525-6dda417f793a"), "public/default/dry/machine.png", null, "Secar na máquina", -1, new Guid("f213c179-9656-4966-9797-87cd47aaadc6"), 1, "Na máquina" },
                    { new Guid("c7e2a377-e74b-4000-a922-4c3521e48533"), "public/default/service.png", null, "Escolhe um serviço de engomadoria", 10, new Guid("5c396f08-c679-4de4-b33f-cc9479339b65"), 100, "Serviço de Engomadoria" },
                    { new Guid("d62e1039-4de2-448c-ac6b-1e56c961aaa7"), "public/default/wash/dry.png", null, "Lavar a seco", -3, new Guid("b602935e-3aee-4f0d-9ca7-cfbb2fbdc30e"), 0, "A seco" },
                    { new Guid("ec3b4627-d2d8-4416-8682-ae794124de0a"), "public/default/wash/less50.png", null, "Lavar a menos de 50ºC", -2, new Guid("b602935e-3aee-4f0d-9ca7-cfbb2fbdc30e"), 1, "A menos de 50ºC" },
                    { new Guid("faed1a53-f944-47c5-87e1-6cffa38aab9e"), "public/default/service.png", null, "Escolhe um serviço de secagem", 10, new Guid("f213c179-9656-4966-9797-87cd47aaadc6"), 100, "Serviço de Secagem" },
                    { new Guid("fc706a98-3259-4fdd-bc96-3262fda6523c"), "public/default/iron/less200.png", null, "Engomar a menos de 200ºC", -1, new Guid("5c396f08-c679-4de4-b33f-cc9479339b65"), 1, "A menos de 200ºC" },
                    { new Guid("fc96b20c-5688-40c7-8ac8-367bb02cd3a5"), "public/default/wash/hand.png", null, "Lavar à mão com água e sabão", 10, new Guid("b602935e-3aee-4f0d-9ca7-cfbb2fbdc30e"), 100, "Lavar à mão" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_workers_profile",
                table: "workers",
                column: "profile");

            migrationBuilder.CreateIndex(
                name: "IX_workers_store",
                table: "workers",
                column: "store");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "workers");

            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: new Guid("425a08cc-2461-41bb-8675-b176bb123d17"));

            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: new Guid("58333572-1aa2-4593-943a-561656cb5442"));

            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: new Guid("76f849ce-dea4-4be1-b382-8d58e2700397"));

            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: new Guid("b654e9f3-eff8-4459-ac13-9f8de5410adb"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("01415c63-31c9-4c0e-871a-2c15eab5f310"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("070ea6d3-97fe-4da8-9126-02ead99a3ece"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("1951621c-fe5f-4862-be80-6aef862a8456"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("1f3bee85-4ac2-41f1-a833-b25d0d8bbee8"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("29cfea6b-8f83-4393-80be-fbb4369a34f3"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("4d325138-a5bc-4eaf-8276-2eda182a8655"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("54d6d0b6-77e8-4701-89bc-9ae04a2c1e91"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("6792374c-3fbe-4103-ac5c-53681b63dedb"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("6a02b907-456b-4e1e-96f6-dfb889d63897"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("6b49e020-594e-469d-bba3-439193d20f35"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("6c1f1c50-189b-47e4-8d58-2648e2cf41eb"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("6f7dfbd4-ab1f-45f6-a654-2f9e2346c9da"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("8fd93f80-e27b-4ded-b7f5-a0681687ff78"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("99222e34-260b-4ff7-b992-473bc7781cd0"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("a91ba19f-c014-4370-a575-1f1a44bc5d2b"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("ae0903f3-1ded-422b-88fa-a39d90b6e9eb"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("b52e1c6e-5db8-4224-905c-acf2363c0248"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("bc16833f-d275-4549-b37a-98ede7f9fdf7"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("becd4059-05b2-4daf-876a-2be7f7464a01"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("c1c908db-6402-4070-a34b-c3996082c99e"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("e9f77356-187c-47ac-8fc3-b5171e12b8ba"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("05f03e3d-9e58-416b-b101-0f432d1f0ed0"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("32934261-c460-4f4c-bdd8-ea0e2fcf05af"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("4571ac7e-39a5-410a-96c5-ee9904b89b82"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("6c73427d-6353-4aef-bbc6-589e523cf7b1"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("87bac1eb-24d4-4dce-a0df-0d0eacb1f646"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("89c46e4c-8f46-4a27-b536-7cc0aaba5ebe"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("a001c879-f216-4f59-9c3f-4be92ae219ae"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("a50d1561-f670-4a00-a024-195c0be5297b"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("ac866e00-72b6-4bb3-b587-63367f734a3d"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("b095ed57-75c0-485e-a525-6dda417f793a"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("c7e2a377-e74b-4000-a922-4c3521e48533"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("d62e1039-4de2-448c-ac6b-1e56c961aaa7"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("ec3b4627-d2d8-4416-8682-ae794124de0a"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("faed1a53-f944-47c5-87e1-6cffa38aab9e"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("fc706a98-3259-4fdd-bc96-3262fda6523c"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("fc96b20c-5688-40c7-8ac8-367bb02cd3a5"));

            migrationBuilder.DeleteData(
                table: "maintenance_services",
                keyColumn: "id",
                keyValue: new Guid("5c396f08-c679-4de4-b33f-cc9479339b65"));

            migrationBuilder.DeleteData(
                table: "maintenance_services",
                keyColumn: "id",
                keyValue: new Guid("b602935e-3aee-4f0d-9ca7-cfbb2fbdc30e"));

            migrationBuilder.DeleteData(
                table: "maintenance_services",
                keyColumn: "id",
                keyValue: new Guid("f213c179-9656-4966-9797-87cd47aaadc6"));

            migrationBuilder.DeleteData(
                table: "maintenance_services",
                keyColumn: "id",
                keyValue: new Guid("fcd97809-3160-4091-a3d5-219b557e3e00"));

            migrationBuilder.InsertData(
                table: "brands",
                columns: new[] { "id", "brand_avatar", "deleted_at", "name" },
                values: new object[,]
                {
                    { new Guid("0096181c-d722-4b50-ac62-f627c9bef4a6"), "public/default/brands/mo.png", null, "MO" },
                    { new Guid("161d571e-5c72-401f-9199-e1571963b408"), "public/default/brands/salsa.png", null, "Salsa" },
                    { new Guid("3a12fca1-9b07-4f9b-abb3-d25fe55eeb98"), "public/default/brands/zippy.png", null, "Zippy" },
                    { new Guid("c9571870-eea4-4161-9995-14a2c68111ef"), "public/default/brands/losan.png", null, "Losan" }
                });

            migrationBuilder.InsertData(
                table: "colors",
                columns: new[] { "id", "deleted_at", "hex", "name" },
                values: new object[,]
                {
                    { new Guid("02a23eb3-0b4a-4385-8e2e-5ab054bf9ec1"), null, "FFFF6D6D", "Vermelho Claro" },
                    { new Guid("2c3dc5fa-d200-4dff-ae35-bf7f4a799763"), null, "FFBE5967", "Rosa" },
                    { new Guid("48652000-2bcb-4e44-8bd0-16477e433064"), null, "FFC3A572", "Amarelo Claro" },
                    { new Guid("513888c7-caad-48bb-9524-3512cfa69001"), null, "FF98B3C8", "Azul Claro" },
                    { new Guid("720b5b5a-5684-40ca-a466-4c73748003e0"), null, "FF8B5F3C", "Castanho Bebê" },
                    { new Guid("7eef72d8-8f34-42e2-8ec1-c9798040d755"), null, "FF000000", "Black" },
                    { new Guid("95d71e40-3988-4c0e-91cb-214fc33783ce"), null, "FFF9C7C4", "Rosa Claro" },
                    { new Guid("97636597-5751-407b-9ea8-d03efcb03fad"), null, "FF4A2D16", "Castanho" },
                    { new Guid("97a3ba7d-ca46-4001-a485-5615807e48ed"), null, "FF509C75", "Verde" },
                    { new Guid("9e08cc8a-a9ff-4110-a14f-e825fd216834"), null, "FFFFFFFF", "White" },
                    { new Guid("aad149cd-e854-4ea5-b473-6668e83bc29e"), null, "FFC2BC8B", "Verde Lima" },
                    { new Guid("b2b28c72-ea70-47a9-8973-8d6539cd745c"), null, "FFC0C0C0", "Cinzento Bebê" },
                    { new Guid("b8279caa-e59b-431f-a9c9-8e2fe8ee18d9"), null, "FF4C4C4C", "Cinzento Claro" },
                    { new Guid("cde49ee6-36c7-465f-83bb-272782b815bc"), null, "FFF2E7D4", "Amarelo Bebê" },
                    { new Guid("d35dc6f6-895b-4929-bc89-2b6189b2339b"), null, "FFD2AAC5", "Roxo Claro" },
                    { new Guid("e0f3a1ff-bba6-4192-a587-0eb39421ead1"), null, "FF948066", "Castanho Claro" },
                    { new Guid("e1b408b0-6938-4304-a120-8d321f0398fe"), null, "FFFFE69F", "Amarelo" },
                    { new Guid("e47ed693-2b80-4415-82ba-23165d7336f3"), null, "FFF58221", "Laranja" },
                    { new Guid("e5245c36-1c08-4cdb-91ce-247dce34fa3b"), null, "FF29394A", "Azul Escuro" },
                    { new Guid("ea97c70a-e4a9-42c8-9ee9-3d182dc24e52"), null, "FFDA252E", "Vermelho" },
                    { new Guid("ebcb89dc-0598-4020-87f6-4cb0bea6d8a7"), null, "FFD62598", "Roxo" }
                });

            migrationBuilder.InsertData(
                table: "maintenance_services",
                columns: new[] { "id", "badge", "deleted_at", "description", "title" },
                values: new object[,]
                {
                    { new Guid("39d39f68-5c87-489f-9ccb-da6d6e13966e"), "public/default/wash.png", null, "De que forma pretende lavar?", "Lavar" },
                    { new Guid("3cd01305-e232-4931-8096-e3d2d51479b5"), "public/default/repair.png", null, "De que forma pretende arranjar a peça?", "Reparar" },
                    { new Guid("836e6abf-bb0f-48fe-8079-d6c94a1fc6d0"), "public/default/iron.png", null, "De que forma pretende engomar?", "Engomar" },
                    { new Guid("c722c2ce-1bbf-4e14-a458-319ab9660a77"), "public/default/dry.png", null, "De que forma pretende secar?", "Secar" }
                });

            migrationBuilder.InsertData(
                table: "maintenance_service_actions",
                columns: new[] { "id", "badge", "deleted_at", "Description", "eco_score", "maintenance_service_id", "sustainable_points", "title" },
                values: new object[,]
                {
                    { new Guid("193fcff2-16d9-478b-8b56-dd823c182cb0"), "public/default/service.png", null, "Escolhe um serviço de secagem", 10, new Guid("c722c2ce-1bbf-4e14-a458-319ab9660a77"), 100, "Serviço de Secagem" },
                    { new Guid("2b82e11d-ea01-481d-b11d-b687746db5e1"), "public/default/iron/less110.png", null, "Engomar a menos de 110ºC", -1, new Guid("836e6abf-bb0f-48fe-8079-d6c94a1fc6d0"), 1, "A menos de 110ºC" },
                    { new Guid("32999cf2-654f-4351-9116-8f0325521ea2"), "public/default/dry/air.png", null, "Secar ao ar livre", 0, new Guid("c722c2ce-1bbf-4e14-a458-319ab9660a77"), 2, "Ao ar livre" },
                    { new Guid("4ac0e147-d714-44a6-bb5a-59771a3e7f5d"), "public/default/iron/less200.png", null, "Engomar a menos de 200ºC", -1, new Guid("836e6abf-bb0f-48fe-8079-d6c94a1fc6d0"), 1, "A menos de 200ºC" },
                    { new Guid("54365680-ce72-4121-a1b8-c88ea2437084"), "public/default/service.png", null, "Escolhe uma lavandaria", 10, new Guid("39d39f68-5c87-489f-9ccb-da6d6e13966e"), 100, "Serviço de lavandaria" },
                    { new Guid("5dfda032-c8ee-4033-ae76-593ea072f237"), "public/default/wash/dry.png", null, "Lavar a seco", -3, new Guid("39d39f68-5c87-489f-9ccb-da6d6e13966e"), 0, "A seco" },
                    { new Guid("5f37f47b-95fd-484e-97c8-a057069a54a4"), "public/default/wash/less70.png", null, "Lavar a menos de 70ºC", -2, new Guid("39d39f68-5c87-489f-9ccb-da6d6e13966e"), 1, "A menos de 70ºC" },
                    { new Guid("9462a987-f2a6-4528-8e5b-cd9530f99df6"), "public/default/wash/hand.png", null, "Lavar à mão com água e sabão", 10, new Guid("39d39f68-5c87-489f-9ccb-da6d6e13966e"), 100, "Lavar à mão" },
                    { new Guid("9b19552a-e36a-4288-be29-b5f87c3702db"), "public/default/wash/less50.png", null, "Lavar a menos de 50ºC", -2, new Guid("39d39f68-5c87-489f-9ccb-da6d6e13966e"), 1, "A menos de 50ºC" },
                    { new Guid("a0037ec4-d4bd-4205-b88e-7878e64d22f4"), "public/default/dry/machine.png", null, "Secar na máquina", -1, new Guid("c722c2ce-1bbf-4e14-a458-319ab9660a77"), 1, "Na máquina" },
                    { new Guid("a797edd7-e33c-40ec-8bc7-fcea167230e6"), "public/default/iron/less150.png", null, "Engomar a menos de 150ºC", -1, new Guid("836e6abf-bb0f-48fe-8079-d6c94a1fc6d0"), 1, "A menos de 150ºC" },
                    { new Guid("ab8273a1-d2f8-4622-91a7-22603606d0f7"), "public/default/repair.png", null, "Arranjar a peça pelo próprio", 2, new Guid("3cd01305-e232-4931-8096-e3d2d51479b5"), 3, "Pelo Próprio" },
                    { new Guid("aeebca6a-9c35-4795-a0ca-cb83dfb9dae8"), "public/default/wash/less30.png", null, "Lavar a menos de 30ºC", -1, new Guid("39d39f68-5c87-489f-9ccb-da6d6e13966e"), 2, "A menos de 30ºC" },
                    { new Guid("d2a45b21-3a45-4006-a3f0-71873769b699"), "public/default/wash/less95.png", null, "Lavar a menos de 95ºC", -2, new Guid("39d39f68-5c87-489f-9ccb-da6d6e13966e"), 1, "A menos de 95ºC" },
                    { new Guid("d83e91bb-7706-49ab-810a-c799bb08b8b0"), "public/default/service.png", null, "Escolhe um serviço de engomadoria", 10, new Guid("836e6abf-bb0f-48fe-8079-d6c94a1fc6d0"), 100, "Serviço de Engomadoria" },
                    { new Guid("fc46dc94-5db8-4925-98b0-5b7c92675661"), "public/default/service.png", null, "Escolhe um serviço de Reparação", 10, new Guid("3cd01305-e232-4931-8096-e3d2d51479b5"), 100, "Serviço de Reparação" }
                });
        }
    }
}
