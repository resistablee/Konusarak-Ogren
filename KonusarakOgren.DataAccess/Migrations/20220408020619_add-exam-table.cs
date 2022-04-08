using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KonusarakOgren.DataAccess.Migrations
{
    public partial class addexamtable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Exam",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserID = table.Column<int>(type: "INTEGER", nullable: false),
                    ArticleID = table.Column<int>(type: "INTEGER", nullable: false),
                    ExamDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreatedBy = table.Column<int>(type: "INTEGER", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "TEXT", nullable: true),
                    UpdatedBy = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exam", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Exam_Articles_ArticleID",
                        column: x => x.ArticleID,
                        principalTable: "Articles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Exam_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 4, 8, 2, 6, 19, 81, DateTimeKind.Utc).AddTicks(4675), new DateTime(2022, 4, 8, 2, 6, 19, 81, DateTimeKind.Utc).AddTicks(4677) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 4, 8, 2, 6, 19, 81, DateTimeKind.Utc).AddTicks(4680), new DateTime(2022, 4, 8, 2, 6, 19, 81, DateTimeKind.Utc).AddTicks(4681) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 4, 8, 2, 6, 19, 81, DateTimeKind.Utc).AddTicks(4681), new DateTime(2022, 4, 8, 2, 6, 19, 81, DateTimeKind.Utc).AddTicks(4682) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 4, 8, 2, 6, 19, 81, DateTimeKind.Utc).AddTicks(4682), new DateTime(2022, 4, 8, 2, 6, 19, 81, DateTimeKind.Utc).AddTicks(4683) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 4, 8, 2, 6, 19, 81, DateTimeKind.Utc).AddTicks(4683), new DateTime(2022, 4, 8, 2, 6, 19, 81, DateTimeKind.Utc).AddTicks(4684) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 4, 8, 2, 6, 19, 81, DateTimeKind.Utc).AddTicks(5166), new DateTime(2022, 4, 8, 2, 6, 19, 81, DateTimeKind.Utc).AddTicks(5168) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 4, 8, 2, 6, 19, 81, DateTimeKind.Utc).AddTicks(5168), new DateTime(2022, 4, 8, 2, 6, 19, 81, DateTimeKind.Utc).AddTicks(5169) });

            migrationBuilder.CreateIndex(
                name: "IX_Exam_ArticleID",
                table: "Exam",
                column: "ArticleID");

            migrationBuilder.CreateIndex(
                name: "IX_Exam_UserID",
                table: "Exam",
                column: "UserID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Exam");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 3, 27, 16, 46, 32, 652, DateTimeKind.Utc).AddTicks(2525), new DateTime(2022, 3, 27, 16, 46, 32, 652, DateTimeKind.Utc).AddTicks(2528) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 3, 27, 16, 46, 32, 652, DateTimeKind.Utc).AddTicks(2531), new DateTime(2022, 3, 27, 16, 46, 32, 652, DateTimeKind.Utc).AddTicks(2531) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 3, 27, 16, 46, 32, 652, DateTimeKind.Utc).AddTicks(2531), new DateTime(2022, 3, 27, 16, 46, 32, 652, DateTimeKind.Utc).AddTicks(2532) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 3, 27, 16, 46, 32, 652, DateTimeKind.Utc).AddTicks(2532), new DateTime(2022, 3, 27, 16, 46, 32, 652, DateTimeKind.Utc).AddTicks(2533) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 3, 27, 16, 46, 32, 652, DateTimeKind.Utc).AddTicks(2533), new DateTime(2022, 3, 27, 16, 46, 32, 652, DateTimeKind.Utc).AddTicks(2534) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 3, 27, 16, 46, 32, 652, DateTimeKind.Utc).AddTicks(3060), new DateTime(2022, 3, 27, 16, 46, 32, 652, DateTimeKind.Utc).AddTicks(3062) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 3, 27, 16, 46, 32, 652, DateTimeKind.Utc).AddTicks(3062), new DateTime(2022, 3, 27, 16, 46, 32, 652, DateTimeKind.Utc).AddTicks(3063) });
        }
    }
}
