using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApiHandson.Migrations
{
    public partial class inits : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Commands");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Commands");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Commands",
                newName: "Comment");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Comment",
                table: "Commands",
                newName: "Name");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Commands",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Commands",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
