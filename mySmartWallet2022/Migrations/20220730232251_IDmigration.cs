using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace mySmartWallet2022.Migrations
{
    public partial class IDmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Languages",
                newName: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Languages",
                newName: "ID");
        }
    }
}
