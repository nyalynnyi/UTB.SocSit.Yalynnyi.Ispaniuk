using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace UTB.SocSit.Yalynnyi.Ispaniuk.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class alter_all_tables_with_id : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Updated",
                table: "User",
                type: "datetime(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");

            migrationBuilder.InsertData(
                table: "Comment",
                columns: new[] { "ID", "PostID", "Text", "UserID" },
                values: new object[,]
                {
                    { 1, 1, "Hello there", 2 },
                    { 2, 1, "Cool", 4 },
                    { 3, 1, "New era of social comunication begins today", 5 },
                    { 4, 5, "Nice job, keep going", 4 },
                    { 5, 4, "Cool place", 5 }
                });

            migrationBuilder.InsertData(
                table: "Down",
                columns: new[] { "ID", "PostID", "UserID" },
                values: new object[] { 1, 4, 3 });

            migrationBuilder.InsertData(
                table: "Follow",
                columns: new[] { "ID", "FollowerID", "UserID" },
                values: new object[,]
                {
                    { 1, 2, 1 },
                    { 2, 2, 1 },
                    { 3, 3, 1 },
                    { 4, 4, 1 },
                    { 5, 1, 2 },
                    { 6, 4, 2 },
                    { 7, 5, 2 },
                    { 8, 5, 4 },
                    { 9, 4, 5 },
                    { 10, 4, 3 }
                });

            migrationBuilder.InsertData(
                table: "Media",
                columns: new[] { "ID", "Deleted", "Link", "PostID" },
                values: new object[,]
                {
                    { 1, null, "/media/4_1.jpg", 4 },
                    { 2, null, "/media/4_2.jpg", 4 },
                    { 3, null, "/media/4_3.jpg", 4 },
                    { 4, null, "/media/5_1.mp4", 5 }
                });

            migrationBuilder.InsertData(
                table: "Post",
                columns: new[] { "ID", "Deleted", "Text", "UserID" },
                values: new object[,]
                {
                    { 1, null, "This is the first post on this network. Wow", 1 },
                    { 2, null, "Hello world", 2 },
                    { 3, null, "Let's try something new. What about this?", 4 },
                    { 4, null, "My the latest photos from NA", 2 },
                    { 5, null, "My first video from drone. What's your score?", 3 }
                });

            migrationBuilder.InsertData(
                table: "Up",
                columns: new[] { "ID", "PostID", "UserID" },
                values: new object[,]
                {
                    { 1, 1, 2 },
                    { 2, 1, 4 },
                    { 3, 2, 1 },
                    { 4, 4, 1 },
                    { 5, 4, 5 },
                    { 6, 4, 2 },
                    { 7, 4, 4 },
                    { 8, 5, 4 },
                    { 9, 5, 1 },
                    { 10, 5, 2 }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "ID", "Bio", "Birthday", "Deleted", "Email", "Name", "Nickname", "Password", "Photo", "Updated" },
                values: new object[,]
                {
                    { 1, null, null, null, "orpha_terry@example.com", "Orpha Terry", "orpha_terry", "EXAMPLE_pass_must_be_HASH", "/img/user/default.jpg", null },
                    { 2, null, null, null, "marta.berge47@example.com", "Marta Berge", "marta_berge", "EXAMPLE_pass_must_be_HASH", "/img/user/default.jpg", null },
                    { 3, null, null, null, "jamir_kshlerin@example.com", "Jamir Kshlerin", "j_kshlerin", "EXAMPLE_pass_must_be_HASH", "/img/user/default.jpg", null },
                    { 4, null, null, null, "rico_spinka66@example.com", "Rico Spinka", "rico_spinka", "EXAMPLE_pass_must_be_HASH", "/img/user/default.jpg", null },
                    { 5, null, null, null, "ottilie.emmerich43@example.com", "Ottilie Emmerich", "emmerich43", "EXAMPLE_pass_must_be_HASH", "/img/user/default.jpg", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Comment",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Comment",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Comment",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Comment",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Comment",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Down",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Follow",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Follow",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Follow",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Follow",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Follow",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Follow",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Follow",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Follow",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Follow",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Follow",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Up",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Up",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Up",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Up",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Up",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Up",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Up",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Up",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Up",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Up",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Updated",
                table: "User",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldNullable: true);
        }
    }
}
