using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class mig_add_relation_customeraccount_appuser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<int>(
                name: "AppUserID",
                table: "customerAccounts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AppUserID",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_customerAccounts_AppUserID",
                table: "customerAccounts",
                column: "AppUserID");

            migrationBuilder.AddForeignKey(
                name: "FK_customerAccounts_AspNetUsers_AppUserID",
                table: "customerAccounts",
                column: "AppUserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_customerAccounts_AspNetUsers_AppUserID",
                table: "customerAccounts");

            migrationBuilder.DropIndex(
                name: "IX_customerAccounts_AppUserID",
                table: "customerAccounts");

            migrationBuilder.DropColumn(
                name: "AppUserID",
                table: "customerAccounts");

            migrationBuilder.DropColumn(
                name: "AppUserID",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
