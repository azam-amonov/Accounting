using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MicrosAccounting.Api.Migrations
{
    /// <inheritdoc />
    public partial class AddNullType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("28014daa-db65-430d-a746-59f722c82a1c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3f4d326a-e03a-47aa-ae85-0daf6b87d04d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5217136e-25c8-428e-9996-591587d824e4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6398fa09-91b1-485f-b701-b8363f54c5b3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("90feb77d-fdd6-4bfe-afa9-257c43a8159e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("dc2ab154-aa13-481f-8112-87600cca4479"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f6424788-1f1b-4271-ad2d-12039a0bf202"));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Accounting", "Name" },
                values: new object[,]
                {
                    { new Guid("0ca6c0a4-2a85-4b88-9c42-2fb86334b1ed"), 1, "Food" },
                    { new Guid("1a99ed58-54fc-4c2d-b68d-f0f8c96f88c8"), 0, "Salary" },
                    { new Guid("71577dac-0a17-4a58-8285-7fdc5c008b4e"), 0, "Other Income" },
                    { new Guid("ba0c060a-2c9d-441d-837c-40aaaebd30a3"), 1, "Entertainment" },
                    { new Guid("ccabf5d2-4ad2-46c8-bd73-3d391f7ff918"), 1, "Internet" },
                    { new Guid("e1b10d79-d2e0-40bf-86d2-f7f05b868e66"), 1, "Mobile Connection" },
                    { new Guid("ed29109f-27df-43f5-b40d-8b2d12da3738"), 1, "Transport" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0ca6c0a4-2a85-4b88-9c42-2fb86334b1ed"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1a99ed58-54fc-4c2d-b68d-f0f8c96f88c8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("71577dac-0a17-4a58-8285-7fdc5c008b4e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ba0c060a-2c9d-441d-837c-40aaaebd30a3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ccabf5d2-4ad2-46c8-bd73-3d391f7ff918"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e1b10d79-d2e0-40bf-86d2-f7f05b868e66"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ed29109f-27df-43f5-b40d-8b2d12da3738"));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Accounting", "Name" },
                values: new object[,]
                {
                    { new Guid("28014daa-db65-430d-a746-59f722c82a1c"), 1, "Food" },
                    { new Guid("3f4d326a-e03a-47aa-ae85-0daf6b87d04d"), 0, "Other Income" },
                    { new Guid("5217136e-25c8-428e-9996-591587d824e4"), 1, "Transport" },
                    { new Guid("6398fa09-91b1-485f-b701-b8363f54c5b3"), 1, "Mobile Connection" },
                    { new Guid("90feb77d-fdd6-4bfe-afa9-257c43a8159e"), 1, "Entertainment" },
                    { new Guid("dc2ab154-aa13-481f-8112-87600cca4479"), 0, "Salary" },
                    { new Guid("f6424788-1f1b-4271-ad2d-12039a0bf202"), 1, "Internet" }
                });
        }
    }
}
