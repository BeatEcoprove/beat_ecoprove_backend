using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BeatEcoprove.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateOrderSolveNullWorkerId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_store_orders_workers_assigned_worker",
                table: "store_orders");

            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: new Guid("298bfa53-cc2e-4876-8761-71af6b299ff8"));

            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: new Guid("2f6f9a18-2b69-4d0e-bc9a-176c7b08607e"));

            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: new Guid("95e718b5-533e-44ca-b1e4-c724701ae1d7"));

            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: new Guid("be9f14ae-5f69-47eb-b426-1736b7cafafe"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("16292f3b-76d2-4b50-ab4e-92de2b592b41"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("20b135e4-4e0b-4dfc-93a1-f93536e9c648"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("2a1a4fc3-de1c-419b-bf3c-fda466092409"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("46fb1a51-d814-4bd6-a376-8e18bdbf7224"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("4b92f17a-4a50-4899-96a8-737a179f3890"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("50677230-1e2f-4dc3-9708-cd786bb815c5"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("5d719aa9-4b7d-4c05-a14d-6f986088af87"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("65a4a941-58f1-4181-b687-e606150c37bb"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("6f004ead-ac04-4cef-bf9e-a11492a1cd56"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("74350af4-390b-47e3-b4a7-c5984ff8791a"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("7b8690e2-8cf1-4b43-8c7a-da47682062fe"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("7bcc70f3-b57c-412d-a9d6-ae2aa1789e8f"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("ab83331f-bd1a-4083-b4e6-a58b4aa21aed"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("bb58aec9-bad1-4081-ad5e-9e4c2dc937d4"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("bbf5b09d-d6a3-43b6-81c7-6cf2fa2f2648"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("c5b30e63-9fd4-48b8-aef6-cfa67de063e6"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("c6e6efc0-f16a-4931-a4c6-fc92d5a7dad3"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("cc478c8a-e196-4856-803c-98a071f25e93"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("ced8221f-cc95-4e2c-b5a1-323ae57aa992"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("f42b7cd4-cc93-4ad9-bba4-a5884614e499"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("fff2fd3a-1f7d-404f-8fd7-0c16e8ee64a4"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("075d10d9-0041-4458-af69-d3e8961e4e59"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("16e95161-cb63-45af-ab7c-75b13e145b2e"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("2b3ebd1c-f96b-4c2d-86fd-14521f438691"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("3cfc740e-334e-43e6-a561-893b4712ea80"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("451fe20e-6d7a-41e8-a413-73e8a2091113"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("4fe1ebce-0e77-4e6f-b847-f4332c5bea60"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("51e4a6ea-1004-486a-82ea-6afcbe619943"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("5eacc778-611c-43ab-947a-34d056636eb4"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("66bf88d5-a99d-45f5-bf4d-c36870e33342"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("6f45fef6-a548-4754-b326-8b6463405c20"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("74afd84f-e817-4aec-ab89-5d11c32955da"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("810a231d-cd08-43cd-8c83-5c102f42f118"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("a2495f78-ae7b-4eb7-b85f-51f1aedd668c"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("d52569d4-9097-4e06-ad3e-a21df000f00b"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("d7ab3e0a-e18d-462d-a4bd-17e1c7d0f889"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("ecbd01e7-3322-4c0a-9c08-5eae2beda57e"));

            migrationBuilder.DeleteData(
                table: "maintenance_services",
                keyColumn: "id",
                keyValue: new Guid("23db32c4-9e98-434a-8b9b-e50a6b4ecf71"));

            migrationBuilder.DeleteData(
                table: "maintenance_services",
                keyColumn: "id",
                keyValue: new Guid("942edccf-f09f-48ed-aaf8-471217bb8978"));

            migrationBuilder.DeleteData(
                table: "maintenance_services",
                keyColumn: "id",
                keyValue: new Guid("f81b87a0-29be-4d56-b1e8-5b507c6a91a0"));

            migrationBuilder.DeleteData(
                table: "maintenance_services",
                keyColumn: "id",
                keyValue: new Guid("fea92981-527b-44f0-a782-f03331998d3b"));

            migrationBuilder.AlterColumn<Guid>(
                name: "assigned_worker",
                table: "store_orders",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

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

            migrationBuilder.AddForeignKey(
                name: "FK_store_orders_workers_assigned_worker",
                table: "store_orders",
                column: "assigned_worker",
                principalTable: "workers",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_store_orders_workers_assigned_worker",
                table: "store_orders");

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

            migrationBuilder.AlterColumn<Guid>(
                name: "assigned_worker",
                table: "store_orders",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "brands",
                columns: new[] { "id", "brand_avatar", "deleted_at", "name" },
                values: new object[,]
                {
                    { new Guid("298bfa53-cc2e-4876-8761-71af6b299ff8"), "public/default/brands/salsa.png", null, "Salsa" },
                    { new Guid("2f6f9a18-2b69-4d0e-bc9a-176c7b08607e"), "public/default/brands/mo.png", null, "MO" },
                    { new Guid("95e718b5-533e-44ca-b1e4-c724701ae1d7"), "public/default/brands/zippy.png", null, "Zippy" },
                    { new Guid("be9f14ae-5f69-47eb-b426-1736b7cafafe"), "public/default/brands/losan.png", null, "Losan" }
                });

            migrationBuilder.InsertData(
                table: "colors",
                columns: new[] { "id", "deleted_at", "hex", "name" },
                values: new object[,]
                {
                    { new Guid("16292f3b-76d2-4b50-ab4e-92de2b592b41"), null, "FF000000", "Black" },
                    { new Guid("20b135e4-4e0b-4dfc-93a1-f93536e9c648"), null, "FFFF6D6D", "Vermelho Claro" },
                    { new Guid("2a1a4fc3-de1c-419b-bf3c-fda466092409"), null, "FFF9C7C4", "Rosa Claro" },
                    { new Guid("46fb1a51-d814-4bd6-a376-8e18bdbf7224"), null, "FFFFE69F", "Amarelo" },
                    { new Guid("4b92f17a-4a50-4899-96a8-737a179f3890"), null, "FF29394A", "Azul Escuro" },
                    { new Guid("50677230-1e2f-4dc3-9708-cd786bb815c5"), null, "FFC3A572", "Amarelo Claro" },
                    { new Guid("5d719aa9-4b7d-4c05-a14d-6f986088af87"), null, "FF4A2D16", "Castanho" },
                    { new Guid("65a4a941-58f1-4181-b687-e606150c37bb"), null, "FFF2E7D4", "Amarelo Bebê" },
                    { new Guid("6f004ead-ac04-4cef-bf9e-a11492a1cd56"), null, "FF4C4C4C", "Cinzento Claro" },
                    { new Guid("74350af4-390b-47e3-b4a7-c5984ff8791a"), null, "FFD62598", "Roxo" },
                    { new Guid("7b8690e2-8cf1-4b43-8c7a-da47682062fe"), null, "FF98B3C8", "Azul Claro" },
                    { new Guid("7bcc70f3-b57c-412d-a9d6-ae2aa1789e8f"), null, "FF8B5F3C", "Castanho Bebê" },
                    { new Guid("ab83331f-bd1a-4083-b4e6-a58b4aa21aed"), null, "FFD2AAC5", "Roxo Claro" },
                    { new Guid("bb58aec9-bad1-4081-ad5e-9e4c2dc937d4"), null, "FF509C75", "Verde" },
                    { new Guid("bbf5b09d-d6a3-43b6-81c7-6cf2fa2f2648"), null, "FFDA252E", "Vermelho" },
                    { new Guid("c5b30e63-9fd4-48b8-aef6-cfa67de063e6"), null, "FFBE5967", "Rosa" },
                    { new Guid("c6e6efc0-f16a-4931-a4c6-fc92d5a7dad3"), null, "FFFFFFFF", "White" },
                    { new Guid("cc478c8a-e196-4856-803c-98a071f25e93"), null, "FFC2BC8B", "Verde Lima" },
                    { new Guid("ced8221f-cc95-4e2c-b5a1-323ae57aa992"), null, "FFF58221", "Laranja" },
                    { new Guid("f42b7cd4-cc93-4ad9-bba4-a5884614e499"), null, "FF948066", "Castanho Claro" },
                    { new Guid("fff2fd3a-1f7d-404f-8fd7-0c16e8ee64a4"), null, "FFC0C0C0", "Cinzento Bebê" }
                });

            migrationBuilder.InsertData(
                table: "maintenance_services",
                columns: new[] { "id", "badge", "deleted_at", "description", "title" },
                values: new object[,]
                {
                    { new Guid("23db32c4-9e98-434a-8b9b-e50a6b4ecf71"), "public/default/repair.png", null, "De que forma pretende arranjar a peça?", "Reparar" },
                    { new Guid("942edccf-f09f-48ed-aaf8-471217bb8978"), "public/default/iron.png", null, "De que forma pretende engomar?", "Engomar" },
                    { new Guid("f81b87a0-29be-4d56-b1e8-5b507c6a91a0"), "public/default/dry.png", null, "De que forma pretende secar?", "Secar" },
                    { new Guid("fea92981-527b-44f0-a782-f03331998d3b"), "public/default/wash.png", null, "De que forma pretende lavar?", "Lavar" }
                });

            migrationBuilder.InsertData(
                table: "maintenance_service_actions",
                columns: new[] { "id", "badge", "deleted_at", "Description", "eco_score", "maintenance_service_id", "sustainable_points", "title" },
                values: new object[,]
                {
                    { new Guid("075d10d9-0041-4458-af69-d3e8961e4e59"), "public/default/dry/air.png", null, "Secar ao ar livre", 0, new Guid("f81b87a0-29be-4d56-b1e8-5b507c6a91a0"), 2, "Ao ar livre" },
                    { new Guid("16e95161-cb63-45af-ab7c-75b13e145b2e"), "public/default/dry/machine.png", null, "Secar na máquina", -1, new Guid("f81b87a0-29be-4d56-b1e8-5b507c6a91a0"), 1, "Na máquina" },
                    { new Guid("2b3ebd1c-f96b-4c2d-86fd-14521f438691"), "public/default/service.png", null, "Escolhe um serviço de Reparação", 10, new Guid("23db32c4-9e98-434a-8b9b-e50a6b4ecf71"), 100, "Serviço de Reparação" },
                    { new Guid("3cfc740e-334e-43e6-a561-893b4712ea80"), "public/default/wash/less70.png", null, "Lavar a menos de 70ºC", -2, new Guid("fea92981-527b-44f0-a782-f03331998d3b"), 1, "A menos de 70ºC" },
                    { new Guid("451fe20e-6d7a-41e8-a413-73e8a2091113"), "public/default/wash/less50.png", null, "Lavar a menos de 50ºC", -2, new Guid("fea92981-527b-44f0-a782-f03331998d3b"), 1, "A menos de 50ºC" },
                    { new Guid("4fe1ebce-0e77-4e6f-b847-f4332c5bea60"), "public/default/wash/hand.png", null, "Lavar à mão com água e sabão", 10, new Guid("fea92981-527b-44f0-a782-f03331998d3b"), 100, "Lavar à mão" },
                    { new Guid("51e4a6ea-1004-486a-82ea-6afcbe619943"), "public/default/iron/less200.png", null, "Engomar a menos de 200ºC", -1, new Guid("942edccf-f09f-48ed-aaf8-471217bb8978"), 1, "A menos de 200ºC" },
                    { new Guid("5eacc778-611c-43ab-947a-34d056636eb4"), "public/default/service.png", null, "Escolhe uma lavandaria", 10, new Guid("fea92981-527b-44f0-a782-f03331998d3b"), 100, "Serviço de lavandaria" },
                    { new Guid("66bf88d5-a99d-45f5-bf4d-c36870e33342"), "public/default/service.png", null, "Escolhe um serviço de engomadoria", 10, new Guid("942edccf-f09f-48ed-aaf8-471217bb8978"), 100, "Serviço de Engomadoria" },
                    { new Guid("6f45fef6-a548-4754-b326-8b6463405c20"), "public/default/wash/less95.png", null, "Lavar a menos de 95ºC", -2, new Guid("fea92981-527b-44f0-a782-f03331998d3b"), 1, "A menos de 95ºC" },
                    { new Guid("74afd84f-e817-4aec-ab89-5d11c32955da"), "public/default/repair.png", null, "Arranjar a peça pelo próprio", 2, new Guid("23db32c4-9e98-434a-8b9b-e50a6b4ecf71"), 3, "Pelo Próprio" },
                    { new Guid("810a231d-cd08-43cd-8c83-5c102f42f118"), "public/default/service.png", null, "Escolhe um serviço de secagem", 10, new Guid("f81b87a0-29be-4d56-b1e8-5b507c6a91a0"), 100, "Serviço de Secagem" },
                    { new Guid("a2495f78-ae7b-4eb7-b85f-51f1aedd668c"), "public/default/wash/less30.png", null, "Lavar a menos de 30ºC", -1, new Guid("fea92981-527b-44f0-a782-f03331998d3b"), 2, "A menos de 30ºC" },
                    { new Guid("d52569d4-9097-4e06-ad3e-a21df000f00b"), "public/default/iron/less110.png", null, "Engomar a menos de 110ºC", -1, new Guid("942edccf-f09f-48ed-aaf8-471217bb8978"), 1, "A menos de 110ºC" },
                    { new Guid("d7ab3e0a-e18d-462d-a4bd-17e1c7d0f889"), "public/default/iron/less150.png", null, "Engomar a menos de 150ºC", -1, new Guid("942edccf-f09f-48ed-aaf8-471217bb8978"), 1, "A menos de 150ºC" },
                    { new Guid("ecbd01e7-3322-4c0a-9c08-5eae2beda57e"), "public/default/wash/dry.png", null, "Lavar a seco", -3, new Guid("fea92981-527b-44f0-a782-f03331998d3b"), 0, "A seco" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_store_orders_workers_assigned_worker",
                table: "store_orders",
                column: "assigned_worker",
                principalTable: "workers",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
