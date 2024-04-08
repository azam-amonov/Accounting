using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MicrosAccounting.Api.Migrations
{
    /// <inheritdoc />
    public partial class AddSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
