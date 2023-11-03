using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E_Commerce_Project.Migrations
{
    public partial class changImgdir2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25da1360-0e0d-4741-937f-a692c0019514");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e0e0e260-54c6-47c2-9d43-52d6582059a0");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductCode",
                keyValue: "ab807bab-7d17-4cef-a724-bcb11d93866d");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductCode",
                keyValue: "ca3c0b16-bb07-479f-8857-f4ff89b5ac4e");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "25da1360-0e0d-4741-937f-a692c0019514", 0, "8234d736-6c29-4f6f-90e2-9cb3d6a4bca4", "OsamaHassan@gmail.com", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null, "AQAAAAEAACcQAAAAENQgvtNc5QCTY4uWtBIdn5RFvumAc29Y73oe3WXnPHLn8vOP8RoabW3xNWZ7PHagQw==", null, false, "ff610a25-fb48-479c-b155-7f0f34cf89b0", false, "OsamaHassan" },
                    { "e0e0e260-54c6-47c2-9d43-52d6582059a0", 0, "cd4ed2d4-5719-4784-b809-d98c99aa6884", "Mohandayman0127@gmail.com", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null, "AQAAAAEAACcQAAAAEBXDsAcOSN1LsEk2fg6TFJCc5z1fepNfr9eqS01EEX5Ma/nfVBzeZAk1maHp0PdJgA==", null, false, "d04dd7ad-7d03-40a5-8e3a-3a2f0db80f22", false, "MohandAyman" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductCode", "CategoryId", "Discount_Rate", "ImgUrl", "Minimum_Quantity", "Name", "price" },
                values: new object[,]
                {
                    { "ab807bab-7d17-4cef-a724-bcb11d93866d", 1, 0.2m, "C:\\Users\\mohand\\Desktop\\E-Commerce Project\\E-commerce-Frontend\\src\\assets\\img\\MobileImg.jpeg", 1000, "mobile", 4000m },
                    { "ca3c0b16-bb07-479f-8857-f4ff89b5ac4e", 2, 0.1m, "C:\\Users\\mohand\\Desktop\\E-Commerce Project\\E-commerce-Frontend\\src\\assets\\img\\PantsImg.webp", 500, "pants", 100m }
                });
        }
    }
}
