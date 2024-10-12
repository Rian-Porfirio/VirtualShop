using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EShop.ProductAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("""
                INSERT INTO products(Name, Price, Description, ImageUrl, CategoryId)
                VALUES("Borracha", 2.90, "Feita para apagar", "photo.png", 2)
                """);
            mb.Sql("""
                INSERT INTO products(Name, Price, Description, ImageUrl, CategoryId)
                VALUES("Lápis", 3.90, "Feito para escrever", "photo.png", 2)
                """);
            mb.Sql("""
                INSERT INTO products(Name, Price, Description, ImageUrl, CategoryId)
                VALUES("Caderno", 20.90, "Feito para ser escrito e apagado", "photo.png", 2)
                """);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("DROP FROM products");
        }
    }
}
