using Microsoft.EntityFrameworkCore.Migrations;

namespace M7.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bts",
                columns: table => new
                {
                    BtsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ratings = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bts", x => x.BtsId);
                });

            migrationBuilder.InsertData(
                table: "Bts",
                columns: new[] { "BtsId", "Name", "Ratings" },
                values: new object[,]
                {
                    { 1, "Jimin", "9.8" },
                    { 2, "RM", "10" },
                    { 3, "Suga", "9" },
                    { 4, "Jungkook", "6" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bts");
        }
    }
}
