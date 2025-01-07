using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace UTB.SocSit.Yalynnyi.Ispaniuk.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class alter_indentity_user : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Email = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Nickname = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Bio = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Photo = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Updated = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    Deleted = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    Birthday = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UserName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedUserName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedEmail = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EmailConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    PasswordHash = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SecurityStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumber = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumberConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "Bio", "Birthday", "ConcurrencyStamp", "Created", "Deleted", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "Nickname", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Photo", "SecurityStamp", "TwoFactorEnabled", "Updated", "UserName" },
                values: new object[,]
                {
                    { 1, 0, null, null, "26aba3e9-86ba-492a-a525-da131a46f8cf", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orpha_terry@example.com", false, false, null, "Orpha Terry", "orpha_terry", null, null, null, null, false, "/img/user/default.jpg", null, false, null, null },
                    { 2, 0, null, null, "5f84c7c5-cfd4-482f-b25f-85c3bc991069", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "marta.berge47@example.com", false, false, null, "Marta Berge", "marta_berge", null, null, null, null, false, "/img/user/default.jpg", null, false, null, null },
                    { 3, 0, null, null, "a8dfc092-d16b-40a8-88c4-2799e2dcc0a1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "jamir_kshlerin@example.com", false, false, null, "Jamir Kshlerin", "j_kshlerin", null, null, null, null, false, "/img/user/default.jpg", null, false, null, null },
                    { 4, 0, null, null, "c1a31b25-4ac9-4bad-8054-a00871222cf4", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "rico_spinka66@example.com", false, false, null, "Rico Spinka", "rico_spinka", null, null, null, null, false, "/img/user/default.jpg", null, false, null, null },
                    { 5, 0, null, null, "cc67af2d-cb55-41e8-a371-6c93892c3595", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "ottilie.emmerich43@example.com", false, false, null, "Ottilie Emmerich", "emmerich43", null, null, null, null, false, "/img/user/default.jpg", null, false, null, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Bio = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Birthday = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    Deleted = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    Email = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Nickname = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Password = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Photo = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Updated = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.ID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

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
    }
}
