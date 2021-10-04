using Microsoft.EntityFrameworkCore.Migrations;

namespace JWTTeste.Migrations
{
    public partial class InitialDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_USUARIO",
                columns: table => new
                {
                    ID_USUARIO = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NM_USUARIO = table.Column<string>(type: "VARCHAR(100)", nullable: true),
                    CD_EMAIL = table.Column<string>(type: "VARCHAR(60)", nullable: true),
                    CD_SENHA = table.Column<string>(type: "VARCHAR(20)", nullable: true),
                    CD_PERFIL = table.Column<string>(type: "VARCHAR(20)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_USUARIO", x => x.ID_USUARIO);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_USUARIO");
        }
    }
}
