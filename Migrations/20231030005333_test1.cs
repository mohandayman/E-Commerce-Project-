using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E_Commerce_Project.Migrations
{
    public partial class test1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "78c8562f-59c4-4219-9f82-1fc580dc5039");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "98195a42-fa61-4b80-b98b-d6e661e49f6d");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductCode",
                keyValue: "3007441f-2408-4354-812d-eeda17915608");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductCode",
                keyValue: "43da1284-8fd3-46ee-b460-8f314b188733");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LastLoginTime", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "7163c008-d27d-4965-b88b-d77cb473f06c", 0, "255238ee-0667-4555-abea-c8171528f09e", "Mohandayman0127@gmail.com", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null, "AQAAAAEAACcQAAAAEP5ai9OWWvzcrt3mdgWNi3qQMVa3iqKjuRvZOy05tS1oFrL2dvkG1E+T2pHSfK7h0Q==", null, false, "86b29b00-e3ae-4a73-abd6-ab4ebb6e14c6", false, "MohandAyman" },
                    { "9a91d5a4-2cd8-46af-a26a-57ca5c877b51", 0, "b7676117-b7ef-46c2-9d20-3f0189d650cf", "OsamaHassan@gmail.com", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null, "AQAAAAEAACcQAAAAEJYB7Y3JSzbm2FCjaeR3MZTvIi+0uxmb88zY/7S08BHdbkMwMBzvOtnvjzmPuxAwaA==", null, false, "e73b28cb-a392-4b55-b532-49d0d3778dee", false, "OsamaHassan" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductCode", "CategoryId", "Discount_Rate", "ImgUrl", "Minimum_Quantity", "Name", "price" },
                values: new object[,]
                {
                    { "8fff398b-22bc-40d7-b997-25ed4b3b5d0f", 2, 0.1m, "assets/Images/PantsImg.webp", 500, "pants", 100m },
                    { "96c01a1b-fcc2-4a57-aac0-b17834f97992", 1, 0.2m, "assets/Images/MobileImg.jpeg", 1000, "mobile", 4000m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7163c008-d27d-4965-b88b-d77cb473f06c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9a91d5a4-2cd8-46af-a26a-57ca5c877b51");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductCode",
                keyValue: "8fff398b-22bc-40d7-b997-25ed4b3b5d0f");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductCode",
                keyValue: "96c01a1b-fcc2-4a57-aac0-b17834f97992");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LastLoginTime", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "78c8562f-59c4-4219-9f82-1fc580dc5039", 0, "3e02fd18-0163-44c8-93bc-cd8e4ed5fc63", "OsamaHassan@gmail.com", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null, "AQAAAAEAACcQAAAAEMUA85JJ20F/e8F/RaGo1ydgOZhXlXYjR3YqT9jMZiWFFNbgNp6VsahGjtIT9RbGrA==", null, false, "4126e586-689f-41cc-ad9a-691115fb8cab", false, "OsamaHassan" },
                    { "98195a42-fa61-4b80-b98b-d6e661e49f6d", 0, "8f42d5de-12e1-4f79-9529-32394902fccb", "Mohandayman0127@gmail.com", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null, "AQAAAAEAACcQAAAAEIn/myDk020SFXpUbn8OpXLiU7EQNwsMFCK0wJpA7/kALZtksF6/t3RHE9vqGmX30g==", null, false, "61b729c9-4de3-4f3a-bddf-fd230fc99c65", false, "MohandAyman" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductCode", "CategoryId", "Discount_Rate", "ImgUrl", "Minimum_Quantity", "Name", "price" },
                values: new object[,]
                {
                    { "3007441f-2408-4354-812d-eeda17915608", 1, 0.2m, "assets/Images/MobileImg.jpeg", 1000, "mobile", 4000m },
                    { "43da1284-8fd3-46ee-b460-8f314b188733", 2, 0.1m, "assets/Images/PantsImg.webp", 500, "pants", 100m }
                });
        }
    }
}
