using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BeatEcoprove.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpgradeDefaultColors : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: new Guid("7f386d60-27b9-4c0d-b13b-c01ba2729693"));

            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: new Guid("b32b05ac-1531-4d8c-b6b9-f0b554ab557b"));

            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: new Guid("dc7fba3d-231b-4ef8-931f-c93c82a95365"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("1fa130a8-0514-4dcf-b4f6-3255ff3d033b"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("278fee68-f717-4b1e-b693-65dd5eb3b7d2"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("82be98b3-e3e6-49f9-9748-83ca3ffe3379"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("b6fbda96-110a-4287-9b2a-153e2855865e"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("d2111157-54e8-4ee2-a3be-373a93451793"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("0b98243f-f4ec-4ec4-9126-56c59a6b804d"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("2981afd0-c8aa-4926-8bda-bf71eb21892c"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("3460d900-15ef-471a-9a06-f45a8086195e"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("3ebad7bb-2b9b-452d-8a1d-fba0ad195a2e"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("472a0b25-5b5a-4bf1-b5da-96c7d0d675b8"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("5116d81b-2c83-427e-bcef-8c70c6f33668"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("5af4f66a-a8e2-457d-a9d7-79d84cf1c909"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("7f15774a-6a78-425e-bf94-60acf1258e74"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("87ddae47-fd57-45a3-85e1-d15f125765b0"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("8eed3bef-0fd6-4c88-ac8c-078ef81ba4e4"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("a11a1abc-1ec4-4587-8c35-07a93371cd0a"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("a3898f19-4de1-414f-991f-357ce0000fac"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("b33c19da-363f-46c5-9353-71540f65b8f3"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("b525aa7a-8999-4480-8a03-d10e6b27a3a0"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("e64f1fc9-f2d4-4492-b548-3c163a1257dc"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("f2802726-d963-409e-a9ed-caed80a4637c"));

            migrationBuilder.DeleteData(
                table: "maintenance_services",
                keyColumn: "id",
                keyValue: new Guid("3ce29e6e-89a5-4700-8b09-2de656b13103"));

            migrationBuilder.DeleteData(
                table: "maintenance_services",
                keyColumn: "id",
                keyValue: new Guid("973dadb9-b07a-46c2-91cc-55389686f2f2"));

            migrationBuilder.DeleteData(
                table: "maintenance_services",
                keyColumn: "id",
                keyValue: new Guid("aa883287-24ee-42e9-b1cb-3122e99f4d8a"));

            migrationBuilder.DeleteData(
                table: "maintenance_services",
                keyColumn: "id",
                keyValue: new Guid("b6a455d6-593c-4941-969d-13d21705b92f"));

            migrationBuilder.AlterColumn<string>(
                name: "hex",
                table: "colors",
                type: "character varying(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(8)",
                oldMaxLength: 8);

            migrationBuilder.InsertData(
                table: "brands",
                columns: new[] { "id", "brand_avatar", "deleted_at", "name" },
                values: new object[,]
                {
                    { new Guid("6ad7e93f-7ea3-456c-bd89-1b8a0dc0bbd3"), "...", null, "Tifosi" },
                    { new Guid("c1ff09d0-6bf1-45a9-83cf-77c717e796c6"), "...", null, "MO" },
                    { new Guid("d994952a-cb26-4eee-a54d-f7b0306561a7"), "...", null, "Salsa" }
                });

            migrationBuilder.InsertData(
                table: "colors",
                columns: new[] { "id", "deleted_at", "hex", "name" },
                values: new object[,]
                {
                    { new Guid("08824efc-8b28-4c9f-a968-a837972e201c"), null, "FF29394A", "Azul Escuro" },
                    { new Guid("1496ef74-1693-4ea2-9489-5ba07fdc7529"), null, "FFC2BC8B", "Verde Lima" },
                    { new Guid("3922fc75-ede4-446f-a4ae-db00f7271fb9"), null, "FF509C75", "Verde" },
                    { new Guid("41d86caa-0310-4476-acbb-2f11521ee173"), null, "FF4C4C4C", "Cinzento Claro" },
                    { new Guid("492665d6-9f00-44be-a787-82f9e4d6c82f"), null, "FF98B3C8", "Azul Claro" },
                    { new Guid("4ac5d271-e1b4-40e9-8e8d-65b3505719ff"), null, "FFC0C0C0", "Cinzento Bebê" },
                    { new Guid("53ad2b6e-be0b-4900-92d8-9a3b6f6ec000"), null, "FFF9C7C4", "Rosa Claro" },
                    { new Guid("56766df7-05a5-4b84-b2e0-d9c61cb4002b"), null, "FFFFE69F", "Amarelo" },
                    { new Guid("57a2cb42-f24c-4c24-8e9e-19e4161c0583"), null, "FFD62598", "Roxo" },
                    { new Guid("5b2a37f1-ecee-4235-9ad5-612cc158bfe7"), null, "FF4A2D16", "Castanho" },
                    { new Guid("63831e89-41fe-4da8-b0be-8bd82654fd4c"), null, "FFBE5967", "Rosa" },
                    { new Guid("661af01d-5c35-460b-8c8f-59c6d3d4ee59"), null, "FFDA252E", "Vermelho" },
                    { new Guid("718fab40-796d-4e36-8d6e-2a29afd8eabb"), null, "FFF2E7D4", "Amarelo Bebê" },
                    { new Guid("88f170b3-40dd-4cda-bebd-ff2c7107b96a"), null, "FFC3A572", "Amarelo Claro" },
                    { new Guid("9313b0a8-ed2f-4522-9ee9-73be4484e941"), null, "FF8B5F3C", "Castanho Bebê" },
                    { new Guid("a420bb7a-d021-4727-8d1d-63e1941efc38"), null, "FFD2AAC5", "Roxo Claro" },
                    { new Guid("ae1a50eb-d4af-41db-b205-86f5f825a9ce"), null, "FFF58221", "Laranja" },
                    { new Guid("b0a80794-75e9-45b9-9665-3bf5e39b944a"), null, "FFFF6D6D", "Vermelho Claro" },
                    { new Guid("bbc99374-e207-4d63-98dd-e481c2bd54a0"), null, "FF000000", "Preto" },
                    { new Guid("d63341a2-6322-49d1-9477-aff90e0c13ad"), null, "FFFFFFFF", "White" },
                    { new Guid("ef27693c-b9bf-4536-bf4f-447c88c5c2b5"), null, "FF948066", "Castanho Claro" },
                    { new Guid("fb28fbe7-f227-427f-872f-29b5ecec7715"), null, "FF000000", "Black" }
                });

            migrationBuilder.InsertData(
                table: "maintenance_services",
                columns: new[] { "id", "badge", "deleted_at", "description", "title" },
                values: new object[,]
                {
                    { new Guid("477a1fc5-de28-43f5-9206-e8e1ed754f32"), "public/default/dry.png", null, "De que forma pertende secar?", "Secar" },
                    { new Guid("5ba116b4-8745-4fec-8703-cd887f8bda94"), "public/default/iron.png", null, "De que forma pertende engomar?", "Engomar" },
                    { new Guid("b2c0074a-7b1c-4646-ae06-af2c6f8faba3"), "public/default/repair.png", null, "De que forma pertende arranjar a peça?", "Engomar" },
                    { new Guid("ba23272f-c136-40ce-a941-f3b924170cd6"), "public/default/wash.png", null, "De que forma pertende lavar?", "Lavar" }
                });

            migrationBuilder.InsertData(
                table: "maintenance_service_actions",
                columns: new[] { "id", "badge", "deleted_at", "Description", "eco_score", "maintenance_service_id", "sustainable_points", "title" },
                values: new object[,]
                {
                    { new Guid("00c42d18-d815-4920-ad25-4b7de9226c56"), "public/default/wash/hand.png", null, "Lavar à mão com água e sabão", 10, new Guid("ba23272f-c136-40ce-a941-f3b924170cd6"), 100, "Lavar à mão" },
                    { new Guid("0d6c0c43-5e0c-4931-bcab-ab1bc0820f92"), "public/default/wash/less50.png", null, "Lavar a menos de 50ºC", 10, new Guid("ba23272f-c136-40ce-a941-f3b924170cd6"), 100, "A menos de 50ºC" },
                    { new Guid("1a021f97-aed6-4d29-af98-c0d3ac5e8d2d"), "public/default/service.png", null, "Escolhe um serviço de engomadoria", 10, new Guid("5ba116b4-8745-4fec-8703-cd887f8bda94"), 100, "Serviço de Engomadoria" },
                    { new Guid("1ccf9e3e-b12e-4419-a45f-4ce27a3085c9"), "public/default/repair.png", null, "Arranjar a peça pelo próprio", 10, new Guid("b2c0074a-7b1c-4646-ae06-af2c6f8faba3"), 100, "Pelo Próprio" },
                    { new Guid("1de8b5d4-f158-44b7-9dc7-ead2da7f520d"), "public/default/iron/less110.png", null, "Engomar a menos de 110ºC", 10, new Guid("5ba116b4-8745-4fec-8703-cd887f8bda94"), 100, "A menos de 110ºC" },
                    { new Guid("1fc31dc2-1f67-47b7-a126-624b72cb3ded"), "public/default/dry/air.png", null, "Secar ao ar livre", 10, new Guid("477a1fc5-de28-43f5-9206-e8e1ed754f32"), 100, "Ao ar livre" },
                    { new Guid("59f9aa2b-e799-40ea-975b-c6f378c93993"), "public/default/wash/less70.png", null, "Lavar a menos de 70ºC", 10, new Guid("ba23272f-c136-40ce-a941-f3b924170cd6"), 100, "A menos de 70ºC" },
                    { new Guid("87c91f1c-8a86-4f82-a744-bc43cfc44c19"), "public/default/service.png", null, "Escolhe um serviço de Reparação", 10, new Guid("b2c0074a-7b1c-4646-ae06-af2c6f8faba3"), 100, "Serviço de Reparação" },
                    { new Guid("8a9b8b99-8fa5-4158-a239-927c3bdfba27"), "public/default/service.png", null, "Escolhe um serviço de secagem", 10, new Guid("477a1fc5-de28-43f5-9206-e8e1ed754f32"), 100, "Serviço de Secagem" },
                    { new Guid("8aa7231f-6e7f-4660-aa1d-06e55b75535c"), "public/default/service.png", null, "Escolhe uma lavandaria", 10, new Guid("ba23272f-c136-40ce-a941-f3b924170cd6"), 100, "Serviço de lavandaria" },
                    { new Guid("945e5b91-b9ff-4d84-9499-bef56b8a56c7"), "public/default/iron/less200.png", null, "Engomar a menos de 200ºC", 10, new Guid("5ba116b4-8745-4fec-8703-cd887f8bda94"), 100, "A menos de 200ºC" },
                    { new Guid("b5847d9e-09cc-4303-9558-26a72b818cf1"), "public/default/iron/less150.png", null, "Engomar a menos de 150ºC", 10, new Guid("5ba116b4-8745-4fec-8703-cd887f8bda94"), 100, "A menos de 150ºC" },
                    { new Guid("d49b732d-153f-462d-9cdf-2ea17436c1a1"), "public/default/wash/less30.png", null, "Lavar a menos de 30ºC", 10, new Guid("ba23272f-c136-40ce-a941-f3b924170cd6"), 100, "A menos de 30ºC" },
                    { new Guid("d98eef09-c5cd-4a37-ad23-9200eff7228b"), "public/default/dry/machine.png", null, "Secar na máquina", 10, new Guid("477a1fc5-de28-43f5-9206-e8e1ed754f32"), 100, "Na máquina" },
                    { new Guid("e140a577-8df8-4c98-81e3-8ad541e81b62"), "public/default/wash/less95.png", null, "Lavar a menos de 95ºC", 10, new Guid("ba23272f-c136-40ce-a941-f3b924170cd6"), 100, "A menos de 95ºC" },
                    { new Guid("faf2903a-3343-4959-9e31-598695fc3c02"), "public/default/wash/dry.png", null, "Lavar a seco", 10, new Guid("ba23272f-c136-40ce-a941-f3b924170cd6"), 100, "A seco" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: new Guid("6ad7e93f-7ea3-456c-bd89-1b8a0dc0bbd3"));

            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: new Guid("c1ff09d0-6bf1-45a9-83cf-77c717e796c6"));

            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: new Guid("d994952a-cb26-4eee-a54d-f7b0306561a7"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("08824efc-8b28-4c9f-a968-a837972e201c"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("1496ef74-1693-4ea2-9489-5ba07fdc7529"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("3922fc75-ede4-446f-a4ae-db00f7271fb9"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("41d86caa-0310-4476-acbb-2f11521ee173"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("492665d6-9f00-44be-a787-82f9e4d6c82f"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("4ac5d271-e1b4-40e9-8e8d-65b3505719ff"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("53ad2b6e-be0b-4900-92d8-9a3b6f6ec000"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("56766df7-05a5-4b84-b2e0-d9c61cb4002b"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("57a2cb42-f24c-4c24-8e9e-19e4161c0583"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("5b2a37f1-ecee-4235-9ad5-612cc158bfe7"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("63831e89-41fe-4da8-b0be-8bd82654fd4c"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("661af01d-5c35-460b-8c8f-59c6d3d4ee59"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("718fab40-796d-4e36-8d6e-2a29afd8eabb"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("88f170b3-40dd-4cda-bebd-ff2c7107b96a"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("9313b0a8-ed2f-4522-9ee9-73be4484e941"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("a420bb7a-d021-4727-8d1d-63e1941efc38"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("ae1a50eb-d4af-41db-b205-86f5f825a9ce"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("b0a80794-75e9-45b9-9665-3bf5e39b944a"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("bbc99374-e207-4d63-98dd-e481c2bd54a0"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("d63341a2-6322-49d1-9477-aff90e0c13ad"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("ef27693c-b9bf-4536-bf4f-447c88c5c2b5"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("fb28fbe7-f227-427f-872f-29b5ecec7715"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("00c42d18-d815-4920-ad25-4b7de9226c56"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("0d6c0c43-5e0c-4931-bcab-ab1bc0820f92"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("1a021f97-aed6-4d29-af98-c0d3ac5e8d2d"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("1ccf9e3e-b12e-4419-a45f-4ce27a3085c9"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("1de8b5d4-f158-44b7-9dc7-ead2da7f520d"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("1fc31dc2-1f67-47b7-a126-624b72cb3ded"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("59f9aa2b-e799-40ea-975b-c6f378c93993"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("87c91f1c-8a86-4f82-a744-bc43cfc44c19"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("8a9b8b99-8fa5-4158-a239-927c3bdfba27"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("8aa7231f-6e7f-4660-aa1d-06e55b75535c"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("945e5b91-b9ff-4d84-9499-bef56b8a56c7"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("b5847d9e-09cc-4303-9558-26a72b818cf1"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("d49b732d-153f-462d-9cdf-2ea17436c1a1"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("d98eef09-c5cd-4a37-ad23-9200eff7228b"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("e140a577-8df8-4c98-81e3-8ad541e81b62"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("faf2903a-3343-4959-9e31-598695fc3c02"));

            migrationBuilder.DeleteData(
                table: "maintenance_services",
                keyColumn: "id",
                keyValue: new Guid("477a1fc5-de28-43f5-9206-e8e1ed754f32"));

            migrationBuilder.DeleteData(
                table: "maintenance_services",
                keyColumn: "id",
                keyValue: new Guid("5ba116b4-8745-4fec-8703-cd887f8bda94"));

            migrationBuilder.DeleteData(
                table: "maintenance_services",
                keyColumn: "id",
                keyValue: new Guid("b2c0074a-7b1c-4646-ae06-af2c6f8faba3"));

            migrationBuilder.DeleteData(
                table: "maintenance_services",
                keyColumn: "id",
                keyValue: new Guid("ba23272f-c136-40ce-a941-f3b924170cd6"));

            migrationBuilder.AlterColumn<string>(
                name: "hex",
                table: "colors",
                type: "character varying(8)",
                maxLength: 8,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(10)",
                oldMaxLength: 10);

            migrationBuilder.InsertData(
                table: "brands",
                columns: new[] { "id", "brand_avatar", "deleted_at", "name" },
                values: new object[,]
                {
                    { new Guid("7f386d60-27b9-4c0d-b13b-c01ba2729693"), "...", null, "Salsa" },
                    { new Guid("b32b05ac-1531-4d8c-b6b9-f0b554ab557b"), "...", null, "Tifosi" },
                    { new Guid("dc7fba3d-231b-4ef8-931f-c93c82a95365"), "...", null, "MO" }
                });

            migrationBuilder.InsertData(
                table: "colors",
                columns: new[] { "id", "deleted_at", "hex", "name" },
                values: new object[,]
                {
                    { new Guid("1fa130a8-0514-4dcf-b4f6-3255ff3d033b"), null, "FFFF0000", "Red" },
                    { new Guid("278fee68-f717-4b1e-b693-65dd5eb3b7d2"), null, "FFFFFFFF", "White" },
                    { new Guid("82be98b3-e3e6-49f9-9748-83ca3ffe3379"), null, "FF0000FF", "Blue" },
                    { new Guid("b6fbda96-110a-4287-9b2a-153e2855865e"), null, "FF00FF00", "Green" },
                    { new Guid("d2111157-54e8-4ee2-a3be-373a93451793"), null, "FF000000", "Black" }
                });

            migrationBuilder.InsertData(
                table: "maintenance_services",
                columns: new[] { "id", "badge", "deleted_at", "description", "title" },
                values: new object[,]
                {
                    { new Guid("3ce29e6e-89a5-4700-8b09-2de656b13103"), "public/default/wash.png", null, "De que forma pertende lavar?", "Lavar" },
                    { new Guid("973dadb9-b07a-46c2-91cc-55389686f2f2"), "public/default/iron.png", null, "De que forma pertende engomar?", "Engomar" },
                    { new Guid("aa883287-24ee-42e9-b1cb-3122e99f4d8a"), "public/default/repair.png", null, "De que forma pertende arranjar a peça?", "Engomar" },
                    { new Guid("b6a455d6-593c-4941-969d-13d21705b92f"), "public/default/dry.png", null, "De que forma pertende secar?", "Secar" }
                });

            migrationBuilder.InsertData(
                table: "maintenance_service_actions",
                columns: new[] { "id", "badge", "deleted_at", "Description", "eco_score", "maintenance_service_id", "sustainable_points", "title" },
                values: new object[,]
                {
                    { new Guid("0b98243f-f4ec-4ec4-9126-56c59a6b804d"), "public/default/wash/less50.png", null, "Lavar a menos de 50ºC", 10, new Guid("3ce29e6e-89a5-4700-8b09-2de656b13103"), 100, "A menos de 50ºC" },
                    { new Guid("2981afd0-c8aa-4926-8bda-bf71eb21892c"), "public/default/iron/less110.png", null, "Engomar a menos de 110ºC", 10, new Guid("973dadb9-b07a-46c2-91cc-55389686f2f2"), 100, "A menos de 110ºC" },
                    { new Guid("3460d900-15ef-471a-9a06-f45a8086195e"), "public/default/dry/air.png", null, "Secar ao ar livre", 10, new Guid("b6a455d6-593c-4941-969d-13d21705b92f"), 100, "Ao ar livre" },
                    { new Guid("3ebad7bb-2b9b-452d-8a1d-fba0ad195a2e"), "public/default/service.png", null, "Escolhe uma lavandaria", 10, new Guid("3ce29e6e-89a5-4700-8b09-2de656b13103"), 100, "Serviço de lavandaria" },
                    { new Guid("472a0b25-5b5a-4bf1-b5da-96c7d0d675b8"), "public/default/wash/hand.png", null, "Lavar à mão com água e sabão", 10, new Guid("3ce29e6e-89a5-4700-8b09-2de656b13103"), 100, "Lavar à mão" },
                    { new Guid("5116d81b-2c83-427e-bcef-8c70c6f33668"), "public/default/wash/dry.png", null, "Lavar a seco", 10, new Guid("3ce29e6e-89a5-4700-8b09-2de656b13103"), 100, "A seco" },
                    { new Guid("5af4f66a-a8e2-457d-a9d7-79d84cf1c909"), "public/default/service.png", null, "Escolhe um serviço de Reparação", 10, new Guid("aa883287-24ee-42e9-b1cb-3122e99f4d8a"), 100, "Serviço de Reparação" },
                    { new Guid("7f15774a-6a78-425e-bf94-60acf1258e74"), "public/default/repair.png", null, "Arranjar a peça pelo próprio", 10, new Guid("aa883287-24ee-42e9-b1cb-3122e99f4d8a"), 100, "Pelo Próprio" },
                    { new Guid("87ddae47-fd57-45a3-85e1-d15f125765b0"), "public/default/service.png", null, "Escolhe um serviço de engomadoria", 10, new Guid("973dadb9-b07a-46c2-91cc-55389686f2f2"), 100, "Serviço de Engomadoria" },
                    { new Guid("8eed3bef-0fd6-4c88-ac8c-078ef81ba4e4"), "public/default/iron/less150.png", null, "Engomar a menos de 150ºC", 10, new Guid("973dadb9-b07a-46c2-91cc-55389686f2f2"), 100, "A menos de 150ºC" },
                    { new Guid("a11a1abc-1ec4-4587-8c35-07a93371cd0a"), "public/default/wash/less30.png", null, "Lavar a menos de 30ºC", 10, new Guid("3ce29e6e-89a5-4700-8b09-2de656b13103"), 100, "A menos de 30ºC" },
                    { new Guid("a3898f19-4de1-414f-991f-357ce0000fac"), "public/default/wash/less95.png", null, "Lavar a menos de 95ºC", 10, new Guid("3ce29e6e-89a5-4700-8b09-2de656b13103"), 100, "A menos de 95ºC" },
                    { new Guid("b33c19da-363f-46c5-9353-71540f65b8f3"), "public/default/iron/less200.png", null, "Engomar a menos de 200ºC", 10, new Guid("973dadb9-b07a-46c2-91cc-55389686f2f2"), 100, "A menos de 200ºC" },
                    { new Guid("b525aa7a-8999-4480-8a03-d10e6b27a3a0"), "public/default/service.png", null, "Escolhe um serviço de secagem", 10, new Guid("b6a455d6-593c-4941-969d-13d21705b92f"), 100, "Serviço de Secagem" },
                    { new Guid("e64f1fc9-f2d4-4492-b548-3c163a1257dc"), "public/default/dry/machine.png", null, "Secar na máquina", 10, new Guid("b6a455d6-593c-4941-969d-13d21705b92f"), 100, "Na máquina" },
                    { new Guid("f2802726-d963-409e-a9ed-caed80a4637c"), "public/default/wash/less70.png", null, "Lavar a menos de 70ºC", 10, new Guid("3ce29e6e-89a5-4700-8b09-2de656b13103"), 100, "A menos de 70ºC" }
                });
        }
    }
}
