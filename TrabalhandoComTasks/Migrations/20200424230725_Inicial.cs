using Microsoft.EntityFrameworkCore.Migrations;

namespace TrabalhandoComTasks.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GrupoPessoa",
                columns: table => new
                {
                    idGrupoPessoa = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nomeGrupo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_grupoPessoa", x => x.idGrupoPessoa);
                });

            migrationBuilder.CreateTable(
                name: "Pessoa",
                columns: table => new
                {
                    idPessoa = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nomePessoa = table.Column<string>(nullable: true),
                    tipoDocumento = table.Column<string>(nullable: true),
                    numeroDocumento = table.Column<string>(nullable: true),
                    idGrupoPessoa = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_pessoa", x => x.idPessoa);
                    table.ForeignKey(
                        name: "fk_pessoa_grupoPessoa",
                        column: x => x.idGrupoPessoa,
                        principalTable: "GrupoPessoa",
                        principalColumn: "idGrupoPessoa",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pessoa_idGrupoPessoa",
                table: "Pessoa",
                column: "idGrupoPessoa");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pessoa");

            migrationBuilder.DropTable(
                name: "GrupoPessoa");
        }
    }
}
