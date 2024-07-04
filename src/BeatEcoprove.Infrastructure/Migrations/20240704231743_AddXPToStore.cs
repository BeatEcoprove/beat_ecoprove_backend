using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BeatEcoprove.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddXPToStore : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<double>(
                name: "xp",
                table: "stores",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.InsertData(
                table: "brands",
                columns: new[] { "id", "brand_avatar", "deleted_at", "name" },
                values: new object[,]
                {
                    { new Guid("0d810f3b-2f17-49a0-9faf-320c30393e22"), "public/default/brands/mo.png", null, "MO" },
                    { new Guid("1066f7be-78b8-4704-b444-bc6c11057b25"), "public/default/brands/zippy.png", null, "Zippy" },
                    { new Guid("a0a204c5-067c-46b8-8ad8-9f72a1100eeb"), "public/default/brands/salsa.png", null, "Salsa" },
                    { new Guid("ae921096-f72b-4b77-8562-ad49ab137d68"), "public/default/brands/losan.png", null, "Losan" }
                });

            migrationBuilder.InsertData(
                table: "colors",
                columns: new[] { "id", "deleted_at", "hex", "name" },
                values: new object[,]
                {
                    { new Guid("02e1621a-31de-428f-bfe8-12ce16303cfa"), null, "FF29394A", "Azul Escuro" },
                    { new Guid("0dc52312-73b4-45cd-97c2-7ba0a0684195"), null, "FFDA252E", "Vermelho" },
                    { new Guid("20648049-1121-4037-912a-0b5ae4fe8ca1"), null, "FF4C4C4C", "Cinzento Claro" },
                    { new Guid("21077620-0f70-4b79-adcb-26747d1f5d03"), null, "FFC3A572", "Amarelo Claro" },
                    { new Guid("27b5e9e4-c2cc-487e-a47e-42ccc0ff7a82"), null, "FFD2AAC5", "Roxo Claro" },
                    { new Guid("460345a7-22c3-4739-92a5-bc15b7dbc8ec"), null, "FFC2BC8B", "Verde Lima" },
                    { new Guid("607c29b2-e0a8-4c0e-9903-a9d95e335135"), null, "FF98B3C8", "Azul Claro" },
                    { new Guid("64332e3c-fbff-403d-b450-6cf764d67a98"), null, "FFD62598", "Roxo" },
                    { new Guid("679480a2-707b-45ca-9bd6-cc8643877fa6"), null, "FFFF6D6D", "Vermelho Claro" },
                    { new Guid("737af9e9-d7e6-45a3-93db-66352b62d1af"), null, "FFBE5967", "Rosa" },
                    { new Guid("9039f788-7265-474d-b352-302233dea969"), null, "FF8B5F3C", "Castanho Bebê" },
                    { new Guid("9169de9c-87f0-40a7-8381-8a5b1107ad19"), null, "FFFFE69F", "Amarelo" },
                    { new Guid("92957cca-6e3b-4512-a813-243f0da7b148"), null, "FFF9C7C4", "Rosa Claro" },
                    { new Guid("9b4ec4c5-cb66-4b10-a433-a85d72652593"), null, "FF948066", "Castanho Claro" },
                    { new Guid("a3895e31-4048-48fb-83d1-8315448b12c1"), null, "FFFFFFFF", "White" },
                    { new Guid("b1c577cc-498a-4f54-9c30-54a0eef365a3"), null, "FF000000", "Black" },
                    { new Guid("c114ae9d-fe77-437e-a3ca-44d5a606efd2"), null, "FFC0C0C0", "Cinzento Bebê" },
                    { new Guid("c24acdb0-b7ff-4dd6-bd06-6f3f7bc13e01"), null, "FFF58221", "Laranja" },
                    { new Guid("dfb2b324-6205-4200-b617-7371495b9b9c"), null, "FFF2E7D4", "Amarelo Bebê" },
                    { new Guid("e18956f5-22a8-4a42-be44-a17227a05958"), null, "FF509C75", "Verde" },
                    { new Guid("e72157a6-64f3-4d47-ac2b-e67dd9148f04"), null, "FF4A2D16", "Castanho" }
                });

            migrationBuilder.InsertData(
                table: "maintenance_services",
                columns: new[] { "id", "badge", "deleted_at", "description", "title" },
                values: new object[,]
                {
                    { new Guid("2b78eb70-b39a-40c7-a9c4-0d6294c8da68"), "public/default/iron.png", null, "De que forma pretende engomar?", "Engomar" },
                    { new Guid("5cf609b9-227d-42e8-8dba-6a30da3fdab2"), "public/default/dry.png", null, "De que forma pretende secar?", "Secar" },
                    { new Guid("8aaa293b-bc68-426a-bafb-0a5fc1c4244e"), "public/default/repair.png", null, "De que forma pretende arranjar a peça?", "Reparar" },
                    { new Guid("9197ddd7-6f01-4eb6-8ef4-4412fcb7cb1f"), "public/default/wash.png", null, "De que forma pretende lavar?", "Lavar" }
                });

            migrationBuilder.InsertData(
                table: "maintenance_service_actions",
                columns: new[] { "id", "badge", "deleted_at", "Description", "eco_score", "maintenance_service_id", "sustainable_points", "title" },
                values: new object[,]
                {
                    { new Guid("0489437f-e69d-46b4-8efd-71a49333550d"), "public/default/iron/less150.png", null, "Engomar a menos de 150ºC", -1, new Guid("2b78eb70-b39a-40c7-a9c4-0d6294c8da68"), 1, "A menos de 150ºC" },
                    { new Guid("320d38a2-9067-49c4-849b-db85766a8c2b"), "public/default/wash/dry.png", null, "Lavar a seco", -3, new Guid("9197ddd7-6f01-4eb6-8ef4-4412fcb7cb1f"), 0, "A seco" },
                    { new Guid("344a0c07-eb30-490c-a7e8-eda8ac310d9f"), "public/default/dry/air.png", null, "Secar ao ar livre", 0, new Guid("5cf609b9-227d-42e8-8dba-6a30da3fdab2"), 2, "Ao ar livre" },
                    { new Guid("50fdf9dd-a510-452f-9149-61db12696b79"), "public/default/iron/less110.png", null, "Engomar a menos de 110ºC", -1, new Guid("2b78eb70-b39a-40c7-a9c4-0d6294c8da68"), 1, "A menos de 110ºC" },
                    { new Guid("636302c3-a457-400c-8352-2852bf610ebf"), "public/default/iron/less200.png", null, "Engomar a menos de 200ºC", -1, new Guid("2b78eb70-b39a-40c7-a9c4-0d6294c8da68"), 1, "A menos de 200ºC" },
                    { new Guid("a41ee2b3-70ab-4574-9c32-0ee81b7b0e9f"), "public/default/repair.png", null, "Arranjar a peça pelo próprio", 2, new Guid("8aaa293b-bc68-426a-bafb-0a5fc1c4244e"), 3, "Pelo Próprio" },
                    { new Guid("a7910197-97ba-441a-a4b9-9353650b22ad"), "public/default/wash/less30.png", null, "Lavar a menos de 30ºC", -1, new Guid("9197ddd7-6f01-4eb6-8ef4-4412fcb7cb1f"), 2, "A menos de 30ºC" },
                    { new Guid("a85c6baa-0cea-441e-8545-bb99877118e1"), "public/default/dry/machine.png", null, "Secar na máquina", -1, new Guid("5cf609b9-227d-42e8-8dba-6a30da3fdab2"), 1, "Na máquina" },
                    { new Guid("aeef60ff-7006-49b0-bc9c-26b049411434"), "public/default/wash/hand.png", null, "Lavar à mão com água e sabão", 10, new Guid("9197ddd7-6f01-4eb6-8ef4-4412fcb7cb1f"), 100, "Lavar à mão" },
                    { new Guid("b8ff55b2-af07-47c0-9428-5e24596afc68"), "public/default/service.png", null, "Escolhe uma lavandaria", 10, new Guid("9197ddd7-6f01-4eb6-8ef4-4412fcb7cb1f"), 100, "Serviço de lavandaria" },
                    { new Guid("bab6b0f1-4841-4c0a-b31d-35cb0d794a82"), "public/default/wash/less50.png", null, "Lavar a menos de 50ºC", -2, new Guid("9197ddd7-6f01-4eb6-8ef4-4412fcb7cb1f"), 1, "A menos de 50ºC" },
                    { new Guid("bf2026c0-359c-423d-9216-0edd70b874dc"), "public/default/service.png", null, "Escolhe um serviço de secagem", 10, new Guid("5cf609b9-227d-42e8-8dba-6a30da3fdab2"), 100, "Serviço de Secagem" },
                    { new Guid("bf296acc-c032-42b3-8ae3-8b08addfd66b"), "public/default/wash/less95.png", null, "Lavar a menos de 95ºC", -2, new Guid("9197ddd7-6f01-4eb6-8ef4-4412fcb7cb1f"), 1, "A menos de 95ºC" },
                    { new Guid("c1794ceb-9750-411d-8a48-f047f52253c9"), "public/default/wash/less70.png", null, "Lavar a menos de 70ºC", -2, new Guid("9197ddd7-6f01-4eb6-8ef4-4412fcb7cb1f"), 1, "A menos de 70ºC" },
                    { new Guid("f11a3aef-3d2a-490c-b7ee-02e695d6c47c"), "public/default/service.png", null, "Escolhe um serviço de engomadoria", 10, new Guid("2b78eb70-b39a-40c7-a9c4-0d6294c8da68"), 100, "Serviço de Engomadoria" },
                    { new Guid("f50a6b8b-5861-40ba-9084-3d7f1ff98253"), "public/default/service.png", null, "Escolhe um serviço de Reparação", 10, new Guid("8aaa293b-bc68-426a-bafb-0a5fc1c4244e"), 100, "Serviço de Reparação" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: new Guid("0d810f3b-2f17-49a0-9faf-320c30393e22"));

            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: new Guid("1066f7be-78b8-4704-b444-bc6c11057b25"));

            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: new Guid("a0a204c5-067c-46b8-8ad8-9f72a1100eeb"));

            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: new Guid("ae921096-f72b-4b77-8562-ad49ab137d68"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("02e1621a-31de-428f-bfe8-12ce16303cfa"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("0dc52312-73b4-45cd-97c2-7ba0a0684195"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("20648049-1121-4037-912a-0b5ae4fe8ca1"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("21077620-0f70-4b79-adcb-26747d1f5d03"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("27b5e9e4-c2cc-487e-a47e-42ccc0ff7a82"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("460345a7-22c3-4739-92a5-bc15b7dbc8ec"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("607c29b2-e0a8-4c0e-9903-a9d95e335135"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("64332e3c-fbff-403d-b450-6cf764d67a98"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("679480a2-707b-45ca-9bd6-cc8643877fa6"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("737af9e9-d7e6-45a3-93db-66352b62d1af"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("9039f788-7265-474d-b352-302233dea969"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("9169de9c-87f0-40a7-8381-8a5b1107ad19"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("92957cca-6e3b-4512-a813-243f0da7b148"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("9b4ec4c5-cb66-4b10-a433-a85d72652593"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("a3895e31-4048-48fb-83d1-8315448b12c1"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("b1c577cc-498a-4f54-9c30-54a0eef365a3"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("c114ae9d-fe77-437e-a3ca-44d5a606efd2"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("c24acdb0-b7ff-4dd6-bd06-6f3f7bc13e01"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("dfb2b324-6205-4200-b617-7371495b9b9c"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("e18956f5-22a8-4a42-be44-a17227a05958"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("e72157a6-64f3-4d47-ac2b-e67dd9148f04"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("0489437f-e69d-46b4-8efd-71a49333550d"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("320d38a2-9067-49c4-849b-db85766a8c2b"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("344a0c07-eb30-490c-a7e8-eda8ac310d9f"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("50fdf9dd-a510-452f-9149-61db12696b79"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("636302c3-a457-400c-8352-2852bf610ebf"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("a41ee2b3-70ab-4574-9c32-0ee81b7b0e9f"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("a7910197-97ba-441a-a4b9-9353650b22ad"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("a85c6baa-0cea-441e-8545-bb99877118e1"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("aeef60ff-7006-49b0-bc9c-26b049411434"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("b8ff55b2-af07-47c0-9428-5e24596afc68"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("bab6b0f1-4841-4c0a-b31d-35cb0d794a82"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("bf2026c0-359c-423d-9216-0edd70b874dc"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("bf296acc-c032-42b3-8ae3-8b08addfd66b"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("c1794ceb-9750-411d-8a48-f047f52253c9"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("f11a3aef-3d2a-490c-b7ee-02e695d6c47c"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("f50a6b8b-5861-40ba-9084-3d7f1ff98253"));

            migrationBuilder.DeleteData(
                table: "maintenance_services",
                keyColumn: "id",
                keyValue: new Guid("2b78eb70-b39a-40c7-a9c4-0d6294c8da68"));

            migrationBuilder.DeleteData(
                table: "maintenance_services",
                keyColumn: "id",
                keyValue: new Guid("5cf609b9-227d-42e8-8dba-6a30da3fdab2"));

            migrationBuilder.DeleteData(
                table: "maintenance_services",
                keyColumn: "id",
                keyValue: new Guid("8aaa293b-bc68-426a-bafb-0a5fc1c4244e"));

            migrationBuilder.DeleteData(
                table: "maintenance_services",
                keyColumn: "id",
                keyValue: new Guid("9197ddd7-6f01-4eb6-8ef4-4412fcb7cb1f"));

            migrationBuilder.DropColumn(
                name: "xp",
                table: "stores");

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
        }
    }
}
