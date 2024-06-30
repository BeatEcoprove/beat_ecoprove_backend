using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BeatEcoprove.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddRatingsToStore : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "rating",
                table: "stores");

            migrationBuilder.CreateTable(
                name: "store_ratings",
                columns: table => new
                {
                    store = table.Column<Guid>(type: "uuid", nullable: false),
                    user = table.Column<Guid>(type: "uuid", nullable: false),
                    rate = table.Column<double>(type: "double precision", nullable: false),
                    publish_at = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    deleted_at = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_store_ratings", x => new { x.store, x.user });
                    table.ForeignKey(
                        name: "FK_store_ratings_profiles_user",
                        column: x => x.user,
                        principalTable: "profiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_store_ratings_stores_store",
                        column: x => x.store,
                        principalTable: "stores",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_store_ratings_user",
                table: "store_ratings",
                column: "user");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "store_ratings");

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

            migrationBuilder.AddColumn<double>(
                name: "rating",
                table: "stores",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

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
    }
}
