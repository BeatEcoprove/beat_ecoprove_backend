using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BeatEcoprove.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class RemoveRequireOnStoreId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: new Guid("282bcd21-e36d-4400-9c63-1ed7da7a1f6b"));

            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: new Guid("49f4f825-cb4b-4a07-88b1-5b3b798faff1"));

            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: new Guid("6758acad-bcb5-4f89-bf6c-875ba7df670f"));

            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: new Guid("e6eca0a7-e03a-4a18-9edb-9b217a0fd89a"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("0bfb4fe7-eb25-4c94-adae-06377c9d6c8e"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("1267b190-e84a-4654-86af-617b410ffe25"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("1ee25379-cf44-42db-918f-077ccaed7738"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("2e6cb66b-46db-4819-8ce2-c3e6246f31b7"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("317ca49a-7f0e-431c-805c-e4d529299371"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("43a73885-2edc-4f45-bbd8-d278997cfea2"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("443af987-2f7b-46a2-833d-5d60d8872f6a"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("49feaf8d-624b-45fe-850f-b42596b0e596"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("4d56539c-295f-4d2d-a435-d3ac69eb0414"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("5721844d-0592-4466-88ea-93ad1737db71"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("6f1ca834-d3de-4aed-a579-bbf76cc94874"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("7103863a-5def-4e73-aa02-b14fcdd4a9c4"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("7831164c-8957-47d2-95b5-1556eae25574"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("785d5807-1c96-4bfb-8343-4969a9fb0a75"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("bcc3506b-7bfb-4810-a76d-c26570472b56"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("c0a3c16b-3c77-493c-b324-6694c616696c"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("d05d17e2-afa2-48ac-85f8-05bcf7c8b967"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("e62003a9-51d3-4214-826e-74515c30a05c"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("ecd8a6e1-950e-4a8c-a19e-9b4ca68a5487"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("ed37e38f-bffa-44f5-819d-ade1db0fcc27"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("f8f3d5a0-dc3d-4fdc-8778-16fd662f7db1"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("040e4649-a99c-4440-bf7c-e0bb2b09bbe0"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("05192070-d8f2-4108-bb42-55d078326839"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("116cbcc8-e518-4066-b4f7-10de0093c1b1"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("3d2286e6-eb7b-4627-80d8-987df4386992"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("3d46c5fe-457e-41ce-ba64-f125f1ab03f0"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("3f4dd4bf-1bdf-46e7-a386-acb6a10429a6"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("40e133f3-7976-4bdc-869c-99c04a8cbbce"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("4305632e-9152-4088-a8fb-d1248e231dd6"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("69e63c85-33ab-49ca-8a32-a37a263aa527"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("7489bb91-83b8-4b78-8a9e-aa39880bca10"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("7ef8de23-f184-4e87-bc67-c2d9a0dfd718"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("80fa22bd-e557-4900-b72a-ccb091a7b2fb"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("bf8c45a4-da89-4b9f-9bd1-cb00f0cdea33"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("e579b374-19ca-4a9d-b041-05dc0364db82"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("eb4fbd34-51c0-4745-9ddc-01ba037b457a"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("f1ab89e1-bd7a-46bb-8b7b-a3113511dc93"));

            migrationBuilder.DeleteData(
                table: "maintenance_services",
                keyColumn: "id",
                keyValue: new Guid("841e8be6-0f75-47ef-8a30-4e4ba1bc4bbe"));

            migrationBuilder.DeleteData(
                table: "maintenance_services",
                keyColumn: "id",
                keyValue: new Guid("ab5e465b-35ce-4fff-be64-b592d2067587"));

            migrationBuilder.DeleteData(
                table: "maintenance_services",
                keyColumn: "id",
                keyValue: new Guid("d7beffbf-82bc-4275-8789-3927b42dee61"));

            migrationBuilder.DeleteData(
                table: "maintenance_services",
                keyColumn: "id",
                keyValue: new Guid("e084b757-79b0-4423-8d3a-5a6f13e717ba"));

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "brands",
                columns: new[] { "id", "brand_avatar", "deleted_at", "name" },
                values: new object[,]
                {
                    { new Guid("282bcd21-e36d-4400-9c63-1ed7da7a1f6b"), "public/default/brands/zippy.png", null, "Zippy" },
                    { new Guid("49f4f825-cb4b-4a07-88b1-5b3b798faff1"), "public/default/brands/losan.png", null, "Losan" },
                    { new Guid("6758acad-bcb5-4f89-bf6c-875ba7df670f"), "public/default/brands/salsa.png", null, "Salsa" },
                    { new Guid("e6eca0a7-e03a-4a18-9edb-9b217a0fd89a"), "public/default/brands/mo.png", null, "MO" }
                });

            migrationBuilder.InsertData(
                table: "colors",
                columns: new[] { "id", "deleted_at", "hex", "name" },
                values: new object[,]
                {
                    { new Guid("0bfb4fe7-eb25-4c94-adae-06377c9d6c8e"), null, "FFC0C0C0", "Cinzento Bebê" },
                    { new Guid("1267b190-e84a-4654-86af-617b410ffe25"), null, "FF948066", "Castanho Claro" },
                    { new Guid("1ee25379-cf44-42db-918f-077ccaed7738"), null, "FFD2AAC5", "Roxo Claro" },
                    { new Guid("2e6cb66b-46db-4819-8ce2-c3e6246f31b7"), null, "FF4C4C4C", "Cinzento Claro" },
                    { new Guid("317ca49a-7f0e-431c-805c-e4d529299371"), null, "FFF9C7C4", "Rosa Claro" },
                    { new Guid("43a73885-2edc-4f45-bbd8-d278997cfea2"), null, "FFC2BC8B", "Verde Lima" },
                    { new Guid("443af987-2f7b-46a2-833d-5d60d8872f6a"), null, "FFC3A572", "Amarelo Claro" },
                    { new Guid("49feaf8d-624b-45fe-850f-b42596b0e596"), null, "FFFFFFFF", "White" },
                    { new Guid("4d56539c-295f-4d2d-a435-d3ac69eb0414"), null, "FFD62598", "Roxo" },
                    { new Guid("5721844d-0592-4466-88ea-93ad1737db71"), null, "FFF2E7D4", "Amarelo Bebê" },
                    { new Guid("6f1ca834-d3de-4aed-a579-bbf76cc94874"), null, "FF8B5F3C", "Castanho Bebê" },
                    { new Guid("7103863a-5def-4e73-aa02-b14fcdd4a9c4"), null, "FFFFE69F", "Amarelo" },
                    { new Guid("7831164c-8957-47d2-95b5-1556eae25574"), null, "FFF58221", "Laranja" },
                    { new Guid("785d5807-1c96-4bfb-8343-4969a9fb0a75"), null, "FFDA252E", "Vermelho" },
                    { new Guid("bcc3506b-7bfb-4810-a76d-c26570472b56"), null, "FF4A2D16", "Castanho" },
                    { new Guid("c0a3c16b-3c77-493c-b324-6694c616696c"), null, "FFBE5967", "Rosa" },
                    { new Guid("d05d17e2-afa2-48ac-85f8-05bcf7c8b967"), null, "FF509C75", "Verde" },
                    { new Guid("e62003a9-51d3-4214-826e-74515c30a05c"), null, "FFFF6D6D", "Vermelho Claro" },
                    { new Guid("ecd8a6e1-950e-4a8c-a19e-9b4ca68a5487"), null, "FF29394A", "Azul Escuro" },
                    { new Guid("ed37e38f-bffa-44f5-819d-ade1db0fcc27"), null, "FF000000", "Black" },
                    { new Guid("f8f3d5a0-dc3d-4fdc-8778-16fd662f7db1"), null, "FF98B3C8", "Azul Claro" }
                });

            migrationBuilder.InsertData(
                table: "maintenance_services",
                columns: new[] { "id", "badge", "deleted_at", "description", "title" },
                values: new object[,]
                {
                    { new Guid("841e8be6-0f75-47ef-8a30-4e4ba1bc4bbe"), "public/default/iron.png", null, "De que forma pretende engomar?", "Engomar" },
                    { new Guid("ab5e465b-35ce-4fff-be64-b592d2067587"), "public/default/dry.png", null, "De que forma pretende secar?", "Secar" },
                    { new Guid("d7beffbf-82bc-4275-8789-3927b42dee61"), "public/default/repair.png", null, "De que forma pretende arranjar a peça?", "Reparar" },
                    { new Guid("e084b757-79b0-4423-8d3a-5a6f13e717ba"), "public/default/wash.png", null, "De que forma pretende lavar?", "Lavar" }
                });

            migrationBuilder.InsertData(
                table: "maintenance_service_actions",
                columns: new[] { "id", "badge", "deleted_at", "Description", "eco_score", "maintenance_service_id", "sustainable_points", "title" },
                values: new object[,]
                {
                    { new Guid("040e4649-a99c-4440-bf7c-e0bb2b09bbe0"), "public/default/iron/less110.png", null, "Engomar a menos de 110ºC", -1, new Guid("841e8be6-0f75-47ef-8a30-4e4ba1bc4bbe"), 1, "A menos de 110ºC" },
                    { new Guid("05192070-d8f2-4108-bb42-55d078326839"), "public/default/dry/machine.png", null, "Secar na máquina", -1, new Guid("ab5e465b-35ce-4fff-be64-b592d2067587"), 1, "Na máquina" },
                    { new Guid("116cbcc8-e518-4066-b4f7-10de0093c1b1"), "public/default/service.png", null, "Escolhe uma lavandaria", 10, new Guid("e084b757-79b0-4423-8d3a-5a6f13e717ba"), 100, "Serviço de lavandaria" },
                    { new Guid("3d2286e6-eb7b-4627-80d8-987df4386992"), "public/default/wash/less50.png", null, "Lavar a menos de 50ºC", -2, new Guid("e084b757-79b0-4423-8d3a-5a6f13e717ba"), 1, "A menos de 50ºC" },
                    { new Guid("3d46c5fe-457e-41ce-ba64-f125f1ab03f0"), "public/default/wash/less30.png", null, "Lavar a menos de 30ºC", -1, new Guid("e084b757-79b0-4423-8d3a-5a6f13e717ba"), 2, "A menos de 30ºC" },
                    { new Guid("3f4dd4bf-1bdf-46e7-a386-acb6a10429a6"), "public/default/wash/less95.png", null, "Lavar a menos de 95ºC", -2, new Guid("e084b757-79b0-4423-8d3a-5a6f13e717ba"), 1, "A menos de 95ºC" },
                    { new Guid("40e133f3-7976-4bdc-869c-99c04a8cbbce"), "public/default/service.png", null, "Escolhe um serviço de engomadoria", 10, new Guid("841e8be6-0f75-47ef-8a30-4e4ba1bc4bbe"), 100, "Serviço de Engomadoria" },
                    { new Guid("4305632e-9152-4088-a8fb-d1248e231dd6"), "public/default/service.png", null, "Escolhe um serviço de Reparação", 10, new Guid("d7beffbf-82bc-4275-8789-3927b42dee61"), 100, "Serviço de Reparação" },
                    { new Guid("69e63c85-33ab-49ca-8a32-a37a263aa527"), "public/default/service.png", null, "Escolhe um serviço de secagem", 10, new Guid("ab5e465b-35ce-4fff-be64-b592d2067587"), 100, "Serviço de Secagem" },
                    { new Guid("7489bb91-83b8-4b78-8a9e-aa39880bca10"), "public/default/iron/less200.png", null, "Engomar a menos de 200ºC", -1, new Guid("841e8be6-0f75-47ef-8a30-4e4ba1bc4bbe"), 1, "A menos de 200ºC" },
                    { new Guid("7ef8de23-f184-4e87-bc67-c2d9a0dfd718"), "public/default/dry/air.png", null, "Secar ao ar livre", 0, new Guid("ab5e465b-35ce-4fff-be64-b592d2067587"), 2, "Ao ar livre" },
                    { new Guid("80fa22bd-e557-4900-b72a-ccb091a7b2fb"), "public/default/iron/less150.png", null, "Engomar a menos de 150ºC", -1, new Guid("841e8be6-0f75-47ef-8a30-4e4ba1bc4bbe"), 1, "A menos de 150ºC" },
                    { new Guid("bf8c45a4-da89-4b9f-9bd1-cb00f0cdea33"), "public/default/wash/dry.png", null, "Lavar a seco", -3, new Guid("e084b757-79b0-4423-8d3a-5a6f13e717ba"), 0, "A seco" },
                    { new Guid("e579b374-19ca-4a9d-b041-05dc0364db82"), "public/default/wash/less70.png", null, "Lavar a menos de 70ºC", -2, new Guid("e084b757-79b0-4423-8d3a-5a6f13e717ba"), 1, "A menos de 70ºC" },
                    { new Guid("eb4fbd34-51c0-4745-9ddc-01ba037b457a"), "public/default/wash/hand.png", null, "Lavar à mão com água e sabão", 10, new Guid("e084b757-79b0-4423-8d3a-5a6f13e717ba"), 100, "Lavar à mão" },
                    { new Guid("f1ab89e1-bd7a-46bb-8b7b-a3113511dc93"), "public/default/repair.png", null, "Arranjar a peça pelo próprio", 2, new Guid("d7beffbf-82bc-4275-8789-3927b42dee61"), 3, "Pelo Próprio" }
                });
        }
    }
}
