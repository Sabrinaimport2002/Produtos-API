using Microsoft.EntityFrameworkCore.Migrations;

namespace ProdutosAPI.Migrations
{
    public partial class ProdutoMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Marca = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Preco = table.Column<double>(type: "float", nullable: false),
                    Distribuidor = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Validade = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Produtos");
        }
    }
}
