using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BeatEcoprove.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddOrderToStore : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: new Guid("425a08cc-2461-41bb-8675-b176bb123d17"));

            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: new Guid("58333572-1aa2-4593-943a-561656cb5442"));

            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: new Guid("76f849ce-dea4-4be1-b382-8d58e2700397"));

            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: new Guid("b654e9f3-eff8-4459-ac13-9f8de5410adb"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("01415c63-31c9-4c0e-871a-2c15eab5f310"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("070ea6d3-97fe-4da8-9126-02ead99a3ece"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("1951621c-fe5f-4862-be80-6aef862a8456"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("1f3bee85-4ac2-41f1-a833-b25d0d8bbee8"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("29cfea6b-8f83-4393-80be-fbb4369a34f3"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("4d325138-a5bc-4eaf-8276-2eda182a8655"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("54d6d0b6-77e8-4701-89bc-9ae04a2c1e91"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("6792374c-3fbe-4103-ac5c-53681b63dedb"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("6a02b907-456b-4e1e-96f6-dfb889d63897"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("6b49e020-594e-469d-bba3-439193d20f35"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("6c1f1c50-189b-47e4-8d58-2648e2cf41eb"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("6f7dfbd4-ab1f-45f6-a654-2f9e2346c9da"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("8fd93f80-e27b-4ded-b7f5-a0681687ff78"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("99222e34-260b-4ff7-b992-473bc7781cd0"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("a91ba19f-c014-4370-a575-1f1a44bc5d2b"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("ae0903f3-1ded-422b-88fa-a39d90b6e9eb"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("b52e1c6e-5db8-4224-905c-acf2363c0248"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("bc16833f-d275-4549-b37a-98ede7f9fdf7"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("becd4059-05b2-4daf-876a-2be7f7464a01"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("c1c908db-6402-4070-a34b-c3996082c99e"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("e9f77356-187c-47ac-8fc3-b5171e12b8ba"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("05f03e3d-9e58-416b-b101-0f432d1f0ed0"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("32934261-c460-4f4c-bdd8-ea0e2fcf05af"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("4571ac7e-39a5-410a-96c5-ee9904b89b82"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("6c73427d-6353-4aef-bbc6-589e523cf7b1"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("87bac1eb-24d4-4dce-a0df-0d0eacb1f646"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("89c46e4c-8f46-4a27-b536-7cc0aaba5ebe"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("a001c879-f216-4f59-9c3f-4be92ae219ae"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("a50d1561-f670-4a00-a024-195c0be5297b"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("ac866e00-72b6-4bb3-b587-63367f734a3d"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("b095ed57-75c0-485e-a525-6dda417f793a"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("c7e2a377-e74b-4000-a922-4c3521e48533"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("d62e1039-4de2-448c-ac6b-1e56c961aaa7"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("ec3b4627-d2d8-4416-8682-ae794124de0a"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("faed1a53-f944-47c5-87e1-6cffa38aab9e"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("fc706a98-3259-4fdd-bc96-3262fda6523c"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("fc96b20c-5688-40c7-8ac8-367bb02cd3a5"));

            migrationBuilder.DeleteData(
                table: "maintenance_services",
                keyColumn: "id",
                keyValue: new Guid("5c396f08-c679-4de4-b33f-cc9479339b65"));

            migrationBuilder.DeleteData(
                table: "maintenance_services",
                keyColumn: "id",
                keyValue: new Guid("b602935e-3aee-4f0d-9ca7-cfbb2fbdc30e"));

            migrationBuilder.DeleteData(
                table: "maintenance_services",
                keyColumn: "id",
                keyValue: new Guid("f213c179-9656-4966-9797-87cd47aaadc6"));

            migrationBuilder.DeleteData(
                table: "maintenance_services",
                keyColumn: "id",
                keyValue: new Guid("fcd97809-3160-4091-a3d5-219b557e3e00"));

            migrationBuilder.CreateTable(
                name: "store_orders",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    store = table.Column<Guid>(type: "uuid", nullable: false),
                    owner = table.Column<Guid>(type: "uuid", nullable: false),
                    assigned_worker = table.Column<Guid>(type: "uuid", nullable: false),
                    status = table.Column<int>(type: "integer", nullable: false),
                    accepted_at = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    type = table.Column<int>(type: "integer", nullable: false),
                    bucket = table.Column<Guid>(type: "uuid", nullable: true),
                    cloth = table.Column<Guid>(type: "uuid", nullable: true),
                    deleted_at = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_store_orders", x => x.id);
                    table.ForeignKey(
                        name: "FK_store_orders_buckets_bucket",
                        column: x => x.bucket,
                        principalTable: "buckets",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_store_orders_cloths_cloth",
                        column: x => x.cloth,
                        principalTable: "cloths",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_store_orders_profiles_owner",
                        column: x => x.owner,
                        principalTable: "profiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_store_orders_stores_store",
                        column: x => x.store,
                        principalTable: "stores",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_store_orders_workers_assigned_worker",
                        column: x => x.assigned_worker,
                        principalTable: "workers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "orders_maintenance_services",
                columns: table => new
                {
                    service = table.Column<Guid>(type: "uuid", nullable: false),
                    order = table.Column<Guid>(type: "uuid", nullable: false),
                    deleted_at = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_orders_maintenance_services", x => new { x.order, x.service });
                    table.ForeignKey(
                        name: "FK_orders_maintenance_services_maintenance_services_service",
                        column: x => x.service,
                        principalTable: "maintenance_services",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_orders_maintenance_services_store_orders_order",
                        column: x => x.order,
                        principalTable: "store_orders",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_orders_maintenance_services_service",
                table: "orders_maintenance_services",
                column: "service");

            migrationBuilder.CreateIndex(
                name: "IX_store_orders_assigned_worker",
                table: "store_orders",
                column: "assigned_worker");

            migrationBuilder.CreateIndex(
                name: "IX_store_orders_bucket",
                table: "store_orders",
                column: "bucket");

            migrationBuilder.CreateIndex(
                name: "IX_store_orders_cloth",
                table: "store_orders",
                column: "cloth");

            migrationBuilder.CreateIndex(
                name: "IX_store_orders_owner",
                table: "store_orders",
                column: "owner");

            migrationBuilder.CreateIndex(
                name: "IX_store_orders_store",
                table: "store_orders",
                column: "store");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "orders_maintenance_services");

            migrationBuilder.DropTable(
                name: "store_orders");

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

            migrationBuilder.InsertData(
                table: "brands",
                columns: new[] { "id", "brand_avatar", "deleted_at", "name" },
                values: new object[,]
                {
                    { new Guid("425a08cc-2461-41bb-8675-b176bb123d17"), "public/default/brands/losan.png", null, "Losan" },
                    { new Guid("58333572-1aa2-4593-943a-561656cb5442"), "public/default/brands/mo.png", null, "MO" },
                    { new Guid("76f849ce-dea4-4be1-b382-8d58e2700397"), "public/default/brands/zippy.png", null, "Zippy" },
                    { new Guid("b654e9f3-eff8-4459-ac13-9f8de5410adb"), "public/default/brands/salsa.png", null, "Salsa" }
                });

            migrationBuilder.InsertData(
                table: "colors",
                columns: new[] { "id", "deleted_at", "hex", "name" },
                values: new object[,]
                {
                    { new Guid("01415c63-31c9-4c0e-871a-2c15eab5f310"), null, "FF4C4C4C", "Cinzento Claro" },
                    { new Guid("070ea6d3-97fe-4da8-9126-02ead99a3ece"), null, "FFBE5967", "Rosa" },
                    { new Guid("1951621c-fe5f-4862-be80-6aef862a8456"), null, "FFFFE69F", "Amarelo" },
                    { new Guid("1f3bee85-4ac2-41f1-a833-b25d0d8bbee8"), null, "FFF58221", "Laranja" },
                    { new Guid("29cfea6b-8f83-4393-80be-fbb4369a34f3"), null, "FFD62598", "Roxo" },
                    { new Guid("4d325138-a5bc-4eaf-8276-2eda182a8655"), null, "FF4A2D16", "Castanho" },
                    { new Guid("54d6d0b6-77e8-4701-89bc-9ae04a2c1e91"), null, "FF509C75", "Verde" },
                    { new Guid("6792374c-3fbe-4103-ac5c-53681b63dedb"), null, "FFDA252E", "Vermelho" },
                    { new Guid("6a02b907-456b-4e1e-96f6-dfb889d63897"), null, "FFF9C7C4", "Rosa Claro" },
                    { new Guid("6b49e020-594e-469d-bba3-439193d20f35"), null, "FFFF6D6D", "Vermelho Claro" },
                    { new Guid("6c1f1c50-189b-47e4-8d58-2648e2cf41eb"), null, "FF000000", "Black" },
                    { new Guid("6f7dfbd4-ab1f-45f6-a654-2f9e2346c9da"), null, "FF8B5F3C", "Castanho Bebê" },
                    { new Guid("8fd93f80-e27b-4ded-b7f5-a0681687ff78"), null, "FF98B3C8", "Azul Claro" },
                    { new Guid("99222e34-260b-4ff7-b992-473bc7781cd0"), null, "FFC3A572", "Amarelo Claro" },
                    { new Guid("a91ba19f-c014-4370-a575-1f1a44bc5d2b"), null, "FFF2E7D4", "Amarelo Bebê" },
                    { new Guid("ae0903f3-1ded-422b-88fa-a39d90b6e9eb"), null, "FF29394A", "Azul Escuro" },
                    { new Guid("b52e1c6e-5db8-4224-905c-acf2363c0248"), null, "FFC2BC8B", "Verde Lima" },
                    { new Guid("bc16833f-d275-4549-b37a-98ede7f9fdf7"), null, "FF948066", "Castanho Claro" },
                    { new Guid("becd4059-05b2-4daf-876a-2be7f7464a01"), null, "FFC0C0C0", "Cinzento Bebê" },
                    { new Guid("c1c908db-6402-4070-a34b-c3996082c99e"), null, "FFD2AAC5", "Roxo Claro" },
                    { new Guid("e9f77356-187c-47ac-8fc3-b5171e12b8ba"), null, "FFFFFFFF", "White" }
                });

            migrationBuilder.InsertData(
                table: "maintenance_services",
                columns: new[] { "id", "badge", "deleted_at", "description", "title" },
                values: new object[,]
                {
                    { new Guid("5c396f08-c679-4de4-b33f-cc9479339b65"), "public/default/iron.png", null, "De que forma pretende engomar?", "Engomar" },
                    { new Guid("b602935e-3aee-4f0d-9ca7-cfbb2fbdc30e"), "public/default/wash.png", null, "De que forma pretende lavar?", "Lavar" },
                    { new Guid("f213c179-9656-4966-9797-87cd47aaadc6"), "public/default/dry.png", null, "De que forma pretende secar?", "Secar" },
                    { new Guid("fcd97809-3160-4091-a3d5-219b557e3e00"), "public/default/repair.png", null, "De que forma pretende arranjar a peça?", "Reparar" }
                });

            migrationBuilder.InsertData(
                table: "maintenance_service_actions",
                columns: new[] { "id", "badge", "deleted_at", "Description", "eco_score", "maintenance_service_id", "sustainable_points", "title" },
                values: new object[,]
                {
                    { new Guid("05f03e3d-9e58-416b-b101-0f432d1f0ed0"), "public/default/wash/less30.png", null, "Lavar a menos de 30ºC", -1, new Guid("b602935e-3aee-4f0d-9ca7-cfbb2fbdc30e"), 2, "A menos de 30ºC" },
                    { new Guid("32934261-c460-4f4c-bdd8-ea0e2fcf05af"), "public/default/service.png", null, "Escolhe um serviço de Reparação", 10, new Guid("fcd97809-3160-4091-a3d5-219b557e3e00"), 100, "Serviço de Reparação" },
                    { new Guid("4571ac7e-39a5-410a-96c5-ee9904b89b82"), "public/default/dry/air.png", null, "Secar ao ar livre", 0, new Guid("f213c179-9656-4966-9797-87cd47aaadc6"), 2, "Ao ar livre" },
                    { new Guid("6c73427d-6353-4aef-bbc6-589e523cf7b1"), "public/default/wash/less95.png", null, "Lavar a menos de 95ºC", -2, new Guid("b602935e-3aee-4f0d-9ca7-cfbb2fbdc30e"), 1, "A menos de 95ºC" },
                    { new Guid("87bac1eb-24d4-4dce-a0df-0d0eacb1f646"), "public/default/iron/less110.png", null, "Engomar a menos de 110ºC", -1, new Guid("5c396f08-c679-4de4-b33f-cc9479339b65"), 1, "A menos de 110ºC" },
                    { new Guid("89c46e4c-8f46-4a27-b536-7cc0aaba5ebe"), "public/default/repair.png", null, "Arranjar a peça pelo próprio", 2, new Guid("fcd97809-3160-4091-a3d5-219b557e3e00"), 3, "Pelo Próprio" },
                    { new Guid("a001c879-f216-4f59-9c3f-4be92ae219ae"), "public/default/service.png", null, "Escolhe uma lavandaria", 10, new Guid("b602935e-3aee-4f0d-9ca7-cfbb2fbdc30e"), 100, "Serviço de lavandaria" },
                    { new Guid("a50d1561-f670-4a00-a024-195c0be5297b"), "public/default/iron/less150.png", null, "Engomar a menos de 150ºC", -1, new Guid("5c396f08-c679-4de4-b33f-cc9479339b65"), 1, "A menos de 150ºC" },
                    { new Guid("ac866e00-72b6-4bb3-b587-63367f734a3d"), "public/default/wash/less70.png", null, "Lavar a menos de 70ºC", -2, new Guid("b602935e-3aee-4f0d-9ca7-cfbb2fbdc30e"), 1, "A menos de 70ºC" },
                    { new Guid("b095ed57-75c0-485e-a525-6dda417f793a"), "public/default/dry/machine.png", null, "Secar na máquina", -1, new Guid("f213c179-9656-4966-9797-87cd47aaadc6"), 1, "Na máquina" },
                    { new Guid("c7e2a377-e74b-4000-a922-4c3521e48533"), "public/default/service.png", null, "Escolhe um serviço de engomadoria", 10, new Guid("5c396f08-c679-4de4-b33f-cc9479339b65"), 100, "Serviço de Engomadoria" },
                    { new Guid("d62e1039-4de2-448c-ac6b-1e56c961aaa7"), "public/default/wash/dry.png", null, "Lavar a seco", -3, new Guid("b602935e-3aee-4f0d-9ca7-cfbb2fbdc30e"), 0, "A seco" },
                    { new Guid("ec3b4627-d2d8-4416-8682-ae794124de0a"), "public/default/wash/less50.png", null, "Lavar a menos de 50ºC", -2, new Guid("b602935e-3aee-4f0d-9ca7-cfbb2fbdc30e"), 1, "A menos de 50ºC" },
                    { new Guid("faed1a53-f944-47c5-87e1-6cffa38aab9e"), "public/default/service.png", null, "Escolhe um serviço de secagem", 10, new Guid("f213c179-9656-4966-9797-87cd47aaadc6"), 100, "Serviço de Secagem" },
                    { new Guid("fc706a98-3259-4fdd-bc96-3262fda6523c"), "public/default/iron/less200.png", null, "Engomar a menos de 200ºC", -1, new Guid("5c396f08-c679-4de4-b33f-cc9479339b65"), 1, "A menos de 200ºC" },
                    { new Guid("fc96b20c-5688-40c7-8ac8-367bb02cd3a5"), "public/default/wash/hand.png", null, "Lavar à mão com água e sabão", 10, new Guid("b602935e-3aee-4f0d-9ca7-cfbb2fbdc30e"), 100, "Lavar à mão" }
                });
        }
    }
}
