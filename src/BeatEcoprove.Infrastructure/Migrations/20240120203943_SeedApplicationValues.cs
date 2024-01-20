using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BeatEcoprove.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedApplicationValues : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
