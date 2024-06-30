using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BeatEcoprove.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddEmployee : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: new Guid("45b473e7-3855-4eb6-8987-2f6e0d35559c"));

            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: new Guid("79d7ff9d-fa19-4825-81ab-72b7172c4d42"));

            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: new Guid("8edb5dfa-99b6-492b-a581-58da50503d2c"));

            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: new Guid("ba546719-c339-4b86-89e1-c8e7879dd527"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("0426a6fd-264e-421a-adbe-2f44409bf7ea"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("0c1972f5-059f-4ca2-ae89-975ce61b7741"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("0e0ac4a2-ade1-450a-a0d7-bdeb37ec9069"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("1250b7e5-9866-41d1-89d8-f70b792b9efb"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("2a99775f-80a8-4da3-b949-a9b5172a8c5e"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("395eccb7-3b6d-47ac-b3af-949db300b0ac"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("3fe47bee-47d7-419c-982b-bce032705741"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("51b10699-f8c5-4647-be68-dd918c8b8d00"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("6033cc85-5cf9-4963-a570-99cb03b13a0c"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("7bf4b91d-332c-4247-801b-9f8a8d7d7312"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("7bffdc03-bbd4-46d7-ad85-c5d08a9a6714"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("98d6bcde-b053-44a5-b5a0-078927189996"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("aeb96645-7f18-4f97-b6fd-3fc1a673a3b5"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("af33eece-cd39-42d8-93a4-2ae7669c5045"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("b1ff4444-c528-4962-b112-16177882181d"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("b97d886c-4571-4608-99de-965f7b88562f"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("bcf5ba76-ff2d-4a64-b219-dd58bba9cb39"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("c8d474b8-2402-4cc9-9dbb-610ffb1388a0"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("ed3d556a-ccd1-4fb7-b29d-9f981ad9ca13"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("f0ddb75b-89d0-479c-a86c-d21b18378580"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("fa533f65-2beb-44a8-b9f0-ac8f4c652a41"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("0e23aac5-279f-4f12-b5e5-b5c7720154f0"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("0f29baea-a215-44d8-a1ed-f5d57cfc861d"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("0f8455b7-8781-44a0-ae18-3ef997e22edd"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("106b6c7a-2640-4eda-bf23-7f7879b950df"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("20475405-cb3d-488c-8d4b-6554f86aff18"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("2662c18f-4ca2-4907-b8be-29cb78d690da"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("749a3f3c-efae-40c7-ad22-7ba1017889c2"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("871878c9-dee7-4300-9321-3bdb1fe3491a"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("9f3ecfa0-1f0d-469e-98b1-7ef1068608b6"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("a553e522-01dc-48c5-863d-2e0cb8d9c064"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("a6ea7c10-6d7b-4eaa-8592-88534aacd4fa"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("ad6a0245-014e-42b0-93ad-faa290036385"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("c64b03a6-6c2a-445b-a8c9-6cea021f3eed"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("eca039af-3fac-4f2d-a958-2dc8b908f234"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("ed8a69da-2c9c-475a-9523-bd3226833a89"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("fb080307-e181-4eef-943f-f8936cf4ac40"));

            migrationBuilder.DeleteData(
                table: "maintenance_services",
                keyColumn: "id",
                keyValue: new Guid("09b67d1f-e92d-4c16-9ae2-779b92741676"));

            migrationBuilder.DeleteData(
                table: "maintenance_services",
                keyColumn: "id",
                keyValue: new Guid("9c1f97ce-eb02-42b8-a0a8-75511c61e0ff"));

            migrationBuilder.DeleteData(
                table: "maintenance_services",
                keyColumn: "id",
                keyValue: new Guid("bcde9aa7-6090-46ff-9a68-90d5e9c1e5c5"));

            migrationBuilder.DeleteData(
                table: "maintenance_services",
                keyColumn: "id",
                keyValue: new Guid("bf3e38c6-88b6-4b51-936a-aceec5706470"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "brands",
                columns: new[] { "id", "brand_avatar", "deleted_at", "name" },
                values: new object[,]
                {
                    { new Guid("45b473e7-3855-4eb6-8987-2f6e0d35559c"), "public/default/brands/mo.png", null, "MO" },
                    { new Guid("79d7ff9d-fa19-4825-81ab-72b7172c4d42"), "public/default/brands/zippy.png", null, "Zippy" },
                    { new Guid("8edb5dfa-99b6-492b-a581-58da50503d2c"), "public/default/brands/salsa.png", null, "Salsa" },
                    { new Guid("ba546719-c339-4b86-89e1-c8e7879dd527"), "public/default/brands/losan.png", null, "Losan" }
                });

            migrationBuilder.InsertData(
                table: "colors",
                columns: new[] { "id", "deleted_at", "hex", "name" },
                values: new object[,]
                {
                    { new Guid("0426a6fd-264e-421a-adbe-2f44409bf7ea"), null, "FFFFFFFF", "White" },
                    { new Guid("0c1972f5-059f-4ca2-ae89-975ce61b7741"), null, "FFF58221", "Laranja" },
                    { new Guid("0e0ac4a2-ade1-450a-a0d7-bdeb37ec9069"), null, "FF948066", "Castanho Claro" },
                    { new Guid("1250b7e5-9866-41d1-89d8-f70b792b9efb"), null, "FFC3A572", "Amarelo Claro" },
                    { new Guid("2a99775f-80a8-4da3-b949-a9b5172a8c5e"), null, "FFF9C7C4", "Rosa Claro" },
                    { new Guid("395eccb7-3b6d-47ac-b3af-949db300b0ac"), null, "FFC0C0C0", "Cinzento Bebê" },
                    { new Guid("3fe47bee-47d7-419c-982b-bce032705741"), null, "FFFFE69F", "Amarelo" },
                    { new Guid("51b10699-f8c5-4647-be68-dd918c8b8d00"), null, "FFF2E7D4", "Amarelo Bebê" },
                    { new Guid("6033cc85-5cf9-4963-a570-99cb03b13a0c"), null, "FF4C4C4C", "Cinzento Claro" },
                    { new Guid("7bf4b91d-332c-4247-801b-9f8a8d7d7312"), null, "FF000000", "Black" },
                    { new Guid("7bffdc03-bbd4-46d7-ad85-c5d08a9a6714"), null, "FFD62598", "Roxo" },
                    { new Guid("98d6bcde-b053-44a5-b5a0-078927189996"), null, "FF29394A", "Azul Escuro" },
                    { new Guid("aeb96645-7f18-4f97-b6fd-3fc1a673a3b5"), null, "FFD2AAC5", "Roxo Claro" },
                    { new Guid("af33eece-cd39-42d8-93a4-2ae7669c5045"), null, "FFC2BC8B", "Verde Lima" },
                    { new Guid("b1ff4444-c528-4962-b112-16177882181d"), null, "FF4A2D16", "Castanho" },
                    { new Guid("b97d886c-4571-4608-99de-965f7b88562f"), null, "FFDA252E", "Vermelho" },
                    { new Guid("bcf5ba76-ff2d-4a64-b219-dd58bba9cb39"), null, "FF8B5F3C", "Castanho Bebê" },
                    { new Guid("c8d474b8-2402-4cc9-9dbb-610ffb1388a0"), null, "FFBE5967", "Rosa" },
                    { new Guid("ed3d556a-ccd1-4fb7-b29d-9f981ad9ca13"), null, "FFFF6D6D", "Vermelho Claro" },
                    { new Guid("f0ddb75b-89d0-479c-a86c-d21b18378580"), null, "FF509C75", "Verde" },
                    { new Guid("fa533f65-2beb-44a8-b9f0-ac8f4c652a41"), null, "FF98B3C8", "Azul Claro" }
                });

            migrationBuilder.InsertData(
                table: "maintenance_services",
                columns: new[] { "id", "badge", "deleted_at", "description", "title" },
                values: new object[,]
                {
                    { new Guid("09b67d1f-e92d-4c16-9ae2-779b92741676"), "public/default/wash.png", null, "De que forma pretende lavar?", "Lavar" },
                    { new Guid("9c1f97ce-eb02-42b8-a0a8-75511c61e0ff"), "public/default/repair.png", null, "De que forma pretende arranjar a peça?", "Reparar" },
                    { new Guid("bcde9aa7-6090-46ff-9a68-90d5e9c1e5c5"), "public/default/iron.png", null, "De que forma pretende engomar?", "Engomar" },
                    { new Guid("bf3e38c6-88b6-4b51-936a-aceec5706470"), "public/default/dry.png", null, "De que forma pretende secar?", "Secar" }
                });

            migrationBuilder.InsertData(
                table: "maintenance_service_actions",
                columns: new[] { "id", "badge", "deleted_at", "Description", "eco_score", "maintenance_service_id", "sustainable_points", "title" },
                values: new object[,]
                {
                    { new Guid("0e23aac5-279f-4f12-b5e5-b5c7720154f0"), "public/default/service.png", null, "Escolhe um serviço de Reparação", 10, new Guid("9c1f97ce-eb02-42b8-a0a8-75511c61e0ff"), 100, "Serviço de Reparação" },
                    { new Guid("0f29baea-a215-44d8-a1ed-f5d57cfc861d"), "public/default/wash/less95.png", null, "Lavar a menos de 95ºC", -2, new Guid("09b67d1f-e92d-4c16-9ae2-779b92741676"), 1, "A menos de 95ºC" },
                    { new Guid("0f8455b7-8781-44a0-ae18-3ef997e22edd"), "public/default/wash/dry.png", null, "Lavar a seco", -3, new Guid("09b67d1f-e92d-4c16-9ae2-779b92741676"), 0, "A seco" },
                    { new Guid("106b6c7a-2640-4eda-bf23-7f7879b950df"), "public/default/wash/less50.png", null, "Lavar a menos de 50ºC", -2, new Guid("09b67d1f-e92d-4c16-9ae2-779b92741676"), 1, "A menos de 50ºC" },
                    { new Guid("20475405-cb3d-488c-8d4b-6554f86aff18"), "public/default/service.png", null, "Escolhe uma lavandaria", 10, new Guid("09b67d1f-e92d-4c16-9ae2-779b92741676"), 100, "Serviço de lavandaria" },
                    { new Guid("2662c18f-4ca2-4907-b8be-29cb78d690da"), "public/default/wash/less70.png", null, "Lavar a menos de 70ºC", -2, new Guid("09b67d1f-e92d-4c16-9ae2-779b92741676"), 1, "A menos de 70ºC" },
                    { new Guid("749a3f3c-efae-40c7-ad22-7ba1017889c2"), "public/default/service.png", null, "Escolhe um serviço de engomadoria", 10, new Guid("bcde9aa7-6090-46ff-9a68-90d5e9c1e5c5"), 100, "Serviço de Engomadoria" },
                    { new Guid("871878c9-dee7-4300-9321-3bdb1fe3491a"), "public/default/service.png", null, "Escolhe um serviço de secagem", 10, new Guid("bf3e38c6-88b6-4b51-936a-aceec5706470"), 100, "Serviço de Secagem" },
                    { new Guid("9f3ecfa0-1f0d-469e-98b1-7ef1068608b6"), "public/default/wash/less30.png", null, "Lavar a menos de 30ºC", -1, new Guid("09b67d1f-e92d-4c16-9ae2-779b92741676"), 2, "A menos de 30ºC" },
                    { new Guid("a553e522-01dc-48c5-863d-2e0cb8d9c064"), "public/default/repair.png", null, "Arranjar a peça pelo próprio", 2, new Guid("9c1f97ce-eb02-42b8-a0a8-75511c61e0ff"), 3, "Pelo Próprio" },
                    { new Guid("a6ea7c10-6d7b-4eaa-8592-88534aacd4fa"), "public/default/iron/less110.png", null, "Engomar a menos de 110ºC", -1, new Guid("bcde9aa7-6090-46ff-9a68-90d5e9c1e5c5"), 1, "A menos de 110ºC" },
                    { new Guid("ad6a0245-014e-42b0-93ad-faa290036385"), "public/default/iron/less150.png", null, "Engomar a menos de 150ºC", -1, new Guid("bcde9aa7-6090-46ff-9a68-90d5e9c1e5c5"), 1, "A menos de 150ºC" },
                    { new Guid("c64b03a6-6c2a-445b-a8c9-6cea021f3eed"), "public/default/iron/less200.png", null, "Engomar a menos de 200ºC", -1, new Guid("bcde9aa7-6090-46ff-9a68-90d5e9c1e5c5"), 1, "A menos de 200ºC" },
                    { new Guid("eca039af-3fac-4f2d-a958-2dc8b908f234"), "public/default/wash/hand.png", null, "Lavar à mão com água e sabão", 10, new Guid("09b67d1f-e92d-4c16-9ae2-779b92741676"), 100, "Lavar à mão" },
                    { new Guid("ed8a69da-2c9c-475a-9523-bd3226833a89"), "public/default/dry/air.png", null, "Secar ao ar livre", 0, new Guid("bf3e38c6-88b6-4b51-936a-aceec5706470"), 2, "Ao ar livre" },
                    { new Guid("fb080307-e181-4eef-943f-f8936cf4ac40"), "public/default/dry/machine.png", null, "Secar na máquina", -1, new Guid("bf3e38c6-88b6-4b51-936a-aceec5706470"), 1, "Na máquina" }
                });
        }
    }
}
