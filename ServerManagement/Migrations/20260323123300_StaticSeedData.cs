using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ServerManagement.Migrations
{
    /// <inheritdoc />
    public partial class StaticSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ServersManagement",
                keyColumn: "Id",
                keyValue: 2,
                column: "IsOnline",
                value: true);

            migrationBuilder.UpdateData(
                table: "ServersManagement",
                keyColumn: "Id",
                keyValue: 5,
                column: "IsOnline",
                value: false);

            migrationBuilder.UpdateData(
                table: "ServersManagement",
                keyColumn: "Id",
                keyValue: 10,
                column: "IsOnline",
                value: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ServersManagement",
                keyColumn: "Id",
                keyValue: 2,
                column: "IsOnline",
                value: false);

            migrationBuilder.UpdateData(
                table: "ServersManagement",
                keyColumn: "Id",
                keyValue: 5,
                column: "IsOnline",
                value: true);

            migrationBuilder.UpdateData(
                table: "ServersManagement",
                keyColumn: "Id",
                keyValue: 10,
                column: "IsOnline",
                value: true);
        }
    }
}
