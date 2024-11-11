using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TechBankAPI.Migrations
{
    /// <inheritdoc />
    public partial class UpdateUserDetailTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AccountNumber",
                table: "UserDetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "RoutingNumber",
                table: "UserDetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "isActiveAccount",
                table: "UserDetails",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AccountNumber",
                table: "UserDetails");

            migrationBuilder.DropColumn(
                name: "RoutingNumber",
                table: "UserDetails");

            migrationBuilder.DropColumn(
                name: "isActiveAccount",
                table: "UserDetails");
        }
    }
}
