using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BeatEcoprove.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddBrandImages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: new Guid("72ebdcd9-4d9f-4911-8a70-84f7e8d08079"));

            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: new Guid("a9aeec63-3220-42d0-a045-7a8239d9582e"));

            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: new Guid("cf98502f-54a9-410b-bdf8-e6f79e635de4"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("003685cc-db4f-4f8e-b99c-0747e53965ba"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("0cb02dcb-85f1-41b0-ac14-c5696fd044e0"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("137de7c2-7340-4997-af40-8a3c72e97868"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("1868efde-5e58-4533-a266-957f81c0cec2"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("2dd686e7-8598-4352-9f8e-9e2f392d3eaf"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("3eb4ba0c-ca6e-45d5-b23c-2b74bc45a9cf"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("49b4e34d-6f76-4560-96c4-573075a2fb26"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("4c3b6209-9872-4c30-99f0-4d1398c16d14"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("58e4291e-1f2d-4783-beb8-cd5cb8034866"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("6117d603-2d02-4365-9148-60066d2d6ebb"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("6aea3d42-1667-4dfe-8fbe-4934e6cf385a"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("7d5eec0f-86b0-4b11-b336-41d2b31b081a"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("8f0cb390-b665-4e3c-8266-a6d43c392bf6"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("90b31ed8-59f4-414f-87d2-027aeddc6722"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("c0f4bbd9-4ec5-47c8-9eaa-6b192190106b"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("c5ddcae0-d5cb-4505-948f-737af834e2ea"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("c7282c01-5cf1-4434-9c2b-d9b2e0effa85"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("cbb3d13e-35b3-46ee-81cf-515a51d49164"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("ce9b77b2-4923-4be3-8a10-7b61a8f2925b"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("d339b83f-dd89-440f-9c98-50adbe848ae9"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("fc796230-5458-4fff-8956-d2467a6ec769"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("125893b0-f0ac-484f-b2cc-d232db32145f"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("13b00c78-04ea-42f4-8454-ee69696a4830"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("32a8b41c-a3de-4db3-abb7-0d1cb6972a4e"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("347a08be-9246-49a3-a53a-116d5de74c45"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("47046061-3afb-4848-a281-b57e1eb0574a"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("513a3d39-74bb-453f-a612-4046fac9fc89"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("5a59cc3e-1839-4ebe-829a-922fb5342289"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("7cb3c017-17b1-4f1e-8282-5084669fe86e"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("803cab24-050d-4ded-a376-496834ec7ac5"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("89ea57e1-342f-4923-8065-1c0dcdc266ba"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("8a85a7c6-a9c2-4a93-b970-3001ef5d4fbb"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("bb30e2ff-5615-4547-ad99-5c78783c0935"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("d1c3fef6-fba5-422b-bc0b-37660512bff1"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("e3d8ffac-8a67-4baf-ad8b-ea2066477d12"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("ea2ad035-d372-43d5-b30e-15b3b9759881"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("f8c2c544-18d1-4edd-820f-16e2d228efe4"));

            migrationBuilder.DeleteData(
                table: "maintenance_services",
                keyColumn: "id",
                keyValue: new Guid("0a912017-037a-4387-bb48-f81cb00ee2ca"));

            migrationBuilder.DeleteData(
                table: "maintenance_services",
                keyColumn: "id",
                keyValue: new Guid("1faa30c0-8ee3-4084-944d-2cbd8c669c16"));

            migrationBuilder.DeleteData(
                table: "maintenance_services",
                keyColumn: "id",
                keyValue: new Guid("29ba13a8-bb75-44b9-8703-3f6379eb81d3"));

            migrationBuilder.DeleteData(
                table: "maintenance_services",
                keyColumn: "id",
                keyValue: new Guid("89632620-3f8f-476c-a977-796f50696c8d"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { new Guid("72ebdcd9-4d9f-4911-8a70-84f7e8d08079"), "...", null, "MO" },
                    { new Guid("a9aeec63-3220-42d0-a045-7a8239d9582e"), "...", null, "Salsa" },
                    { new Guid("cf98502f-54a9-410b-bdf8-e6f79e635de4"), "...", null, "Tifosi" }
                });

            migrationBuilder.InsertData(
                table: "colors",
                columns: new[] { "id", "deleted_at", "hex", "name" },
                values: new object[,]
                {
                    { new Guid("003685cc-db4f-4f8e-b99c-0747e53965ba"), null, "FFFFE69F", "Amarelo" },
                    { new Guid("0cb02dcb-85f1-41b0-ac14-c5696fd044e0"), null, "FFF9C7C4", "Rosa Claro" },
                    { new Guid("137de7c2-7340-4997-af40-8a3c72e97868"), null, "FFBE5967", "Rosa" },
                    { new Guid("1868efde-5e58-4533-a266-957f81c0cec2"), null, "FFF2E7D4", "Amarelo Bebê" },
                    { new Guid("2dd686e7-8598-4352-9f8e-9e2f392d3eaf"), null, "FFFFFFFF", "White" },
                    { new Guid("3eb4ba0c-ca6e-45d5-b23c-2b74bc45a9cf"), null, "FFD62598", "Roxo" },
                    { new Guid("49b4e34d-6f76-4560-96c4-573075a2fb26"), null, "FF98B3C8", "Azul Claro" },
                    { new Guid("4c3b6209-9872-4c30-99f0-4d1398c16d14"), null, "FF8B5F3C", "Castanho Bebê" },
                    { new Guid("58e4291e-1f2d-4783-beb8-cd5cb8034866"), null, "FF948066", "Castanho Claro" },
                    { new Guid("6117d603-2d02-4365-9148-60066d2d6ebb"), null, "FFD2AAC5", "Roxo Claro" },
                    { new Guid("6aea3d42-1667-4dfe-8fbe-4934e6cf385a"), null, "FF509C75", "Verde" },
                    { new Guid("7d5eec0f-86b0-4b11-b336-41d2b31b081a"), null, "FF4C4C4C", "Cinzento Claro" },
                    { new Guid("8f0cb390-b665-4e3c-8266-a6d43c392bf6"), null, "FFFF6D6D", "Vermelho Claro" },
                    { new Guid("90b31ed8-59f4-414f-87d2-027aeddc6722"), null, "FF29394A", "Azul Escuro" },
                    { new Guid("c0f4bbd9-4ec5-47c8-9eaa-6b192190106b"), null, "FF000000", "Black" },
                    { new Guid("c5ddcae0-d5cb-4505-948f-737af834e2ea"), null, "FFDA252E", "Vermelho" },
                    { new Guid("c7282c01-5cf1-4434-9c2b-d9b2e0effa85"), null, "FFC3A572", "Amarelo Claro" },
                    { new Guid("cbb3d13e-35b3-46ee-81cf-515a51d49164"), null, "FFC2BC8B", "Verde Lima" },
                    { new Guid("ce9b77b2-4923-4be3-8a10-7b61a8f2925b"), null, "FFC0C0C0", "Cinzento Bebê" },
                    { new Guid("d339b83f-dd89-440f-9c98-50adbe848ae9"), null, "FF4A2D16", "Castanho" },
                    { new Guid("fc796230-5458-4fff-8956-d2467a6ec769"), null, "FFF58221", "Laranja" }
                });

            migrationBuilder.InsertData(
                table: "maintenance_services",
                columns: new[] { "id", "badge", "deleted_at", "description", "title" },
                values: new object[,]
                {
                    { new Guid("0a912017-037a-4387-bb48-f81cb00ee2ca"), "public/default/wash.png", null, "De que forma pertende lavar?", "Lavar" },
                    { new Guid("1faa30c0-8ee3-4084-944d-2cbd8c669c16"), "public/default/iron.png", null, "De que forma pertende engomar?", "Engomar" },
                    { new Guid("29ba13a8-bb75-44b9-8703-3f6379eb81d3"), "public/default/dry.png", null, "De que forma pertende secar?", "Secar" },
                    { new Guid("89632620-3f8f-476c-a977-796f50696c8d"), "public/default/repair.png", null, "De que forma pertende arranjar a peça?", "Reparar" }
                });

            migrationBuilder.InsertData(
                table: "maintenance_service_actions",
                columns: new[] { "id", "badge", "deleted_at", "Description", "eco_score", "maintenance_service_id", "sustainable_points", "title" },
                values: new object[,]
                {
                    { new Guid("125893b0-f0ac-484f-b2cc-d232db32145f"), "public/default/iron/less200.png", null, "Engomar a menos de 200ºC", 10, new Guid("1faa30c0-8ee3-4084-944d-2cbd8c669c16"), 100, "A menos de 200ºC" },
                    { new Guid("13b00c78-04ea-42f4-8454-ee69696a4830"), "public/default/wash/less50.png", null, "Lavar a menos de 50ºC", 10, new Guid("0a912017-037a-4387-bb48-f81cb00ee2ca"), 100, "A menos de 50ºC" },
                    { new Guid("32a8b41c-a3de-4db3-abb7-0d1cb6972a4e"), "public/default/dry/machine.png", null, "Secar na máquina", 10, new Guid("29ba13a8-bb75-44b9-8703-3f6379eb81d3"), 100, "Na máquina" },
                    { new Guid("347a08be-9246-49a3-a53a-116d5de74c45"), "public/default/wash/less30.png", null, "Lavar a menos de 30ºC", 10, new Guid("0a912017-037a-4387-bb48-f81cb00ee2ca"), 100, "A menos de 30ºC" },
                    { new Guid("47046061-3afb-4848-a281-b57e1eb0574a"), "public/default/wash/hand.png", null, "Lavar à mão com água e sabão", 10, new Guid("0a912017-037a-4387-bb48-f81cb00ee2ca"), 100, "Lavar à mão" },
                    { new Guid("513a3d39-74bb-453f-a612-4046fac9fc89"), "public/default/wash/less70.png", null, "Lavar a menos de 70ºC", 10, new Guid("0a912017-037a-4387-bb48-f81cb00ee2ca"), 100, "A menos de 70ºC" },
                    { new Guid("5a59cc3e-1839-4ebe-829a-922fb5342289"), "public/default/service.png", null, "Escolhe um serviço de engomadoria", 10, new Guid("1faa30c0-8ee3-4084-944d-2cbd8c669c16"), 100, "Serviço de Engomadoria" },
                    { new Guid("7cb3c017-17b1-4f1e-8282-5084669fe86e"), "public/default/wash/less95.png", null, "Lavar a menos de 95ºC", 10, new Guid("0a912017-037a-4387-bb48-f81cb00ee2ca"), 100, "A menos de 95ºC" },
                    { new Guid("803cab24-050d-4ded-a376-496834ec7ac5"), "public/default/dry/air.png", null, "Secar ao ar livre", 10, new Guid("29ba13a8-bb75-44b9-8703-3f6379eb81d3"), 100, "Ao ar livre" },
                    { new Guid("89ea57e1-342f-4923-8065-1c0dcdc266ba"), "public/default/repair.png", null, "Arranjar a peça pelo próprio", 10, new Guid("89632620-3f8f-476c-a977-796f50696c8d"), 100, "Pelo Próprio" },
                    { new Guid("8a85a7c6-a9c2-4a93-b970-3001ef5d4fbb"), "public/default/iron/less150.png", null, "Engomar a menos de 150ºC", 10, new Guid("1faa30c0-8ee3-4084-944d-2cbd8c669c16"), 100, "A menos de 150ºC" },
                    { new Guid("bb30e2ff-5615-4547-ad99-5c78783c0935"), "public/default/service.png", null, "Escolhe uma lavandaria", 10, new Guid("0a912017-037a-4387-bb48-f81cb00ee2ca"), 100, "Serviço de lavandaria" },
                    { new Guid("d1c3fef6-fba5-422b-bc0b-37660512bff1"), "public/default/service.png", null, "Escolhe um serviço de secagem", 10, new Guid("29ba13a8-bb75-44b9-8703-3f6379eb81d3"), 100, "Serviço de Secagem" },
                    { new Guid("e3d8ffac-8a67-4baf-ad8b-ea2066477d12"), "public/default/wash/dry.png", null, "Lavar a seco", 10, new Guid("0a912017-037a-4387-bb48-f81cb00ee2ca"), 100, "A seco" },
                    { new Guid("ea2ad035-d372-43d5-b30e-15b3b9759881"), "public/default/iron/less110.png", null, "Engomar a menos de 110ºC", 10, new Guid("1faa30c0-8ee3-4084-944d-2cbd8c669c16"), 100, "A menos de 110ºC" },
                    { new Guid("f8c2c544-18d1-4edd-820f-16e2d228efe4"), "public/default/service.png", null, "Escolhe um serviço de Reparação", 10, new Guid("89632620-3f8f-476c-a977-796f50696c8d"), 100, "Serviço de Reparação" }
                });
        }
    }
}