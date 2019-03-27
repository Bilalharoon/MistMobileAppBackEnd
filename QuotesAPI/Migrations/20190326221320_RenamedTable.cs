using Microsoft.EntityFrameworkCore.Migrations;

namespace QuotesAPI.Migrations
{
    public partial class RenamedTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_UserModels",
                table: "UserModels");

            migrationBuilder.RenameTable(
                name: "UserModels",
                newName: "QuotesModel");

            migrationBuilder.AddPrimaryKey(
                name: "PK_QuotesModel",
                table: "QuotesModel",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_QuotesModel",
                table: "QuotesModel");

            migrationBuilder.RenameTable(
                name: "QuotesModel",
                newName: "UserModels");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserModels",
                table: "UserModels",
                column: "Id");
        }
    }
}
