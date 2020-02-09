using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieApp.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MovieModel",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ReleaseYear = table.Column<int>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    OriginEthinicity = table.Column<string>(nullable: true),
                    Director = table.Column<string>(nullable: true),
                    Cast = table.Column<string>(nullable: true),
                    Genre = table.Column<string>(nullable: true),
                    WikiPage = table.Column<string>(nullable: true),
                    Plot = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieModel", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MovieModel");
        }
    }
}
