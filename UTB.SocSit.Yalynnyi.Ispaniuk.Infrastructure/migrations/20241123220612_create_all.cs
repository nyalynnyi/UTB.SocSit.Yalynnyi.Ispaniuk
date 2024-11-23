using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace UTB.SocSit.Yalynnyi.Ispaniuk.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class create_all : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Comment",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    PostID = table.Column<int>(type: "int", nullable: false),
                    Text = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comment", x => x.ID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Follow",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    FollowerID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Follow", x => x.ID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Media",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PostID = table.Column<int>(type: "int", nullable: false),
                    Link = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Deleted = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Media", x => x.ID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Post",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    Text = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Deleted = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Post", x => x.ID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Reaction",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    PostID = table.Column<int>(type: "int", nullable: false),
                    Like = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reaction", x => x.ID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Email = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Nickname = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Bio = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Photo = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Password = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Updated = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    Deleted = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    Birthday = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.ID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

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
                table: "Reaction",
                columns: new[] { "ID", "Like", "PostID", "UserID" },
                values: new object[,]
                {
                    { 1, true, 1, 2 },
                    { 2, true, 1, 4 },
                    { 3, true, 2, 1 },
                    { 4, true, 4, 1 },
                    { 5, true, 4, 5 },
                    { 6, true, 4, 2 },
                    { 7, true, 4, 4 },
                    { 8, true, 5, 4 },
                    { 9, true, 5, 1 },
                    { 10, true, 5, 2 },
                    { 11, false, 4, 3 }
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
            migrationBuilder.DropTable(
                name: "Comment");

            migrationBuilder.DropTable(
                name: "Follow");

            migrationBuilder.DropTable(
                name: "Media");

            migrationBuilder.DropTable(
                name: "Post");

            migrationBuilder.DropTable(
                name: "Reaction");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
