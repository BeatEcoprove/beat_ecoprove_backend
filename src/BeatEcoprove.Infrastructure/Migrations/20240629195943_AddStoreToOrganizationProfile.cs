using System;
using Microsoft.EntityFrameworkCore.Migrations;
using NetTopologySuite.Geometries;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BeatEcoprove.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddStoreToOrganizationProfile : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: new Guid("41ceff9e-ab2d-451b-8620-1ab4bb11b01e"));

            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: new Guid("7d4d570a-161c-471d-a215-4a20bd9ac7fc"));

            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: new Guid("a75a802e-3d36-4758-a1bd-b6c10921fabd"));

            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: new Guid("f7204e3f-abaa-470e-8414-bd2b9a125922"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("20fc9439-bfbc-464d-a926-9cb3611a60b8"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("255e8ded-4cb1-4cfa-af4a-d32f59782c2b"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("36276319-b7e8-45c7-abb1-367a9c2dd8d4"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("43fd3146-3d27-4587-8488-5777a03ce051"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("4da91aa9-9b5a-4ea2-a1f3-f90f129e131c"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("514d715f-d2be-46e6-a26e-def74f86c34f"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("6f0e8f81-1d26-42b0-8486-309d88f6706e"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("732ceee4-cbc1-4da2-ba48-9dabef21fd70"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("78d90733-b192-4964-b733-181d8188c995"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("83915387-5790-4e37-93c1-925524fdf83c"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("8596c490-f56c-4342-aca8-f57b022a0782"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("a9252ddf-31fd-4e1b-8bda-8619a38e5c6e"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("c29e07f5-f501-4b19-ad4e-04448924614d"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("c695cf1a-36d6-4bd8-9bf4-ad770a814b3e"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("c8b454d8-6c62-4c0d-8f9a-70f46e326825"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("d028205b-ff7a-4c79-bd26-1be1a8bae5a8"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("e3ce96e6-5bd8-4e1c-ba23-15753b192687"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("e87764b0-602b-407f-8550-07aee8fb7e9e"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("f186dbef-b99c-4516-ba23-7d5c2ad5323a"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("f4846e38-6ffe-447b-b754-3821205d1fa7"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("f89f40db-2b7f-402e-a6d1-acac00cd16a2"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("1b89d648-fa9e-4e44-a61d-6637096488df"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("39648a00-0e22-4094-a38c-42b9df16fecd"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("4082ffce-305f-430c-acb7-dc808d9f94a7"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("47596bcf-350f-4509-8cf4-e8029b532737"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("48eb4b7e-c4f7-446a-a2cf-10c666585055"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("508831ef-b6bd-49f4-8561-2b072ac8716d"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("59b08b9f-18bf-4e09-bc4e-c05ccaf70ba2"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("5de969a3-9d9c-489d-8002-1785899bad84"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("8be53abd-a205-4e01-a03c-d26ff8e20af7"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("96089038-8ded-48ef-8d5e-f7b24c5a91ee"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("a91d9133-4478-4394-bbbf-a40011e273de"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("ba6414ba-28e9-4e06-833e-e470cbc48e77"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("dd41c67b-ba1d-4c7a-81b1-3332b28f98e7"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("e161a149-2433-4554-aa46-74351dd929c9"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("e4330b1e-61dd-47bb-8fe9-f792495a20a9"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("f75bba9f-e315-4694-a3be-642a83de9e10"));

            migrationBuilder.DeleteData(
                table: "maintenance_services",
                keyColumn: "id",
                keyValue: new Guid("2e2dc041-752f-4988-b1b9-539dc6b69171"));

            migrationBuilder.DeleteData(
                table: "maintenance_services",
                keyColumn: "id",
                keyValue: new Guid("3397ea20-8508-40a6-88b0-8641b0df9a6c"));

            migrationBuilder.DeleteData(
                table: "maintenance_services",
                keyColumn: "id",
                keyValue: new Guid("938b1c39-a683-4e1a-b2ad-51ffdd8a5923"));

            migrationBuilder.DeleteData(
                table: "maintenance_services",
                keyColumn: "id",
                keyValue: new Guid("d513efe0-a5fb-408a-8ade-2e173520f7ec"));

            migrationBuilder.AlterDatabase()
                .Annotation("Npgsql:PostgresExtension:postgis", ",,")
                .Annotation("Npgsql:PostgresExtension:postgis_topology", ",,");

            migrationBuilder.CreateTable(
                name: "stores",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    owner = table.Column<Guid>(type: "uuid", nullable: false),
                    name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    localization = table.Column<Point>(type: "geometry", nullable: false),
                    street = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false),
                    port = table.Column<int>(type: "integer", nullable: false),
                    locality = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false),
                    postal_code = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false),
                    sustainable_points = table.Column<int>(type: "integer", nullable: false),
                    rating = table.Column<double>(type: "double precision", nullable: false),
                    picture = table.Column<string>(type: "text", nullable: false),
                    level = table.Column<int>(type: "integer", nullable: false),
                    deleted_at = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_stores", x => x.id);
                    table.ForeignKey(
                        name: "FK_stores_profiles_owner",
                        column: x => x.owner,
                        principalTable: "profiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_stores_owner",
                table: "stores",
                column: "owner");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "stores");

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

            migrationBuilder.AlterDatabase()
                .OldAnnotation("Npgsql:PostgresExtension:postgis", ",,")
                .OldAnnotation("Npgsql:PostgresExtension:postgis_topology", ",,");

            migrationBuilder.InsertData(
                table: "brands",
                columns: new[] { "id", "brand_avatar", "deleted_at", "name" },
                values: new object[,]
                {
                    { new Guid("41ceff9e-ab2d-451b-8620-1ab4bb11b01e"), "public/default/brands/zippy.png", null, "Zippy" },
                    { new Guid("7d4d570a-161c-471d-a215-4a20bd9ac7fc"), "public/default/brands/mo.png", null, "MO" },
                    { new Guid("a75a802e-3d36-4758-a1bd-b6c10921fabd"), "public/default/brands/salsa.png", null, "Salsa" },
                    { new Guid("f7204e3f-abaa-470e-8414-bd2b9a125922"), "public/default/brands/losan.png", null, "Losan" }
                });

            migrationBuilder.InsertData(
                table: "colors",
                columns: new[] { "id", "deleted_at", "hex", "name" },
                values: new object[,]
                {
                    { new Guid("20fc9439-bfbc-464d-a926-9cb3611a60b8"), null, "FFFFE69F", "Amarelo" },
                    { new Guid("255e8ded-4cb1-4cfa-af4a-d32f59782c2b"), null, "FF4C4C4C", "Cinzento Claro" },
                    { new Guid("36276319-b7e8-45c7-abb1-367a9c2dd8d4"), null, "FF4A2D16", "Castanho" },
                    { new Guid("43fd3146-3d27-4587-8488-5777a03ce051"), null, "FFC2BC8B", "Verde Lima" },
                    { new Guid("4da91aa9-9b5a-4ea2-a1f3-f90f129e131c"), null, "FFF9C7C4", "Rosa Claro" },
                    { new Guid("514d715f-d2be-46e6-a26e-def74f86c34f"), null, "FFF58221", "Laranja" },
                    { new Guid("6f0e8f81-1d26-42b0-8486-309d88f6706e"), null, "FFDA252E", "Vermelho" },
                    { new Guid("732ceee4-cbc1-4da2-ba48-9dabef21fd70"), null, "FF98B3C8", "Azul Claro" },
                    { new Guid("78d90733-b192-4964-b733-181d8188c995"), null, "FFF2E7D4", "Amarelo Bebê" },
                    { new Guid("83915387-5790-4e37-93c1-925524fdf83c"), null, "FF509C75", "Verde" },
                    { new Guid("8596c490-f56c-4342-aca8-f57b022a0782"), null, "FFD2AAC5", "Roxo Claro" },
                    { new Guid("a9252ddf-31fd-4e1b-8bda-8619a38e5c6e"), null, "FF29394A", "Azul Escuro" },
                    { new Guid("c29e07f5-f501-4b19-ad4e-04448924614d"), null, "FFFFFFFF", "White" },
                    { new Guid("c695cf1a-36d6-4bd8-9bf4-ad770a814b3e"), null, "FFC3A572", "Amarelo Claro" },
                    { new Guid("c8b454d8-6c62-4c0d-8f9a-70f46e326825"), null, "FFC0C0C0", "Cinzento Bebê" },
                    { new Guid("d028205b-ff7a-4c79-bd26-1be1a8bae5a8"), null, "FF000000", "Black" },
                    { new Guid("e3ce96e6-5bd8-4e1c-ba23-15753b192687"), null, "FF8B5F3C", "Castanho Bebê" },
                    { new Guid("e87764b0-602b-407f-8550-07aee8fb7e9e"), null, "FF948066", "Castanho Claro" },
                    { new Guid("f186dbef-b99c-4516-ba23-7d5c2ad5323a"), null, "FFFF6D6D", "Vermelho Claro" },
                    { new Guid("f4846e38-6ffe-447b-b754-3821205d1fa7"), null, "FFD62598", "Roxo" },
                    { new Guid("f89f40db-2b7f-402e-a6d1-acac00cd16a2"), null, "FFBE5967", "Rosa" }
                });

            migrationBuilder.InsertData(
                table: "maintenance_services",
                columns: new[] { "id", "badge", "deleted_at", "description", "title" },
                values: new object[,]
                {
                    { new Guid("2e2dc041-752f-4988-b1b9-539dc6b69171"), "public/default/iron.png", null, "De que forma pretende engomar?", "Engomar" },
                    { new Guid("3397ea20-8508-40a6-88b0-8641b0df9a6c"), "public/default/wash.png", null, "De que forma pretende lavar?", "Lavar" },
                    { new Guid("938b1c39-a683-4e1a-b2ad-51ffdd8a5923"), "public/default/dry.png", null, "De que forma pretende secar?", "Secar" },
                    { new Guid("d513efe0-a5fb-408a-8ade-2e173520f7ec"), "public/default/repair.png", null, "De que forma pretende arranjar a peça?", "Reparar" }
                });

            migrationBuilder.InsertData(
                table: "maintenance_service_actions",
                columns: new[] { "id", "badge", "deleted_at", "Description", "eco_score", "maintenance_service_id", "sustainable_points", "title" },
                values: new object[,]
                {
                    { new Guid("1b89d648-fa9e-4e44-a61d-6637096488df"), "public/default/iron/less110.png", null, "Engomar a menos de 110ºC", -1, new Guid("2e2dc041-752f-4988-b1b9-539dc6b69171"), 1, "A menos de 110ºC" },
                    { new Guid("39648a00-0e22-4094-a38c-42b9df16fecd"), "public/default/repair.png", null, "Arranjar a peça pelo próprio", 2, new Guid("d513efe0-a5fb-408a-8ade-2e173520f7ec"), 3, "Pelo Próprio" },
                    { new Guid("4082ffce-305f-430c-acb7-dc808d9f94a7"), "public/default/wash/dry.png", null, "Lavar a seco", -3, new Guid("3397ea20-8508-40a6-88b0-8641b0df9a6c"), 0, "A seco" },
                    { new Guid("47596bcf-350f-4509-8cf4-e8029b532737"), "public/default/service.png", null, "Escolhe um serviço de Reparação", 10, new Guid("d513efe0-a5fb-408a-8ade-2e173520f7ec"), 100, "Serviço de Reparação" },
                    { new Guid("48eb4b7e-c4f7-446a-a2cf-10c666585055"), "public/default/wash/less50.png", null, "Lavar a menos de 50ºC", -2, new Guid("3397ea20-8508-40a6-88b0-8641b0df9a6c"), 1, "A menos de 50ºC" },
                    { new Guid("508831ef-b6bd-49f4-8561-2b072ac8716d"), "public/default/iron/less150.png", null, "Engomar a menos de 150ºC", -1, new Guid("2e2dc041-752f-4988-b1b9-539dc6b69171"), 1, "A menos de 150ºC" },
                    { new Guid("59b08b9f-18bf-4e09-bc4e-c05ccaf70ba2"), "public/default/wash/less70.png", null, "Lavar a menos de 70ºC", -2, new Guid("3397ea20-8508-40a6-88b0-8641b0df9a6c"), 1, "A menos de 70ºC" },
                    { new Guid("5de969a3-9d9c-489d-8002-1785899bad84"), "public/default/service.png", null, "Escolhe um serviço de secagem", 10, new Guid("938b1c39-a683-4e1a-b2ad-51ffdd8a5923"), 100, "Serviço de Secagem" },
                    { new Guid("8be53abd-a205-4e01-a03c-d26ff8e20af7"), "public/default/wash/less30.png", null, "Lavar a menos de 30ºC", -1, new Guid("3397ea20-8508-40a6-88b0-8641b0df9a6c"), 2, "A menos de 30ºC" },
                    { new Guid("96089038-8ded-48ef-8d5e-f7b24c5a91ee"), "public/default/wash/hand.png", null, "Lavar à mão com água e sabão", 10, new Guid("3397ea20-8508-40a6-88b0-8641b0df9a6c"), 100, "Lavar à mão" },
                    { new Guid("a91d9133-4478-4394-bbbf-a40011e273de"), "public/default/dry/air.png", null, "Secar ao ar livre", 0, new Guid("938b1c39-a683-4e1a-b2ad-51ffdd8a5923"), 2, "Ao ar livre" },
                    { new Guid("ba6414ba-28e9-4e06-833e-e470cbc48e77"), "public/default/service.png", null, "Escolhe uma lavandaria", 10, new Guid("3397ea20-8508-40a6-88b0-8641b0df9a6c"), 100, "Serviço de lavandaria" },
                    { new Guid("dd41c67b-ba1d-4c7a-81b1-3332b28f98e7"), "public/default/iron/less200.png", null, "Engomar a menos de 200ºC", -1, new Guid("2e2dc041-752f-4988-b1b9-539dc6b69171"), 1, "A menos de 200ºC" },
                    { new Guid("e161a149-2433-4554-aa46-74351dd929c9"), "public/default/service.png", null, "Escolhe um serviço de engomadoria", 10, new Guid("2e2dc041-752f-4988-b1b9-539dc6b69171"), 100, "Serviço de Engomadoria" },
                    { new Guid("e4330b1e-61dd-47bb-8fe9-f792495a20a9"), "public/default/dry/machine.png", null, "Secar na máquina", -1, new Guid("938b1c39-a683-4e1a-b2ad-51ffdd8a5923"), 1, "Na máquina" },
                    { new Guid("f75bba9f-e315-4694-a3be-642a83de9e10"), "public/default/wash/less95.png", null, "Lavar a menos de 95ºC", -2, new Guid("3397ea20-8508-40a6-88b0-8641b0df9a6c"), 1, "A menos de 95ºC" }
                });
        }
    }
}
