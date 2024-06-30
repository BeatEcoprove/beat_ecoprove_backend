using System;
using Microsoft.EntityFrameworkCore.Migrations;
using NetTopologySuite.Geometries;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BeatEcoprove.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class FixStoreLocalizationColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: new Guid("05a36638-b5fb-458c-9b71-66db91c748eb"));

            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: new Guid("155b69c8-9dc9-49ba-b06b-fb1a54ccab5c"));

            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: new Guid("3d69309d-c520-46c9-8a94-2e678bfde4f2"));

            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: new Guid("ec95eca7-1865-47ce-b1e0-e8fd35773114"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("03f5fbb2-3957-4f57-829e-91afe49986fc"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("0645bc5b-6405-4828-8a99-ce871961bed0"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("143d6ff6-f77d-49be-9080-82658f6f0ebe"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("2482ad18-9572-4bcd-acdb-2b195e5f8c01"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("2b531f39-033a-44f0-b81c-ef6fc1a56e86"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("2c010e8b-8f45-4ca7-94ed-7bed92ede000"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("32bd7b0a-f0e5-49a5-a203-fdf7802a74d6"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("6dd56ffb-08e2-4414-820c-15117b8e48c9"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("7139c2b2-68f2-4977-b046-345fc489a13a"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("74f9d216-3567-482b-9887-c0a586c78258"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("783df109-ceed-49d1-bb70-1683862636fe"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("7a884a5c-fa11-4d8c-8ead-f4e0d3ce9236"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("7fa5b0c0-fe86-420f-bcc9-f10d53f18e61"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("8682c558-0bdd-4e01-a8e6-9343ea5feea6"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("a342ece8-aa52-426e-910f-7d9391b2c7d8"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("a7ed83e1-06a4-4b2a-be84-f8e86349eb6b"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("b37f1d61-728f-4e26-adf0-b9cdcd7c9630"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("b449b4e9-5a30-440a-86d9-3773cb719184"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("ccd848f7-8326-4651-b084-ae32f8263756"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("e7dca1dc-077f-494a-b647-207d3a032d05"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("e971a765-568d-4b82-b155-967af5c8c3db"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("1969cb77-f1ef-47a1-9e30-f02b589640a4"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("286449f1-3aa6-414b-b1d8-159f178a69e6"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("3b1f5e21-99e9-41d4-bc0b-fd3a32c69448"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("514c17c3-58f1-405a-a38a-b6c2218fe00d"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("624052a4-53a7-4255-b1cc-4ab50133140a"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("6c4260eb-e45c-4526-9d7e-a236e4a3180f"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("7202061e-f2b2-4c12-8e34-6f05b5f894a0"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("8c9b938c-1604-4a62-9750-a1253b95d25c"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("930651cf-17af-473c-b97e-da3cbeacab0f"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("9c657c53-2eb9-446e-8d77-465226eb5afd"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("9c9593f7-d984-4c80-9ae1-ce8326b94833"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("a8414f73-7f67-4bbc-8eb8-b5c8dfeb4b32"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("b4203568-eae2-4476-91b4-8ed194653d34"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("be8d35d5-440d-41d0-a40b-68ef54832ea8"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("d661dcce-1ca3-4c98-bbe0-e27250424bba"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("fd61c1df-b95a-4596-afd3-278c8387f51f"));

            migrationBuilder.DeleteData(
                table: "maintenance_services",
                keyColumn: "id",
                keyValue: new Guid("87671f78-2508-48b5-a8f5-6b97cc7404b6"));

            migrationBuilder.DeleteData(
                table: "maintenance_services",
                keyColumn: "id",
                keyValue: new Guid("b248beb6-8962-4bff-bfb7-fef25d0b0941"));

            migrationBuilder.DeleteData(
                table: "maintenance_services",
                keyColumn: "id",
                keyValue: new Guid("be25556d-0ff6-46be-8f90-c1acd79bde0f"));

            migrationBuilder.DeleteData(
                table: "maintenance_services",
                keyColumn: "id",
                keyValue: new Guid("d5fec31a-3a65-4531-b3a3-9e76f3728c03"));

            migrationBuilder.AlterColumn<Point>(
                name: "localization",
                table: "stores",
                type: "geography (point)",
                nullable: false,
                oldClrType: typeof(Point),
                oldType: "geometry");

            migrationBuilder.InsertData(
                table: "brands",
                columns: new[] { "id", "brand_avatar", "deleted_at", "name" },
                values: new object[,]
                {
                    { new Guid("3683deae-b289-491b-8d2d-cfc88c964c89"), "public/default/brands/losan.png", null, "Losan" },
                    { new Guid("b97eaeae-2044-402e-b4ce-079514a7cfbc"), "public/default/brands/zippy.png", null, "Zippy" },
                    { new Guid("d294354e-b55d-43b9-a3c3-1ccb46152fbb"), "public/default/brands/mo.png", null, "MO" },
                    { new Guid("e6de64a5-c35e-4394-b7c6-6c357838a5e1"), "public/default/brands/salsa.png", null, "Salsa" }
                });

            migrationBuilder.InsertData(
                table: "colors",
                columns: new[] { "id", "deleted_at", "hex", "name" },
                values: new object[,]
                {
                    { new Guid("01a8e673-e4f4-4561-bd77-5cf2d01e80f3"), null, "FFBE5967", "Rosa" },
                    { new Guid("0314792d-f53e-471f-8dd9-37ad0157e86e"), null, "FF000000", "Black" },
                    { new Guid("0555e239-bcac-4bdb-9bcf-59bb7e698aa4"), null, "FFFFFFFF", "White" },
                    { new Guid("0ec2cd9e-1ec3-4f9d-9d51-b22dcb6cdc6f"), null, "FF4A2D16", "Castanho" },
                    { new Guid("0ef8726b-709b-4814-9270-649b8def2fe8"), null, "FFC0C0C0", "Cinzento Bebê" },
                    { new Guid("265930cb-e339-496d-af12-75dcfed46592"), null, "FF8B5F3C", "Castanho Bebê" },
                    { new Guid("2b4e7bc0-e0fc-4978-859b-8f67392383cd"), null, "FF948066", "Castanho Claro" },
                    { new Guid("3d791d80-2c90-487a-95d3-e2cd3b62290b"), null, "FF29394A", "Azul Escuro" },
                    { new Guid("4cb00b1d-39f3-4fa6-a6cd-8caf40a2d347"), null, "FFF9C7C4", "Rosa Claro" },
                    { new Guid("64e61d5f-56c2-42c3-8a4e-423def75b387"), null, "FFF2E7D4", "Amarelo Bebê" },
                    { new Guid("745b1ffc-e3e9-45fd-ac96-4f9faf62ee4c"), null, "FFDA252E", "Vermelho" },
                    { new Guid("86700f0c-d651-4b09-9797-7df7f4b4ea8d"), null, "FFD62598", "Roxo" },
                    { new Guid("99009bef-9f08-4bf8-95cd-d7bc11d83fc5"), null, "FF98B3C8", "Azul Claro" },
                    { new Guid("b1fd43a4-5ce2-4d3d-93e2-6180785c942c"), null, "FF4C4C4C", "Cinzento Claro" },
                    { new Guid("cbd139cf-159f-42f1-bfcd-bbf0c82050f8"), null, "FFFF6D6D", "Vermelho Claro" },
                    { new Guid("d1397448-7dcc-4220-81cd-66c953b14677"), null, "FFD2AAC5", "Roxo Claro" },
                    { new Guid("d2e62368-bd89-46ff-9a4d-7da1a478a59f"), null, "FFF58221", "Laranja" },
                    { new Guid("e40acc90-85f8-4e33-9151-86821a4a3319"), null, "FFFFE69F", "Amarelo" },
                    { new Guid("ed0dda53-595a-4841-a9c7-79f783512831"), null, "FF509C75", "Verde" },
                    { new Guid("ef61b0f6-ec7b-4793-8b05-df8bf0097ed0"), null, "FFC3A572", "Amarelo Claro" },
                    { new Guid("fbbc9f0d-d01d-4407-aac8-5b3a574212e1"), null, "FFC2BC8B", "Verde Lima" }
                });

            migrationBuilder.InsertData(
                table: "maintenance_services",
                columns: new[] { "id", "badge", "deleted_at", "description", "title" },
                values: new object[,]
                {
                    { new Guid("4792b066-55ce-48d3-94e6-7edad62855fa"), "public/default/wash.png", null, "De que forma pretende lavar?", "Lavar" },
                    { new Guid("4a4091eb-8e73-4caf-a87c-b467895e10b5"), "public/default/repair.png", null, "De que forma pretende arranjar a peça?", "Reparar" },
                    { new Guid("4f79b84f-f6c1-4b61-9e21-4966980911c2"), "public/default/iron.png", null, "De que forma pretende engomar?", "Engomar" },
                    { new Guid("f847e091-ac50-466f-9a3e-6f041fdaf43f"), "public/default/dry.png", null, "De que forma pretende secar?", "Secar" }
                });

            migrationBuilder.InsertData(
                table: "maintenance_service_actions",
                columns: new[] { "id", "badge", "deleted_at", "Description", "eco_score", "maintenance_service_id", "sustainable_points", "title" },
                values: new object[,]
                {
                    { new Guid("183e7713-b743-4d8c-85f3-479f395b5199"), "public/default/service.png", null, "Escolhe um serviço de secagem", 10, new Guid("f847e091-ac50-466f-9a3e-6f041fdaf43f"), 100, "Serviço de Secagem" },
                    { new Guid("22eeed64-4652-4422-b487-1508dbee1c25"), "public/default/iron/less200.png", null, "Engomar a menos de 200ºC", -1, new Guid("4f79b84f-f6c1-4b61-9e21-4966980911c2"), 1, "A menos de 200ºC" },
                    { new Guid("348127ef-c645-403f-a4e0-f9a062b2b06f"), "public/default/iron/less150.png", null, "Engomar a menos de 150ºC", -1, new Guid("4f79b84f-f6c1-4b61-9e21-4966980911c2"), 1, "A menos de 150ºC" },
                    { new Guid("3c71a180-fcc2-4fe2-90ac-14a59d9ca07a"), "public/default/dry/air.png", null, "Secar ao ar livre", 0, new Guid("f847e091-ac50-466f-9a3e-6f041fdaf43f"), 2, "Ao ar livre" },
                    { new Guid("4011dcc7-9ea7-44a1-b998-cf07ba7c24f2"), "public/default/dry/machine.png", null, "Secar na máquina", -1, new Guid("f847e091-ac50-466f-9a3e-6f041fdaf43f"), 1, "Na máquina" },
                    { new Guid("42d1f6db-f65b-4254-bc7a-ee4d7b86067d"), "public/default/wash/hand.png", null, "Lavar à mão com água e sabão", 10, new Guid("4792b066-55ce-48d3-94e6-7edad62855fa"), 100, "Lavar à mão" },
                    { new Guid("5272d6bc-6482-4c5e-946b-bfe8309ec4f0"), "public/default/repair.png", null, "Arranjar a peça pelo próprio", 2, new Guid("4a4091eb-8e73-4caf-a87c-b467895e10b5"), 3, "Pelo Próprio" },
                    { new Guid("59351ec5-c1a5-4c4b-a3d7-1492081af0b4"), "public/default/wash/less30.png", null, "Lavar a menos de 30ºC", -1, new Guid("4792b066-55ce-48d3-94e6-7edad62855fa"), 2, "A menos de 30ºC" },
                    { new Guid("98bb2a05-a098-4aa1-87dc-0a5486f29142"), "public/default/wash/dry.png", null, "Lavar a seco", -3, new Guid("4792b066-55ce-48d3-94e6-7edad62855fa"), 0, "A seco" },
                    { new Guid("9ec83720-7b1f-44d8-8185-a6c696789246"), "public/default/service.png", null, "Escolhe um serviço de Reparação", 10, new Guid("4a4091eb-8e73-4caf-a87c-b467895e10b5"), 100, "Serviço de Reparação" },
                    { new Guid("aa1e395e-f3ef-4852-8a09-dc22510b2c71"), "public/default/iron/less110.png", null, "Engomar a menos de 110ºC", -1, new Guid("4f79b84f-f6c1-4b61-9e21-4966980911c2"), 1, "A menos de 110ºC" },
                    { new Guid("ae08b4cb-c653-42fa-936f-5c27bf5e9669"), "public/default/wash/less95.png", null, "Lavar a menos de 95ºC", -2, new Guid("4792b066-55ce-48d3-94e6-7edad62855fa"), 1, "A menos de 95ºC" },
                    { new Guid("b01c912a-854e-4bbd-bd70-cbc7895aa3e7"), "public/default/wash/less70.png", null, "Lavar a menos de 70ºC", -2, new Guid("4792b066-55ce-48d3-94e6-7edad62855fa"), 1, "A menos de 70ºC" },
                    { new Guid("c8f53140-6691-47c2-be2e-2ddbdf9befba"), "public/default/wash/less50.png", null, "Lavar a menos de 50ºC", -2, new Guid("4792b066-55ce-48d3-94e6-7edad62855fa"), 1, "A menos de 50ºC" },
                    { new Guid("cfd919f1-dab0-44ac-a58f-90205f4ddcc7"), "public/default/service.png", null, "Escolhe um serviço de engomadoria", 10, new Guid("4f79b84f-f6c1-4b61-9e21-4966980911c2"), 100, "Serviço de Engomadoria" },
                    { new Guid("f25b89a6-17cd-4b07-a86d-b2d38421cf7a"), "public/default/service.png", null, "Escolhe uma lavandaria", 10, new Guid("4792b066-55ce-48d3-94e6-7edad62855fa"), 100, "Serviço de lavandaria" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: new Guid("3683deae-b289-491b-8d2d-cfc88c964c89"));

            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: new Guid("b97eaeae-2044-402e-b4ce-079514a7cfbc"));

            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: new Guid("d294354e-b55d-43b9-a3c3-1ccb46152fbb"));

            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: new Guid("e6de64a5-c35e-4394-b7c6-6c357838a5e1"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("01a8e673-e4f4-4561-bd77-5cf2d01e80f3"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("0314792d-f53e-471f-8dd9-37ad0157e86e"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("0555e239-bcac-4bdb-9bcf-59bb7e698aa4"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("0ec2cd9e-1ec3-4f9d-9d51-b22dcb6cdc6f"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("0ef8726b-709b-4814-9270-649b8def2fe8"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("265930cb-e339-496d-af12-75dcfed46592"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("2b4e7bc0-e0fc-4978-859b-8f67392383cd"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("3d791d80-2c90-487a-95d3-e2cd3b62290b"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("4cb00b1d-39f3-4fa6-a6cd-8caf40a2d347"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("64e61d5f-56c2-42c3-8a4e-423def75b387"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("745b1ffc-e3e9-45fd-ac96-4f9faf62ee4c"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("86700f0c-d651-4b09-9797-7df7f4b4ea8d"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("99009bef-9f08-4bf8-95cd-d7bc11d83fc5"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("b1fd43a4-5ce2-4d3d-93e2-6180785c942c"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("cbd139cf-159f-42f1-bfcd-bbf0c82050f8"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("d1397448-7dcc-4220-81cd-66c953b14677"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("d2e62368-bd89-46ff-9a4d-7da1a478a59f"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("e40acc90-85f8-4e33-9151-86821a4a3319"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("ed0dda53-595a-4841-a9c7-79f783512831"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("ef61b0f6-ec7b-4793-8b05-df8bf0097ed0"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("fbbc9f0d-d01d-4407-aac8-5b3a574212e1"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("183e7713-b743-4d8c-85f3-479f395b5199"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("22eeed64-4652-4422-b487-1508dbee1c25"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("348127ef-c645-403f-a4e0-f9a062b2b06f"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("3c71a180-fcc2-4fe2-90ac-14a59d9ca07a"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("4011dcc7-9ea7-44a1-b998-cf07ba7c24f2"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("42d1f6db-f65b-4254-bc7a-ee4d7b86067d"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("5272d6bc-6482-4c5e-946b-bfe8309ec4f0"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("59351ec5-c1a5-4c4b-a3d7-1492081af0b4"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("98bb2a05-a098-4aa1-87dc-0a5486f29142"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("9ec83720-7b1f-44d8-8185-a6c696789246"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("aa1e395e-f3ef-4852-8a09-dc22510b2c71"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("ae08b4cb-c653-42fa-936f-5c27bf5e9669"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("b01c912a-854e-4bbd-bd70-cbc7895aa3e7"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("c8f53140-6691-47c2-be2e-2ddbdf9befba"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("cfd919f1-dab0-44ac-a58f-90205f4ddcc7"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("f25b89a6-17cd-4b07-a86d-b2d38421cf7a"));

            migrationBuilder.DeleteData(
                table: "maintenance_services",
                keyColumn: "id",
                keyValue: new Guid("4792b066-55ce-48d3-94e6-7edad62855fa"));

            migrationBuilder.DeleteData(
                table: "maintenance_services",
                keyColumn: "id",
                keyValue: new Guid("4a4091eb-8e73-4caf-a87c-b467895e10b5"));

            migrationBuilder.DeleteData(
                table: "maintenance_services",
                keyColumn: "id",
                keyValue: new Guid("4f79b84f-f6c1-4b61-9e21-4966980911c2"));

            migrationBuilder.DeleteData(
                table: "maintenance_services",
                keyColumn: "id",
                keyValue: new Guid("f847e091-ac50-466f-9a3e-6f041fdaf43f"));

            migrationBuilder.AlterColumn<Point>(
                name: "localization",
                table: "stores",
                type: "geometry",
                nullable: false,
                oldClrType: typeof(Point),
                oldType: "geography (point)");

            migrationBuilder.InsertData(
                table: "brands",
                columns: new[] { "id", "brand_avatar", "deleted_at", "name" },
                values: new object[,]
                {
                    { new Guid("05a36638-b5fb-458c-9b71-66db91c748eb"), "public/default/brands/mo.png", null, "MO" },
                    { new Guid("155b69c8-9dc9-49ba-b06b-fb1a54ccab5c"), "public/default/brands/salsa.png", null, "Salsa" },
                    { new Guid("3d69309d-c520-46c9-8a94-2e678bfde4f2"), "public/default/brands/losan.png", null, "Losan" },
                    { new Guid("ec95eca7-1865-47ce-b1e0-e8fd35773114"), "public/default/brands/zippy.png", null, "Zippy" }
                });

            migrationBuilder.InsertData(
                table: "colors",
                columns: new[] { "id", "deleted_at", "hex", "name" },
                values: new object[,]
                {
                    { new Guid("03f5fbb2-3957-4f57-829e-91afe49986fc"), null, "FFD2AAC5", "Roxo Claro" },
                    { new Guid("0645bc5b-6405-4828-8a99-ce871961bed0"), null, "FF8B5F3C", "Castanho Bebê" },
                    { new Guid("143d6ff6-f77d-49be-9080-82658f6f0ebe"), null, "FFC2BC8B", "Verde Lima" },
                    { new Guid("2482ad18-9572-4bcd-acdb-2b195e5f8c01"), null, "FFC3A572", "Amarelo Claro" },
                    { new Guid("2b531f39-033a-44f0-b81c-ef6fc1a56e86"), null, "FFD62598", "Roxo" },
                    { new Guid("2c010e8b-8f45-4ca7-94ed-7bed92ede000"), null, "FF948066", "Castanho Claro" },
                    { new Guid("32bd7b0a-f0e5-49a5-a203-fdf7802a74d6"), null, "FF4A2D16", "Castanho" },
                    { new Guid("6dd56ffb-08e2-4414-820c-15117b8e48c9"), null, "FFF9C7C4", "Rosa Claro" },
                    { new Guid("7139c2b2-68f2-4977-b046-345fc489a13a"), null, "FFFFFFFF", "White" },
                    { new Guid("74f9d216-3567-482b-9887-c0a586c78258"), null, "FF000000", "Black" },
                    { new Guid("783df109-ceed-49d1-bb70-1683862636fe"), null, "FFF58221", "Laranja" },
                    { new Guid("7a884a5c-fa11-4d8c-8ead-f4e0d3ce9236"), null, "FFF2E7D4", "Amarelo Bebê" },
                    { new Guid("7fa5b0c0-fe86-420f-bcc9-f10d53f18e61"), null, "FF98B3C8", "Azul Claro" },
                    { new Guid("8682c558-0bdd-4e01-a8e6-9343ea5feea6"), null, "FF29394A", "Azul Escuro" },
                    { new Guid("a342ece8-aa52-426e-910f-7d9391b2c7d8"), null, "FFBE5967", "Rosa" },
                    { new Guid("a7ed83e1-06a4-4b2a-be84-f8e86349eb6b"), null, "FF4C4C4C", "Cinzento Claro" },
                    { new Guid("b37f1d61-728f-4e26-adf0-b9cdcd7c9630"), null, "FF509C75", "Verde" },
                    { new Guid("b449b4e9-5a30-440a-86d9-3773cb719184"), null, "FFC0C0C0", "Cinzento Bebê" },
                    { new Guid("ccd848f7-8326-4651-b084-ae32f8263756"), null, "FFFF6D6D", "Vermelho Claro" },
                    { new Guid("e7dca1dc-077f-494a-b647-207d3a032d05"), null, "FFDA252E", "Vermelho" },
                    { new Guid("e971a765-568d-4b82-b155-967af5c8c3db"), null, "FFFFE69F", "Amarelo" }
                });

            migrationBuilder.InsertData(
                table: "maintenance_services",
                columns: new[] { "id", "badge", "deleted_at", "description", "title" },
                values: new object[,]
                {
                    { new Guid("87671f78-2508-48b5-a8f5-6b97cc7404b6"), "public/default/iron.png", null, "De que forma pretende engomar?", "Engomar" },
                    { new Guid("b248beb6-8962-4bff-bfb7-fef25d0b0941"), "public/default/repair.png", null, "De que forma pretende arranjar a peça?", "Reparar" },
                    { new Guid("be25556d-0ff6-46be-8f90-c1acd79bde0f"), "public/default/wash.png", null, "De que forma pretende lavar?", "Lavar" },
                    { new Guid("d5fec31a-3a65-4531-b3a3-9e76f3728c03"), "public/default/dry.png", null, "De que forma pretende secar?", "Secar" }
                });

            migrationBuilder.InsertData(
                table: "maintenance_service_actions",
                columns: new[] { "id", "badge", "deleted_at", "Description", "eco_score", "maintenance_service_id", "sustainable_points", "title" },
                values: new object[,]
                {
                    { new Guid("1969cb77-f1ef-47a1-9e30-f02b589640a4"), "public/default/iron/less110.png", null, "Engomar a menos de 110ºC", -1, new Guid("87671f78-2508-48b5-a8f5-6b97cc7404b6"), 1, "A menos de 110ºC" },
                    { new Guid("286449f1-3aa6-414b-b1d8-159f178a69e6"), "public/default/wash/less95.png", null, "Lavar a menos de 95ºC", -2, new Guid("be25556d-0ff6-46be-8f90-c1acd79bde0f"), 1, "A menos de 95ºC" },
                    { new Guid("3b1f5e21-99e9-41d4-bc0b-fd3a32c69448"), "public/default/wash/less50.png", null, "Lavar a menos de 50ºC", -2, new Guid("be25556d-0ff6-46be-8f90-c1acd79bde0f"), 1, "A menos de 50ºC" },
                    { new Guid("514c17c3-58f1-405a-a38a-b6c2218fe00d"), "public/default/dry/machine.png", null, "Secar na máquina", -1, new Guid("d5fec31a-3a65-4531-b3a3-9e76f3728c03"), 1, "Na máquina" },
                    { new Guid("624052a4-53a7-4255-b1cc-4ab50133140a"), "public/default/wash/less70.png", null, "Lavar a menos de 70ºC", -2, new Guid("be25556d-0ff6-46be-8f90-c1acd79bde0f"), 1, "A menos de 70ºC" },
                    { new Guid("6c4260eb-e45c-4526-9d7e-a236e4a3180f"), "public/default/service.png", null, "Escolhe um serviço de Reparação", 10, new Guid("b248beb6-8962-4bff-bfb7-fef25d0b0941"), 100, "Serviço de Reparação" },
                    { new Guid("7202061e-f2b2-4c12-8e34-6f05b5f894a0"), "public/default/service.png", null, "Escolhe uma lavandaria", 10, new Guid("be25556d-0ff6-46be-8f90-c1acd79bde0f"), 100, "Serviço de lavandaria" },
                    { new Guid("8c9b938c-1604-4a62-9750-a1253b95d25c"), "public/default/iron/less150.png", null, "Engomar a menos de 150ºC", -1, new Guid("87671f78-2508-48b5-a8f5-6b97cc7404b6"), 1, "A menos de 150ºC" },
                    { new Guid("930651cf-17af-473c-b97e-da3cbeacab0f"), "public/default/wash/dry.png", null, "Lavar a seco", -3, new Guid("be25556d-0ff6-46be-8f90-c1acd79bde0f"), 0, "A seco" },
                    { new Guid("9c657c53-2eb9-446e-8d77-465226eb5afd"), "public/default/wash/less30.png", null, "Lavar a menos de 30ºC", -1, new Guid("be25556d-0ff6-46be-8f90-c1acd79bde0f"), 2, "A menos de 30ºC" },
                    { new Guid("9c9593f7-d984-4c80-9ae1-ce8326b94833"), "public/default/iron/less200.png", null, "Engomar a menos de 200ºC", -1, new Guid("87671f78-2508-48b5-a8f5-6b97cc7404b6"), 1, "A menos de 200ºC" },
                    { new Guid("a8414f73-7f67-4bbc-8eb8-b5c8dfeb4b32"), "public/default/service.png", null, "Escolhe um serviço de engomadoria", 10, new Guid("87671f78-2508-48b5-a8f5-6b97cc7404b6"), 100, "Serviço de Engomadoria" },
                    { new Guid("b4203568-eae2-4476-91b4-8ed194653d34"), "public/default/service.png", null, "Escolhe um serviço de secagem", 10, new Guid("d5fec31a-3a65-4531-b3a3-9e76f3728c03"), 100, "Serviço de Secagem" },
                    { new Guid("be8d35d5-440d-41d0-a40b-68ef54832ea8"), "public/default/repair.png", null, "Arranjar a peça pelo próprio", 2, new Guid("b248beb6-8962-4bff-bfb7-fef25d0b0941"), 3, "Pelo Próprio" },
                    { new Guid("d661dcce-1ca3-4c98-bbe0-e27250424bba"), "public/default/dry/air.png", null, "Secar ao ar livre", 0, new Guid("d5fec31a-3a65-4531-b3a3-9e76f3728c03"), 2, "Ao ar livre" },
                    { new Guid("fd61c1df-b95a-4596-afd3-278c8387f51f"), "public/default/wash/hand.png", null, "Lavar à mão com água e sabão", 10, new Guid("be25556d-0ff6-46be-8f90-c1acd79bde0f"), 100, "Lavar à mão" }
                });
        }
    }
}
