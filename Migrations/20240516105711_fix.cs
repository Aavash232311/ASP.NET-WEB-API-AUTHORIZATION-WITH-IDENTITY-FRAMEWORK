using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ReactApp2.Server.Migrations
{
    /// <inheritdoc />
    public partial class fix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Details",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "Details",
                newName: "FirstName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Details",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Details",
                newName: "FullName");
        }
    }
}
