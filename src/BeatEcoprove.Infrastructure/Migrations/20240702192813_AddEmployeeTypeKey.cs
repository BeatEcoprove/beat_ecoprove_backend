using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BeatEcoprove.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddEmployeeTypeKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: new Guid("042304db-7ae7-4d8a-921e-6201dd7122b8"));

            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: new Guid("1787f49e-139d-48fa-a96c-8a6400a4d7c7"));

            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: new Guid("3fdad647-ca99-481d-929e-824998f5dff3"));

            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: new Guid("718ab7c8-1a10-429d-a9a6-50378bb7cec1"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("23645050-243a-4b18-a183-626864dc6343"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("2439e3d4-bc2e-4093-9352-5fcf3213d90c"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("2a51e300-a687-48a1-949a-7d7a8cfa7554"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("2c3c2f21-e442-4cef-a8a3-7e142580ecad"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("347fab90-7fc4-4dd7-8a69-d19de9512673"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("3773af5a-25ac-4ab3-9675-8d98c116cbda"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("3b0aa452-41ff-44fb-8348-c1e42441ba7a"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("48997f00-baa5-4481-aa79-9bad23ccadca"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("5899844b-3546-4af8-9abe-b5bf0d625401"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("6d488316-b47f-4f1b-bb51-2017bf6f3d49"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("7a0061a2-3cc9-4d19-94c2-6ae310e98c55"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("9451f5c0-3734-4dc5-88b5-a3d11bbafaa0"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("99426b6c-695d-4a5c-8fc6-b0d8308f608e"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("b3d34843-b7bf-4a04-8623-badc646013c1"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("b51ec4d6-a87c-4ea1-a58e-f3c5c9d1d0d8"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("b7e66984-4234-4dbf-83ec-fb2626695dc7"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("c13df81f-fdc9-485e-a04a-f22ff305df92"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("ce856308-6ed7-49f2-b115-f5956b89057b"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("d8501ce2-9b33-42a1-980b-7aef71d6e32f"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("d97c8234-4cd9-4f95-867e-0ae3e0d77ce0"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("ebfd0c87-54a4-4471-80f1-db84d63dd041"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("0015a80c-5dd7-4692-8a19-3e4a6e758811"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("0d15a4f7-2cc8-40e7-af15-c27745f013b2"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("0e1ea4aa-79a3-4fb0-946c-6606c4e458df"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("2ca099d9-ebac-4a82-a942-aca8895fd71d"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("3de70907-c2ac-4878-86a9-24c8cac8be63"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("3e72ed8b-6ef3-4a60-afa2-ec9e38be4bb3"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("40682e16-2706-4533-b987-60be5789bc56"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("67bd775e-13aa-4882-9d2f-54a233011edc"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("7d9d69f7-3ff6-4683-b68e-412dd42caa8a"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("a817fe51-4af4-4b52-8e24-dac8171f3d4d"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("addb2bc7-46bc-4384-a53d-685ca9b3a2e6"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("b5312470-b5c7-4c10-a65c-38ff713d8ebf"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("cdab03ce-c780-4d76-a976-c13b3af98be7"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("ce5bab67-e071-464f-8d98-9b96c7db83b4"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("d58f2776-3e61-4b63-998f-aa81ed7209c6"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("f3ef606d-ee60-4f77-b1b7-f0f9dd24b41b"));

            migrationBuilder.DeleteData(
                table: "maintenance_services",
                keyColumn: "id",
                keyValue: new Guid("6c820178-ae6e-4c03-8278-5546af3b31b4"));

            migrationBuilder.DeleteData(
                table: "maintenance_services",
                keyColumn: "id",
                keyValue: new Guid("9a749def-fea0-46f6-8385-1b1ec38e5598"));

            migrationBuilder.DeleteData(
                table: "maintenance_services",
                keyColumn: "id",
                keyValue: new Guid("a9124cab-8529-40c6-bc5e-cd2782d99ab8"));

            migrationBuilder.DeleteData(
                table: "maintenance_services",
                keyColumn: "id",
                keyValue: new Guid("d4c417aa-1628-41ec-8aa7-d645478b2bbf"));

            migrationBuilder.InsertData(
                table: "brands",
                columns: new[] { "id", "brand_avatar", "deleted_at", "name" },
                values: new object[,]
                {
                    { new Guid("09969a83-8904-4126-95f9-bcfe6a9608fd"), "public/default/brands/zippy.png", null, "Zippy" },
                    { new Guid("1cf192a2-8fd6-4336-a549-ad81259adebb"), "public/default/brands/mo.png", null, "MO" },
                    { new Guid("ba0f2d4a-0a84-4cf4-a76d-8908105773b5"), "public/default/brands/losan.png", null, "Losan" },
                    { new Guid("e29574dd-0fd8-4261-bd24-20e7109505e6"), "public/default/brands/salsa.png", null, "Salsa" }
                });

            migrationBuilder.InsertData(
                table: "colors",
                columns: new[] { "id", "deleted_at", "hex", "name" },
                values: new object[,]
                {
                    { new Guid("05d1ae18-8048-4e65-966d-fedfcd7022b7"), null, "FF8B5F3C", "Castanho Bebê" },
                    { new Guid("19ad2a54-5c2e-405f-a7e8-5acf9e9b7964"), null, "FFC0C0C0", "Cinzento Bebê" },
                    { new Guid("1f6b41c6-b656-4108-8f00-97af148e46d4"), null, "FF000000", "Black" },
                    { new Guid("2e925d1f-600c-4215-a92c-8a74fbca0fa8"), null, "FFDA252E", "Vermelho" },
                    { new Guid("3012ee75-b53e-4af9-8c51-bfe3b2d07d05"), null, "FF29394A", "Azul Escuro" },
                    { new Guid("40c16fc3-19a1-4f38-9310-6b3f6d5ef98f"), null, "FFF9C7C4", "Rosa Claro" },
                    { new Guid("4ced5360-13c2-49a4-9068-97eb9b7dfc56"), null, "FF509C75", "Verde" },
                    { new Guid("55c61286-5bb3-4601-ab75-c7aae1a9f905"), null, "FFD2AAC5", "Roxo Claro" },
                    { new Guid("5f56016e-38ba-4ec9-82b5-2ad16d7fe524"), null, "FF4C4C4C", "Cinzento Claro" },
                    { new Guid("7070f8c5-e486-402a-81f4-edcf8e1d95ea"), null, "FF98B3C8", "Azul Claro" },
                    { new Guid("7280289d-af16-4f84-bed4-ba2967aab4ce"), null, "FFF58221", "Laranja" },
                    { new Guid("775d2c9e-5d90-4858-947c-789928dc8657"), null, "FFFFE69F", "Amarelo" },
                    { new Guid("7999c3c6-8dd5-4f2d-9198-3ea391c6ea26"), null, "FFBE5967", "Rosa" },
                    { new Guid("81200373-68b0-475f-996a-f483b0fe8680"), null, "FFF2E7D4", "Amarelo Bebê" },
                    { new Guid("90655b2a-b2b0-42df-87eb-87f0d64550d4"), null, "FFFFFFFF", "White" },
                    { new Guid("9c155f55-1991-435c-8562-255362019486"), null, "FFC3A572", "Amarelo Claro" },
                    { new Guid("ac769128-b928-4924-8950-2c5c021da33e"), null, "FF948066", "Castanho Claro" },
                    { new Guid("bafa92dc-98b9-4470-aff5-36b53e2436d1"), null, "FFD62598", "Roxo" },
                    { new Guid("e18fb4f6-1661-43fa-9df3-b93bdab44571"), null, "FFC2BC8B", "Verde Lima" },
                    { new Guid("e25e2d81-c349-4b02-893a-7796facfdfad"), null, "FF4A2D16", "Castanho" },
                    { new Guid("f2df7b3f-9c1d-412f-97fc-6030b30cac7c"), null, "FFFF6D6D", "Vermelho Claro" }
                });

            migrationBuilder.InsertData(
                table: "maintenance_services",
                columns: new[] { "id", "badge", "deleted_at", "description", "title" },
                values: new object[,]
                {
                    { new Guid("141ea57c-77ad-45ec-bd2c-947d107c5d1d"), "public/default/dry.png", null, "De que forma pretende secar?", "Secar" },
                    { new Guid("463b9767-101d-4c46-9be8-01a190908abc"), "public/default/iron.png", null, "De que forma pretende engomar?", "Engomar" },
                    { new Guid("9d81a59e-5348-48f2-bb20-ce90955bc93c"), "public/default/wash.png", null, "De que forma pretende lavar?", "Lavar" },
                    { new Guid("efc03f74-b1c1-48ea-8d9b-d6865accf0fc"), "public/default/repair.png", null, "De que forma pretende arranjar a peça?", "Reparar" }
                });

            migrationBuilder.InsertData(
                table: "maintenance_service_actions",
                columns: new[] { "id", "badge", "deleted_at", "Description", "eco_score", "maintenance_service_id", "sustainable_points", "title" },
                values: new object[,]
                {
                    { new Guid("098bf94a-0260-4a94-a677-37bc7b316e76"), "public/default/wash/less50.png", null, "Lavar a menos de 50ºC", -2, new Guid("9d81a59e-5348-48f2-bb20-ce90955bc93c"), 1, "A menos de 50ºC" },
                    { new Guid("14829450-0f9a-4585-9d02-9071cb8e93b9"), "public/default/wash/hand.png", null, "Lavar à mão com água e sabão", 10, new Guid("9d81a59e-5348-48f2-bb20-ce90955bc93c"), 100, "Lavar à mão" },
                    { new Guid("21b47cb0-bfae-4f2e-b336-67bb2a0f18fa"), "public/default/service.png", null, "Escolhe uma lavandaria", 10, new Guid("9d81a59e-5348-48f2-bb20-ce90955bc93c"), 100, "Serviço de lavandaria" },
                    { new Guid("2a4bccbc-929b-4669-a044-cc0df5cf5b0f"), "public/default/service.png", null, "Escolhe um serviço de Reparação", 10, new Guid("efc03f74-b1c1-48ea-8d9b-d6865accf0fc"), 100, "Serviço de Reparação" },
                    { new Guid("4f7d1983-78e2-4c42-bf38-2e8d87955a3c"), "public/default/service.png", null, "Escolhe um serviço de secagem", 10, new Guid("141ea57c-77ad-45ec-bd2c-947d107c5d1d"), 100, "Serviço de Secagem" },
                    { new Guid("5e66da4c-6676-461f-8e14-bcb92ca7573d"), "public/default/wash/less70.png", null, "Lavar a menos de 70ºC", -2, new Guid("9d81a59e-5348-48f2-bb20-ce90955bc93c"), 1, "A menos de 70ºC" },
                    { new Guid("74785afb-6736-4eec-a2b1-0423d57255c6"), "public/default/service.png", null, "Escolhe um serviço de engomadoria", 10, new Guid("463b9767-101d-4c46-9be8-01a190908abc"), 100, "Serviço de Engomadoria" },
                    { new Guid("8125d44c-d9b3-44df-965f-1f1e35c8a849"), "public/default/dry/air.png", null, "Secar ao ar livre", 0, new Guid("141ea57c-77ad-45ec-bd2c-947d107c5d1d"), 2, "Ao ar livre" },
                    { new Guid("a1602526-91b0-4377-8a84-609ab0038c41"), "public/default/iron/less200.png", null, "Engomar a menos de 200ºC", -1, new Guid("463b9767-101d-4c46-9be8-01a190908abc"), 1, "A menos de 200ºC" },
                    { new Guid("b2745d9b-9f2c-4917-a83f-0034bde73138"), "public/default/repair.png", null, "Arranjar a peça pelo próprio", 2, new Guid("efc03f74-b1c1-48ea-8d9b-d6865accf0fc"), 3, "Pelo Próprio" },
                    { new Guid("ba0cd1a2-d09c-41c5-a2e6-9608a206d669"), "public/default/wash/less30.png", null, "Lavar a menos de 30ºC", -1, new Guid("9d81a59e-5348-48f2-bb20-ce90955bc93c"), 2, "A menos de 30ºC" },
                    { new Guid("c00f4aa7-6c92-45b3-b8b0-9a302185050c"), "public/default/dry/machine.png", null, "Secar na máquina", -1, new Guid("141ea57c-77ad-45ec-bd2c-947d107c5d1d"), 1, "Na máquina" },
                    { new Guid("c67bb728-6c27-499a-bb74-934badbf9388"), "public/default/iron/less110.png", null, "Engomar a menos de 110ºC", -1, new Guid("463b9767-101d-4c46-9be8-01a190908abc"), 1, "A menos de 110ºC" },
                    { new Guid("d65b12fa-6eb4-458b-861b-83eaa428d5ca"), "public/default/wash/dry.png", null, "Lavar a seco", -3, new Guid("9d81a59e-5348-48f2-bb20-ce90955bc93c"), 0, "A seco" },
                    { new Guid("f4226515-03c1-4e94-b56b-957f26b212f1"), "public/default/iron/less150.png", null, "Engomar a menos de 150ºC", -1, new Guid("463b9767-101d-4c46-9be8-01a190908abc"), 1, "A menos de 150ºC" },
                    { new Guid("f593fc88-cad8-43d6-83eb-6b88c77c3b2b"), "public/default/wash/less95.png", null, "Lavar a menos de 95ºC", -2, new Guid("9d81a59e-5348-48f2-bb20-ce90955bc93c"), 1, "A menos de 95ºC" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: new Guid("09969a83-8904-4126-95f9-bcfe6a9608fd"));

            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: new Guid("1cf192a2-8fd6-4336-a549-ad81259adebb"));

            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: new Guid("ba0f2d4a-0a84-4cf4-a76d-8908105773b5"));

            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: new Guid("e29574dd-0fd8-4261-bd24-20e7109505e6"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("05d1ae18-8048-4e65-966d-fedfcd7022b7"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("19ad2a54-5c2e-405f-a7e8-5acf9e9b7964"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("1f6b41c6-b656-4108-8f00-97af148e46d4"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("2e925d1f-600c-4215-a92c-8a74fbca0fa8"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("3012ee75-b53e-4af9-8c51-bfe3b2d07d05"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("40c16fc3-19a1-4f38-9310-6b3f6d5ef98f"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("4ced5360-13c2-49a4-9068-97eb9b7dfc56"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("55c61286-5bb3-4601-ab75-c7aae1a9f905"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("5f56016e-38ba-4ec9-82b5-2ad16d7fe524"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("7070f8c5-e486-402a-81f4-edcf8e1d95ea"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("7280289d-af16-4f84-bed4-ba2967aab4ce"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("775d2c9e-5d90-4858-947c-789928dc8657"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("7999c3c6-8dd5-4f2d-9198-3ea391c6ea26"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("81200373-68b0-475f-996a-f483b0fe8680"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("90655b2a-b2b0-42df-87eb-87f0d64550d4"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("9c155f55-1991-435c-8562-255362019486"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("ac769128-b928-4924-8950-2c5c021da33e"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("bafa92dc-98b9-4470-aff5-36b53e2436d1"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("e18fb4f6-1661-43fa-9df3-b93bdab44571"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("e25e2d81-c349-4b02-893a-7796facfdfad"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("f2df7b3f-9c1d-412f-97fc-6030b30cac7c"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("098bf94a-0260-4a94-a677-37bc7b316e76"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("14829450-0f9a-4585-9d02-9071cb8e93b9"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("21b47cb0-bfae-4f2e-b336-67bb2a0f18fa"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("2a4bccbc-929b-4669-a044-cc0df5cf5b0f"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("4f7d1983-78e2-4c42-bf38-2e8d87955a3c"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("5e66da4c-6676-461f-8e14-bcb92ca7573d"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("74785afb-6736-4eec-a2b1-0423d57255c6"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("8125d44c-d9b3-44df-965f-1f1e35c8a849"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("a1602526-91b0-4377-8a84-609ab0038c41"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("b2745d9b-9f2c-4917-a83f-0034bde73138"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("ba0cd1a2-d09c-41c5-a2e6-9608a206d669"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("c00f4aa7-6c92-45b3-b8b0-9a302185050c"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("c67bb728-6c27-499a-bb74-934badbf9388"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("d65b12fa-6eb4-458b-861b-83eaa428d5ca"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("f4226515-03c1-4e94-b56b-957f26b212f1"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("f593fc88-cad8-43d6-83eb-6b88c77c3b2b"));

            migrationBuilder.DeleteData(
                table: "maintenance_services",
                keyColumn: "id",
                keyValue: new Guid("141ea57c-77ad-45ec-bd2c-947d107c5d1d"));

            migrationBuilder.DeleteData(
                table: "maintenance_services",
                keyColumn: "id",
                keyValue: new Guid("463b9767-101d-4c46-9be8-01a190908abc"));

            migrationBuilder.DeleteData(
                table: "maintenance_services",
                keyColumn: "id",
                keyValue: new Guid("9d81a59e-5348-48f2-bb20-ce90955bc93c"));

            migrationBuilder.DeleteData(
                table: "maintenance_services",
                keyColumn: "id",
                keyValue: new Guid("efc03f74-b1c1-48ea-8d9b-d6865accf0fc"));

            migrationBuilder.InsertData(
                table: "brands",
                columns: new[] { "id", "brand_avatar", "deleted_at", "name" },
                values: new object[,]
                {
                    { new Guid("042304db-7ae7-4d8a-921e-6201dd7122b8"), "public/default/brands/mo.png", null, "MO" },
                    { new Guid("1787f49e-139d-48fa-a96c-8a6400a4d7c7"), "public/default/brands/zippy.png", null, "Zippy" },
                    { new Guid("3fdad647-ca99-481d-929e-824998f5dff3"), "public/default/brands/losan.png", null, "Losan" },
                    { new Guid("718ab7c8-1a10-429d-a9a6-50378bb7cec1"), "public/default/brands/salsa.png", null, "Salsa" }
                });

            migrationBuilder.InsertData(
                table: "colors",
                columns: new[] { "id", "deleted_at", "hex", "name" },
                values: new object[,]
                {
                    { new Guid("23645050-243a-4b18-a183-626864dc6343"), null, "FF29394A", "Azul Escuro" },
                    { new Guid("2439e3d4-bc2e-4093-9352-5fcf3213d90c"), null, "FFFFFFFF", "White" },
                    { new Guid("2a51e300-a687-48a1-949a-7d7a8cfa7554"), null, "FF4A2D16", "Castanho" },
                    { new Guid("2c3c2f21-e442-4cef-a8a3-7e142580ecad"), null, "FF509C75", "Verde" },
                    { new Guid("347fab90-7fc4-4dd7-8a69-d19de9512673"), null, "FFBE5967", "Rosa" },
                    { new Guid("3773af5a-25ac-4ab3-9675-8d98c116cbda"), null, "FFF9C7C4", "Rosa Claro" },
                    { new Guid("3b0aa452-41ff-44fb-8348-c1e42441ba7a"), null, "FFF58221", "Laranja" },
                    { new Guid("48997f00-baa5-4481-aa79-9bad23ccadca"), null, "FFDA252E", "Vermelho" },
                    { new Guid("5899844b-3546-4af8-9abe-b5bf0d625401"), null, "FFC2BC8B", "Verde Lima" },
                    { new Guid("6d488316-b47f-4f1b-bb51-2017bf6f3d49"), null, "FF98B3C8", "Azul Claro" },
                    { new Guid("7a0061a2-3cc9-4d19-94c2-6ae310e98c55"), null, "FFFFE69F", "Amarelo" },
                    { new Guid("9451f5c0-3734-4dc5-88b5-a3d11bbafaa0"), null, "FFD62598", "Roxo" },
                    { new Guid("99426b6c-695d-4a5c-8fc6-b0d8308f608e"), null, "FFFF6D6D", "Vermelho Claro" },
                    { new Guid("b3d34843-b7bf-4a04-8623-badc646013c1"), null, "FF8B5F3C", "Castanho Bebê" },
                    { new Guid("b51ec4d6-a87c-4ea1-a58e-f3c5c9d1d0d8"), null, "FF4C4C4C", "Cinzento Claro" },
                    { new Guid("b7e66984-4234-4dbf-83ec-fb2626695dc7"), null, "FFC0C0C0", "Cinzento Bebê" },
                    { new Guid("c13df81f-fdc9-485e-a04a-f22ff305df92"), null, "FFD2AAC5", "Roxo Claro" },
                    { new Guid("ce856308-6ed7-49f2-b115-f5956b89057b"), null, "FFC3A572", "Amarelo Claro" },
                    { new Guid("d8501ce2-9b33-42a1-980b-7aef71d6e32f"), null, "FF000000", "Black" },
                    { new Guid("d97c8234-4cd9-4f95-867e-0ae3e0d77ce0"), null, "FFF2E7D4", "Amarelo Bebê" },
                    { new Guid("ebfd0c87-54a4-4471-80f1-db84d63dd041"), null, "FF948066", "Castanho Claro" }
                });

            migrationBuilder.InsertData(
                table: "maintenance_services",
                columns: new[] { "id", "badge", "deleted_at", "description", "title" },
                values: new object[,]
                {
                    { new Guid("6c820178-ae6e-4c03-8278-5546af3b31b4"), "public/default/iron.png", null, "De que forma pretende engomar?", "Engomar" },
                    { new Guid("9a749def-fea0-46f6-8385-1b1ec38e5598"), "public/default/dry.png", null, "De que forma pretende secar?", "Secar" },
                    { new Guid("a9124cab-8529-40c6-bc5e-cd2782d99ab8"), "public/default/wash.png", null, "De que forma pretende lavar?", "Lavar" },
                    { new Guid("d4c417aa-1628-41ec-8aa7-d645478b2bbf"), "public/default/repair.png", null, "De que forma pretende arranjar a peça?", "Reparar" }
                });

            migrationBuilder.InsertData(
                table: "maintenance_service_actions",
                columns: new[] { "id", "badge", "deleted_at", "Description", "eco_score", "maintenance_service_id", "sustainable_points", "title" },
                values: new object[,]
                {
                    { new Guid("0015a80c-5dd7-4692-8a19-3e4a6e758811"), "public/default/iron/less110.png", null, "Engomar a menos de 110ºC", -1, new Guid("6c820178-ae6e-4c03-8278-5546af3b31b4"), 1, "A menos de 110ºC" },
                    { new Guid("0d15a4f7-2cc8-40e7-af15-c27745f013b2"), "public/default/repair.png", null, "Arranjar a peça pelo próprio", 2, new Guid("d4c417aa-1628-41ec-8aa7-d645478b2bbf"), 3, "Pelo Próprio" },
                    { new Guid("0e1ea4aa-79a3-4fb0-946c-6606c4e458df"), "public/default/service.png", null, "Escolhe um serviço de engomadoria", 10, new Guid("6c820178-ae6e-4c03-8278-5546af3b31b4"), 100, "Serviço de Engomadoria" },
                    { new Guid("2ca099d9-ebac-4a82-a942-aca8895fd71d"), "public/default/service.png", null, "Escolhe uma lavandaria", 10, new Guid("a9124cab-8529-40c6-bc5e-cd2782d99ab8"), 100, "Serviço de lavandaria" },
                    { new Guid("3de70907-c2ac-4878-86a9-24c8cac8be63"), "public/default/wash/less30.png", null, "Lavar a menos de 30ºC", -1, new Guid("a9124cab-8529-40c6-bc5e-cd2782d99ab8"), 2, "A menos de 30ºC" },
                    { new Guid("3e72ed8b-6ef3-4a60-afa2-ec9e38be4bb3"), "public/default/wash/less50.png", null, "Lavar a menos de 50ºC", -2, new Guid("a9124cab-8529-40c6-bc5e-cd2782d99ab8"), 1, "A menos de 50ºC" },
                    { new Guid("40682e16-2706-4533-b987-60be5789bc56"), "public/default/dry/machine.png", null, "Secar na máquina", -1, new Guid("9a749def-fea0-46f6-8385-1b1ec38e5598"), 1, "Na máquina" },
                    { new Guid("67bd775e-13aa-4882-9d2f-54a233011edc"), "public/default/iron/less200.png", null, "Engomar a menos de 200ºC", -1, new Guid("6c820178-ae6e-4c03-8278-5546af3b31b4"), 1, "A menos de 200ºC" },
                    { new Guid("7d9d69f7-3ff6-4683-b68e-412dd42caa8a"), "public/default/wash/hand.png", null, "Lavar à mão com água e sabão", 10, new Guid("a9124cab-8529-40c6-bc5e-cd2782d99ab8"), 100, "Lavar à mão" },
                    { new Guid("a817fe51-4af4-4b52-8e24-dac8171f3d4d"), "public/default/wash/less70.png", null, "Lavar a menos de 70ºC", -2, new Guid("a9124cab-8529-40c6-bc5e-cd2782d99ab8"), 1, "A menos de 70ºC" },
                    { new Guid("addb2bc7-46bc-4384-a53d-685ca9b3a2e6"), "public/default/iron/less150.png", null, "Engomar a menos de 150ºC", -1, new Guid("6c820178-ae6e-4c03-8278-5546af3b31b4"), 1, "A menos de 150ºC" },
                    { new Guid("b5312470-b5c7-4c10-a65c-38ff713d8ebf"), "public/default/wash/dry.png", null, "Lavar a seco", -3, new Guid("a9124cab-8529-40c6-bc5e-cd2782d99ab8"), 0, "A seco" },
                    { new Guid("cdab03ce-c780-4d76-a976-c13b3af98be7"), "public/default/service.png", null, "Escolhe um serviço de secagem", 10, new Guid("9a749def-fea0-46f6-8385-1b1ec38e5598"), 100, "Serviço de Secagem" },
                    { new Guid("ce5bab67-e071-464f-8d98-9b96c7db83b4"), "public/default/wash/less95.png", null, "Lavar a menos de 95ºC", -2, new Guid("a9124cab-8529-40c6-bc5e-cd2782d99ab8"), 1, "A menos de 95ºC" },
                    { new Guid("d58f2776-3e61-4b63-998f-aa81ed7209c6"), "public/default/dry/air.png", null, "Secar ao ar livre", 0, new Guid("9a749def-fea0-46f6-8385-1b1ec38e5598"), 2, "Ao ar livre" },
                    { new Guid("f3ef606d-ee60-4f77-b1b7-f0f9dd24b41b"), "public/default/service.png", null, "Escolhe um serviço de Reparação", 10, new Guid("d4c417aa-1628-41ec-8aa7-d645478b2bbf"), 100, "Serviço de Reparação" }
                });
        }
    }
}
