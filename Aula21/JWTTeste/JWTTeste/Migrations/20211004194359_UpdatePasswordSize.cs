using Microsoft.EntityFrameworkCore.Migrations;

namespace JWTTeste.Migrations
{
    public partial class UpdatePasswordSize : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CD_SENHA",
                table: "TB_USUARIO",
                type: "VARCHAR(60)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(20)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CD_SENHA",
                table: "TB_USUARIO",
                type: "VARCHAR(20)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(60)",
                oldNullable: true);
        }
    }
}
