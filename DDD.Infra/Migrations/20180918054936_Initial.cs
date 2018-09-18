using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DDD.Infra.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "LivrariaHbsis");

            migrationBuilder.CreateTable(
                name: "BOOK",
                schema: "LivrariaHbsis",
                columns: table => new
                {
                    book_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    book_title = table.Column<string>(maxLength: 200, nullable: false),
                    book_description = table.Column<string>(maxLength: 200, nullable: false),
                    book_author = table.Column<string>(maxLength: 200, nullable: false),
                    book_publishing_company = table.Column<string>(maxLength: 200, nullable: false),
                    book_price = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("book_id", x => x.book_id);
                });

            migrationBuilder.CreateTable(
                name: "EXEMPLARY",
                schema: "LivrariaHbsis",
                columns: table => new
                {
                    exemplary_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    book_id = table.Column<int>(nullable: false),
                    exemplary_count = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("exemplary_id", x => x.exemplary_id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BOOK_book_title",
                schema: "LivrariaHbsis",
                table: "BOOK",
                column: "book_title",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BOOK",
                schema: "LivrariaHbsis");

            migrationBuilder.DropTable(
                name: "EXEMPLARY",
                schema: "LivrariaHbsis");
        }
    }
}
