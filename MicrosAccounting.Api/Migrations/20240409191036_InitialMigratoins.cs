using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MicrosAccounting.Api.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigratoins : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Accounting = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Password = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Transaction",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    Comment = table.Column<string>(type: "text", nullable: true),
                    Amount = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transaction", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Transaction_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Transaction_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Password" },
                values: new object[,]
                {
                    { new Guid("47729a8b-e359-493e-a982-e7c818cd1220"), "adim@microsoft.com", "Hello!11" },
                    { new Guid("8121adf5-6db9-46bb-ae3b-60b547526438"), "user@microsoft.com", "Hello!12" }
                });

            migrationBuilder.InsertData(
                table: "Transaction",
                columns: new[] { "Id", "Amount", "CategoryId", "Comment", "CreatedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("070e7930-b979-43a2-b512-69ad2999c2c1"), 90m, new Guid("0ca6c0a4-2a85-4b88-9c42-2fb86334b1ed"), "some comment", new DateTimeOffset(new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 5, 0, 0, 0)), new Guid("8121adf5-6db9-46bb-ae3b-60b547526438") },
                    { new Guid("5714ede8-db42-4fa0-845c-47ff57d29ff1"), 100m, new Guid("ed29109f-27df-43f5-b40d-8b2d12da3738"), "some comment", new DateTimeOffset(new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 5, 0, 0, 0)), new Guid("47729a8b-e359-493e-a982-e7c818cd1220") },
                    { new Guid("71065dfc-eaef-4f96-a1f9-5291a8467a86"), 5000m, new Guid("71577dac-0a17-4a58-8285-7fdc5c008b4e"), "some comment", new DateTimeOffset(new DateTime(2024, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 5, 0, 0, 0)), new Guid("8121adf5-6db9-46bb-ae3b-60b547526438") },
                    { new Guid("72144c30-d401-4b4a-be4c-13dcf4a8e567"), 500m, new Guid("0ca6c0a4-2a85-4b88-9c42-2fb86334b1ed"), "some comment", new DateTimeOffset(new DateTime(2024, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 5, 0, 0, 0)), new Guid("47729a8b-e359-493e-a982-e7c818cd1220") },
                    { new Guid("75b01b84-8590-4ce5-b2d6-b8fda47c2a4c"), 101m, new Guid("ed29109f-27df-43f5-b40d-8b2d12da3738"), "some comment", new DateTimeOffset(new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 5, 0, 0, 0)), new Guid("47729a8b-e359-493e-a982-e7c818cd1220") },
                    { new Guid("75c56079-9619-44a3-88a4-7675b09817d0"), 40m, new Guid("0ca6c0a4-2a85-4b88-9c42-2fb86334b1ed"), "some comment", new DateTimeOffset(new DateTime(2024, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 5, 0, 0, 0)), new Guid("8121adf5-6db9-46bb-ae3b-60b547526438") },
                    { new Guid("7f45cc7a-75e5-43b3-9993-44a1a2f54c28"), 6000m, new Guid("1a99ed58-54fc-4c2d-b68d-f0f8c96f88c8"), "some comment", new DateTimeOffset(new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 5, 0, 0, 0)), new Guid("47729a8b-e359-493e-a982-e7c818cd1220") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Transaction_CategoryId",
                table: "Transaction",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Transaction_UserId",
                table: "Transaction",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Transaction");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
