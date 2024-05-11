using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BeatEcoprove.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ChangePointsValues : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: new Guid("1d7e6179-d179-4825-8b94-d9baa3612be7"));

            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: new Guid("6b02cef0-4d0c-481a-969c-447a530d7b3c"));

            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: new Guid("ae2225aa-8782-4eb6-8e88-9fdbc0047002"));

            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: new Guid("cb073f39-2299-410a-8be8-68840dda7274"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("1725f09d-8e58-4f45-a81b-f3a26c9c804b"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("1e5abbd1-ef9d-434f-8c68-4f225a49096e"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("4dbb2fe7-84ef-4957-9b8d-ebe5ee6b7965"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("63c6c5cc-efd4-4ab7-9ef2-7636f8e8a63b"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("64a1bcc3-d220-4f59-8dca-531e1d696d11"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("67741691-f0e4-4a29-9e61-dbc1ae5abed2"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("74996e47-a7d0-4a42-9713-e0ac81a94d76"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("806bfd3d-3ff7-4d82-8027-66cb1557d58b"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("86dfd526-5ced-4e10-b8ee-f5743c39d228"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("86f7968c-cdc1-4d91-ac64-82c4a41aa25c"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("8e622198-30b2-4d54-9731-d0f4f25eab42"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("a9f6c93b-808c-4002-93f6-aa885e42d671"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("b12840da-1aca-4e61-9620-7ebb39e75836"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("b9f9523e-a3aa-4cf0-99d9-4d67d32b9681"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("bc082231-166f-4be2-921b-ea9861e62aa0"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("bd7707af-9528-412b-aa8f-90ca1dbab8d2"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("d568fa66-fe58-4920-a4b5-0cf5ab040f39"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("ec1581c4-0cdf-4191-91ca-f251e73fd800"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("edfece44-711b-4afb-8333-957639c68b1b"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("f9fb6e66-9277-4e0b-8b91-5d6c2cb97a97"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("fb74bcd1-cc12-445a-a15d-974b98b4a6a0"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("38e97e47-d866-4c49-a886-8faba1873d1d"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("46d6348f-61df-42aa-817b-547aa04d4def"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("471dc93e-2cd1-4f2d-b4d7-4601595b9c01"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("5c6e34bd-921a-4d9c-bd05-cf0eac374c6f"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("62c59381-6f9e-4aa6-8bbe-93f152a4d13d"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("6463a5d7-af21-4f83-b528-c88f35e16ca5"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("7dd192bb-2a3d-48e6-bd8b-594d028a1312"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("92017374-e153-45b2-a8e8-dedf6620c6f5"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("9c6beac9-3289-403b-8cdd-010b18c23d6b"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("cae7b1e2-a7aa-46cf-8d84-77d5a55efb17"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("d104262a-b558-4415-b46d-cb586a2d6923"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("d55837dd-95c7-4cf7-86a4-0342e948634b"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("e2b36626-c6df-4bd2-8f85-36e45ee6d4a6"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("e6f23e79-48ed-4292-bead-c8415df0aae2"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("efa99d04-4657-4bd2-a908-11c5fb9dee19"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("f5ba8d63-a6c1-49a8-b006-c47386bc0886"));

            migrationBuilder.DeleteData(
                table: "maintenance_services",
                keyColumn: "id",
                keyValue: new Guid("17c71665-aeb6-4916-8632-2e0e05d9866c"));

            migrationBuilder.DeleteData(
                table: "maintenance_services",
                keyColumn: "id",
                keyValue: new Guid("42d42921-cda2-402b-a66f-ceb192de23c2"));

            migrationBuilder.DeleteData(
                table: "maintenance_services",
                keyColumn: "id",
                keyValue: new Guid("ab9ea09d-581c-4278-8580-af5271a3f813"));

            migrationBuilder.DeleteData(
                table: "maintenance_services",
                keyColumn: "id",
                keyValue: new Guid("dac2c8f8-519d-4ecb-a51d-a2fff5e02d25"));

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                    { new Guid("1d7e6179-d179-4825-8b94-d9baa3612be7"), "public/default/brands/losan.png", null, "Losan" },
                    { new Guid("6b02cef0-4d0c-481a-969c-447a530d7b3c"), "public/default/brands/zippy.png", null, "Zippy" },
                    { new Guid("ae2225aa-8782-4eb6-8e88-9fdbc0047002"), "public/default/brands/mo.png", null, "MO" },
                    { new Guid("cb073f39-2299-410a-8be8-68840dda7274"), "public/default/brands/salsa.png", null, "Salsa" }
                });

            migrationBuilder.InsertData(
                table: "colors",
                columns: new[] { "id", "deleted_at", "hex", "name" },
                values: new object[,]
                {
                    { new Guid("1725f09d-8e58-4f45-a81b-f3a26c9c804b"), null, "FF29394A", "Azul Escuro" },
                    { new Guid("1e5abbd1-ef9d-434f-8c68-4f225a49096e"), null, "FFF9C7C4", "Rosa Claro" },
                    { new Guid("4dbb2fe7-84ef-4957-9b8d-ebe5ee6b7965"), null, "FFD2AAC5", "Roxo Claro" },
                    { new Guid("63c6c5cc-efd4-4ab7-9ef2-7636f8e8a63b"), null, "FFFFE69F", "Amarelo" },
                    { new Guid("64a1bcc3-d220-4f59-8dca-531e1d696d11"), null, "FFD62598", "Roxo" },
                    { new Guid("67741691-f0e4-4a29-9e61-dbc1ae5abed2"), null, "FFC3A572", "Amarelo Claro" },
                    { new Guid("74996e47-a7d0-4a42-9713-e0ac81a94d76"), null, "FF8B5F3C", "Castanho Bebê" },
                    { new Guid("806bfd3d-3ff7-4d82-8027-66cb1557d58b"), null, "FFF58221", "Laranja" },
                    { new Guid("86dfd526-5ced-4e10-b8ee-f5743c39d228"), null, "FF98B3C8", "Azul Claro" },
                    { new Guid("86f7968c-cdc1-4d91-ac64-82c4a41aa25c"), null, "FF509C75", "Verde" },
                    { new Guid("8e622198-30b2-4d54-9731-d0f4f25eab42"), null, "FFC2BC8B", "Verde Lima" },
                    { new Guid("a9f6c93b-808c-4002-93f6-aa885e42d671"), null, "FFFF6D6D", "Vermelho Claro" },
                    { new Guid("b12840da-1aca-4e61-9620-7ebb39e75836"), null, "FFFFFFFF", "White" },
                    { new Guid("b9f9523e-a3aa-4cf0-99d9-4d67d32b9681"), null, "FF000000", "Black" },
                    { new Guid("bc082231-166f-4be2-921b-ea9861e62aa0"), null, "FF948066", "Castanho Claro" },
                    { new Guid("bd7707af-9528-412b-aa8f-90ca1dbab8d2"), null, "FFBE5967", "Rosa" },
                    { new Guid("d568fa66-fe58-4920-a4b5-0cf5ab040f39"), null, "FF4C4C4C", "Cinzento Claro" },
                    { new Guid("ec1581c4-0cdf-4191-91ca-f251e73fd800"), null, "FF4A2D16", "Castanho" },
                    { new Guid("edfece44-711b-4afb-8333-957639c68b1b"), null, "FFC0C0C0", "Cinzento Bebê" },
                    { new Guid("f9fb6e66-9277-4e0b-8b91-5d6c2cb97a97"), null, "FFDA252E", "Vermelho" },
                    { new Guid("fb74bcd1-cc12-445a-a15d-974b98b4a6a0"), null, "FFF2E7D4", "Amarelo Bebê" }
                });

            migrationBuilder.InsertData(
                table: "maintenance_services",
                columns: new[] { "id", "badge", "deleted_at", "description", "title" },
                values: new object[,]
                {
                    { new Guid("17c71665-aeb6-4916-8632-2e0e05d9866c"), "public/default/wash.png", null, "De que forma pertende lavar?", "Lavar" },
                    { new Guid("42d42921-cda2-402b-a66f-ceb192de23c2"), "public/default/dry.png", null, "De que forma pertende secar?", "Secar" },
                    { new Guid("ab9ea09d-581c-4278-8580-af5271a3f813"), "public/default/repair.png", null, "De que forma pertende arranjar a peça?", "Reparar" },
                    { new Guid("dac2c8f8-519d-4ecb-a51d-a2fff5e02d25"), "public/default/iron.png", null, "De que forma pertende engomar?", "Engomar" }
                });

            migrationBuilder.InsertData(
                table: "maintenance_service_actions",
                columns: new[] { "id", "badge", "deleted_at", "Description", "eco_score", "maintenance_service_id", "sustainable_points", "title" },
                values: new object[,]
                {
                    { new Guid("38e97e47-d866-4c49-a886-8faba1873d1d"), "public/default/service.png", null, "Escolhe uma lavandaria", 10, new Guid("17c71665-aeb6-4916-8632-2e0e05d9866c"), 100, "Serviço de lavandaria" },
                    { new Guid("46d6348f-61df-42aa-817b-547aa04d4def"), "public/default/iron/less200.png", null, "Engomar a menos de 200ºC", 10, new Guid("dac2c8f8-519d-4ecb-a51d-a2fff5e02d25"), 100, "A menos de 200ºC" },
                    { new Guid("471dc93e-2cd1-4f2d-b4d7-4601595b9c01"), "public/default/wash/less30.png", null, "Lavar a menos de 30ºC", 10, new Guid("17c71665-aeb6-4916-8632-2e0e05d9866c"), 100, "A menos de 30ºC" },
                    { new Guid("5c6e34bd-921a-4d9c-bd05-cf0eac374c6f"), "public/default/wash/dry.png", null, "Lavar a seco", 10, new Guid("17c71665-aeb6-4916-8632-2e0e05d9866c"), 100, "A seco" },
                    { new Guid("62c59381-6f9e-4aa6-8bbe-93f152a4d13d"), "public/default/service.png", null, "Escolhe um serviço de secagem", 10, new Guid("42d42921-cda2-402b-a66f-ceb192de23c2"), 100, "Serviço de Secagem" },
                    { new Guid("6463a5d7-af21-4f83-b528-c88f35e16ca5"), "public/default/wash/less50.png", null, "Lavar a menos de 50ºC", 10, new Guid("17c71665-aeb6-4916-8632-2e0e05d9866c"), 100, "A menos de 50ºC" },
                    { new Guid("7dd192bb-2a3d-48e6-bd8b-594d028a1312"), "public/default/service.png", null, "Escolhe um serviço de Reparação", 10, new Guid("ab9ea09d-581c-4278-8580-af5271a3f813"), 100, "Serviço de Reparação" },
                    { new Guid("92017374-e153-45b2-a8e8-dedf6620c6f5"), "public/default/service.png", null, "Escolhe um serviço de engomadoria", 10, new Guid("dac2c8f8-519d-4ecb-a51d-a2fff5e02d25"), 100, "Serviço de Engomadoria" },
                    { new Guid("9c6beac9-3289-403b-8cdd-010b18c23d6b"), "public/default/iron/less150.png", null, "Engomar a menos de 150ºC", 10, new Guid("dac2c8f8-519d-4ecb-a51d-a2fff5e02d25"), 100, "A menos de 150ºC" },
                    { new Guid("cae7b1e2-a7aa-46cf-8d84-77d5a55efb17"), "public/default/dry/air.png", null, "Secar ao ar livre", 10, new Guid("42d42921-cda2-402b-a66f-ceb192de23c2"), 100, "Ao ar livre" },
                    { new Guid("d104262a-b558-4415-b46d-cb586a2d6923"), "public/default/iron/less110.png", null, "Engomar a menos de 110ºC", 10, new Guid("dac2c8f8-519d-4ecb-a51d-a2fff5e02d25"), 100, "A menos de 110ºC" },
                    { new Guid("d55837dd-95c7-4cf7-86a4-0342e948634b"), "public/default/repair.png", null, "Arranjar a peça pelo próprio", 10, new Guid("ab9ea09d-581c-4278-8580-af5271a3f813"), 100, "Pelo Próprio" },
                    { new Guid("e2b36626-c6df-4bd2-8f85-36e45ee6d4a6"), "public/default/dry/machine.png", null, "Secar na máquina", 10, new Guid("42d42921-cda2-402b-a66f-ceb192de23c2"), 100, "Na máquina" },
                    { new Guid("e6f23e79-48ed-4292-bead-c8415df0aae2"), "public/default/wash/hand.png", null, "Lavar à mão com água e sabão", 10, new Guid("17c71665-aeb6-4916-8632-2e0e05d9866c"), 100, "Lavar à mão" },
                    { new Guid("efa99d04-4657-4bd2-a908-11c5fb9dee19"), "public/default/wash/less70.png", null, "Lavar a menos de 70ºC", 10, new Guid("17c71665-aeb6-4916-8632-2e0e05d9866c"), 100, "A menos de 70ºC" },
                    { new Guid("f5ba8d63-a6c1-49a8-b006-c47386bc0886"), "public/default/wash/less95.png", null, "Lavar a menos de 95ºC", 10, new Guid("17c71665-aeb6-4916-8632-2e0e05d9866c"), 100, "A menos de 95ºC" }
                });
        }
    }
}