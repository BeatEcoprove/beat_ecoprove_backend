using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BeatEcoprove.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class RemoveTextMessages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "group_text_messages");

            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: new Guid("7041b578-6dee-46f5-9306-5fa027a1e166"));

            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: new Guid("7b5840b7-21a3-42d2-8d9f-1a6c6b835ec4"));

            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: new Guid("8d4f9500-bdf7-4db8-88d4-cfdfb302d2b5"));

            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: new Guid("ff240300-99e1-4389-bebb-b48c77c30292"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("0ad4a7d3-b69a-43d3-91bc-64600efca0d6"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("1ef3600e-d043-41bf-adc7-fd15eeef1f02"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("356d8d64-133d-426a-a63a-3c5fba133aa8"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("3aaa255f-791c-4482-8c57-e2f8fecb4948"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("42129c13-4719-47c6-8830-e6324f7e3b3c"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("6046b26a-333e-40ec-893c-7efe4fba453a"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("61c79c9e-de49-44db-bf2e-3d34a43314e0"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("6baac232-40e0-484c-aaa8-1e579705cf1d"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("6f6234c6-0535-48d6-9f1f-56d9102a2e42"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("87d4305f-408f-4f26-b5ec-866fe84439c2"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("91ecca73-dd25-43e2-ae34-a81a5a578679"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("96638301-9a53-41a2-ac22-b5f1910a505d"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("affdf781-cd4a-4bc8-b77a-afe36a17d4d7"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("bd686168-159e-4d9b-b73e-f3d6d15cd7a1"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("bd73df8d-303e-482a-b6a6-07af0335f23c"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("c43ea7f6-60a9-4de6-8421-30fa49092c1a"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("d029fa9d-b36f-48b2-9d6f-38e64f5eaafc"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("dc9f773c-8da1-4e26-b10f-3c93e9a16cab"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("e58b862e-d59f-478e-a558-ffa1b565d6af"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("f6e385c8-970f-4771-990c-2ff61d03099e"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("f81c3d10-ed70-4cb2-972f-b84beb1032a4"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("0c749948-26f1-481e-b0f5-ee9d3d48ec58"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("1d1cd3af-5e75-4cd0-b5a5-3c6885408328"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("229e80a8-eb46-49da-a95f-5f73ff4d9d4d"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("28c4c7d1-82c3-4df1-88da-dbb0664150d5"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("2b37e561-b195-413f-aa78-c55ff59d6131"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("49c7b4bf-9bcd-48e8-904d-e1c367c5d198"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("6476f332-e62e-454e-957f-0660ffb97c11"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("71aef365-3fe2-428d-aedd-7432d45bfb61"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("7abba4c2-51ae-46ed-8b83-759317c2645a"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("7b491094-854e-4410-9d81-ce59e3696eab"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("9172d102-6c59-4e76-91a0-5103bc4a0a9e"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("a87dffc1-a8aa-47d1-a144-3729f1609532"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("aece55fb-e3da-41f8-a75f-d36fbc55171d"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("cd5c932f-790a-4c68-9461-43b22bb7a308"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("da7a9e18-cbe1-459d-aa07-f3ab23784b17"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("f0b200a6-0a45-4a15-8c80-11069340cbd1"));

            migrationBuilder.DeleteData(
                table: "maintenance_services",
                keyColumn: "id",
                keyValue: new Guid("3182bec8-1946-4eb1-8e1b-20a855d81fb2"));

            migrationBuilder.DeleteData(
                table: "maintenance_services",
                keyColumn: "id",
                keyValue: new Guid("56723cfe-ad7e-42f9-a50d-d255d68eeb4d"));

            migrationBuilder.DeleteData(
                table: "maintenance_services",
                keyColumn: "id",
                keyValue: new Guid("97015a91-4db5-405f-b178-6f59e4e66b09"));

            migrationBuilder.DeleteData(
                table: "maintenance_services",
                keyColumn: "id",
                keyValue: new Guid("e9f9fbc8-2d67-421a-9a23-a2338554c5ff"));

            migrationBuilder.InsertData(
                table: "brands",
                columns: new[] { "id", "brand_avatar", "deleted_at", "name" },
                values: new object[,]
                {
                    { new Guid("396f0f88-6b86-4877-a6fa-5c103e494738"), "public/default/brands/mo.png", null, "MO" },
                    { new Guid("4f6f43f2-0a0d-422a-a1d2-ae06f4f0ee4f"), "public/default/brands/salsa.png", null, "Salsa" },
                    { new Guid("9605b6aa-9ca6-431b-898e-2b18c14f6dc3"), "public/default/brands/zippy.png", null, "Zippy" },
                    { new Guid("b1d23c32-24fa-4437-99e9-03a3dcb3226e"), "public/default/brands/losan.png", null, "Losan" }
                });

            migrationBuilder.InsertData(
                table: "colors",
                columns: new[] { "id", "deleted_at", "hex", "name" },
                values: new object[,]
                {
                    { new Guid("06bd9801-e50f-492d-b5ac-9f3cd80f4abf"), null, "FF29394A", "Azul Escuro" },
                    { new Guid("0cb784f9-51f8-4724-b151-25d922d7d8fe"), null, "FFFFFFFF", "White" },
                    { new Guid("194a533a-f7c1-4b7d-bb14-0fd06563d54c"), null, "FF000000", "Black" },
                    { new Guid("2a9b3a75-d9fb-4a84-a9e0-24f822f39bc9"), null, "FF4A2D16", "Castanho" },
                    { new Guid("34a39a0d-19b3-41d6-8016-c8a6bd9c8c02"), null, "FF948066", "Castanho Claro" },
                    { new Guid("36d9f481-7b36-4270-86c6-17bdc7a947eb"), null, "FF8B5F3C", "Castanho Bebê" },
                    { new Guid("3ef5e0b1-be6b-4da9-b899-ae4089029c41"), null, "FFFFE69F", "Amarelo" },
                    { new Guid("5153da9c-b93a-4451-8129-72c2752de167"), null, "FFC0C0C0", "Cinzento Bebê" },
                    { new Guid("534ae41f-a69d-4daa-8d21-b2dffc9545dc"), null, "FFFF6D6D", "Vermelho Claro" },
                    { new Guid("5b50b453-830a-4a03-b772-ccbd9e9d3893"), null, "FF509C75", "Verde" },
                    { new Guid("5e96f685-35cd-458b-9dd2-555a7f88b13e"), null, "FFDA252E", "Vermelho" },
                    { new Guid("6a577e75-6781-4b96-8382-6bda5d96e1ca"), null, "FFC2BC8B", "Verde Lima" },
                    { new Guid("75fc8bf0-25f2-47d4-9d56-d7dd5c509e14"), null, "FFD2AAC5", "Roxo Claro" },
                    { new Guid("81596883-f577-4d11-8856-5428bc44bf84"), null, "FFF2E7D4", "Amarelo Bebê" },
                    { new Guid("98c7532c-b127-456f-b0c4-fdbdc692a887"), null, "FFC3A572", "Amarelo Claro" },
                    { new Guid("9954c249-2ef5-4c35-9191-e0acf1d90bf8"), null, "FF98B3C8", "Azul Claro" },
                    { new Guid("a08ecbe1-79fb-4575-829a-f1263b57582e"), null, "FF4C4C4C", "Cinzento Claro" },
                    { new Guid("ab6fc744-0a4a-446d-a439-4b026db2260f"), null, "FFD62598", "Roxo" },
                    { new Guid("baa23461-1702-4673-8c41-f7eddd83acd3"), null, "FFBE5967", "Rosa" },
                    { new Guid("c7cb2750-3c01-4ca4-a5b1-1eb68bd133c7"), null, "FFF58221", "Laranja" },
                    { new Guid("fee32a74-ccd8-4231-b0ea-3278e9b33d72"), null, "FFF9C7C4", "Rosa Claro" }
                });

            migrationBuilder.InsertData(
                table: "maintenance_services",
                columns: new[] { "id", "badge", "deleted_at", "description", "title" },
                values: new object[,]
                {
                    { new Guid("231b17ba-0569-46da-b193-9a4b7eaf1026"), "public/default/dry.png", null, "De que forma pretende secar?", "Secar" },
                    { new Guid("53c10a42-e98d-494e-b339-9c7785253de8"), "public/default/repair.png", null, "De que forma pretende arranjar a peça?", "Reparar" },
                    { new Guid("dafcb3e6-84e9-4eed-a54a-acd87304da36"), "public/default/iron.png", null, "De que forma pretende engomar?", "Engomar" },
                    { new Guid("f4fabe42-b5c0-4508-aea7-d2edcfefecb6"), "public/default/wash.png", null, "De que forma pretende lavar?", "Lavar" }
                });

            migrationBuilder.InsertData(
                table: "maintenance_service_actions",
                columns: new[] { "id", "badge", "deleted_at", "Description", "eco_score", "maintenance_service_id", "sustainable_points", "title" },
                values: new object[,]
                {
                    { new Guid("133635b4-c4d3-4d3a-886f-e7b67ccf50e3"), "public/default/service.png", null, "Escolhe um serviço de engomadoria", 10, new Guid("dafcb3e6-84e9-4eed-a54a-acd87304da36"), 100, "Serviço de Engomadoria" },
                    { new Guid("1832bf7a-fdbd-4396-9f0e-12df21c98f70"), "public/default/iron/less150.png", null, "Engomar a menos de 150ºC", -1, new Guid("dafcb3e6-84e9-4eed-a54a-acd87304da36"), 1, "A menos de 150ºC" },
                    { new Guid("2fe7f6a8-5e70-41f2-9512-8d9f7c18efcc"), "public/default/wash/less95.png", null, "Lavar a menos de 95ºC", -2, new Guid("f4fabe42-b5c0-4508-aea7-d2edcfefecb6"), 1, "A menos de 95ºC" },
                    { new Guid("4abc53ce-9586-422b-a2a8-83633fceab02"), "public/default/wash/less50.png", null, "Lavar a menos de 50ºC", -2, new Guid("f4fabe42-b5c0-4508-aea7-d2edcfefecb6"), 1, "A menos de 50ºC" },
                    { new Guid("4ed9c92b-7043-4e3c-9ac6-ecf20d160167"), "public/default/wash/less70.png", null, "Lavar a menos de 70ºC", -2, new Guid("f4fabe42-b5c0-4508-aea7-d2edcfefecb6"), 1, "A menos de 70ºC" },
                    { new Guid("54692848-31f5-46f2-adb7-a54c01f55f8a"), "public/default/service.png", null, "Escolhe um serviço de Reparação", 10, new Guid("53c10a42-e98d-494e-b339-9c7785253de8"), 100, "Serviço de Reparação" },
                    { new Guid("56c26616-2108-44c7-b330-be615f6050cc"), "public/default/service.png", null, "Escolhe um serviço de secagem", 10, new Guid("231b17ba-0569-46da-b193-9a4b7eaf1026"), 100, "Serviço de Secagem" },
                    { new Guid("578c46b3-8c69-44b0-8ac8-dd38dc83ff32"), "public/default/wash/dry.png", null, "Lavar a seco", -3, new Guid("f4fabe42-b5c0-4508-aea7-d2edcfefecb6"), 0, "A seco" },
                    { new Guid("91f1d3bf-3d14-41f9-9f07-690400ed8650"), "public/default/repair.png", null, "Arranjar a peça pelo próprio", 2, new Guid("53c10a42-e98d-494e-b339-9c7785253de8"), 3, "Pelo Próprio" },
                    { new Guid("95b6c97e-d9e0-4656-ab5e-2cf718e04675"), "public/default/dry/machine.png", null, "Secar na máquina", -1, new Guid("231b17ba-0569-46da-b193-9a4b7eaf1026"), 1, "Na máquina" },
                    { new Guid("a489dc9a-1618-4d1d-baca-a9e2731f6cef"), "public/default/iron/less110.png", null, "Engomar a menos de 110ºC", -1, new Guid("dafcb3e6-84e9-4eed-a54a-acd87304da36"), 1, "A menos de 110ºC" },
                    { new Guid("a8ba3264-885c-4368-ada1-d5bb2713b146"), "public/default/dry/air.png", null, "Secar ao ar livre", 0, new Guid("231b17ba-0569-46da-b193-9a4b7eaf1026"), 2, "Ao ar livre" },
                    { new Guid("b982d037-83c0-4685-8c30-c80088f0806d"), "public/default/service.png", null, "Escolhe uma lavandaria", 10, new Guid("f4fabe42-b5c0-4508-aea7-d2edcfefecb6"), 100, "Serviço de lavandaria" },
                    { new Guid("e201f764-35d7-44b9-bd4c-145d531088da"), "public/default/wash/less30.png", null, "Lavar a menos de 30ºC", -1, new Guid("f4fabe42-b5c0-4508-aea7-d2edcfefecb6"), 2, "A menos de 30ºC" },
                    { new Guid("ee61a170-fa08-454d-95bd-d45926695206"), "public/default/iron/less200.png", null, "Engomar a menos de 200ºC", -1, new Guid("dafcb3e6-84e9-4eed-a54a-acd87304da36"), 1, "A menos de 200ºC" },
                    { new Guid("f0d866bd-7458-4045-bda7-509e0a6432cb"), "public/default/wash/hand.png", null, "Lavar à mão com água e sabão", 10, new Guid("f4fabe42-b5c0-4508-aea7-d2edcfefecb6"), 100, "Lavar à mão" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: new Guid("396f0f88-6b86-4877-a6fa-5c103e494738"));

            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: new Guid("4f6f43f2-0a0d-422a-a1d2-ae06f4f0ee4f"));

            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: new Guid("9605b6aa-9ca6-431b-898e-2b18c14f6dc3"));

            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: new Guid("b1d23c32-24fa-4437-99e9-03a3dcb3226e"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("06bd9801-e50f-492d-b5ac-9f3cd80f4abf"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("0cb784f9-51f8-4724-b151-25d922d7d8fe"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("194a533a-f7c1-4b7d-bb14-0fd06563d54c"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("2a9b3a75-d9fb-4a84-a9e0-24f822f39bc9"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("34a39a0d-19b3-41d6-8016-c8a6bd9c8c02"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("36d9f481-7b36-4270-86c6-17bdc7a947eb"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("3ef5e0b1-be6b-4da9-b899-ae4089029c41"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("5153da9c-b93a-4451-8129-72c2752de167"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("534ae41f-a69d-4daa-8d21-b2dffc9545dc"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("5b50b453-830a-4a03-b772-ccbd9e9d3893"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("5e96f685-35cd-458b-9dd2-555a7f88b13e"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("6a577e75-6781-4b96-8382-6bda5d96e1ca"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("75fc8bf0-25f2-47d4-9d56-d7dd5c509e14"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("81596883-f577-4d11-8856-5428bc44bf84"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("98c7532c-b127-456f-b0c4-fdbdc692a887"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("9954c249-2ef5-4c35-9191-e0acf1d90bf8"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("a08ecbe1-79fb-4575-829a-f1263b57582e"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("ab6fc744-0a4a-446d-a439-4b026db2260f"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("baa23461-1702-4673-8c41-f7eddd83acd3"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("c7cb2750-3c01-4ca4-a5b1-1eb68bd133c7"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("fee32a74-ccd8-4231-b0ea-3278e9b33d72"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("133635b4-c4d3-4d3a-886f-e7b67ccf50e3"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("1832bf7a-fdbd-4396-9f0e-12df21c98f70"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("2fe7f6a8-5e70-41f2-9512-8d9f7c18efcc"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("4abc53ce-9586-422b-a2a8-83633fceab02"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("4ed9c92b-7043-4e3c-9ac6-ecf20d160167"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("54692848-31f5-46f2-adb7-a54c01f55f8a"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("56c26616-2108-44c7-b330-be615f6050cc"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("578c46b3-8c69-44b0-8ac8-dd38dc83ff32"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("91f1d3bf-3d14-41f9-9f07-690400ed8650"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("95b6c97e-d9e0-4656-ab5e-2cf718e04675"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("a489dc9a-1618-4d1d-baca-a9e2731f6cef"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("a8ba3264-885c-4368-ada1-d5bb2713b146"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("b982d037-83c0-4685-8c30-c80088f0806d"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("e201f764-35d7-44b9-bd4c-145d531088da"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("ee61a170-fa08-454d-95bd-d45926695206"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("f0d866bd-7458-4045-bda7-509e0a6432cb"));

            migrationBuilder.DeleteData(
                table: "maintenance_services",
                keyColumn: "id",
                keyValue: new Guid("231b17ba-0569-46da-b193-9a4b7eaf1026"));

            migrationBuilder.DeleteData(
                table: "maintenance_services",
                keyColumn: "id",
                keyValue: new Guid("53c10a42-e98d-494e-b339-9c7785253de8"));

            migrationBuilder.DeleteData(
                table: "maintenance_services",
                keyColumn: "id",
                keyValue: new Guid("dafcb3e6-84e9-4eed-a54a-acd87304da36"));

            migrationBuilder.DeleteData(
                table: "maintenance_services",
                keyColumn: "id",
                keyValue: new Guid("f4fabe42-b5c0-4508-aea7-d2edcfefecb6"));

            migrationBuilder.CreateTable(
                name: "group_text_messages",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    content = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DeletedAt = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    group_id = table.Column<Guid>(type: "uuid", nullable: false),
                    sender_id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_group_text_messages", x => x.id);
                    table.ForeignKey(
                        name: "FK_group_text_messages_group_members_sender_id",
                        column: x => x.sender_id,
                        principalTable: "group_members",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_group_text_messages_groups_group_id",
                        column: x => x.group_id,
                        principalTable: "groups",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "brands",
                columns: new[] { "id", "brand_avatar", "deleted_at", "name" },
                values: new object[,]
                {
                    { new Guid("7041b578-6dee-46f5-9306-5fa027a1e166"), "public/default/brands/mo.png", null, "MO" },
                    { new Guid("7b5840b7-21a3-42d2-8d9f-1a6c6b835ec4"), "public/default/brands/salsa.png", null, "Salsa" },
                    { new Guid("8d4f9500-bdf7-4db8-88d4-cfdfb302d2b5"), "public/default/brands/losan.png", null, "Losan" },
                    { new Guid("ff240300-99e1-4389-bebb-b48c77c30292"), "public/default/brands/zippy.png", null, "Zippy" }
                });

            migrationBuilder.InsertData(
                table: "colors",
                columns: new[] { "id", "deleted_at", "hex", "name" },
                values: new object[,]
                {
                    { new Guid("0ad4a7d3-b69a-43d3-91bc-64600efca0d6"), null, "FFDA252E", "Vermelho" },
                    { new Guid("1ef3600e-d043-41bf-adc7-fd15eeef1f02"), null, "FF509C75", "Verde" },
                    { new Guid("356d8d64-133d-426a-a63a-3c5fba133aa8"), null, "FF000000", "Black" },
                    { new Guid("3aaa255f-791c-4482-8c57-e2f8fecb4948"), null, "FF29394A", "Azul Escuro" },
                    { new Guid("42129c13-4719-47c6-8830-e6324f7e3b3c"), null, "FF8B5F3C", "Castanho Bebê" },
                    { new Guid("6046b26a-333e-40ec-893c-7efe4fba453a"), null, "FFF58221", "Laranja" },
                    { new Guid("61c79c9e-de49-44db-bf2e-3d34a43314e0"), null, "FFD62598", "Roxo" },
                    { new Guid("6baac232-40e0-484c-aaa8-1e579705cf1d"), null, "FFBE5967", "Rosa" },
                    { new Guid("6f6234c6-0535-48d6-9f1f-56d9102a2e42"), null, "FFFFFFFF", "White" },
                    { new Guid("87d4305f-408f-4f26-b5ec-866fe84439c2"), null, "FFD2AAC5", "Roxo Claro" },
                    { new Guid("91ecca73-dd25-43e2-ae34-a81a5a578679"), null, "FFC2BC8B", "Verde Lima" },
                    { new Guid("96638301-9a53-41a2-ac22-b5f1910a505d"), null, "FF948066", "Castanho Claro" },
                    { new Guid("affdf781-cd4a-4bc8-b77a-afe36a17d4d7"), null, "FF4C4C4C", "Cinzento Claro" },
                    { new Guid("bd686168-159e-4d9b-b73e-f3d6d15cd7a1"), null, "FFC0C0C0", "Cinzento Bebê" },
                    { new Guid("bd73df8d-303e-482a-b6a6-07af0335f23c"), null, "FFFF6D6D", "Vermelho Claro" },
                    { new Guid("c43ea7f6-60a9-4de6-8421-30fa49092c1a"), null, "FFFFE69F", "Amarelo" },
                    { new Guid("d029fa9d-b36f-48b2-9d6f-38e64f5eaafc"), null, "FF98B3C8", "Azul Claro" },
                    { new Guid("dc9f773c-8da1-4e26-b10f-3c93e9a16cab"), null, "FFF2E7D4", "Amarelo Bebê" },
                    { new Guid("e58b862e-d59f-478e-a558-ffa1b565d6af"), null, "FF4A2D16", "Castanho" },
                    { new Guid("f6e385c8-970f-4771-990c-2ff61d03099e"), null, "FFF9C7C4", "Rosa Claro" },
                    { new Guid("f81c3d10-ed70-4cb2-972f-b84beb1032a4"), null, "FFC3A572", "Amarelo Claro" }
                });

            migrationBuilder.InsertData(
                table: "maintenance_services",
                columns: new[] { "id", "badge", "deleted_at", "description", "title" },
                values: new object[,]
                {
                    { new Guid("3182bec8-1946-4eb1-8e1b-20a855d81fb2"), "public/default/iron.png", null, "De que forma pretende engomar?", "Engomar" },
                    { new Guid("56723cfe-ad7e-42f9-a50d-d255d68eeb4d"), "public/default/dry.png", null, "De que forma pretende secar?", "Secar" },
                    { new Guid("97015a91-4db5-405f-b178-6f59e4e66b09"), "public/default/repair.png", null, "De que forma pretende arranjar a peça?", "Reparar" },
                    { new Guid("e9f9fbc8-2d67-421a-9a23-a2338554c5ff"), "public/default/wash.png", null, "De que forma pretende lavar?", "Lavar" }
                });

            migrationBuilder.InsertData(
                table: "maintenance_service_actions",
                columns: new[] { "id", "badge", "deleted_at", "Description", "eco_score", "maintenance_service_id", "sustainable_points", "title" },
                values: new object[,]
                {
                    { new Guid("0c749948-26f1-481e-b0f5-ee9d3d48ec58"), "public/default/wash/dry.png", null, "Lavar a seco", -3, new Guid("e9f9fbc8-2d67-421a-9a23-a2338554c5ff"), 0, "A seco" },
                    { new Guid("1d1cd3af-5e75-4cd0-b5a5-3c6885408328"), "public/default/wash/less50.png", null, "Lavar a menos de 50ºC", -2, new Guid("e9f9fbc8-2d67-421a-9a23-a2338554c5ff"), 1, "A menos de 50ºC" },
                    { new Guid("229e80a8-eb46-49da-a95f-5f73ff4d9d4d"), "public/default/service.png", null, "Escolhe um serviço de secagem", 10, new Guid("56723cfe-ad7e-42f9-a50d-d255d68eeb4d"), 100, "Serviço de Secagem" },
                    { new Guid("28c4c7d1-82c3-4df1-88da-dbb0664150d5"), "public/default/wash/less30.png", null, "Lavar a menos de 30ºC", -1, new Guid("e9f9fbc8-2d67-421a-9a23-a2338554c5ff"), 2, "A menos de 30ºC" },
                    { new Guid("2b37e561-b195-413f-aa78-c55ff59d6131"), "public/default/wash/less70.png", null, "Lavar a menos de 70ºC", -2, new Guid("e9f9fbc8-2d67-421a-9a23-a2338554c5ff"), 1, "A menos de 70ºC" },
                    { new Guid("49c7b4bf-9bcd-48e8-904d-e1c367c5d198"), "public/default/service.png", null, "Escolhe um serviço de engomadoria", 10, new Guid("3182bec8-1946-4eb1-8e1b-20a855d81fb2"), 100, "Serviço de Engomadoria" },
                    { new Guid("6476f332-e62e-454e-957f-0660ffb97c11"), "public/default/iron/less200.png", null, "Engomar a menos de 200ºC", -1, new Guid("3182bec8-1946-4eb1-8e1b-20a855d81fb2"), 1, "A menos de 200ºC" },
                    { new Guid("71aef365-3fe2-428d-aedd-7432d45bfb61"), "public/default/repair.png", null, "Arranjar a peça pelo próprio", 2, new Guid("97015a91-4db5-405f-b178-6f59e4e66b09"), 3, "Pelo Próprio" },
                    { new Guid("7abba4c2-51ae-46ed-8b83-759317c2645a"), "public/default/wash/hand.png", null, "Lavar à mão com água e sabão", 10, new Guid("e9f9fbc8-2d67-421a-9a23-a2338554c5ff"), 100, "Lavar à mão" },
                    { new Guid("7b491094-854e-4410-9d81-ce59e3696eab"), "public/default/service.png", null, "Escolhe uma lavandaria", 10, new Guid("e9f9fbc8-2d67-421a-9a23-a2338554c5ff"), 100, "Serviço de lavandaria" },
                    { new Guid("9172d102-6c59-4e76-91a0-5103bc4a0a9e"), "public/default/service.png", null, "Escolhe um serviço de Reparação", 10, new Guid("97015a91-4db5-405f-b178-6f59e4e66b09"), 100, "Serviço de Reparação" },
                    { new Guid("a87dffc1-a8aa-47d1-a144-3729f1609532"), "public/default/iron/less150.png", null, "Engomar a menos de 150ºC", -1, new Guid("3182bec8-1946-4eb1-8e1b-20a855d81fb2"), 1, "A menos de 150ºC" },
                    { new Guid("aece55fb-e3da-41f8-a75f-d36fbc55171d"), "public/default/iron/less110.png", null, "Engomar a menos de 110ºC", -1, new Guid("3182bec8-1946-4eb1-8e1b-20a855d81fb2"), 1, "A menos de 110ºC" },
                    { new Guid("cd5c932f-790a-4c68-9461-43b22bb7a308"), "public/default/wash/less95.png", null, "Lavar a menos de 95ºC", -2, new Guid("e9f9fbc8-2d67-421a-9a23-a2338554c5ff"), 1, "A menos de 95ºC" },
                    { new Guid("da7a9e18-cbe1-459d-aa07-f3ab23784b17"), "public/default/dry/machine.png", null, "Secar na máquina", -1, new Guid("56723cfe-ad7e-42f9-a50d-d255d68eeb4d"), 1, "Na máquina" },
                    { new Guid("f0b200a6-0a45-4a15-8c80-11069340cbd1"), "public/default/dry/air.png", null, "Secar ao ar livre", 0, new Guid("56723cfe-ad7e-42f9-a50d-d255d68eeb4d"), 2, "Ao ar livre" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_group_text_messages_group_id",
                table: "group_text_messages",
                column: "group_id");

            migrationBuilder.CreateIndex(
                name: "IX_group_text_messages_sender_id",
                table: "group_text_messages",
                column: "sender_id");
        }
    }
}