using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MicrosAccounting.Api.Migrations
{
    /// <inheritdoc />
    public partial class Updatenames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Transaction",
                keyColumn: "Id",
                keyValue: new Guid("070e7930-b979-43a2-b512-69ad2999c2c1"),
                column: "TransactionDate",
                value: new DateTimeOffset(new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Transaction",
                keyColumn: "Id",
                keyValue: new Guid("5714ede8-db42-4fa0-845c-47ff57d29ff1"),
                column: "TransactionDate",
                value: new DateTimeOffset(new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Transaction",
                keyColumn: "Id",
                keyValue: new Guid("71065dfc-eaef-4f96-a1f9-5291a8467a86"),
                column: "TransactionDate",
                value: new DateTimeOffset(new DateTime(2024, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Transaction",
                keyColumn: "Id",
                keyValue: new Guid("72144c30-d401-4b4a-be4c-13dcf4a8e567"),
                column: "TransactionDate",
                value: new DateTimeOffset(new DateTime(2024, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Transaction",
                keyColumn: "Id",
                keyValue: new Guid("75b01b84-8590-4ce5-b2d6-b8fda47c2a4c"),
                column: "TransactionDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Transaction",
                keyColumn: "Id",
                keyValue: new Guid("75c56079-9619-44a3-88a4-7675b09817d0"),
                column: "TransactionDate",
                value: new DateTimeOffset(new DateTime(2024, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Transaction",
                keyColumn: "Id",
                keyValue: new Guid("7f45cc7a-75e5-43b3-9993-44a1a2f54c28"),
                column: "TransactionDate",
                value: new DateTimeOffset(new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 5, 0, 0, 0)));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Transaction",
                keyColumn: "Id",
                keyValue: new Guid("070e7930-b979-43a2-b512-69ad2999c2c1"),
                column: "TransactionDate",
                value: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Transaction",
                keyColumn: "Id",
                keyValue: new Guid("5714ede8-db42-4fa0-845c-47ff57d29ff1"),
                column: "TransactionDate",
                value: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Transaction",
                keyColumn: "Id",
                keyValue: new Guid("71065dfc-eaef-4f96-a1f9-5291a8467a86"),
                column: "TransactionDate",
                value: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Transaction",
                keyColumn: "Id",
                keyValue: new Guid("72144c30-d401-4b4a-be4c-13dcf4a8e567"),
                column: "TransactionDate",
                value: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Transaction",
                keyColumn: "Id",
                keyValue: new Guid("75b01b84-8590-4ce5-b2d6-b8fda47c2a4c"),
                column: "TransactionDate",
                value: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Transaction",
                keyColumn: "Id",
                keyValue: new Guid("75c56079-9619-44a3-88a4-7675b09817d0"),
                column: "TransactionDate",
                value: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Transaction",
                keyColumn: "Id",
                keyValue: new Guid("7f45cc7a-75e5-43b3-9993-44a1a2f54c28"),
                column: "TransactionDate",
                value: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));
        }
    }
}
