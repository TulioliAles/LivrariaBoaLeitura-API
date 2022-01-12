using Microsoft.EntityFrameworkCore.Migrations;

namespace LivrariaBoaLeitura.API.Migrations
{
    public partial class RetiraCampoImagem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Imagem",
                table: "Livro");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Imagem",
                table: "Livro",
                type: "varchar",
                nullable: true);
        }
    }
}
