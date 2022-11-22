using Microsoft.EntityFrameworkCore.Migrations;

namespace Asp.netIdentitys.Data.Migrations
{
    public partial class ihyt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Staffs_User_UserId1",
                schema: "Identity",
                table: "Staffs");

            migrationBuilder.DropIndex(
                name: "IX_Staffs_UserId1",
                schema: "Identity",
                table: "Staffs");

            migrationBuilder.DropColumn(
                name: "UserId1",
                schema: "Identity",
                table: "Staffs");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                schema: "Identity",
                table: "Staffs",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Staffs_UserId",
                schema: "Identity",
                table: "Staffs",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Staffs_User_UserId",
                schema: "Identity",
                table: "Staffs",
                column: "UserId",
                principalSchema: "Identity",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Staffs_User_UserId",
                schema: "Identity",
                table: "Staffs");

            migrationBuilder.DropIndex(
                name: "IX_Staffs_UserId",
                schema: "Identity",
                table: "Staffs");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                schema: "Identity",
                table: "Staffs",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId1",
                schema: "Identity",
                table: "Staffs",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Staffs_UserId1",
                schema: "Identity",
                table: "Staffs",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Staffs_User_UserId1",
                schema: "Identity",
                table: "Staffs",
                column: "UserId1",
                principalSchema: "Identity",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
