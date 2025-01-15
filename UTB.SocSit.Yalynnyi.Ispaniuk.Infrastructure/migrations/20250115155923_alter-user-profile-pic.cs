using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UTB.SocSit.Yalynnyi.Ispaniuk.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class alteruserprofilepic : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "Photo" },
                values: new object[] { "34928153-420d-4f5c-94ff-ee7a09ab6668", "~/img/photos/default.png" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "Photo" },
                values: new object[] { "027b754f-d60f-4556-8d71-4b6b9bc01149", "~/img/photos/default.png" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "Photo" },
                values: new object[] { "ebc7fd91-bbf3-4ac4-a8b6-dfbc526250ee", "~/img/photos/default.png" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "Photo" },
                values: new object[] { "3a5ec67d-d3f3-41c9-9f1e-c5cf13df1601", "~/img/photos/default.png" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "Photo" },
                values: new object[] { "da59f2d8-9530-453f-afb6-0c31ee37cd6a", "~/img/photos/default.png" });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2025, 1, 15, 16, 59, 23, 557, DateTimeKind.Local).AddTicks(1431));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2025, 1, 15, 16, 59, 23, 557, DateTimeKind.Local).AddTicks(1528));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2025, 1, 15, 16, 59, 23, 557, DateTimeKind.Local).AddTicks(1531));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2025, 1, 15, 16, 59, 23, 557, DateTimeKind.Local).AddTicks(1533));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2025, 1, 15, 16, 59, 23, 557, DateTimeKind.Local).AddTicks(1535));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2025, 1, 15, 16, 59, 23, 557, DateTimeKind.Local).AddTicks(1539));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 7,
                column: "Created",
                value: new DateTime(2025, 1, 15, 16, 59, 23, 557, DateTimeKind.Local).AddTicks(1541));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 8,
                column: "Created",
                value: new DateTime(2025, 1, 15, 16, 59, 23, 557, DateTimeKind.Local).AddTicks(1542));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 9,
                column: "Created",
                value: new DateTime(2025, 1, 15, 16, 59, 23, 557, DateTimeKind.Local).AddTicks(1544));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 10,
                column: "Created",
                value: new DateTime(2025, 1, 15, 16, 59, 23, 557, DateTimeKind.Local).AddTicks(1548));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 11,
                column: "Created",
                value: new DateTime(2025, 1, 15, 16, 59, 23, 557, DateTimeKind.Local).AddTicks(1550));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 12,
                column: "Created",
                value: new DateTime(2025, 1, 15, 16, 59, 23, 557, DateTimeKind.Local).AddTicks(1552));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 13,
                column: "Created",
                value: new DateTime(2025, 1, 15, 16, 59, 23, 557, DateTimeKind.Local).AddTicks(1554));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 14,
                column: "Created",
                value: new DateTime(2025, 1, 15, 16, 59, 23, 557, DateTimeKind.Local).AddTicks(1556));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 15,
                column: "Created",
                value: new DateTime(2025, 1, 15, 16, 59, 23, 557, DateTimeKind.Local).AddTicks(1557));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 16,
                column: "Created",
                value: new DateTime(2025, 1, 15, 16, 59, 23, 557, DateTimeKind.Local).AddTicks(1560));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 17,
                column: "Created",
                value: new DateTime(2025, 1, 15, 16, 59, 23, 557, DateTimeKind.Local).AddTicks(1562));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 18,
                column: "Created",
                value: new DateTime(2025, 1, 15, 16, 59, 23, 557, DateTimeKind.Local).AddTicks(1565));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 19,
                column: "Created",
                value: new DateTime(2025, 1, 15, 16, 59, 23, 557, DateTimeKind.Local).AddTicks(1566));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 20,
                column: "Created",
                value: new DateTime(2025, 1, 15, 16, 59, 23, 557, DateTimeKind.Local).AddTicks(1568));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 21,
                column: "Created",
                value: new DateTime(2025, 1, 15, 16, 59, 23, 557, DateTimeKind.Local).AddTicks(1570));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 22,
                column: "Created",
                value: new DateTime(2025, 1, 15, 16, 59, 23, 557, DateTimeKind.Local).AddTicks(1573));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 23,
                column: "Created",
                value: new DateTime(2025, 1, 15, 16, 59, 23, 557, DateTimeKind.Local).AddTicks(1575));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 24,
                column: "Created",
                value: new DateTime(2025, 1, 15, 16, 59, 23, 557, DateTimeKind.Local).AddTicks(1577));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 25,
                column: "Created",
                value: new DateTime(2025, 1, 15, 16, 59, 23, 557, DateTimeKind.Local).AddTicks(1578));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 26,
                column: "Created",
                value: new DateTime(2025, 1, 15, 16, 59, 23, 557, DateTimeKind.Local).AddTicks(1580));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 27,
                column: "Created",
                value: new DateTime(2025, 1, 15, 16, 59, 23, 557, DateTimeKind.Local).AddTicks(1582));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 28,
                column: "Created",
                value: new DateTime(2025, 1, 15, 16, 59, 23, 557, DateTimeKind.Local).AddTicks(1584));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 29,
                column: "Created",
                value: new DateTime(2025, 1, 15, 16, 59, 23, 557, DateTimeKind.Local).AddTicks(1586));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 30,
                column: "Created",
                value: new DateTime(2025, 1, 15, 16, 59, 23, 557, DateTimeKind.Local).AddTicks(1587));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 31,
                column: "Created",
                value: new DateTime(2025, 1, 15, 16, 59, 23, 557, DateTimeKind.Local).AddTicks(1589));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 32,
                column: "Created",
                value: new DateTime(2025, 1, 15, 16, 59, 23, 557, DateTimeKind.Local).AddTicks(1591));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 33,
                column: "Created",
                value: new DateTime(2025, 1, 15, 16, 59, 23, 557, DateTimeKind.Local).AddTicks(1593));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 34,
                column: "Created",
                value: new DateTime(2025, 1, 15, 16, 59, 23, 557, DateTimeKind.Local).AddTicks(1595));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 35,
                column: "Created",
                value: new DateTime(2025, 1, 15, 16, 59, 23, 557, DateTimeKind.Local).AddTicks(1597));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 36,
                column: "Created",
                value: new DateTime(2025, 1, 15, 16, 59, 23, 557, DateTimeKind.Local).AddTicks(1599));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 37,
                column: "Created",
                value: new DateTime(2025, 1, 15, 16, 59, 23, 557, DateTimeKind.Local).AddTicks(1601));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 38,
                column: "Created",
                value: new DateTime(2025, 1, 15, 16, 59, 23, 557, DateTimeKind.Local).AddTicks(1602));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 39,
                column: "Created",
                value: new DateTime(2025, 1, 15, 16, 59, 23, 557, DateTimeKind.Local).AddTicks(1634));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 40,
                column: "Created",
                value: new DateTime(2025, 1, 15, 16, 59, 23, 557, DateTimeKind.Local).AddTicks(1637));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 41,
                column: "Created",
                value: new DateTime(2025, 1, 15, 16, 59, 23, 557, DateTimeKind.Local).AddTicks(1639));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 42,
                column: "Created",
                value: new DateTime(2025, 1, 15, 16, 59, 23, 557, DateTimeKind.Local).AddTicks(1640));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 43,
                column: "Created",
                value: new DateTime(2025, 1, 15, 16, 59, 23, 557, DateTimeKind.Local).AddTicks(1642));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 44,
                column: "Created",
                value: new DateTime(2025, 1, 15, 16, 59, 23, 557, DateTimeKind.Local).AddTicks(1644));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 45,
                column: "Created",
                value: new DateTime(2025, 1, 15, 16, 59, 23, 557, DateTimeKind.Local).AddTicks(1646));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 46,
                column: "Created",
                value: new DateTime(2025, 1, 15, 16, 59, 23, 557, DateTimeKind.Local).AddTicks(1648));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 47,
                column: "Created",
                value: new DateTime(2025, 1, 15, 16, 59, 23, 557, DateTimeKind.Local).AddTicks(1649));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 48,
                column: "Created",
                value: new DateTime(2025, 1, 15, 16, 59, 23, 557, DateTimeKind.Local).AddTicks(1651));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 49,
                column: "Created",
                value: new DateTime(2025, 1, 15, 16, 59, 23, 557, DateTimeKind.Local).AddTicks(1653));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 50,
                column: "Created",
                value: new DateTime(2025, 1, 15, 16, 59, 23, 557, DateTimeKind.Local).AddTicks(1655));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 51,
                column: "Created",
                value: new DateTime(2025, 1, 15, 16, 59, 23, 557, DateTimeKind.Local).AddTicks(1656));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 52,
                column: "Created",
                value: new DateTime(2025, 1, 15, 16, 59, 23, 557, DateTimeKind.Local).AddTicks(1658));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 53,
                column: "Created",
                value: new DateTime(2025, 1, 15, 16, 59, 23, 557, DateTimeKind.Local).AddTicks(1660));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 54,
                column: "Created",
                value: new DateTime(2025, 1, 15, 16, 59, 23, 557, DateTimeKind.Local).AddTicks(1662));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 55,
                column: "Created",
                value: new DateTime(2025, 1, 15, 16, 59, 23, 557, DateTimeKind.Local).AddTicks(1663));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 56,
                column: "Created",
                value: new DateTime(2025, 1, 15, 16, 59, 23, 557, DateTimeKind.Local).AddTicks(1665));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 57,
                column: "Created",
                value: new DateTime(2025, 1, 15, 16, 59, 23, 557, DateTimeKind.Local).AddTicks(1667));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 58,
                column: "Created",
                value: new DateTime(2025, 1, 15, 16, 59, 23, 557, DateTimeKind.Local).AddTicks(1668));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 59,
                column: "Created",
                value: new DateTime(2025, 1, 15, 16, 59, 23, 557, DateTimeKind.Local).AddTicks(1670));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 60,
                column: "Created",
                value: new DateTime(2025, 1, 15, 16, 59, 23, 557, DateTimeKind.Local).AddTicks(1672));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 61,
                column: "Created",
                value: new DateTime(2025, 1, 15, 16, 59, 23, 557, DateTimeKind.Local).AddTicks(1674));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 62,
                column: "Created",
                value: new DateTime(2025, 1, 15, 16, 59, 23, 557, DateTimeKind.Local).AddTicks(1675));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 63,
                column: "Created",
                value: new DateTime(2025, 1, 15, 16, 59, 23, 557, DateTimeKind.Local).AddTicks(1677));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 64,
                column: "Created",
                value: new DateTime(2025, 1, 15, 16, 59, 23, 557, DateTimeKind.Local).AddTicks(1679));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 65,
                column: "Created",
                value: new DateTime(2025, 1, 15, 16, 59, 23, 557, DateTimeKind.Local).AddTicks(1681));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 66,
                column: "Created",
                value: new DateTime(2025, 1, 15, 16, 59, 23, 557, DateTimeKind.Local).AddTicks(1683));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 67,
                column: "Created",
                value: new DateTime(2025, 1, 15, 16, 59, 23, 557, DateTimeKind.Local).AddTicks(1685));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 68,
                column: "Created",
                value: new DateTime(2025, 1, 15, 16, 59, 23, 557, DateTimeKind.Local).AddTicks(1687));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 69,
                column: "Created",
                value: new DateTime(2025, 1, 15, 16, 59, 23, 557, DateTimeKind.Local).AddTicks(1689));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 70,
                column: "Created",
                value: new DateTime(2025, 1, 15, 16, 59, 23, 557, DateTimeKind.Local).AddTicks(1691));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 71,
                column: "Created",
                value: new DateTime(2025, 1, 15, 16, 59, 23, 557, DateTimeKind.Local).AddTicks(1692));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 72,
                column: "Created",
                value: new DateTime(2025, 1, 15, 16, 59, 23, 557, DateTimeKind.Local).AddTicks(1694));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 73,
                column: "Created",
                value: new DateTime(2025, 1, 15, 16, 59, 23, 557, DateTimeKind.Local).AddTicks(1696));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 74,
                column: "Created",
                value: new DateTime(2025, 1, 15, 16, 59, 23, 557, DateTimeKind.Local).AddTicks(1698));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 75,
                column: "Created",
                value: new DateTime(2025, 1, 15, 16, 59, 23, 557, DateTimeKind.Local).AddTicks(1699));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 76,
                column: "Created",
                value: new DateTime(2025, 1, 15, 16, 59, 23, 557, DateTimeKind.Local).AddTicks(1728));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 77,
                column: "Created",
                value: new DateTime(2025, 1, 15, 16, 59, 23, 557, DateTimeKind.Local).AddTicks(1731));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 78,
                column: "Created",
                value: new DateTime(2025, 1, 15, 16, 59, 23, 557, DateTimeKind.Local).AddTicks(1733));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 79,
                column: "Created",
                value: new DateTime(2025, 1, 15, 16, 59, 23, 557, DateTimeKind.Local).AddTicks(1734));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 80,
                column: "Created",
                value: new DateTime(2025, 1, 15, 16, 59, 23, 557, DateTimeKind.Local).AddTicks(1736));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 81,
                column: "Created",
                value: new DateTime(2025, 1, 15, 16, 59, 23, 557, DateTimeKind.Local).AddTicks(1738));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 82,
                column: "Created",
                value: new DateTime(2025, 1, 15, 16, 59, 23, 557, DateTimeKind.Local).AddTicks(1740));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 83,
                column: "Created",
                value: new DateTime(2025, 1, 15, 16, 59, 23, 557, DateTimeKind.Local).AddTicks(1741));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 84,
                column: "Created",
                value: new DateTime(2025, 1, 15, 16, 59, 23, 557, DateTimeKind.Local).AddTicks(1743));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 85,
                column: "Created",
                value: new DateTime(2025, 1, 15, 16, 59, 23, 557, DateTimeKind.Local).AddTicks(1745));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 86,
                column: "Created",
                value: new DateTime(2025, 1, 15, 16, 59, 23, 557, DateTimeKind.Local).AddTicks(1747));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 87,
                column: "Created",
                value: new DateTime(2025, 1, 15, 16, 59, 23, 557, DateTimeKind.Local).AddTicks(1748));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 88,
                column: "Created",
                value: new DateTime(2025, 1, 15, 16, 59, 23, 557, DateTimeKind.Local).AddTicks(1750));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 89,
                column: "Created",
                value: new DateTime(2025, 1, 15, 16, 59, 23, 557, DateTimeKind.Local).AddTicks(1752));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 90,
                column: "Created",
                value: new DateTime(2025, 1, 15, 16, 59, 23, 557, DateTimeKind.Local).AddTicks(1754));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 91,
                column: "Created",
                value: new DateTime(2025, 1, 15, 16, 59, 23, 557, DateTimeKind.Local).AddTicks(1756));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 92,
                column: "Created",
                value: new DateTime(2025, 1, 15, 16, 59, 23, 557, DateTimeKind.Local).AddTicks(1757));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 93,
                column: "Created",
                value: new DateTime(2025, 1, 15, 16, 59, 23, 557, DateTimeKind.Local).AddTicks(1759));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 94,
                column: "Created",
                value: new DateTime(2025, 1, 15, 16, 59, 23, 557, DateTimeKind.Local).AddTicks(1761));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 95,
                column: "Created",
                value: new DateTime(2025, 1, 15, 16, 59, 23, 557, DateTimeKind.Local).AddTicks(1762));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 96,
                column: "Created",
                value: new DateTime(2025, 1, 15, 16, 59, 23, 557, DateTimeKind.Local).AddTicks(1764));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 97,
                column: "Created",
                value: new DateTime(2025, 1, 15, 16, 59, 23, 557, DateTimeKind.Local).AddTicks(1766));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 98,
                column: "Created",
                value: new DateTime(2025, 1, 15, 16, 59, 23, 557, DateTimeKind.Local).AddTicks(1768));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 99,
                column: "Created",
                value: new DateTime(2025, 1, 15, 16, 59, 23, 557, DateTimeKind.Local).AddTicks(1770));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 100,
                column: "Created",
                value: new DateTime(2025, 1, 15, 16, 59, 23, 557, DateTimeKind.Local).AddTicks(1772));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "Photo" },
                values: new object[] { "44f2eeb7-1b89-410f-92fa-a17de5c80a2f", "/img/user/default.jpg" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "Photo" },
                values: new object[] { "c03ebe15-64a2-40b9-93f0-079b45d26612", "/img/user/default.jpg" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "Photo" },
                values: new object[] { "1f2f24ec-c140-4f0e-9d31-f6f06ba0a30c", "/img/user/default.jpg" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "Photo" },
                values: new object[] { "44379e31-27da-43dd-ad5b-db9c8a10bba3", "/img/user/default.jpg" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "Photo" },
                values: new object[] { "1f695f65-106b-459b-acc9-00a4392795c9", "/img/user/default.jpg" });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3072));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3127));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3130));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3132));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3134));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3137));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 7,
                column: "Created",
                value: new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3139));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 8,
                column: "Created",
                value: new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3141));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 9,
                column: "Created",
                value: new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3142));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 10,
                column: "Created",
                value: new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3146));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 11,
                column: "Created",
                value: new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3149));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 12,
                column: "Created",
                value: new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3182));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 13,
                column: "Created",
                value: new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3184));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 14,
                column: "Created",
                value: new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3186));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 15,
                column: "Created",
                value: new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3188));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 16,
                column: "Created",
                value: new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3190));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 17,
                column: "Created",
                value: new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3192));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 18,
                column: "Created",
                value: new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3195));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 19,
                column: "Created",
                value: new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3197));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 20,
                column: "Created",
                value: new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3199));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 21,
                column: "Created",
                value: new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3201));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 22,
                column: "Created",
                value: new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3203));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 23,
                column: "Created",
                value: new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3205));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 24,
                column: "Created",
                value: new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3207));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 25,
                column: "Created",
                value: new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3209));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 26,
                column: "Created",
                value: new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3211));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 27,
                column: "Created",
                value: new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3212));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 28,
                column: "Created",
                value: new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3214));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 29,
                column: "Created",
                value: new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3216));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 30,
                column: "Created",
                value: new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3218));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 31,
                column: "Created",
                value: new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3220));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 32,
                column: "Created",
                value: new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3221));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 33,
                column: "Created",
                value: new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3223));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 34,
                column: "Created",
                value: new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3226));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 35,
                column: "Created",
                value: new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3228));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 36,
                column: "Created",
                value: new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3230));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 37,
                column: "Created",
                value: new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3232));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 38,
                column: "Created",
                value: new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3233));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 39,
                column: "Created",
                value: new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3235));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 40,
                column: "Created",
                value: new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3237));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 41,
                column: "Created",
                value: new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3239));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 42,
                column: "Created",
                value: new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3240));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 43,
                column: "Created",
                value: new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3242));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 44,
                column: "Created",
                value: new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3244));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 45,
                column: "Created",
                value: new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3246));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 46,
                column: "Created",
                value: new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3247));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 47,
                column: "Created",
                value: new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3249));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 48,
                column: "Created",
                value: new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3251));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 49,
                column: "Created",
                value: new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3253));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 50,
                column: "Created",
                value: new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3282));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 51,
                column: "Created",
                value: new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3284));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 52,
                column: "Created",
                value: new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3287));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 53,
                column: "Created",
                value: new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3288));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 54,
                column: "Created",
                value: new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3290));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 55,
                column: "Created",
                value: new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3292));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 56,
                column: "Created",
                value: new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3294));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 57,
                column: "Created",
                value: new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3295));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 58,
                column: "Created",
                value: new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3297));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 59,
                column: "Created",
                value: new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3299));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 60,
                column: "Created",
                value: new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3301));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 61,
                column: "Created",
                value: new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3303));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 62,
                column: "Created",
                value: new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3305));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 63,
                column: "Created",
                value: new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3306));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 64,
                column: "Created",
                value: new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3308));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 65,
                column: "Created",
                value: new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3310));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 66,
                column: "Created",
                value: new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3313));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 67,
                column: "Created",
                value: new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3315));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 68,
                column: "Created",
                value: new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3317));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 69,
                column: "Created",
                value: new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3318));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 70,
                column: "Created",
                value: new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3320));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 71,
                column: "Created",
                value: new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3322));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 72,
                column: "Created",
                value: new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3324));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 73,
                column: "Created",
                value: new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3325));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 74,
                column: "Created",
                value: new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3327));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 75,
                column: "Created",
                value: new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3329));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 76,
                column: "Created",
                value: new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3331));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 77,
                column: "Created",
                value: new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3333));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 78,
                column: "Created",
                value: new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3334));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 79,
                column: "Created",
                value: new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3336));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 80,
                column: "Created",
                value: new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3338));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 81,
                column: "Created",
                value: new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3340));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 82,
                column: "Created",
                value: new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3342));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 83,
                column: "Created",
                value: new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3343));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 84,
                column: "Created",
                value: new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3345));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 85,
                column: "Created",
                value: new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3347));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 86,
                column: "Created",
                value: new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3349));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 87,
                column: "Created",
                value: new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3369));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 88,
                column: "Created",
                value: new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3371));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 89,
                column: "Created",
                value: new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3373));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 90,
                column: "Created",
                value: new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3375));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 91,
                column: "Created",
                value: new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3377));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 92,
                column: "Created",
                value: new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3378));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 93,
                column: "Created",
                value: new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3380));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 94,
                column: "Created",
                value: new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3382));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 95,
                column: "Created",
                value: new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3384));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 96,
                column: "Created",
                value: new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3386));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 97,
                column: "Created",
                value: new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3387));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 98,
                column: "Created",
                value: new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3389));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 99,
                column: "Created",
                value: new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3391));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 100,
                column: "Created",
                value: new DateTime(2025, 1, 14, 21, 47, 19, 112, DateTimeKind.Local).AddTicks(3393));
        }
    }
}
