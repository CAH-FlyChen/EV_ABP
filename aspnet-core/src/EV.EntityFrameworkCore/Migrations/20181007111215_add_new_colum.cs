using Microsoft.EntityFrameworkCore.Migrations;

namespace EV.Migrations
{
    public partial class add_new_colum : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "ev_menubutton",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "ev_menubutton",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "ev_menu",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "ev_menu",
                maxLength: 20,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Code",
                table: "ev_menubutton");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "ev_menubutton");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "ev_menu");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "ev_menu");
        }
    }
}
