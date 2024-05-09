using System;

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BeatEcoprove.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddDeletedAtGroupAggregation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: new Guid("3468ec3a-97c8-4cca-92ed-d61de93c1cac"));

            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: new Guid("4da30967-df9f-4944-8574-39d9bca215bc"));

            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: new Guid("800a4079-214a-42ce-aa23-39de9e520db0"));

            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: new Guid("ccb630c9-9c22-4b88-a680-cf9be3abb28d"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("2d3ef177-302e-4c2b-94fa-9453a7d7e1a6"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("34945c27-702d-4ede-a4ff-4bd956948f5a"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("37bac44e-32d6-4b53-8e2e-34e10dd7bb5b"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("3dec56d2-9a6d-4666-97f6-3e7c01cbde51"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("456b8fe8-4e50-4666-8f55-faf56ccd7e3a"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("5116d861-94f6-4d9a-8562-604ebe6ffe3a"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("51ed1a26-e9ff-4c40-a5db-392cd6797dbd"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("5fdd6049-c495-4209-9579-16b9cd64515a"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("6ac7fcf6-9769-4fc3-91de-5880542ce2cd"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("6e54cdb3-845d-4af1-8815-b680192efb96"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("72ff7178-51bc-4367-8568-961294e58a8d"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("7b284523-b5ac-49e6-a896-09e86eae70c9"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("8c0a3cad-b284-410f-af51-aeb5bc109467"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("950997ae-2779-4a50-904c-421b0c531b21"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("b55a680d-13b6-4833-ad9b-eecca11357d0"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("b669c509-cf2b-4bdc-abf3-a4a4ff159c86"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("ba4383d7-99a6-4fc3-a8b6-4392eb87201e"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("c9d42a94-6660-4da2-95f1-38e2fcd694b8"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("d25fe3f8-bd74-4355-9466-67460db3d778"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("e82e2186-7661-4f35-be62-ce5df1e667f2"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("fbc7787a-d896-4cd3-a10b-5c8d4acc782e"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("04c7fe79-7492-4106-92ae-cb9f7f2b51f8"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("0887e272-db45-4dae-8cf2-32206cd5c7b8"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("0d3003ea-2073-4b80-9776-5740380ae6dc"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("17933120-77b9-4aee-bb67-64cda5a6c765"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("1f393ebb-f555-46db-be1e-d62899115893"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("2636172a-74f2-4928-a37e-59e9b7ebbf91"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("349a3ffc-3075-43af-8ccd-3b2f9540bd5e"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("5057361b-190a-406b-8b48-9f2b3a8f20e7"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("7b6570d0-d8e5-40ea-a5d9-cb13376be304"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("920f8dd9-9b33-4e4e-9146-c9649fd21537"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("9d003008-a2df-49e0-aaf0-087d6528aa95"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("b1e19f6b-3b3e-4a91-9bc8-d75a0e04cf9f"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("d6249f7b-54bd-4477-aa8f-95dfaa6307cb"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("e05c32e3-6ab6-446d-a2e8-73678d4cba51"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("e0b6ff00-e5d0-496c-a6d4-c978a034aaa7"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("fb4c8984-6eb1-46e7-895b-e961f028c075"));

            migrationBuilder.DeleteData(
                table: "maintenance_services",
                keyColumn: "id",
                keyValue: new Guid("0601b7b7-f3b6-4edd-9cad-f1fd0094d9ae"));

            migrationBuilder.DeleteData(
                table: "maintenance_services",
                keyColumn: "id",
                keyValue: new Guid("42b6e37c-4b01-45c9-8c09-642e8fc90694"));

            migrationBuilder.DeleteData(
                table: "maintenance_services",
                keyColumn: "id",
                keyValue: new Guid("aa8f0da0-bffa-48bd-855b-9ade0c21c254"));

            migrationBuilder.DeleteData(
                table: "maintenance_services",
                keyColumn: "id",
                keyValue: new Guid("e0c3f834-a760-46cc-833e-dc8451860277"));

            migrationBuilder.RenameColumn(
                name: "DeletedAt",
                table: "groups",
                newName: "deleted_at");

            migrationBuilder.RenameColumn(
                name: "DeletedAt",
                table: "group_members",
                newName: "deleted_at");

            migrationBuilder.RenameColumn(
                name: "DeletedAt",
                table: "group_invites",
                newName: "deleted_at");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: new Guid("41ceff9e-ab2d-451b-8620-1ab4bb11b01e"));

            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: new Guid("7d4d570a-161c-471d-a215-4a20bd9ac7fc"));

            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: new Guid("a75a802e-3d36-4758-a1bd-b6c10921fabd"));

            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "id",
                keyValue: new Guid("f7204e3f-abaa-470e-8414-bd2b9a125922"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("20fc9439-bfbc-464d-a926-9cb3611a60b8"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("255e8ded-4cb1-4cfa-af4a-d32f59782c2b"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("36276319-b7e8-45c7-abb1-367a9c2dd8d4"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("43fd3146-3d27-4587-8488-5777a03ce051"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("4da91aa9-9b5a-4ea2-a1f3-f90f129e131c"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("514d715f-d2be-46e6-a26e-def74f86c34f"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("6f0e8f81-1d26-42b0-8486-309d88f6706e"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("732ceee4-cbc1-4da2-ba48-9dabef21fd70"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("78d90733-b192-4964-b733-181d8188c995"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("83915387-5790-4e37-93c1-925524fdf83c"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("8596c490-f56c-4342-aca8-f57b022a0782"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("a9252ddf-31fd-4e1b-8bda-8619a38e5c6e"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("c29e07f5-f501-4b19-ad4e-04448924614d"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("c695cf1a-36d6-4bd8-9bf4-ad770a814b3e"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("c8b454d8-6c62-4c0d-8f9a-70f46e326825"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("d028205b-ff7a-4c79-bd26-1be1a8bae5a8"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("e3ce96e6-5bd8-4e1c-ba23-15753b192687"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("e87764b0-602b-407f-8550-07aee8fb7e9e"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("f186dbef-b99c-4516-ba23-7d5c2ad5323a"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("f4846e38-6ffe-447b-b754-3821205d1fa7"));

            migrationBuilder.DeleteData(
                table: "colors",
                keyColumn: "id",
                keyValue: new Guid("f89f40db-2b7f-402e-a6d1-acac00cd16a2"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("1b89d648-fa9e-4e44-a61d-6637096488df"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("39648a00-0e22-4094-a38c-42b9df16fecd"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("4082ffce-305f-430c-acb7-dc808d9f94a7"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("47596bcf-350f-4509-8cf4-e8029b532737"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("48eb4b7e-c4f7-446a-a2cf-10c666585055"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("508831ef-b6bd-49f4-8561-2b072ac8716d"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("59b08b9f-18bf-4e09-bc4e-c05ccaf70ba2"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("5de969a3-9d9c-489d-8002-1785899bad84"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("8be53abd-a205-4e01-a03c-d26ff8e20af7"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("96089038-8ded-48ef-8d5e-f7b24c5a91ee"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("a91d9133-4478-4394-bbbf-a40011e273de"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("ba6414ba-28e9-4e06-833e-e470cbc48e77"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("dd41c67b-ba1d-4c7a-81b1-3332b28f98e7"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("e161a149-2433-4554-aa46-74351dd929c9"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("e4330b1e-61dd-47bb-8fe9-f792495a20a9"));

            migrationBuilder.DeleteData(
                table: "maintenance_service_actions",
                keyColumn: "id",
                keyValue: new Guid("f75bba9f-e315-4694-a3be-642a83de9e10"));

            migrationBuilder.DeleteData(
                table: "maintenance_services",
                keyColumn: "id",
                keyValue: new Guid("2e2dc041-752f-4988-b1b9-539dc6b69171"));

            migrationBuilder.DeleteData(
                table: "maintenance_services",
                keyColumn: "id",
                keyValue: new Guid("3397ea20-8508-40a6-88b0-8641b0df9a6c"));

            migrationBuilder.DeleteData(
                table: "maintenance_services",
                keyColumn: "id",
                keyValue: new Guid("938b1c39-a683-4e1a-b2ad-51ffdd8a5923"));

            migrationBuilder.DeleteData(
                table: "maintenance_services",
                keyColumn: "id",
                keyValue: new Guid("d513efe0-a5fb-408a-8ade-2e173520f7ec"));

            migrationBuilder.RenameColumn(
                name: "deleted_at",
                table: "groups",
                newName: "DeletedAt");

            migrationBuilder.RenameColumn(
                name: "deleted_at",
                table: "group_members",
                newName: "DeletedAt");

            migrationBuilder.RenameColumn(
                name: "deleted_at",
                table: "group_invites",
                newName: "DeletedAt");

            migrationBuilder.InsertData(
                table: "brands",
                columns: new[] { "id", "brand_avatar", "deleted_at", "name" },
                values: new object[,]
                {
                    { new Guid("3468ec3a-97c8-4cca-92ed-d61de93c1cac"), "public/default/brands/losan.png", null, "Losan" },
                    { new Guid("4da30967-df9f-4944-8574-39d9bca215bc"), "public/default/brands/salsa.png", null, "Salsa" },
                    { new Guid("800a4079-214a-42ce-aa23-39de9e520db0"), "public/default/brands/zippy.png", null, "Zippy" },
                    { new Guid("ccb630c9-9c22-4b88-a680-cf9be3abb28d"), "public/default/brands/mo.png", null, "MO" }
                });
        }
    }
}
