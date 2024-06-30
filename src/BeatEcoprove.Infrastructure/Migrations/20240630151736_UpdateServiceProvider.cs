using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BeatEcoprove.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateServiceProvider : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
