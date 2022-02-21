using Microsoft.EntityFrameworkCore.Migrations;

namespace Limbo.ApiAuthentication.Persistence.Migrations {
    /// <summary>
    /// 
    /// </summary>
    public partial class AddClaims : Migration {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="migrationBuilder"></param>
        protected override void Up(MigrationBuilder migrationBuilder) {
            migrationBuilder.CreateTable(
                name: "ApiClaims",
                columns: table => new {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table => {
                    table.PrimaryKey("PK_ApiClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ApiClaimApiKey",
                columns: table => new {
                    ApiKeysId = table.Column<int>(type: "int", nullable: false),
                    ClaimsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table => {
                    table.PrimaryKey("PK_ApiClaimApiKey", x => new { x.ApiKeysId, x.ClaimsId });
                    table.ForeignKey(
                        name: "FK_ApiClaimApiKey_ApiClaims_ClaimsId",
                        column: x => x.ClaimsId,
                        principalTable: "ApiClaims",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ApiClaimApiKey_ApiKeys_ApiKeysId",
                        column: x => x.ApiKeysId,
                        principalTable: "ApiKeys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ApiClaimApiKey_ClaimsId",
                table: "ApiClaimApiKey",
                column: "ClaimsId");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="migrationBuilder"></param>
        protected override void Down(MigrationBuilder migrationBuilder) {
            migrationBuilder.DropTable(
                name: "ApiClaimApiKey");

            migrationBuilder.DropTable(
                name: "ApiClaims");
        }
    }
}
