using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UTB.SocSit.Yalynnyi.Ispaniuk.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class alterpostsaddcreatedcol : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "Post",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "44f2eeb7-1b89-410f-92fa-a17de5c80a2f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "c03ebe15-64a2-40b9-93f0-079b45d26612");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "1f2f24ec-c140-4f0e-9d31-f6f06ba0a30c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "44379e31-27da-43dd-ad5b-db9c8a10bba3");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "1f695f65-106b-459b-acc9-00a4392795c9");

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Created", "UserID" },
                values: new object[] { new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3072), 14 });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Created", "UserID" },
                values: new object[] { new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3127), 14 });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "Created", "UserID" },
                values: new object[] { new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3130), 14 });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "Created", "UserID" },
                values: new object[] { new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3132), 14 });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "Created", "UserID" },
                values: new object[] { new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3134), 14 });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "Created", "UserID" },
                values: new object[] { new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3137), 14 });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "Created", "UserID" },
                values: new object[] { new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3139), 14 });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "Created", "UserID" },
                values: new object[] { new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3141), 14 });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "Created", "UserID" },
                values: new object[] { new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3142), 14 });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "Created", "UserID" },
                values: new object[] { new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3146), 14 });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "Created", "UserID" },
                values: new object[] { new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3149), 14 });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "Created", "UserID" },
                values: new object[] { new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3182), 14 });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "Created", "UserID" },
                values: new object[] { new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3184), 14 });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "Created", "UserID" },
                values: new object[] { new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3186), 14 });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "Created", "UserID" },
                values: new object[] { new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3188), 14 });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "Created", "UserID" },
                values: new object[] { new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3190), 14 });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "Created", "UserID" },
                values: new object[] { new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3192), 14 });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "Created", "UserID" },
                values: new object[] { new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3195), 14 });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "Created", "UserID" },
                values: new object[] { new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3197), 14 });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "Created", "UserID" },
                values: new object[] { new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3199), 14 });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "Created", "UserID" },
                values: new object[] { new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3201), 14 });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "Created", "UserID" },
                values: new object[] { new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3203), 14 });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 23,
                columns: new[] { "Created", "UserID" },
                values: new object[] { new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3205), 14 });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "Created", "UserID" },
                values: new object[] { new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3207), 14 });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 25,
                columns: new[] { "Created", "UserID" },
                values: new object[] { new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3209), 14 });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "Created", "UserID" },
                values: new object[] { new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3211), 14 });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 27,
                columns: new[] { "Created", "UserID" },
                values: new object[] { new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3212), 14 });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 28,
                columns: new[] { "Created", "UserID" },
                values: new object[] { new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3214), 14 });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 29,
                columns: new[] { "Created", "UserID" },
                values: new object[] { new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3216), 14 });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "Created", "UserID" },
                values: new object[] { new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3218), 14 });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 31,
                columns: new[] { "Created", "UserID" },
                values: new object[] { new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3220), 14 });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 32,
                columns: new[] { "Created", "UserID" },
                values: new object[] { new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3221), 14 });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 33,
                columns: new[] { "Created", "UserID" },
                values: new object[] { new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3223), 14 });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 34,
                columns: new[] { "Created", "UserID" },
                values: new object[] { new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3226), 14 });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 35,
                columns: new[] { "Created", "UserID" },
                values: new object[] { new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3228), 14 });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 36,
                columns: new[] { "Created", "UserID" },
                values: new object[] { new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3230), 14 });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 37,
                columns: new[] { "Created", "UserID" },
                values: new object[] { new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3232), 14 });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 38,
                columns: new[] { "Created", "UserID" },
                values: new object[] { new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3233), 14 });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 39,
                columns: new[] { "Created", "UserID" },
                values: new object[] { new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3235), 14 });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 40,
                columns: new[] { "Created", "UserID" },
                values: new object[] { new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3237), 14 });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 41,
                columns: new[] { "Created", "UserID" },
                values: new object[] { new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3239), 14 });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 42,
                columns: new[] { "Created", "UserID" },
                values: new object[] { new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3240), 14 });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 43,
                columns: new[] { "Created", "UserID" },
                values: new object[] { new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3242), 14 });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 44,
                columns: new[] { "Created", "UserID" },
                values: new object[] { new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3244), 14 });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 45,
                columns: new[] { "Created", "UserID" },
                values: new object[] { new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3246), 14 });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 46,
                columns: new[] { "Created", "UserID" },
                values: new object[] { new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3247), 14 });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 47,
                columns: new[] { "Created", "UserID" },
                values: new object[] { new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3249), 14 });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 48,
                columns: new[] { "Created", "UserID" },
                values: new object[] { new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3251), 14 });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 49,
                columns: new[] { "Created", "UserID" },
                values: new object[] { new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3253), 14 });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 50,
                columns: new[] { "Created", "UserID" },
                values: new object[] { new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3282), 14 });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 51,
                columns: new[] { "Created", "UserID" },
                values: new object[] { new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3284), 14 });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 52,
                columns: new[] { "Created", "UserID" },
                values: new object[] { new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3287), 14 });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 53,
                columns: new[] { "Created", "UserID" },
                values: new object[] { new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3288), 14 });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 54,
                columns: new[] { "Created", "UserID" },
                values: new object[] { new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3290), 14 });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 55,
                columns: new[] { "Created", "UserID" },
                values: new object[] { new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3292), 14 });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 56,
                columns: new[] { "Created", "UserID" },
                values: new object[] { new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3294), 14 });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 57,
                columns: new[] { "Created", "UserID" },
                values: new object[] { new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3295), 14 });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 58,
                columns: new[] { "Created", "UserID" },
                values: new object[] { new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3297), 14 });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 59,
                columns: new[] { "Created", "UserID" },
                values: new object[] { new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3299), 14 });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 60,
                columns: new[] { "Created", "UserID" },
                values: new object[] { new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3301), 14 });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 61,
                columns: new[] { "Created", "UserID" },
                values: new object[] { new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3303), 14 });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 62,
                columns: new[] { "Created", "UserID" },
                values: new object[] { new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3305), 14 });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 63,
                columns: new[] { "Created", "UserID" },
                values: new object[] { new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3306), 14 });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 64,
                columns: new[] { "Created", "UserID" },
                values: new object[] { new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3308), 14 });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 65,
                columns: new[] { "Created", "UserID" },
                values: new object[] { new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3310), 14 });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 66,
                columns: new[] { "Created", "UserID" },
                values: new object[] { new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3313), 14 });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 67,
                columns: new[] { "Created", "UserID" },
                values: new object[] { new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3315), 14 });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 68,
                columns: new[] { "Created", "UserID" },
                values: new object[] { new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3317), 14 });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 69,
                columns: new[] { "Created", "UserID" },
                values: new object[] { new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3318), 14 });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 70,
                columns: new[] { "Created", "UserID" },
                values: new object[] { new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3320), 14 });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 71,
                columns: new[] { "Created", "UserID" },
                values: new object[] { new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3322), 14 });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 72,
                columns: new[] { "Created", "UserID" },
                values: new object[] { new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3324), 14 });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 73,
                columns: new[] { "Created", "UserID" },
                values: new object[] { new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3325), 14 });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 74,
                columns: new[] { "Created", "UserID" },
                values: new object[] { new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3327), 14 });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 75,
                columns: new[] { "Created", "UserID" },
                values: new object[] { new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3329), 14 });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 76,
                columns: new[] { "Created", "UserID" },
                values: new object[] { new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3331), 14 });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 77,
                columns: new[] { "Created", "UserID" },
                values: new object[] { new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3333), 14 });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 78,
                columns: new[] { "Created", "UserID" },
                values: new object[] { new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3334), 14 });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 79,
                columns: new[] { "Created", "UserID" },
                values: new object[] { new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3336), 14 });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 80,
                columns: new[] { "Created", "UserID" },
                values: new object[] { new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3338), 14 });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 81,
                columns: new[] { "Created", "UserID" },
                values: new object[] { new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3340), 14 });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 82,
                columns: new[] { "Created", "UserID" },
                values: new object[] { new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3342), 14 });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 83,
                columns: new[] { "Created", "UserID" },
                values: new object[] { new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3343), 14 });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 84,
                columns: new[] { "Created", "UserID" },
                values: new object[] { new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3345), 14 });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 85,
                columns: new[] { "Created", "UserID" },
                values: new object[] { new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3347), 14 });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 86,
                columns: new[] { "Created", "UserID" },
                values: new object[] { new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3349), 14 });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 87,
                columns: new[] { "Created", "UserID" },
                values: new object[] { new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3369), 14 });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 88,
                columns: new[] { "Created", "UserID" },
                values: new object[] { new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3371), 14 });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 89,
                columns: new[] { "Created", "UserID" },
                values: new object[] { new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3373), 14 });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 90,
                columns: new[] { "Created", "UserID" },
                values: new object[] { new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3375), 14 });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 91,
                columns: new[] { "Created", "UserID" },
                values: new object[] { new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3377), 14 });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 92,
                columns: new[] { "Created", "UserID" },
                values: new object[] { new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3378), 14 });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 93,
                columns: new[] { "Created", "UserID" },
                values: new object[] { new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3380), 14 });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 94,
                columns: new[] { "Created", "UserID" },
                values: new object[] { new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3382), 14 });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 95,
                columns: new[] { "Created", "UserID" },
                values: new object[] { new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3384), 14 });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 96,
                columns: new[] { "Created", "UserID" },
                values: new object[] { new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3386), 14 });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 97,
                columns: new[] { "Created", "UserID" },
                values: new object[] { new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3387), 14 });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 98,
                columns: new[] { "Created", "UserID" },
                values: new object[] { new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3389), 14 });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 99,
                columns: new[] { "Created", "UserID" },
                values: new object[] { new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3391), 14 });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 100,
                columns: new[] { "Created", "UserID" },
                values: new object[] { new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3393), 14 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Created",
                table: "Post");

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
                column: "UserID",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 2,
                column: "UserID",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 3,
                column: "UserID",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 4,
                column: "UserID",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 5,
                column: "UserID",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 6,
                column: "UserID",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 7,
                column: "UserID",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 8,
                column: "UserID",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 9,
                column: "UserID",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 10,
                column: "UserID",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 11,
                column: "UserID",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 12,
                column: "UserID",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 13,
                column: "UserID",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 14,
                column: "UserID",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 15,
                column: "UserID",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 16,
                column: "UserID",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 17,
                column: "UserID",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 18,
                column: "UserID",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 19,
                column: "UserID",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 20,
                column: "UserID",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 21,
                column: "UserID",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 22,
                column: "UserID",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 23,
                column: "UserID",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 24,
                column: "UserID",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 25,
                column: "UserID",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 26,
                column: "UserID",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 27,
                column: "UserID",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 28,
                column: "UserID",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 29,
                column: "UserID",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 30,
                column: "UserID",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 31,
                column: "UserID",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 32,
                column: "UserID",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 33,
                column: "UserID",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 34,
                column: "UserID",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 35,
                column: "UserID",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 36,
                column: "UserID",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 37,
                column: "UserID",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 38,
                column: "UserID",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 39,
                column: "UserID",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 40,
                column: "UserID",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 41,
                column: "UserID",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 42,
                column: "UserID",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 43,
                column: "UserID",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 44,
                column: "UserID",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 45,
                column: "UserID",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 46,
                column: "UserID",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 47,
                column: "UserID",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 48,
                column: "UserID",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 49,
                column: "UserID",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 50,
                column: "UserID",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 51,
                column: "UserID",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 52,
                column: "UserID",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 53,
                column: "UserID",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 54,
                column: "UserID",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 55,
                column: "UserID",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 56,
                column: "UserID",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 57,
                column: "UserID",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 58,
                column: "UserID",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 59,
                column: "UserID",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 60,
                column: "UserID",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 61,
                column: "UserID",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 62,
                column: "UserID",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 63,
                column: "UserID",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 64,
                column: "UserID",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 65,
                column: "UserID",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 66,
                column: "UserID",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 67,
                column: "UserID",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 68,
                column: "UserID",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 69,
                column: "UserID",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 70,
                column: "UserID",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 71,
                column: "UserID",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 72,
                column: "UserID",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 73,
                column: "UserID",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 74,
                column: "UserID",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 75,
                column: "UserID",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 76,
                column: "UserID",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 77,
                column: "UserID",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 78,
                column: "UserID",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 79,
                column: "UserID",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 80,
                column: "UserID",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 81,
                column: "UserID",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 82,
                column: "UserID",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 83,
                column: "UserID",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 84,
                column: "UserID",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 85,
                column: "UserID",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 86,
                column: "UserID",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 87,
                column: "UserID",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 88,
                column: "UserID",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 89,
                column: "UserID",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 90,
                column: "UserID",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 91,
                column: "UserID",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 92,
                column: "UserID",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 93,
                column: "UserID",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 94,
                column: "UserID",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 95,
                column: "UserID",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 96,
                column: "UserID",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 97,
                column: "UserID",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 98,
                column: "UserID",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 99,
                column: "UserID",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 100,
                column: "UserID",
                value: 1);
        }
    }
}
