using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace UTB.SocSit.Yalynnyi.Ispaniuk.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class alterpostsseeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "d5e18436-1d5c-4145-887e-51ef41fa3638");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "6dcbf4f7-38d7-4ce2-94bf-26758717f9e0");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "d8bf7b3b-4430-4f69-8a1d-26237ba67a52");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "feff3194-e445-46f6-b119-12d6f8481d20");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "44d8f454-fc97-4357-a1e0-488b0e994741");

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Text", "UserID" },
                values: new object[] { "This is post number 1 on this network. Enjoy reading!", 2 });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Text", "UserID" },
                values: new object[] { "This is post number 2 on this network. Enjoy reading!", 3 });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 3,
                column: "Text",
                value: "This is post number 3 on this network. Enjoy reading!");

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "Text", "UserID" },
                values: new object[] { "This is post number 4 on this network. Enjoy reading!", 5 });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "Text", "UserID" },
                values: new object[] { "This is post number 5 on this network. Enjoy reading!", 1 });

            migrationBuilder.InsertData(
                table: "Post",
                columns: new[] { "ID", "Deleted", "Text", "UserID" },
                values: new object[,]
                {
                    { 6, null, "This is post number 6 on this network. Enjoy reading!", 2 },
                    { 7, null, "This is post number 7 on this network. Enjoy reading!", 3 },
                    { 8, null, "This is post number 8 on this network. Enjoy reading!", 4 },
                    { 9, null, "This is post number 9 on this network. Enjoy reading!", 5 },
                    { 10, null, "This is post number 10 on this network. Enjoy reading!", 1 },
                    { 11, null, "This is post number 11 on this network. Enjoy reading!", 2 },
                    { 12, null, "This is post number 12 on this network. Enjoy reading!", 3 },
                    { 13, null, "This is post number 13 on this network. Enjoy reading!", 4 },
                    { 14, null, "This is post number 14 on this network. Enjoy reading!", 5 },
                    { 15, null, "This is post number 15 on this network. Enjoy reading!", 1 },
                    { 16, null, "This is post number 16 on this network. Enjoy reading!", 2 },
                    { 17, null, "This is post number 17 on this network. Enjoy reading!", 3 },
                    { 18, null, "This is post number 18 on this network. Enjoy reading!", 4 },
                    { 19, null, "This is post number 19 on this network. Enjoy reading!", 5 },
                    { 20, null, "This is post number 20 on this network. Enjoy reading!", 1 },
                    { 21, null, "This is post number 21 on this network. Enjoy reading!", 2 },
                    { 22, null, "This is post number 22 on this network. Enjoy reading!", 3 },
                    { 23, null, "This is post number 23 on this network. Enjoy reading!", 4 },
                    { 24, null, "This is post number 24 on this network. Enjoy reading!", 5 },
                    { 25, null, "This is post number 25 on this network. Enjoy reading!", 1 },
                    { 26, null, "This is post number 26 on this network. Enjoy reading!", 2 },
                    { 27, null, "This is post number 27 on this network. Enjoy reading!", 3 },
                    { 28, null, "This is post number 28 on this network. Enjoy reading!", 4 },
                    { 29, null, "This is post number 29 on this network. Enjoy reading!", 5 },
                    { 30, null, "This is post number 30 on this network. Enjoy reading!", 1 },
                    { 31, null, "This is post number 31 on this network. Enjoy reading!", 2 },
                    { 32, null, "This is post number 32 on this network. Enjoy reading!", 3 },
                    { 33, null, "This is post number 33 on this network. Enjoy reading!", 4 },
                    { 34, null, "This is post number 34 on this network. Enjoy reading!", 5 },
                    { 35, null, "This is post number 35 on this network. Enjoy reading!", 1 },
                    { 36, null, "This is post number 36 on this network. Enjoy reading!", 2 },
                    { 37, null, "This is post number 37 on this network. Enjoy reading!", 3 },
                    { 38, null, "This is post number 38 on this network. Enjoy reading!", 4 },
                    { 39, null, "This is post number 39 on this network. Enjoy reading!", 5 },
                    { 40, null, "This is post number 40 on this network. Enjoy reading!", 1 },
                    { 41, null, "This is post number 41 on this network. Enjoy reading!", 2 },
                    { 42, null, "This is post number 42 on this network. Enjoy reading!", 3 },
                    { 43, null, "This is post number 43 on this network. Enjoy reading!", 4 },
                    { 44, null, "This is post number 44 on this network. Enjoy reading!", 5 },
                    { 45, null, "This is post number 45 on this network. Enjoy reading!", 1 },
                    { 46, null, "This is post number 46 on this network. Enjoy reading!", 2 },
                    { 47, null, "This is post number 47 on this network. Enjoy reading!", 3 },
                    { 48, null, "This is post number 48 on this network. Enjoy reading!", 4 },
                    { 49, null, "This is post number 49 on this network. Enjoy reading!", 5 },
                    { 50, null, "This is post number 50 on this network. Enjoy reading!", 1 },
                    { 51, null, "This is post number 51 on this network. Enjoy reading!", 2 },
                    { 52, null, "This is post number 52 on this network. Enjoy reading!", 3 },
                    { 53, null, "This is post number 53 on this network. Enjoy reading!", 4 },
                    { 54, null, "This is post number 54 on this network. Enjoy reading!", 5 },
                    { 55, null, "This is post number 55 on this network. Enjoy reading!", 1 },
                    { 56, null, "This is post number 56 on this network. Enjoy reading!", 2 },
                    { 57, null, "This is post number 57 on this network. Enjoy reading!", 3 },
                    { 58, null, "This is post number 58 on this network. Enjoy reading!", 4 },
                    { 59, null, "This is post number 59 on this network. Enjoy reading!", 5 },
                    { 60, null, "This is post number 60 on this network. Enjoy reading!", 1 },
                    { 61, null, "This is post number 61 on this network. Enjoy reading!", 2 },
                    { 62, null, "This is post number 62 on this network. Enjoy reading!", 3 },
                    { 63, null, "This is post number 63 on this network. Enjoy reading!", 4 },
                    { 64, null, "This is post number 64 on this network. Enjoy reading!", 5 },
                    { 65, null, "This is post number 65 on this network. Enjoy reading!", 1 },
                    { 66, null, "This is post number 66 on this network. Enjoy reading!", 2 },
                    { 67, null, "This is post number 67 on this network. Enjoy reading!", 3 },
                    { 68, null, "This is post number 68 on this network. Enjoy reading!", 4 },
                    { 69, null, "This is post number 69 on this network. Enjoy reading!", 5 },
                    { 70, null, "This is post number 70 on this network. Enjoy reading!", 1 },
                    { 71, null, "This is post number 71 on this network. Enjoy reading!", 2 },
                    { 72, null, "This is post number 72 on this network. Enjoy reading!", 3 },
                    { 73, null, "This is post number 73 on this network. Enjoy reading!", 4 },
                    { 74, null, "This is post number 74 on this network. Enjoy reading!", 5 },
                    { 75, null, "This is post number 75 on this network. Enjoy reading!", 1 },
                    { 76, null, "This is post number 76 on this network. Enjoy reading!", 2 },
                    { 77, null, "This is post number 77 on this network. Enjoy reading!", 3 },
                    { 78, null, "This is post number 78 on this network. Enjoy reading!", 4 },
                    { 79, null, "This is post number 79 on this network. Enjoy reading!", 5 },
                    { 80, null, "This is post number 80 on this network. Enjoy reading!", 1 },
                    { 81, null, "This is post number 81 on this network. Enjoy reading!", 2 },
                    { 82, null, "This is post number 82 on this network. Enjoy reading!", 3 },
                    { 83, null, "This is post number 83 on this network. Enjoy reading!", 4 },
                    { 84, null, "This is post number 84 on this network. Enjoy reading!", 5 },
                    { 85, null, "This is post number 85 on this network. Enjoy reading!", 1 },
                    { 86, null, "This is post number 86 on this network. Enjoy reading!", 2 },
                    { 87, null, "This is post number 87 on this network. Enjoy reading!", 3 },
                    { 88, null, "This is post number 88 on this network. Enjoy reading!", 4 },
                    { 89, null, "This is post number 89 on this network. Enjoy reading!", 5 },
                    { 90, null, "This is post number 90 on this network. Enjoy reading!", 1 },
                    { 91, null, "This is post number 91 on this network. Enjoy reading!", 2 },
                    { 92, null, "This is post number 92 on this network. Enjoy reading!", 3 },
                    { 93, null, "This is post number 93 on this network. Enjoy reading!", 4 },
                    { 94, null, "This is post number 94 on this network. Enjoy reading!", 5 },
                    { 95, null, "This is post number 95 on this network. Enjoy reading!", 1 },
                    { 96, null, "This is post number 96 on this network. Enjoy reading!", 2 },
                    { 97, null, "This is post number 97 on this network. Enjoy reading!", 3 },
                    { 98, null, "This is post number 98 on this network. Enjoy reading!", 4 },
                    { 99, null, "This is post number 99 on this network. Enjoy reading!", 5 },
                    { 100, null, "This is post number 100 on this network. Enjoy reading!", 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 100);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "09d3e95c-c1bc-4261-a20e-ec49d9072939");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "9a1da46c-4353-4adf-beca-8ed054430185");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "5fd4a7ed-e5dc-4592-b4dc-804283fdb962");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "b768b6b5-4b79-4c57-9d1b-2b5bf3df0e24");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "816365a6-fd21-49ff-b2f8-b74b9ce04891");

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Text", "UserID" },
                values: new object[] { "This is the first post on this network. Wow", 1 });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Text", "UserID" },
                values: new object[] { "Hello world", 2 });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 3,
                column: "Text",
                value: "Let's try something new. What about this?");

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "Text", "UserID" },
                values: new object[] { "My the latest photos from NA", 2 });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "Text", "UserID" },
                values: new object[] { "My first video from drone. What's your score?", 3 });
        }
    }
}
