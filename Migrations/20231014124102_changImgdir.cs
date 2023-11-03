using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E_Commerce_Project.Migrations
{
    public partial class changImgdir : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10babe9f-7f2a-4c2b-9eff-e49fd2e472c8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5fe01ca7-f5a9-4d2e-ac7f-277d64eb4c74");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductCode",
                keyValue: "da83d3a2-8c26-430e-aea1-646e80ce27d5");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductCode",
                keyValue: "f06a2849-e9d8-4ea0-b541-04d458e6540d");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "10babe9f-7f2a-4c2b-9eff-e49fd2e472c8", 0, "0040a32d-a6cf-4586-b678-796de33c7eb5", "OsamaHassan@gmail.com", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null, "AQAAAAEAACcQAAAAEEc/aRTS1FShfK4sZPZV8NrPtxXBuoZAw/X+PwjniOQa45uPuNXsJMsAIxdzwc21eQ==", null, false, "543f1520-ad5e-4fa7-818b-5ab48b777373", false, "OsamaHassan" },
                    { "5fe01ca7-f5a9-4d2e-ac7f-277d64eb4c74", 0, "c70c8663-2a12-466b-9f23-b9ccfc3534cf", "Mohandayman0127@gmail.com", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null, "AQAAAAEAACcQAAAAEDvd6NNUOJmpw7WFQMsUyrwE3NrD488o9gs4IcBcpTxShvYve6NCo6LKSoSmZ5daJw==", null, false, "19f2f1a1-3ee4-437d-9068-6260993183a7", false, "MohandAyman" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductCode", "CategoryId", "Discount_Rate", "ImgUrl", "Minimum_Quantity", "Name", "price" },
                values: new object[,]
                {
                    { "da83d3a2-8c26-430e-aea1-646e80ce27d5", 2, 0.1m, "img1.jpg", 500, "pants", 100m },
                    { "f06a2849-e9d8-4ea0-b541-04d458e6540d", 1, 0.2m, "img2.jpg", 1000, "mobile", 4000m }
                });
        }
    }
}
