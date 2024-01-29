using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BeatEcoprove.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddBrandImages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "brands",
                columns: new[] { "id", "brand_avatar", "deleted_at", "name" },
                values: new object[,]
                {
                    { new Guid("417b5e82-f8e2-42e0-83da-78f7b8ae79a5"), "public/brands/mo.png", null, "MO" },
                    { new Guid("9a787839-53f7-4b01-b996-e19053d1dbd0"), "public/brands/losan.png", null, "Losan" },
                    { new Guid("a5e47d6b-1045-4c6a-80be-298b9a5f429f"), "public/brands/salsa.png", null, "Salsa" },
                    { new Guid("b249227a-1dc4-4a28-9e2f-88cceefbdf6d"), "public/brands/zippy.png", null, "Zippy" }
                });

            migrationBuilder.InsertData(
                table: "colors",
                columns: new[] { "id", "deleted_at", "hex", "name" },
                values: new object[,]
                {
                    { new Guid("04eb5dfb-fa6d-470a-9ff5-b9ce8ea12e32"), null, "FFC2BC8B", "Verde Lima" },
                    { new Guid("105e5293-95d3-42d0-974a-42d3899aecc7"), null, "FF000000", "Black" },
                    { new Guid("25ad5968-afea-44e8-9a34-79a4cc0e0586"), null, "FFFF6D6D", "Vermelho Claro" },
                    { new Guid("33982e56-e191-4417-a70e-c67898dd6e4d"), null, "FF948066", "Castanho Claro" },
                    { new Guid("378dfa0e-25df-4a4b-b79d-40a8e104ebdc"), null, "FFFFE69F", "Amarelo" },
                    { new Guid("3fc044d2-a1dc-48d1-aa37-b961b5bcf7fc"), null, "FF29394A", "Azul Escuro" },
                    { new Guid("46425be0-26ef-43c2-ac0d-82f5f57840c4"), null, "FF98B3C8", "Azul Claro" },
                    { new Guid("5641945a-2902-4033-9c10-0f6e03350a1d"), null, "FF509C75", "Verde" },
                    { new Guid("5d1c3dc1-bccc-468d-8b8e-56d4d7e807a7"), null, "FF4A2D16", "Castanho" },
                    { new Guid("77cc4e68-4b70-477b-be74-a263f59dfa79"), null, "FFF2E7D4", "Amarelo Bebê" },
                    { new Guid("77f8fa02-6bfe-4b41-9a50-da42907bbde3"), null, "FFD2AAC5", "Roxo Claro" },
                    { new Guid("796910c5-e467-4bd2-81b4-b5be30717449"), null, "FFBE5967", "Rosa" },
                    { new Guid("7bcc7d2b-f607-4d7a-94f6-0c190d1d19ca"), null, "FFF58221", "Laranja" },
                    { new Guid("8091b3c5-7144-4764-b383-34f3926b7d74"), null, "FFDA252E", "Vermelho" },
                    { new Guid("87d58f3c-cd8a-4399-a74f-2b08a15d1e35"), null, "FFC3A572", "Amarelo Claro" },
                    { new Guid("9472eb71-7e02-47f3-a18b-368f445c59cc"), null, "FFD62598", "Roxo" },
                    { new Guid("9c0f0ec3-8495-4d9d-be91-77cb08d67415"), null, "FFC0C0C0", "Cinzento Bebê" },
                    { new Guid("b02bc5ba-10eb-4fad-8596-342f8fcb1e68"), null, "FF8B5F3C", "Castanho Bebê" },
                    { new Guid("b6ff1842-2c22-4c1f-b22a-d727c30674e1"), null, "FFF9C7C4", "Rosa Claro" },
                    { new Guid("e82ba23a-c9ca-43b0-ab2f-e5c2fa5652f9"), null, "FF4C4C4C", "Cinzento Claro" },
                    { new Guid("f3495399-7f2a-4c0d-959b-51f7e40fe9cc"), null, "FFFFFFFF", "White" }
                });

            migrationBuilder.InsertData(
                table: "maintenance_services",
                columns: new[] { "id", "badge", "deleted_at", "description", "title" },
                values: new object[,]
                {
                    { new Guid("6da2608f-a37f-4bf8-b9c6-fadc3cd527ce"), "public/default/repair.png", null, "De que forma pertende arranjar a peça?", "Engomar" },
                    { new Guid("763367b1-063c-4fa9-b72b-54ff59e7e77f"), "public/default/wash.png", null, "De que forma pertende lavar?", "Lavar" },
                    { new Guid("8c6984c3-5bb1-4178-8b13-0efe2b81f1aa"), "public/default/iron.png", null, "De que forma pertende engomar?", "Engomar" },
                    { new Guid("ee1ac1b6-d71d-415a-a070-c1d493614c1f"), "public/default/dry.png", null, "De que forma pertende secar?", "Secar" }
                });

            migrationBuilder.InsertData(
                table: "maintenance_service_actions",
                columns: new[] { "id", "badge", "deleted_at", "Description", "eco_score", "maintenance_service_id", "sustainable_points", "title" },
                values: new object[,]
                {
                    { new Guid("22cae5e4-0cd9-462d-a40b-9806aa148aba"), "public/default/iron/less150.png", null, "Engomar a menos de 150ºC", 10, new Guid("8c6984c3-5bb1-4178-8b13-0efe2b81f1aa"), 100, "A menos de 150ºC" },
                    { new Guid("3bf5f219-24a5-4b92-9869-76d7cff4cb1c"), "public/default/wash/less70.png", null, "Lavar a menos de 70ºC", 10, new Guid("763367b1-063c-4fa9-b72b-54ff59e7e77f"), 100, "A menos de 70ºC" },
                    { new Guid("4b4a6231-12b3-48ad-a446-e029b97986ce"), "public/default/repair.png", null, "Arranjar a peça pelo próprio", 10, new Guid("6da2608f-a37f-4bf8-b9c6-fadc3cd527ce"), 100, "Pelo Próprio" },
                    { new Guid("4c887696-7c0f-43cf-9c44-5fa89d3c81cd"), "public/default/dry/air.png", null, "Secar ao ar livre", 10, new Guid("ee1ac1b6-d71d-415a-a070-c1d493614c1f"), 100, "Ao ar livre" },
                    { new Guid("5bd16e14-035a-4473-ab97-b61760d64617"), "public/default/wash/less95.png", null, "Lavar a menos de 95ºC", 10, new Guid("763367b1-063c-4fa9-b72b-54ff59e7e77f"), 100, "A menos de 95ºC" },
                    { new Guid("5dd0591e-a8d6-4946-bc89-b1c528e04c98"), "public/default/service.png", null, "Escolhe um serviço de secagem", 10, new Guid("ee1ac1b6-d71d-415a-a070-c1d493614c1f"), 100, "Serviço de Secagem" },
                    { new Guid("6d01099a-775a-4559-8240-0165213c9347"), "public/default/service.png", null, "Escolhe um serviço de engomadoria", 10, new Guid("8c6984c3-5bb1-4178-8b13-0efe2b81f1aa"), 100, "Serviço de Engomadoria" },
                    { new Guid("705d1c9e-481d-4f11-9b51-df5413ad780e"), "public/default/dry/machine.png", null, "Secar na máquina", 10, new Guid("ee1ac1b6-d71d-415a-a070-c1d493614c1f"), 100, "Na máquina" },
                    { new Guid("72a7437a-c9d4-4123-aa26-db969af45879"), "public/default/wash/less50.png", null, "Lavar a menos de 50ºC", 10, new Guid("763367b1-063c-4fa9-b72b-54ff59e7e77f"), 100, "A menos de 50ºC" },
                    { new Guid("815bc68f-ca9d-4fc6-8ce2-cb70b4c1db99"), "public/default/service.png", null, "Escolhe uma lavandaria", 10, new Guid("763367b1-063c-4fa9-b72b-54ff59e7e77f"), 100, "Serviço de lavandaria" },
                    { new Guid("883f9804-bee3-40ee-8473-ec39f6615296"), "public/default/iron/less200.png", null, "Engomar a menos de 200ºC", 10, new Guid("8c6984c3-5bb1-4178-8b13-0efe2b81f1aa"), 100, "A menos de 200ºC" },
                    { new Guid("a3b83217-2df1-4a54-9b2c-75988c7bb071"), "public/default/service.png", null, "Escolhe um serviço de Reparação", 10, new Guid("6da2608f-a37f-4bf8-b9c6-fadc3cd527ce"), 100, "Serviço de Reparação" },
                    { new Guid("c36ac5ad-8490-4ac6-8196-8dbfdf3fd4a7"), "public/default/wash/less30.png", null, "Lavar a menos de 30ºC", 10, new Guid("763367b1-063c-4fa9-b72b-54ff59e7e77f"), 100, "A menos de 30ºC" },
                    { new Guid("c6fe4558-bfac-4a8e-a176-bb622c0cc528"), "public/default/wash/dry.png", null, "Lavar a seco", 10, new Guid("763367b1-063c-4fa9-b72b-54ff59e7e77f"), 100, "A seco" },
                    { new Guid("e1733d25-27b8-47ce-9ce4-a8d79f7d7d9b"), "public/default/wash/hand.png", null, "Lavar à mão com água e sabão", 10, new Guid("763367b1-063c-4fa9-b72b-54ff59e7e77f"), 100, "Lavar à mão" },
                    { new Guid("fb7df132-ccea-4ed2-bec8-1a1b1bab2ffd"), "public/default/iron/less110.png", null, "Engomar a menos de 110ºC", 10, new Guid("8c6984c3-5bb1-4178-8b13-0efe2b81f1aa"), 100, "A menos de 110ºC" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: new Guid("417b5e82-f8e2-42e0-83da-78f7b8ae79a5"));

            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: new Guid("9a787839-53f7-4b01-b996-e19053d1dbd0"));

            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: new Guid("a5e47d6b-1045-4c6a-80be-298b9a5f429f"));

            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: new Guid("b249227a-1dc4-4a28-9e2f-88cceefbdf6d"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("04eb5dfb-fa6d-470a-9ff5-b9ce8ea12e32"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("105e5293-95d3-42d0-974a-42d3899aecc7"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("25ad5968-afea-44e8-9a34-79a4cc0e0586"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("33982e56-e191-4417-a70e-c67898dd6e4d"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("378dfa0e-25df-4a4b-b79d-40a8e104ebdc"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("3fc044d2-a1dc-48d1-aa37-b961b5bcf7fc"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("46425be0-26ef-43c2-ac0d-82f5f57840c4"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("5641945a-2902-4033-9c10-0f6e03350a1d"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("5d1c3dc1-bccc-468d-8b8e-56d4d7e807a7"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("77cc4e68-4b70-477b-be74-a263f59dfa79"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("77f8fa02-6bfe-4b41-9a50-da42907bbde3"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("796910c5-e467-4bd2-81b4-b5be30717449"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("7bcc7d2b-f607-4d7a-94f6-0c190d1d19ca"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("8091b3c5-7144-4764-b383-34f3926b7d74"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("87d58f3c-cd8a-4399-a74f-2b08a15d1e35"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("9472eb71-7e02-47f3-a18b-368f445c59cc"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("9c0f0ec3-8495-4d9d-be91-77cb08d67415"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("b02bc5ba-10eb-4fad-8596-342f8fcb1e68"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("b6ff1842-2c22-4c1f-b22a-d727c30674e1"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("e82ba23a-c9ca-43b0-ab2f-e5c2fa5652f9"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("f3495399-7f2a-4c0d-959b-51f7e40fe9cc"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("22cae5e4-0cd9-462d-a40b-9806aa148aba"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("3bf5f219-24a5-4b92-9869-76d7cff4cb1c"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("4b4a6231-12b3-48ad-a446-e029b97986ce"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("4c887696-7c0f-43cf-9c44-5fa89d3c81cd"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("5bd16e14-035a-4473-ab97-b61760d64617"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("5dd0591e-a8d6-4946-bc89-b1c528e04c98"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("6d01099a-775a-4559-8240-0165213c9347"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("705d1c9e-481d-4f11-9b51-df5413ad780e"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("72a7437a-c9d4-4123-aa26-db969af45879"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("815bc68f-ca9d-4fc6-8ce2-cb70b4c1db99"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("883f9804-bee3-40ee-8473-ec39f6615296"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("a3b83217-2df1-4a54-9b2c-75988c7bb071"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("c36ac5ad-8490-4ac6-8196-8dbfdf3fd4a7"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("c6fe4558-bfac-4a8e-a176-bb622c0cc528"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("e1733d25-27b8-47ce-9ce4-a8d79f7d7d9b"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("fb7df132-ccea-4ed2-bec8-1a1b1bab2ffd"));

            migrationBuilder.DeleteData(
                table: "maintenance_services",
                keyColumn: "id",
                keyValue: new Guid("6da2608f-a37f-4bf8-b9c6-fadc3cd527ce"));

            migrationBuilder.DeleteData(
                table: "maintenance_services",
                keyColumn: "id",
                keyValue: new Guid("763367b1-063c-4fa9-b72b-54ff59e7e77f"));

            migrationBuilder.DeleteData(
                table: "maintenance_services",
                keyColumn: "id",
                keyValue: new Guid("8c6984c3-5bb1-4178-8b13-0efe2b81f1aa"));

            migrationBuilder.DeleteData(
                table: "maintenance_services",
                keyColumn: "id",
                keyValue: new Guid("ee1ac1b6-d71d-415a-a070-c1d493614c1f"));

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
                    { new Guid("89632620-3f8f-476c-a977-796f50696c8d"), "public/default/repair.png", null, "De que forma pertende arranjar a peça?", "Engomar" }
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
        }
    }
}
