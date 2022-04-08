using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KonusarakOgren.DataAccess.Migrations
{
    public partial class nullablepropertyedit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "IsTrue",
                table: "Answers",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "INTEGER");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "IsTrue",
                table: "Answers",
                type: "INTEGER",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 3, 25, 14, 33, 51, 414, DateTimeKind.Utc).AddTicks(1893), new DateTime(2022, 3, 25, 14, 33, 51, 414, DateTimeKind.Utc).AddTicks(1898) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 3, 25, 14, 33, 51, 414, DateTimeKind.Utc).AddTicks(1903), new DateTime(2022, 3, 25, 14, 33, 51, 414, DateTimeKind.Utc).AddTicks(1903) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 3, 25, 14, 33, 51, 414, DateTimeKind.Utc).AddTicks(1904), new DateTime(2022, 3, 25, 14, 33, 51, 414, DateTimeKind.Utc).AddTicks(1905) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 3, 25, 14, 33, 51, 414, DateTimeKind.Utc).AddTicks(1905), new DateTime(2022, 3, 25, 14, 33, 51, 414, DateTimeKind.Utc).AddTicks(1905) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 3, 25, 14, 33, 51, 414, DateTimeKind.Utc).AddTicks(1906), new DateTime(2022, 3, 25, 14, 33, 51, 414, DateTimeKind.Utc).AddTicks(1907) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 3, 25, 14, 33, 51, 414, DateTimeKind.Utc).AddTicks(2522), new DateTime(2022, 3, 25, 14, 33, 51, 414, DateTimeKind.Utc).AddTicks(2523) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 3, 25, 14, 33, 51, 414, DateTimeKind.Utc).AddTicks(2523), new DateTime(2022, 3, 25, 14, 33, 51, 414, DateTimeKind.Utc).AddTicks(2524) });
        }
    }
}
