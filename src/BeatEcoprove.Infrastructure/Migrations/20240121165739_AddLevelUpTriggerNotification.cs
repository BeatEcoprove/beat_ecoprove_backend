using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BeatEcoprove.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddLevelUpTriggerNotification : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: new Guid("36ce016d-b9de-48b0-a0d8-35d4f9501c62"));

            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: new Guid("d1440c3d-3f28-47dc-a202-c185272b1dbe"));

            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: new Guid("e3b3eddf-3037-4402-8ced-ff721c35481e"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("5d5155a4-9bad-425f-8444-a2c65291db07"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("76eb11ce-11f7-4eef-850d-767443cb261f"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("a94faae1-9c32-4418-b9e6-e02d8efbe1b7"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("db467672-13bc-4e6f-8e68-dd1defc71f9c"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("e774cb84-ca95-4430-8610-d93aa57bd7d0"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("2b8c5d7a-1969-49b6-9385-80a5de0a89de"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("2e770e6d-fd87-467b-8cd6-20910c173810"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("336d12bc-ddc2-4cb8-bf6c-67f6f3c2ca8f"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("35b3eeae-294f-4c7f-9f40-8bc43982f740"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("3fc683e7-4b82-4319-af20-3c6ce2fb27fb"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("56b181b9-4c80-45e1-aef3-956f69bb739d"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("63a592a7-455e-4e9f-96c3-f031e5bacb02"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("724cb8f9-a04d-47b6-b8a2-de44ea2780e8"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("7f6392e3-05fe-47da-a5f8-c9e24169dcd6"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("8176c49f-eaed-445f-8312-24fa0765d160"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("a9117518-3a74-4c45-bf58-38a47ab8a413"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("a980f950-7749-47f1-8eb5-c8b2e369531a"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("b76d9710-f953-4f55-9435-eb43fde8ae9b"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("c0268528-a255-4e06-afab-ed35d53ecbf3"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("c479d878-fb33-4335-a78c-77c8d76803d9"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("e3d43c5f-a303-40e7-80bc-b9d7a59ebe09"));

            migrationBuilder.DeleteData(
                table: "maintenance_services",
                keyColumn: "id",
                keyValue: new Guid("0eaefa43-2687-44ee-b3fb-527db9eb5dad"));

            migrationBuilder.DeleteData(
                table: "maintenance_services",
                keyColumn: "id",
                keyValue: new Guid("53ecb0f0-bb77-4875-8563-17eac5e97780"));

            migrationBuilder.DeleteData(
                table: "maintenance_services",
                keyColumn: "id",
                keyValue: new Guid("8e8ecf6e-7301-4f8a-9b5d-00768daade36"));

            migrationBuilder.DeleteData(
                table: "maintenance_services",
                keyColumn: "id",
                keyValue: new Guid("fa98a556-80d0-4dc3-a905-479e40f5030f"));

            migrationBuilder.InsertData(
                table: "brands",
                columns: new[] { "id", "brand_avatar", "deleted_at", "name" },
                values: new object[,]
                {
                    { new Guid("7f386d60-27b9-4c0d-b13b-c01ba2729693"), "...", null, "Salsa" },
                    { new Guid("b32b05ac-1531-4d8c-b6b9-f0b554ab557b"), "...", null, "Tifosi" },
                    { new Guid("dc7fba3d-231b-4ef8-931f-c93c82a95365"), "...", null, "MO" }
                });

            migrationBuilder.InsertData(
                table: "colors",
                columns: new[] { "id", "deleted_at", "hex", "name" },
                values: new object[,]
                {
                    { new Guid("1fa130a8-0514-4dcf-b4f6-3255ff3d033b"), null, "FFFF0000", "Red" },
                    { new Guid("278fee68-f717-4b1e-b693-65dd5eb3b7d2"), null, "FFFFFFFF", "White" },
                    { new Guid("82be98b3-e3e6-49f9-9748-83ca3ffe3379"), null, "FF0000FF", "Blue" },
                    { new Guid("b6fbda96-110a-4287-9b2a-153e2855865e"), null, "FF00FF00", "Green" },
                    { new Guid("d2111157-54e8-4ee2-a3be-373a93451793"), null, "FF000000", "Black" }
                });

            migrationBuilder.InsertData(
                table: "maintenance_services",
                columns: new[] { "id", "badge", "deleted_at", "description", "title" },
                values: new object[,]
                {
                    { new Guid("3ce29e6e-89a5-4700-8b09-2de656b13103"), "public/default/wash.png", null, "De que forma pertende lavar?", "Lavar" },
                    { new Guid("973dadb9-b07a-46c2-91cc-55389686f2f2"), "public/default/iron.png", null, "De que forma pertende engomar?", "Engomar" },
                    { new Guid("aa883287-24ee-42e9-b1cb-3122e99f4d8a"), "public/default/repair.png", null, "De que forma pertende arranjar a peça?", "Engomar" },
                    { new Guid("b6a455d6-593c-4941-969d-13d21705b92f"), "public/default/dry.png", null, "De que forma pertende secar?", "Secar" }
                });

            migrationBuilder.InsertData(
                table: "maintenance_service_actions",
                columns: new[] { "id", "badge", "deleted_at", "Description", "eco_score", "maintenance_service_id", "sustainable_points", "title" },
                values: new object[,]
                {
                    { new Guid("0b98243f-f4ec-4ec4-9126-56c59a6b804d"), "public/default/wash/less50.png", null, "Lavar a menos de 50ºC", 10, new Guid("3ce29e6e-89a5-4700-8b09-2de656b13103"), 100, "A menos de 50ºC" },
                    { new Guid("2981afd0-c8aa-4926-8bda-bf71eb21892c"), "public/default/iron/less110.png", null, "Engomar a menos de 110ºC", 10, new Guid("973dadb9-b07a-46c2-91cc-55389686f2f2"), 100, "A menos de 110ºC" },
                    { new Guid("3460d900-15ef-471a-9a06-f45a8086195e"), "public/default/dry/air.png", null, "Secar ao ar livre", 10, new Guid("b6a455d6-593c-4941-969d-13d21705b92f"), 100, "Ao ar livre" },
                    { new Guid("3ebad7bb-2b9b-452d-8a1d-fba0ad195a2e"), "public/default/service.png", null, "Escolhe uma lavandaria", 10, new Guid("3ce29e6e-89a5-4700-8b09-2de656b13103"), 100, "Serviço de lavandaria" },
                    { new Guid("472a0b25-5b5a-4bf1-b5da-96c7d0d675b8"), "public/default/wash/hand.png", null, "Lavar à mão com água e sabão", 10, new Guid("3ce29e6e-89a5-4700-8b09-2de656b13103"), 100, "Lavar à mão" },
                    { new Guid("5116d81b-2c83-427e-bcef-8c70c6f33668"), "public/default/wash/dry.png", null, "Lavar a seco", 10, new Guid("3ce29e6e-89a5-4700-8b09-2de656b13103"), 100, "A seco" },
                    { new Guid("5af4f66a-a8e2-457d-a9d7-79d84cf1c909"), "public/default/service.png", null, "Escolhe um serviço de Reparação", 10, new Guid("aa883287-24ee-42e9-b1cb-3122e99f4d8a"), 100, "Serviço de Reparação" },
                    { new Guid("7f15774a-6a78-425e-bf94-60acf1258e74"), "public/default/repair.png", null, "Arranjar a peça pelo próprio", 10, new Guid("aa883287-24ee-42e9-b1cb-3122e99f4d8a"), 100, "Pelo Próprio" },
                    { new Guid("87ddae47-fd57-45a3-85e1-d15f125765b0"), "public/default/service.png", null, "Escolhe um serviço de engomadoria", 10, new Guid("973dadb9-b07a-46c2-91cc-55389686f2f2"), 100, "Serviço de Engomadoria" },
                    { new Guid("8eed3bef-0fd6-4c88-ac8c-078ef81ba4e4"), "public/default/iron/less150.png", null, "Engomar a menos de 150ºC", 10, new Guid("973dadb9-b07a-46c2-91cc-55389686f2f2"), 100, "A menos de 150ºC" },
                    { new Guid("a11a1abc-1ec4-4587-8c35-07a93371cd0a"), "public/default/wash/less30.png", null, "Lavar a menos de 30ºC", 10, new Guid("3ce29e6e-89a5-4700-8b09-2de656b13103"), 100, "A menos de 30ºC" },
                    { new Guid("a3898f19-4de1-414f-991f-357ce0000fac"), "public/default/wash/less95.png", null, "Lavar a menos de 95ºC", 10, new Guid("3ce29e6e-89a5-4700-8b09-2de656b13103"), 100, "A menos de 95ºC" },
                    { new Guid("b33c19da-363f-46c5-9353-71540f65b8f3"), "public/default/iron/less200.png", null, "Engomar a menos de 200ºC", 10, new Guid("973dadb9-b07a-46c2-91cc-55389686f2f2"), 100, "A menos de 200ºC" },
                    { new Guid("b525aa7a-8999-4480-8a03-d10e6b27a3a0"), "public/default/service.png", null, "Escolhe um serviço de secagem", 10, new Guid("b6a455d6-593c-4941-969d-13d21705b92f"), 100, "Serviço de Secagem" },
                    { new Guid("e64f1fc9-f2d4-4492-b548-3c163a1257dc"), "public/default/dry/machine.png", null, "Secar na máquina", 10, new Guid("b6a455d6-593c-4941-969d-13d21705b92f"), 100, "Na máquina" },
                    { new Guid("f2802726-d963-409e-a9ed-caed80a4637c"), "public/default/wash/less70.png", null, "Lavar a menos de 70ºC", 10, new Guid("3ce29e6e-89a5-4700-8b09-2de656b13103"), 100, "A menos de 70ºC" }
                });

            migrationBuilder.Sql(File.ReadAllText("../BeatEcoprove.Infrastructure/Scripts/addTriggerNotification.sql"));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: new Guid("7f386d60-27b9-4c0d-b13b-c01ba2729693"));

            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: new Guid("b32b05ac-1531-4d8c-b6b9-f0b554ab557b"));

            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: new Guid("dc7fba3d-231b-4ef8-931f-c93c82a95365"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("1fa130a8-0514-4dcf-b4f6-3255ff3d033b"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("278fee68-f717-4b1e-b693-65dd5eb3b7d2"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("82be98b3-e3e6-49f9-9748-83ca3ffe3379"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("b6fbda96-110a-4287-9b2a-153e2855865e"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("d2111157-54e8-4ee2-a3be-373a93451793"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("0b98243f-f4ec-4ec4-9126-56c59a6b804d"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("2981afd0-c8aa-4926-8bda-bf71eb21892c"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("3460d900-15ef-471a-9a06-f45a8086195e"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("3ebad7bb-2b9b-452d-8a1d-fba0ad195a2e"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("472a0b25-5b5a-4bf1-b5da-96c7d0d675b8"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("5116d81b-2c83-427e-bcef-8c70c6f33668"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("5af4f66a-a8e2-457d-a9d7-79d84cf1c909"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("7f15774a-6a78-425e-bf94-60acf1258e74"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("87ddae47-fd57-45a3-85e1-d15f125765b0"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("8eed3bef-0fd6-4c88-ac8c-078ef81ba4e4"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("a11a1abc-1ec4-4587-8c35-07a93371cd0a"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("a3898f19-4de1-414f-991f-357ce0000fac"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("b33c19da-363f-46c5-9353-71540f65b8f3"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("b525aa7a-8999-4480-8a03-d10e6b27a3a0"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("e64f1fc9-f2d4-4492-b548-3c163a1257dc"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("f2802726-d963-409e-a9ed-caed80a4637c"));

            migrationBuilder.DeleteData(
                table: "maintenance_services",
                keyColumn: "id",
                keyValue: new Guid("3ce29e6e-89a5-4700-8b09-2de656b13103"));

            migrationBuilder.DeleteData(
                table: "maintenance_services",
                keyColumn: "id",
                keyValue: new Guid("973dadb9-b07a-46c2-91cc-55389686f2f2"));

            migrationBuilder.DeleteData(
                table: "maintenance_services",
                keyColumn: "id",
                keyValue: new Guid("aa883287-24ee-42e9-b1cb-3122e99f4d8a"));

            migrationBuilder.DeleteData(
                table: "maintenance_services",
                keyColumn: "id",
                keyValue: new Guid("b6a455d6-593c-4941-969d-13d21705b92f"));

            migrationBuilder.InsertData(
                table: "brands",
                columns: new[] { "id", "brand_avatar", "deleted_at", "name" },
                values: new object[,]
                {
                    { new Guid("36ce016d-b9de-48b0-a0d8-35d4f9501c62"), "...", null, "MO" },
                    { new Guid("d1440c3d-3f28-47dc-a202-c185272b1dbe"), "...", null, "Salsa" },
                    { new Guid("e3b3eddf-3037-4402-8ced-ff721c35481e"), "...", null, "Tifosi" }
                });

            migrationBuilder.InsertData(
                table: "colors",
                columns: new[] { "id", "deleted_at", "hex", "name" },
                values: new object[,]
                {
                    { new Guid("5d5155a4-9bad-425f-8444-a2c65291db07"), null, "FF00FF00", "Green" },
                    { new Guid("76eb11ce-11f7-4eef-850d-767443cb261f"), null, "FF000000", "Black" },
                    { new Guid("a94faae1-9c32-4418-b9e6-e02d8efbe1b7"), null, "FF0000FF", "Blue" },
                    { new Guid("db467672-13bc-4e6f-8e68-dd1defc71f9c"), null, "FFFF0000", "Red" },
                    { new Guid("e774cb84-ca95-4430-8610-d93aa57bd7d0"), null, "FFFFFFFF", "White" }
                });

            migrationBuilder.InsertData(
                table: "maintenance_services",
                columns: new[] { "id", "badge", "deleted_at", "description", "title" },
                values: new object[,]
                {
                    { new Guid("0eaefa43-2687-44ee-b3fb-527db9eb5dad"), "public/default/iron.png", null, "De que forma pertende engomar?", "Engomar" },
                    { new Guid("53ecb0f0-bb77-4875-8563-17eac5e97780"), "public/default/wash.png", null, "De que forma pertende lavar?", "Lavar" },
                    { new Guid("8e8ecf6e-7301-4f8a-9b5d-00768daade36"), "public/default/repair.png", null, "De que forma pertende arranjar a peça?", "Engomar" },
                    { new Guid("fa98a556-80d0-4dc3-a905-479e40f5030f"), "public/default/dry.png", null, "De que forma pertende secar?", "Secar" }
                });

            migrationBuilder.InsertData(
                table: "maintenance_service_actions",
                columns: new[] { "id", "badge", "deleted_at", "Description", "eco_score", "maintenance_service_id", "sustainable_points", "title" },
                values: new object[,]
                {
                    { new Guid("2b8c5d7a-1969-49b6-9385-80a5de0a89de"), "public/default/wash/less95.png", null, "Lavar a menos de 95ºC", 10, new Guid("53ecb0f0-bb77-4875-8563-17eac5e97780"), 100, "A menos de 95ºC" },
                    { new Guid("2e770e6d-fd87-467b-8cd6-20910c173810"), "public/default/wash/hand.png", null, "Lavar à mão com água e sabão", 10, new Guid("53ecb0f0-bb77-4875-8563-17eac5e97780"), 100, "Lavar à mão" },
                    { new Guid("336d12bc-ddc2-4cb8-bf6c-67f6f3c2ca8f"), "public/default/service.png", null, "Escolhe uma lavandaria", 10, new Guid("53ecb0f0-bb77-4875-8563-17eac5e97780"), 100, "Serviço de lavandaria" },
                    { new Guid("35b3eeae-294f-4c7f-9f40-8bc43982f740"), "public/default/iron/less200.png", null, "Engomar a menos de 200ºC", 10, new Guid("0eaefa43-2687-44ee-b3fb-527db9eb5dad"), 100, "A menos de 200ºC" },
                    { new Guid("3fc683e7-4b82-4319-af20-3c6ce2fb27fb"), "public/default/service.png", null, "Escolhe um serviço de engomadoria", 10, new Guid("0eaefa43-2687-44ee-b3fb-527db9eb5dad"), 100, "Serviço de Engomadoria" },
                    { new Guid("56b181b9-4c80-45e1-aef3-956f69bb739d"), "public/default/service.png", null, "Escolhe um serviço de secagem", 10, new Guid("fa98a556-80d0-4dc3-a905-479e40f5030f"), 100, "Serviço de Secagem" },
                    { new Guid("63a592a7-455e-4e9f-96c3-f031e5bacb02"), "public/default/wash/less30.png", null, "Lavar a menos de 30ºC", 10, new Guid("53ecb0f0-bb77-4875-8563-17eac5e97780"), 100, "A menos de 30ºC" },
                    { new Guid("724cb8f9-a04d-47b6-b8a2-de44ea2780e8"), "public/default/repair.png", null, "Arranjar a peça pelo próprio", 10, new Guid("8e8ecf6e-7301-4f8a-9b5d-00768daade36"), 100, "Pelo Próprio" },
                    { new Guid("7f6392e3-05fe-47da-a5f8-c9e24169dcd6"), "public/default/wash/less50.png", null, "Lavar a menos de 50ºC", 10, new Guid("53ecb0f0-bb77-4875-8563-17eac5e97780"), 100, "A menos de 50ºC" },
                    { new Guid("8176c49f-eaed-445f-8312-24fa0765d160"), "public/default/dry/air.png", null, "Secar ao ar livre", 10, new Guid("fa98a556-80d0-4dc3-a905-479e40f5030f"), 100, "Ao ar livre" },
                    { new Guid("a9117518-3a74-4c45-bf58-38a47ab8a413"), "public/default/wash/dry.png", null, "Lavar a seco", 10, new Guid("53ecb0f0-bb77-4875-8563-17eac5e97780"), 100, "A seco" },
                    { new Guid("a980f950-7749-47f1-8eb5-c8b2e369531a"), "public/default/service.png", null, "Escolhe um serviço de Reparação", 10, new Guid("8e8ecf6e-7301-4f8a-9b5d-00768daade36"), 100, "Serviço de Reparação" },
                    { new Guid("b76d9710-f953-4f55-9435-eb43fde8ae9b"), "public/default/iron/less150.png", null, "Engomar a menos de 150ºC", 10, new Guid("0eaefa43-2687-44ee-b3fb-527db9eb5dad"), 100, "A menos de 150ºC" },
                    { new Guid("c0268528-a255-4e06-afab-ed35d53ecbf3"), "public/default/wash/less70.png", null, "Lavar a menos de 70ºC", 10, new Guid("53ecb0f0-bb77-4875-8563-17eac5e97780"), 100, "A menos de 70ºC" },
                    { new Guid("c479d878-fb33-4335-a78c-77c8d76803d9"), "public/default/iron/less110.png", null, "Engomar a menos de 110ºC", 10, new Guid("0eaefa43-2687-44ee-b3fb-527db9eb5dad"), 100, "A menos de 110ºC" },
                    { new Guid("e3d43c5f-a303-40e7-80bc-b9d7a59ebe09"), "public/default/dry/machine.png", null, "Secar na máquina", 10, new Guid("fa98a556-80d0-4dc3-a905-479e40f5030f"), 100, "Na máquina" }
                });
        }
    }
}
