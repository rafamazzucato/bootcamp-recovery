using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoMercadoMVC.Migrations
{
    public partial class UpdateIdentityTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB_VENDA_TB_USUARIO_ID_USUARIO_VENDA",
                table: "TB_VENDA");

            migrationBuilder.DropTable(
                name: "TB_USUARIO");

            migrationBuilder.AlterColumn<string>(
                name: "ID_USUARIO_VENDA",
                table: "TB_VENDA",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_TB_VENDA_AspNetUsers_ID_USUARIO_VENDA",
                table: "TB_VENDA",
                column: "ID_USUARIO_VENDA",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB_VENDA_AspNetUsers_ID_USUARIO_VENDA",
                table: "TB_VENDA");

            migrationBuilder.AlterColumn<int>(
                name: "ID_USUARIO_VENDA",
                table: "TB_VENDA",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "TB_USUARIO",
                columns: table => new
                {
                    ID_USUARIO = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NM_USUARIO = table.Column<string>(type: "VARCHAR(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_USUARIO", x => x.ID_USUARIO);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_TB_VENDA_TB_USUARIO_ID_USUARIO_VENDA",
                table: "TB_VENDA",
                column: "ID_USUARIO_VENDA",
                principalTable: "TB_USUARIO",
                principalColumn: "ID_USUARIO",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
