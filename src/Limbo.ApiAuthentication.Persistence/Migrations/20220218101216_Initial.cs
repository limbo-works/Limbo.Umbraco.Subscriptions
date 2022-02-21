using Microsoft.EntityFrameworkCore.Migrations;

namespace Limbo.ApiAuthentication.Persistence.Migrations {
    /// <summary>
    /// 
    /// </summary>
    public partial class Initial : Migration {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="migrationBuilder"></param>
        protected override void Up(MigrationBuilder migrationBuilder) {
            migrationBuilder.CreateTable(
                name: "ApiKeys",
                columns: table => new {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Key = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true)
                },
                constraints: table => {
                    table.PrimaryKey("PK_ApiKeys", x => x.Id);
                });
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="migrationBuilder"></param>
        protected override void Down(MigrationBuilder migrationBuilder) {
            migrationBuilder.DropTable(
                name: "ApiKeys");
        }
    }
}
