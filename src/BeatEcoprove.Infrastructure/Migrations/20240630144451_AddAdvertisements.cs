using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BeatEcoprove.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddAdvertisements : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: new Guid("095236fd-6e55-4a5d-86a4-03f4a6a60721"));

            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: new Guid("11879d80-99a3-4997-9d46-27a64ad34726"));

            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: new Guid("5543362e-4982-4355-8a3f-9a91c2ce778f"));

            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: new Guid("7c4c914a-ecb9-437d-a194-78e1a8418452"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("008bd8b9-71a8-4dd7-999b-8abf04bdc3c4"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("22228017-2fbf-467c-8de8-553939e3a43f"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("2a24f4ae-56c2-49f0-be23-e6db9f93fb6b"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("2eb871b5-0c46-42dd-a29f-823cff0bcb43"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("34d2c6fb-d196-46dd-b431-34a4aca841f4"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("35668905-d74e-46d2-ba0a-8af9b8183bce"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("3dce264d-6dbe-478a-b749-f8f95b516428"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("43011b93-88c7-474a-8255-b5957df81a1c"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("4e92785a-5d0e-446e-aef0-f0ad1c03d9fd"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("64d00f10-4a84-4d2e-b8e3-bb248e6a3ef6"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("924b4e98-efc8-4745-9771-bb673a0886b3"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("98c20101-606f-4f1e-8ea6-6314de00aea3"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("a2f22c7f-a16b-4d55-9c91-5cf1a8e95f08"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("a7f31f49-54be-420d-a083-1f18683da36c"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("b163e41f-e62e-4c1a-8a9f-27b3a38e0565"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("c501fd44-52f3-45a9-a037-14d892bbe69e"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("c52f7152-1327-44d5-8f2c-f1ae30170552"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("cd0a4da0-a416-41d4-ae60-266dcd571fbb"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("cd6fcbde-7a63-4238-82d3-c9c5edd97eda"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("f47738ee-f66a-490a-9bbc-2f0f586b7388"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("fe69c355-868d-4438-9c16-fc7dc7a84c03"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("080c528c-1027-4c45-b37e-4439a10c6693"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("15a4e75a-65f8-43b6-b7bc-6340aa805779"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("30c7b3f5-b1ec-4378-bccc-8f953cbdf8b1"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("37bdfc4b-5239-4d8d-97e4-b32bf5353cba"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("3bdbbc0e-4858-489d-b745-5d64ef58d7ab"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("489ee762-57bb-4f35-bdfd-9877ac926c8e"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("4b327cea-441a-4bfe-9430-4da53f423f15"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("62c16c1e-8fa6-44d3-b81a-3dc65fc1bba0"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("6c1a50a3-c2a7-45af-b1d6-f38b102c5e58"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("6dd490ef-89dc-4659-8411-1ffbb75e56cf"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("7747ed77-93d5-44b2-b3aa-4ea6ffaa6a33"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("b32af17b-43d5-4030-8ca5-fde8a1f68903"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("d187afe4-b7e3-46d3-8646-1d92264210c8"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("d8d6c354-cc08-4ae0-b04c-ed65d60e581b"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("da4fcd6d-cb60-4891-a80f-7440f1816a93"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("ff3423f6-4fed-416f-9b34-ef1fa6189503"));

            migrationBuilder.DeleteData(
                table: "maintenance_services",
                keyColumn: "id",
                keyValue: new Guid("05d68c18-7fc2-4ae4-88f4-f26896bc1136"));

            migrationBuilder.DeleteData(
                table: "maintenance_services",
                keyColumn: "id",
                keyValue: new Guid("2fe22a88-372c-4dcb-af10-2c8c4373eb97"));

            migrationBuilder.DeleteData(
                table: "maintenance_services",
                keyColumn: "id",
                keyValue: new Guid("9de188bc-88ce-424f-bbc0-df22d39b0132"));

            migrationBuilder.DeleteData(
                table: "maintenance_services",
                keyColumn: "id",
                keyValue: new Guid("f6c34e93-6162-47e7-aaf0-8eb52e255c4d"));

            migrationBuilder.CreateTable(
                name: "advertisements",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    creator = table.Column<Guid>(type: "uuid", nullable: false),
                    title = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    description = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false),
                    init_date = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    end_date = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    picture = table.Column<string>(type: "text", nullable: false),
                    sustainable_points = table.Column<int>(type: "integer", nullable: false),
                    type = table.Column<int>(type: "integer", nullable: false),
                    quantity = table.Column<int>(type: "integer", nullable: true),
                    DeletedAt = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_advertisements", x => x.id);
                    table.ForeignKey(
                        name: "FK_advertisements_profiles_creator",
                        column: x => x.creator,
                        principalTable: "profiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "brands",
                columns: new[] { "id", "brand_avatar", "deleted_at", "name" },
                values: new object[,]
                {
                    { new Guid("1b9b19b0-1417-44cd-9538-e01794085ca1"), "public/default/brands/losan.png", null, "Losan" },
                    { new Guid("67ddcdeb-8851-4e72-b1dd-24195d6fee0b"), "public/default/brands/salsa.png", null, "Salsa" },
                    { new Guid("7a77766f-e7cf-4246-aace-3c8fa49b2196"), "public/default/brands/mo.png", null, "MO" },
                    { new Guid("b5163117-27f4-4dc5-8cc2-b4e2e50379cf"), "public/default/brands/zippy.png", null, "Zippy" }
                });

            migrationBuilder.InsertData(
                table: "colors",
                columns: new[] { "id", "deleted_at", "hex", "name" },
                values: new object[,]
                {
                    { new Guid("07285b40-abc9-45ed-bd62-3f6f92ed87f0"), null, "FF000000", "Black" },
                    { new Guid("0fd79b1e-55b6-4d6e-b271-5d8ba623bbe8"), null, "FF4C4C4C", "Cinzento Claro" },
                    { new Guid("130a8e90-009b-495a-b76b-47cf7890289c"), null, "FFC3A572", "Amarelo Claro" },
                    { new Guid("135e451a-1cc2-400c-966e-4b3bcdd3e7e5"), null, "FFDA252E", "Vermelho" },
                    { new Guid("173fe411-92dd-408b-96cf-96543b377801"), null, "FFC2BC8B", "Verde Lima" },
                    { new Guid("2b28d191-8385-4948-a6ce-9314235118ce"), null, "FF4A2D16", "Castanho" },
                    { new Guid("2bd83002-1f11-4e1f-b96f-e29274fd5b25"), null, "FF29394A", "Azul Escuro" },
                    { new Guid("302ae865-a2d6-4641-8e7b-c91de5ba55dd"), null, "FFFFE69F", "Amarelo" },
                    { new Guid("345dbbe2-760b-467b-8c34-d2cd20708ba2"), null, "FFC0C0C0", "Cinzento Bebê" },
                    { new Guid("396db88f-61e3-4391-a6da-7709858e39ab"), null, "FFF2E7D4", "Amarelo Bebê" },
                    { new Guid("465133a8-10ae-4adc-8ef5-ffefde60f6f8"), null, "FFBE5967", "Rosa" },
                    { new Guid("4e846ace-fb94-4337-bb3d-65e1f1c4f587"), null, "FF8B5F3C", "Castanho Bebê" },
                    { new Guid("5a5accf7-5412-4f2e-9fc5-8a8c84c90894"), null, "FFFF6D6D", "Vermelho Claro" },
                    { new Guid("5f4aeac5-196d-4d03-bd2f-43e1b3c1a119"), null, "FFD62598", "Roxo" },
                    { new Guid("a690c398-7ffd-44ab-93ca-498d22e4c0c6"), null, "FF509C75", "Verde" },
                    { new Guid("b011f5cc-dc7b-4c83-be6e-7d1827c96efb"), null, "FFFFFFFF", "White" },
                    { new Guid("c1f57589-1b6b-4336-80d1-3fb1fb727136"), null, "FFF9C7C4", "Rosa Claro" },
                    { new Guid("f10bf30b-d0f8-4cc0-b411-597b6ebf6b33"), null, "FF948066", "Castanho Claro" },
                    { new Guid("f6931fd9-2ed9-4c3e-97fa-08a613accf9d"), null, "FFF58221", "Laranja" },
                    { new Guid("f8e34e55-1ef3-4cc8-8eb9-bf33779ebf11"), null, "FF98B3C8", "Azul Claro" },
                    { new Guid("fd524a59-c2bf-4c0f-9f5e-4e5c1eab7272"), null, "FFD2AAC5", "Roxo Claro" }
                });

            migrationBuilder.InsertData(
                table: "maintenance_services",
                columns: new[] { "id", "badge", "deleted_at", "description", "title" },
                values: new object[,]
                {
                    { new Guid("01305132-39d8-454b-afba-727dda008a10"), "public/default/dry.png", null, "De que forma pretende secar?", "Secar" },
                    { new Guid("756e421b-47d9-4a97-8cdf-e996854a18c4"), "public/default/repair.png", null, "De que forma pretende arranjar a peça?", "Reparar" },
                    { new Guid("bdd540b1-b896-4451-8f2c-d2c511ede85d"), "public/default/wash.png", null, "De que forma pretende lavar?", "Lavar" },
                    { new Guid("fa7057fd-cb35-41c6-8260-aa0f03d6faa7"), "public/default/iron.png", null, "De que forma pretende engomar?", "Engomar" }
                });

            migrationBuilder.InsertData(
                table: "maintenance_service_actions",
                columns: new[] { "id", "badge", "deleted_at", "Description", "eco_score", "maintenance_service_id", "sustainable_points", "title" },
                values: new object[,]
                {
                    { new Guid("12f3023b-ea01-405a-991a-8b8420d0f6e7"), "public/default/service.png", null, "Escolhe uma lavandaria", 10, new Guid("bdd540b1-b896-4451-8f2c-d2c511ede85d"), 100, "Serviço de lavandaria" },
                    { new Guid("47601e84-5baf-48e1-b2eb-92c7fa3f5ac5"), "public/default/iron/less150.png", null, "Engomar a menos de 150ºC", -1, new Guid("fa7057fd-cb35-41c6-8260-aa0f03d6faa7"), 1, "A menos de 150ºC" },
                    { new Guid("4d67afc8-47f0-40a7-b096-3499881da632"), "public/default/iron/less200.png", null, "Engomar a menos de 200ºC", -1, new Guid("fa7057fd-cb35-41c6-8260-aa0f03d6faa7"), 1, "A menos de 200ºC" },
                    { new Guid("5360a760-2b91-4bc3-bfa3-c752f6ccd0b0"), "public/default/service.png", null, "Escolhe um serviço de engomadoria", 10, new Guid("fa7057fd-cb35-41c6-8260-aa0f03d6faa7"), 100, "Serviço de Engomadoria" },
                    { new Guid("54186aba-ade3-4da3-a96b-8a77be9b59b3"), "public/default/repair.png", null, "Arranjar a peça pelo próprio", 2, new Guid("756e421b-47d9-4a97-8cdf-e996854a18c4"), 3, "Pelo Próprio" },
                    { new Guid("5866f15d-fc62-4e4a-8d4a-a15cd8099a09"), "public/default/wash/less30.png", null, "Lavar a menos de 30ºC", -1, new Guid("bdd540b1-b896-4451-8f2c-d2c511ede85d"), 2, "A menos de 30ºC" },
                    { new Guid("719747b1-56ec-4b61-b722-81e9bd9eb13c"), "public/default/service.png", null, "Escolhe um serviço de secagem", 10, new Guid("01305132-39d8-454b-afba-727dda008a10"), 100, "Serviço de Secagem" },
                    { new Guid("865b823d-f94c-4f00-aeba-3e43294ebbc4"), "public/default/wash/less95.png", null, "Lavar a menos de 95ºC", -2, new Guid("bdd540b1-b896-4451-8f2c-d2c511ede85d"), 1, "A menos de 95ºC" },
                    { new Guid("87d546d7-5bbd-4945-ab33-9ac5eee9034c"), "public/default/wash/less50.png", null, "Lavar a menos de 50ºC", -2, new Guid("bdd540b1-b896-4451-8f2c-d2c511ede85d"), 1, "A menos de 50ºC" },
                    { new Guid("892896cf-b1e9-4adc-af6e-7767ed14962d"), "public/default/service.png", null, "Escolhe um serviço de Reparação", 10, new Guid("756e421b-47d9-4a97-8cdf-e996854a18c4"), 100, "Serviço de Reparação" },
                    { new Guid("912d6e4f-9964-423c-bb93-d4b7e90a8660"), "public/default/dry/machine.png", null, "Secar na máquina", -1, new Guid("01305132-39d8-454b-afba-727dda008a10"), 1, "Na máquina" },
                    { new Guid("94b258a4-6572-4e8c-9ef1-fa5466957be5"), "public/default/dry/air.png", null, "Secar ao ar livre", 0, new Guid("01305132-39d8-454b-afba-727dda008a10"), 2, "Ao ar livre" },
                    { new Guid("a12ec7b7-bded-4bb9-8aa7-b725677c3a55"), "public/default/wash/less70.png", null, "Lavar a menos de 70ºC", -2, new Guid("bdd540b1-b896-4451-8f2c-d2c511ede85d"), 1, "A menos de 70ºC" },
                    { new Guid("be01acb6-a65a-438d-9e4d-f4de15eb8a4b"), "public/default/iron/less110.png", null, "Engomar a menos de 110ºC", -1, new Guid("fa7057fd-cb35-41c6-8260-aa0f03d6faa7"), 1, "A menos de 110ºC" },
                    { new Guid("d48409fa-d9b1-4f76-927d-182f6ef425ba"), "public/default/wash/dry.png", null, "Lavar a seco", -3, new Guid("bdd540b1-b896-4451-8f2c-d2c511ede85d"), 0, "A seco" },
                    { new Guid("f5cfdf2e-0725-4d29-a3c6-440b558cc2b8"), "public/default/wash/hand.png", null, "Lavar à mão com água e sabão", 10, new Guid("bdd540b1-b896-4451-8f2c-d2c511ede85d"), 100, "Lavar à mão" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_advertisements_creator",
                table: "advertisements",
                column: "creator");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "advertisements");

            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: new Guid("1b9b19b0-1417-44cd-9538-e01794085ca1"));

            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: new Guid("67ddcdeb-8851-4e72-b1dd-24195d6fee0b"));

            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: new Guid("7a77766f-e7cf-4246-aace-3c8fa49b2196"));

            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: new Guid("b5163117-27f4-4dc5-8cc2-b4e2e50379cf"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("07285b40-abc9-45ed-bd62-3f6f92ed87f0"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("0fd79b1e-55b6-4d6e-b271-5d8ba623bbe8"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("130a8e90-009b-495a-b76b-47cf7890289c"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("135e451a-1cc2-400c-966e-4b3bcdd3e7e5"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("173fe411-92dd-408b-96cf-96543b377801"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("2b28d191-8385-4948-a6ce-9314235118ce"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("2bd83002-1f11-4e1f-b96f-e29274fd5b25"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("302ae865-a2d6-4641-8e7b-c91de5ba55dd"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("345dbbe2-760b-467b-8c34-d2cd20708ba2"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("396db88f-61e3-4391-a6da-7709858e39ab"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("465133a8-10ae-4adc-8ef5-ffefde60f6f8"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("4e846ace-fb94-4337-bb3d-65e1f1c4f587"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("5a5accf7-5412-4f2e-9fc5-8a8c84c90894"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("5f4aeac5-196d-4d03-bd2f-43e1b3c1a119"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("a690c398-7ffd-44ab-93ca-498d22e4c0c6"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("b011f5cc-dc7b-4c83-be6e-7d1827c96efb"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("c1f57589-1b6b-4336-80d1-3fb1fb727136"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("f10bf30b-d0f8-4cc0-b411-597b6ebf6b33"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("f6931fd9-2ed9-4c3e-97fa-08a613accf9d"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("f8e34e55-1ef3-4cc8-8eb9-bf33779ebf11"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("fd524a59-c2bf-4c0f-9f5e-4e5c1eab7272"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("12f3023b-ea01-405a-991a-8b8420d0f6e7"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("47601e84-5baf-48e1-b2eb-92c7fa3f5ac5"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("4d67afc8-47f0-40a7-b096-3499881da632"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("5360a760-2b91-4bc3-bfa3-c752f6ccd0b0"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("54186aba-ade3-4da3-a96b-8a77be9b59b3"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("5866f15d-fc62-4e4a-8d4a-a15cd8099a09"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("719747b1-56ec-4b61-b722-81e9bd9eb13c"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("865b823d-f94c-4f00-aeba-3e43294ebbc4"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("87d546d7-5bbd-4945-ab33-9ac5eee9034c"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("892896cf-b1e9-4adc-af6e-7767ed14962d"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("912d6e4f-9964-423c-bb93-d4b7e90a8660"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("94b258a4-6572-4e8c-9ef1-fa5466957be5"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("a12ec7b7-bded-4bb9-8aa7-b725677c3a55"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("be01acb6-a65a-438d-9e4d-f4de15eb8a4b"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("d48409fa-d9b1-4f76-927d-182f6ef425ba"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("f5cfdf2e-0725-4d29-a3c6-440b558cc2b8"));

            migrationBuilder.DeleteData(
                table: "maintenance_services",
                keyColumn: "id",
                keyValue: new Guid("01305132-39d8-454b-afba-727dda008a10"));

            migrationBuilder.DeleteData(
                table: "maintenance_services",
                keyColumn: "id",
                keyValue: new Guid("756e421b-47d9-4a97-8cdf-e996854a18c4"));

            migrationBuilder.DeleteData(
                table: "maintenance_services",
                keyColumn: "id",
                keyValue: new Guid("bdd540b1-b896-4451-8f2c-d2c511ede85d"));

            migrationBuilder.DeleteData(
                table: "maintenance_services",
                keyColumn: "id",
                keyValue: new Guid("fa7057fd-cb35-41c6-8260-aa0f03d6faa7"));

            migrationBuilder.InsertData(
                table: "brands",
                columns: new[] { "id", "brand_avatar", "deleted_at", "name" },
                values: new object[,]
                {
                    { new Guid("095236fd-6e55-4a5d-86a4-03f4a6a60721"), "public/default/brands/losan.png", null, "Losan" },
                    { new Guid("11879d80-99a3-4997-9d46-27a64ad34726"), "public/default/brands/zippy.png", null, "Zippy" },
                    { new Guid("5543362e-4982-4355-8a3f-9a91c2ce778f"), "public/default/brands/salsa.png", null, "Salsa" },
                    { new Guid("7c4c914a-ecb9-437d-a194-78e1a8418452"), "public/default/brands/mo.png", null, "MO" }
                });

            migrationBuilder.InsertData(
                table: "colors",
                columns: new[] { "id", "deleted_at", "hex", "name" },
                values: new object[,]
                {
                    { new Guid("008bd8b9-71a8-4dd7-999b-8abf04bdc3c4"), null, "FF4A2D16", "Castanho" },
                    { new Guid("22228017-2fbf-467c-8de8-553939e3a43f"), null, "FF29394A", "Azul Escuro" },
                    { new Guid("2a24f4ae-56c2-49f0-be23-e6db9f93fb6b"), null, "FF4C4C4C", "Cinzento Claro" },
                    { new Guid("2eb871b5-0c46-42dd-a29f-823cff0bcb43"), null, "FFFF6D6D", "Vermelho Claro" },
                    { new Guid("34d2c6fb-d196-46dd-b431-34a4aca841f4"), null, "FF98B3C8", "Azul Claro" },
                    { new Guid("35668905-d74e-46d2-ba0a-8af9b8183bce"), null, "FFD62598", "Roxo" },
                    { new Guid("3dce264d-6dbe-478a-b749-f8f95b516428"), null, "FF000000", "Black" },
                    { new Guid("43011b93-88c7-474a-8255-b5957df81a1c"), null, "FF509C75", "Verde" },
                    { new Guid("4e92785a-5d0e-446e-aef0-f0ad1c03d9fd"), null, "FFBE5967", "Rosa" },
                    { new Guid("64d00f10-4a84-4d2e-b8e3-bb248e6a3ef6"), null, "FF948066", "Castanho Claro" },
                    { new Guid("924b4e98-efc8-4745-9771-bb673a0886b3"), null, "FFDA252E", "Vermelho" },
                    { new Guid("98c20101-606f-4f1e-8ea6-6314de00aea3"), null, "FF8B5F3C", "Castanho Bebê" },
                    { new Guid("a2f22c7f-a16b-4d55-9c91-5cf1a8e95f08"), null, "FFFFFFFF", "White" },
                    { new Guid("a7f31f49-54be-420d-a083-1f18683da36c"), null, "FFF2E7D4", "Amarelo Bebê" },
                    { new Guid("b163e41f-e62e-4c1a-8a9f-27b3a38e0565"), null, "FFF58221", "Laranja" },
                    { new Guid("c501fd44-52f3-45a9-a037-14d892bbe69e"), null, "FFFFE69F", "Amarelo" },
                    { new Guid("c52f7152-1327-44d5-8f2c-f1ae30170552"), null, "FFC0C0C0", "Cinzento Bebê" },
                    { new Guid("cd0a4da0-a416-41d4-ae60-266dcd571fbb"), null, "FFD2AAC5", "Roxo Claro" },
                    { new Guid("cd6fcbde-7a63-4238-82d3-c9c5edd97eda"), null, "FFC3A572", "Amarelo Claro" },
                    { new Guid("f47738ee-f66a-490a-9bbc-2f0f586b7388"), null, "FFC2BC8B", "Verde Lima" },
                    { new Guid("fe69c355-868d-4438-9c16-fc7dc7a84c03"), null, "FFF9C7C4", "Rosa Claro" }
                });

            migrationBuilder.InsertData(
                table: "maintenance_services",
                columns: new[] { "id", "badge", "deleted_at", "description", "title" },
                values: new object[,]
                {
                    { new Guid("05d68c18-7fc2-4ae4-88f4-f26896bc1136"), "public/default/repair.png", null, "De que forma pretende arranjar a peça?", "Reparar" },
                    { new Guid("2fe22a88-372c-4dcb-af10-2c8c4373eb97"), "public/default/iron.png", null, "De que forma pretende engomar?", "Engomar" },
                    { new Guid("9de188bc-88ce-424f-bbc0-df22d39b0132"), "public/default/wash.png", null, "De que forma pretende lavar?", "Lavar" },
                    { new Guid("f6c34e93-6162-47e7-aaf0-8eb52e255c4d"), "public/default/dry.png", null, "De que forma pretende secar?", "Secar" }
                });

            migrationBuilder.InsertData(
                table: "maintenance_service_actions",
                columns: new[] { "id", "badge", "deleted_at", "Description", "eco_score", "maintenance_service_id", "sustainable_points", "title" },
                values: new object[,]
                {
                    { new Guid("080c528c-1027-4c45-b37e-4439a10c6693"), "public/default/dry/air.png", null, "Secar ao ar livre", 0, new Guid("f6c34e93-6162-47e7-aaf0-8eb52e255c4d"), 2, "Ao ar livre" },
                    { new Guid("15a4e75a-65f8-43b6-b7bc-6340aa805779"), "public/default/wash/less50.png", null, "Lavar a menos de 50ºC", -2, new Guid("9de188bc-88ce-424f-bbc0-df22d39b0132"), 1, "A menos de 50ºC" },
                    { new Guid("30c7b3f5-b1ec-4378-bccc-8f953cbdf8b1"), "public/default/service.png", null, "Escolhe um serviço de Reparação", 10, new Guid("05d68c18-7fc2-4ae4-88f4-f26896bc1136"), 100, "Serviço de Reparação" },
                    { new Guid("37bdfc4b-5239-4d8d-97e4-b32bf5353cba"), "public/default/wash/hand.png", null, "Lavar à mão com água e sabão", 10, new Guid("9de188bc-88ce-424f-bbc0-df22d39b0132"), 100, "Lavar à mão" },
                    { new Guid("3bdbbc0e-4858-489d-b745-5d64ef58d7ab"), "public/default/wash/less95.png", null, "Lavar a menos de 95ºC", -2, new Guid("9de188bc-88ce-424f-bbc0-df22d39b0132"), 1, "A menos de 95ºC" },
                    { new Guid("489ee762-57bb-4f35-bdfd-9877ac926c8e"), "public/default/iron/less150.png", null, "Engomar a menos de 150ºC", -1, new Guid("2fe22a88-372c-4dcb-af10-2c8c4373eb97"), 1, "A menos de 150ºC" },
                    { new Guid("4b327cea-441a-4bfe-9430-4da53f423f15"), "public/default/service.png", null, "Escolhe um serviço de engomadoria", 10, new Guid("2fe22a88-372c-4dcb-af10-2c8c4373eb97"), 100, "Serviço de Engomadoria" },
                    { new Guid("62c16c1e-8fa6-44d3-b81a-3dc65fc1bba0"), "public/default/service.png", null, "Escolhe uma lavandaria", 10, new Guid("9de188bc-88ce-424f-bbc0-df22d39b0132"), 100, "Serviço de lavandaria" },
                    { new Guid("6c1a50a3-c2a7-45af-b1d6-f38b102c5e58"), "public/default/wash/dry.png", null, "Lavar a seco", -3, new Guid("9de188bc-88ce-424f-bbc0-df22d39b0132"), 0, "A seco" },
                    { new Guid("6dd490ef-89dc-4659-8411-1ffbb75e56cf"), "public/default/service.png", null, "Escolhe um serviço de secagem", 10, new Guid("f6c34e93-6162-47e7-aaf0-8eb52e255c4d"), 100, "Serviço de Secagem" },
                    { new Guid("7747ed77-93d5-44b2-b3aa-4ea6ffaa6a33"), "public/default/wash/less70.png", null, "Lavar a menos de 70ºC", -2, new Guid("9de188bc-88ce-424f-bbc0-df22d39b0132"), 1, "A menos de 70ºC" },
                    { new Guid("b32af17b-43d5-4030-8ca5-fde8a1f68903"), "public/default/wash/less30.png", null, "Lavar a menos de 30ºC", -1, new Guid("9de188bc-88ce-424f-bbc0-df22d39b0132"), 2, "A menos de 30ºC" },
                    { new Guid("d187afe4-b7e3-46d3-8646-1d92264210c8"), "public/default/dry/machine.png", null, "Secar na máquina", -1, new Guid("f6c34e93-6162-47e7-aaf0-8eb52e255c4d"), 1, "Na máquina" },
                    { new Guid("d8d6c354-cc08-4ae0-b04c-ed65d60e581b"), "public/default/repair.png", null, "Arranjar a peça pelo próprio", 2, new Guid("05d68c18-7fc2-4ae4-88f4-f26896bc1136"), 3, "Pelo Próprio" },
                    { new Guid("da4fcd6d-cb60-4891-a80f-7440f1816a93"), "public/default/iron/less110.png", null, "Engomar a menos de 110ºC", -1, new Guid("2fe22a88-372c-4dcb-af10-2c8c4373eb97"), 1, "A menos de 110ºC" },
                    { new Guid("ff3423f6-4fed-416f-9b34-ef1fa6189503"), "public/default/iron/less200.png", null, "Engomar a menos de 200ºC", -1, new Guid("2fe22a88-372c-4dcb-af10-2c8c4373eb97"), 1, "A menos de 200ºC" }
                });
        }
    }
}
