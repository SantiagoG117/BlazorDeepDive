using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ServerManagement.Migrations
{
    /// <inheritdoc />
    public partial class RenameServerTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_MyProperty",
                table: "MyProperty");

            migrationBuilder.RenameTable(
                name: "MyProperty",
                newName: "ServersManagement");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ServersManagement",
                table: "ServersManagement",
                column: "Id");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ServersManagement",
                table: "ServersManagement");

            migrationBuilder.RenameTable(
                name: "ServersManagement",
                newName: "MyProperty");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MyProperty",
                table: "MyProperty",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "MyProperty",
                keyColumn: "Id",
                keyValue: 2,
                column: "IsOnline",
                value: true);

            migrationBuilder.UpdateData(
                table: "MyProperty",
                keyColumn: "Id",
                keyValue: 5,
                column: "IsOnline",
                value: false);

            migrationBuilder.UpdateData(
                table: "MyProperty",
                keyColumn: "Id",
                keyValue: 10,
                column: "IsOnline",
                value: false);
        }
    }
}
