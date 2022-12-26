using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace BoriskinWebKr.Migrations
{
    /// <inheritdoc />
    public partial class addPainters : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "painter_id",
                table: "pictures",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateTable(
                name: "painters",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false),
                    descriptions = table.Column<string>(type: "text", nullable: false),
                    photo = table.Column<byte[]>(type: "bytea", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_painters", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_pictures_painter_id",
                table: "pictures",
                column: "painter_id");

            migrationBuilder.AddForeignKey(
                name: "FK_pictures_painters_painter_id",
                table: "pictures",
                column: "painter_id",
                principalTable: "painters",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_pictures_painters_painter_id",
                table: "pictures");

            migrationBuilder.DropTable(
                name: "painters");

            migrationBuilder.DropIndex(
                name: "IX_pictures_painter_id",
                table: "pictures");

            migrationBuilder.DropColumn(
                name: "painter_id",
                table: "pictures");
        }
    }
}
