using Microsoft.EntityFrameworkCore.Migrations;

namespace Limbo.MailSystem.Persisence.Migrations {
    public partial class Initial : Migration {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="migrationBuilder"></param>
        protected override void Up(MigrationBuilder migrationBuilder) {
            migrationBuilder.CreateTable(
                name: "Limbo_Mail_MailTemplates",
                columns: table => new {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table => {
                    table.PrimaryKey("PK_Limbo_Mail_MailTemplates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Limbo_Mail_SegmentTypes",
                columns: table => new {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Alias = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table => {
                    table.PrimaryKey("PK_Limbo_Mail_SegmentTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Limbo_Mail_MailSegments",
                columns: table => new {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NVarCharValue = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    NVarCharMaxValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MailTemplateId = table.Column<int>(type: "int", nullable: true),
                    SegmentTypeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table => {
                    table.PrimaryKey("PK_Limbo_Mail_MailSegments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Limbo_Mail_MailSegments_Limbo_Mail_MailTemplates_MailTemplateId",
                        column: x => x.MailTemplateId,
                        principalTable: "Limbo_Mail_MailTemplates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Limbo_Mail_MailSegments_Limbo_Mail_SegmentTypes_SegmentTypeId",
                        column: x => x.SegmentTypeId,
                        principalTable: "Limbo_Mail_SegmentTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Limbo_Mail_MailSegments_MailTemplateId",
                table: "Limbo_Mail_MailSegments",
                column: "MailTemplateId");

            migrationBuilder.CreateIndex(
                name: "IX_Limbo_Mail_MailSegments_SegmentTypeId",
                table: "Limbo_Mail_MailSegments",
                column: "SegmentTypeId");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="migrationBuilder"></param>
        protected override void Down(MigrationBuilder migrationBuilder) {
            migrationBuilder.DropTable(
                name: "Limbo_Mail_MailSegments");

            migrationBuilder.DropTable(
                name: "Limbo_Mail_MailTemplates");

            migrationBuilder.DropTable(
                name: "Limbo_Mail_SegmentTypes");
        }
    }
}
