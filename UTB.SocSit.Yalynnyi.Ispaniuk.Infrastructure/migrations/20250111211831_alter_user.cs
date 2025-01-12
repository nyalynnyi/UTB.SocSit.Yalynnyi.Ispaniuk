using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UTB.SocSit.Yalynnyi.Ispaniuk.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class alter_user : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nickname",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "UserName" },
                values: new object[] { "09d3e95c-c1bc-4261-a20e-ec49d9072939", "orpha_terry" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "UserName" },
                values: new object[] { "9a1da46c-4353-4adf-beca-8ed054430185", "marta_berge" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "UserName" },
                values: new object[] { "5fd4a7ed-e5dc-4592-b4dc-804283fdb962", "j_kshlerin" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "UserName" },
                values: new object[] { "b768b6b5-4b79-4c57-9d1b-2b5bf3df0e24", "rico_spinka" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "UserName" },
                values: new object[] { "816365a6-fd21-49ff-b2f8-b74b9ce04891", "emmerich43" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Nickname",
                table: "AspNetUsers",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "Nickname", "UserName" },
                values: new object[] { "349e0500-1c6d-4f71-b2d8-4034bf057056", "orpha_terry", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "Nickname", "UserName" },
                values: new object[] { "d2fd95e1-6e59-4042-ad28-de392b6f9f3c", "marta_berge", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "Nickname", "UserName" },
                values: new object[] { "5c03f5db-0d57-440f-904a-d9e5663d4faa", "j_kshlerin", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "Nickname", "UserName" },
                values: new object[] { "f5d3fb35-17d6-496d-8fa2-c8db3a528f7d", "rico_spinka", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "Nickname", "UserName" },
                values: new object[] { "474ffdfa-e64f-4f21-aa03-440acb870cfc", "emmerich43", null });
        }
    }
}
