using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BeatEcoprove.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddStoreOntoAdvertisement : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<Guid>(
                name: "store",
                table: "advertisements",
                type: "uuid",
                nullable: true);

            migrationBuilder.InsertData(
                table: "brands",
                columns: new[] { "id", "brand_avatar", "deleted_at", "name" },
                values: new object[,]
                {
                    { new Guid("02ab46c0-15d2-48e6-a9e7-3bad1c870316"), "public/default/brands/mo.png", null, "MO" },
                    { new Guid("c6d07277-1e33-4159-b9a2-033b1eeac460"), "public/default/brands/salsa.png", null, "Salsa" },
                    { new Guid("d8a08cd6-74f4-4894-8e43-9ec4db8f391c"), "public/default/brands/losan.png", null, "Losan" },
                    { new Guid("fecbe4d4-bf33-4ba8-beb0-700811dd7e35"), "public/default/brands/zippy.png", null, "Zippy" }
                });

            migrationBuilder.InsertData(
                table: "colors",
                columns: new[] { "id", "deleted_at", "hex", "name" },
                values: new object[,]
                {
                    { new Guid("04414364-8389-41db-a9be-13d98c27a6ae"), null, "FF4C4C4C", "Cinzento Claro" },
                    { new Guid("0d427950-23fa-47ea-b1e7-71fe5e464f2e"), null, "FFC3A572", "Amarelo Claro" },
                    { new Guid("2eced102-de83-47a8-a029-361706d5928f"), null, "FFFFFFFF", "White" },
                    { new Guid("3112c299-8063-4d38-95d9-890eab22dd47"), null, "FFFF6D6D", "Vermelho Claro" },
                    { new Guid("31291cd7-2b4a-4a44-8552-c76724ea8dcb"), null, "FFDA252E", "Vermelho" },
                    { new Guid("3eb99ead-ad1b-4f0c-8cff-8a841348f8f4"), null, "FFF9C7C4", "Rosa Claro" },
                    { new Guid("52bbdb07-896d-4690-966d-dffe240d16c1"), null, "FFFFE69F", "Amarelo" },
                    { new Guid("631ad511-07f7-4187-9f02-809661462603"), null, "FFF2E7D4", "Amarelo Bebê" },
                    { new Guid("7c377762-2bd1-4fd6-8181-32a8108a54ef"), null, "FF948066", "Castanho Claro" },
                    { new Guid("87c9c8c2-b03a-4f87-bb8b-4311d0f84924"), null, "FF98B3C8", "Azul Claro" },
                    { new Guid("8c8da77d-71ac-4e6a-b24d-d5d64b6f99f8"), null, "FFC2BC8B", "Verde Lima" },
                    { new Guid("9839a6c9-ead9-4775-b3c8-8dc54d9aa626"), null, "FFF58221", "Laranja" },
                    { new Guid("98608468-8258-4366-8bdb-2baf98206bd7"), null, "FF8B5F3C", "Castanho Bebê" },
                    { new Guid("a2a19a96-7a34-4c02-ad46-eb9ad40d40d4"), null, "FFD62598", "Roxo" },
                    { new Guid("c895a717-4239-444a-8453-62677b082a1b"), null, "FF000000", "Black" },
                    { new Guid("d97ac9c3-5f88-4283-abec-7c128ec06e08"), null, "FF29394A", "Azul Escuro" },
                    { new Guid("dd6cbabf-8895-42bd-a423-86f912e44850"), null, "FFD2AAC5", "Roxo Claro" },
                    { new Guid("e3d0f7c8-6038-47e0-86fd-98635f7aafc4"), null, "FFBE5967", "Rosa" },
                    { new Guid("e4e306ce-0e5d-466e-a774-f5d8aff85b35"), null, "FF4A2D16", "Castanho" },
                    { new Guid("fde1242c-c9aa-40de-9eeb-7225301e6dbd"), null, "FF509C75", "Verde" },
                    { new Guid("fe6dac04-b957-43de-ac0c-63bd17106bd8"), null, "FFC0C0C0", "Cinzento Bebê" }
                });

            migrationBuilder.InsertData(
                table: "maintenance_services",
                columns: new[] { "id", "badge", "deleted_at", "description", "title" },
                values: new object[,]
                {
                    { new Guid("3c3f5bb7-e22e-4dd9-80dd-367356959a89"), "public/default/repair.png", null, "De que forma pretende arranjar a peça?", "Reparar" },
                    { new Guid("6f85e705-01ab-47a6-82c8-db72e322cc7c"), "public/default/wash.png", null, "De que forma pretende lavar?", "Lavar" },
                    { new Guid("88a905e3-31d2-413c-a756-fec140a85719"), "public/default/dry.png", null, "De que forma pretende secar?", "Secar" },
                    { new Guid("d2b30163-3702-403f-afe7-7cfb4d4f30d2"), "public/default/iron.png", null, "De que forma pretende engomar?", "Engomar" }
                });

            migrationBuilder.InsertData(
                table: "maintenance_service_actions",
                columns: new[] { "id", "badge", "deleted_at", "Description", "eco_score", "maintenance_service_id", "sustainable_points", "title" },
                values: new object[,]
                {
                    { new Guid("0d4ee8fd-ba43-47b8-b4f4-93a18ad3177e"), "public/default/iron/less110.png", null, "Engomar a menos de 110ºC", -1, new Guid("d2b30163-3702-403f-afe7-7cfb4d4f30d2"), 1, "A menos de 110ºC" },
                    { new Guid("2ae98421-2b32-4e22-9975-00311b4c477e"), "public/default/wash/less70.png", null, "Lavar a menos de 70ºC", -2, new Guid("6f85e705-01ab-47a6-82c8-db72e322cc7c"), 1, "A menos de 70ºC" },
                    { new Guid("2c19292a-94b0-4732-b76a-f223a8fdc93b"), "public/default/service.png", null, "Escolhe um serviço de engomadoria", 10, new Guid("d2b30163-3702-403f-afe7-7cfb4d4f30d2"), 100, "Serviço de Engomadoria" },
                    { new Guid("395b4fae-ba3b-445e-9634-28725efac330"), "public/default/service.png", null, "Escolhe um serviço de secagem", 10, new Guid("88a905e3-31d2-413c-a756-fec140a85719"), 100, "Serviço de Secagem" },
                    { new Guid("61cf61be-f0a8-47c5-a4ee-9d516f55e2ee"), "public/default/wash/less30.png", null, "Lavar a menos de 30ºC", -1, new Guid("6f85e705-01ab-47a6-82c8-db72e322cc7c"), 2, "A menos de 30ºC" },
                    { new Guid("661e48b2-f1d7-4062-8d83-cb7ec919288b"), "public/default/wash/hand.png", null, "Lavar à mão com água e sabão", 10, new Guid("6f85e705-01ab-47a6-82c8-db72e322cc7c"), 100, "Lavar à mão" },
                    { new Guid("6e83ced3-219d-4b5e-95b9-abb4ba1e308c"), "public/default/dry/air.png", null, "Secar ao ar livre", 0, new Guid("88a905e3-31d2-413c-a756-fec140a85719"), 2, "Ao ar livre" },
                    { new Guid("7ac9e774-4046-406e-8606-09bc8a4adf6c"), "public/default/wash/less50.png", null, "Lavar a menos de 50ºC", -2, new Guid("6f85e705-01ab-47a6-82c8-db72e322cc7c"), 1, "A menos de 50ºC" },
                    { new Guid("85d9b0af-45b5-4ce7-9bc2-67bba4b3bae5"), "public/default/iron/less150.png", null, "Engomar a menos de 150ºC", -1, new Guid("d2b30163-3702-403f-afe7-7cfb4d4f30d2"), 1, "A menos de 150ºC" },
                    { new Guid("8a9f9e55-30e9-4d6d-a1ba-d26909708466"), "public/default/wash/dry.png", null, "Lavar a seco", -3, new Guid("6f85e705-01ab-47a6-82c8-db72e322cc7c"), 0, "A seco" },
                    { new Guid("95d3ce68-0e53-47ff-be3f-1b77daea21fa"), "public/default/repair.png", null, "Arranjar a peça pelo próprio", 2, new Guid("3c3f5bb7-e22e-4dd9-80dd-367356959a89"), 3, "Pelo Próprio" },
                    { new Guid("9c38debb-f170-4497-9b97-283b952124dd"), "public/default/service.png", null, "Escolhe uma lavandaria", 10, new Guid("6f85e705-01ab-47a6-82c8-db72e322cc7c"), 100, "Serviço de lavandaria" },
                    { new Guid("baf32513-5cfa-4513-a108-f1c443bc7d0d"), "public/default/service.png", null, "Escolhe um serviço de Reparação", 10, new Guid("3c3f5bb7-e22e-4dd9-80dd-367356959a89"), 100, "Serviço de Reparação" },
                    { new Guid("d16c0eb2-c61e-4120-ab81-5fcbcf3e5ad8"), "public/default/iron/less200.png", null, "Engomar a menos de 200ºC", -1, new Guid("d2b30163-3702-403f-afe7-7cfb4d4f30d2"), 1, "A menos de 200ºC" },
                    { new Guid("eb02f096-b277-439c-bd81-87b5718a4f83"), "public/default/dry/machine.png", null, "Secar na máquina", -1, new Guid("88a905e3-31d2-413c-a756-fec140a85719"), 1, "Na máquina" },
                    { new Guid("f24c6e71-eb01-4498-a1fd-9601a708d32e"), "public/default/wash/less95.png", null, "Lavar a menos de 95ºC", -2, new Guid("6f85e705-01ab-47a6-82c8-db72e322cc7c"), 1, "A menos de 95ºC" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_advertisements_store",
                table: "advertisements",
                column: "store");

            migrationBuilder.AddForeignKey(
                name: "FK_advertisements_stores_store",
                table: "advertisements",
                column: "store",
                principalTable: "stores",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_advertisements_stores_store",
                table: "advertisements");

            migrationBuilder.DropIndex(
                name: "IX_advertisements_store",
                table: "advertisements");

            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: new Guid("02ab46c0-15d2-48e6-a9e7-3bad1c870316"));

            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: new Guid("c6d07277-1e33-4159-b9a2-033b1eeac460"));

            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: new Guid("d8a08cd6-74f4-4894-8e43-9ec4db8f391c"));

            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: new Guid("fecbe4d4-bf33-4ba8-beb0-700811dd7e35"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("04414364-8389-41db-a9be-13d98c27a6ae"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("0d427950-23fa-47ea-b1e7-71fe5e464f2e"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("2eced102-de83-47a8-a029-361706d5928f"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("3112c299-8063-4d38-95d9-890eab22dd47"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("31291cd7-2b4a-4a44-8552-c76724ea8dcb"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("3eb99ead-ad1b-4f0c-8cff-8a841348f8f4"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("52bbdb07-896d-4690-966d-dffe240d16c1"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("631ad511-07f7-4187-9f02-809661462603"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("7c377762-2bd1-4fd6-8181-32a8108a54ef"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("87c9c8c2-b03a-4f87-bb8b-4311d0f84924"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("8c8da77d-71ac-4e6a-b24d-d5d64b6f99f8"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("9839a6c9-ead9-4775-b3c8-8dc54d9aa626"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("98608468-8258-4366-8bdb-2baf98206bd7"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("a2a19a96-7a34-4c02-ad46-eb9ad40d40d4"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("c895a717-4239-444a-8453-62677b082a1b"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("d97ac9c3-5f88-4283-abec-7c128ec06e08"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("dd6cbabf-8895-42bd-a423-86f912e44850"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("e3d0f7c8-6038-47e0-86fd-98635f7aafc4"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("e4e306ce-0e5d-466e-a774-f5d8aff85b35"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("fde1242c-c9aa-40de-9eeb-7225301e6dbd"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("fe6dac04-b957-43de-ac0c-63bd17106bd8"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("0d4ee8fd-ba43-47b8-b4f4-93a18ad3177e"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("2ae98421-2b32-4e22-9975-00311b4c477e"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("2c19292a-94b0-4732-b76a-f223a8fdc93b"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("395b4fae-ba3b-445e-9634-28725efac330"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("61cf61be-f0a8-47c5-a4ee-9d516f55e2ee"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("661e48b2-f1d7-4062-8d83-cb7ec919288b"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("6e83ced3-219d-4b5e-95b9-abb4ba1e308c"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("7ac9e774-4046-406e-8606-09bc8a4adf6c"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("85d9b0af-45b5-4ce7-9bc2-67bba4b3bae5"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("8a9f9e55-30e9-4d6d-a1ba-d26909708466"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("95d3ce68-0e53-47ff-be3f-1b77daea21fa"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("9c38debb-f170-4497-9b97-283b952124dd"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("baf32513-5cfa-4513-a108-f1c443bc7d0d"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("d16c0eb2-c61e-4120-ab81-5fcbcf3e5ad8"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("eb02f096-b277-439c-bd81-87b5718a4f83"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("f24c6e71-eb01-4498-a1fd-9601a708d32e"));

            migrationBuilder.DeleteData(
                table: "maintenance_services",
                keyColumn: "id",
                keyValue: new Guid("3c3f5bb7-e22e-4dd9-80dd-367356959a89"));

            migrationBuilder.DeleteData(
                table: "maintenance_services",
                keyColumn: "id",
                keyValue: new Guid("6f85e705-01ab-47a6-82c8-db72e322cc7c"));

            migrationBuilder.DeleteData(
                table: "maintenance_services",
                keyColumn: "id",
                keyValue: new Guid("88a905e3-31d2-413c-a756-fec140a85719"));

            migrationBuilder.DeleteData(
                table: "maintenance_services",
                keyColumn: "id",
                keyValue: new Guid("d2b30163-3702-403f-afe7-7cfb4d4f30d2"));

            migrationBuilder.DropColumn(
                name: "store",
                table: "advertisements");

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
    }
}
