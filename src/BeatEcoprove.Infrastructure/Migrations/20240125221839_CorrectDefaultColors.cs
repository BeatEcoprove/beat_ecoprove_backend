using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BeatEcoprove.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class CorrectDefaultColors : Migration
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
                    { new Guid("f59193cd-a717-466b-b5ff-ffdfd5206419"), "public/default/repair.png", null, "De que forma pertende arranjar a peça?", "Engomar" }
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
