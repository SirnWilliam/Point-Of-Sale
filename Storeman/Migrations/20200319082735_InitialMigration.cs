using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Storeman.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ACC_TAB",
                columns: table => new
                {
                    F1068 = table.Column<string>(unicode: false, maxLength: 6, nullable: false),
                    F1033 = table.Column<string>(unicode: false, maxLength: 3, nullable: false),
                    F01 = table.Column<string>(unicode: false, maxLength: 13, nullable: false),
                    F1034 = table.Column<int>(nullable: false),
                    F1253 = table.Column<string>(unicode: false, maxLength: 1, nullable: false),
                    F1000 = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    F1039 = table.Column<string>(unicode: false, maxLength: 60, nullable: true),
                    F1128 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    F1129 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    F1130 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    F1147 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ACC_TAB_P1068", x => new { x.F1068, x.F1033, x.F01, x.F1034, x.F1253, x.F1000 });
                });

            migrationBuilder.CreateTable(
                name: "ALLOW_BAT",
                columns: table => new
                {
                    F01 = table.Column<string>(unicode: false, maxLength: 13, nullable: false),
                    F902 = table.Column<string>(unicode: false, maxLength: 8, nullable: false),
                    F1000 = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    F27 = table.Column<string>(unicode: false, maxLength: 14, nullable: false),
                    F1184 = table.Column<string>(unicode: false, maxLength: 12, nullable: false),
                    F07 = table.Column<int>(nullable: true),
                    F156 = table.Column<string>(unicode: false, maxLength: 120, nullable: true),
                    F201 = table.Column<decimal>(type: "money", nullable: true),
                    F202 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F203 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F204 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F222 = table.Column<string>(unicode: false, maxLength: 12, nullable: true),
                    F223 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F329 = table.Column<double>(nullable: true),
                    F1001 = table.Column<int>(nullable: true),
                    F1657 = table.Column<double>(nullable: true),
                    F1977 = table.Column<double>(nullable: true),
                    F2591 = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ALLOW_BAT_P01", x => new { x.F01, x.F902, x.F1000, x.F27, x.F1184 });
                });

            migrationBuilder.CreateTable(
                name: "ALT_DEL",
                columns: table => new
                {
                    F154 = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
                    F1000 = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    F01 = table.Column<string>(unicode: false, maxLength: 13, nullable: true),
                    F902 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F126 = table.Column<int>(nullable: true),
                    F253 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F1001 = table.Column<int>(nullable: true),
                    F1759 = table.Column<int>(nullable: true),
                    F1874 = table.Column<int>(nullable: true),
                    F1898 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F1964 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F2637 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F2660 = table.Column<string>(unicode: false, maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ALT_DEL_P154", x => new { x.F154, x.F1000 });
                });

            migrationBuilder.CreateTable(
                name: "ALT_TAB",
                columns: table => new
                {
                    F154 = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
                    F1000 = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    F01 = table.Column<string>(unicode: false, maxLength: 13, nullable: true),
                    F902 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F126 = table.Column<int>(nullable: true),
                    F253 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F1001 = table.Column<int>(nullable: true),
                    F1759 = table.Column<int>(nullable: true),
                    F1874 = table.Column<int>(nullable: true),
                    F1898 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F1964 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F2637 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F2660 = table.Column<string>(unicode: false, maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ALT_TAB_P154", x => new { x.F154, x.F1000 });
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ASSRT_TAB",
                columns: table => new
                {
                    F01 = table.Column<string>(unicode: false, maxLength: 13, nullable: false),
                    F1000 = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    F2932 = table.Column<string>(unicode: false, maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ASSRT_TAB_P01", x => new { x.F01, x.F1000 });
                });

            migrationBuilder.CreateTable(
                name: "BIO_DEL",
                columns: table => new
                {
                    F1063 = table.Column<int>(nullable: false),
                    F1148 = table.Column<string>(unicode: false, maxLength: 14, nullable: false),
                    F253 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F1001 = table.Column<int>(nullable: true),
                    F1581 = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    F1849 = table.Column<string>(unicode: false, maxLength: 8000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("BIO_DEL_P1063", x => new { x.F1063, x.F1148 });
                });

            migrationBuilder.CreateTable(
                name: "BIO_TAB",
                columns: table => new
                {
                    F1063 = table.Column<int>(nullable: false),
                    F1148 = table.Column<string>(unicode: false, maxLength: 14, nullable: false),
                    F253 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F1001 = table.Column<int>(nullable: true),
                    F1581 = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    F1849 = table.Column<string>(unicode: false, maxLength: 8000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("BIO_TAB_P1063", x => new { x.F1063, x.F1148 });
                });

            migrationBuilder.CreateTable(
                name: "BMP_DEL",
                columns: table => new
                {
                    F01 = table.Column<string>(unicode: false, maxLength: 13, nullable: false),
                    F2926 = table.Column<string>(unicode: false, maxLength: 12, nullable: false),
                    F2927 = table.Column<string>(unicode: false, maxLength: 12, nullable: false),
                    F2928 = table.Column<string>(unicode: false, maxLength: 12, nullable: false),
                    F253 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F1001 = table.Column<int>(nullable: true),
                    F2929 = table.Column<string>(unicode: false, maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("BMP_DEL_P01", x => new { x.F01, x.F2926, x.F2927, x.F2928 });
                });

            migrationBuilder.CreateTable(
                name: "BMP_TAB",
                columns: table => new
                {
                    F01 = table.Column<string>(unicode: false, maxLength: 13, nullable: false),
                    F2926 = table.Column<string>(unicode: false, maxLength: 12, nullable: false),
                    F2927 = table.Column<string>(unicode: false, maxLength: 12, nullable: false),
                    F2928 = table.Column<string>(unicode: false, maxLength: 12, nullable: false),
                    F253 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F1001 = table.Column<int>(nullable: true),
                    F2929 = table.Column<string>(unicode: false, maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("BMP_TAB_P01", x => new { x.F01, x.F2926, x.F2927, x.F2928 });
                });

            migrationBuilder.CreateTable(
                name: "BTL_TAB",
                columns: table => new
                {
                    F05 = table.Column<int>(nullable: false),
                    F50 = table.Column<decimal>(type: "money", nullable: true),
                    F79 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F81 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F96 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F97 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F98 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F99 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F100 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F101 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F106 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F178 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F186 = table.Column<decimal>(type: "money", nullable: true),
                    F1020 = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    F1034 = table.Column<int>(nullable: true),
                    F1594 = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    F1595 = table.Column<decimal>(type: "money", nullable: true),
                    F1596 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("BTL_TAB_P05", x => x.F05);
                });

            migrationBuilder.CreateTable(
                name: "CAT_TAB",
                columns: table => new
                {
                    F17 = table.Column<int>(nullable: false),
                    F49 = table.Column<double>(nullable: true),
                    F1023 = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    F1123 = table.Column<double>(nullable: true),
                    F1124 = table.Column<double>(nullable: true),
                    F1168 = table.Column<int>(nullable: true),
                    F1943 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F1944 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F1945 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F1946 = table.Column<int>(nullable: true),
                    F1947 = table.Column<int>(nullable: true),
                    F1965 = table.Column<int>(nullable: true),
                    F1966 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    F1967 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F2653 = table.Column<int>(nullable: true),
                    F2654 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("CAT_TAB_P17", x => x.F17);
                });

            migrationBuilder.CreateTable(
                name: "CFG_TAB",
                columns: table => new
                {
                    F2845 = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    F2846 = table.Column<string>(unicode: false, maxLength: 16, nullable: false),
                    F1000 = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    F253 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F940 = table.Column<int>(nullable: true),
                    F941 = table.Column<int>(nullable: true),
                    F1001 = table.Column<int>(nullable: true),
                    F1264 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F2847 = table.Column<string>(unicode: false, maxLength: 2000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("CFG_TAB_P2845", x => new { x.F2845, x.F2846, x.F1000 });
                });

            migrationBuilder.CreateTable(
                name: "CKZ_TAB",
                columns: table => new
                {
                    F2827 = table.Column<string>(unicode: false, maxLength: 10, nullable: false),
                    F1034 = table.Column<int>(nullable: false),
                    F253 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F902 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F940 = table.Column<int>(nullable: true),
                    F941 = table.Column<int>(nullable: true),
                    F1001 = table.Column<int>(nullable: true),
                    F2825 = table.Column<double>(nullable: true),
                    F2826 = table.Column<string>(unicode: false, maxLength: 8, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("CKZ_TAB_P2827", x => new { x.F2827, x.F1034 });
                });

            migrationBuilder.CreateTable(
                name: "CLF_SDP_TAB",
                columns: table => new
                {
                    F1152 = table.Column<int>(nullable: false),
                    F04 = table.Column<int>(nullable: false),
                    F1164 = table.Column<double>(nullable: true),
                    F1938 = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("CLF_SDP_TAB_P1152", x => new { x.F1152, x.F04 });
                });

            migrationBuilder.CreateTable(
                name: "CLF_TAB",
                columns: table => new
                {
                    F1152 = table.Column<int>(nullable: false),
                    F253 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F1073 = table.Column<decimal>(type: "money", nullable: true),
                    F1074 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F1075 = table.Column<decimal>(type: "money", nullable: true),
                    F1076 = table.Column<int>(nullable: true),
                    F1163 = table.Column<int>(nullable: true),
                    F1164 = table.Column<double>(nullable: true),
                    F1174 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    F1269 = table.Column<double>(nullable: true),
                    F1270 = table.Column<decimal>(type: "money", nullable: true),
                    F1271 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F1272 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F1273 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F1274 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F1275 = table.Column<decimal>(type: "money", nullable: true),
                    F1276 = table.Column<int>(nullable: true),
                    F1277 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F1278 = table.Column<double>(nullable: true),
                    F1279 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F1280 = table.Column<double>(nullable: true),
                    F1281 = table.Column<double>(nullable: true),
                    F1282 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F1283 = table.Column<double>(nullable: true),
                    F1284 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F1285 = table.Column<int>(nullable: true),
                    F1286 = table.Column<decimal>(type: "money", nullable: true),
                    F1287 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F1288 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F1289 = table.Column<decimal>(type: "money", nullable: true),
                    F1290 = table.Column<int>(nullable: true),
                    F1291 = table.Column<decimal>(type: "money", nullable: true),
                    F1292 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F1293 = table.Column<int>(nullable: true),
                    F1294 = table.Column<int>(nullable: true),
                    F1295 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F1296 = table.Column<int>(nullable: true),
                    F1297 = table.Column<decimal>(type: "money", nullable: true),
                    F1298 = table.Column<decimal>(type: "money", nullable: true),
                    F1711 = table.Column<int>(nullable: true),
                    F1745 = table.Column<string>(unicode: false, maxLength: 6, nullable: true),
                    F1746 = table.Column<string>(unicode: false, maxLength: 6, nullable: true),
                    F1747 = table.Column<string>(unicode: false, maxLength: 6, nullable: true),
                    F1748 = table.Column<string>(unicode: false, maxLength: 6, nullable: true),
                    F1749 = table.Column<string>(unicode: false, maxLength: 6, nullable: true),
                    F1750 = table.Column<string>(unicode: false, maxLength: 6, nullable: true),
                    F1751 = table.Column<string>(unicode: false, maxLength: 6, nullable: true),
                    F1752 = table.Column<string>(unicode: false, maxLength: 6, nullable: true),
                    F1753 = table.Column<string>(unicode: false, maxLength: 6, nullable: true),
                    F1754 = table.Column<string>(unicode: false, maxLength: 6, nullable: true),
                    F1755 = table.Column<string>(unicode: false, maxLength: 6, nullable: true),
                    F1756 = table.Column<string>(unicode: false, maxLength: 6, nullable: true),
                    F1757 = table.Column<string>(unicode: false, maxLength: 6, nullable: true),
                    F1758 = table.Column<string>(unicode: false, maxLength: 6, nullable: true),
                    F1811 = table.Column<int>(nullable: true),
                    F1812 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F1886 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F1938 = table.Column<double>(nullable: true),
                    F2743 = table.Column<string>(unicode: false, maxLength: 40, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("CLF_TAB_P1152", x => x.F1152);
                });

            migrationBuilder.CreateTable(
                name: "CLG_TAB",
                columns: table => new
                {
                    F1154 = table.Column<string>(unicode: false, maxLength: 10, nullable: false),
                    F1268 = table.Column<string>(unicode: false, maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("CLG_TAB_P1154", x => x.F1154);
                });

            migrationBuilder.CreateTable(
                name: "CLK_DEL",
                columns: table => new
                {
                    F1185 = table.Column<int>(nullable: false),
                    F1001 = table.Column<int>(nullable: true),
                    F1126 = table.Column<int>(nullable: true),
                    F1571 = table.Column<string>(unicode: false, maxLength: 60, nullable: true),
                    F27 = table.Column<string>(unicode: false, maxLength: 14, nullable: true),
                    F170 = table.Column<int>(nullable: true),
                    F253 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F902 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F940 = table.Column<int>(nullable: true),
                    F941 = table.Column<int>(nullable: true),
                    F1000 = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    F1056 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F1127 = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    F1141 = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    F1142 = table.Column<int>(nullable: true),
                    F1143 = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    F1144 = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    F1145 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F1146 = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    F1148 = table.Column<string>(unicode: false, maxLength: 14, nullable: true),
                    F1176 = table.Column<string>(unicode: false, maxLength: 3, nullable: true),
                    F1264 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F1552 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F1553 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F1554 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F1555 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F1556 = table.Column<int>(nullable: true),
                    F1557 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F1558 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F1559 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F1560 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    F1561 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    F1562 = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    F1563 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    F1564 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    F1565 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    F1566 = table.Column<double>(nullable: true),
                    F1567 = table.Column<int>(nullable: true),
                    F1568 = table.Column<int>(nullable: true),
                    F1569 = table.Column<int>(nullable: true),
                    F1570 = table.Column<double>(nullable: true),
                    F1585 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    F1586 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F1587 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    F1588 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F1589 = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    F1590 = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    F1964 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F2587 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F2597 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    F2692 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F2806 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F2827 = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    F2828 = table.Column<double>(nullable: true),
                    F2829 = table.Column<double>(nullable: true),
                    F2830 = table.Column<double>(nullable: true),
                    F2831 = table.Column<double>(nullable: true),
                    F2832 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    F2833 = table.Column<int>(nullable: true),
                    F2844 = table.Column<string>(unicode: false, maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("CLK_DEL_P1185", x => x.F1185);
                });

            migrationBuilder.CreateTable(
                name: "CLK_TAB",
                columns: table => new
                {
                    F1185 = table.Column<int>(nullable: false),
                    F1001 = table.Column<int>(nullable: true),
                    F1126 = table.Column<int>(nullable: true),
                    F1571 = table.Column<string>(unicode: false, maxLength: 60, nullable: true),
                    F27 = table.Column<string>(unicode: false, maxLength: 14, nullable: true),
                    F170 = table.Column<int>(nullable: true),
                    F253 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F902 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F940 = table.Column<int>(nullable: true),
                    F941 = table.Column<int>(nullable: true),
                    F1000 = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    F1056 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F1127 = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    F1141 = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    F1142 = table.Column<int>(nullable: true),
                    F1143 = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    F1144 = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    F1145 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F1146 = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    F1148 = table.Column<string>(unicode: false, maxLength: 14, nullable: true),
                    F1176 = table.Column<string>(unicode: false, maxLength: 3, nullable: true),
                    F1264 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F1552 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F1553 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F1554 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F1555 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F1556 = table.Column<int>(nullable: true),
                    F1557 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F1558 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F1559 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F1560 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    F1561 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    F1562 = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    F1563 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    F1564 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    F1565 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    F1566 = table.Column<double>(nullable: true),
                    F1567 = table.Column<int>(nullable: true),
                    F1568 = table.Column<int>(nullable: true),
                    F1569 = table.Column<int>(nullable: true),
                    F1570 = table.Column<double>(nullable: true),
                    F1585 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    F1586 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F1587 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    F1588 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F1589 = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    F1590 = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    F1964 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F2587 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F2597 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    F2692 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F2806 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F2827 = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    F2828 = table.Column<double>(nullable: true),
                    F2829 = table.Column<double>(nullable: true),
                    F2830 = table.Column<double>(nullable: true),
                    F2831 = table.Column<double>(nullable: true),
                    F2832 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    F2833 = table.Column<int>(nullable: true),
                    F2844 = table.Column<string>(unicode: false, maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("CLK_TAB_P1185", x => x.F1185);
                });

            migrationBuilder.CreateTable(
                name: "CLL_DEL",
                columns: table => new
                {
                    F1577 = table.Column<string>(unicode: false, maxLength: 32, nullable: false),
                    F1578 = table.Column<string>(unicode: false, maxLength: 6, nullable: false),
                    F902 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F1000 = table.Column<string>(unicode: false, maxLength: 5, nullable: true),
                    F1001 = table.Column<int>(nullable: true),
                    F1148 = table.Column<string>(unicode: false, maxLength: 14, nullable: true),
                    F253 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F1759 = table.Column<int>(nullable: true),
                    F1898 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F1964 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F2966 = table.Column<string>(unicode: false, maxLength: 12, nullable: true),
                    F2967 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F2971 = table.Column<string>(unicode: false, maxLength: 12, nullable: true),
                    F2972 = table.Column<string>(unicode: false, maxLength: 12, nullable: true),
                    F2973 = table.Column<decimal>(type: "money", nullable: true),
                    F2974 = table.Column<decimal>(type: "money", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("CLL_DEL_P1577", x => new { x.F1577, x.F1578 });
                });

            migrationBuilder.CreateTable(
                name: "CLL_TAB",
                columns: table => new
                {
                    F1577 = table.Column<string>(unicode: false, maxLength: 32, nullable: false),
                    F1578 = table.Column<string>(unicode: false, maxLength: 6, nullable: false),
                    F902 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F1000 = table.Column<string>(unicode: false, maxLength: 5, nullable: true),
                    F1001 = table.Column<int>(nullable: true),
                    F1148 = table.Column<string>(unicode: false, maxLength: 14, nullable: true),
                    F253 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F1759 = table.Column<int>(nullable: true),
                    F1898 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F1964 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F2966 = table.Column<string>(unicode: false, maxLength: 12, nullable: true),
                    F2967 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F2971 = table.Column<string>(unicode: false, maxLength: 12, nullable: true),
                    F2972 = table.Column<string>(unicode: false, maxLength: 12, nullable: true),
                    F2973 = table.Column<decimal>(type: "money", nullable: true),
                    F2974 = table.Column<decimal>(type: "money", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("CLL_TAB_P1577", x => new { x.F1577, x.F1578 });
                });

            migrationBuilder.CreateTable(
                name: "CLR_TAB",
                columns: table => new
                {
                    F1153 = table.Column<int>(nullable: false),
                    F253 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F1162 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F1165 = table.Column<decimal>(type: "money", nullable: true),
                    F1166 = table.Column<double>(nullable: true),
                    F1167 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    F1175 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    F1257 = table.Column<decimal>(type: "money", nullable: true),
                    F1258 = table.Column<decimal>(type: "money", nullable: true),
                    F1259 = table.Column<decimal>(type: "money", nullable: true),
                    F1260 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F1762 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    F1788 = table.Column<int>(nullable: true),
                    F1876 = table.Column<int>(nullable: true),
                    F1877 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F1878 = table.Column<decimal>(type: "money", nullable: true),
                    F1879 = table.Column<decimal>(type: "money", nullable: true),
                    F1880 = table.Column<int>(nullable: true),
                    F1881 = table.Column<int>(nullable: true),
                    F1921 = table.Column<int>(nullable: true),
                    F1922 = table.Column<int>(nullable: true),
                    F1923 = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("CLR_TAB_P1153", x => x.F1153);
                });

            migrationBuilder.CreateTable(
                name: "CLS_AUX",
                columns: table => new
                {
                    F2935 = table.Column<string>(unicode: false, maxLength: 11, nullable: false),
                    F2936 = table.Column<string>(unicode: false, maxLength: 60, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("CLS_AUX_P2935", x => x.F2935);
                });

            migrationBuilder.CreateTable(
                name: "CLS_DEL",
                columns: table => new
                {
                    F01 = table.Column<string>(unicode: false, maxLength: 13, nullable: false),
                    F2935 = table.Column<string>(unicode: false, maxLength: 11, nullable: false),
                    F1001 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("CLS_DEL_P01", x => new { x.F01, x.F2935 });
                });

            migrationBuilder.CreateTable(
                name: "CLS_TAB",
                columns: table => new
                {
                    F01 = table.Column<string>(unicode: false, maxLength: 13, nullable: false),
                    F2935 = table.Column<string>(unicode: false, maxLength: 11, nullable: false),
                    F1001 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("CLS_TAB_P01", x => new { x.F01, x.F2935 });
                });

            migrationBuilder.CreateTable(
                name: "CLT_DEL",
                columns: table => new
                {
                    F1148 = table.Column<string>(unicode: false, maxLength: 14, nullable: false),
                    F902 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F1000 = table.Column<string>(unicode: false, maxLength: 5, nullable: true),
                    F1001 = table.Column<int>(nullable: true),
                    F1150 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F1152 = table.Column<int>(nullable: true),
                    F1153 = table.Column<int>(nullable: true),
                    F1154 = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    F1172 = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    F1573 = table.Column<string>(unicode: false, maxLength: 60, nullable: true),
                    F253 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F940 = table.Column<int>(nullable: true),
                    F941 = table.Column<int>(nullable: true),
                    F1149 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F1151 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F1155 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F1156 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F1157 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F1158 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F1159 = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    F1160 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    F1161 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    F1168 = table.Column<int>(nullable: true),
                    F1170 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    F1171 = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    F1173 = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    F1264 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F1265 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F1501 = table.Column<string>(unicode: false, maxLength: 14, nullable: true),
                    F1502 = table.Column<string>(unicode: false, maxLength: 6, nullable: true),
                    F1504 = table.Column<string>(unicode: false, maxLength: 2, nullable: true),
                    F1520 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F1521 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F1522 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F1523 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F1524 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F1525 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F1526 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F1527 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F1528 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F1529 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F1550 = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    F1574 = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    F1575 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F1576 = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    F1581 = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    F1582 = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    F1583 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F1584 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F1642 = table.Column<string>(unicode: false, maxLength: 14, nullable: true),
                    F1643 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F1644 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F1645 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F1646 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F1647 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F1648 = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    F1649 = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    F1650 = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    F1651 = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    F1654 = table.Column<double>(nullable: true),
                    F1655 = table.Column<double>(nullable: true),
                    F1685 = table.Column<int>(nullable: true),
                    F1692 = table.Column<string>(unicode: false, maxLength: 160, nullable: true),
                    F1697 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F1743 = table.Column<int>(nullable: true),
                    F1759 = table.Column<int>(nullable: true),
                    F1777 = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    F1778 = table.Column<string>(unicode: false, maxLength: 80, nullable: true),
                    F1809 = table.Column<string>(unicode: false, maxLength: 12, nullable: true),
                    F1810 = table.Column<int>(nullable: true),
                    F1950 = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    F1957 = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    F1964 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F2597 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    F2602 = table.Column<string>(unicode: false, maxLength: 3, nullable: true),
                    F2615 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F2616 = table.Column<int>(nullable: true),
                    F2617 = table.Column<decimal>(type: "money", nullable: true),
                    F2619 = table.Column<double>(nullable: true),
                    F2660 = table.Column<string>(unicode: false, maxLength: 250, nullable: true),
                    F2743 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F2807 = table.Column<double>(nullable: true),
                    F2808 = table.Column<decimal>(type: "money", nullable: true),
                    F2809 = table.Column<double>(nullable: true),
                    F2810 = table.Column<decimal>(type: "money", nullable: true),
                    F2811 = table.Column<double>(nullable: true),
                    F2812 = table.Column<decimal>(type: "money", nullable: true),
                    F2875 = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    F2889 = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    F2899 = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    F2900 = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    F2901 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F2904 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F2934 = table.Column<string>(unicode: false, maxLength: 160, nullable: true),
                    F2977 = table.Column<string>(unicode: false, maxLength: 250, nullable: true),
                    F2978 = table.Column<string>(unicode: false, maxLength: 12, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("CLT_DEL_P1148", x => x.F1148);
                });

            migrationBuilder.CreateTable(
                name: "CLT_ITM_DEL",
                columns: table => new
                {
                    F1148 = table.Column<string>(unicode: false, maxLength: 14, nullable: false),
                    F01 = table.Column<string>(unicode: false, maxLength: 13, nullable: false),
                    F1001 = table.Column<int>(nullable: true),
                    F33 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F35 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F49 = table.Column<double>(nullable: true),
                    F62 = table.Column<double>(nullable: true),
                    F63 = table.Column<decimal>(type: "money", nullable: true),
                    F129 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F168 = table.Column<decimal>(type: "money", nullable: true),
                    F253 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F902 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F1005 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F1713 = table.Column<double>(nullable: true),
                    F1714 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F1759 = table.Column<int>(nullable: true),
                    F1780 = table.Column<string>(unicode: false, maxLength: 12, nullable: true),
                    F1964 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F2604 = table.Column<decimal>(type: "money", nullable: true),
                    F2605 = table.Column<double>(nullable: true),
                    F2606 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F2607 = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("CLT_ITM_DEL_P1148", x => new { x.F1148, x.F01 });
                });

            migrationBuilder.CreateTable(
                name: "CLT_ITM_TAB",
                columns: table => new
                {
                    F1148 = table.Column<string>(unicode: false, maxLength: 14, nullable: false),
                    F01 = table.Column<string>(unicode: false, maxLength: 13, nullable: false),
                    F1001 = table.Column<int>(nullable: true),
                    F33 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F35 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F49 = table.Column<double>(nullable: true),
                    F62 = table.Column<double>(nullable: true),
                    F63 = table.Column<decimal>(type: "money", nullable: true),
                    F129 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F168 = table.Column<decimal>(type: "money", nullable: true),
                    F253 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F902 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F1005 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F1713 = table.Column<double>(nullable: true),
                    F1714 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F1759 = table.Column<int>(nullable: true),
                    F1780 = table.Column<string>(unicode: false, maxLength: 12, nullable: true),
                    F1964 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F2604 = table.Column<decimal>(type: "money", nullable: true),
                    F2605 = table.Column<double>(nullable: true),
                    F2606 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F2607 = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("CLT_ITM_TAB_P1148", x => new { x.F1148, x.F01 });
                });

            migrationBuilder.CreateTable(
                name: "CLT_TAB",
                columns: table => new
                {
                    F1148 = table.Column<string>(unicode: false, maxLength: 14, nullable: false),
                    F902 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F1000 = table.Column<string>(unicode: false, maxLength: 5, nullable: true),
                    F1001 = table.Column<int>(nullable: true),
                    F1150 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F1152 = table.Column<int>(nullable: true),
                    F1153 = table.Column<int>(nullable: true),
                    F1154 = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    F1172 = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    F1573 = table.Column<string>(unicode: false, maxLength: 60, nullable: true),
                    F253 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F940 = table.Column<int>(nullable: true),
                    F941 = table.Column<int>(nullable: true),
                    F1149 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F1151 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F1155 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F1156 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F1157 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F1158 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F1159 = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    F1160 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    F1161 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    F1168 = table.Column<int>(nullable: true),
                    F1170 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    F1171 = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    F1173 = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    F1264 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F1265 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F1501 = table.Column<string>(unicode: false, maxLength: 14, nullable: true),
                    F1502 = table.Column<string>(unicode: false, maxLength: 6, nullable: true),
                    F1504 = table.Column<string>(unicode: false, maxLength: 2, nullable: true),
                    F1520 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F1521 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F1522 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F1523 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F1524 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F1525 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F1526 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F1527 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F1528 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F1529 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F1550 = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    F1574 = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    F1575 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F1576 = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    F1581 = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    F1582 = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    F1583 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F1584 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F1642 = table.Column<string>(unicode: false, maxLength: 14, nullable: true),
                    F1643 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F1644 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F1645 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F1646 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F1647 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F1648 = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    F1649 = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    F1650 = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    F1651 = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    F1654 = table.Column<double>(nullable: true),
                    F1655 = table.Column<double>(nullable: true),
                    F1685 = table.Column<int>(nullable: true),
                    F1692 = table.Column<string>(unicode: false, maxLength: 160, nullable: true),
                    F1697 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F1743 = table.Column<int>(nullable: true),
                    F1759 = table.Column<int>(nullable: true),
                    F1777 = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    F1778 = table.Column<string>(unicode: false, maxLength: 80, nullable: true),
                    F1809 = table.Column<string>(unicode: false, maxLength: 12, nullable: true),
                    F1810 = table.Column<int>(nullable: true),
                    F1950 = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    F1957 = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    F1964 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F2597 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    F2602 = table.Column<string>(unicode: false, maxLength: 3, nullable: true),
                    F2615 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F2616 = table.Column<int>(nullable: true),
                    F2617 = table.Column<decimal>(type: "money", nullable: true),
                    F2619 = table.Column<double>(nullable: true),
                    F2660 = table.Column<string>(unicode: false, maxLength: 250, nullable: true),
                    F2743 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F2807 = table.Column<double>(nullable: true),
                    F2808 = table.Column<decimal>(type: "money", nullable: true),
                    F2809 = table.Column<double>(nullable: true),
                    F2810 = table.Column<decimal>(type: "money", nullable: true),
                    F2811 = table.Column<double>(nullable: true),
                    F2812 = table.Column<decimal>(type: "money", nullable: true),
                    F2875 = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    F2889 = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    F2899 = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    F2900 = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    F2901 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F2904 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F2934 = table.Column<string>(unicode: false, maxLength: 160, nullable: true),
                    F2977 = table.Column<string>(unicode: false, maxLength: 250, nullable: true),
                    F2978 = table.Column<string>(unicode: false, maxLength: 12, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("CLT_TAB_P1148", x => x.F1148);
                });

            migrationBuilder.CreateTable(
                name: "COST_DEL",
                columns: table => new
                {
                    F01 = table.Column<string>(unicode: false, maxLength: 13, nullable: false),
                    F1000 = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    F27 = table.Column<string>(unicode: false, maxLength: 14, nullable: false),
                    F1184 = table.Column<string>(unicode: false, maxLength: 12, nullable: false),
                    F26 = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    F902 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F1001 = table.Column<int>(nullable: true),
                    F07 = table.Column<int>(nullable: true),
                    F08 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F19 = table.Column<double>(nullable: true),
                    F20 = table.Column<double>(nullable: true),
                    F28 = table.Column<string>(unicode: false, maxLength: 13, nullable: true),
                    F38 = table.Column<decimal>(type: "money", nullable: true),
                    F39 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F90 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F120 = table.Column<decimal>(type: "money", nullable: true),
                    F127 = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    F131 = table.Column<int>(nullable: true),
                    F134 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F151 = table.Column<decimal>(type: "money", nullable: true),
                    F152 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F156 = table.Column<string>(unicode: false, maxLength: 120, nullable: true),
                    F165 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F185 = table.Column<decimal>(type: "money", nullable: true),
                    F194 = table.Column<double>(nullable: true),
                    F195 = table.Column<decimal>(type: "money", nullable: true),
                    F196 = table.Column<decimal>(type: "money", nullable: true),
                    F201 = table.Column<decimal>(type: "money", nullable: true),
                    F202 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F203 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F204 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F212 = table.Column<string>(unicode: false, maxLength: 6, nullable: true),
                    F216 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F219 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F220 = table.Column<string>(unicode: false, maxLength: 13, nullable: true),
                    F222 = table.Column<string>(unicode: false, maxLength: 12, nullable: true),
                    F223 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F224 = table.Column<double>(nullable: true),
                    F225 = table.Column<decimal>(type: "money", nullable: true),
                    F226 = table.Column<double>(nullable: true),
                    F227 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F228 = table.Column<double>(nullable: true),
                    F229 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F230 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F231 = table.Column<string>(unicode: false, maxLength: 12, nullable: true),
                    F233 = table.Column<decimal>(type: "money", nullable: true),
                    F234 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F235 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F236 = table.Column<string>(unicode: false, maxLength: 12, nullable: true),
                    F237 = table.Column<double>(nullable: true),
                    F253 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F325 = table.Column<double>(nullable: true),
                    F326 = table.Column<double>(nullable: true),
                    F327 = table.Column<double>(nullable: true),
                    F328 = table.Column<double>(nullable: true),
                    F329 = table.Column<double>(nullable: true),
                    F1037 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F1038 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F1121 = table.Column<decimal>(type: "money", nullable: true),
                    F1122 = table.Column<double>(nullable: true),
                    F1140 = table.Column<decimal>(type: "money", nullable: true),
                    F1168 = table.Column<int>(nullable: true),
                    F1657 = table.Column<double>(nullable: true),
                    F1658 = table.Column<decimal>(type: "money", nullable: true),
                    F1659 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F1660 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F1661 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F1662 = table.Column<decimal>(type: "money", nullable: true),
                    F1663 = table.Column<double>(nullable: true),
                    F1664 = table.Column<decimal>(type: "money", nullable: true),
                    F1665 = table.Column<double>(nullable: true),
                    F1666 = table.Column<decimal>(type: "money", nullable: true),
                    F1667 = table.Column<double>(nullable: true),
                    F1668 = table.Column<string>(unicode: false, maxLength: 16, nullable: true),
                    F1669 = table.Column<decimal>(type: "money", nullable: true),
                    F1670 = table.Column<double>(nullable: true),
                    F1685 = table.Column<int>(nullable: true),
                    F1759 = table.Column<int>(nullable: true),
                    F1760 = table.Column<double>(nullable: true),
                    F1761 = table.Column<double>(nullable: true),
                    F1766 = table.Column<decimal>(type: "money", nullable: true),
                    F1791 = table.Column<string>(unicode: false, maxLength: 12, nullable: true),
                    F1792 = table.Column<string>(unicode: false, maxLength: 12, nullable: true),
                    F1793 = table.Column<int>(nullable: true),
                    F1794 = table.Column<int>(nullable: true),
                    F1795 = table.Column<double>(nullable: true),
                    F1796 = table.Column<double>(nullable: true),
                    F1797 = table.Column<decimal>(type: "money", nullable: true),
                    F1798 = table.Column<decimal>(type: "money", nullable: true),
                    F1875 = table.Column<string>(unicode: false, maxLength: 2, nullable: true),
                    F1887 = table.Column<string>(unicode: false, maxLength: 2, nullable: true),
                    F1961 = table.Column<string>(unicode: false, maxLength: 2, nullable: true),
                    F1964 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F1973 = table.Column<string>(unicode: false, maxLength: 120, nullable: true),
                    F1974 = table.Column<string>(unicode: false, maxLength: 120, nullable: true),
                    F1975 = table.Column<string>(unicode: false, maxLength: 120, nullable: true),
                    F1976 = table.Column<string>(unicode: false, maxLength: 120, nullable: true),
                    F1977 = table.Column<double>(nullable: true),
                    F1978 = table.Column<double>(nullable: true),
                    F1979 = table.Column<double>(nullable: true),
                    F2119 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F2566 = table.Column<double>(nullable: true),
                    F2567 = table.Column<double>(nullable: true),
                    F2568 = table.Column<double>(nullable: true),
                    F2601 = table.Column<string>(unicode: false, maxLength: 2, nullable: true),
                    F2624 = table.Column<int>(nullable: true),
                    F2626 = table.Column<decimal>(type: "money", nullable: true),
                    F2628 = table.Column<double>(nullable: true),
                    F2666 = table.Column<double>(nullable: true),
                    F2699 = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("COST_DEL_P01", x => new { x.F01, x.F1000, x.F27, x.F1184 });
                });

            migrationBuilder.CreateTable(
                name: "COST_TAB",
                columns: table => new
                {
                    F01 = table.Column<string>(unicode: false, maxLength: 13, nullable: false),
                    F1000 = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    F27 = table.Column<string>(unicode: false, maxLength: 14, nullable: false),
                    F1184 = table.Column<string>(unicode: false, maxLength: 12, nullable: false),
                    F26 = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    F902 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F1001 = table.Column<int>(nullable: true),
                    F07 = table.Column<int>(nullable: true),
                    F08 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F19 = table.Column<double>(nullable: true),
                    F20 = table.Column<double>(nullable: true),
                    F28 = table.Column<string>(unicode: false, maxLength: 13, nullable: true),
                    F38 = table.Column<decimal>(type: "money", nullable: true),
                    F39 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F90 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F120 = table.Column<decimal>(type: "money", nullable: true),
                    F127 = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    F131 = table.Column<int>(nullable: true),
                    F134 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F151 = table.Column<decimal>(type: "money", nullable: true),
                    F152 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F156 = table.Column<string>(unicode: false, maxLength: 120, nullable: true),
                    F165 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F185 = table.Column<decimal>(type: "money", nullable: true),
                    F194 = table.Column<double>(nullable: true),
                    F195 = table.Column<decimal>(type: "money", nullable: true),
                    F196 = table.Column<decimal>(type: "money", nullable: true),
                    F201 = table.Column<decimal>(type: "money", nullable: true),
                    F202 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F203 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F204 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F212 = table.Column<string>(unicode: false, maxLength: 6, nullable: true),
                    F216 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F219 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F220 = table.Column<string>(unicode: false, maxLength: 13, nullable: true),
                    F222 = table.Column<string>(unicode: false, maxLength: 12, nullable: true),
                    F223 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F224 = table.Column<double>(nullable: true),
                    F225 = table.Column<decimal>(type: "money", nullable: true),
                    F226 = table.Column<double>(nullable: true),
                    F227 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F228 = table.Column<double>(nullable: true),
                    F229 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F230 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F231 = table.Column<string>(unicode: false, maxLength: 12, nullable: true),
                    F233 = table.Column<decimal>(type: "money", nullable: true),
                    F234 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F235 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F236 = table.Column<string>(unicode: false, maxLength: 12, nullable: true),
                    F237 = table.Column<double>(nullable: true),
                    F253 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F325 = table.Column<double>(nullable: true),
                    F326 = table.Column<double>(nullable: true),
                    F327 = table.Column<double>(nullable: true),
                    F328 = table.Column<double>(nullable: true),
                    F329 = table.Column<double>(nullable: true),
                    F1037 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F1038 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F1121 = table.Column<decimal>(type: "money", nullable: true),
                    F1122 = table.Column<double>(nullable: true),
                    F1140 = table.Column<decimal>(type: "money", nullable: true),
                    F1168 = table.Column<int>(nullable: true),
                    F1657 = table.Column<double>(nullable: true),
                    F1658 = table.Column<decimal>(type: "money", nullable: true),
                    F1659 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F1660 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F1661 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F1662 = table.Column<decimal>(type: "money", nullable: true),
                    F1663 = table.Column<double>(nullable: true),
                    F1664 = table.Column<decimal>(type: "money", nullable: true),
                    F1665 = table.Column<double>(nullable: true),
                    F1666 = table.Column<decimal>(type: "money", nullable: true),
                    F1667 = table.Column<double>(nullable: true),
                    F1668 = table.Column<string>(unicode: false, maxLength: 16, nullable: true),
                    F1669 = table.Column<decimal>(type: "money", nullable: true),
                    F1670 = table.Column<double>(nullable: true),
                    F1685 = table.Column<int>(nullable: true),
                    F1759 = table.Column<int>(nullable: true),
                    F1760 = table.Column<double>(nullable: true),
                    F1761 = table.Column<double>(nullable: true),
                    F1766 = table.Column<decimal>(type: "money", nullable: true),
                    F1791 = table.Column<string>(unicode: false, maxLength: 12, nullable: true),
                    F1792 = table.Column<string>(unicode: false, maxLength: 12, nullable: true),
                    F1793 = table.Column<int>(nullable: true),
                    F1794 = table.Column<int>(nullable: true),
                    F1795 = table.Column<double>(nullable: true),
                    F1796 = table.Column<double>(nullable: true),
                    F1797 = table.Column<decimal>(type: "money", nullable: true),
                    F1798 = table.Column<decimal>(type: "money", nullable: true),
                    F1875 = table.Column<string>(unicode: false, maxLength: 2, nullable: true),
                    F1887 = table.Column<string>(unicode: false, maxLength: 2, nullable: true),
                    F1961 = table.Column<string>(unicode: false, maxLength: 2, nullable: true),
                    F1964 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F1973 = table.Column<string>(unicode: false, maxLength: 120, nullable: true),
                    F1974 = table.Column<string>(unicode: false, maxLength: 120, nullable: true),
                    F1975 = table.Column<string>(unicode: false, maxLength: 120, nullable: true),
                    F1976 = table.Column<string>(unicode: false, maxLength: 120, nullable: true),
                    F1977 = table.Column<double>(nullable: true),
                    F1978 = table.Column<double>(nullable: true),
                    F1979 = table.Column<double>(nullable: true),
                    F2119 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F2566 = table.Column<double>(nullable: true),
                    F2567 = table.Column<double>(nullable: true),
                    F2568 = table.Column<double>(nullable: true),
                    F2601 = table.Column<string>(unicode: false, maxLength: 2, nullable: true),
                    F2624 = table.Column<int>(nullable: true),
                    F2626 = table.Column<decimal>(type: "money", nullable: true),
                    F2628 = table.Column<double>(nullable: true),
                    F2666 = table.Column<double>(nullable: true),
                    F2699 = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("COST_TAB_P01", x => new { x.F01, x.F1000, x.F27, x.F1184 });
                });

            migrationBuilder.CreateTable(
                name: "CPN_TAB",
                columns: table => new
                {
                    F2034 = table.Column<int>(nullable: false),
                    F1000 = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    F1001 = table.Column<int>(nullable: true),
                    F2035 = table.Column<string>(unicode: false, maxLength: 6, nullable: true),
                    F2036 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F2037 = table.Column<double>(nullable: true),
                    F2038 = table.Column<double>(nullable: true),
                    F2039 = table.Column<string>(unicode: false, maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("CPN_TAB_P2034", x => new { x.F2034, x.F1000 });
                });

            migrationBuilder.CreateTable(
                name: "DATA_REG",
                columns: table => new
                {
                    F254 = table.Column<DateTime>(type: "datetime", nullable: false),
                    F1031 = table.Column<string>(unicode: false, maxLength: 1, nullable: false),
                    F1056 = table.Column<string>(unicode: false, maxLength: 4, nullable: false),
                    F1068 = table.Column<string>(unicode: false, maxLength: 6, nullable: false),
                    F154 = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
                    F1034 = table.Column<int>(nullable: false),
                    F64 = table.Column<double>(nullable: true),
                    F65 = table.Column<decimal>(type: "money", nullable: true),
                    F67 = table.Column<double>(nullable: true),
                    F253 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F1079 = table.Column<string>(unicode: false, maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("DATA_REG_P254", x => new { x.F254, x.F1031, x.F1056, x.F1068, x.F154, x.F1034 });
                });

            migrationBuilder.CreateTable(
                name: "DELV_TAB",
                columns: table => new
                {
                    F27 = table.Column<string>(unicode: false, maxLength: 14, nullable: false),
                    F1000 = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    F2659 = table.Column<string>(unicode: false, maxLength: 6, nullable: false),
                    F2663 = table.Column<string>(unicode: false, maxLength: 2, nullable: false),
                    F2664 = table.Column<int>(nullable: false),
                    F2665 = table.Column<int>(nullable: false),
                    F2656 = table.Column<string>(unicode: false, maxLength: 6, nullable: false),
                    F2655 = table.Column<string>(unicode: false, maxLength: 6, nullable: false),
                    F2658 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F2661 = table.Column<int>(nullable: true),
                    F2662 = table.Column<string>(unicode: false, maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("DELV_TAB_P27", x => new { x.F27, x.F1000, x.F2659, x.F2663, x.F2664, x.F2665, x.F2656, x.F2655 });
                });

            migrationBuilder.CreateTable(
                name: "DEPT_TAB",
                columns: table => new
                {
                    F03 = table.Column<int>(nullable: false),
                    F49 = table.Column<double>(nullable: true),
                    F78 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F79 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F80 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F81 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F82 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F88 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F96 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F97 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F98 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F99 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F100 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F101 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F104 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F108 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F114 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F115 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F121 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F124 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F150 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F170 = table.Column<int>(nullable: true),
                    F171 = table.Column<int>(nullable: true),
                    F172 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F177 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F178 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F238 = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    F239 = table.Column<decimal>(type: "money", nullable: true),
                    F240 = table.Column<decimal>(type: "money", nullable: true),
                    F241 = table.Column<decimal>(type: "money", nullable: true),
                    F242 = table.Column<decimal>(type: "money", nullable: true),
                    F1120 = table.Column<string>(unicode: false, maxLength: 12, nullable: true),
                    F1123 = table.Column<double>(nullable: true),
                    F1124 = table.Column<double>(nullable: true),
                    F1132 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    F1139 = table.Column<int>(nullable: true),
                    F1147 = table.Column<int>(nullable: true),
                    F1168 = table.Column<int>(nullable: true),
                    F1256 = table.Column<double>(nullable: true),
                    F1785 = table.Column<string>(unicode: false, maxLength: 12, nullable: true),
                    F1894 = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    F1965 = table.Column<int>(nullable: true),
                    F1966 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    F1967 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F2660 = table.Column<string>(unicode: false, maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("DEPT_TAB_P03", x => x.F03);
                });

            migrationBuilder.CreateTable(
                name: "Dril_File",
                columns: table => new
                {
                    F1000 = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    F1597 = table.Column<string>(unicode: false, maxLength: 40, nullable: false),
                    F1606 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F1607 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F1608 = table.Column<string>(unicode: false, maxLength: 40, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Dril_File_P1000", x => new { x.F1000, x.F1597 });
                });

            migrationBuilder.CreateTable(
                name: "Dril_Page",
                columns: table => new
                {
                    F1597 = table.Column<string>(unicode: false, maxLength: 40, nullable: false),
                    F1598 = table.Column<int>(nullable: false),
                    F1042 = table.Column<int>(nullable: true),
                    F1043 = table.Column<int>(nullable: true),
                    F1044 = table.Column<int>(nullable: true),
                    F1045 = table.Column<int>(nullable: true),
                    F1046 = table.Column<int>(nullable: true),
                    F1047 = table.Column<int>(nullable: true),
                    F1054 = table.Column<int>(nullable: true),
                    F1055 = table.Column<int>(nullable: true),
                    F1599 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F1600 = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    F1601 = table.Column<string>(unicode: false, maxLength: 120, nullable: true),
                    F1602 = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    F1603 = table.Column<int>(nullable: true),
                    F1604 = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    F1605 = table.Column<string>(unicode: false, maxLength: 250, nullable: true),
                    F1609 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F1698 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F1817 = table.Column<int>(nullable: true),
                    F1818 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Dril_Page_P1597", x => new { x.F1597, x.F1598 });
                });

            migrationBuilder.CreateTable(
                name: "DSD_DEL",
                columns: table => new
                {
                    F01 = table.Column<string>(unicode: false, maxLength: 13, nullable: false),
                    F1000 = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    F902 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F1001 = table.Column<int>(nullable: true),
                    F07 = table.Column<int>(nullable: true),
                    F15 = table.Column<int>(nullable: true),
                    F68 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F69 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F72 = table.Column<double>(nullable: true),
                    F73 = table.Column<double>(nullable: true),
                    F74 = table.Column<double>(nullable: true),
                    F253 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F1123 = table.Column<double>(nullable: true),
                    F1759 = table.Column<int>(nullable: true),
                    F1964 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F2697 = table.Column<double>(nullable: true),
                    F2698 = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("DSD_DEL_P01", x => new { x.F01, x.F1000 });
                });

            migrationBuilder.CreateTable(
                name: "DSD_TAB",
                columns: table => new
                {
                    F01 = table.Column<string>(unicode: false, maxLength: 13, nullable: false),
                    F1000 = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    F902 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F1001 = table.Column<int>(nullable: true),
                    F07 = table.Column<int>(nullable: true),
                    F15 = table.Column<int>(nullable: true),
                    F68 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F69 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F72 = table.Column<double>(nullable: true),
                    F73 = table.Column<double>(nullable: true),
                    F74 = table.Column<double>(nullable: true),
                    F253 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F1123 = table.Column<double>(nullable: true),
                    F1759 = table.Column<int>(nullable: true),
                    F1964 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F2697 = table.Column<double>(nullable: true),
                    F2698 = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("DSD_TAB_P01", x => new { x.F01, x.F1000 });
                });

            migrationBuilder.CreateTable(
                name: "DSS_TAB",
                columns: table => new
                {
                    F2729 = table.Column<string>(unicode: false, maxLength: 60, nullable: false),
                    F2730 = table.Column<string>(unicode: false, maxLength: 60, nullable: false),
                    F2731 = table.Column<string>(unicode: false, maxLength: 60, nullable: false),
                    F253 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F2727 = table.Column<int>(nullable: true),
                    F2728 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F2732 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F2733 = table.Column<string>(unicode: false, maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("DSS_TAB_P2729", x => new { x.F2729, x.F2730, x.F2731 });
                });

            migrationBuilder.CreateTable(
                name: "ECL_DEL",
                columns: table => new
                {
                    F164 = table.Column<string>(unicode: false, maxLength: 13, nullable: false),
                    F1033 = table.Column<string>(unicode: false, maxLength: 3, nullable: false),
                    F01 = table.Column<string>(unicode: false, maxLength: 13, nullable: false),
                    F1031 = table.Column<string>(unicode: false, maxLength: 1, nullable: false),
                    F1034 = table.Column<int>(nullable: false),
                    F1000 = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    F902 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F1001 = table.Column<int>(nullable: true),
                    F02 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F33 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F64 = table.Column<double>(nullable: true),
                    F65 = table.Column<decimal>(type: "money", nullable: true),
                    F67 = table.Column<double>(nullable: true),
                    F1759 = table.Column<int>(nullable: true),
                    F1964 = table.Column<string>(unicode: false, maxLength: 4, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ECL_DEL_P164", x => new { x.F164, x.F1033, x.F01, x.F1031, x.F1034, x.F1000 });
                });

            migrationBuilder.CreateTable(
                name: "ECL_TAB",
                columns: table => new
                {
                    F164 = table.Column<string>(unicode: false, maxLength: 13, nullable: false),
                    F1033 = table.Column<string>(unicode: false, maxLength: 3, nullable: false),
                    F01 = table.Column<string>(unicode: false, maxLength: 13, nullable: false),
                    F1031 = table.Column<string>(unicode: false, maxLength: 1, nullable: false),
                    F1034 = table.Column<int>(nullable: false),
                    F1000 = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    F902 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F1001 = table.Column<int>(nullable: true),
                    F02 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F33 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F64 = table.Column<double>(nullable: true),
                    F65 = table.Column<decimal>(type: "money", nullable: true),
                    F67 = table.Column<double>(nullable: true),
                    F1759 = table.Column<int>(nullable: true),
                    F1964 = table.Column<string>(unicode: false, maxLength: 4, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ECL_TAB_P164", x => new { x.F164, x.F1033, x.F01, x.F1031, x.F1034, x.F1000 });
                });

            migrationBuilder.CreateTable(
                name: "EXC_TAB",
                columns: table => new
                {
                    F1511 = table.Column<int>(nullable: false),
                    F1512 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F1513 = table.Column<string>(unicode: false, maxLength: 6, nullable: true),
                    F1897 = table.Column<string>(unicode: false, maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("EXC_TAB_P1511", x => x.F1511);
                });

            migrationBuilder.CreateTable(
                name: "FAM_TAB",
                columns: table => new
                {
                    F16 = table.Column<int>(nullable: false),
                    F49 = table.Column<double>(nullable: true),
                    F1040 = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    F1123 = table.Column<double>(nullable: true),
                    F1124 = table.Column<double>(nullable: true),
                    F1168 = table.Column<int>(nullable: true),
                    F1965 = table.Column<int>(nullable: true),
                    F1966 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    F1967 = table.Column<string>(unicode: false, maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("FAM_TAB_P16", x => x.F16);
                });

            migrationBuilder.CreateTable(
                name: "FBBACK_BAT",
                columns: table => new
                {
                    F01 = table.Column<string>(unicode: false, maxLength: 13, nullable: false),
                    F902 = table.Column<string>(unicode: false, maxLength: 8, nullable: false),
                    F1000 = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    F27 = table.Column<string>(unicode: false, maxLength: 14, nullable: false),
                    F1184 = table.Column<string>(unicode: false, maxLength: 12, nullable: false),
                    F07 = table.Column<int>(nullable: true),
                    F1001 = table.Column<int>(nullable: true),
                    F1662 = table.Column<decimal>(type: "money", nullable: true),
                    F1663 = table.Column<double>(nullable: true),
                    F1664 = table.Column<decimal>(type: "money", nullable: true),
                    F1665 = table.Column<double>(nullable: true),
                    F1666 = table.Column<decimal>(type: "money", nullable: true),
                    F1667 = table.Column<double>(nullable: true),
                    F1668 = table.Column<string>(unicode: false, maxLength: 16, nullable: true),
                    F1669 = table.Column<decimal>(type: "money", nullable: true),
                    F1670 = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("FBBACK_BAT_P01", x => new { x.F01, x.F902, x.F1000, x.F27, x.F1184 });
                });

            migrationBuilder.CreateTable(
                name: "FCOST_BAT",
                columns: table => new
                {
                    F01 = table.Column<string>(unicode: false, maxLength: 13, nullable: false),
                    F902 = table.Column<string>(unicode: false, maxLength: 8, nullable: false),
                    F1000 = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    F27 = table.Column<string>(unicode: false, maxLength: 14, nullable: false),
                    F1184 = table.Column<string>(unicode: false, maxLength: 12, nullable: false),
                    F07 = table.Column<int>(nullable: true),
                    F19 = table.Column<double>(nullable: true),
                    F20 = table.Column<double>(nullable: true),
                    F38 = table.Column<decimal>(type: "money", nullable: true),
                    F39 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F120 = table.Column<decimal>(type: "money", nullable: true),
                    F185 = table.Column<decimal>(type: "money", nullable: true),
                    F212 = table.Column<string>(unicode: false, maxLength: 6, nullable: true),
                    F1001 = table.Column<int>(nullable: true),
                    F1121 = table.Column<decimal>(type: "money", nullable: true),
                    F1122 = table.Column<double>(nullable: true),
                    F1964 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F2626 = table.Column<decimal>(type: "money", nullable: true),
                    F2628 = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("FCOST_BAT_P01", x => new { x.F01, x.F902, x.F1000, x.F27, x.F1184 });
                });

            migrationBuilder.CreateTable(
                name: "FCSTBRK_BAT",
                columns: table => new
                {
                    F01 = table.Column<string>(unicode: false, maxLength: 13, nullable: false),
                    F902 = table.Column<string>(unicode: false, maxLength: 8, nullable: false),
                    F1000 = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    F27 = table.Column<string>(unicode: false, maxLength: 14, nullable: false),
                    F1184 = table.Column<string>(unicode: false, maxLength: 12, nullable: false),
                    F07 = table.Column<int>(nullable: true),
                    F219 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F224 = table.Column<double>(nullable: true),
                    F225 = table.Column<decimal>(type: "money", nullable: true),
                    F226 = table.Column<double>(nullable: true),
                    F227 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F1001 = table.Column<int>(nullable: true),
                    F1661 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F1975 = table.Column<string>(unicode: false, maxLength: 120, nullable: true),
                    F2568 = table.Column<double>(nullable: true),
                    F2594 = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("FCSTBRK_BAT_P01", x => new { x.F01, x.F902, x.F1000, x.F27, x.F1184 });
                });

            migrationBuilder.CreateTable(
                name: "FCT_TAB",
                columns: table => new
                {
                    F1063 = table.Column<int>(nullable: false),
                    F1000 = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    F81 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F85 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F96 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F97 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F98 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F99 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F100 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F101 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F102 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F125 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F172 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F239 = table.Column<decimal>(type: "money", nullable: true),
                    F240 = table.Column<decimal>(type: "money", nullable: true),
                    F241 = table.Column<decimal>(type: "money", nullable: true),
                    F242 = table.Column<decimal>(type: "money", nullable: true),
                    F1042 = table.Column<int>(nullable: true),
                    F1043 = table.Column<int>(nullable: true),
                    F1044 = table.Column<int>(nullable: true),
                    F1045 = table.Column<int>(nullable: true),
                    F1046 = table.Column<int>(nullable: true),
                    F1047 = table.Column<int>(nullable: true),
                    F1050 = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    F1051 = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    F1052 = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    F1053 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F1054 = table.Column<int>(nullable: true),
                    F1055 = table.Column<int>(nullable: true),
                    F1064 = table.Column<string>(unicode: false, maxLength: 60, nullable: true),
                    F1081 = table.Column<string>(unicode: false, maxLength: 5000, nullable: true),
                    F1082 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F1083 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F1084 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F1085 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F1086 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F1088 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F1089 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F1090 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F1091 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F1092 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F1147 = table.Column<int>(nullable: true),
                    F1817 = table.Column<int>(nullable: true),
                    F1818 = table.Column<int>(nullable: true),
                    F1895 = table.Column<string>(unicode: false, maxLength: 60, nullable: true),
                    F1897 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F1965 = table.Column<int>(nullable: true),
                    F1966 = table.Column<string>(unicode: false, maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("FCT_TAB_P1063", x => new { x.F1063, x.F1000 });
                });

            migrationBuilder.CreateTable(
                name: "FCZ_TAB",
                columns: table => new
                {
                    F1063 = table.Column<int>(nullable: false),
                    F1034 = table.Column<int>(nullable: false),
                    F1000 = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    F1065 = table.Column<string>(unicode: false, maxLength: 40, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("FCZ_TAB_P1063", x => new { x.F1063, x.F1034, x.F1000 });
                });

            migrationBuilder.CreateTable(
                name: "FDISC_BAT",
                columns: table => new
                {
                    F01 = table.Column<string>(unicode: false, maxLength: 13, nullable: false),
                    F902 = table.Column<string>(unicode: false, maxLength: 8, nullable: false),
                    F1000 = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    F27 = table.Column<string>(unicode: false, maxLength: 14, nullable: false),
                    F1184 = table.Column<string>(unicode: false, maxLength: 12, nullable: false),
                    F07 = table.Column<int>(nullable: true),
                    F228 = table.Column<double>(nullable: true),
                    F229 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F230 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F231 = table.Column<string>(unicode: false, maxLength: 12, nullable: true),
                    F1001 = table.Column<int>(nullable: true),
                    F1658 = table.Column<decimal>(type: "money", nullable: true),
                    F1659 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F1973 = table.Column<string>(unicode: false, maxLength: 120, nullable: true),
                    F1978 = table.Column<double>(nullable: true),
                    F2566 = table.Column<double>(nullable: true),
                    F2593 = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("FDISC_BAT_P01", x => new { x.F01, x.F902, x.F1000, x.F27, x.F1184 });
                });

            migrationBuilder.CreateTable(
                name: "FECL_BAT",
                columns: table => new
                {
                    F902 = table.Column<string>(unicode: false, maxLength: 8, nullable: false),
                    F164 = table.Column<string>(unicode: false, maxLength: 13, nullable: false),
                    F1033 = table.Column<string>(unicode: false, maxLength: 3, nullable: false),
                    F01 = table.Column<string>(unicode: false, maxLength: 13, nullable: false),
                    F1031 = table.Column<string>(unicode: false, maxLength: 1, nullable: false),
                    F1034 = table.Column<int>(nullable: false),
                    F1000 = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    F02 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F33 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F64 = table.Column<double>(nullable: true),
                    F65 = table.Column<decimal>(type: "money", nullable: true),
                    F67 = table.Column<double>(nullable: true),
                    F1001 = table.Column<int>(nullable: true),
                    F1759 = table.Column<int>(nullable: true),
                    F1964 = table.Column<string>(unicode: false, maxLength: 4, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("FECL_BAT_P902", x => new { x.F902, x.F164, x.F1033, x.F01, x.F1031, x.F1034, x.F1000 });
                });

            migrationBuilder.CreateTable(
                name: "FGCOST_BAT",
                columns: table => new
                {
                    F01 = table.Column<string>(unicode: false, maxLength: 13, nullable: false),
                    F902 = table.Column<string>(unicode: false, maxLength: 8, nullable: false),
                    F1000 = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    F27 = table.Column<string>(unicode: false, maxLength: 14, nullable: false),
                    F1184 = table.Column<string>(unicode: false, maxLength: 12, nullable: false),
                    F07 = table.Column<int>(nullable: true),
                    F08 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F26 = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    F28 = table.Column<string>(unicode: false, maxLength: 13, nullable: true),
                    F90 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F127 = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    F131 = table.Column<int>(nullable: true),
                    F165 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F216 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F220 = table.Column<string>(unicode: false, maxLength: 13, nullable: true),
                    F325 = table.Column<double>(nullable: true),
                    F326 = table.Column<double>(nullable: true),
                    F327 = table.Column<double>(nullable: true),
                    F328 = table.Column<double>(nullable: true),
                    F1001 = table.Column<int>(nullable: true),
                    F1037 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F1168 = table.Column<int>(nullable: true),
                    F1685 = table.Column<int>(nullable: true),
                    F1759 = table.Column<int>(nullable: true),
                    F1760 = table.Column<double>(nullable: true),
                    F1761 = table.Column<double>(nullable: true),
                    F1766 = table.Column<decimal>(type: "money", nullable: true),
                    F1791 = table.Column<string>(unicode: false, maxLength: 12, nullable: true),
                    F1792 = table.Column<string>(unicode: false, maxLength: 12, nullable: true),
                    F1793 = table.Column<int>(nullable: true),
                    F1794 = table.Column<int>(nullable: true),
                    F1795 = table.Column<double>(nullable: true),
                    F1797 = table.Column<decimal>(type: "money", nullable: true),
                    F1798 = table.Column<decimal>(type: "money", nullable: true),
                    F1875 = table.Column<string>(unicode: false, maxLength: 2, nullable: true),
                    F1887 = table.Column<string>(unicode: false, maxLength: 2, nullable: true),
                    F1961 = table.Column<string>(unicode: false, maxLength: 2, nullable: true),
                    F1976 = table.Column<string>(unicode: false, maxLength: 120, nullable: true),
                    F2601 = table.Column<string>(unicode: false, maxLength: 2, nullable: true),
                    F2624 = table.Column<int>(nullable: true),
                    F2666 = table.Column<double>(nullable: true),
                    F2699 = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("FGCOST_BAT_P01", x => new { x.F01, x.F902, x.F1000, x.F27, x.F1184 });
                });

            migrationBuilder.CreateTable(
                name: "FGPRICE_BAT",
                columns: table => new
                {
                    F01 = table.Column<string>(unicode: false, maxLength: 13, nullable: false),
                    F902 = table.Column<string>(unicode: false, maxLength: 8, nullable: false),
                    F1000 = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    F126 = table.Column<int>(nullable: false),
                    F07 = table.Column<int>(nullable: true),
                    F21 = table.Column<double>(nullable: true),
                    F41 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F43 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F109 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F119 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F122 = table.Column<string>(unicode: false, maxLength: 13, nullable: true),
                    F164 = table.Column<string>(unicode: false, maxLength: 13, nullable: true),
                    F166 = table.Column<decimal>(type: "money", nullable: true),
                    F167 = table.Column<double>(nullable: true),
                    F175 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F177 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F903 = table.Column<string>(unicode: false, maxLength: 16, nullable: true),
                    F1001 = table.Column<int>(nullable: true),
                    F1135 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F1230 = table.Column<int>(nullable: true),
                    F1233 = table.Column<decimal>(type: "money", nullable: true),
                    F1759 = table.Column<int>(nullable: true),
                    F1799 = table.Column<string>(unicode: false, maxLength: 12, nullable: true),
                    F1800 = table.Column<string>(unicode: false, maxLength: 12, nullable: true),
                    F1802 = table.Column<int>(nullable: true),
                    F1803 = table.Column<double>(nullable: true),
                    F1804 = table.Column<double>(nullable: true),
                    F1885 = table.Column<decimal>(type: "money", nullable: true),
                    F1928 = table.Column<double>(nullable: true),
                    F1930 = table.Column<int>(nullable: true),
                    F1935 = table.Column<decimal>(type: "money", nullable: true),
                    F2694 = table.Column<string>(unicode: false, maxLength: 12, nullable: true),
                    F2695 = table.Column<string>(unicode: false, maxLength: 12, nullable: true),
                    F2696 = table.Column<string>(unicode: false, maxLength: 12, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("FGPRICE_BAT_P01", x => new { x.F01, x.F902, x.F1000, x.F126 });
                });

            migrationBuilder.CreateTable(
                name: "FIL_TAB",
                columns: table => new
                {
                    F1101 = table.Column<int>(nullable: false),
                    F1025 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F1026 = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    F1027 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F1028 = table.Column<string>(unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("FIL_TAB_P1101", x => x.F1101);
                });

            migrationBuilder.CreateTable(
                name: "FINSTORE_BAT",
                columns: table => new
                {
                    F01 = table.Column<string>(unicode: false, maxLength: 13, nullable: false),
                    F902 = table.Column<string>(unicode: false, maxLength: 8, nullable: false),
                    F1000 = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    F126 = table.Column<int>(nullable: false),
                    F07 = table.Column<int>(nullable: true),
                    F34 = table.Column<string>(unicode: false, maxLength: 2, nullable: true),
                    F37 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F59 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F1001 = table.Column<int>(nullable: true),
                    F1133 = table.Column<decimal>(type: "money", nullable: true),
                    F1134 = table.Column<double>(nullable: true),
                    F1194 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F1195 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F1196 = table.Column<decimal>(type: "money", nullable: true),
                    F1197 = table.Column<double>(nullable: true),
                    F1198 = table.Column<decimal>(type: "money", nullable: true),
                    F1199 = table.Column<double>(nullable: true),
                    F1200 = table.Column<int>(nullable: true),
                    F1201 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F1202 = table.Column<int>(nullable: true),
                    F1216 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F1217 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F1222 = table.Column<decimal>(type: "money", nullable: true),
                    F1223 = table.Column<double>(nullable: true),
                    F1871 = table.Column<double>(nullable: true),
                    F1872 = table.Column<double>(nullable: true),
                    F1873 = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("FINSTORE_BAT_P01", x => new { x.F01, x.F902, x.F1000, x.F126 });
                });

            migrationBuilder.CreateTable(
                name: "FOBJ_BAT",
                columns: table => new
                {
                    F01 = table.Column<string>(unicode: false, maxLength: 13, nullable: false),
                    F902 = table.Column<string>(unicode: false, maxLength: 8, nullable: false),
                    F07 = table.Column<int>(nullable: true),
                    F11 = table.Column<int>(nullable: true),
                    F12 = table.Column<double>(nullable: true),
                    F13 = table.Column<double>(nullable: true),
                    F14 = table.Column<double>(nullable: true),
                    F16 = table.Column<int>(nullable: true),
                    F17 = table.Column<int>(nullable: true),
                    F18 = table.Column<int>(nullable: true),
                    F21 = table.Column<double>(nullable: true),
                    F22 = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    F23 = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    F29 = table.Column<string>(unicode: false, maxLength: 60, nullable: true),
                    F93 = table.Column<string>(unicode: false, maxLength: 16, nullable: true),
                    F155 = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    F180 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    F193 = table.Column<string>(unicode: false, maxLength: 16, nullable: true),
                    F213 = table.Column<string>(unicode: false, maxLength: 13, nullable: true),
                    F214 = table.Column<string>(unicode: false, maxLength: 13, nullable: true),
                    F215 = table.Column<int>(nullable: true),
                    F218 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F255 = table.Column<string>(unicode: false, maxLength: 120, nullable: true),
                    F270 = table.Column<double>(nullable: true),
                    F940 = table.Column<int>(nullable: true),
                    F941 = table.Column<int>(nullable: true),
                    F1000 = table.Column<string>(unicode: false, maxLength: 5, nullable: true),
                    F1001 = table.Column<int>(nullable: true),
                    F1002 = table.Column<double>(nullable: true),
                    F1004 = table.Column<int>(nullable: true),
                    F1118 = table.Column<string>(unicode: false, maxLength: 9, nullable: true),
                    F1119 = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    F1168 = table.Column<int>(nullable: true),
                    F1699 = table.Column<double>(nullable: true),
                    F1736 = table.Column<int>(nullable: true),
                    F1737 = table.Column<string>(unicode: false, maxLength: 13, nullable: true),
                    F1738 = table.Column<string>(unicode: false, maxLength: 13, nullable: true),
                    F1744 = table.Column<double>(nullable: true),
                    F1781 = table.Column<string>(unicode: false, maxLength: 12, nullable: true),
                    F1782 = table.Column<string>(unicode: false, maxLength: 12, nullable: true),
                    F1783 = table.Column<int>(nullable: true),
                    F1784 = table.Column<int>(nullable: true),
                    F1939 = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    F1940 = table.Column<string>(unicode: false, maxLength: 60, nullable: true),
                    F1941 = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    F1942 = table.Column<string>(unicode: false, maxLength: 120, nullable: true),
                    F1957 = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    F1958 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    F1959 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    F1960 = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    F1962 = table.Column<string>(unicode: false, maxLength: 600, nullable: true),
                    F1964 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F2600 = table.Column<string>(unicode: false, maxLength: 2, nullable: true),
                    F2693 = table.Column<string>(unicode: false, maxLength: 13, nullable: true),
                    F2789 = table.Column<string>(unicode: false, maxLength: 13, nullable: true),
                    F2931 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("FOBJ_BAT_P01", x => new { x.F01, x.F902 });
                });

            migrationBuilder.CreateTable(
                name: "FPID_BAT",
                columns: table => new
                {
                    F01 = table.Column<string>(unicode: false, maxLength: 13, nullable: false),
                    F902 = table.Column<string>(unicode: false, maxLength: 8, nullable: false),
                    F1000 = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    F383 = table.Column<string>(unicode: false, maxLength: 80, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("FPID_BAT_P01", x => new { x.F01, x.F902, x.F1000, x.F383 });
                });

            migrationBuilder.CreateTable(
                name: "FPOS_BAT",
                columns: table => new
                {
                    F01 = table.Column<string>(unicode: false, maxLength: 13, nullable: false),
                    F902 = table.Column<string>(unicode: false, maxLength: 8, nullable: false),
                    F1000 = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    F02 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F03 = table.Column<int>(nullable: true),
                    F04 = table.Column<int>(nullable: true),
                    F05 = table.Column<int>(nullable: true),
                    F06 = table.Column<int>(nullable: true),
                    F07 = table.Column<int>(nullable: true),
                    F08 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F09 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F24 = table.Column<double>(nullable: true),
                    F40 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F50 = table.Column<decimal>(type: "money", nullable: true),
                    F60 = table.Column<decimal>(type: "money", nullable: true),
                    F61 = table.Column<decimal>(type: "money", nullable: true),
                    F66 = table.Column<int>(nullable: true),
                    F77 = table.Column<int>(nullable: true),
                    F78 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F79 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F80 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F81 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F82 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F83 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F84 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F85 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F86 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F87 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F88 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F92 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F96 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F97 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F98 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F99 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F100 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F101 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F102 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F104 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F106 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F107 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F108 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F110 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F114 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F115 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F121 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F123 = table.Column<string>(unicode: false, maxLength: 13, nullable: true),
                    F124 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F125 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F141 = table.Column<double>(nullable: true),
                    F149 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F150 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F153 = table.Column<int>(nullable: true),
                    F158 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F159 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F160 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F161 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F162 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F163 = table.Column<int>(nullable: true),
                    F170 = table.Column<int>(nullable: true),
                    F171 = table.Column<int>(nullable: true),
                    F172 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F173 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F174 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F176 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F178 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F188 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F189 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F209 = table.Column<double>(nullable: true),
                    F210 = table.Column<decimal>(type: "money", nullable: true),
                    F211 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F217 = table.Column<double>(nullable: true),
                    F302 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F303 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F304 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F306 = table.Column<double>(nullable: true),
                    F383 = table.Column<string>(unicode: false, maxLength: 80, nullable: true),
                    F388 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F397 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F1001 = table.Column<int>(nullable: true),
                    F1099 = table.Column<int>(nullable: true),
                    F1120 = table.Column<string>(unicode: false, maxLength: 12, nullable: true),
                    F1124 = table.Column<double>(nullable: true),
                    F1136 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F1138 = table.Column<double>(nullable: true),
                    F1139 = table.Column<int>(nullable: true),
                    F1236 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F1237 = table.Column<double>(nullable: true),
                    F1735 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F1785 = table.Column<string>(unicode: false, maxLength: 12, nullable: true),
                    F1786 = table.Column<string>(unicode: false, maxLength: 12, nullable: true),
                    F1787 = table.Column<int>(nullable: true),
                    F1788 = table.Column<int>(nullable: true),
                    F1789 = table.Column<double>(nullable: true),
                    F1790 = table.Column<double>(nullable: true),
                    F1892 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F1926 = table.Column<double>(nullable: true),
                    F1929 = table.Column<int>(nullable: true),
                    F1933 = table.Column<decimal>(type: "money", nullable: true),
                    F1964 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F2608 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F2660 = table.Column<string>(unicode: false, maxLength: 250, nullable: true),
                    F2930 = table.Column<string>(unicode: false, maxLength: 13, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("FPOS_BAT_P01", x => new { x.F01, x.F902, x.F1000 });
                });

            migrationBuilder.CreateTable(
                name: "FPRICE_BAT",
                columns: table => new
                {
                    F01 = table.Column<string>(unicode: false, maxLength: 13, nullable: false),
                    F902 = table.Column<string>(unicode: false, maxLength: 8, nullable: false),
                    F1000 = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    F126 = table.Column<int>(nullable: false),
                    F07 = table.Column<int>(nullable: true),
                    F30 = table.Column<decimal>(type: "money", nullable: true),
                    F31 = table.Column<double>(nullable: true),
                    F32 = table.Column<int>(nullable: true),
                    F33 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F34 = table.Column<string>(unicode: false, maxLength: 2, nullable: true),
                    F35 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F36 = table.Column<string>(unicode: false, maxLength: 6, nullable: true),
                    F37 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F49 = table.Column<double>(nullable: true),
                    F62 = table.Column<double>(nullable: true),
                    F63 = table.Column<decimal>(type: "money", nullable: true),
                    F111 = table.Column<decimal>(type: "money", nullable: true),
                    F112 = table.Column<double>(nullable: true),
                    F129 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F130 = table.Column<string>(unicode: false, maxLength: 6, nullable: true),
                    F133 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F140 = table.Column<decimal>(type: "money", nullable: true),
                    F142 = table.Column<double>(nullable: true),
                    F168 = table.Column<decimal>(type: "money", nullable: true),
                    F169 = table.Column<int>(nullable: true),
                    F205 = table.Column<decimal>(type: "money", nullable: true),
                    F1001 = table.Column<int>(nullable: true),
                    F1005 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F1713 = table.Column<double>(nullable: true),
                    F1714 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F1767 = table.Column<double>(nullable: true),
                    F1768 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F1769 = table.Column<double>(nullable: true),
                    F1770 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F1927 = table.Column<double>(nullable: true),
                    F1934 = table.Column<decimal>(type: "money", nullable: true),
                    F1964 = table.Column<string>(unicode: false, maxLength: 4, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("FPRICE_BAT_P01", x => new { x.F01, x.F902, x.F1000, x.F126 });
                });

            migrationBuilder.CreateTable(
                name: "FREDEEM_BAT",
                columns: table => new
                {
                    F01 = table.Column<string>(unicode: false, maxLength: 13, nullable: false),
                    F902 = table.Column<string>(unicode: false, maxLength: 8, nullable: false),
                    F1000 = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    F126 = table.Column<int>(nullable: false),
                    F07 = table.Column<int>(nullable: true),
                    F1001 = table.Column<int>(nullable: true),
                    F1228 = table.Column<int>(nullable: true),
                    F1229 = table.Column<decimal>(type: "money", nullable: true),
                    F1232 = table.Column<int>(nullable: true),
                    F1234 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F1235 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F2744 = table.Column<string>(unicode: false, maxLength: 4, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("FREDEEM_BAT_P01", x => new { x.F01, x.F902, x.F1000, x.F126 });
                });

            migrationBuilder.CreateTable(
                name: "FSPRICE_BAT",
                columns: table => new
                {
                    F01 = table.Column<string>(unicode: false, maxLength: 13, nullable: false),
                    F902 = table.Column<string>(unicode: false, maxLength: 8, nullable: false),
                    F1000 = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    F126 = table.Column<int>(nullable: false),
                    F07 = table.Column<int>(nullable: true),
                    F34 = table.Column<string>(unicode: false, maxLength: 2, nullable: true),
                    F37 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F42 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F135 = table.Column<double>(nullable: true),
                    F136 = table.Column<decimal>(type: "money", nullable: true),
                    F137 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F138 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F139 = table.Column<decimal>(type: "money", nullable: true),
                    F143 = table.Column<double>(nullable: true),
                    F144 = table.Column<string>(unicode: false, maxLength: 6, nullable: true),
                    F145 = table.Column<string>(unicode: false, maxLength: 6, nullable: true),
                    F146 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F147 = table.Column<double>(nullable: true),
                    F148 = table.Column<decimal>(type: "money", nullable: true),
                    F179 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F232 = table.Column<double>(nullable: true),
                    F1001 = table.Column<int>(nullable: true),
                    F1192 = table.Column<int>(nullable: true),
                    F1193 = table.Column<int>(nullable: true),
                    F1220 = table.Column<decimal>(type: "money", nullable: true),
                    F1221 = table.Column<double>(nullable: true),
                    F1801 = table.Column<int>(nullable: true),
                    F1865 = table.Column<double>(nullable: true),
                    F1866 = table.Column<double>(nullable: true),
                    F1867 = table.Column<double>(nullable: true),
                    F1955 = table.Column<decimal>(type: "money", nullable: true),
                    F1956 = table.Column<decimal>(type: "money", nullable: true),
                    F2668 = table.Column<string>(unicode: false, maxLength: 12, nullable: true),
                    F2955 = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("FSPRICE_BAT_P01", x => new { x.F01, x.F902, x.F1000, x.F126 });
                });

            migrationBuilder.CreateTable(
                name: "FTPRICE_BAT",
                columns: table => new
                {
                    F01 = table.Column<string>(unicode: false, maxLength: 13, nullable: false),
                    F902 = table.Column<string>(unicode: false, maxLength: 8, nullable: false),
                    F1000 = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    F126 = table.Column<int>(nullable: false),
                    F07 = table.Column<int>(nullable: true),
                    F34 = table.Column<string>(unicode: false, maxLength: 2, nullable: true),
                    F37 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F181 = table.Column<decimal>(type: "money", nullable: true),
                    F182 = table.Column<double>(nullable: true),
                    F183 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F184 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F221 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F1001 = table.Column<int>(nullable: true),
                    F1186 = table.Column<decimal>(type: "money", nullable: true),
                    F1187 = table.Column<double>(nullable: true),
                    F1188 = table.Column<decimal>(type: "money", nullable: true),
                    F1189 = table.Column<double>(nullable: true),
                    F1190 = table.Column<int>(nullable: true),
                    F1191 = table.Column<int>(nullable: true),
                    F1218 = table.Column<decimal>(type: "money", nullable: true),
                    F1219 = table.Column<double>(nullable: true),
                    F1868 = table.Column<double>(nullable: true),
                    F1869 = table.Column<double>(nullable: true),
                    F1870 = table.Column<double>(nullable: true),
                    F1953 = table.Column<decimal>(type: "money", nullable: true),
                    F1954 = table.Column<decimal>(type: "money", nullable: true),
                    F2667 = table.Column<string>(unicode: false, maxLength: 12, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("FTPRICE_BAT_P01", x => new { x.F01, x.F902, x.F1000, x.F126 });
                });

            migrationBuilder.CreateTable(
                name: "HEADER_BAT",
                columns: table => new
                {
                    F902 = table.Column<string>(unicode: false, maxLength: 8, nullable: false),
                    F903 = table.Column<string>(unicode: false, maxLength: 16, nullable: false),
                    F901 = table.Column<string>(unicode: false, maxLength: 2, nullable: true),
                    F904 = table.Column<string>(unicode: false, maxLength: 6, nullable: true),
                    F905 = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    F906 = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    F907 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F908 = table.Column<string>(unicode: false, maxLength: 6, nullable: true),
                    F909 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F910 = table.Column<string>(unicode: false, maxLength: 6, nullable: true),
                    F911 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F912 = table.Column<string>(unicode: false, maxLength: 6, nullable: true),
                    F913 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F914 = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    F915 = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    F916 = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    F917 = table.Column<int>(nullable: true),
                    F918 = table.Column<int>(nullable: true),
                    F919 = table.Column<string>(unicode: false, maxLength: 7, nullable: true),
                    F920 = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    F921 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F922 = table.Column<string>(unicode: false, maxLength: 128, nullable: true),
                    F930 = table.Column<string>(unicode: false, maxLength: 80, nullable: true),
                    F931 = table.Column<int>(nullable: true),
                    F932 = table.Column<string>(unicode: false, maxLength: 250, nullable: true),
                    F1000 = table.Column<string>(unicode: false, maxLength: 5, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("HEADER_BAT_P902", x => new { x.F902, x.F903 });
                });

            migrationBuilder.CreateTable(
                name: "HEADER_DCT",
                columns: table => new
                {
                    F902 = table.Column<string>(unicode: false, maxLength: 8, nullable: false),
                    F903 = table.Column<string>(unicode: false, maxLength: 16, nullable: false),
                    F901 = table.Column<string>(unicode: false, maxLength: 2, nullable: true),
                    F904 = table.Column<string>(unicode: false, maxLength: 6, nullable: true),
                    F905 = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    F906 = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    F907 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F908 = table.Column<string>(unicode: false, maxLength: 6, nullable: true),
                    F909 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F910 = table.Column<string>(unicode: false, maxLength: 6, nullable: true),
                    F911 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F912 = table.Column<string>(unicode: false, maxLength: 6, nullable: true),
                    F913 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F914 = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    F915 = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    F916 = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    F917 = table.Column<int>(nullable: true),
                    F918 = table.Column<int>(nullable: true),
                    F919 = table.Column<string>(unicode: false, maxLength: 7, nullable: true),
                    F920 = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    F921 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F922 = table.Column<string>(unicode: false, maxLength: 128, nullable: true),
                    F930 = table.Column<string>(unicode: false, maxLength: 80, nullable: true),
                    F931 = table.Column<int>(nullable: true),
                    F932 = table.Column<string>(unicode: false, maxLength: 250, nullable: true),
                    F1000 = table.Column<string>(unicode: false, maxLength: 5, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("HEADER_DCT_P902", x => new { x.F902, x.F903 });
                });

            migrationBuilder.CreateTable(
                name: "HEADER_DEL",
                columns: table => new
                {
                    F902 = table.Column<string>(unicode: false, maxLength: 8, nullable: false),
                    F903 = table.Column<string>(unicode: false, maxLength: 16, nullable: false),
                    F901 = table.Column<string>(unicode: false, maxLength: 2, nullable: true),
                    F904 = table.Column<string>(unicode: false, maxLength: 6, nullable: true),
                    F905 = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    F906 = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    F907 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F908 = table.Column<string>(unicode: false, maxLength: 6, nullable: true),
                    F909 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F910 = table.Column<string>(unicode: false, maxLength: 6, nullable: true),
                    F911 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F912 = table.Column<string>(unicode: false, maxLength: 6, nullable: true),
                    F913 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F914 = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    F915 = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    F916 = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    F917 = table.Column<int>(nullable: true),
                    F918 = table.Column<int>(nullable: true),
                    F919 = table.Column<string>(unicode: false, maxLength: 7, nullable: true),
                    F920 = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    F921 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F922 = table.Column<string>(unicode: false, maxLength: 128, nullable: true),
                    F930 = table.Column<string>(unicode: false, maxLength: 80, nullable: true),
                    F931 = table.Column<int>(nullable: true),
                    F932 = table.Column<string>(unicode: false, maxLength: 250, nullable: true),
                    F1000 = table.Column<string>(unicode: false, maxLength: 5, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("HEADER_DEL_P902", x => new { x.F902, x.F903 });
                });

            migrationBuilder.CreateTable(
                name: "HEADER_EXE",
                columns: table => new
                {
                    F902 = table.Column<string>(unicode: false, maxLength: 8, nullable: false),
                    F903 = table.Column<string>(unicode: false, maxLength: 16, nullable: false),
                    F901 = table.Column<string>(unicode: false, maxLength: 2, nullable: true),
                    F904 = table.Column<string>(unicode: false, maxLength: 6, nullable: true),
                    F905 = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    F906 = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    F907 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F908 = table.Column<string>(unicode: false, maxLength: 6, nullable: true),
                    F909 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F910 = table.Column<string>(unicode: false, maxLength: 6, nullable: true),
                    F911 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F912 = table.Column<string>(unicode: false, maxLength: 6, nullable: true),
                    F913 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F914 = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    F915 = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    F916 = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    F917 = table.Column<int>(nullable: true),
                    F918 = table.Column<int>(nullable: true),
                    F919 = table.Column<string>(unicode: false, maxLength: 7, nullable: true),
                    F920 = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    F921 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F922 = table.Column<string>(unicode: false, maxLength: 128, nullable: true),
                    F930 = table.Column<string>(unicode: false, maxLength: 80, nullable: true),
                    F931 = table.Column<int>(nullable: true),
                    F932 = table.Column<string>(unicode: false, maxLength: 250, nullable: true),
                    F1000 = table.Column<string>(unicode: false, maxLength: 5, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("HEADER_EXE_P902", x => new { x.F902, x.F903 });
                });

            migrationBuilder.CreateTable(
                name: "HEADER_INS",
                columns: table => new
                {
                    F902 = table.Column<string>(unicode: false, maxLength: 8, nullable: false),
                    F903 = table.Column<string>(unicode: false, maxLength: 16, nullable: false),
                    F901 = table.Column<string>(unicode: false, maxLength: 2, nullable: true),
                    F904 = table.Column<string>(unicode: false, maxLength: 6, nullable: true),
                    F905 = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    F906 = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    F907 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F908 = table.Column<string>(unicode: false, maxLength: 6, nullable: true),
                    F909 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F910 = table.Column<string>(unicode: false, maxLength: 6, nullable: true),
                    F911 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F912 = table.Column<string>(unicode: false, maxLength: 6, nullable: true),
                    F913 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F914 = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    F915 = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    F916 = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    F917 = table.Column<int>(nullable: true),
                    F918 = table.Column<int>(nullable: true),
                    F919 = table.Column<string>(unicode: false, maxLength: 7, nullable: true),
                    F920 = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    F921 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F922 = table.Column<string>(unicode: false, maxLength: 128, nullable: true),
                    F930 = table.Column<string>(unicode: false, maxLength: 80, nullable: true),
                    F931 = table.Column<int>(nullable: true),
                    F932 = table.Column<string>(unicode: false, maxLength: 250, nullable: true),
                    F1000 = table.Column<string>(unicode: false, maxLength: 5, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("HEADER_INS_P902", x => new { x.F902, x.F903 });
                });

            migrationBuilder.CreateTable(
                name: "HEADER_OLD",
                columns: table => new
                {
                    F902 = table.Column<string>(unicode: false, maxLength: 8, nullable: false),
                    F903 = table.Column<string>(unicode: false, maxLength: 16, nullable: false),
                    F901 = table.Column<string>(unicode: false, maxLength: 2, nullable: true),
                    F904 = table.Column<string>(unicode: false, maxLength: 6, nullable: true),
                    F905 = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    F906 = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    F907 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F908 = table.Column<string>(unicode: false, maxLength: 6, nullable: true),
                    F909 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F910 = table.Column<string>(unicode: false, maxLength: 6, nullable: true),
                    F911 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F912 = table.Column<string>(unicode: false, maxLength: 6, nullable: true),
                    F913 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F914 = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    F915 = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    F916 = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    F917 = table.Column<int>(nullable: true),
                    F918 = table.Column<int>(nullable: true),
                    F919 = table.Column<string>(unicode: false, maxLength: 7, nullable: true),
                    F920 = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    F921 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F922 = table.Column<string>(unicode: false, maxLength: 128, nullable: true),
                    F930 = table.Column<string>(unicode: false, maxLength: 80, nullable: true),
                    F931 = table.Column<int>(nullable: true),
                    F932 = table.Column<string>(unicode: false, maxLength: 250, nullable: true),
                    F1000 = table.Column<string>(unicode: false, maxLength: 5, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("HEADER_OLD_P902", x => new { x.F902, x.F903 });
                });

            migrationBuilder.CreateTable(
                name: "HEADER_SAV",
                columns: table => new
                {
                    F902 = table.Column<string>(unicode: false, maxLength: 8, nullable: false),
                    F903 = table.Column<string>(unicode: false, maxLength: 16, nullable: false),
                    F901 = table.Column<string>(unicode: false, maxLength: 2, nullable: true),
                    F904 = table.Column<string>(unicode: false, maxLength: 6, nullable: true),
                    F905 = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    F906 = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    F907 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F908 = table.Column<string>(unicode: false, maxLength: 6, nullable: true),
                    F909 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F910 = table.Column<string>(unicode: false, maxLength: 6, nullable: true),
                    F911 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F912 = table.Column<string>(unicode: false, maxLength: 6, nullable: true),
                    F913 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F914 = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    F915 = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    F916 = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    F917 = table.Column<int>(nullable: true),
                    F918 = table.Column<int>(nullable: true),
                    F919 = table.Column<string>(unicode: false, maxLength: 7, nullable: true),
                    F920 = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    F921 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F922 = table.Column<string>(unicode: false, maxLength: 128, nullable: true),
                    F930 = table.Column<string>(unicode: false, maxLength: 80, nullable: true),
                    F931 = table.Column<int>(nullable: true),
                    F932 = table.Column<string>(unicode: false, maxLength: 250, nullable: true),
                    F1000 = table.Column<string>(unicode: false, maxLength: 5, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("HEADER_SAV_P902", x => new { x.F902, x.F903 });
                });

            migrationBuilder.CreateTable(
                name: "HOOK_TAB",
                columns: table => new
                {
                    F1700 = table.Column<string>(unicode: false, maxLength: 10, nullable: false),
                    F1701 = table.Column<string>(unicode: false, maxLength: 10, nullable: false),
                    F1702 = table.Column<string>(unicode: false, maxLength: 10, nullable: false),
                    F1703 = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
                    F1704 = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
                    F1705 = table.Column<string>(unicode: false, maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("HOOK_TAB_P1700", x => new { x.F1700, x.F1701, x.F1702, x.F1703, x.F1704, x.F1705 });
                });

            migrationBuilder.CreateTable(
                name: "INV_BAT",
                columns: table => new
                {
                    F1032 = table.Column<int>(nullable: false),
                    F04 = table.Column<int>(nullable: true),
                    F17 = table.Column<int>(nullable: true),
                    F27 = table.Column<string>(unicode: false, maxLength: 14, nullable: true),
                    F253 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F254 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F902 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F1035 = table.Column<string>(unicode: false, maxLength: 6, nullable: true),
                    F1036 = table.Column<string>(unicode: false, maxLength: 6, nullable: true),
                    F1056 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F1057 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F1067 = table.Column<string>(unicode: false, maxLength: 7, nullable: true),
                    F1068 = table.Column<string>(unicode: false, maxLength: 6, nullable: true),
                    F1101 = table.Column<int>(nullable: true),
                    F1126 = table.Column<int>(nullable: true),
                    F1127 = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    F1245 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    F1254 = table.Column<string>(unicode: false, maxLength: 5000, nullable: true),
                    F1255 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F1264 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F1687 = table.Column<int>(nullable: true),
                    F1688 = table.Column<int>(nullable: true),
                    F1689 = table.Column<int>(nullable: true),
                    F2641 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F2642 = table.Column<int>(nullable: true),
                    F2643 = table.Column<decimal>(type: "money", nullable: true),
                    F2644 = table.Column<int>(nullable: true),
                    F2645 = table.Column<decimal>(type: "money", nullable: true),
                    F2646 = table.Column<double>(nullable: true),
                    F2647 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F2848 = table.Column<string>(unicode: false, maxLength: 5000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("INV_BAT_P1032", x => x.F1032);
                });

            migrationBuilder.CreateTable(
                name: "INV_HDR",
                columns: table => new
                {
                    F1032 = table.Column<int>(nullable: false),
                    F04 = table.Column<int>(nullable: true),
                    F17 = table.Column<int>(nullable: true),
                    F27 = table.Column<string>(unicode: false, maxLength: 14, nullable: true),
                    F253 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F254 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F902 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F1035 = table.Column<string>(unicode: false, maxLength: 6, nullable: true),
                    F1036 = table.Column<string>(unicode: false, maxLength: 6, nullable: true),
                    F1056 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F1057 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F1067 = table.Column<string>(unicode: false, maxLength: 7, nullable: true),
                    F1068 = table.Column<string>(unicode: false, maxLength: 6, nullable: true),
                    F1101 = table.Column<int>(nullable: true),
                    F1126 = table.Column<int>(nullable: true),
                    F1127 = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    F1245 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    F1254 = table.Column<string>(unicode: false, maxLength: 5000, nullable: true),
                    F1255 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F1264 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F1687 = table.Column<int>(nullable: true),
                    F1688 = table.Column<int>(nullable: true),
                    F1689 = table.Column<int>(nullable: true),
                    F2641 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F2642 = table.Column<int>(nullable: true),
                    F2643 = table.Column<decimal>(type: "money", nullable: true),
                    F2644 = table.Column<int>(nullable: true),
                    F2645 = table.Column<decimal>(type: "money", nullable: true),
                    F2646 = table.Column<double>(nullable: true),
                    F2647 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F2848 = table.Column<string>(unicode: false, maxLength: 5000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("INV_HDR_P1032", x => x.F1032);
                });

            migrationBuilder.CreateTable(
                name: "INV_REG",
                columns: table => new
                {
                    F1032 = table.Column<int>(nullable: false),
                    F1101 = table.Column<int>(nullable: false),
                    F01 = table.Column<string>(unicode: false, maxLength: 13, nullable: true),
                    F03 = table.Column<int>(nullable: true),
                    F04 = table.Column<int>(nullable: true),
                    F05 = table.Column<int>(nullable: true),
                    F19 = table.Column<double>(nullable: true),
                    F26 = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    F27 = table.Column<string>(unicode: false, maxLength: 14, nullable: true),
                    F30 = table.Column<decimal>(type: "money", nullable: true),
                    F31 = table.Column<double>(nullable: true),
                    F38 = table.Column<decimal>(type: "money", nullable: true),
                    F64 = table.Column<double>(nullable: true),
                    F65 = table.Column<decimal>(type: "money", nullable: true),
                    F67 = table.Column<double>(nullable: true),
                    F70 = table.Column<double>(nullable: true),
                    F82 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F131 = table.Column<int>(nullable: true),
                    F151 = table.Column<decimal>(type: "money", nullable: true),
                    F195 = table.Column<decimal>(type: "money", nullable: true),
                    F196 = table.Column<decimal>(type: "money", nullable: true),
                    F253 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F254 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F270 = table.Column<double>(nullable: true),
                    F1003 = table.Column<double>(nullable: true),
                    F1006 = table.Column<double>(nullable: true),
                    F1007 = table.Column<decimal>(type: "money", nullable: true),
                    F1034 = table.Column<int>(nullable: true),
                    F1035 = table.Column<string>(unicode: false, maxLength: 6, nullable: true),
                    F1036 = table.Column<string>(unicode: false, maxLength: 6, nullable: true),
                    F1041 = table.Column<string>(unicode: false, maxLength: 60, nullable: true),
                    F1056 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F1063 = table.Column<int>(nullable: true),
                    F1067 = table.Column<string>(unicode: false, maxLength: 7, nullable: true),
                    F1068 = table.Column<string>(unicode: false, maxLength: 6, nullable: true),
                    F1072 = table.Column<int>(nullable: true),
                    F1079 = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    F1081 = table.Column<string>(unicode: false, maxLength: 5000, nullable: true),
                    F1140 = table.Column<decimal>(type: "money", nullable: true),
                    F1184 = table.Column<string>(unicode: false, maxLength: 12, nullable: true),
                    F1690 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F1691 = table.Column<string>(unicode: false, maxLength: 250, nullable: true),
                    F1694 = table.Column<int>(nullable: true),
                    F1706 = table.Column<double>(nullable: true),
                    F1707 = table.Column<decimal>(type: "money", nullable: true),
                    F1708 = table.Column<decimal>(type: "money", nullable: true),
                    F1813 = table.Column<decimal>(type: "money", nullable: true),
                    F1814 = table.Column<int>(nullable: true),
                    F1875 = table.Column<string>(unicode: false, maxLength: 2, nullable: true),
                    F2638 = table.Column<int>(nullable: true),
                    F2639 = table.Column<double>(nullable: true),
                    F2640 = table.Column<decimal>(type: "money", nullable: true),
                    F2641 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F2642 = table.Column<int>(nullable: true),
                    F2643 = table.Column<decimal>(type: "money", nullable: true),
                    F2660 = table.Column<string>(unicode: false, maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("INV_REG_P1032", x => new { x.F1032, x.F1101 });
                });

            migrationBuilder.CreateTable(
                name: "INV_TTL",
                columns: table => new
                {
                    F1032 = table.Column<int>(nullable: false),
                    F1034 = table.Column<int>(nullable: false),
                    F64 = table.Column<double>(nullable: true),
                    F65 = table.Column<decimal>(type: "money", nullable: true),
                    F67 = table.Column<double>(nullable: true),
                    F1039 = table.Column<string>(unicode: false, maxLength: 60, nullable: true),
                    F1067 = table.Column<string>(unicode: false, maxLength: 7, nullable: true),
                    F1093 = table.Column<decimal>(type: "money", nullable: true),
                    F1094 = table.Column<decimal>(type: "money", nullable: true),
                    F1095 = table.Column<decimal>(type: "money", nullable: true),
                    F1096 = table.Column<decimal>(type: "money", nullable: true),
                    F1097 = table.Column<decimal>(type: "money", nullable: true),
                    F1098 = table.Column<decimal>(type: "money", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("INV_TTL_P1032", x => new { x.F1032, x.F1034 });
                });

            migrationBuilder.CreateTable(
                name: "ITD_DEL",
                columns: table => new
                {
                    F01 = table.Column<string>(unicode: false, maxLength: 13, nullable: false),
                    F2834 = table.Column<string>(unicode: false, maxLength: 8, nullable: false),
                    F1000 = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    F253 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F902 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F940 = table.Column<int>(nullable: true),
                    F941 = table.Column<int>(nullable: true),
                    F1001 = table.Column<int>(nullable: true),
                    F2835 = table.Column<string>(unicode: false, maxLength: 8000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ITD_DEL_P01", x => new { x.F01, x.F2834, x.F1000 });
                });

            migrationBuilder.CreateTable(
                name: "ITD_TAB",
                columns: table => new
                {
                    F01 = table.Column<string>(unicode: false, maxLength: 13, nullable: false),
                    F2834 = table.Column<string>(unicode: false, maxLength: 8, nullable: false),
                    F1000 = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    F253 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F902 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F940 = table.Column<int>(nullable: true),
                    F941 = table.Column<int>(nullable: true),
                    F1001 = table.Column<int>(nullable: true),
                    F2835 = table.Column<string>(unicode: false, maxLength: 8000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ITD_TAB_P01", x => new { x.F01, x.F2834, x.F1000 });
                });

            migrationBuilder.CreateTable(
                name: "ITZ_DEL",
                columns: table => new
                {
                    F01 = table.Column<string>(unicode: false, maxLength: 13, nullable: false),
                    F1034 = table.Column<int>(nullable: false),
                    F1000 = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    F253 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F902 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F940 = table.Column<int>(nullable: true),
                    F941 = table.Column<int>(nullable: true),
                    F1001 = table.Column<int>(nullable: true),
                    F2823 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F2824 = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ITZ_DEL_P01", x => new { x.F01, x.F1034, x.F1000 });
                });

            migrationBuilder.CreateTable(
                name: "ITZ_TAB",
                columns: table => new
                {
                    F01 = table.Column<string>(unicode: false, maxLength: 13, nullable: false),
                    F1034 = table.Column<int>(nullable: false),
                    F1000 = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    F253 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F902 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F940 = table.Column<int>(nullable: true),
                    F941 = table.Column<int>(nullable: true),
                    F1001 = table.Column<int>(nullable: true),
                    F2823 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F2824 = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ITZ_TAB_P01", x => new { x.F01, x.F1034, x.F1000 });
                });

            migrationBuilder.CreateTable(
                name: "KIT_DEL",
                columns: table => new
                {
                    F01 = table.Column<string>(unicode: false, maxLength: 13, nullable: false),
                    F126 = table.Column<int>(nullable: false),
                    F1507 = table.Column<string>(unicode: false, maxLength: 13, nullable: false),
                    F902 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F1001 = table.Column<int>(nullable: true),
                    F07 = table.Column<int>(nullable: true),
                    F253 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F1508 = table.Column<double>(nullable: true),
                    F1509 = table.Column<string>(unicode: false, maxLength: 2, nullable: true),
                    F1510 = table.Column<double>(nullable: true),
                    F1759 = table.Column<int>(nullable: true),
                    F1964 = table.Column<string>(unicode: false, maxLength: 4, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("KIT_DEL_P01", x => new { x.F01, x.F126, x.F1507 });
                });

            migrationBuilder.CreateTable(
                name: "KIT_TAB",
                columns: table => new
                {
                    F01 = table.Column<string>(unicode: false, maxLength: 13, nullable: false),
                    F126 = table.Column<int>(nullable: false),
                    F1507 = table.Column<string>(unicode: false, maxLength: 13, nullable: false),
                    F902 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F1001 = table.Column<int>(nullable: true),
                    F07 = table.Column<int>(nullable: true),
                    F253 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F1508 = table.Column<double>(nullable: true),
                    F1509 = table.Column<string>(unicode: false, maxLength: 2, nullable: true),
                    F1510 = table.Column<double>(nullable: true),
                    F1759 = table.Column<int>(nullable: true),
                    F1964 = table.Column<string>(unicode: false, maxLength: 4, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("KIT_TAB_P01", x => new { x.F01, x.F126, x.F1507 });
                });

            migrationBuilder.CreateTable(
                name: "LABEL_TAB",
                columns: table => new
                {
                    F1148 = table.Column<string>(unicode: false, maxLength: 14, nullable: false),
                    F95 = table.Column<string>(unicode: false, maxLength: 80, nullable: false),
                    F01 = table.Column<string>(unicode: false, maxLength: 13, nullable: false),
                    F126 = table.Column<int>(nullable: false),
                    F02 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F04 = table.Column<int>(nullable: true),
                    F05 = table.Column<int>(nullable: true),
                    F08 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F16 = table.Column<int>(nullable: true),
                    F17 = table.Column<int>(nullable: true),
                    F18 = table.Column<int>(nullable: true),
                    F19 = table.Column<double>(nullable: true),
                    F21 = table.Column<double>(nullable: true),
                    F22 = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    F23 = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    F24 = table.Column<double>(nullable: true),
                    F25 = table.Column<string>(unicode: false, maxLength: 16, nullable: true),
                    F26 = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    F27 = table.Column<string>(unicode: false, maxLength: 14, nullable: true),
                    F29 = table.Column<string>(unicode: false, maxLength: 60, nullable: true),
                    F30 = table.Column<decimal>(type: "money", nullable: true),
                    F31 = table.Column<double>(nullable: true),
                    F32 = table.Column<int>(nullable: true),
                    F33 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F35 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F36 = table.Column<string>(unicode: false, maxLength: 6, nullable: true),
                    F38 = table.Column<decimal>(type: "money", nullable: true),
                    F62 = table.Column<double>(nullable: true),
                    F63 = table.Column<decimal>(type: "money", nullable: true),
                    F81 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F82 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F94 = table.Column<int>(nullable: true),
                    F96 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F97 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F98 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F105 = table.Column<int>(nullable: true),
                    F111 = table.Column<decimal>(type: "money", nullable: true),
                    F112 = table.Column<double>(nullable: true),
                    F113 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F117 = table.Column<string>(unicode: false, maxLength: 16, nullable: true),
                    F129 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F130 = table.Column<string>(unicode: false, maxLength: 6, nullable: true),
                    F140 = table.Column<decimal>(type: "money", nullable: true),
                    F142 = table.Column<double>(nullable: true),
                    F154 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    F155 = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    F164 = table.Column<string>(unicode: false, maxLength: 13, nullable: true),
                    F166 = table.Column<decimal>(type: "money", nullable: true),
                    F167 = table.Column<double>(nullable: true),
                    F168 = table.Column<decimal>(type: "money", nullable: true),
                    F169 = table.Column<int>(nullable: true),
                    F253 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F255 = table.Column<string>(unicode: false, maxLength: 120, nullable: true),
                    F902 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F903 = table.Column<string>(unicode: false, maxLength: 16, nullable: true),
                    F1030 = table.Column<double>(nullable: true),
                    F1184 = table.Column<string>(unicode: false, maxLength: 12, nullable: true),
                    F1185 = table.Column<int>(nullable: true),
                    F1301 = table.Column<double>(nullable: true),
                    F1302 = table.Column<double>(nullable: true),
                    F1401 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F1402 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F1744 = table.Column<double>(nullable: true),
                    F1806 = table.Column<decimal>(type: "money", nullable: true),
                    F2588 = table.Column<string>(unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("LABEL_TAB_P1148", x => new { x.F1148, x.F95, x.F01, x.F126 });
                });

            migrationBuilder.CreateTable(
                name: "LABEL_TPL",
                columns: table => new
                {
                    F2783 = table.Column<string>(unicode: false, maxLength: 80, nullable: false),
                    F113 = table.Column<string>(unicode: false, maxLength: 8, nullable: false),
                    F95 = table.Column<string>(unicode: false, maxLength: 80, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("LABEL_TPL_P2783", x => new { x.F2783, x.F113 });
                });

            migrationBuilder.CreateTable(
                name: "LIKE_TAB",
                columns: table => new
                {
                    F122 = table.Column<string>(unicode: false, maxLength: 13, nullable: false),
                    F2790 = table.Column<string>(unicode: false, maxLength: 60, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("LIKE_TAB_P122", x => x.F122);
                });

            migrationBuilder.CreateTable(
                name: "LNK_TAB",
                columns: table => new
                {
                    F1000 = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    F1056 = table.Column<string>(unicode: false, maxLength: 4, nullable: false),
                    F1057 = table.Column<string>(unicode: false, maxLength: 4, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("LNK_TAB_P1000", x => new { x.F1000, x.F1056, x.F1057 });
                });

            migrationBuilder.CreateTable(
                name: "LOC_DEL",
                columns: table => new
                {
                    F01 = table.Column<string>(unicode: false, maxLength: 13, nullable: false),
                    F1000 = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    F117 = table.Column<string>(unicode: false, maxLength: 16, nullable: false),
                    F902 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F1001 = table.Column<int>(nullable: true),
                    F07 = table.Column<int>(nullable: true),
                    F25 = table.Column<string>(unicode: false, maxLength: 16, nullable: true),
                    F94 = table.Column<int>(nullable: true),
                    F95 = table.Column<string>(unicode: false, maxLength: 80, nullable: true),
                    F105 = table.Column<int>(nullable: true),
                    F116 = table.Column<string>(unicode: false, maxLength: 16, nullable: true),
                    F118 = table.Column<string>(unicode: false, maxLength: 16, nullable: true),
                    F157 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F187 = table.Column<string>(unicode: false, maxLength: 16, nullable: true),
                    F190 = table.Column<string>(unicode: false, maxLength: 16, nullable: true),
                    F191 = table.Column<int>(nullable: true),
                    F192 = table.Column<int>(nullable: true),
                    F253 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F1029 = table.Column<int>(nullable: true),
                    F1030 = table.Column<double>(nullable: true),
                    F1759 = table.Column<int>(nullable: true),
                    F1963 = table.Column<string>(unicode: false, maxLength: 2, nullable: true),
                    F1964 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F2851 = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("LOC_DEL_P01", x => new { x.F01, x.F1000, x.F117 });
                });

            migrationBuilder.CreateTable(
                name: "LOC_TAB",
                columns: table => new
                {
                    F01 = table.Column<string>(unicode: false, maxLength: 13, nullable: false),
                    F1000 = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    F117 = table.Column<string>(unicode: false, maxLength: 16, nullable: false),
                    F902 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F1001 = table.Column<int>(nullable: true),
                    F07 = table.Column<int>(nullable: true),
                    F25 = table.Column<string>(unicode: false, maxLength: 16, nullable: true),
                    F94 = table.Column<int>(nullable: true),
                    F95 = table.Column<string>(unicode: false, maxLength: 80, nullable: true),
                    F105 = table.Column<int>(nullable: true),
                    F116 = table.Column<string>(unicode: false, maxLength: 16, nullable: true),
                    F118 = table.Column<string>(unicode: false, maxLength: 16, nullable: true),
                    F157 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F187 = table.Column<string>(unicode: false, maxLength: 16, nullable: true),
                    F190 = table.Column<string>(unicode: false, maxLength: 16, nullable: true),
                    F191 = table.Column<int>(nullable: true),
                    F192 = table.Column<int>(nullable: true),
                    F253 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F1029 = table.Column<int>(nullable: true),
                    F1030 = table.Column<double>(nullable: true),
                    F1759 = table.Column<int>(nullable: true),
                    F1963 = table.Column<string>(unicode: false, maxLength: 2, nullable: true),
                    F1964 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F2851 = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("LOC_TAB_P01", x => new { x.F01, x.F1000, x.F117 });
                });

            migrationBuilder.CreateTable(
                name: "LST_HDR",
                columns: table => new
                {
                    F2891 = table.Column<string>(unicode: false, maxLength: 25, nullable: false),
                    F1148 = table.Column<string>(unicode: false, maxLength: 14, nullable: true),
                    F253 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F941 = table.Column<int>(nullable: true),
                    F1001 = table.Column<int>(nullable: true),
                    F1067 = table.Column<string>(unicode: false, maxLength: 7, nullable: true),
                    F1068 = table.Column<string>(unicode: false, maxLength: 6, nullable: true),
                    F1264 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F2892 = table.Column<string>(unicode: false, maxLength: 60, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("LST_HDR_P2891", x => x.F2891);
                });

            migrationBuilder.CreateTable(
                name: "LST_REG",
                columns: table => new
                {
                    F2891 = table.Column<string>(unicode: false, maxLength: 25, nullable: false),
                    F01 = table.Column<string>(unicode: false, maxLength: 13, nullable: false),
                    F03 = table.Column<int>(nullable: true),
                    F04 = table.Column<int>(nullable: true),
                    F64 = table.Column<double>(nullable: true),
                    F67 = table.Column<double>(nullable: true),
                    F253 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F941 = table.Column<int>(nullable: true),
                    F1001 = table.Column<int>(nullable: true),
                    F1041 = table.Column<string>(unicode: false, maxLength: 60, nullable: true),
                    F1067 = table.Column<string>(unicode: false, maxLength: 7, nullable: true),
                    F1071 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F1874 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("LST_REG_P2891", x => new { x.F2891, x.F01 });
                });

            migrationBuilder.CreateTable(
                name: "LVL_TAB",
                columns: table => new
                {
                    F126 = table.Column<int>(nullable: false),
                    F1000 = table.Column<string>(unicode: false, maxLength: 5, nullable: true),
                    F1017 = table.Column<string>(unicode: false, maxLength: 16, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("LVL_TAB_P126", x => x.F126);
                });

            migrationBuilder.CreateTable(
                name: "MIX_DEL",
                columns: table => new
                {
                    F32 = table.Column<int>(nullable: false),
                    F1001 = table.Column<int>(nullable: true),
                    F902 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F1019 = table.Column<string>(unicode: false, maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("MIX_DEL_P32", x => x.F32);
                });

            migrationBuilder.CreateTable(
                name: "MIX_TAB",
                columns: table => new
                {
                    F32 = table.Column<int>(nullable: false),
                    F1001 = table.Column<int>(nullable: true),
                    F902 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F1019 = table.Column<string>(unicode: false, maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("MIX_TAB_P32", x => x.F32);
                });

            migrationBuilder.CreateTable(
                name: "MOD_ITM_TAB",
                columns: table => new
                {
                    F01 = table.Column<string>(unicode: false, maxLength: 13, nullable: false),
                    F2765 = table.Column<int>(nullable: false),
                    F2882 = table.Column<string>(unicode: false, maxLength: 13, nullable: false),
                    F253 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F1001 = table.Column<int>(nullable: true),
                    F2754 = table.Column<int>(nullable: true),
                    F2883 = table.Column<double>(nullable: true),
                    F2884 = table.Column<double>(nullable: true),
                    F2885 = table.Column<double>(nullable: true),
                    F2886 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F2887 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F2888 = table.Column<string>(unicode: false, maxLength: 4, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("MOD_ITM_TAB_P01", x => new { x.F01, x.F2765, x.F2882 });
                });

            migrationBuilder.CreateTable(
                name: "MOD_TAB",
                columns: table => new
                {
                    F01 = table.Column<string>(unicode: false, maxLength: 13, nullable: false),
                    F2765 = table.Column<int>(nullable: false),
                    F253 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F1001 = table.Column<int>(nullable: true),
                    F2754 = table.Column<int>(nullable: true),
                    F2766 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F2767 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F2768 = table.Column<string>(unicode: false, maxLength: 3, nullable: true),
                    F2769 = table.Column<string>(unicode: false, maxLength: 13, nullable: true),
                    F2879 = table.Column<double>(nullable: true),
                    F2880 = table.Column<double>(nullable: true),
                    F2881 = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("MOD_TAB_P01", x => new { x.F01, x.F2765 });
                });

            migrationBuilder.CreateTable(
                name: "NACS_TAB",
                columns: table => new
                {
                    F2931 = table.Column<int>(nullable: false),
                    F2933 = table.Column<string>(unicode: false, maxLength: 60, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("NACS_TAB_P2931", x => x.F2931);
                });

            migrationBuilder.CreateTable(
                name: "OALLOW_BAT",
                columns: table => new
                {
                    F01 = table.Column<string>(unicode: false, maxLength: 13, nullable: false),
                    F902 = table.Column<string>(unicode: false, maxLength: 8, nullable: false),
                    F1000 = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    F27 = table.Column<string>(unicode: false, maxLength: 14, nullable: false),
                    F1184 = table.Column<string>(unicode: false, maxLength: 12, nullable: false),
                    F07 = table.Column<int>(nullable: true),
                    F156 = table.Column<string>(unicode: false, maxLength: 120, nullable: true),
                    F201 = table.Column<decimal>(type: "money", nullable: true),
                    F202 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F203 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F204 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F222 = table.Column<string>(unicode: false, maxLength: 12, nullable: true),
                    F223 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F329 = table.Column<double>(nullable: true),
                    F1001 = table.Column<int>(nullable: true),
                    F1657 = table.Column<double>(nullable: true),
                    F1977 = table.Column<double>(nullable: true),
                    F2591 = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("OALLOW_BAT_P01", x => new { x.F01, x.F902, x.F1000, x.F27, x.F1184 });
                });

            migrationBuilder.CreateTable(
                name: "OBBACK_BAT",
                columns: table => new
                {
                    F01 = table.Column<string>(unicode: false, maxLength: 13, nullable: false),
                    F902 = table.Column<string>(unicode: false, maxLength: 8, nullable: false),
                    F1000 = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    F27 = table.Column<string>(unicode: false, maxLength: 14, nullable: false),
                    F1184 = table.Column<string>(unicode: false, maxLength: 12, nullable: false),
                    F07 = table.Column<int>(nullable: true),
                    F1001 = table.Column<int>(nullable: true),
                    F1662 = table.Column<decimal>(type: "money", nullable: true),
                    F1663 = table.Column<double>(nullable: true),
                    F1664 = table.Column<decimal>(type: "money", nullable: true),
                    F1665 = table.Column<double>(nullable: true),
                    F1666 = table.Column<decimal>(type: "money", nullable: true),
                    F1667 = table.Column<double>(nullable: true),
                    F1668 = table.Column<string>(unicode: false, maxLength: 16, nullable: true),
                    F1669 = table.Column<decimal>(type: "money", nullable: true),
                    F1670 = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("OBBACK_BAT_P01", x => new { x.F01, x.F902, x.F1000, x.F27, x.F1184 });
                });

            migrationBuilder.CreateTable(
                name: "OBJ_DEL",
                columns: table => new
                {
                    F01 = table.Column<string>(unicode: false, maxLength: 13, nullable: false),
                    F16 = table.Column<int>(nullable: true),
                    F17 = table.Column<int>(nullable: true),
                    F18 = table.Column<int>(nullable: true),
                    F93 = table.Column<string>(unicode: false, maxLength: 16, nullable: true),
                    F193 = table.Column<string>(unicode: false, maxLength: 16, nullable: true),
                    F902 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F1001 = table.Column<int>(nullable: true),
                    F07 = table.Column<int>(nullable: true),
                    F11 = table.Column<int>(nullable: true),
                    F12 = table.Column<double>(nullable: true),
                    F13 = table.Column<double>(nullable: true),
                    F14 = table.Column<double>(nullable: true),
                    F21 = table.Column<double>(nullable: true),
                    F22 = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    F23 = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    F29 = table.Column<string>(unicode: false, maxLength: 60, nullable: true),
                    F155 = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    F180 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    F213 = table.Column<string>(unicode: false, maxLength: 13, nullable: true),
                    F214 = table.Column<string>(unicode: false, maxLength: 13, nullable: true),
                    F215 = table.Column<int>(nullable: true),
                    F218 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F253 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F255 = table.Column<string>(unicode: false, maxLength: 120, nullable: true),
                    F270 = table.Column<double>(nullable: true),
                    F940 = table.Column<int>(nullable: true),
                    F941 = table.Column<int>(nullable: true),
                    F1000 = table.Column<string>(unicode: false, maxLength: 5, nullable: true),
                    F1002 = table.Column<double>(nullable: true),
                    F1004 = table.Column<int>(nullable: true),
                    F1118 = table.Column<string>(unicode: false, maxLength: 9, nullable: true),
                    F1119 = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    F1168 = table.Column<int>(nullable: true),
                    F1699 = table.Column<double>(nullable: true),
                    F1736 = table.Column<int>(nullable: true),
                    F1737 = table.Column<string>(unicode: false, maxLength: 13, nullable: true),
                    F1738 = table.Column<string>(unicode: false, maxLength: 13, nullable: true),
                    F1744 = table.Column<double>(nullable: true),
                    F1759 = table.Column<int>(nullable: true),
                    F1781 = table.Column<string>(unicode: false, maxLength: 12, nullable: true),
                    F1782 = table.Column<string>(unicode: false, maxLength: 12, nullable: true),
                    F1783 = table.Column<int>(nullable: true),
                    F1784 = table.Column<int>(nullable: true),
                    F1939 = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    F1940 = table.Column<string>(unicode: false, maxLength: 60, nullable: true),
                    F1941 = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    F1942 = table.Column<string>(unicode: false, maxLength: 120, nullable: true),
                    F1957 = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    F1958 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    F1959 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    F1960 = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    F1962 = table.Column<string>(unicode: false, maxLength: 600, nullable: true),
                    F1964 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F2119 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F2600 = table.Column<string>(unicode: false, maxLength: 2, nullable: true),
                    F2693 = table.Column<string>(unicode: false, maxLength: 13, nullable: true),
                    F2789 = table.Column<string>(unicode: false, maxLength: 13, nullable: true),
                    F2931 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("OBJ_DEL_P01", x => x.F01);
                });

            migrationBuilder.CreateTable(
                name: "OBJ_TAB",
                columns: table => new
                {
                    F01 = table.Column<string>(unicode: false, maxLength: 13, nullable: false),
                    F16 = table.Column<int>(nullable: true),
                    F17 = table.Column<int>(nullable: true),
                    F18 = table.Column<int>(nullable: true),
                    F93 = table.Column<string>(unicode: false, maxLength: 16, nullable: true),
                    F193 = table.Column<string>(unicode: false, maxLength: 16, nullable: true),
                    F902 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F1001 = table.Column<int>(nullable: true),
                    F07 = table.Column<int>(nullable: true),
                    F11 = table.Column<int>(nullable: true),
                    F12 = table.Column<double>(nullable: true),
                    F13 = table.Column<double>(nullable: true),
                    F14 = table.Column<double>(nullable: true),
                    F21 = table.Column<double>(nullable: true),
                    F22 = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    F23 = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    F29 = table.Column<string>(unicode: false, maxLength: 60, nullable: true),
                    F155 = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    F180 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    F213 = table.Column<string>(unicode: false, maxLength: 13, nullable: true),
                    F214 = table.Column<string>(unicode: false, maxLength: 13, nullable: true),
                    F215 = table.Column<int>(nullable: true),
                    F218 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F253 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F255 = table.Column<string>(unicode: false, maxLength: 120, nullable: true),
                    F270 = table.Column<double>(nullable: true),
                    F940 = table.Column<int>(nullable: true),
                    F941 = table.Column<int>(nullable: true),
                    F1000 = table.Column<string>(unicode: false, maxLength: 5, nullable: true),
                    F1002 = table.Column<double>(nullable: true),
                    F1004 = table.Column<int>(nullable: true),
                    F1118 = table.Column<string>(unicode: false, maxLength: 9, nullable: true),
                    F1119 = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    F1168 = table.Column<int>(nullable: true),
                    F1699 = table.Column<double>(nullable: true),
                    F1736 = table.Column<int>(nullable: true),
                    F1737 = table.Column<string>(unicode: false, maxLength: 13, nullable: true),
                    F1738 = table.Column<string>(unicode: false, maxLength: 13, nullable: true),
                    F1744 = table.Column<double>(nullable: true),
                    F1759 = table.Column<int>(nullable: true),
                    F1781 = table.Column<string>(unicode: false, maxLength: 12, nullable: true),
                    F1782 = table.Column<string>(unicode: false, maxLength: 12, nullable: true),
                    F1783 = table.Column<int>(nullable: true),
                    F1784 = table.Column<int>(nullable: true),
                    F1939 = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    F1940 = table.Column<string>(unicode: false, maxLength: 60, nullable: true),
                    F1941 = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    F1942 = table.Column<string>(unicode: false, maxLength: 120, nullable: true),
                    F1957 = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    F1958 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    F1959 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    F1960 = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    F1962 = table.Column<string>(unicode: false, maxLength: 600, nullable: true),
                    F1964 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F2119 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F2600 = table.Column<string>(unicode: false, maxLength: 2, nullable: true),
                    F2693 = table.Column<string>(unicode: false, maxLength: 13, nullable: true),
                    F2789 = table.Column<string>(unicode: false, maxLength: 13, nullable: true),
                    F2931 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("OBJ_TAB_P01", x => x.F01);
                });

            migrationBuilder.CreateTable(
                name: "OCOST_BAT",
                columns: table => new
                {
                    F01 = table.Column<string>(unicode: false, maxLength: 13, nullable: false),
                    F902 = table.Column<string>(unicode: false, maxLength: 8, nullable: false),
                    F1000 = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    F27 = table.Column<string>(unicode: false, maxLength: 14, nullable: false),
                    F1184 = table.Column<string>(unicode: false, maxLength: 12, nullable: false),
                    F07 = table.Column<int>(nullable: true),
                    F19 = table.Column<double>(nullable: true),
                    F20 = table.Column<double>(nullable: true),
                    F38 = table.Column<decimal>(type: "money", nullable: true),
                    F39 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F120 = table.Column<decimal>(type: "money", nullable: true),
                    F185 = table.Column<decimal>(type: "money", nullable: true),
                    F212 = table.Column<string>(unicode: false, maxLength: 6, nullable: true),
                    F1001 = table.Column<int>(nullable: true),
                    F1121 = table.Column<decimal>(type: "money", nullable: true),
                    F1122 = table.Column<double>(nullable: true),
                    F1964 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F2626 = table.Column<decimal>(type: "money", nullable: true),
                    F2628 = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("OCOST_BAT_P01", x => new { x.F01, x.F902, x.F1000, x.F27, x.F1184 });
                });

            migrationBuilder.CreateTable(
                name: "OCSTBRK_BAT",
                columns: table => new
                {
                    F01 = table.Column<string>(unicode: false, maxLength: 13, nullable: false),
                    F902 = table.Column<string>(unicode: false, maxLength: 8, nullable: false),
                    F1000 = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    F27 = table.Column<string>(unicode: false, maxLength: 14, nullable: false),
                    F1184 = table.Column<string>(unicode: false, maxLength: 12, nullable: false),
                    F07 = table.Column<int>(nullable: true),
                    F219 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F224 = table.Column<double>(nullable: true),
                    F225 = table.Column<decimal>(type: "money", nullable: true),
                    F226 = table.Column<double>(nullable: true),
                    F227 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F1001 = table.Column<int>(nullable: true),
                    F1661 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F1975 = table.Column<string>(unicode: false, maxLength: 120, nullable: true),
                    F2568 = table.Column<double>(nullable: true),
                    F2594 = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("OCSTBRK_BAT_P01", x => new { x.F01, x.F902, x.F1000, x.F27, x.F1184 });
                });

            migrationBuilder.CreateTable(
                name: "ODISC_BAT",
                columns: table => new
                {
                    F01 = table.Column<string>(unicode: false, maxLength: 13, nullable: false),
                    F902 = table.Column<string>(unicode: false, maxLength: 8, nullable: false),
                    F1000 = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    F27 = table.Column<string>(unicode: false, maxLength: 14, nullable: false),
                    F1184 = table.Column<string>(unicode: false, maxLength: 12, nullable: false),
                    F07 = table.Column<int>(nullable: true),
                    F228 = table.Column<double>(nullable: true),
                    F229 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F230 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F231 = table.Column<string>(unicode: false, maxLength: 12, nullable: true),
                    F1001 = table.Column<int>(nullable: true),
                    F1658 = table.Column<decimal>(type: "money", nullable: true),
                    F1659 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F1973 = table.Column<string>(unicode: false, maxLength: 120, nullable: true),
                    F1978 = table.Column<double>(nullable: true),
                    F2566 = table.Column<double>(nullable: true),
                    F2593 = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ODISC_BAT_P01", x => new { x.F01, x.F902, x.F1000, x.F27, x.F1184 });
                });

            migrationBuilder.CreateTable(
                name: "OECL_BAT",
                columns: table => new
                {
                    F902 = table.Column<string>(unicode: false, maxLength: 8, nullable: false),
                    F164 = table.Column<string>(unicode: false, maxLength: 13, nullable: false),
                    F1033 = table.Column<string>(unicode: false, maxLength: 3, nullable: false),
                    F01 = table.Column<string>(unicode: false, maxLength: 13, nullable: false),
                    F1031 = table.Column<string>(unicode: false, maxLength: 1, nullable: false),
                    F1034 = table.Column<int>(nullable: false),
                    F1000 = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    F02 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F33 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F64 = table.Column<double>(nullable: true),
                    F65 = table.Column<decimal>(type: "money", nullable: true),
                    F67 = table.Column<double>(nullable: true),
                    F1001 = table.Column<int>(nullable: true),
                    F1759 = table.Column<int>(nullable: true),
                    F1964 = table.Column<string>(unicode: false, maxLength: 4, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("OECL_BAT_P902", x => new { x.F902, x.F164, x.F1033, x.F01, x.F1031, x.F1034, x.F1000 });
                });

            migrationBuilder.CreateTable(
                name: "OFR_TAB",
                columns: table => new
                {
                    F1148 = table.Column<string>(unicode: false, maxLength: 14, nullable: false),
                    F2817 = table.Column<string>(unicode: false, maxLength: 10, nullable: false),
                    F301 = table.Column<string>(unicode: false, maxLength: 250, nullable: false),
                    F88 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F104 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F253 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F302 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F303 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F304 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F305 = table.Column<decimal>(type: "money", nullable: true),
                    F306 = table.Column<double>(nullable: true),
                    F307 = table.Column<decimal>(type: "money", nullable: true),
                    F308 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F309 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F310 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F311 = table.Column<int>(nullable: true),
                    F312 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F313 = table.Column<string>(unicode: false, maxLength: 13, nullable: true),
                    F314 = table.Column<double>(nullable: true),
                    F315 = table.Column<string>(unicode: false, maxLength: 13, nullable: true),
                    F316 = table.Column<double>(nullable: true),
                    F317 = table.Column<string>(unicode: false, maxLength: 13, nullable: true),
                    F318 = table.Column<double>(nullable: true),
                    F319 = table.Column<string>(unicode: false, maxLength: 13, nullable: true),
                    F320 = table.Column<double>(nullable: true),
                    F321 = table.Column<string>(unicode: false, maxLength: 13, nullable: true),
                    F322 = table.Column<double>(nullable: true),
                    F385 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F940 = table.Column<int>(nullable: true),
                    F941 = table.Column<int>(nullable: true),
                    F1056 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F1057 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F1101 = table.Column<int>(nullable: true),
                    F1264 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F1525 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F2813 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F2814 = table.Column<string>(unicode: false, maxLength: 250, nullable: true),
                    F2815 = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    F2818 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F2819 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F2820 = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    F2821 = table.Column<double>(nullable: true),
                    F2822 = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("OFR_TAB_P1148", x => new { x.F1148, x.F2817, x.F301 });
                });

            migrationBuilder.CreateTable(
                name: "OGCOST_BAT",
                columns: table => new
                {
                    F01 = table.Column<string>(unicode: false, maxLength: 13, nullable: false),
                    F902 = table.Column<string>(unicode: false, maxLength: 8, nullable: false),
                    F1000 = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    F27 = table.Column<string>(unicode: false, maxLength: 14, nullable: false),
                    F1184 = table.Column<string>(unicode: false, maxLength: 12, nullable: false),
                    F07 = table.Column<int>(nullable: true),
                    F08 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F26 = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    F28 = table.Column<string>(unicode: false, maxLength: 13, nullable: true),
                    F90 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F127 = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    F131 = table.Column<int>(nullable: true),
                    F165 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F216 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F220 = table.Column<string>(unicode: false, maxLength: 13, nullable: true),
                    F325 = table.Column<double>(nullable: true),
                    F326 = table.Column<double>(nullable: true),
                    F327 = table.Column<double>(nullable: true),
                    F328 = table.Column<double>(nullable: true),
                    F1001 = table.Column<int>(nullable: true),
                    F1037 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F1168 = table.Column<int>(nullable: true),
                    F1685 = table.Column<int>(nullable: true),
                    F1759 = table.Column<int>(nullable: true),
                    F1760 = table.Column<double>(nullable: true),
                    F1761 = table.Column<double>(nullable: true),
                    F1766 = table.Column<decimal>(type: "money", nullable: true),
                    F1791 = table.Column<string>(unicode: false, maxLength: 12, nullable: true),
                    F1792 = table.Column<string>(unicode: false, maxLength: 12, nullable: true),
                    F1793 = table.Column<int>(nullable: true),
                    F1794 = table.Column<int>(nullable: true),
                    F1795 = table.Column<double>(nullable: true),
                    F1797 = table.Column<decimal>(type: "money", nullable: true),
                    F1798 = table.Column<decimal>(type: "money", nullable: true),
                    F1875 = table.Column<string>(unicode: false, maxLength: 2, nullable: true),
                    F1887 = table.Column<string>(unicode: false, maxLength: 2, nullable: true),
                    F1961 = table.Column<string>(unicode: false, maxLength: 2, nullable: true),
                    F1976 = table.Column<string>(unicode: false, maxLength: 120, nullable: true),
                    F2601 = table.Column<string>(unicode: false, maxLength: 2, nullable: true),
                    F2624 = table.Column<int>(nullable: true),
                    F2666 = table.Column<double>(nullable: true),
                    F2699 = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("OGCOST_BAT_P01", x => new { x.F01, x.F902, x.F1000, x.F27, x.F1184 });
                });

            migrationBuilder.CreateTable(
                name: "OGPRICE_BAT",
                columns: table => new
                {
                    F01 = table.Column<string>(unicode: false, maxLength: 13, nullable: false),
                    F902 = table.Column<string>(unicode: false, maxLength: 8, nullable: false),
                    F1000 = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    F126 = table.Column<int>(nullable: false),
                    F07 = table.Column<int>(nullable: true),
                    F21 = table.Column<double>(nullable: true),
                    F41 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F43 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F109 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F119 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F122 = table.Column<string>(unicode: false, maxLength: 13, nullable: true),
                    F164 = table.Column<string>(unicode: false, maxLength: 13, nullable: true),
                    F166 = table.Column<decimal>(type: "money", nullable: true),
                    F167 = table.Column<double>(nullable: true),
                    F175 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F177 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F903 = table.Column<string>(unicode: false, maxLength: 16, nullable: true),
                    F1001 = table.Column<int>(nullable: true),
                    F1135 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F1230 = table.Column<int>(nullable: true),
                    F1233 = table.Column<decimal>(type: "money", nullable: true),
                    F1759 = table.Column<int>(nullable: true),
                    F1799 = table.Column<string>(unicode: false, maxLength: 12, nullable: true),
                    F1800 = table.Column<string>(unicode: false, maxLength: 12, nullable: true),
                    F1802 = table.Column<int>(nullable: true),
                    F1803 = table.Column<double>(nullable: true),
                    F1804 = table.Column<double>(nullable: true),
                    F1885 = table.Column<decimal>(type: "money", nullable: true),
                    F1928 = table.Column<double>(nullable: true),
                    F1930 = table.Column<int>(nullable: true),
                    F1935 = table.Column<decimal>(type: "money", nullable: true),
                    F2694 = table.Column<string>(unicode: false, maxLength: 12, nullable: true),
                    F2695 = table.Column<string>(unicode: false, maxLength: 12, nullable: true),
                    F2696 = table.Column<string>(unicode: false, maxLength: 12, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("OGPRICE_BAT_P01", x => new { x.F01, x.F902, x.F1000, x.F126 });
                });

            migrationBuilder.CreateTable(
                name: "OINSTORE_BAT",
                columns: table => new
                {
                    F01 = table.Column<string>(unicode: false, maxLength: 13, nullable: false),
                    F902 = table.Column<string>(unicode: false, maxLength: 8, nullable: false),
                    F1000 = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    F126 = table.Column<int>(nullable: false),
                    F07 = table.Column<int>(nullable: true),
                    F34 = table.Column<string>(unicode: false, maxLength: 2, nullable: true),
                    F37 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F59 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F1001 = table.Column<int>(nullable: true),
                    F1133 = table.Column<decimal>(type: "money", nullable: true),
                    F1134 = table.Column<double>(nullable: true),
                    F1194 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F1195 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F1196 = table.Column<decimal>(type: "money", nullable: true),
                    F1197 = table.Column<double>(nullable: true),
                    F1198 = table.Column<decimal>(type: "money", nullable: true),
                    F1199 = table.Column<double>(nullable: true),
                    F1200 = table.Column<int>(nullable: true),
                    F1201 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F1202 = table.Column<int>(nullable: true),
                    F1216 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F1217 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F1222 = table.Column<decimal>(type: "money", nullable: true),
                    F1223 = table.Column<double>(nullable: true),
                    F1871 = table.Column<double>(nullable: true),
                    F1872 = table.Column<double>(nullable: true),
                    F1873 = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("OINSTORE_BAT_P01", x => new { x.F01, x.F902, x.F1000, x.F126 });
                });

            migrationBuilder.CreateTable(
                name: "OOBJ_BAT",
                columns: table => new
                {
                    F01 = table.Column<string>(unicode: false, maxLength: 13, nullable: false),
                    F902 = table.Column<string>(unicode: false, maxLength: 8, nullable: false),
                    F07 = table.Column<int>(nullable: true),
                    F11 = table.Column<int>(nullable: true),
                    F12 = table.Column<double>(nullable: true),
                    F13 = table.Column<double>(nullable: true),
                    F14 = table.Column<double>(nullable: true),
                    F16 = table.Column<int>(nullable: true),
                    F17 = table.Column<int>(nullable: true),
                    F18 = table.Column<int>(nullable: true),
                    F21 = table.Column<double>(nullable: true),
                    F22 = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    F23 = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    F29 = table.Column<string>(unicode: false, maxLength: 60, nullable: true),
                    F93 = table.Column<string>(unicode: false, maxLength: 16, nullable: true),
                    F155 = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    F180 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    F193 = table.Column<string>(unicode: false, maxLength: 16, nullable: true),
                    F213 = table.Column<string>(unicode: false, maxLength: 13, nullable: true),
                    F214 = table.Column<string>(unicode: false, maxLength: 13, nullable: true),
                    F215 = table.Column<int>(nullable: true),
                    F218 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F255 = table.Column<string>(unicode: false, maxLength: 120, nullable: true),
                    F270 = table.Column<double>(nullable: true),
                    F940 = table.Column<int>(nullable: true),
                    F941 = table.Column<int>(nullable: true),
                    F1000 = table.Column<string>(unicode: false, maxLength: 5, nullable: true),
                    F1001 = table.Column<int>(nullable: true),
                    F1002 = table.Column<double>(nullable: true),
                    F1004 = table.Column<int>(nullable: true),
                    F1118 = table.Column<string>(unicode: false, maxLength: 9, nullable: true),
                    F1119 = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    F1168 = table.Column<int>(nullable: true),
                    F1699 = table.Column<double>(nullable: true),
                    F1736 = table.Column<int>(nullable: true),
                    F1737 = table.Column<string>(unicode: false, maxLength: 13, nullable: true),
                    F1738 = table.Column<string>(unicode: false, maxLength: 13, nullable: true),
                    F1744 = table.Column<double>(nullable: true),
                    F1781 = table.Column<string>(unicode: false, maxLength: 12, nullable: true),
                    F1782 = table.Column<string>(unicode: false, maxLength: 12, nullable: true),
                    F1783 = table.Column<int>(nullable: true),
                    F1784 = table.Column<int>(nullable: true),
                    F1939 = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    F1940 = table.Column<string>(unicode: false, maxLength: 60, nullable: true),
                    F1941 = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    F1942 = table.Column<string>(unicode: false, maxLength: 120, nullable: true),
                    F1957 = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    F1958 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    F1959 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    F1960 = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    F1962 = table.Column<string>(unicode: false, maxLength: 600, nullable: true),
                    F1964 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F2600 = table.Column<string>(unicode: false, maxLength: 2, nullable: true),
                    F2693 = table.Column<string>(unicode: false, maxLength: 13, nullable: true),
                    F2789 = table.Column<string>(unicode: false, maxLength: 13, nullable: true),
                    F2931 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("OOBJ_BAT_P01", x => new { x.F01, x.F902 });
                });

            migrationBuilder.CreateTable(
                name: "OPID_BAT",
                columns: table => new
                {
                    F01 = table.Column<string>(unicode: false, maxLength: 13, nullable: false),
                    F902 = table.Column<string>(unicode: false, maxLength: 8, nullable: false),
                    F1000 = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    F383 = table.Column<string>(unicode: false, maxLength: 80, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("OPID_BAT_P01", x => new { x.F01, x.F902, x.F1000, x.F383 });
                });

            migrationBuilder.CreateTable(
                name: "OPOS_BAT",
                columns: table => new
                {
                    F01 = table.Column<string>(unicode: false, maxLength: 13, nullable: false),
                    F902 = table.Column<string>(unicode: false, maxLength: 8, nullable: false),
                    F1000 = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    F02 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F03 = table.Column<int>(nullable: true),
                    F04 = table.Column<int>(nullable: true),
                    F05 = table.Column<int>(nullable: true),
                    F06 = table.Column<int>(nullable: true),
                    F07 = table.Column<int>(nullable: true),
                    F08 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F09 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F24 = table.Column<double>(nullable: true),
                    F40 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F50 = table.Column<decimal>(type: "money", nullable: true),
                    F60 = table.Column<decimal>(type: "money", nullable: true),
                    F61 = table.Column<decimal>(type: "money", nullable: true),
                    F66 = table.Column<int>(nullable: true),
                    F77 = table.Column<int>(nullable: true),
                    F78 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F79 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F80 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F81 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F82 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F83 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F84 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F85 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F86 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F87 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F88 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F92 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F96 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F97 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F98 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F99 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F100 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F101 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F102 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F104 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F106 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F107 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F108 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F110 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F114 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F115 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F121 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F123 = table.Column<string>(unicode: false, maxLength: 13, nullable: true),
                    F124 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F125 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F141 = table.Column<double>(nullable: true),
                    F149 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F150 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F153 = table.Column<int>(nullable: true),
                    F158 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F159 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F160 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F161 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F162 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F163 = table.Column<int>(nullable: true),
                    F170 = table.Column<int>(nullable: true),
                    F171 = table.Column<int>(nullable: true),
                    F172 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F173 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F174 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F176 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F178 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F188 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F189 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F209 = table.Column<double>(nullable: true),
                    F210 = table.Column<decimal>(type: "money", nullable: true),
                    F211 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F217 = table.Column<double>(nullable: true),
                    F302 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F303 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F304 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F306 = table.Column<double>(nullable: true),
                    F383 = table.Column<string>(unicode: false, maxLength: 80, nullable: true),
                    F388 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F397 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F1001 = table.Column<int>(nullable: true),
                    F1099 = table.Column<int>(nullable: true),
                    F1120 = table.Column<string>(unicode: false, maxLength: 12, nullable: true),
                    F1124 = table.Column<double>(nullable: true),
                    F1136 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F1138 = table.Column<double>(nullable: true),
                    F1139 = table.Column<int>(nullable: true),
                    F1236 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F1237 = table.Column<double>(nullable: true),
                    F1735 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F1785 = table.Column<string>(unicode: false, maxLength: 12, nullable: true),
                    F1786 = table.Column<string>(unicode: false, maxLength: 12, nullable: true),
                    F1787 = table.Column<int>(nullable: true),
                    F1788 = table.Column<int>(nullable: true),
                    F1789 = table.Column<double>(nullable: true),
                    F1790 = table.Column<double>(nullable: true),
                    F1892 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F1926 = table.Column<double>(nullable: true),
                    F1929 = table.Column<int>(nullable: true),
                    F1933 = table.Column<decimal>(type: "money", nullable: true),
                    F1964 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F2608 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F2660 = table.Column<string>(unicode: false, maxLength: 250, nullable: true),
                    F2930 = table.Column<string>(unicode: false, maxLength: 13, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("OPOS_BAT_P01", x => new { x.F01, x.F902, x.F1000 });
                });

            migrationBuilder.CreateTable(
                name: "OPRICE_BAT",
                columns: table => new
                {
                    F01 = table.Column<string>(unicode: false, maxLength: 13, nullable: false),
                    F902 = table.Column<string>(unicode: false, maxLength: 8, nullable: false),
                    F1000 = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    F126 = table.Column<int>(nullable: false),
                    F07 = table.Column<int>(nullable: true),
                    F30 = table.Column<decimal>(type: "money", nullable: true),
                    F31 = table.Column<double>(nullable: true),
                    F32 = table.Column<int>(nullable: true),
                    F33 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F34 = table.Column<string>(unicode: false, maxLength: 2, nullable: true),
                    F35 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F36 = table.Column<string>(unicode: false, maxLength: 6, nullable: true),
                    F37 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F49 = table.Column<double>(nullable: true),
                    F62 = table.Column<double>(nullable: true),
                    F63 = table.Column<decimal>(type: "money", nullable: true),
                    F111 = table.Column<decimal>(type: "money", nullable: true),
                    F112 = table.Column<double>(nullable: true),
                    F129 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F130 = table.Column<string>(unicode: false, maxLength: 6, nullable: true),
                    F133 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F140 = table.Column<decimal>(type: "money", nullable: true),
                    F142 = table.Column<double>(nullable: true),
                    F168 = table.Column<decimal>(type: "money", nullable: true),
                    F169 = table.Column<int>(nullable: true),
                    F205 = table.Column<decimal>(type: "money", nullable: true),
                    F1001 = table.Column<int>(nullable: true),
                    F1005 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F1713 = table.Column<double>(nullable: true),
                    F1714 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F1767 = table.Column<double>(nullable: true),
                    F1768 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F1769 = table.Column<double>(nullable: true),
                    F1770 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F1927 = table.Column<double>(nullable: true),
                    F1934 = table.Column<decimal>(type: "money", nullable: true),
                    F1964 = table.Column<string>(unicode: false, maxLength: 4, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("OPRICE_BAT_P01", x => new { x.F01, x.F902, x.F1000, x.F126 });
                });

            migrationBuilder.CreateTable(
                name: "OREBATE_BAT",
                columns: table => new
                {
                    F01 = table.Column<string>(unicode: false, maxLength: 13, nullable: false),
                    F902 = table.Column<string>(unicode: false, maxLength: 8, nullable: false),
                    F1000 = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    F27 = table.Column<string>(unicode: false, maxLength: 14, nullable: false),
                    F1184 = table.Column<string>(unicode: false, maxLength: 12, nullable: false),
                    F07 = table.Column<int>(nullable: true),
                    F233 = table.Column<decimal>(type: "money", nullable: true),
                    F234 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F235 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F236 = table.Column<string>(unicode: false, maxLength: 12, nullable: true),
                    F237 = table.Column<double>(nullable: true),
                    F1001 = table.Column<int>(nullable: true),
                    F1660 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F1974 = table.Column<string>(unicode: false, maxLength: 120, nullable: true),
                    F1979 = table.Column<double>(nullable: true),
                    F2567 = table.Column<double>(nullable: true),
                    F2592 = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("OREBATE_BAT_P01", x => new { x.F01, x.F902, x.F1000, x.F27, x.F1184 });
                });

            migrationBuilder.CreateTable(
                name: "OREDEEM_BAT",
                columns: table => new
                {
                    F01 = table.Column<string>(unicode: false, maxLength: 13, nullable: false),
                    F902 = table.Column<string>(unicode: false, maxLength: 8, nullable: false),
                    F1000 = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    F126 = table.Column<int>(nullable: false),
                    F07 = table.Column<int>(nullable: true),
                    F1001 = table.Column<int>(nullable: true),
                    F1228 = table.Column<int>(nullable: true),
                    F1229 = table.Column<decimal>(type: "money", nullable: true),
                    F1232 = table.Column<int>(nullable: true),
                    F1234 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F1235 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F2744 = table.Column<string>(unicode: false, maxLength: 4, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("OREDEEM_BAT_P01", x => new { x.F01, x.F902, x.F1000, x.F126 });
                });

            migrationBuilder.CreateTable(
                name: "OSPRICE_BAT",
                columns: table => new
                {
                    F01 = table.Column<string>(unicode: false, maxLength: 13, nullable: false),
                    F902 = table.Column<string>(unicode: false, maxLength: 8, nullable: false),
                    F1000 = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    F126 = table.Column<int>(nullable: false),
                    F07 = table.Column<int>(nullable: true),
                    F34 = table.Column<string>(unicode: false, maxLength: 2, nullable: true),
                    F37 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F42 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F135 = table.Column<double>(nullable: true),
                    F136 = table.Column<decimal>(type: "money", nullable: true),
                    F137 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F138 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F139 = table.Column<decimal>(type: "money", nullable: true),
                    F143 = table.Column<double>(nullable: true),
                    F144 = table.Column<string>(unicode: false, maxLength: 6, nullable: true),
                    F145 = table.Column<string>(unicode: false, maxLength: 6, nullable: true),
                    F146 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F147 = table.Column<double>(nullable: true),
                    F148 = table.Column<decimal>(type: "money", nullable: true),
                    F179 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F232 = table.Column<double>(nullable: true),
                    F1001 = table.Column<int>(nullable: true),
                    F1192 = table.Column<int>(nullable: true),
                    F1193 = table.Column<int>(nullable: true),
                    F1220 = table.Column<decimal>(type: "money", nullable: true),
                    F1221 = table.Column<double>(nullable: true),
                    F1801 = table.Column<int>(nullable: true),
                    F1865 = table.Column<double>(nullable: true),
                    F1866 = table.Column<double>(nullable: true),
                    F1867 = table.Column<double>(nullable: true),
                    F1955 = table.Column<decimal>(type: "money", nullable: true),
                    F1956 = table.Column<decimal>(type: "money", nullable: true),
                    F2668 = table.Column<string>(unicode: false, maxLength: 12, nullable: true),
                    F2955 = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("OSPRICE_BAT_P01", x => new { x.F01, x.F902, x.F1000, x.F126 });
                });

            migrationBuilder.CreateTable(
                name: "OTPRICE_BAT",
                columns: table => new
                {
                    F01 = table.Column<string>(unicode: false, maxLength: 13, nullable: false),
                    F902 = table.Column<string>(unicode: false, maxLength: 8, nullable: false),
                    F1000 = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    F126 = table.Column<int>(nullable: false),
                    F07 = table.Column<int>(nullable: true),
                    F34 = table.Column<string>(unicode: false, maxLength: 2, nullable: true),
                    F37 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F181 = table.Column<decimal>(type: "money", nullable: true),
                    F182 = table.Column<double>(nullable: true),
                    F183 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F184 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F221 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F1001 = table.Column<int>(nullable: true),
                    F1186 = table.Column<decimal>(type: "money", nullable: true),
                    F1187 = table.Column<double>(nullable: true),
                    F1188 = table.Column<decimal>(type: "money", nullable: true),
                    F1189 = table.Column<double>(nullable: true),
                    F1190 = table.Column<int>(nullable: true),
                    F1191 = table.Column<int>(nullable: true),
                    F1218 = table.Column<decimal>(type: "money", nullable: true),
                    F1219 = table.Column<double>(nullable: true),
                    F1868 = table.Column<double>(nullable: true),
                    F1869 = table.Column<double>(nullable: true),
                    F1870 = table.Column<double>(nullable: true),
                    F1953 = table.Column<decimal>(type: "money", nullable: true),
                    F1954 = table.Column<decimal>(type: "money", nullable: true),
                    F2667 = table.Column<string>(unicode: false, maxLength: 12, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("OTPRICE_BAT_P01", x => new { x.F01, x.F902, x.F1000, x.F126 });
                });

            migrationBuilder.CreateTable(
                name: "PAY_TAB",
                columns: table => new
                {
                    F1567 = table.Column<int>(nullable: false),
                    F03 = table.Column<int>(nullable: true),
                    F04 = table.Column<int>(nullable: true),
                    F2648 = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    F2649 = table.Column<decimal>(type: "money", nullable: true),
                    F2650 = table.Column<decimal>(type: "money", nullable: true),
                    F2651 = table.Column<decimal>(type: "money", nullable: true),
                    F2652 = table.Column<decimal>(type: "money", nullable: true),
                    F2779 = table.Column<decimal>(type: "money", nullable: true),
                    F2780 = table.Column<decimal>(type: "money", nullable: true),
                    F2781 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PAY_TAB_P1567", x => x.F1567);
                });

            migrationBuilder.CreateTable(
                name: "PERIOD_TAB",
                columns: table => new
                {
                    F1000 = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    F1031 = table.Column<string>(unicode: false, maxLength: 1, nullable: false),
                    F254 = table.Column<DateTime>(type: "datetime", nullable: false),
                    F253 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F1032 = table.Column<int>(nullable: true),
                    F1951 = table.Column<string>(unicode: false, maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PERIOD_TAB_P1000", x => new { x.F1000, x.F1031, x.F254 });
                });

            migrationBuilder.CreateTable(
                name: "POS_DEL",
                columns: table => new
                {
                    F01 = table.Column<string>(unicode: false, maxLength: 13, nullable: false),
                    F1000 = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    F04 = table.Column<int>(nullable: true),
                    F383 = table.Column<string>(unicode: false, maxLength: 80, nullable: true),
                    F902 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F1001 = table.Column<int>(nullable: true),
                    F02 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F03 = table.Column<int>(nullable: true),
                    F05 = table.Column<int>(nullable: true),
                    F06 = table.Column<int>(nullable: true),
                    F07 = table.Column<int>(nullable: true),
                    F08 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F09 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F24 = table.Column<double>(nullable: true),
                    F40 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F50 = table.Column<decimal>(type: "money", nullable: true),
                    F60 = table.Column<decimal>(type: "money", nullable: true),
                    F61 = table.Column<decimal>(type: "money", nullable: true),
                    F66 = table.Column<int>(nullable: true),
                    F77 = table.Column<int>(nullable: true),
                    F78 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F79 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F80 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F81 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F82 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F83 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F84 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F85 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F86 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F87 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F88 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F92 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F96 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F97 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F98 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F99 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F100 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F101 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F102 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F104 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F106 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F107 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F108 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F110 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F114 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F115 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F121 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F123 = table.Column<string>(unicode: false, maxLength: 13, nullable: true),
                    F124 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F125 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F141 = table.Column<double>(nullable: true),
                    F149 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F150 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F153 = table.Column<int>(nullable: true),
                    F158 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F159 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F160 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F161 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F162 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F163 = table.Column<int>(nullable: true),
                    F170 = table.Column<int>(nullable: true),
                    F171 = table.Column<int>(nullable: true),
                    F172 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F173 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F174 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F176 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F178 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F188 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F189 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F209 = table.Column<double>(nullable: true),
                    F210 = table.Column<decimal>(type: "money", nullable: true),
                    F211 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F217 = table.Column<double>(nullable: true),
                    F253 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F302 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F303 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F304 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F306 = table.Column<double>(nullable: true),
                    F388 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F397 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F1099 = table.Column<int>(nullable: true),
                    F1120 = table.Column<string>(unicode: false, maxLength: 12, nullable: true),
                    F1124 = table.Column<double>(nullable: true),
                    F1136 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F1138 = table.Column<double>(nullable: true),
                    F1139 = table.Column<int>(nullable: true),
                    F1236 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F1237 = table.Column<double>(nullable: true),
                    F1735 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F1759 = table.Column<int>(nullable: true),
                    F1785 = table.Column<string>(unicode: false, maxLength: 12, nullable: true),
                    F1786 = table.Column<string>(unicode: false, maxLength: 12, nullable: true),
                    F1787 = table.Column<int>(nullable: true),
                    F1788 = table.Column<int>(nullable: true),
                    F1789 = table.Column<double>(nullable: true),
                    F1790 = table.Column<double>(nullable: true),
                    F1892 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F1926 = table.Column<double>(nullable: true),
                    F1929 = table.Column<int>(nullable: true),
                    F1933 = table.Column<decimal>(type: "money", nullable: true),
                    F1964 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F2119 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F2608 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F2660 = table.Column<string>(unicode: false, maxLength: 250, nullable: true),
                    F2930 = table.Column<string>(unicode: false, maxLength: 13, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("POS_DEL_P01", x => new { x.F01, x.F1000 });
                });

            migrationBuilder.CreateTable(
                name: "POS_TAB",
                columns: table => new
                {
                    F01 = table.Column<string>(unicode: false, maxLength: 13, nullable: false),
                    F1000 = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    F04 = table.Column<int>(nullable: true),
                    F383 = table.Column<string>(unicode: false, maxLength: 80, nullable: true),
                    F902 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F1001 = table.Column<int>(nullable: true),
                    F02 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F03 = table.Column<int>(nullable: true),
                    F05 = table.Column<int>(nullable: true),
                    F06 = table.Column<int>(nullable: true),
                    F07 = table.Column<int>(nullable: true),
                    F08 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F09 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F24 = table.Column<double>(nullable: true),
                    F40 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F50 = table.Column<decimal>(type: "money", nullable: true),
                    F60 = table.Column<decimal>(type: "money", nullable: true),
                    F61 = table.Column<decimal>(type: "money", nullable: true),
                    F66 = table.Column<int>(nullable: true),
                    F77 = table.Column<int>(nullable: true),
                    F78 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F79 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F80 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F81 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F82 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F83 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F84 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F85 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F86 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F87 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F88 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F92 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F96 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F97 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F98 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F99 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F100 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F101 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F102 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F104 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F106 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F107 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F108 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F110 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F114 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F115 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F121 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F123 = table.Column<string>(unicode: false, maxLength: 13, nullable: true),
                    F124 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F125 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F141 = table.Column<double>(nullable: true),
                    F149 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F150 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F153 = table.Column<int>(nullable: true),
                    F158 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F159 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F160 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F161 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F162 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F163 = table.Column<int>(nullable: true),
                    F170 = table.Column<int>(nullable: true),
                    F171 = table.Column<int>(nullable: true),
                    F172 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F173 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F174 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F176 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F178 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F188 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F189 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F209 = table.Column<double>(nullable: true),
                    F210 = table.Column<decimal>(type: "money", nullable: true),
                    F211 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F217 = table.Column<double>(nullable: true),
                    F253 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F302 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F303 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F304 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F306 = table.Column<double>(nullable: true),
                    F388 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F397 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F1099 = table.Column<int>(nullable: true),
                    F1120 = table.Column<string>(unicode: false, maxLength: 12, nullable: true),
                    F1124 = table.Column<double>(nullable: true),
                    F1136 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F1138 = table.Column<double>(nullable: true),
                    F1139 = table.Column<int>(nullable: true),
                    F1236 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F1237 = table.Column<double>(nullable: true),
                    F1735 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F1759 = table.Column<int>(nullable: true),
                    F1785 = table.Column<string>(unicode: false, maxLength: 12, nullable: true),
                    F1786 = table.Column<string>(unicode: false, maxLength: 12, nullable: true),
                    F1787 = table.Column<int>(nullable: true),
                    F1788 = table.Column<int>(nullable: true),
                    F1789 = table.Column<double>(nullable: true),
                    F1790 = table.Column<double>(nullable: true),
                    F1892 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F1926 = table.Column<double>(nullable: true),
                    F1929 = table.Column<int>(nullable: true),
                    F1933 = table.Column<decimal>(type: "money", nullable: true),
                    F1964 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F2119 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F2608 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F2660 = table.Column<string>(unicode: false, maxLength: 250, nullable: true),
                    F2930 = table.Column<string>(unicode: false, maxLength: 13, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("POS_TAB_P01", x => new { x.F01, x.F1000 });
                });

            migrationBuilder.CreateTable(
                name: "PRICE_DEL",
                columns: table => new
                {
                    F01 = table.Column<string>(unicode: false, maxLength: 13, nullable: false),
                    F1000 = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    F126 = table.Column<int>(nullable: false),
                    F32 = table.Column<int>(nullable: true),
                    F902 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F1001 = table.Column<int>(nullable: true),
                    F1014 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F07 = table.Column<int>(nullable: true),
                    F21 = table.Column<double>(nullable: true),
                    F30 = table.Column<decimal>(type: "money", nullable: true),
                    F31 = table.Column<double>(nullable: true),
                    F33 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F34 = table.Column<string>(unicode: false, maxLength: 2, nullable: true),
                    F35 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F36 = table.Column<string>(unicode: false, maxLength: 6, nullable: true),
                    F37 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F41 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F42 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F43 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F49 = table.Column<double>(nullable: true),
                    F59 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F62 = table.Column<double>(nullable: true),
                    F63 = table.Column<decimal>(type: "money", nullable: true),
                    F109 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F111 = table.Column<decimal>(type: "money", nullable: true),
                    F112 = table.Column<double>(nullable: true),
                    F113 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F119 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F122 = table.Column<string>(unicode: false, maxLength: 13, nullable: true),
                    F129 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F130 = table.Column<string>(unicode: false, maxLength: 6, nullable: true),
                    F133 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F135 = table.Column<double>(nullable: true),
                    F136 = table.Column<decimal>(type: "money", nullable: true),
                    F137 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F138 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F139 = table.Column<decimal>(type: "money", nullable: true),
                    F140 = table.Column<decimal>(type: "money", nullable: true),
                    F142 = table.Column<double>(nullable: true),
                    F143 = table.Column<double>(nullable: true),
                    F144 = table.Column<string>(unicode: false, maxLength: 6, nullable: true),
                    F145 = table.Column<string>(unicode: false, maxLength: 6, nullable: true),
                    F146 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F147 = table.Column<double>(nullable: true),
                    F148 = table.Column<decimal>(type: "money", nullable: true),
                    F164 = table.Column<string>(unicode: false, maxLength: 13, nullable: true),
                    F166 = table.Column<decimal>(type: "money", nullable: true),
                    F167 = table.Column<double>(nullable: true),
                    F168 = table.Column<decimal>(type: "money", nullable: true),
                    F169 = table.Column<int>(nullable: true),
                    F175 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F177 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F179 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F181 = table.Column<decimal>(type: "money", nullable: true),
                    F182 = table.Column<double>(nullable: true),
                    F183 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F184 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F205 = table.Column<decimal>(type: "money", nullable: true),
                    F221 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F232 = table.Column<double>(nullable: true),
                    F253 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F903 = table.Column<string>(unicode: false, maxLength: 16, nullable: true),
                    F1005 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F1006 = table.Column<double>(nullable: true),
                    F1007 = table.Column<decimal>(type: "money", nullable: true),
                    F1008 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F1009 = table.Column<string>(unicode: false, maxLength: 6, nullable: true),
                    F1010 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F1011 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F1012 = table.Column<double>(nullable: true),
                    F1013 = table.Column<decimal>(type: "money", nullable: true),
                    F1015 = table.Column<string>(unicode: false, maxLength: 6, nullable: true),
                    F1133 = table.Column<decimal>(type: "money", nullable: true),
                    F1134 = table.Column<double>(nullable: true),
                    F1135 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F1186 = table.Column<decimal>(type: "money", nullable: true),
                    F1187 = table.Column<double>(nullable: true),
                    F1188 = table.Column<decimal>(type: "money", nullable: true),
                    F1189 = table.Column<double>(nullable: true),
                    F1190 = table.Column<int>(nullable: true),
                    F1191 = table.Column<int>(nullable: true),
                    F1192 = table.Column<int>(nullable: true),
                    F1193 = table.Column<int>(nullable: true),
                    F1194 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F1195 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F1196 = table.Column<decimal>(type: "money", nullable: true),
                    F1197 = table.Column<double>(nullable: true),
                    F1198 = table.Column<decimal>(type: "money", nullable: true),
                    F1199 = table.Column<double>(nullable: true),
                    F1200 = table.Column<int>(nullable: true),
                    F1201 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F1202 = table.Column<int>(nullable: true),
                    F1203 = table.Column<decimal>(type: "money", nullable: true),
                    F1204 = table.Column<double>(nullable: true),
                    F1205 = table.Column<decimal>(type: "money", nullable: true),
                    F1206 = table.Column<double>(nullable: true),
                    F1207 = table.Column<int>(nullable: true),
                    F1208 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F1209 = table.Column<int>(nullable: true),
                    F1210 = table.Column<decimal>(type: "money", nullable: true),
                    F1211 = table.Column<double>(nullable: true),
                    F1212 = table.Column<decimal>(type: "money", nullable: true),
                    F1213 = table.Column<double>(nullable: true),
                    F1214 = table.Column<int>(nullable: true),
                    F1215 = table.Column<int>(nullable: true),
                    F1216 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F1217 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F1218 = table.Column<decimal>(type: "money", nullable: true),
                    F1219 = table.Column<double>(nullable: true),
                    F1220 = table.Column<decimal>(type: "money", nullable: true),
                    F1221 = table.Column<double>(nullable: true),
                    F1222 = table.Column<decimal>(type: "money", nullable: true),
                    F1223 = table.Column<double>(nullable: true),
                    F1224 = table.Column<decimal>(type: "money", nullable: true),
                    F1225 = table.Column<double>(nullable: true),
                    F1226 = table.Column<decimal>(type: "money", nullable: true),
                    F1227 = table.Column<double>(nullable: true),
                    F1228 = table.Column<int>(nullable: true),
                    F1229 = table.Column<decimal>(type: "money", nullable: true),
                    F1230 = table.Column<int>(nullable: true),
                    F1231 = table.Column<decimal>(type: "money", nullable: true),
                    F1232 = table.Column<int>(nullable: true),
                    F1233 = table.Column<decimal>(type: "money", nullable: true),
                    F1234 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F1235 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F1713 = table.Column<double>(nullable: true),
                    F1714 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F1759 = table.Column<int>(nullable: true),
                    F1767 = table.Column<double>(nullable: true),
                    F1768 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F1769 = table.Column<double>(nullable: true),
                    F1770 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F1799 = table.Column<string>(unicode: false, maxLength: 12, nullable: true),
                    F1800 = table.Column<string>(unicode: false, maxLength: 12, nullable: true),
                    F1801 = table.Column<int>(nullable: true),
                    F1802 = table.Column<int>(nullable: true),
                    F1803 = table.Column<double>(nullable: true),
                    F1804 = table.Column<double>(nullable: true),
                    F1805 = table.Column<decimal>(type: "money", nullable: true),
                    F1806 = table.Column<decimal>(type: "money", nullable: true),
                    F1885 = table.Column<decimal>(type: "money", nullable: true),
                    F1927 = table.Column<double>(nullable: true),
                    F1928 = table.Column<double>(nullable: true),
                    F1930 = table.Column<int>(nullable: true),
                    F1934 = table.Column<decimal>(type: "money", nullable: true),
                    F1935 = table.Column<decimal>(type: "money", nullable: true),
                    F1964 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F2119 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F2569 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F2570 = table.Column<double>(nullable: true),
                    F2571 = table.Column<decimal>(type: "money", nullable: true),
                    F2572 = table.Column<double>(nullable: true),
                    F2573 = table.Column<decimal>(type: "money", nullable: true),
                    F2574 = table.Column<double>(nullable: true),
                    F2575 = table.Column<int>(nullable: true),
                    F2576 = table.Column<int>(nullable: true),
                    F2577 = table.Column<decimal>(type: "money", nullable: true),
                    F2578 = table.Column<double>(nullable: true),
                    F2579 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F2580 = table.Column<int>(nullable: true),
                    F2667 = table.Column<string>(unicode: false, maxLength: 12, nullable: true),
                    F2668 = table.Column<string>(unicode: false, maxLength: 12, nullable: true),
                    F2694 = table.Column<string>(unicode: false, maxLength: 12, nullable: true),
                    F2695 = table.Column<string>(unicode: false, maxLength: 12, nullable: true),
                    F2696 = table.Column<string>(unicode: false, maxLength: 12, nullable: true),
                    F2744 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F2955 = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRICE_DEL_P01", x => new { x.F01, x.F1000, x.F126 });
                });

            migrationBuilder.CreateTable(
                name: "PRICE_TAB",
                columns: table => new
                {
                    F01 = table.Column<string>(unicode: false, maxLength: 13, nullable: false),
                    F1000 = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    F126 = table.Column<int>(nullable: false),
                    F32 = table.Column<int>(nullable: true),
                    F902 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F1001 = table.Column<int>(nullable: true),
                    F1014 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F07 = table.Column<int>(nullable: true),
                    F21 = table.Column<double>(nullable: true),
                    F30 = table.Column<decimal>(type: "money", nullable: true),
                    F31 = table.Column<double>(nullable: true),
                    F33 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F34 = table.Column<string>(unicode: false, maxLength: 2, nullable: true),
                    F35 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F36 = table.Column<string>(unicode: false, maxLength: 6, nullable: true),
                    F37 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F41 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F42 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F43 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F49 = table.Column<double>(nullable: true),
                    F59 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F62 = table.Column<double>(nullable: true),
                    F63 = table.Column<decimal>(type: "money", nullable: true),
                    F109 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F111 = table.Column<decimal>(type: "money", nullable: true),
                    F112 = table.Column<double>(nullable: true),
                    F113 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F119 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F122 = table.Column<string>(unicode: false, maxLength: 13, nullable: true),
                    F129 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F130 = table.Column<string>(unicode: false, maxLength: 6, nullable: true),
                    F133 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F135 = table.Column<double>(nullable: true),
                    F136 = table.Column<decimal>(type: "money", nullable: true),
                    F137 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F138 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F139 = table.Column<decimal>(type: "money", nullable: true),
                    F140 = table.Column<decimal>(type: "money", nullable: true),
                    F142 = table.Column<double>(nullable: true),
                    F143 = table.Column<double>(nullable: true),
                    F144 = table.Column<string>(unicode: false, maxLength: 6, nullable: true),
                    F145 = table.Column<string>(unicode: false, maxLength: 6, nullable: true),
                    F146 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F147 = table.Column<double>(nullable: true),
                    F148 = table.Column<decimal>(type: "money", nullable: true),
                    F164 = table.Column<string>(unicode: false, maxLength: 13, nullable: true),
                    F166 = table.Column<decimal>(type: "money", nullable: true),
                    F167 = table.Column<double>(nullable: true),
                    F168 = table.Column<decimal>(type: "money", nullable: true),
                    F169 = table.Column<int>(nullable: true),
                    F175 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F177 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F179 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F181 = table.Column<decimal>(type: "money", nullable: true),
                    F182 = table.Column<double>(nullable: true),
                    F183 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F184 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F205 = table.Column<decimal>(type: "money", nullable: true),
                    F221 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F232 = table.Column<double>(nullable: true),
                    F253 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F903 = table.Column<string>(unicode: false, maxLength: 16, nullable: true),
                    F1005 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F1006 = table.Column<double>(nullable: true),
                    F1007 = table.Column<decimal>(type: "money", nullable: true),
                    F1008 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F1009 = table.Column<string>(unicode: false, maxLength: 6, nullable: true),
                    F1010 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F1011 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F1012 = table.Column<double>(nullable: true),
                    F1013 = table.Column<decimal>(type: "money", nullable: true),
                    F1015 = table.Column<string>(unicode: false, maxLength: 6, nullable: true),
                    F1133 = table.Column<decimal>(type: "money", nullable: true),
                    F1134 = table.Column<double>(nullable: true),
                    F1135 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F1186 = table.Column<decimal>(type: "money", nullable: true),
                    F1187 = table.Column<double>(nullable: true),
                    F1188 = table.Column<decimal>(type: "money", nullable: true),
                    F1189 = table.Column<double>(nullable: true),
                    F1190 = table.Column<int>(nullable: true),
                    F1191 = table.Column<int>(nullable: true),
                    F1192 = table.Column<int>(nullable: true),
                    F1193 = table.Column<int>(nullable: true),
                    F1194 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F1195 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F1196 = table.Column<decimal>(type: "money", nullable: true),
                    F1197 = table.Column<double>(nullable: true),
                    F1198 = table.Column<decimal>(type: "money", nullable: true),
                    F1199 = table.Column<double>(nullable: true),
                    F1200 = table.Column<int>(nullable: true),
                    F1201 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F1202 = table.Column<int>(nullable: true),
                    F1203 = table.Column<decimal>(type: "money", nullable: true),
                    F1204 = table.Column<double>(nullable: true),
                    F1205 = table.Column<decimal>(type: "money", nullable: true),
                    F1206 = table.Column<double>(nullable: true),
                    F1207 = table.Column<int>(nullable: true),
                    F1208 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F1209 = table.Column<int>(nullable: true),
                    F1210 = table.Column<decimal>(type: "money", nullable: true),
                    F1211 = table.Column<double>(nullable: true),
                    F1212 = table.Column<decimal>(type: "money", nullable: true),
                    F1213 = table.Column<double>(nullable: true),
                    F1214 = table.Column<int>(nullable: true),
                    F1215 = table.Column<int>(nullable: true),
                    F1216 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F1217 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F1218 = table.Column<decimal>(type: "money", nullable: true),
                    F1219 = table.Column<double>(nullable: true),
                    F1220 = table.Column<decimal>(type: "money", nullable: true),
                    F1221 = table.Column<double>(nullable: true),
                    F1222 = table.Column<decimal>(type: "money", nullable: true),
                    F1223 = table.Column<double>(nullable: true),
                    F1224 = table.Column<decimal>(type: "money", nullable: true),
                    F1225 = table.Column<double>(nullable: true),
                    F1226 = table.Column<decimal>(type: "money", nullable: true),
                    F1227 = table.Column<double>(nullable: true),
                    F1228 = table.Column<int>(nullable: true),
                    F1229 = table.Column<decimal>(type: "money", nullable: true),
                    F1230 = table.Column<int>(nullable: true),
                    F1231 = table.Column<decimal>(type: "money", nullable: true),
                    F1232 = table.Column<int>(nullable: true),
                    F1233 = table.Column<decimal>(type: "money", nullable: true),
                    F1234 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F1235 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F1713 = table.Column<double>(nullable: true),
                    F1714 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F1759 = table.Column<int>(nullable: true),
                    F1767 = table.Column<double>(nullable: true),
                    F1768 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F1769 = table.Column<double>(nullable: true),
                    F1770 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F1799 = table.Column<string>(unicode: false, maxLength: 12, nullable: true),
                    F1800 = table.Column<string>(unicode: false, maxLength: 12, nullable: true),
                    F1801 = table.Column<int>(nullable: true),
                    F1802 = table.Column<int>(nullable: true),
                    F1803 = table.Column<double>(nullable: true),
                    F1804 = table.Column<double>(nullable: true),
                    F1805 = table.Column<decimal>(type: "money", nullable: true),
                    F1806 = table.Column<decimal>(type: "money", nullable: true),
                    F1885 = table.Column<decimal>(type: "money", nullable: true),
                    F1927 = table.Column<double>(nullable: true),
                    F1928 = table.Column<double>(nullable: true),
                    F1930 = table.Column<int>(nullable: true),
                    F1934 = table.Column<decimal>(type: "money", nullable: true),
                    F1935 = table.Column<decimal>(type: "money", nullable: true),
                    F1964 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F2119 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F2569 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F2570 = table.Column<double>(nullable: true),
                    F2571 = table.Column<decimal>(type: "money", nullable: true),
                    F2572 = table.Column<double>(nullable: true),
                    F2573 = table.Column<decimal>(type: "money", nullable: true),
                    F2574 = table.Column<double>(nullable: true),
                    F2575 = table.Column<int>(nullable: true),
                    F2576 = table.Column<int>(nullable: true),
                    F2577 = table.Column<decimal>(type: "money", nullable: true),
                    F2578 = table.Column<double>(nullable: true),
                    F2579 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F2580 = table.Column<int>(nullable: true),
                    F2667 = table.Column<string>(unicode: false, maxLength: 12, nullable: true),
                    F2668 = table.Column<string>(unicode: false, maxLength: 12, nullable: true),
                    F2694 = table.Column<string>(unicode: false, maxLength: 12, nullable: true),
                    F2695 = table.Column<string>(unicode: false, maxLength: 12, nullable: true),
                    F2696 = table.Column<string>(unicode: false, maxLength: 12, nullable: true),
                    F2744 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F2955 = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRICE_TAB_P01", x => new { x.F01, x.F1000, x.F126 });
                });

            migrationBuilder.CreateTable(
                name: "PROFILE_TAB",
                columns: table => new
                {
                    F1000 = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    F2669 = table.Column<string>(unicode: false, maxLength: 40, nullable: false),
                    F2687 = table.Column<string>(unicode: false, maxLength: 60, nullable: false),
                    F2670 = table.Column<string>(unicode: false, maxLength: 250, nullable: false),
                    F2671 = table.Column<string>(unicode: false, nullable: true),
                    F2672 = table.Column<string>(unicode: false, maxLength: 250, nullable: true),
                    F2673 = table.Column<string>(unicode: false, maxLength: 250, nullable: true),
                    F2674 = table.Column<string>(unicode: false, maxLength: 250, nullable: true),
                    F2675 = table.Column<string>(unicode: false, maxLength: 250, nullable: true),
                    F2676 = table.Column<string>(unicode: false, maxLength: 250, nullable: true),
                    F2677 = table.Column<string>(unicode: false, maxLength: 250, nullable: true),
                    F2678 = table.Column<string>(unicode: false, maxLength: 250, nullable: true),
                    F2679 = table.Column<string>(unicode: false, maxLength: 250, nullable: true),
                    F2680 = table.Column<string>(unicode: false, maxLength: 250, nullable: true),
                    F2681 = table.Column<string>(unicode: false, maxLength: 250, nullable: true),
                    F2682 = table.Column<string>(unicode: false, maxLength: 250, nullable: true),
                    F2683 = table.Column<string>(unicode: false, maxLength: 250, nullable: true),
                    F2684 = table.Column<string>(unicode: false, maxLength: 250, nullable: true),
                    F2685 = table.Column<string>(unicode: false, maxLength: 250, nullable: true),
                    F2686 = table.Column<string>(unicode: false, maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PROFILE_TAB_P1000", x => new { x.F1000, x.F2669, x.F2687, x.F2670 });
                });

            migrationBuilder.CreateTable(
                name: "PUB_TAB",
                columns: table => new
                {
                    F1912 = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
                    F1000 = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    F01 = table.Column<string>(unicode: false, maxLength: 13, nullable: true),
                    F253 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F1001 = table.Column<int>(nullable: true),
                    F1033 = table.Column<string>(unicode: false, maxLength: 3, nullable: true),
                    F1759 = table.Column<int>(nullable: true),
                    F1913 = table.Column<int>(nullable: true),
                    F1914 = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    F1915 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    F1916 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F1917 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F1964 = table.Column<string>(unicode: false, maxLength: 4, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PUB_TAB_P1912", x => new { x.F1912, x.F1000 });
                });

            migrationBuilder.CreateTable(
                name: "RB_FIELDS",
                columns: table => new
                {
                    F1452 = table.Column<string>(unicode: false, maxLength: 60, nullable: false),
                    F1453 = table.Column<string>(unicode: false, maxLength: 60, nullable: false),
                    F1454 = table.Column<string>(unicode: false, maxLength: 60, nullable: true),
                    F1455 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F1456 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F1457 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F1458 = table.Column<string>(unicode: false, maxLength: 60, nullable: true),
                    F1459 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F1460 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F2595 = table.Column<string>(unicode: false, maxLength: 40, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("RB_FIELDS_P1452", x => new { x.F1452, x.F1453 });
                });

            migrationBuilder.CreateTable(
                name: "RB_JOINS",
                columns: table => new
                {
                    F1461 = table.Column<string>(unicode: false, maxLength: 60, nullable: false),
                    F1462 = table.Column<string>(unicode: false, maxLength: 60, nullable: false),
                    F1463 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    F1464 = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    F1465 = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    F1466 = table.Column<string>(unicode: false, maxLength: 60, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("RB_JOINS_P1461", x => new { x.F1461, x.F1462 });
                });

            migrationBuilder.CreateTable(
                name: "RB_TABLES",
                columns: table => new
                {
                    F1452 = table.Column<string>(unicode: false, maxLength: 60, nullable: false),
                    F1451 = table.Column<string>(unicode: false, maxLength: 60, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("RB_TABLES_P1452", x => x.F1452);
                });

            migrationBuilder.CreateTable(
                name: "RCP_DET_TAB",
                columns: table => new
                {
                    F2907 = table.Column<string>(unicode: false, maxLength: 13, nullable: false),
                    F01 = table.Column<string>(unicode: false, maxLength: 13, nullable: true),
                    F2909 = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    F2910 = table.Column<string>(unicode: false, maxLength: 8000, nullable: true),
                    F2911 = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    F2912 = table.Column<string>(unicode: false, maxLength: 8000, nullable: true),
                    F2913 = table.Column<string>(unicode: false, maxLength: 4000, nullable: true),
                    F2914 = table.Column<string>(unicode: false, maxLength: 1000, nullable: true),
                    F2915 = table.Column<string>(unicode: false, maxLength: 400, nullable: true),
                    F2916 = table.Column<string>(unicode: false, maxLength: 400, nullable: true),
                    F2917 = table.Column<string>(unicode: false, maxLength: 400, nullable: true),
                    F2918 = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    F2919 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F2922 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    F2923 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    F2924 = table.Column<string>(unicode: false, maxLength: 60, nullable: true),
                    F2925 = table.Column<string>(unicode: false, maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("RCP_DET_TAB_P2907", x => x.F2907);
                });

            migrationBuilder.CreateTable(
                name: "RCP_ITM_TAB",
                columns: table => new
                {
                    F2907 = table.Column<string>(unicode: false, maxLength: 13, nullable: false),
                    F2908 = table.Column<int>(nullable: false),
                    F01 = table.Column<string>(unicode: false, maxLength: 13, nullable: true),
                    F2920 = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    F2921 = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("RCP_ITM_TAB_P2907", x => new { x.F2907, x.F2908 });
                });

            migrationBuilder.CreateTable(
                name: "RCP_TAB",
                columns: table => new
                {
                    F01 = table.Column<string>(unicode: false, maxLength: 13, nullable: false),
                    F2784 = table.Column<string>(unicode: false, maxLength: 13, nullable: false),
                    F2785 = table.Column<double>(nullable: true),
                    F2788 = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("RCP_TAB_P01", x => new { x.F01, x.F2784 });
                });

            migrationBuilder.CreateTable(
                name: "REASON_TAB",
                columns: table => new
                {
                    F2772 = table.Column<int>(nullable: false),
                    F1000 = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    F1511 = table.Column<int>(nullable: true),
                    F2773 = table.Column<string>(unicode: false, maxLength: 40, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("REASON_TAB_P2772", x => x.F2772);
                });

            migrationBuilder.CreateTable(
                name: "REBATE_BAT",
                columns: table => new
                {
                    F01 = table.Column<string>(unicode: false, maxLength: 13, nullable: false),
                    F902 = table.Column<string>(unicode: false, maxLength: 8, nullable: false),
                    F1000 = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    F27 = table.Column<string>(unicode: false, maxLength: 14, nullable: false),
                    F1184 = table.Column<string>(unicode: false, maxLength: 12, nullable: false),
                    F07 = table.Column<int>(nullable: true),
                    F233 = table.Column<decimal>(type: "money", nullable: true),
                    F234 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F235 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F236 = table.Column<string>(unicode: false, maxLength: 12, nullable: true),
                    F237 = table.Column<double>(nullable: true),
                    F1001 = table.Column<int>(nullable: true),
                    F1660 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F1974 = table.Column<string>(unicode: false, maxLength: 120, nullable: true),
                    F1979 = table.Column<double>(nullable: true),
                    F2567 = table.Column<double>(nullable: true),
                    F2592 = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("REBATE_BAT_P01", x => new { x.F01, x.F902, x.F1000, x.F27, x.F1184 });
                });

            migrationBuilder.CreateTable(
                name: "REC_BAT",
                columns: table => new
                {
                    F1032 = table.Column<int>(nullable: false),
                    F27 = table.Column<string>(unicode: false, maxLength: 14, nullable: true),
                    F76 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F91 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    F253 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F254 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F334 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F335 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F336 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F337 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F338 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F339 = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    F340 = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    F341 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    F342 = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    F343 = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    F344 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    F345 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    F346 = table.Column<double>(nullable: true),
                    F347 = table.Column<double>(nullable: true),
                    F348 = table.Column<int>(nullable: true),
                    F349 = table.Column<double>(nullable: true),
                    F352 = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    F902 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F1035 = table.Column<string>(unicode: false, maxLength: 6, nullable: true),
                    F1036 = table.Column<string>(unicode: false, maxLength: 6, nullable: true),
                    F1056 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F1057 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F1067 = table.Column<string>(unicode: false, maxLength: 7, nullable: true),
                    F1068 = table.Column<string>(unicode: false, maxLength: 6, nullable: true),
                    F1101 = table.Column<int>(nullable: true),
                    F1126 = table.Column<int>(nullable: true),
                    F1127 = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    F1148 = table.Column<string>(unicode: false, maxLength: 14, nullable: true),
                    F1168 = table.Column<int>(nullable: true),
                    F1245 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    F1246 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F1254 = table.Column<string>(unicode: false, maxLength: 5000, nullable: true),
                    F1255 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F1264 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F1642 = table.Column<string>(unicode: false, maxLength: 14, nullable: true),
                    F1643 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F1644 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F1645 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F1646 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F1647 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F1648 = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    F1649 = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    F1650 = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    F1651 = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    F1652 = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    F1653 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F1654 = table.Column<double>(nullable: true),
                    F1655 = table.Column<double>(nullable: true),
                    F1656 = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    F1685 = table.Column<int>(nullable: true),
                    F1686 = table.Column<int>(nullable: true),
                    F1687 = table.Column<int>(nullable: true),
                    F1688 = table.Column<int>(nullable: true),
                    F1689 = table.Column<int>(nullable: true),
                    F1692 = table.Column<string>(unicode: false, maxLength: 160, nullable: true),
                    F1693 = table.Column<int>(nullable: true),
                    F1694 = table.Column<int>(nullable: true),
                    F1695 = table.Column<int>(nullable: true),
                    F1696 = table.Column<int>(nullable: true),
                    F1760 = table.Column<double>(nullable: true),
                    F1761 = table.Column<double>(nullable: true),
                    F1793 = table.Column<int>(nullable: true),
                    F1883 = table.Column<double>(nullable: true),
                    F1884 = table.Column<decimal>(type: "money", nullable: true),
                    F1887 = table.Column<string>(unicode: false, maxLength: 2, nullable: true),
                    F1889 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F1890 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    F2596 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F2598 = table.Column<double>(nullable: true),
                    F2599 = table.Column<double>(nullable: true),
                    F2630 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F2631 = table.Column<int>(nullable: true),
                    F2632 = table.Column<int>(nullable: true),
                    F2633 = table.Column<double>(nullable: true),
                    F2634 = table.Column<double>(nullable: true),
                    F2635 = table.Column<decimal>(type: "money", nullable: true),
                    F2636 = table.Column<decimal>(type: "money", nullable: true),
                    F2655 = table.Column<string>(unicode: false, maxLength: 6, nullable: true),
                    F2656 = table.Column<string>(unicode: false, maxLength: 6, nullable: true),
                    F2657 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F2658 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F2659 = table.Column<string>(unicode: false, maxLength: 6, nullable: true),
                    F2710 = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    F2848 = table.Column<string>(unicode: false, maxLength: 5000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("REC_BAT_P1032", x => x.F1032);
                });

            migrationBuilder.CreateTable(
                name: "REC_HDR",
                columns: table => new
                {
                    F1032 = table.Column<int>(nullable: false),
                    F27 = table.Column<string>(unicode: false, maxLength: 14, nullable: true),
                    F76 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F91 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    F253 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F254 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F334 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F335 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F336 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F337 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F338 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F339 = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    F340 = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    F341 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    F342 = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    F343 = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    F344 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    F345 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    F346 = table.Column<double>(nullable: true),
                    F347 = table.Column<double>(nullable: true),
                    F348 = table.Column<int>(nullable: true),
                    F349 = table.Column<double>(nullable: true),
                    F352 = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    F902 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F1035 = table.Column<string>(unicode: false, maxLength: 6, nullable: true),
                    F1036 = table.Column<string>(unicode: false, maxLength: 6, nullable: true),
                    F1056 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F1057 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F1067 = table.Column<string>(unicode: false, maxLength: 7, nullable: true),
                    F1068 = table.Column<string>(unicode: false, maxLength: 6, nullable: true),
                    F1101 = table.Column<int>(nullable: true),
                    F1126 = table.Column<int>(nullable: true),
                    F1127 = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    F1148 = table.Column<string>(unicode: false, maxLength: 14, nullable: true),
                    F1168 = table.Column<int>(nullable: true),
                    F1245 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    F1246 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F1254 = table.Column<string>(unicode: false, maxLength: 5000, nullable: true),
                    F1255 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F1264 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F1642 = table.Column<string>(unicode: false, maxLength: 14, nullable: true),
                    F1643 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F1644 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F1645 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F1646 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F1647 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F1648 = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    F1649 = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    F1650 = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    F1651 = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    F1652 = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    F1653 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F1654 = table.Column<double>(nullable: true),
                    F1655 = table.Column<double>(nullable: true),
                    F1656 = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    F1685 = table.Column<int>(nullable: true),
                    F1686 = table.Column<int>(nullable: true),
                    F1687 = table.Column<int>(nullable: true),
                    F1688 = table.Column<int>(nullable: true),
                    F1689 = table.Column<int>(nullable: true),
                    F1692 = table.Column<string>(unicode: false, maxLength: 160, nullable: true),
                    F1693 = table.Column<int>(nullable: true),
                    F1694 = table.Column<int>(nullable: true),
                    F1695 = table.Column<int>(nullable: true),
                    F1696 = table.Column<int>(nullable: true),
                    F1760 = table.Column<double>(nullable: true),
                    F1761 = table.Column<double>(nullable: true),
                    F1793 = table.Column<int>(nullable: true),
                    F1883 = table.Column<double>(nullable: true),
                    F1884 = table.Column<decimal>(type: "money", nullable: true),
                    F1887 = table.Column<string>(unicode: false, maxLength: 2, nullable: true),
                    F1889 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F1890 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    F2596 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F2598 = table.Column<double>(nullable: true),
                    F2599 = table.Column<double>(nullable: true),
                    F2630 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F2631 = table.Column<int>(nullable: true),
                    F2632 = table.Column<int>(nullable: true),
                    F2633 = table.Column<double>(nullable: true),
                    F2634 = table.Column<double>(nullable: true),
                    F2635 = table.Column<decimal>(type: "money", nullable: true),
                    F2636 = table.Column<decimal>(type: "money", nullable: true),
                    F2655 = table.Column<string>(unicode: false, maxLength: 6, nullable: true),
                    F2656 = table.Column<string>(unicode: false, maxLength: 6, nullable: true),
                    F2657 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F2658 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F2659 = table.Column<string>(unicode: false, maxLength: 6, nullable: true),
                    F2710 = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    F2848 = table.Column<string>(unicode: false, maxLength: 5000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("REC_HDR_P1032", x => x.F1032);
                });

            migrationBuilder.CreateTable(
                name: "REC_HDR_SAV",
                columns: table => new
                {
                    F1505 = table.Column<DateTime>(type: "datetime", nullable: false),
                    F1056 = table.Column<string>(unicode: false, maxLength: 4, nullable: false),
                    F1057 = table.Column<string>(unicode: false, maxLength: 4, nullable: false),
                    F1032 = table.Column<int>(nullable: false),
                    F2890 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F27 = table.Column<string>(unicode: false, maxLength: 14, nullable: true),
                    F76 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F91 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    F253 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F254 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F334 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F335 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F336 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F337 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F338 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F339 = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    F340 = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    F341 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    F342 = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    F343 = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    F344 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    F345 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    F346 = table.Column<decimal>(type: "numeric(20, 4)", nullable: true),
                    F347 = table.Column<decimal>(type: "numeric(20, 4)", nullable: true),
                    F348 = table.Column<int>(nullable: true),
                    F349 = table.Column<decimal>(type: "numeric(20, 4)", nullable: true),
                    F352 = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    F902 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F1035 = table.Column<string>(unicode: false, maxLength: 6, nullable: true),
                    F1036 = table.Column<string>(unicode: false, maxLength: 6, nullable: true),
                    F1067 = table.Column<string>(unicode: false, maxLength: 7, nullable: true),
                    F1068 = table.Column<string>(unicode: false, maxLength: 6, nullable: true),
                    F1101 = table.Column<int>(nullable: true),
                    F1126 = table.Column<int>(nullable: true),
                    F1127 = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    F1148 = table.Column<string>(unicode: false, maxLength: 14, nullable: true),
                    F1168 = table.Column<int>(nullable: true),
                    F1245 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    F1246 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F1254 = table.Column<string>(unicode: false, maxLength: 5000, nullable: true),
                    F1255 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F1264 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F1642 = table.Column<string>(unicode: false, maxLength: 14, nullable: true),
                    F1643 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F1644 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F1645 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F1646 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F1647 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F1648 = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    F1649 = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    F1650 = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    F1651 = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    F1652 = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    F1653 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F1654 = table.Column<decimal>(type: "numeric(20, 4)", nullable: true),
                    F1655 = table.Column<decimal>(type: "numeric(20, 4)", nullable: true),
                    F1656 = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    F1685 = table.Column<int>(nullable: true),
                    F1686 = table.Column<int>(nullable: true),
                    F1687 = table.Column<int>(nullable: true),
                    F1688 = table.Column<int>(nullable: true),
                    F1689 = table.Column<int>(nullable: true),
                    F1692 = table.Column<string>(unicode: false, maxLength: 160, nullable: true),
                    F1693 = table.Column<int>(nullable: true),
                    F1694 = table.Column<int>(nullable: true),
                    F1695 = table.Column<int>(nullable: true),
                    F1696 = table.Column<int>(nullable: true),
                    F1760 = table.Column<decimal>(type: "numeric(20, 4)", nullable: true),
                    F1761 = table.Column<decimal>(type: "numeric(20, 4)", nullable: true),
                    F1793 = table.Column<int>(nullable: true),
                    F1883 = table.Column<decimal>(type: "numeric(20, 4)", nullable: true),
                    F1884 = table.Column<decimal>(type: "money", nullable: true),
                    F1887 = table.Column<string>(unicode: false, maxLength: 2, nullable: true),
                    F1889 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F1890 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    F2596 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F2598 = table.Column<decimal>(type: "numeric(20, 4)", nullable: true),
                    F2599 = table.Column<decimal>(type: "numeric(20, 4)", nullable: true),
                    F2630 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F2631 = table.Column<int>(nullable: true),
                    F2632 = table.Column<int>(nullable: true),
                    F2633 = table.Column<decimal>(type: "numeric(20, 4)", nullable: true),
                    F2634 = table.Column<decimal>(type: "numeric(20, 4)", nullable: true),
                    F2635 = table.Column<decimal>(type: "money", nullable: true),
                    F2636 = table.Column<decimal>(type: "money", nullable: true),
                    F2655 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F2656 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F2657 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F2658 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F2659 = table.Column<string>(unicode: false, maxLength: 6, nullable: true),
                    F2710 = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    F2848 = table.Column<string>(unicode: false, maxLength: 5000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("REC_HDR_SAV_P1032", x => new { x.F1505, x.F1056, x.F1057, x.F1032 });
                });

            migrationBuilder.CreateTable(
                name: "REC_REG",
                columns: table => new
                {
                    F1032 = table.Column<int>(nullable: false),
                    F1101 = table.Column<int>(nullable: false),
                    F01 = table.Column<string>(unicode: false, maxLength: 13, nullable: true),
                    F03 = table.Column<int>(nullable: true),
                    F04 = table.Column<int>(nullable: true),
                    F05 = table.Column<int>(nullable: true),
                    F08 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F19 = table.Column<double>(nullable: true),
                    F20 = table.Column<double>(nullable: true),
                    F26 = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    F38 = table.Column<decimal>(type: "money", nullable: true),
                    F50 = table.Column<decimal>(type: "money", nullable: true),
                    F64 = table.Column<double>(nullable: true),
                    F65 = table.Column<decimal>(type: "money", nullable: true),
                    F67 = table.Column<double>(nullable: true),
                    F70 = table.Column<double>(nullable: true),
                    F75 = table.Column<double>(nullable: true),
                    F76 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F81 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F82 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F90 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F92 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F96 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F97 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F98 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F99 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F100 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F101 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F120 = table.Column<decimal>(type: "money", nullable: true),
                    F131 = table.Column<int>(nullable: true),
                    F151 = table.Column<decimal>(type: "money", nullable: true),
                    F156 = table.Column<string>(unicode: false, maxLength: 120, nullable: true),
                    F186 = table.Column<decimal>(type: "money", nullable: true),
                    F201 = table.Column<decimal>(type: "money", nullable: true),
                    F202 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F203 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F204 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F219 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F220 = table.Column<string>(unicode: false, maxLength: 13, nullable: true),
                    F222 = table.Column<string>(unicode: false, maxLength: 12, nullable: true),
                    F223 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F224 = table.Column<double>(nullable: true),
                    F225 = table.Column<decimal>(type: "money", nullable: true),
                    F226 = table.Column<double>(nullable: true),
                    F227 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F228 = table.Column<double>(nullable: true),
                    F229 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F230 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F231 = table.Column<string>(unicode: false, maxLength: 12, nullable: true),
                    F233 = table.Column<decimal>(type: "money", nullable: true),
                    F234 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F235 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F236 = table.Column<string>(unicode: false, maxLength: 12, nullable: true),
                    F237 = table.Column<double>(nullable: true),
                    F253 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F254 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F270 = table.Column<double>(nullable: true),
                    F327 = table.Column<double>(nullable: true),
                    F328 = table.Column<double>(nullable: true),
                    F329 = table.Column<double>(nullable: true),
                    F1003 = table.Column<double>(nullable: true),
                    F1034 = table.Column<int>(nullable: true),
                    F1041 = table.Column<string>(unicode: false, maxLength: 60, nullable: true),
                    F1063 = table.Column<int>(nullable: true),
                    F1067 = table.Column<string>(unicode: false, maxLength: 7, nullable: true),
                    F1069 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F1070 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F1071 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F1079 = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    F1081 = table.Column<string>(unicode: false, maxLength: 5000, nullable: true),
                    F1086 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F1121 = table.Column<decimal>(type: "money", nullable: true),
                    F1122 = table.Column<double>(nullable: true),
                    F1140 = table.Column<decimal>(type: "money", nullable: true),
                    F1184 = table.Column<string>(unicode: false, maxLength: 12, nullable: true),
                    F1246 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F1247 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F1248 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F1249 = table.Column<decimal>(type: "money", nullable: true),
                    F1250 = table.Column<decimal>(type: "money", nullable: true),
                    F1251 = table.Column<decimal>(type: "money", nullable: true),
                    F1252 = table.Column<decimal>(type: "money", nullable: true),
                    F1266 = table.Column<double>(nullable: true),
                    F1267 = table.Column<double>(nullable: true),
                    F1595 = table.Column<decimal>(type: "money", nullable: true),
                    F1596 = table.Column<int>(nullable: true),
                    F1657 = table.Column<double>(nullable: true),
                    F1658 = table.Column<decimal>(type: "money", nullable: true),
                    F1659 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F1660 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F1661 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F1662 = table.Column<decimal>(type: "money", nullable: true),
                    F1663 = table.Column<double>(nullable: true),
                    F1664 = table.Column<decimal>(type: "money", nullable: true),
                    F1665 = table.Column<double>(nullable: true),
                    F1666 = table.Column<decimal>(type: "money", nullable: true),
                    F1667 = table.Column<double>(nullable: true),
                    F1668 = table.Column<string>(unicode: false, maxLength: 16, nullable: true),
                    F1669 = table.Column<decimal>(type: "money", nullable: true),
                    F1670 = table.Column<double>(nullable: true),
                    F1671 = table.Column<decimal>(type: "money", nullable: true),
                    F1672 = table.Column<decimal>(type: "money", nullable: true),
                    F1673 = table.Column<decimal>(type: "money", nullable: true),
                    F1674 = table.Column<decimal>(type: "money", nullable: true),
                    F1675 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F1676 = table.Column<decimal>(type: "money", nullable: true),
                    F1677 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F1678 = table.Column<decimal>(type: "money", nullable: true),
                    F1679 = table.Column<int>(nullable: true),
                    F1680 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F1681 = table.Column<decimal>(type: "money", nullable: true),
                    F1682 = table.Column<decimal>(type: "money", nullable: true),
                    F1683 = table.Column<double>(nullable: true),
                    F1684 = table.Column<double>(nullable: true),
                    F1685 = table.Column<int>(nullable: true),
                    F1687 = table.Column<int>(nullable: true),
                    F1691 = table.Column<string>(unicode: false, maxLength: 250, nullable: true),
                    F1732 = table.Column<double>(nullable: true),
                    F1771 = table.Column<decimal>(type: "money", nullable: true),
                    F1772 = table.Column<decimal>(type: "money", nullable: true),
                    F1773 = table.Column<decimal>(type: "money", nullable: true),
                    F1774 = table.Column<decimal>(type: "money", nullable: true),
                    F1775 = table.Column<decimal>(type: "money", nullable: true),
                    F1776 = table.Column<int>(nullable: true),
                    F1791 = table.Column<string>(unicode: false, maxLength: 12, nullable: true),
                    F1793 = table.Column<int>(nullable: true),
                    F1795 = table.Column<double>(nullable: true),
                    F1797 = table.Column<decimal>(type: "money", nullable: true),
                    F1815 = table.Column<decimal>(type: "money", nullable: true),
                    F1816 = table.Column<int>(nullable: true),
                    F1887 = table.Column<string>(unicode: false, maxLength: 2, nullable: true),
                    F1899 = table.Column<decimal>(type: "money", nullable: true),
                    F1918 = table.Column<double>(nullable: true),
                    F1919 = table.Column<double>(nullable: true),
                    F1920 = table.Column<double>(nullable: true),
                    F1973 = table.Column<string>(unicode: false, maxLength: 120, nullable: true),
                    F1974 = table.Column<string>(unicode: false, maxLength: 120, nullable: true),
                    F1975 = table.Column<string>(unicode: false, maxLength: 120, nullable: true),
                    F1976 = table.Column<string>(unicode: false, maxLength: 120, nullable: true),
                    F1977 = table.Column<double>(nullable: true),
                    F1978 = table.Column<double>(nullable: true),
                    F1979 = table.Column<double>(nullable: true),
                    F2551 = table.Column<decimal>(type: "money", nullable: true),
                    F2552 = table.Column<decimal>(type: "money", nullable: true),
                    F2553 = table.Column<decimal>(type: "money", nullable: true),
                    F2554 = table.Column<decimal>(type: "money", nullable: true),
                    F2555 = table.Column<decimal>(type: "money", nullable: true),
                    F2556 = table.Column<decimal>(type: "money", nullable: true),
                    F2557 = table.Column<decimal>(type: "money", nullable: true),
                    F2558 = table.Column<decimal>(type: "money", nullable: true),
                    F2559 = table.Column<decimal>(type: "money", nullable: true),
                    F2560 = table.Column<decimal>(type: "money", nullable: true),
                    F2561 = table.Column<decimal>(type: "money", nullable: true),
                    F2562 = table.Column<decimal>(type: "money", nullable: true),
                    F2563 = table.Column<decimal>(type: "money", nullable: true),
                    F2564 = table.Column<decimal>(type: "money", nullable: true),
                    F2565 = table.Column<decimal>(type: "money", nullable: true),
                    F2566 = table.Column<double>(nullable: true),
                    F2567 = table.Column<double>(nullable: true),
                    F2568 = table.Column<double>(nullable: true),
                    F2624 = table.Column<int>(nullable: true),
                    F2625 = table.Column<int>(nullable: true),
                    F2626 = table.Column<decimal>(type: "money", nullable: true),
                    F2627 = table.Column<decimal>(type: "money", nullable: true),
                    F2628 = table.Column<double>(nullable: true),
                    F2629 = table.Column<double>(nullable: true),
                    F2630 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F2631 = table.Column<int>(nullable: true),
                    F2660 = table.Column<string>(unicode: false, maxLength: 250, nullable: true),
                    F2666 = table.Column<double>(nullable: true),
                    F2709 = table.Column<decimal>(type: "money", nullable: true),
                    F2711 = table.Column<decimal>(type: "money", nullable: true),
                    F2712 = table.Column<decimal>(type: "money", nullable: true),
                    F2713 = table.Column<decimal>(type: "money", nullable: true),
                    F2714 = table.Column<decimal>(type: "money", nullable: true),
                    F2715 = table.Column<decimal>(type: "money", nullable: true),
                    F2716 = table.Column<decimal>(type: "money", nullable: true),
                    F2717 = table.Column<decimal>(type: "money", nullable: true),
                    F2718 = table.Column<decimal>(type: "money", nullable: true),
                    F2864 = table.Column<double>(nullable: true),
                    F2868 = table.Column<double>(nullable: true),
                    F2872 = table.Column<decimal>(type: "money", nullable: true),
                    F2873 = table.Column<decimal>(type: "money", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("REC_REG_P1032", x => new { x.F1032, x.F1101 });
                });

            migrationBuilder.CreateTable(
                name: "REC_REG_SAV",
                columns: table => new
                {
                    F1505 = table.Column<DateTime>(type: "datetime", nullable: false),
                    F1056 = table.Column<string>(unicode: false, maxLength: 4, nullable: false),
                    F1057 = table.Column<string>(unicode: false, maxLength: 4, nullable: false),
                    F1032 = table.Column<int>(nullable: false),
                    F1101 = table.Column<int>(nullable: false),
                    F2890 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F01 = table.Column<string>(unicode: false, maxLength: 13, nullable: true),
                    F03 = table.Column<int>(nullable: true),
                    F04 = table.Column<int>(nullable: true),
                    F05 = table.Column<int>(nullable: true),
                    F08 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F19 = table.Column<decimal>(type: "numeric(20, 4)", nullable: true),
                    F20 = table.Column<decimal>(type: "numeric(20, 4)", nullable: true),
                    F26 = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    F38 = table.Column<decimal>(type: "money", nullable: true),
                    F50 = table.Column<decimal>(type: "money", nullable: true),
                    F64 = table.Column<decimal>(type: "numeric(20, 4)", nullable: true),
                    F65 = table.Column<decimal>(type: "money", nullable: true),
                    F67 = table.Column<decimal>(type: "numeric(20, 4)", nullable: true),
                    F70 = table.Column<decimal>(type: "numeric(20, 4)", nullable: true),
                    F75 = table.Column<decimal>(type: "numeric(20, 4)", nullable: true),
                    F76 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F81 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F82 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F90 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F92 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F96 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F97 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F98 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F99 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F100 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F101 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F120 = table.Column<decimal>(type: "money", nullable: true),
                    F131 = table.Column<int>(nullable: true),
                    F151 = table.Column<decimal>(type: "money", nullable: true),
                    F156 = table.Column<string>(unicode: false, maxLength: 120, nullable: true),
                    F186 = table.Column<decimal>(type: "money", nullable: true),
                    F201 = table.Column<decimal>(type: "money", nullable: true),
                    F202 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F203 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F204 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F219 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F220 = table.Column<string>(unicode: false, maxLength: 13, nullable: true),
                    F222 = table.Column<string>(unicode: false, maxLength: 12, nullable: true),
                    F223 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F224 = table.Column<decimal>(type: "numeric(20, 4)", nullable: true),
                    F225 = table.Column<decimal>(type: "money", nullable: true),
                    F226 = table.Column<decimal>(type: "numeric(20, 4)", nullable: true),
                    F227 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F228 = table.Column<decimal>(type: "numeric(20, 4)", nullable: true),
                    F229 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F230 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F231 = table.Column<string>(unicode: false, maxLength: 12, nullable: true),
                    F233 = table.Column<decimal>(type: "money", nullable: true),
                    F234 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F235 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F236 = table.Column<string>(unicode: false, maxLength: 12, nullable: true),
                    F237 = table.Column<decimal>(type: "numeric(20, 4)", nullable: true),
                    F253 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F254 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F270 = table.Column<decimal>(type: "numeric(20, 4)", nullable: true),
                    F327 = table.Column<decimal>(type: "numeric(20, 4)", nullable: true),
                    F328 = table.Column<decimal>(type: "numeric(20, 4)", nullable: true),
                    F329 = table.Column<decimal>(type: "numeric(20, 4)", nullable: true),
                    F1003 = table.Column<decimal>(type: "numeric(20, 4)", nullable: true),
                    F1034 = table.Column<int>(nullable: true),
                    F1041 = table.Column<string>(unicode: false, maxLength: 60, nullable: true),
                    F1063 = table.Column<int>(nullable: true),
                    F1067 = table.Column<string>(unicode: false, maxLength: 7, nullable: true),
                    F1069 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F1070 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F1071 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F1079 = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    F1081 = table.Column<string>(unicode: false, maxLength: 5000, nullable: true),
                    F1086 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F1121 = table.Column<decimal>(type: "money", nullable: true),
                    F1122 = table.Column<decimal>(type: "numeric(20, 4)", nullable: true),
                    F1140 = table.Column<decimal>(type: "money", nullable: true),
                    F1184 = table.Column<string>(unicode: false, maxLength: 12, nullable: true),
                    F1246 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F1247 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F1248 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F1249 = table.Column<decimal>(type: "money", nullable: true),
                    F1250 = table.Column<decimal>(type: "money", nullable: true),
                    F1251 = table.Column<decimal>(type: "money", nullable: true),
                    F1252 = table.Column<decimal>(type: "money", nullable: true),
                    F1266 = table.Column<decimal>(type: "numeric(20, 4)", nullable: true),
                    F1267 = table.Column<decimal>(type: "numeric(20, 4)", nullable: true),
                    F1595 = table.Column<decimal>(type: "money", nullable: true),
                    F1596 = table.Column<int>(nullable: true),
                    F1657 = table.Column<decimal>(type: "numeric(20, 4)", nullable: true),
                    F1658 = table.Column<decimal>(type: "money", nullable: true),
                    F1659 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F1660 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F1661 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F1662 = table.Column<decimal>(type: "money", nullable: true),
                    F1663 = table.Column<decimal>(type: "numeric(20, 4)", nullable: true),
                    F1664 = table.Column<decimal>(type: "money", nullable: true),
                    F1665 = table.Column<decimal>(type: "numeric(20, 4)", nullable: true),
                    F1666 = table.Column<decimal>(type: "money", nullable: true),
                    F1667 = table.Column<decimal>(type: "numeric(20, 4)", nullable: true),
                    F1668 = table.Column<string>(unicode: false, maxLength: 16, nullable: true),
                    F1669 = table.Column<decimal>(type: "money", nullable: true),
                    F1670 = table.Column<decimal>(type: "numeric(20, 4)", nullable: true),
                    F1671 = table.Column<decimal>(type: "money", nullable: true),
                    F1672 = table.Column<decimal>(type: "money", nullable: true),
                    F1673 = table.Column<decimal>(type: "money", nullable: true),
                    F1674 = table.Column<decimal>(type: "money", nullable: true),
                    F1675 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F1676 = table.Column<decimal>(type: "money", nullable: true),
                    F1677 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F1678 = table.Column<decimal>(type: "money", nullable: true),
                    F1679 = table.Column<int>(nullable: true),
                    F1680 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F1681 = table.Column<decimal>(type: "money", nullable: true),
                    F1682 = table.Column<decimal>(type: "money", nullable: true),
                    F1683 = table.Column<decimal>(type: "numeric(20, 4)", nullable: true),
                    F1684 = table.Column<decimal>(type: "numeric(20, 4)", nullable: true),
                    F1685 = table.Column<int>(nullable: true),
                    F1687 = table.Column<int>(nullable: true),
                    F1691 = table.Column<string>(unicode: false, maxLength: 250, nullable: true),
                    F1732 = table.Column<decimal>(type: "numeric(20, 4)", nullable: true),
                    F1771 = table.Column<decimal>(type: "money", nullable: true),
                    F1772 = table.Column<decimal>(type: "money", nullable: true),
                    F1773 = table.Column<decimal>(type: "money", nullable: true),
                    F1774 = table.Column<decimal>(type: "money", nullable: true),
                    F1775 = table.Column<decimal>(type: "money", nullable: true),
                    F1776 = table.Column<int>(nullable: true),
                    F1791 = table.Column<string>(unicode: false, maxLength: 12, nullable: true),
                    F1793 = table.Column<int>(nullable: true),
                    F1795 = table.Column<decimal>(type: "numeric(20, 4)", nullable: true),
                    F1797 = table.Column<decimal>(type: "money", nullable: true),
                    F1815 = table.Column<decimal>(type: "money", nullable: true),
                    F1816 = table.Column<int>(nullable: true),
                    F1887 = table.Column<string>(unicode: false, maxLength: 2, nullable: true),
                    F1899 = table.Column<decimal>(type: "money", nullable: true),
                    F1918 = table.Column<decimal>(type: "numeric(20, 4)", nullable: true),
                    F1919 = table.Column<decimal>(type: "numeric(20, 4)", nullable: true),
                    F1920 = table.Column<decimal>(type: "numeric(20, 4)", nullable: true),
                    F1973 = table.Column<string>(unicode: false, maxLength: 120, nullable: true),
                    F1974 = table.Column<string>(unicode: false, maxLength: 120, nullable: true),
                    F1975 = table.Column<string>(unicode: false, maxLength: 120, nullable: true),
                    F1976 = table.Column<string>(unicode: false, maxLength: 120, nullable: true),
                    F1977 = table.Column<decimal>(type: "numeric(20, 4)", nullable: true),
                    F1978 = table.Column<decimal>(type: "numeric(20, 4)", nullable: true),
                    F1979 = table.Column<decimal>(type: "numeric(20, 4)", nullable: true),
                    F2551 = table.Column<decimal>(type: "money", nullable: true),
                    F2552 = table.Column<decimal>(type: "money", nullable: true),
                    F2553 = table.Column<decimal>(type: "money", nullable: true),
                    F2554 = table.Column<decimal>(type: "money", nullable: true),
                    F2555 = table.Column<decimal>(type: "money", nullable: true),
                    F2556 = table.Column<decimal>(type: "money", nullable: true),
                    F2557 = table.Column<decimal>(type: "money", nullable: true),
                    F2558 = table.Column<decimal>(type: "money", nullable: true),
                    F2559 = table.Column<decimal>(type: "money", nullable: true),
                    F2560 = table.Column<decimal>(type: "money", nullable: true),
                    F2561 = table.Column<decimal>(type: "money", nullable: true),
                    F2562 = table.Column<decimal>(type: "money", nullable: true),
                    F2563 = table.Column<decimal>(type: "money", nullable: true),
                    F2564 = table.Column<decimal>(type: "money", nullable: true),
                    F2565 = table.Column<decimal>(type: "money", nullable: true),
                    F2566 = table.Column<decimal>(type: "numeric(20, 4)", nullable: true),
                    F2567 = table.Column<decimal>(type: "numeric(20, 4)", nullable: true),
                    F2568 = table.Column<decimal>(type: "numeric(20, 4)", nullable: true),
                    F2624 = table.Column<int>(nullable: true),
                    F2625 = table.Column<int>(nullable: true),
                    F2626 = table.Column<decimal>(type: "money", nullable: true),
                    F2627 = table.Column<decimal>(type: "money", nullable: true),
                    F2628 = table.Column<decimal>(type: "numeric(20, 4)", nullable: true),
                    F2629 = table.Column<decimal>(type: "numeric(20, 4)", nullable: true),
                    F2630 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F2631 = table.Column<int>(nullable: true),
                    F2660 = table.Column<string>(unicode: false, maxLength: 250, nullable: true),
                    F2666 = table.Column<decimal>(type: "numeric(20, 4)", nullable: true),
                    F2709 = table.Column<decimal>(type: "money", nullable: true),
                    F2711 = table.Column<decimal>(type: "money", nullable: true),
                    F2712 = table.Column<decimal>(type: "money", nullable: true),
                    F2713 = table.Column<decimal>(type: "money", nullable: true),
                    F2714 = table.Column<decimal>(type: "money", nullable: true),
                    F2715 = table.Column<decimal>(type: "money", nullable: true),
                    F2716 = table.Column<decimal>(type: "money", nullable: true),
                    F2717 = table.Column<decimal>(type: "money", nullable: true),
                    F2718 = table.Column<decimal>(type: "money", nullable: true),
                    F2864 = table.Column<decimal>(type: "numeric(20, 4)", nullable: true),
                    F2868 = table.Column<decimal>(type: "numeric(20, 4)", nullable: true),
                    F2872 = table.Column<decimal>(type: "money", nullable: true),
                    F2873 = table.Column<decimal>(type: "money", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("REC_REG_SAV_P1032", x => new { x.F1505, x.F1056, x.F1057, x.F1032, x.F1101 });
                });

            migrationBuilder.CreateTable(
                name: "REC_TTL",
                columns: table => new
                {
                    F1032 = table.Column<int>(nullable: false),
                    F1034 = table.Column<int>(nullable: false),
                    F64 = table.Column<double>(nullable: true),
                    F65 = table.Column<decimal>(type: "money", nullable: true),
                    F67 = table.Column<double>(nullable: true),
                    F1039 = table.Column<string>(unicode: false, maxLength: 60, nullable: true),
                    F1067 = table.Column<string>(unicode: false, maxLength: 7, nullable: true),
                    F1093 = table.Column<decimal>(type: "money", nullable: true),
                    F1094 = table.Column<decimal>(type: "money", nullable: true),
                    F1095 = table.Column<decimal>(type: "money", nullable: true),
                    F1096 = table.Column<decimal>(type: "money", nullable: true),
                    F1097 = table.Column<decimal>(type: "money", nullable: true),
                    F1098 = table.Column<decimal>(type: "money", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("REC_TTL_P1032", x => new { x.F1032, x.F1034 });
                });

            migrationBuilder.CreateTable(
                name: "REC_TTL_SAV",
                columns: table => new
                {
                    F1505 = table.Column<DateTime>(type: "datetime", nullable: false),
                    F1056 = table.Column<string>(unicode: false, maxLength: 4, nullable: false),
                    F1057 = table.Column<string>(unicode: false, maxLength: 4, nullable: false),
                    F1032 = table.Column<int>(nullable: false),
                    F1034 = table.Column<int>(nullable: false),
                    F2890 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F64 = table.Column<decimal>(type: "numeric(20, 4)", nullable: true),
                    F65 = table.Column<decimal>(type: "money", nullable: true),
                    F67 = table.Column<decimal>(type: "numeric(20, 4)", nullable: true),
                    F1039 = table.Column<string>(unicode: false, maxLength: 60, nullable: true),
                    F1067 = table.Column<string>(unicode: false, maxLength: 7, nullable: true),
                    F1093 = table.Column<decimal>(type: "money", nullable: true),
                    F1094 = table.Column<decimal>(type: "money", nullable: true),
                    F1095 = table.Column<decimal>(type: "money", nullable: true),
                    F1096 = table.Column<decimal>(type: "money", nullable: true),
                    F1097 = table.Column<decimal>(type: "money", nullable: true),
                    F1098 = table.Column<decimal>(type: "money", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("REC_TTL_SAV_P1032", x => new { x.F1505, x.F1056, x.F1057, x.F1032, x.F1034 });
                });

            migrationBuilder.CreateTable(
                name: "RENT_TAB",
                columns: table => new
                {
                    F01 = table.Column<string>(unicode: false, maxLength: 13, nullable: false),
                    F1079 = table.Column<string>(unicode: false, maxLength: 30, nullable: false),
                    F1785 = table.Column<string>(unicode: false, maxLength: 12, nullable: false),
                    F65 = table.Column<decimal>(type: "money", nullable: true),
                    F126 = table.Column<int>(nullable: true),
                    F1032 = table.Column<int>(nullable: true),
                    F1056 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F1057 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F1101 = table.Column<int>(nullable: true),
                    F1148 = table.Column<string>(unicode: false, maxLength: 14, nullable: true),
                    F1845 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F1846 = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("RENT_TAB_P01", x => new { x.F01, x.F1079, x.F1785 });
                });

            migrationBuilder.CreateTable(
                name: "RES_TAB",
                columns: table => new
                {
                    F170 = table.Column<int>(nullable: false),
                    F1001 = table.Column<int>(nullable: true),
                    F1745 = table.Column<string>(unicode: false, maxLength: 6, nullable: true),
                    F1746 = table.Column<string>(unicode: false, maxLength: 6, nullable: true),
                    F1747 = table.Column<string>(unicode: false, maxLength: 6, nullable: true),
                    F1748 = table.Column<string>(unicode: false, maxLength: 6, nullable: true),
                    F1749 = table.Column<string>(unicode: false, maxLength: 6, nullable: true),
                    F1750 = table.Column<string>(unicode: false, maxLength: 6, nullable: true),
                    F1751 = table.Column<string>(unicode: false, maxLength: 6, nullable: true),
                    F1752 = table.Column<string>(unicode: false, maxLength: 6, nullable: true),
                    F1753 = table.Column<string>(unicode: false, maxLength: 6, nullable: true),
                    F1754 = table.Column<string>(unicode: false, maxLength: 6, nullable: true),
                    F1755 = table.Column<string>(unicode: false, maxLength: 6, nullable: true),
                    F1756 = table.Column<string>(unicode: false, maxLength: 6, nullable: true),
                    F1757 = table.Column<string>(unicode: false, maxLength: 6, nullable: true),
                    F1758 = table.Column<string>(unicode: false, maxLength: 6, nullable: true),
                    F1830 = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    F1841 = table.Column<string>(unicode: false, maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("RES_TAB_P170", x => x.F170);
                });

            migrationBuilder.CreateTable(
                name: "REV_EXEC",
                columns: table => new
                {
                    F3000 = table.Column<short>(nullable: false),
                    F3005 = table.Column<DateTime>(nullable: false),
                    F3009 = table.Column<string>(maxLength: 128, nullable: false),
                    F3001 = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    F3006 = table.Column<long>(nullable: false),
                    F3010 = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("REV_EXEC_P01", x => new { x.F3000, x.F3005, x.F3009, x.F3001 });
                });

            migrationBuilder.CreateTable(
                name: "REV_HDR",
                columns: table => new
                {
                    F3005 = table.Column<DateTime>(nullable: false),
                    F3003 = table.Column<byte>(nullable: false),
                    F3009 = table.Column<string>(maxLength: 128, nullable: false),
                    F3004 = table.Column<string>(maxLength: 128, nullable: false),
                    F3001 = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    F3007 = table.Column<DateTime>(nullable: false),
                    F3002 = table.Column<string>(unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("REV_HDR_P01", x => new { x.F3005, x.F3009, x.F3004, x.F3003, x.F3001 });
                });

            migrationBuilder.CreateTable(
                name: "REV_LIST",
                columns: table => new
                {
                    F3000 = table.Column<short>(nullable: false),
                    F3009 = table.Column<string>(maxLength: 128, nullable: false),
                    F1039 = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    F1301 = table.Column<short>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("REV_LIST_P01", x => new { x.F3000, x.F3009 });
                });

            migrationBuilder.CreateTable(
                name: "REV_QUEUE",
                columns: table => new
                {
                    F3005 = table.Column<DateTime>(nullable: false),
                    F3000 = table.Column<short>(nullable: false),
                    F3009 = table.Column<string>(maxLength: 128, nullable: false),
                    F3001 = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    F3007 = table.Column<DateTime>(nullable: false),
                    F3003 = table.Column<byte>(nullable: false),
                    F3004 = table.Column<string>(maxLength: 128, nullable: false),
                    F3002 = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    F3006 = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("REV_QUEUE_P01", x => new { x.F3005, x.F3009, x.F3000, x.F3001 });
                });

            migrationBuilder.CreateTable(
                name: "ROUTE_TAB",
                columns: table => new
                {
                    F1697 = table.Column<string>(unicode: false, maxLength: 40, nullable: false),
                    F1056 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F1654 = table.Column<double>(nullable: true),
                    F1655 = table.Column<double>(nullable: true),
                    F2619 = table.Column<double>(nullable: true),
                    F2893 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F2894 = table.Column<string>(unicode: false, maxLength: 6, nullable: true),
                    F2895 = table.Column<int>(nullable: true),
                    F2896 = table.Column<int>(nullable: true),
                    F2897 = table.Column<int>(nullable: true),
                    F2898 = table.Column<int>(nullable: true),
                    F2902 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F2903 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F2904 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F2905 = table.Column<string>(unicode: false, maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ROUTE_TAB_P1697", x => x.F1697);
                });

            migrationBuilder.CreateTable(
                name: "RPC_TAB",
                columns: table => new
                {
                    F18 = table.Column<int>(nullable: false),
                    F49 = table.Column<double>(nullable: true),
                    F1024 = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    F1123 = table.Column<double>(nullable: true),
                    F1124 = table.Column<double>(nullable: true),
                    F1168 = table.Column<int>(nullable: true),
                    F1965 = table.Column<int>(nullable: true),
                    F1966 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    F1967 = table.Column<string>(unicode: false, maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("RPC_TAB_P18", x => x.F18);
                });

            migrationBuilder.CreateTable(
                name: "RPT_CLK_D",
                columns: table => new
                {
                    F254 = table.Column<DateTime>(type: "datetime", nullable: false),
                    F1034 = table.Column<int>(nullable: false),
                    F1185 = table.Column<int>(nullable: false),
                    F1056 = table.Column<string>(unicode: false, maxLength: 4, nullable: false),
                    F1057 = table.Column<string>(unicode: false, maxLength: 4, nullable: false),
                    F64 = table.Column<double>(nullable: false),
                    F65 = table.Column<decimal>(type: "money", nullable: false),
                    F67 = table.Column<double>(nullable: false),
                    F253 = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("RPT_CLK_D_P254", x => new { x.F254, x.F1034, x.F1185, x.F1056, x.F1057 });
                });

            migrationBuilder.CreateTable(
                name: "RPT_CLK_F",
                columns: table => new
                {
                    F254 = table.Column<DateTime>(type: "datetime", nullable: false),
                    F1034 = table.Column<int>(nullable: false),
                    F1185 = table.Column<int>(nullable: false),
                    F1056 = table.Column<string>(unicode: false, maxLength: 4, nullable: false),
                    F1057 = table.Column<string>(unicode: false, maxLength: 4, nullable: false),
                    F64 = table.Column<double>(nullable: false),
                    F65 = table.Column<decimal>(type: "money", nullable: false),
                    F67 = table.Column<double>(nullable: false),
                    F253 = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("RPT_CLK_F_P254", x => new { x.F254, x.F1034, x.F1185, x.F1056, x.F1057 });
                });

            migrationBuilder.CreateTable(
                name: "RPT_CLK_M",
                columns: table => new
                {
                    F254 = table.Column<DateTime>(type: "datetime", nullable: false),
                    F1034 = table.Column<int>(nullable: false),
                    F1185 = table.Column<int>(nullable: false),
                    F1056 = table.Column<string>(unicode: false, maxLength: 4, nullable: false),
                    F1057 = table.Column<string>(unicode: false, maxLength: 4, nullable: false),
                    F64 = table.Column<double>(nullable: false),
                    F65 = table.Column<decimal>(type: "money", nullable: false),
                    F67 = table.Column<double>(nullable: false),
                    F253 = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("RPT_CLK_M_P254", x => new { x.F254, x.F1034, x.F1185, x.F1056, x.F1057 });
                });

            migrationBuilder.CreateTable(
                name: "RPT_CLK_N",
                columns: table => new
                {
                    F1034 = table.Column<int>(nullable: false),
                    F1185 = table.Column<int>(nullable: false),
                    F64 = table.Column<double>(nullable: false),
                    F65 = table.Column<decimal>(type: "money", nullable: false),
                    F67 = table.Column<double>(nullable: false),
                    F253 = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("RPT_CLK_N_P1034", x => new { x.F1034, x.F1185 });
                });

            migrationBuilder.CreateTable(
                name: "RPT_CLK_P",
                columns: table => new
                {
                    F254 = table.Column<DateTime>(type: "datetime", nullable: false),
                    F1034 = table.Column<int>(nullable: false),
                    F1185 = table.Column<int>(nullable: false),
                    F1056 = table.Column<string>(unicode: false, maxLength: 4, nullable: false),
                    F1057 = table.Column<string>(unicode: false, maxLength: 4, nullable: false),
                    F64 = table.Column<double>(nullable: false),
                    F65 = table.Column<decimal>(type: "money", nullable: false),
                    F67 = table.Column<double>(nullable: false),
                    F253 = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("RPT_CLK_P_P254", x => new { x.F254, x.F1034, x.F1185, x.F1056, x.F1057 });
                });

            migrationBuilder.CreateTable(
                name: "RPT_CLK_W",
                columns: table => new
                {
                    F254 = table.Column<DateTime>(type: "datetime", nullable: false),
                    F1034 = table.Column<int>(nullable: false),
                    F1185 = table.Column<int>(nullable: false),
                    F1056 = table.Column<string>(unicode: false, maxLength: 4, nullable: false),
                    F1057 = table.Column<string>(unicode: false, maxLength: 4, nullable: false),
                    F64 = table.Column<double>(nullable: false),
                    F65 = table.Column<decimal>(type: "money", nullable: false),
                    F67 = table.Column<double>(nullable: false),
                    F253 = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("RPT_CLK_W_P254", x => new { x.F254, x.F1034, x.F1185, x.F1056, x.F1057 });
                });

            migrationBuilder.CreateTable(
                name: "RPT_CLK_Y",
                columns: table => new
                {
                    F254 = table.Column<DateTime>(type: "datetime", nullable: false),
                    F1034 = table.Column<int>(nullable: false),
                    F1185 = table.Column<int>(nullable: false),
                    F1056 = table.Column<string>(unicode: false, maxLength: 4, nullable: false),
                    F1057 = table.Column<string>(unicode: false, maxLength: 4, nullable: false),
                    F64 = table.Column<double>(nullable: false),
                    F65 = table.Column<decimal>(type: "money", nullable: false),
                    F67 = table.Column<double>(nullable: false),
                    F253 = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("RPT_CLK_Y_P254", x => new { x.F254, x.F1034, x.F1185, x.F1056, x.F1057 });
                });

            migrationBuilder.CreateTable(
                name: "RPT_CLT_D",
                columns: table => new
                {
                    F254 = table.Column<DateTime>(type: "datetime", nullable: false),
                    F1034 = table.Column<int>(nullable: false),
                    F1148 = table.Column<string>(unicode: false, maxLength: 14, nullable: false),
                    F1056 = table.Column<string>(unicode: false, maxLength: 4, nullable: false),
                    F64 = table.Column<double>(nullable: false),
                    F65 = table.Column<decimal>(type: "money", nullable: false),
                    F67 = table.Column<double>(nullable: false),
                    F253 = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("RPT_CLT_D_P254", x => new { x.F254, x.F1034, x.F1148, x.F1056 });
                });

            migrationBuilder.CreateTable(
                name: "RPT_CLT_F",
                columns: table => new
                {
                    F254 = table.Column<DateTime>(type: "datetime", nullable: false),
                    F1034 = table.Column<int>(nullable: false),
                    F1148 = table.Column<string>(unicode: false, maxLength: 14, nullable: false),
                    F1056 = table.Column<string>(unicode: false, maxLength: 4, nullable: false),
                    F64 = table.Column<double>(nullable: false),
                    F65 = table.Column<decimal>(type: "money", nullable: false),
                    F67 = table.Column<double>(nullable: false),
                    F253 = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("RPT_CLT_F_P254", x => new { x.F254, x.F1034, x.F1148, x.F1056 });
                });

            migrationBuilder.CreateTable(
                name: "RPT_CLT_ITM_D",
                columns: table => new
                {
                    F254 = table.Column<DateTime>(type: "datetime", nullable: false),
                    F1034 = table.Column<int>(nullable: false),
                    F1148 = table.Column<string>(unicode: false, maxLength: 14, nullable: false),
                    F01 = table.Column<string>(unicode: false, maxLength: 13, nullable: false),
                    F1056 = table.Column<string>(unicode: false, maxLength: 4, nullable: false),
                    F64 = table.Column<double>(nullable: false),
                    F65 = table.Column<decimal>(type: "money", nullable: false),
                    F67 = table.Column<double>(nullable: false),
                    F253 = table.Column<DateTime>(type: "datetime", nullable: false),
                    F1301 = table.Column<double>(nullable: true),
                    F1302 = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("RPT_CLT_ITM_D_P254", x => new { x.F254, x.F1034, x.F1148, x.F01, x.F1056 });
                });

            migrationBuilder.CreateTable(
                name: "RPT_CLT_ITM_N",
                columns: table => new
                {
                    F1148 = table.Column<string>(unicode: false, maxLength: 14, nullable: false),
                    F01 = table.Column<string>(unicode: false, maxLength: 13, nullable: false),
                    F1034 = table.Column<int>(nullable: false),
                    F64 = table.Column<double>(nullable: false),
                    F65 = table.Column<decimal>(type: "money", nullable: false),
                    F67 = table.Column<double>(nullable: false),
                    F253 = table.Column<DateTime>(type: "datetime", nullable: false),
                    F1301 = table.Column<double>(nullable: true),
                    F1302 = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("RPT_CLT_ITM_N_P1148", x => new { x.F1148, x.F01, x.F1034 });
                });

            migrationBuilder.CreateTable(
                name: "RPT_CLT_M",
                columns: table => new
                {
                    F254 = table.Column<DateTime>(type: "datetime", nullable: false),
                    F1034 = table.Column<int>(nullable: false),
                    F1148 = table.Column<string>(unicode: false, maxLength: 14, nullable: false),
                    F1056 = table.Column<string>(unicode: false, maxLength: 4, nullable: false),
                    F64 = table.Column<double>(nullable: false),
                    F65 = table.Column<decimal>(type: "money", nullable: false),
                    F67 = table.Column<double>(nullable: false),
                    F253 = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("RPT_CLT_M_P254", x => new { x.F254, x.F1034, x.F1148, x.F1056 });
                });

            migrationBuilder.CreateTable(
                name: "RPT_CLT_N",
                columns: table => new
                {
                    F1148 = table.Column<string>(unicode: false, maxLength: 14, nullable: false),
                    F1034 = table.Column<int>(nullable: false),
                    F64 = table.Column<double>(nullable: false),
                    F65 = table.Column<decimal>(type: "money", nullable: false),
                    F67 = table.Column<double>(nullable: false),
                    F253 = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("RPT_CLT_N_P1148", x => new { x.F1148, x.F1034 });
                });

            migrationBuilder.CreateTable(
                name: "RPT_CLT_P",
                columns: table => new
                {
                    F254 = table.Column<DateTime>(type: "datetime", nullable: false),
                    F1034 = table.Column<int>(nullable: false),
                    F1148 = table.Column<string>(unicode: false, maxLength: 14, nullable: false),
                    F1056 = table.Column<string>(unicode: false, maxLength: 4, nullable: false),
                    F64 = table.Column<double>(nullable: false),
                    F65 = table.Column<decimal>(type: "money", nullable: false),
                    F67 = table.Column<double>(nullable: false),
                    F253 = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("RPT_CLT_P_P254", x => new { x.F254, x.F1034, x.F1148, x.F1056 });
                });

            migrationBuilder.CreateTable(
                name: "RPT_CLT_W",
                columns: table => new
                {
                    F254 = table.Column<DateTime>(type: "datetime", nullable: false),
                    F1034 = table.Column<int>(nullable: false),
                    F1148 = table.Column<string>(unicode: false, maxLength: 14, nullable: false),
                    F1056 = table.Column<string>(unicode: false, maxLength: 4, nullable: false),
                    F64 = table.Column<double>(nullable: false),
                    F65 = table.Column<decimal>(type: "money", nullable: false),
                    F67 = table.Column<double>(nullable: false),
                    F253 = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("RPT_CLT_W_P254", x => new { x.F254, x.F1034, x.F1148, x.F1056 });
                });

            migrationBuilder.CreateTable(
                name: "RPT_CLT_Y",
                columns: table => new
                {
                    F254 = table.Column<DateTime>(type: "datetime", nullable: false),
                    F1034 = table.Column<int>(nullable: false),
                    F1148 = table.Column<string>(unicode: false, maxLength: 14, nullable: false),
                    F1056 = table.Column<string>(unicode: false, maxLength: 4, nullable: false),
                    F64 = table.Column<double>(nullable: false),
                    F65 = table.Column<decimal>(type: "money", nullable: false),
                    F67 = table.Column<double>(nullable: false),
                    F253 = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("RPT_CLT_Y_P254", x => new { x.F254, x.F1034, x.F1148, x.F1056 });
                });

            migrationBuilder.CreateTable(
                name: "RPT_DPT",
                columns: table => new
                {
                    F1031 = table.Column<string>(unicode: false, maxLength: 1, nullable: false),
                    F254 = table.Column<DateTime>(type: "datetime", nullable: false),
                    F1034 = table.Column<int>(nullable: false),
                    F03 = table.Column<int>(nullable: false),
                    F1056 = table.Column<string>(unicode: false, maxLength: 4, nullable: false),
                    F1057 = table.Column<string>(unicode: false, maxLength: 4, nullable: false),
                    F64 = table.Column<double>(nullable: false),
                    F65 = table.Column<decimal>(type: "money", nullable: false),
                    F67 = table.Column<double>(nullable: false),
                    F253 = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("RPT_DPT_P1031", x => new { x.F1031, x.F254, x.F1034, x.F03, x.F1056, x.F1057 });
                });

            migrationBuilder.CreateTable(
                name: "RPT_FIN",
                columns: table => new
                {
                    F1031 = table.Column<string>(unicode: false, maxLength: 1, nullable: false),
                    F254 = table.Column<DateTime>(type: "datetime", nullable: false),
                    F1034 = table.Column<int>(nullable: false),
                    F1056 = table.Column<string>(unicode: false, maxLength: 4, nullable: false),
                    F1057 = table.Column<string>(unicode: false, maxLength: 4, nullable: false),
                    F64 = table.Column<double>(nullable: false),
                    F65 = table.Column<decimal>(type: "money", nullable: false),
                    F67 = table.Column<double>(nullable: false),
                    F253 = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("RPT_FIN_P1031", x => new { x.F1031, x.F254, x.F1034, x.F1056, x.F1057 });
                });

            migrationBuilder.CreateTable(
                name: "RPT_HOU",
                columns: table => new
                {
                    F1031 = table.Column<string>(unicode: false, maxLength: 1, nullable: false),
                    F254 = table.Column<DateTime>(type: "datetime", nullable: false),
                    F1034 = table.Column<int>(nullable: false),
                    F01 = table.Column<string>(unicode: false, maxLength: 13, nullable: false),
                    F1056 = table.Column<string>(unicode: false, maxLength: 4, nullable: false),
                    F1057 = table.Column<string>(unicode: false, maxLength: 4, nullable: false),
                    F64 = table.Column<double>(nullable: false),
                    F65 = table.Column<decimal>(type: "money", nullable: false),
                    F67 = table.Column<double>(nullable: false),
                    F253 = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("RPT_HOU_P1031", x => new { x.F1031, x.F254, x.F1034, x.F01, x.F1056, x.F1057 });
                });

            migrationBuilder.CreateTable(
                name: "RPT_ITM_D",
                columns: table => new
                {
                    F254 = table.Column<DateTime>(type: "datetime", nullable: false),
                    F1034 = table.Column<int>(nullable: false),
                    F01 = table.Column<string>(unicode: false, maxLength: 13, nullable: false),
                    F1056 = table.Column<string>(unicode: false, maxLength: 4, nullable: false),
                    F1057 = table.Column<string>(unicode: false, maxLength: 4, nullable: false),
                    F64 = table.Column<double>(nullable: false),
                    F65 = table.Column<decimal>(type: "money", nullable: false),
                    F67 = table.Column<double>(nullable: false),
                    F253 = table.Column<DateTime>(type: "datetime", nullable: false),
                    F1301 = table.Column<double>(nullable: true),
                    F1302 = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("RPT_ITM_D_P254", x => new { x.F254, x.F1034, x.F01, x.F1056, x.F1057 });
                });

            migrationBuilder.CreateTable(
                name: "RPT_ITM_F",
                columns: table => new
                {
                    F254 = table.Column<DateTime>(type: "datetime", nullable: false),
                    F1034 = table.Column<int>(nullable: false),
                    F01 = table.Column<string>(unicode: false, maxLength: 13, nullable: false),
                    F1056 = table.Column<string>(unicode: false, maxLength: 4, nullable: false),
                    F1057 = table.Column<string>(unicode: false, maxLength: 4, nullable: false),
                    F64 = table.Column<double>(nullable: false),
                    F65 = table.Column<decimal>(type: "money", nullable: false),
                    F67 = table.Column<double>(nullable: false),
                    F253 = table.Column<DateTime>(type: "datetime", nullable: false),
                    F1301 = table.Column<double>(nullable: true),
                    F1302 = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("RPT_ITM_F_P254", x => new { x.F254, x.F1034, x.F01, x.F1056, x.F1057 });
                });

            migrationBuilder.CreateTable(
                name: "RPT_ITM_M",
                columns: table => new
                {
                    F254 = table.Column<DateTime>(type: "datetime", nullable: false),
                    F1034 = table.Column<int>(nullable: false),
                    F01 = table.Column<string>(unicode: false, maxLength: 13, nullable: false),
                    F1056 = table.Column<string>(unicode: false, maxLength: 4, nullable: false),
                    F1057 = table.Column<string>(unicode: false, maxLength: 4, nullable: false),
                    F64 = table.Column<double>(nullable: false),
                    F65 = table.Column<decimal>(type: "money", nullable: false),
                    F67 = table.Column<double>(nullable: false),
                    F253 = table.Column<DateTime>(type: "datetime", nullable: false),
                    F1301 = table.Column<double>(nullable: true),
                    F1302 = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("RPT_ITM_M_P254", x => new { x.F254, x.F1034, x.F01, x.F1056, x.F1057 });
                });

            migrationBuilder.CreateTable(
                name: "RPT_ITM_N",
                columns: table => new
                {
                    F01 = table.Column<string>(unicode: false, maxLength: 13, nullable: false),
                    F1034 = table.Column<int>(nullable: false),
                    F1056 = table.Column<string>(unicode: false, maxLength: 4, nullable: false),
                    F64 = table.Column<double>(nullable: false),
                    F65 = table.Column<decimal>(type: "money", nullable: false),
                    F67 = table.Column<double>(nullable: false),
                    F253 = table.Column<DateTime>(type: "datetime", nullable: false),
                    F381 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F1301 = table.Column<double>(nullable: true),
                    F1302 = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("RPT_ITM_N_P01", x => new { x.F01, x.F1034, x.F1056 });
                });

            migrationBuilder.CreateTable(
                name: "RPT_ITM_P",
                columns: table => new
                {
                    F254 = table.Column<DateTime>(type: "datetime", nullable: false),
                    F1034 = table.Column<int>(nullable: false),
                    F01 = table.Column<string>(unicode: false, maxLength: 13, nullable: false),
                    F1056 = table.Column<string>(unicode: false, maxLength: 4, nullable: false),
                    F1057 = table.Column<string>(unicode: false, maxLength: 4, nullable: false),
                    F64 = table.Column<double>(nullable: false),
                    F65 = table.Column<decimal>(type: "money", nullable: false),
                    F67 = table.Column<double>(nullable: false),
                    F253 = table.Column<DateTime>(type: "datetime", nullable: false),
                    F1301 = table.Column<double>(nullable: true),
                    F1302 = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("RPT_ITM_P_P254", x => new { x.F254, x.F1034, x.F01, x.F1056, x.F1057 });
                });

            migrationBuilder.CreateTable(
                name: "RPT_ITM_W",
                columns: table => new
                {
                    F254 = table.Column<DateTime>(type: "datetime", nullable: false),
                    F1034 = table.Column<int>(nullable: false),
                    F01 = table.Column<string>(unicode: false, maxLength: 13, nullable: false),
                    F1056 = table.Column<string>(unicode: false, maxLength: 4, nullable: false),
                    F1057 = table.Column<string>(unicode: false, maxLength: 4, nullable: false),
                    F64 = table.Column<double>(nullable: false),
                    F65 = table.Column<decimal>(type: "money", nullable: false),
                    F67 = table.Column<double>(nullable: false),
                    F253 = table.Column<DateTime>(type: "datetime", nullable: false),
                    F1301 = table.Column<double>(nullable: true),
                    F1302 = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("RPT_ITM_W_P254", x => new { x.F254, x.F1034, x.F01, x.F1056, x.F1057 });
                });

            migrationBuilder.CreateTable(
                name: "RPT_ITM_Y",
                columns: table => new
                {
                    F254 = table.Column<DateTime>(type: "datetime", nullable: false),
                    F1034 = table.Column<int>(nullable: false),
                    F01 = table.Column<string>(unicode: false, maxLength: 13, nullable: false),
                    F1056 = table.Column<string>(unicode: false, maxLength: 4, nullable: false),
                    F1057 = table.Column<string>(unicode: false, maxLength: 4, nullable: false),
                    F64 = table.Column<double>(nullable: false),
                    F65 = table.Column<decimal>(type: "money", nullable: false),
                    F67 = table.Column<double>(nullable: false),
                    F253 = table.Column<DateTime>(type: "datetime", nullable: false),
                    F1301 = table.Column<double>(nullable: true),
                    F1302 = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("RPT_ITM_Y_P254", x => new { x.F254, x.F1034, x.F01, x.F1056, x.F1057 });
                });

            migrationBuilder.CreateTable(
                name: "RPT_SUB",
                columns: table => new
                {
                    F1031 = table.Column<string>(unicode: false, maxLength: 1, nullable: false),
                    F254 = table.Column<DateTime>(type: "datetime", nullable: false),
                    F1034 = table.Column<int>(nullable: false),
                    F04 = table.Column<int>(nullable: false),
                    F1056 = table.Column<string>(unicode: false, maxLength: 4, nullable: false),
                    F1057 = table.Column<string>(unicode: false, maxLength: 4, nullable: false),
                    F64 = table.Column<double>(nullable: false),
                    F65 = table.Column<decimal>(type: "money", nullable: false),
                    F67 = table.Column<double>(nullable: false),
                    F253 = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("RPT_SUB_P1031", x => new { x.F1031, x.F254, x.F1034, x.F04, x.F1056, x.F1057 });
                });

            migrationBuilder.CreateTable(
                name: "RPT_VND",
                columns: table => new
                {
                    F1031 = table.Column<string>(unicode: false, maxLength: 1, nullable: false),
                    F254 = table.Column<DateTime>(type: "datetime", nullable: false),
                    F1034 = table.Column<int>(nullable: false),
                    F27 = table.Column<string>(unicode: false, maxLength: 14, nullable: false),
                    F1056 = table.Column<string>(unicode: false, maxLength: 4, nullable: false),
                    F64 = table.Column<double>(nullable: false),
                    F65 = table.Column<decimal>(type: "money", nullable: false),
                    F67 = table.Column<double>(nullable: false),
                    F253 = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("RPT_VND_P1031", x => new { x.F1031, x.F254, x.F1034, x.F27, x.F1056 });
                });

            migrationBuilder.CreateTable(
                name: "RUN_TAB",
                columns: table => new
                {
                    F1102 = table.Column<int>(nullable: false),
                    F1000 = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    F1103 = table.Column<string>(unicode: false, maxLength: 120, nullable: true),
                    F1104 = table.Column<string>(unicode: false, maxLength: 5, nullable: true),
                    F1105 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F1106 = table.Column<int>(nullable: true),
                    F1107 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F1108 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F1109 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F1110 = table.Column<string>(unicode: false, maxLength: 6, nullable: true),
                    F1111 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F1112 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F1113 = table.Column<string>(unicode: false, maxLength: 60, nullable: true),
                    F1114 = table.Column<int>(nullable: true),
                    F1115 = table.Column<int>(nullable: true),
                    F1116 = table.Column<int>(nullable: true),
                    F1117 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("RUN_TAB_P1102", x => new { x.F1102, x.F1000 });
                });

            migrationBuilder.CreateTable(
                name: "SAL_BAT",
                columns: table => new
                {
                    F1032 = table.Column<int>(nullable: false),
                    F1148 = table.Column<string>(unicode: false, maxLength: 14, nullable: true),
                    F76 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F91 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    F253 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F254 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F902 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F1035 = table.Column<string>(unicode: false, maxLength: 6, nullable: true),
                    F1036 = table.Column<string>(unicode: false, maxLength: 6, nullable: true),
                    F1056 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F1057 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F1067 = table.Column<string>(unicode: false, maxLength: 7, nullable: true),
                    F1068 = table.Column<string>(unicode: false, maxLength: 6, nullable: true),
                    F1101 = table.Column<int>(nullable: true),
                    F1126 = table.Column<int>(nullable: true),
                    F1127 = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    F1137 = table.Column<int>(nullable: true),
                    F1149 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F1150 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F1151 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F1152 = table.Column<int>(nullable: true),
                    F1153 = table.Column<int>(nullable: true),
                    F1154 = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    F1155 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F1156 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F1157 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F1158 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F1159 = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    F1160 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    F1161 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    F1163 = table.Column<int>(nullable: true),
                    F1164 = table.Column<double>(nullable: true),
                    F1165 = table.Column<decimal>(type: "money", nullable: true),
                    F1167 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    F1168 = table.Column<int>(nullable: true),
                    F1170 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    F1171 = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    F1172 = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    F1173 = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    F1185 = table.Column<int>(nullable: true),
                    F1238 = table.Column<int>(nullable: true),
                    F1242 = table.Column<decimal>(type: "money", nullable: true),
                    F1245 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    F1246 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F1254 = table.Column<string>(unicode: false, maxLength: 5000, nullable: true),
                    F1255 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F1271 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F1272 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F1273 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F1274 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F1277 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F1287 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F1288 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F1295 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F1504 = table.Column<string>(unicode: false, maxLength: 2, nullable: true),
                    F1520 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F1573 = table.Column<string>(unicode: false, maxLength: 60, nullable: true),
                    F1642 = table.Column<string>(unicode: false, maxLength: 14, nullable: true),
                    F1643 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F1644 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F1645 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F1646 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F1647 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F1648 = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    F1649 = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    F1650 = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    F1651 = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    F1652 = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    F1653 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F1654 = table.Column<double>(nullable: true),
                    F1655 = table.Column<double>(nullable: true),
                    F1685 = table.Column<int>(nullable: true),
                    F1686 = table.Column<int>(nullable: true),
                    F1687 = table.Column<int>(nullable: true),
                    F1688 = table.Column<int>(nullable: true),
                    F1689 = table.Column<int>(nullable: true),
                    F1692 = table.Column<string>(unicode: false, maxLength: 160, nullable: true),
                    F1693 = table.Column<int>(nullable: true),
                    F1694 = table.Column<int>(nullable: true),
                    F1695 = table.Column<int>(nullable: true),
                    F1696 = table.Column<int>(nullable: true),
                    F1697 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F1699 = table.Column<double>(nullable: true),
                    F1711 = table.Column<int>(nullable: true),
                    F1763 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F1764 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F1938 = table.Column<double>(nullable: true),
                    F2596 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F2598 = table.Column<double>(nullable: true),
                    F2599 = table.Column<double>(nullable: true),
                    F2613 = table.Column<int>(nullable: true),
                    F2614 = table.Column<decimal>(type: "money", nullable: true),
                    F2615 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F2616 = table.Column<int>(nullable: true),
                    F2617 = table.Column<decimal>(type: "money", nullable: true),
                    F2618 = table.Column<decimal>(type: "money", nullable: true),
                    F2619 = table.Column<double>(nullable: true),
                    F2620 = table.Column<double>(nullable: true),
                    F2621 = table.Column<int>(nullable: true),
                    F2622 = table.Column<int>(nullable: true),
                    F2623 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F2816 = table.Column<string>(unicode: false, maxLength: 5, nullable: true),
                    F2848 = table.Column<string>(unicode: false, maxLength: 5000, nullable: true),
                    F2889 = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    F2904 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F2934 = table.Column<string>(unicode: false, maxLength: 160, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("SAL_BAT_P1032", x => x.F1032);
                });

            migrationBuilder.CreateTable(
                name: "SAL_DET",
                columns: table => new
                {
                    F1032 = table.Column<int>(nullable: false),
                    F1101 = table.Column<int>(nullable: false),
                    F2770 = table.Column<int>(nullable: false),
                    F01 = table.Column<string>(unicode: false, maxLength: 13, nullable: true),
                    F64 = table.Column<double>(nullable: true),
                    F65 = table.Column<decimal>(type: "money", nullable: true),
                    F1041 = table.Column<string>(unicode: false, maxLength: 60, nullable: true),
                    F1079 = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    F1081 = table.Column<string>(unicode: false, maxLength: 5000, nullable: true),
                    F1691 = table.Column<string>(unicode: false, maxLength: 250, nullable: true),
                    F1802 = table.Column<int>(nullable: true),
                    F2771 = table.Column<string>(unicode: false, maxLength: 16, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("SAL_DET_P1032", x => new { x.F1032, x.F1101, x.F2770 });
                });

            migrationBuilder.CreateTable(
                name: "SAL_DET_SAV",
                columns: table => new
                {
                    F1505 = table.Column<DateTime>(type: "datetime", nullable: false),
                    F1056 = table.Column<string>(unicode: false, maxLength: 4, nullable: false),
                    F1057 = table.Column<string>(unicode: false, maxLength: 4, nullable: false),
                    F1032 = table.Column<int>(nullable: false),
                    F1101 = table.Column<int>(nullable: false),
                    F2770 = table.Column<int>(nullable: false),
                    F2890 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F01 = table.Column<string>(unicode: false, maxLength: 13, nullable: true),
                    F64 = table.Column<decimal>(type: "numeric(20, 4)", nullable: true),
                    F65 = table.Column<decimal>(type: "money", nullable: true),
                    F1041 = table.Column<string>(unicode: false, maxLength: 60, nullable: true),
                    F1079 = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    F1081 = table.Column<string>(unicode: false, maxLength: 5000, nullable: true),
                    F1691 = table.Column<string>(unicode: false, maxLength: 250, nullable: true),
                    F1802 = table.Column<int>(nullable: true),
                    F2771 = table.Column<string>(unicode: false, maxLength: 16, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("SAL_DET_SAV_P1032", x => new { x.F1505, x.F1056, x.F1057, x.F1032, x.F1101, x.F2770 });
                });

            migrationBuilder.CreateTable(
                name: "SAL_HDR",
                columns: table => new
                {
                    F1032 = table.Column<int>(nullable: false),
                    F1148 = table.Column<string>(unicode: false, maxLength: 14, nullable: true),
                    F76 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F91 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    F253 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F254 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F902 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F1035 = table.Column<string>(unicode: false, maxLength: 6, nullable: true),
                    F1036 = table.Column<string>(unicode: false, maxLength: 6, nullable: true),
                    F1056 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F1057 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F1067 = table.Column<string>(unicode: false, maxLength: 7, nullable: true),
                    F1068 = table.Column<string>(unicode: false, maxLength: 6, nullable: true),
                    F1101 = table.Column<int>(nullable: true),
                    F1126 = table.Column<int>(nullable: true),
                    F1127 = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    F1137 = table.Column<int>(nullable: true),
                    F1149 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F1150 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F1151 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F1152 = table.Column<int>(nullable: true),
                    F1153 = table.Column<int>(nullable: true),
                    F1154 = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    F1155 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F1156 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F1157 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F1158 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F1159 = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    F1160 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    F1161 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    F1163 = table.Column<int>(nullable: true),
                    F1164 = table.Column<double>(nullable: true),
                    F1165 = table.Column<decimal>(type: "money", nullable: true),
                    F1167 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    F1168 = table.Column<int>(nullable: true),
                    F1170 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    F1171 = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    F1172 = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    F1173 = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    F1185 = table.Column<int>(nullable: true),
                    F1238 = table.Column<int>(nullable: true),
                    F1242 = table.Column<decimal>(type: "money", nullable: true),
                    F1245 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    F1246 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F1254 = table.Column<string>(unicode: false, maxLength: 5000, nullable: true),
                    F1255 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F1271 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F1272 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F1273 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F1274 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F1277 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F1287 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F1288 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F1295 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F1504 = table.Column<string>(unicode: false, maxLength: 2, nullable: true),
                    F1520 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F1573 = table.Column<string>(unicode: false, maxLength: 60, nullable: true),
                    F1642 = table.Column<string>(unicode: false, maxLength: 14, nullable: true),
                    F1643 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F1644 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F1645 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F1646 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F1647 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F1648 = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    F1649 = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    F1650 = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    F1651 = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    F1652 = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    F1653 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F1654 = table.Column<double>(nullable: true),
                    F1655 = table.Column<double>(nullable: true),
                    F1685 = table.Column<int>(nullable: true),
                    F1686 = table.Column<int>(nullable: true),
                    F1687 = table.Column<int>(nullable: true),
                    F1688 = table.Column<int>(nullable: true),
                    F1689 = table.Column<int>(nullable: true),
                    F1692 = table.Column<string>(unicode: false, maxLength: 160, nullable: true),
                    F1693 = table.Column<int>(nullable: true),
                    F1694 = table.Column<int>(nullable: true),
                    F1695 = table.Column<int>(nullable: true),
                    F1696 = table.Column<int>(nullable: true),
                    F1697 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F1699 = table.Column<double>(nullable: true),
                    F1711 = table.Column<int>(nullable: true),
                    F1763 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F1764 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F1938 = table.Column<double>(nullable: true),
                    F2596 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F2598 = table.Column<double>(nullable: true),
                    F2599 = table.Column<double>(nullable: true),
                    F2613 = table.Column<int>(nullable: true),
                    F2614 = table.Column<decimal>(type: "money", nullable: true),
                    F2615 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F2616 = table.Column<int>(nullable: true),
                    F2617 = table.Column<decimal>(type: "money", nullable: true),
                    F2618 = table.Column<decimal>(type: "money", nullable: true),
                    F2619 = table.Column<double>(nullable: true),
                    F2620 = table.Column<double>(nullable: true),
                    F2621 = table.Column<int>(nullable: true),
                    F2622 = table.Column<int>(nullable: true),
                    F2623 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F2816 = table.Column<string>(unicode: false, maxLength: 5, nullable: true),
                    F2848 = table.Column<string>(unicode: false, maxLength: 5000, nullable: true),
                    F2889 = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    F2904 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F2934 = table.Column<string>(unicode: false, maxLength: 160, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("SAL_HDR_P1032", x => x.F1032);
                });

            migrationBuilder.CreateTable(
                name: "SAL_HDR_SAV",
                columns: table => new
                {
                    F1505 = table.Column<DateTime>(type: "datetime", nullable: false),
                    F1056 = table.Column<string>(unicode: false, maxLength: 4, nullable: false),
                    F1057 = table.Column<string>(unicode: false, maxLength: 4, nullable: false),
                    F1032 = table.Column<int>(nullable: false),
                    F2890 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F1148 = table.Column<string>(unicode: false, maxLength: 14, nullable: true),
                    F76 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F91 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    F253 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F254 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F902 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F1035 = table.Column<string>(unicode: false, maxLength: 6, nullable: true),
                    F1036 = table.Column<string>(unicode: false, maxLength: 6, nullable: true),
                    F1067 = table.Column<string>(unicode: false, maxLength: 7, nullable: true),
                    F1068 = table.Column<string>(unicode: false, maxLength: 6, nullable: true),
                    F1101 = table.Column<int>(nullable: true),
                    F1126 = table.Column<int>(nullable: true),
                    F1127 = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    F1137 = table.Column<int>(nullable: true),
                    F1149 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F1150 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F1151 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F1152 = table.Column<int>(nullable: true),
                    F1153 = table.Column<int>(nullable: true),
                    F1154 = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    F1155 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F1156 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F1157 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F1158 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F1159 = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    F1160 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    F1161 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    F1163 = table.Column<int>(nullable: true),
                    F1164 = table.Column<decimal>(type: "numeric(20, 4)", nullable: true),
                    F1165 = table.Column<decimal>(type: "money", nullable: true),
                    F1167 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    F1168 = table.Column<int>(nullable: true),
                    F1170 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    F1171 = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    F1172 = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    F1173 = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    F1185 = table.Column<int>(nullable: true),
                    F1238 = table.Column<int>(nullable: true),
                    F1242 = table.Column<decimal>(type: "money", nullable: true),
                    F1245 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    F1246 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F1254 = table.Column<string>(unicode: false, maxLength: 5000, nullable: true),
                    F1255 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F1271 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F1272 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F1273 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F1274 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F1277 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F1287 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F1288 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F1295 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F1504 = table.Column<string>(unicode: false, maxLength: 2, nullable: true),
                    F1520 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F1573 = table.Column<string>(unicode: false, maxLength: 60, nullable: true),
                    F1642 = table.Column<string>(unicode: false, maxLength: 14, nullable: true),
                    F1643 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F1644 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F1645 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F1646 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F1647 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F1648 = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    F1649 = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    F1650 = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    F1651 = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    F1652 = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    F1653 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F1654 = table.Column<decimal>(type: "numeric(20, 4)", nullable: true),
                    F1655 = table.Column<decimal>(type: "numeric(20, 4)", nullable: true),
                    F1685 = table.Column<int>(nullable: true),
                    F1686 = table.Column<int>(nullable: true),
                    F1687 = table.Column<int>(nullable: true),
                    F1688 = table.Column<int>(nullable: true),
                    F1689 = table.Column<int>(nullable: true),
                    F1692 = table.Column<string>(unicode: false, maxLength: 160, nullable: true),
                    F1693 = table.Column<int>(nullable: true),
                    F1694 = table.Column<int>(nullable: true),
                    F1695 = table.Column<int>(nullable: true),
                    F1696 = table.Column<int>(nullable: true),
                    F1697 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F1699 = table.Column<decimal>(type: "numeric(20, 4)", nullable: true),
                    F1711 = table.Column<int>(nullable: true),
                    F1763 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F1764 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F1938 = table.Column<decimal>(type: "numeric(20, 4)", nullable: true),
                    F2596 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F2598 = table.Column<decimal>(type: "numeric(20, 4)", nullable: true),
                    F2599 = table.Column<decimal>(type: "numeric(20, 4)", nullable: true),
                    F2613 = table.Column<int>(nullable: true),
                    F2614 = table.Column<decimal>(type: "money", nullable: true),
                    F2615 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F2616 = table.Column<int>(nullable: true),
                    F2617 = table.Column<decimal>(type: "money", nullable: true),
                    F2618 = table.Column<decimal>(type: "money", nullable: true),
                    F2619 = table.Column<decimal>(type: "numeric(20, 4)", nullable: true),
                    F2620 = table.Column<decimal>(type: "numeric(20, 4)", nullable: true),
                    F2621 = table.Column<int>(nullable: true),
                    F2622 = table.Column<int>(nullable: true),
                    F2623 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F2816 = table.Column<string>(unicode: false, maxLength: 5, nullable: true),
                    F2848 = table.Column<string>(unicode: false, maxLength: 5000, nullable: true),
                    F2889 = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    F2904 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F2934 = table.Column<string>(unicode: false, maxLength: 160, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("SAL_HDR_SAV_P1032", x => new { x.F1505, x.F1056, x.F1057, x.F1032 });
                });

            migrationBuilder.CreateTable(
                name: "SAL_REG",
                columns: table => new
                {
                    F1032 = table.Column<int>(nullable: false),
                    F1101 = table.Column<int>(nullable: false),
                    F01 = table.Column<string>(unicode: false, maxLength: 13, nullable: true),
                    F03 = table.Column<int>(nullable: true),
                    F04 = table.Column<int>(nullable: true),
                    F05 = table.Column<int>(nullable: true),
                    F06 = table.Column<int>(nullable: true),
                    F08 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F24 = table.Column<double>(nullable: true),
                    F30 = table.Column<decimal>(type: "money", nullable: true),
                    F31 = table.Column<double>(nullable: true),
                    F43 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F50 = table.Column<decimal>(type: "money", nullable: true),
                    F60 = table.Column<decimal>(type: "money", nullable: true),
                    F61 = table.Column<decimal>(type: "money", nullable: true),
                    F64 = table.Column<double>(nullable: true),
                    F65 = table.Column<decimal>(type: "money", nullable: true),
                    F67 = table.Column<double>(nullable: true),
                    F77 = table.Column<int>(nullable: true),
                    F79 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F80 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F81 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F82 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F83 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F88 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F96 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F97 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F98 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F99 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F100 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F101 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F102 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F104 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F106 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F108 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F109 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F110 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F113 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F114 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F115 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F117 = table.Column<string>(unicode: false, maxLength: 16, nullable: true),
                    F124 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F125 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F126 = table.Column<int>(nullable: true),
                    F149 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F150 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F160 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F163 = table.Column<int>(nullable: true),
                    F168 = table.Column<decimal>(type: "money", nullable: true),
                    F169 = table.Column<int>(nullable: true),
                    F170 = table.Column<int>(nullable: true),
                    F171 = table.Column<int>(nullable: true),
                    F172 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F173 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F175 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F177 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F178 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F253 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F254 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F270 = table.Column<double>(nullable: true),
                    F383 = table.Column<string>(unicode: false, maxLength: 80, nullable: true),
                    F903 = table.Column<string>(unicode: false, maxLength: 16, nullable: true),
                    F1002 = table.Column<double>(nullable: true),
                    F1006 = table.Column<double>(nullable: true),
                    F1007 = table.Column<decimal>(type: "money", nullable: true),
                    F1034 = table.Column<int>(nullable: true),
                    F1041 = table.Column<string>(unicode: false, maxLength: 60, nullable: true),
                    F1063 = table.Column<int>(nullable: true),
                    F1067 = table.Column<string>(unicode: false, maxLength: 7, nullable: true),
                    F1069 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F1070 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F1071 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F1072 = table.Column<int>(nullable: true),
                    F1078 = table.Column<double>(nullable: true),
                    F1079 = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    F1080 = table.Column<double>(nullable: true),
                    F1081 = table.Column<string>(unicode: false, maxLength: 5000, nullable: true),
                    F1086 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F1120 = table.Column<string>(unicode: false, maxLength: 12, nullable: true),
                    F1126 = table.Column<int>(nullable: true),
                    F1136 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F1164 = table.Column<double>(nullable: true),
                    F1178 = table.Column<double>(nullable: true),
                    F1185 = table.Column<int>(nullable: true),
                    F1203 = table.Column<decimal>(type: "money", nullable: true),
                    F1204 = table.Column<double>(nullable: true),
                    F1205 = table.Column<decimal>(type: "money", nullable: true),
                    F1206 = table.Column<double>(nullable: true),
                    F1207 = table.Column<int>(nullable: true),
                    F1208 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F1209 = table.Column<int>(nullable: true),
                    F1224 = table.Column<decimal>(type: "money", nullable: true),
                    F1225 = table.Column<double>(nullable: true),
                    F1239 = table.Column<int>(nullable: true),
                    F1240 = table.Column<decimal>(type: "money", nullable: true),
                    F1241 = table.Column<decimal>(type: "money", nullable: true),
                    F1256 = table.Column<double>(nullable: true),
                    F1263 = table.Column<decimal>(type: "money", nullable: true),
                    F1595 = table.Column<decimal>(type: "money", nullable: true),
                    F1596 = table.Column<int>(nullable: true),
                    F1683 = table.Column<double>(nullable: true),
                    F1684 = table.Column<double>(nullable: true),
                    F1687 = table.Column<int>(nullable: true),
                    F1691 = table.Column<string>(unicode: false, maxLength: 250, nullable: true),
                    F1693 = table.Column<int>(nullable: true),
                    F1694 = table.Column<int>(nullable: true),
                    F1699 = table.Column<double>(nullable: true),
                    F1712 = table.Column<double>(nullable: true),
                    F1715 = table.Column<decimal>(type: "money", nullable: true),
                    F1716 = table.Column<decimal>(type: "money", nullable: true),
                    F1717 = table.Column<double>(nullable: true),
                    F1718 = table.Column<int>(nullable: true),
                    F1719 = table.Column<decimal>(type: "money", nullable: true),
                    F1720 = table.Column<decimal>(type: "money", nullable: true),
                    F1721 = table.Column<int>(nullable: true),
                    F1722 = table.Column<decimal>(type: "money", nullable: true),
                    F1723 = table.Column<decimal>(type: "money", nullable: true),
                    F1724 = table.Column<decimal>(type: "money", nullable: true),
                    F1725 = table.Column<double>(nullable: true),
                    F1726 = table.Column<decimal>(type: "money", nullable: true),
                    F1727 = table.Column<decimal>(type: "money", nullable: true),
                    F1728 = table.Column<decimal>(type: "money", nullable: true),
                    F1729 = table.Column<decimal>(type: "money", nullable: true),
                    F1730 = table.Column<decimal>(type: "money", nullable: true),
                    F1731 = table.Column<int>(nullable: true),
                    F1732 = table.Column<double>(nullable: true),
                    F1733 = table.Column<decimal>(type: "money", nullable: true),
                    F1734 = table.Column<decimal>(type: "money", nullable: true),
                    F1739 = table.Column<double>(nullable: true),
                    F1740 = table.Column<double>(nullable: true),
                    F1741 = table.Column<string>(unicode: false, maxLength: 16, nullable: true),
                    F1742 = table.Column<string>(unicode: false, maxLength: 16, nullable: true),
                    F1785 = table.Column<string>(unicode: false, maxLength: 12, nullable: true),
                    F1787 = table.Column<int>(nullable: true),
                    F1789 = table.Column<double>(nullable: true),
                    F1802 = table.Column<int>(nullable: true),
                    F1803 = table.Column<double>(nullable: true),
                    F1805 = table.Column<decimal>(type: "money", nullable: true),
                    F1815 = table.Column<decimal>(type: "money", nullable: true),
                    F1816 = table.Column<int>(nullable: true),
                    F1831 = table.Column<int>(nullable: true),
                    F1832 = table.Column<int>(nullable: true),
                    F1833 = table.Column<decimal>(type: "money", nullable: true),
                    F1834 = table.Column<decimal>(type: "money", nullable: true),
                    F1835 = table.Column<double>(nullable: true),
                    F1860 = table.Column<int>(nullable: true),
                    F1861 = table.Column<double>(nullable: true),
                    F1862 = table.Column<int>(nullable: true),
                    F1863 = table.Column<double>(nullable: true),
                    F1864 = table.Column<double>(nullable: true),
                    F1874 = table.Column<int>(nullable: true),
                    F1888 = table.Column<double>(nullable: true),
                    F1924 = table.Column<double>(nullable: true),
                    F1925 = table.Column<double>(nullable: true),
                    F1926 = table.Column<double>(nullable: true),
                    F1927 = table.Column<double>(nullable: true),
                    F1928 = table.Column<double>(nullable: true),
                    F1929 = table.Column<int>(nullable: true),
                    F1930 = table.Column<int>(nullable: true),
                    F1931 = table.Column<int>(nullable: true),
                    F1932 = table.Column<decimal>(type: "money", nullable: true),
                    F1933 = table.Column<decimal>(type: "money", nullable: true),
                    F1934 = table.Column<decimal>(type: "money", nullable: true),
                    F1935 = table.Column<decimal>(type: "money", nullable: true),
                    F1936 = table.Column<decimal>(type: "money", nullable: true),
                    F1938 = table.Column<double>(nullable: true),
                    F2551 = table.Column<decimal>(type: "money", nullable: true),
                    F2552 = table.Column<decimal>(type: "money", nullable: true),
                    F2553 = table.Column<decimal>(type: "money", nullable: true),
                    F2554 = table.Column<decimal>(type: "money", nullable: true),
                    F2555 = table.Column<decimal>(type: "money", nullable: true),
                    F2608 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F2609 = table.Column<int>(nullable: true),
                    F2610 = table.Column<decimal>(type: "money", nullable: true),
                    F2611 = table.Column<decimal>(type: "money", nullable: true),
                    F2612 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F2613 = table.Column<int>(nullable: true),
                    F2614 = table.Column<decimal>(type: "money", nullable: true),
                    F2660 = table.Column<string>(unicode: false, maxLength: 250, nullable: true),
                    F2744 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F2745 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F2746 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F2747 = table.Column<int>(nullable: true),
                    F2748 = table.Column<int>(nullable: true),
                    F2749 = table.Column<int>(nullable: true),
                    F2750 = table.Column<int>(nullable: true),
                    F2751 = table.Column<int>(nullable: true),
                    F2752 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F2753 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F2860 = table.Column<double>(nullable: true),
                    F2861 = table.Column<int>(nullable: true),
                    F2862 = table.Column<int>(nullable: true),
                    F2863 = table.Column<int>(nullable: true),
                    F2865 = table.Column<double>(nullable: true),
                    F2866 = table.Column<double>(nullable: true),
                    F2867 = table.Column<double>(nullable: true),
                    F2869 = table.Column<decimal>(type: "money", nullable: true),
                    F2870 = table.Column<decimal>(type: "money", nullable: true),
                    F2871 = table.Column<decimal>(type: "money", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("SAL_REG_P1032", x => new { x.F1032, x.F1101 });
                });

            migrationBuilder.CreateTable(
                name: "SAL_REG_SAV",
                columns: table => new
                {
                    F1505 = table.Column<DateTime>(type: "datetime", nullable: false),
                    F1056 = table.Column<string>(unicode: false, maxLength: 4, nullable: false),
                    F1057 = table.Column<string>(unicode: false, maxLength: 4, nullable: false),
                    F1032 = table.Column<int>(nullable: false),
                    F1101 = table.Column<int>(nullable: false),
                    F2890 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F01 = table.Column<string>(unicode: false, maxLength: 13, nullable: true),
                    F03 = table.Column<int>(nullable: true),
                    F04 = table.Column<int>(nullable: true),
                    F05 = table.Column<int>(nullable: true),
                    F06 = table.Column<int>(nullable: true),
                    F08 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F24 = table.Column<decimal>(type: "numeric(20, 4)", nullable: true),
                    F30 = table.Column<decimal>(type: "money", nullable: true),
                    F31 = table.Column<decimal>(type: "numeric(20, 4)", nullable: true),
                    F43 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F50 = table.Column<decimal>(type: "money", nullable: true),
                    F60 = table.Column<decimal>(type: "money", nullable: true),
                    F61 = table.Column<decimal>(type: "money", nullable: true),
                    F64 = table.Column<decimal>(type: "numeric(20, 4)", nullable: true),
                    F65 = table.Column<decimal>(type: "money", nullable: true),
                    F67 = table.Column<decimal>(type: "numeric(20, 4)", nullable: true),
                    F77 = table.Column<int>(nullable: true),
                    F79 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F80 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F81 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F82 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F83 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F88 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F96 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F97 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F98 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F99 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F100 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F101 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F102 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F104 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F106 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F108 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F109 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F110 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F113 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F114 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F115 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F117 = table.Column<string>(unicode: false, maxLength: 16, nullable: true),
                    F124 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F125 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F126 = table.Column<int>(nullable: true),
                    F149 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F150 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F160 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F163 = table.Column<int>(nullable: true),
                    F168 = table.Column<decimal>(type: "money", nullable: true),
                    F169 = table.Column<int>(nullable: true),
                    F170 = table.Column<int>(nullable: true),
                    F171 = table.Column<int>(nullable: true),
                    F172 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F173 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F175 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F177 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F178 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F253 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F254 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F270 = table.Column<decimal>(type: "numeric(20, 4)", nullable: true),
                    F383 = table.Column<string>(unicode: false, maxLength: 80, nullable: true),
                    F903 = table.Column<string>(unicode: false, maxLength: 16, nullable: true),
                    F1002 = table.Column<decimal>(type: "numeric(20, 4)", nullable: true),
                    F1006 = table.Column<decimal>(type: "numeric(20, 4)", nullable: true),
                    F1007 = table.Column<decimal>(type: "money", nullable: true),
                    F1034 = table.Column<int>(nullable: true),
                    F1041 = table.Column<string>(unicode: false, maxLength: 60, nullable: true),
                    F1063 = table.Column<int>(nullable: true),
                    F1067 = table.Column<string>(unicode: false, maxLength: 7, nullable: true),
                    F1069 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F1070 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F1071 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F1072 = table.Column<int>(nullable: true),
                    F1078 = table.Column<decimal>(type: "numeric(20, 4)", nullable: true),
                    F1079 = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    F1080 = table.Column<decimal>(type: "numeric(20, 4)", nullable: true),
                    F1081 = table.Column<string>(unicode: false, maxLength: 5000, nullable: true),
                    F1086 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F1120 = table.Column<string>(unicode: false, maxLength: 12, nullable: true),
                    F1126 = table.Column<int>(nullable: true),
                    F1136 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F1164 = table.Column<decimal>(type: "numeric(20, 4)", nullable: true),
                    F1178 = table.Column<decimal>(type: "numeric(20, 4)", nullable: true),
                    F1185 = table.Column<int>(nullable: true),
                    F1203 = table.Column<decimal>(type: "money", nullable: true),
                    F1204 = table.Column<decimal>(type: "numeric(20, 4)", nullable: true),
                    F1205 = table.Column<decimal>(type: "money", nullable: true),
                    F1206 = table.Column<decimal>(type: "numeric(20, 4)", nullable: true),
                    F1207 = table.Column<int>(nullable: true),
                    F1208 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F1209 = table.Column<int>(nullable: true),
                    F1224 = table.Column<decimal>(type: "money", nullable: true),
                    F1225 = table.Column<decimal>(type: "numeric(20, 4)", nullable: true),
                    F1239 = table.Column<int>(nullable: true),
                    F1240 = table.Column<decimal>(type: "money", nullable: true),
                    F1241 = table.Column<decimal>(type: "money", nullable: true),
                    F1256 = table.Column<decimal>(type: "numeric(20, 4)", nullable: true),
                    F1263 = table.Column<decimal>(type: "money", nullable: true),
                    F1595 = table.Column<decimal>(type: "money", nullable: true),
                    F1596 = table.Column<int>(nullable: true),
                    F1683 = table.Column<decimal>(type: "numeric(20, 4)", nullable: true),
                    F1684 = table.Column<decimal>(type: "numeric(20, 4)", nullable: true),
                    F1687 = table.Column<int>(nullable: true),
                    F1691 = table.Column<string>(unicode: false, maxLength: 250, nullable: true),
                    F1693 = table.Column<int>(nullable: true),
                    F1694 = table.Column<int>(nullable: true),
                    F1699 = table.Column<decimal>(type: "numeric(20, 4)", nullable: true),
                    F1712 = table.Column<decimal>(type: "numeric(20, 4)", nullable: true),
                    F1715 = table.Column<decimal>(type: "money", nullable: true),
                    F1716 = table.Column<decimal>(type: "money", nullable: true),
                    F1717 = table.Column<decimal>(type: "numeric(20, 4)", nullable: true),
                    F1718 = table.Column<int>(nullable: true),
                    F1719 = table.Column<decimal>(type: "money", nullable: true),
                    F1720 = table.Column<decimal>(type: "money", nullable: true),
                    F1721 = table.Column<int>(nullable: true),
                    F1722 = table.Column<decimal>(type: "money", nullable: true),
                    F1723 = table.Column<decimal>(type: "money", nullable: true),
                    F1724 = table.Column<decimal>(type: "money", nullable: true),
                    F1725 = table.Column<decimal>(type: "numeric(20, 4)", nullable: true),
                    F1726 = table.Column<decimal>(type: "money", nullable: true),
                    F1727 = table.Column<decimal>(type: "money", nullable: true),
                    F1728 = table.Column<decimal>(type: "money", nullable: true),
                    F1729 = table.Column<decimal>(type: "money", nullable: true),
                    F1730 = table.Column<decimal>(type: "money", nullable: true),
                    F1731 = table.Column<int>(nullable: true),
                    F1732 = table.Column<decimal>(type: "numeric(20, 4)", nullable: true),
                    F1733 = table.Column<decimal>(type: "money", nullable: true),
                    F1734 = table.Column<decimal>(type: "money", nullable: true),
                    F1739 = table.Column<decimal>(type: "numeric(20, 4)", nullable: true),
                    F1740 = table.Column<decimal>(type: "numeric(20, 4)", nullable: true),
                    F1741 = table.Column<string>(unicode: false, maxLength: 16, nullable: true),
                    F1742 = table.Column<string>(unicode: false, maxLength: 16, nullable: true),
                    F1785 = table.Column<string>(unicode: false, maxLength: 12, nullable: true),
                    F1787 = table.Column<int>(nullable: true),
                    F1789 = table.Column<decimal>(type: "numeric(20, 4)", nullable: true),
                    F1802 = table.Column<int>(nullable: true),
                    F1803 = table.Column<decimal>(type: "numeric(20, 4)", nullable: true),
                    F1805 = table.Column<decimal>(type: "money", nullable: true),
                    F1815 = table.Column<decimal>(type: "money", nullable: true),
                    F1816 = table.Column<int>(nullable: true),
                    F1831 = table.Column<int>(nullable: true),
                    F1832 = table.Column<int>(nullable: true),
                    F1833 = table.Column<decimal>(type: "money", nullable: true),
                    F1834 = table.Column<decimal>(type: "money", nullable: true),
                    F1835 = table.Column<decimal>(type: "numeric(20, 4)", nullable: true),
                    F1860 = table.Column<int>(nullable: true),
                    F1861 = table.Column<decimal>(type: "numeric(20, 4)", nullable: true),
                    F1862 = table.Column<int>(nullable: true),
                    F1863 = table.Column<decimal>(type: "numeric(20, 4)", nullable: true),
                    F1864 = table.Column<decimal>(type: "numeric(20, 4)", nullable: true),
                    F1874 = table.Column<int>(nullable: true),
                    F1888 = table.Column<decimal>(type: "numeric(20, 4)", nullable: true),
                    F1924 = table.Column<decimal>(type: "numeric(20, 4)", nullable: true),
                    F1925 = table.Column<decimal>(type: "numeric(20, 4)", nullable: true),
                    F1926 = table.Column<decimal>(type: "numeric(20, 4)", nullable: true),
                    F1927 = table.Column<decimal>(type: "numeric(20, 4)", nullable: true),
                    F1928 = table.Column<decimal>(type: "numeric(20, 4)", nullable: true),
                    F1929 = table.Column<int>(nullable: true),
                    F1930 = table.Column<int>(nullable: true),
                    F1931 = table.Column<int>(nullable: true),
                    F1932 = table.Column<decimal>(type: "money", nullable: true),
                    F1933 = table.Column<decimal>(type: "money", nullable: true),
                    F1934 = table.Column<decimal>(type: "money", nullable: true),
                    F1935 = table.Column<decimal>(type: "money", nullable: true),
                    F1936 = table.Column<decimal>(type: "money", nullable: true),
                    F1938 = table.Column<decimal>(type: "numeric(20, 4)", nullable: true),
                    F2551 = table.Column<decimal>(type: "money", nullable: true),
                    F2552 = table.Column<decimal>(type: "money", nullable: true),
                    F2553 = table.Column<decimal>(type: "money", nullable: true),
                    F2554 = table.Column<decimal>(type: "money", nullable: true),
                    F2555 = table.Column<decimal>(type: "money", nullable: true),
                    F2608 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F2609 = table.Column<int>(nullable: true),
                    F2610 = table.Column<decimal>(type: "money", nullable: true),
                    F2611 = table.Column<decimal>(type: "money", nullable: true),
                    F2612 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F2613 = table.Column<int>(nullable: true),
                    F2614 = table.Column<decimal>(type: "money", nullable: true),
                    F2660 = table.Column<string>(unicode: false, maxLength: 250, nullable: true),
                    F2744 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F2745 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F2746 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F2747 = table.Column<int>(nullable: true),
                    F2748 = table.Column<int>(nullable: true),
                    F2749 = table.Column<int>(nullable: true),
                    F2750 = table.Column<int>(nullable: true),
                    F2751 = table.Column<int>(nullable: true),
                    F2752 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F2753 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F2860 = table.Column<decimal>(type: "numeric(20, 4)", nullable: true),
                    F2861 = table.Column<int>(nullable: true),
                    F2862 = table.Column<int>(nullable: true),
                    F2863 = table.Column<int>(nullable: true),
                    F2865 = table.Column<decimal>(type: "numeric(20, 4)", nullable: true),
                    F2866 = table.Column<decimal>(type: "numeric(20, 4)", nullable: true),
                    F2867 = table.Column<decimal>(type: "numeric(20, 4)", nullable: true),
                    F2869 = table.Column<decimal>(type: "money", nullable: true),
                    F2870 = table.Column<decimal>(type: "money", nullable: true),
                    F2871 = table.Column<decimal>(type: "money", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("SAL_REG_SAV_P1032", x => new { x.F1505, x.F1056, x.F1057, x.F1032, x.F1101 });
                });

            migrationBuilder.CreateTable(
                name: "SAL_TTL",
                columns: table => new
                {
                    F1032 = table.Column<int>(nullable: false),
                    F1034 = table.Column<int>(nullable: false),
                    F64 = table.Column<double>(nullable: true),
                    F65 = table.Column<decimal>(type: "money", nullable: true),
                    F67 = table.Column<double>(nullable: true),
                    F1039 = table.Column<string>(unicode: false, maxLength: 60, nullable: true),
                    F1067 = table.Column<string>(unicode: false, maxLength: 7, nullable: true),
                    F1093 = table.Column<decimal>(type: "money", nullable: true),
                    F1094 = table.Column<decimal>(type: "money", nullable: true),
                    F1095 = table.Column<decimal>(type: "money", nullable: true),
                    F1096 = table.Column<decimal>(type: "money", nullable: true),
                    F1097 = table.Column<decimal>(type: "money", nullable: true),
                    F1098 = table.Column<decimal>(type: "money", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("SAL_TTL_P1032", x => new { x.F1032, x.F1034 });
                });

            migrationBuilder.CreateTable(
                name: "SAL_TTL_SAV",
                columns: table => new
                {
                    F1505 = table.Column<DateTime>(type: "datetime", nullable: false),
                    F1056 = table.Column<string>(unicode: false, maxLength: 4, nullable: false),
                    F1057 = table.Column<string>(unicode: false, maxLength: 4, nullable: false),
                    F1032 = table.Column<int>(nullable: false),
                    F1034 = table.Column<int>(nullable: false),
                    F2890 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F64 = table.Column<decimal>(type: "numeric(20, 4)", nullable: true),
                    F65 = table.Column<decimal>(type: "money", nullable: true),
                    F67 = table.Column<decimal>(type: "numeric(20, 4)", nullable: true),
                    F1039 = table.Column<string>(unicode: false, maxLength: 60, nullable: true),
                    F1067 = table.Column<string>(unicode: false, maxLength: 7, nullable: true),
                    F1093 = table.Column<decimal>(type: "money", nullable: true),
                    F1094 = table.Column<decimal>(type: "money", nullable: true),
                    F1095 = table.Column<decimal>(type: "money", nullable: true),
                    F1096 = table.Column<decimal>(type: "money", nullable: true),
                    F1097 = table.Column<decimal>(type: "money", nullable: true),
                    F1098 = table.Column<decimal>(type: "money", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("SAL_TTL_SAV_P1032", x => new { x.F1505, x.F1056, x.F1057, x.F1032, x.F1034 });
                });

            migrationBuilder.CreateTable(
                name: "SCL_CCT_DEL",
                columns: table => new
                {
                    F2802 = table.Column<int>(nullable: false),
                    F1000 = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    F04 = table.Column<int>(nullable: true),
                    F253 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F902 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F1001 = table.Column<int>(nullable: true),
                    F1759 = table.Column<int>(nullable: true),
                    F1964 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F2799 = table.Column<int>(nullable: true),
                    F2803 = table.Column<string>(unicode: false, maxLength: 512, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("SCL_CCT_DEL_P2802", x => new { x.F2802, x.F1000 });
                });

            migrationBuilder.CreateTable(
                name: "SCL_CCT_TAB",
                columns: table => new
                {
                    F2802 = table.Column<int>(nullable: false),
                    F1000 = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    F04 = table.Column<int>(nullable: true),
                    F253 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F902 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F1001 = table.Column<int>(nullable: true),
                    F1759 = table.Column<int>(nullable: true),
                    F1964 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F2799 = table.Column<int>(nullable: true),
                    F2803 = table.Column<string>(unicode: false, maxLength: 512, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("SCL_CCT_TAB_P2802", x => new { x.F2802, x.F1000 });
                });

            migrationBuilder.CreateTable(
                name: "SCL_CPT_DEL",
                columns: table => new
                {
                    F2804 = table.Column<int>(nullable: false),
                    F1000 = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    F04 = table.Column<int>(nullable: true),
                    F253 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F902 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F1001 = table.Column<int>(nullable: true),
                    F1759 = table.Column<int>(nullable: true),
                    F1964 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F2799 = table.Column<int>(nullable: true),
                    F2805 = table.Column<string>(unicode: false, maxLength: 2000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("SCL_CPT_DEL_P2804", x => new { x.F2804, x.F1000 });
                });

            migrationBuilder.CreateTable(
                name: "SCL_CPT_TAB",
                columns: table => new
                {
                    F2804 = table.Column<int>(nullable: false),
                    F1000 = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    F04 = table.Column<int>(nullable: true),
                    F253 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F902 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F1001 = table.Column<int>(nullable: true),
                    F1759 = table.Column<int>(nullable: true),
                    F1964 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F2799 = table.Column<int>(nullable: true),
                    F2805 = table.Column<string>(unicode: false, maxLength: 2000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("SCL_CPT_TAB_P2804", x => new { x.F2804, x.F1000 });
                });

            migrationBuilder.CreateTable(
                name: "SCL_CSL_DEL",
                columns: table => new
                {
                    F2797 = table.Column<int>(nullable: false),
                    F2798 = table.Column<int>(nullable: false),
                    F1000 = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    F04 = table.Column<int>(nullable: true),
                    F253 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F902 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F1001 = table.Column<int>(nullable: true),
                    F1759 = table.Column<int>(nullable: true),
                    F1964 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F2793 = table.Column<int>(nullable: true),
                    F2795 = table.Column<string>(unicode: false, maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("SCL_CSL_DEL_P2797", x => new { x.F2797, x.F2798, x.F1000 });
                });

            migrationBuilder.CreateTable(
                name: "SCL_CSL_TAB",
                columns: table => new
                {
                    F2797 = table.Column<int>(nullable: false),
                    F2798 = table.Column<int>(nullable: false),
                    F1000 = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    F04 = table.Column<int>(nullable: true),
                    F253 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F902 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F1001 = table.Column<int>(nullable: true),
                    F1759 = table.Column<int>(nullable: true),
                    F1964 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F2793 = table.Column<int>(nullable: true),
                    F2795 = table.Column<string>(unicode: false, maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("SCL_CSL_TAB_P2797", x => new { x.F2797, x.F2798, x.F1000 });
                });

            migrationBuilder.CreateTable(
                name: "SCL_CTX_DEL",
                columns: table => new
                {
                    F2793 = table.Column<int>(nullable: false),
                    F1000 = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    F04 = table.Column<int>(nullable: true),
                    F253 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F902 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F1001 = table.Column<int>(nullable: true),
                    F1759 = table.Column<int>(nullable: true),
                    F1964 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F2794 = table.Column<string>(unicode: false, maxLength: 512, nullable: true),
                    F2795 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F2938 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("SCL_CTX_DEL_P2793", x => new { x.F2793, x.F1000 });
                });

            migrationBuilder.CreateTable(
                name: "SCL_CTX_TAB",
                columns: table => new
                {
                    F2793 = table.Column<int>(nullable: false),
                    F1000 = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    F04 = table.Column<int>(nullable: true),
                    F253 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F902 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F1001 = table.Column<int>(nullable: true),
                    F1759 = table.Column<int>(nullable: true),
                    F1964 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F2794 = table.Column<string>(unicode: false, maxLength: 512, nullable: true),
                    F2795 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F2938 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("SCL_CTX_TAB_P2793", x => new { x.F2793, x.F1000 });
                });

            migrationBuilder.CreateTable(
                name: "SCL_DEL",
                columns: table => new
                {
                    F01 = table.Column<string>(unicode: false, maxLength: 13, nullable: false),
                    F1000 = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    F902 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F1001 = table.Column<int>(nullable: true),
                    F253 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F256 = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    F257 = table.Column<double>(nullable: true),
                    F258 = table.Column<double>(nullable: true),
                    F259 = table.Column<double>(nullable: true),
                    F260 = table.Column<double>(nullable: true),
                    F261 = table.Column<decimal>(type: "money", nullable: true),
                    F262 = table.Column<int>(nullable: true),
                    F263 = table.Column<int>(nullable: true),
                    F264 = table.Column<int>(nullable: true),
                    F265 = table.Column<double>(nullable: true),
                    F266 = table.Column<string>(unicode: false, maxLength: 12, nullable: true),
                    F267 = table.Column<int>(nullable: true),
                    F268 = table.Column<double>(nullable: true),
                    F269 = table.Column<double>(nullable: true),
                    F270 = table.Column<double>(nullable: true),
                    F271 = table.Column<double>(nullable: true),
                    F272 = table.Column<double>(nullable: true),
                    F273 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F274 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    F275 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    F1759 = table.Column<int>(nullable: true),
                    F1840 = table.Column<string>(unicode: false, maxLength: 12, nullable: true),
                    F1952 = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    F1964 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F2581 = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    F2582 = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    F2583 = table.Column<int>(nullable: true),
                    F2584 = table.Column<int>(nullable: true),
                    F2585 = table.Column<int>(nullable: true),
                    F2586 = table.Column<int>(nullable: true),
                    F2792 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F2793 = table.Column<int>(nullable: true),
                    F2796 = table.Column<int>(nullable: true),
                    F2797 = table.Column<int>(nullable: true),
                    F2799 = table.Column<int>(nullable: true),
                    F2800 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F2801 = table.Column<string>(unicode: false, maxLength: 250, nullable: true),
                    F2939 = table.Column<int>(nullable: true),
                    F2940 = table.Column<int>(nullable: true),
                    F2941 = table.Column<int>(nullable: true),
                    F2942 = table.Column<int>(nullable: true),
                    F2944 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F2945 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F2946 = table.Column<int>(nullable: true),
                    F2947 = table.Column<int>(nullable: true),
                    F2948 = table.Column<int>(nullable: true),
                    F2949 = table.Column<int>(nullable: true),
                    F2950 = table.Column<int>(nullable: true),
                    F2952 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("SCL_DEL_P01", x => new { x.F01, x.F1000 });
                });

            migrationBuilder.CreateTable(
                name: "SCL_NUT_DEL",
                columns: table => new
                {
                    F268 = table.Column<double>(nullable: false),
                    F1000 = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    F04 = table.Column<int>(nullable: true),
                    F197 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F198 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F199 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F200 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F253 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F276 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    F277 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    F278 = table.Column<double>(nullable: true),
                    F279 = table.Column<double>(nullable: true),
                    F280 = table.Column<double>(nullable: true),
                    F281 = table.Column<double>(nullable: true),
                    F282 = table.Column<double>(nullable: true),
                    F283 = table.Column<double>(nullable: true),
                    F284 = table.Column<double>(nullable: true),
                    F285 = table.Column<double>(nullable: true),
                    F286 = table.Column<double>(nullable: true),
                    F287 = table.Column<double>(nullable: true),
                    F288 = table.Column<double>(nullable: true),
                    F289 = table.Column<double>(nullable: true),
                    F290 = table.Column<double>(nullable: true),
                    F291 = table.Column<double>(nullable: true),
                    F292 = table.Column<double>(nullable: true),
                    F293 = table.Column<double>(nullable: true),
                    F294 = table.Column<double>(nullable: true),
                    F295 = table.Column<double>(nullable: true),
                    F296 = table.Column<double>(nullable: true),
                    F902 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F1001 = table.Column<int>(nullable: true),
                    F1759 = table.Column<int>(nullable: true),
                    F1964 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F2500 = table.Column<double>(nullable: true),
                    F2501 = table.Column<double>(nullable: true),
                    F2502 = table.Column<double>(nullable: true),
                    F2503 = table.Column<double>(nullable: true),
                    F2504 = table.Column<double>(nullable: true),
                    F2505 = table.Column<double>(nullable: true),
                    F2506 = table.Column<double>(nullable: true),
                    F2507 = table.Column<double>(nullable: true),
                    F2508 = table.Column<double>(nullable: true),
                    F2509 = table.Column<double>(nullable: true),
                    F2510 = table.Column<double>(nullable: true),
                    F2511 = table.Column<double>(nullable: true),
                    F2512 = table.Column<double>(nullable: true),
                    F2513 = table.Column<double>(nullable: true),
                    F2514 = table.Column<double>(nullable: true),
                    F2515 = table.Column<double>(nullable: true),
                    F2516 = table.Column<double>(nullable: true),
                    F2517 = table.Column<double>(nullable: true),
                    F2518 = table.Column<double>(nullable: true),
                    F2519 = table.Column<double>(nullable: true),
                    F2520 = table.Column<double>(nullable: true),
                    F2521 = table.Column<double>(nullable: true),
                    F2522 = table.Column<double>(nullable: true),
                    F2523 = table.Column<double>(nullable: true),
                    F2524 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F2525 = table.Column<double>(nullable: true),
                    F2526 = table.Column<double>(nullable: true),
                    F2527 = table.Column<double>(nullable: true),
                    F2528 = table.Column<double>(nullable: true),
                    F2529 = table.Column<double>(nullable: true),
                    F2530 = table.Column<double>(nullable: true),
                    F2531 = table.Column<double>(nullable: true),
                    F2532 = table.Column<double>(nullable: true),
                    F2533 = table.Column<double>(nullable: true),
                    F2534 = table.Column<double>(nullable: true),
                    F2535 = table.Column<double>(nullable: true),
                    F2536 = table.Column<double>(nullable: true),
                    F2537 = table.Column<double>(nullable: true),
                    F2538 = table.Column<double>(nullable: true),
                    F2539 = table.Column<double>(nullable: true),
                    F2540 = table.Column<double>(nullable: true),
                    F2541 = table.Column<double>(nullable: true),
                    F2542 = table.Column<double>(nullable: true),
                    F2543 = table.Column<double>(nullable: true),
                    F2544 = table.Column<double>(nullable: true),
                    F2545 = table.Column<double>(nullable: true),
                    F2546 = table.Column<double>(nullable: true),
                    F2547 = table.Column<double>(nullable: true),
                    F2548 = table.Column<double>(nullable: true),
                    F2549 = table.Column<double>(nullable: true),
                    F2550 = table.Column<double>(nullable: true),
                    F2852 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F2853 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F2854 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F2855 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F2856 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F2857 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F2858 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F2859 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F2951 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("SCL_NUT_DEL_P268", x => new { x.F268, x.F1000 });
                });

            migrationBuilder.CreateTable(
                name: "SCL_NUT_TAB",
                columns: table => new
                {
                    F268 = table.Column<double>(nullable: false),
                    F1000 = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    F04 = table.Column<int>(nullable: true),
                    F197 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F198 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F199 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F200 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F253 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F276 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    F277 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    F278 = table.Column<double>(nullable: true),
                    F279 = table.Column<double>(nullable: true),
                    F280 = table.Column<double>(nullable: true),
                    F281 = table.Column<double>(nullable: true),
                    F282 = table.Column<double>(nullable: true),
                    F283 = table.Column<double>(nullable: true),
                    F284 = table.Column<double>(nullable: true),
                    F285 = table.Column<double>(nullable: true),
                    F286 = table.Column<double>(nullable: true),
                    F287 = table.Column<double>(nullable: true),
                    F288 = table.Column<double>(nullable: true),
                    F289 = table.Column<double>(nullable: true),
                    F290 = table.Column<double>(nullable: true),
                    F291 = table.Column<double>(nullable: true),
                    F292 = table.Column<double>(nullable: true),
                    F293 = table.Column<double>(nullable: true),
                    F294 = table.Column<double>(nullable: true),
                    F295 = table.Column<double>(nullable: true),
                    F296 = table.Column<double>(nullable: true),
                    F902 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F1001 = table.Column<int>(nullable: true),
                    F1759 = table.Column<int>(nullable: true),
                    F1964 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F2500 = table.Column<double>(nullable: true),
                    F2501 = table.Column<double>(nullable: true),
                    F2502 = table.Column<double>(nullable: true),
                    F2503 = table.Column<double>(nullable: true),
                    F2504 = table.Column<double>(nullable: true),
                    F2505 = table.Column<double>(nullable: true),
                    F2506 = table.Column<double>(nullable: true),
                    F2507 = table.Column<double>(nullable: true),
                    F2508 = table.Column<double>(nullable: true),
                    F2509 = table.Column<double>(nullable: true),
                    F2510 = table.Column<double>(nullable: true),
                    F2511 = table.Column<double>(nullable: true),
                    F2512 = table.Column<double>(nullable: true),
                    F2513 = table.Column<double>(nullable: true),
                    F2514 = table.Column<double>(nullable: true),
                    F2515 = table.Column<double>(nullable: true),
                    F2516 = table.Column<double>(nullable: true),
                    F2517 = table.Column<double>(nullable: true),
                    F2518 = table.Column<double>(nullable: true),
                    F2519 = table.Column<double>(nullable: true),
                    F2520 = table.Column<double>(nullable: true),
                    F2521 = table.Column<double>(nullable: true),
                    F2522 = table.Column<double>(nullable: true),
                    F2523 = table.Column<double>(nullable: true),
                    F2524 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F2525 = table.Column<double>(nullable: true),
                    F2526 = table.Column<double>(nullable: true),
                    F2527 = table.Column<double>(nullable: true),
                    F2528 = table.Column<double>(nullable: true),
                    F2529 = table.Column<double>(nullable: true),
                    F2530 = table.Column<double>(nullable: true),
                    F2531 = table.Column<double>(nullable: true),
                    F2532 = table.Column<double>(nullable: true),
                    F2533 = table.Column<double>(nullable: true),
                    F2534 = table.Column<double>(nullable: true),
                    F2535 = table.Column<double>(nullable: true),
                    F2536 = table.Column<double>(nullable: true),
                    F2537 = table.Column<double>(nullable: true),
                    F2538 = table.Column<double>(nullable: true),
                    F2539 = table.Column<double>(nullable: true),
                    F2540 = table.Column<double>(nullable: true),
                    F2541 = table.Column<double>(nullable: true),
                    F2542 = table.Column<double>(nullable: true),
                    F2543 = table.Column<double>(nullable: true),
                    F2544 = table.Column<double>(nullable: true),
                    F2545 = table.Column<double>(nullable: true),
                    F2546 = table.Column<double>(nullable: true),
                    F2547 = table.Column<double>(nullable: true),
                    F2548 = table.Column<double>(nullable: true),
                    F2549 = table.Column<double>(nullable: true),
                    F2550 = table.Column<double>(nullable: true),
                    F2852 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F2853 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F2854 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F2855 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F2856 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F2857 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F2858 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F2859 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F2951 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("SCL_NUT_TAB_P268", x => new { x.F268, x.F1000 });
                });

            migrationBuilder.CreateTable(
                name: "SCL_STO_DEL",
                columns: table => new
                {
                    F2952 = table.Column<int>(nullable: false),
                    F1000 = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    F1001 = table.Column<int>(nullable: true),
                    F2953 = table.Column<string>(unicode: false, maxLength: 6000, nullable: true),
                    F2954 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("SCL_STO_DEL_P2952", x => new { x.F2952, x.F1000 });
                });

            migrationBuilder.CreateTable(
                name: "SCL_STO_TAB",
                columns: table => new
                {
                    F2952 = table.Column<int>(nullable: false),
                    F1000 = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    F1001 = table.Column<int>(nullable: true),
                    F2953 = table.Column<string>(unicode: false, maxLength: 6000, nullable: true),
                    F2954 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("SCL_STO_TAB_P2952", x => new { x.F2952, x.F1000 });
                });

            migrationBuilder.CreateTable(
                name: "SCL_TAB",
                columns: table => new
                {
                    F01 = table.Column<string>(unicode: false, maxLength: 13, nullable: false),
                    F1000 = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    F902 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F1001 = table.Column<int>(nullable: true),
                    F253 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F256 = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    F257 = table.Column<double>(nullable: true),
                    F258 = table.Column<double>(nullable: true),
                    F259 = table.Column<double>(nullable: true),
                    F260 = table.Column<double>(nullable: true),
                    F261 = table.Column<decimal>(type: "money", nullable: true),
                    F262 = table.Column<int>(nullable: true),
                    F263 = table.Column<int>(nullable: true),
                    F264 = table.Column<int>(nullable: true),
                    F265 = table.Column<double>(nullable: true),
                    F266 = table.Column<string>(unicode: false, maxLength: 12, nullable: true),
                    F267 = table.Column<int>(nullable: true),
                    F268 = table.Column<double>(nullable: true),
                    F269 = table.Column<double>(nullable: true),
                    F270 = table.Column<double>(nullable: true),
                    F271 = table.Column<double>(nullable: true),
                    F272 = table.Column<double>(nullable: true),
                    F273 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F274 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    F275 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    F1759 = table.Column<int>(nullable: true),
                    F1840 = table.Column<string>(unicode: false, maxLength: 12, nullable: true),
                    F1952 = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    F1964 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F2581 = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    F2582 = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    F2583 = table.Column<int>(nullable: true),
                    F2584 = table.Column<int>(nullable: true),
                    F2585 = table.Column<int>(nullable: true),
                    F2586 = table.Column<int>(nullable: true),
                    F2792 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F2793 = table.Column<int>(nullable: true),
                    F2796 = table.Column<int>(nullable: true),
                    F2797 = table.Column<int>(nullable: true),
                    F2799 = table.Column<int>(nullable: true),
                    F2800 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F2801 = table.Column<string>(unicode: false, maxLength: 250, nullable: true),
                    F2939 = table.Column<int>(nullable: true),
                    F2940 = table.Column<int>(nullable: true),
                    F2941 = table.Column<int>(nullable: true),
                    F2942 = table.Column<int>(nullable: true),
                    F2944 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F2945 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F2946 = table.Column<int>(nullable: true),
                    F2947 = table.Column<int>(nullable: true),
                    F2948 = table.Column<int>(nullable: true),
                    F2949 = table.Column<int>(nullable: true),
                    F2950 = table.Column<int>(nullable: true),
                    F2952 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("SCL_TAB_P01", x => new { x.F01, x.F1000 });
                });

            migrationBuilder.CreateTable(
                name: "SCL_TXT_DEL",
                columns: table => new
                {
                    F267 = table.Column<int>(nullable: false),
                    F1000 = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    F04 = table.Column<int>(nullable: true),
                    F253 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F297 = table.Column<string>(unicode: false, maxLength: 251, nullable: true),
                    F902 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F1001 = table.Column<int>(nullable: true),
                    F1517 = table.Column<string>(unicode: false, maxLength: 251, nullable: true),
                    F1518 = table.Column<string>(unicode: false, maxLength: 251, nullable: true),
                    F1519 = table.Column<string>(unicode: false, maxLength: 251, nullable: true),
                    F1759 = table.Column<int>(nullable: true),
                    F1836 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F1837 = table.Column<string>(unicode: false, maxLength: 251, nullable: true),
                    F1838 = table.Column<string>(unicode: false, maxLength: 251, nullable: true),
                    F1839 = table.Column<string>(unicode: false, maxLength: 251, nullable: true),
                    F1853 = table.Column<string>(unicode: false, maxLength: 251, nullable: true),
                    F1854 = table.Column<string>(unicode: false, maxLength: 251, nullable: true),
                    F1855 = table.Column<string>(unicode: false, maxLength: 251, nullable: true),
                    F1856 = table.Column<string>(unicode: false, maxLength: 251, nullable: true),
                    F1964 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F1968 = table.Column<string>(unicode: false, maxLength: 251, nullable: true),
                    F1969 = table.Column<string>(unicode: false, maxLength: 251, nullable: true),
                    F1970 = table.Column<string>(unicode: false, maxLength: 251, nullable: true),
                    F1971 = table.Column<string>(unicode: false, maxLength: 251, nullable: true),
                    F1972 = table.Column<string>(unicode: false, maxLength: 251, nullable: true),
                    F2943 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("SCL_TXT_DEL_P267", x => new { x.F267, x.F1000 });
                });

            migrationBuilder.CreateTable(
                name: "SCL_TXT_TAB",
                columns: table => new
                {
                    F267 = table.Column<int>(nullable: false),
                    F1000 = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    F04 = table.Column<int>(nullable: true),
                    F253 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F297 = table.Column<string>(unicode: false, maxLength: 251, nullable: true),
                    F902 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F1001 = table.Column<int>(nullable: true),
                    F1517 = table.Column<string>(unicode: false, maxLength: 251, nullable: true),
                    F1518 = table.Column<string>(unicode: false, maxLength: 251, nullable: true),
                    F1519 = table.Column<string>(unicode: false, maxLength: 251, nullable: true),
                    F1759 = table.Column<int>(nullable: true),
                    F1836 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F1837 = table.Column<string>(unicode: false, maxLength: 251, nullable: true),
                    F1838 = table.Column<string>(unicode: false, maxLength: 251, nullable: true),
                    F1839 = table.Column<string>(unicode: false, maxLength: 251, nullable: true),
                    F1853 = table.Column<string>(unicode: false, maxLength: 251, nullable: true),
                    F1854 = table.Column<string>(unicode: false, maxLength: 251, nullable: true),
                    F1855 = table.Column<string>(unicode: false, maxLength: 251, nullable: true),
                    F1856 = table.Column<string>(unicode: false, maxLength: 251, nullable: true),
                    F1964 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F1968 = table.Column<string>(unicode: false, maxLength: 251, nullable: true),
                    F1969 = table.Column<string>(unicode: false, maxLength: 251, nullable: true),
                    F1970 = table.Column<string>(unicode: false, maxLength: 251, nullable: true),
                    F1971 = table.Column<string>(unicode: false, maxLength: 251, nullable: true),
                    F1972 = table.Column<string>(unicode: false, maxLength: 251, nullable: true),
                    F2943 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("SCL_TXT_TAB_P267", x => new { x.F267, x.F1000 });
                });

            migrationBuilder.CreateTable(
                name: "SDP_TAB",
                columns: table => new
                {
                    F04 = table.Column<int>(nullable: false),
                    F03 = table.Column<int>(nullable: true),
                    F49 = table.Column<double>(nullable: true),
                    F78 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F79 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F80 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F81 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F82 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F88 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F96 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F97 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F98 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F99 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F100 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F101 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F104 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F108 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F114 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F115 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F121 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F124 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F150 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F170 = table.Column<int>(nullable: true),
                    F171 = table.Column<int>(nullable: true),
                    F172 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F177 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F178 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F239 = table.Column<decimal>(type: "money", nullable: true),
                    F240 = table.Column<decimal>(type: "money", nullable: true),
                    F241 = table.Column<decimal>(type: "money", nullable: true),
                    F242 = table.Column<decimal>(type: "money", nullable: true),
                    F1022 = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    F1120 = table.Column<string>(unicode: false, maxLength: 12, nullable: true),
                    F1123 = table.Column<double>(nullable: true),
                    F1124 = table.Column<double>(nullable: true),
                    F1139 = table.Column<int>(nullable: true),
                    F1147 = table.Column<int>(nullable: true),
                    F1168 = table.Column<int>(nullable: true),
                    F1256 = table.Column<double>(nullable: true),
                    F1785 = table.Column<string>(unicode: false, maxLength: 12, nullable: true),
                    F1893 = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    F1938 = table.Column<double>(nullable: true),
                    F1965 = table.Column<int>(nullable: true),
                    F1966 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    F1967 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F2660 = table.Column<string>(unicode: false, maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("SDP_TAB_P04", x => x.F04);
                });

            migrationBuilder.CreateTable(
                name: "SETUP_TAB",
                columns: table => new
                {
                    F2956 = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
                    F2968 = table.Column<string>(unicode: false, maxLength: 60, nullable: false),
                    F2957 = table.Column<string>(unicode: false, maxLength: 60, nullable: false),
                    F2958 = table.Column<string>(unicode: false, maxLength: 60, nullable: false),
                    F2959 = table.Column<string>(unicode: false, maxLength: 60, nullable: false),
                    F253 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F940 = table.Column<int>(nullable: true),
                    F941 = table.Column<int>(nullable: true),
                    F1001 = table.Column<int>(nullable: true),
                    F1056 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F1057 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F2960 = table.Column<string>(unicode: false, maxLength: 250, nullable: true),
                    F2961 = table.Column<string>(type: "xml", nullable: true),
                    F2962 = table.Column<string>(type: "xml", nullable: true),
                    F2963 = table.Column<string>(type: "xml", nullable: true),
                    F2964 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F2965 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F2969 = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    F2970 = table.Column<string>(type: "xml", nullable: true),
                    F2976 = table.Column<string>(unicode: false, maxLength: 40, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("SETUP_TAB_P2956", x => new { x.F2956, x.F2968, x.F2957, x.F2958, x.F2959 });
                });

            migrationBuilder.CreateTable(
                name: "SHF_TAB",
                columns: table => new
                {
                    F117 = table.Column<string>(unicode: false, maxLength: 16, nullable: false),
                    F1000 = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    F25 = table.Column<string>(unicode: false, maxLength: 16, nullable: true),
                    F94 = table.Column<int>(nullable: true),
                    F95 = table.Column<string>(unicode: false, maxLength: 80, nullable: true),
                    F105 = table.Column<int>(nullable: true),
                    F116 = table.Column<string>(unicode: false, maxLength: 16, nullable: true),
                    F118 = table.Column<string>(unicode: false, maxLength: 16, nullable: true),
                    F2836 = table.Column<double>(nullable: true),
                    F2837 = table.Column<double>(nullable: true),
                    F2838 = table.Column<double>(nullable: true),
                    F2839 = table.Column<string>(unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("SHF_TAB_P117", x => new { x.F117, x.F1000 });
                });

            migrationBuilder.CreateTable(
                name: "STD_TAB",
                columns: table => new
                {
                    F1056 = table.Column<string>(unicode: false, maxLength: 4, nullable: false),
                    F1530 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    F1531 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F1532 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F1533 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F1534 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F1535 = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    F1536 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    F1537 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    F1538 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    F1539 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    F1540 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    F1541 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    F1542 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    F1543 = table.Column<int>(nullable: true),
                    F1544 = table.Column<int>(nullable: true),
                    F1545 = table.Column<double>(nullable: true),
                    F1546 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F1547 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F1548 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    F1549 = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    F1551 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F1579 = table.Column<double>(nullable: true),
                    F1580 = table.Column<double>(nullable: true),
                    F2688 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    F2689 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    F2690 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    F2698 = table.Column<double>(nullable: true),
                    F2774 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    F2775 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    F2776 = table.Column<string>(unicode: false, maxLength: 60, nullable: true),
                    F2777 = table.Column<string>(unicode: false, maxLength: 240, nullable: true),
                    F2840 = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    F2841 = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    F2842 = table.Column<double>(nullable: true),
                    F2843 = table.Column<double>(nullable: true),
                    F2849 = table.Column<string>(unicode: false, maxLength: 60, nullable: true),
                    F2850 = table.Column<string>(unicode: false, maxLength: 60, nullable: true),
                    F2937 = table.Column<string>(unicode: false, maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("STD_TAB_P1056", x => x.F1056);
                });

            migrationBuilder.CreateTable(
                name: "STO_TAB",
                columns: table => new
                {
                    F1000 = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    F1018 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F1180 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F1181 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F1182 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F1937 = table.Column<int>(nullable: true),
                    F1965 = table.Column<int>(nullable: true),
                    F1966 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    F2691 = table.Column<string>(unicode: false, maxLength: 40, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("STO_TAB_P1000", x => x.F1000);
                });

            migrationBuilder.CreateTable(
                name: "SYS_TAB",
                columns: table => new
                {
                    F902 = table.Column<string>(unicode: false, maxLength: 8, nullable: false),
                    F91 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    F253 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F254 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F302 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F1032 = table.Column<int>(nullable: true),
                    F1059 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F1066 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F1243 = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    F1244 = table.Column<string>(unicode: false, maxLength: 180, nullable: true),
                    F1763 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F1764 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F1807 = table.Column<int>(nullable: true),
                    F1808 = table.Column<int>(nullable: true),
                    F2589 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F2590 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F2874 = table.Column<string>(unicode: false, maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("SYS_TAB_P902", x => x.F902);
                });

            migrationBuilder.CreateTable(
                name: "TAR_TAB",
                columns: table => new
                {
                    F06 = table.Column<int>(nullable: false),
                    F1021 = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    F1178 = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("TAR_TAB_P06", x => x.F06);
                });

            migrationBuilder.CreateTable(
                name: "TASK_TAB",
                columns: table => new
                {
                    F1822 = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
                    F01 = table.Column<string>(unicode: false, maxLength: 13, nullable: true),
                    F27 = table.Column<string>(unicode: false, maxLength: 14, nullable: true),
                    F253 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F1000 = table.Column<string>(unicode: false, maxLength: 5, nullable: true),
                    F1001 = table.Column<int>(nullable: true),
                    F1056 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F1142 = table.Column<int>(nullable: true),
                    F1148 = table.Column<string>(unicode: false, maxLength: 14, nullable: true),
                    F1168 = table.Column<int>(nullable: true),
                    F1184 = table.Column<string>(unicode: false, maxLength: 12, nullable: true),
                    F1185 = table.Column<int>(nullable: true),
                    F1245 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    F1675 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F1676 = table.Column<decimal>(type: "money", nullable: true),
                    F1677 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F1678 = table.Column<decimal>(type: "money", nullable: true),
                    F1679 = table.Column<int>(nullable: true),
                    F1680 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F1823 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    F1824 = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    F1825 = table.Column<string>(unicode: false, maxLength: 1000, nullable: true),
                    F1826 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F1827 = table.Column<int>(nullable: true),
                    F1828 = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    F1829 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F2754 = table.Column<int>(nullable: true),
                    F2755 = table.Column<string>(unicode: false, nullable: true),
                    F2756 = table.Column<string>(unicode: false, maxLength: 4000, nullable: true),
                    F2757 = table.Column<double>(nullable: true),
                    F2758 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F2759 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    F2760 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F2761 = table.Column<int>(nullable: true),
                    F2762 = table.Column<int>(nullable: true),
                    F2763 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F2764 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F2791 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("TASK_TAB_P1822", x => x.F1822);
                });

            migrationBuilder.CreateTable(
                name: "TER_TAB",
                columns: table => new
                {
                    F1056 = table.Column<string>(unicode: false, maxLength: 4, nullable: false),
                    F1057 = table.Column<string>(unicode: false, maxLength: 4, nullable: false),
                    F1058 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F1125 = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    F1169 = table.Column<string>(unicode: false, maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("TER_TAB_P1056", x => new { x.F1056, x.F1057 });
                });

            migrationBuilder.CreateTable(
                name: "TLZ_TAB",
                columns: table => new
                {
                    F1034 = table.Column<int>(nullable: false),
                    F1128 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    F1129 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    F1147 = table.Column<int>(nullable: true),
                    F1179 = table.Column<int>(nullable: true),
                    F1039 = table.Column<string>(unicode: false, maxLength: 60, nullable: true),
                    F1042 = table.Column<int>(nullable: true),
                    F1043 = table.Column<int>(nullable: true),
                    F1044 = table.Column<int>(nullable: true),
                    F1045 = table.Column<int>(nullable: true),
                    F1046 = table.Column<int>(nullable: true),
                    F1047 = table.Column<int>(nullable: true),
                    F1048 = table.Column<string>(unicode: false, maxLength: 60, nullable: true),
                    F1054 = table.Column<int>(nullable: true),
                    F1055 = table.Column<int>(nullable: true),
                    F1130 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    F1131 = table.Column<string>(unicode: false, maxLength: 250, nullable: true),
                    F1253 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F1709 = table.Column<string>(unicode: false, maxLength: 60, nullable: true),
                    F1710 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F1817 = table.Column<int>(nullable: true),
                    F1818 = table.Column<int>(nullable: true),
                    F1896 = table.Column<string>(unicode: false, maxLength: 60, nullable: true),
                    F1897 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F1965 = table.Column<int>(nullable: true),
                    F1966 = table.Column<string>(unicode: false, maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("TLZ_TAB_P1034", x => x.F1034);
                });

            migrationBuilder.CreateTable(
                name: "TRS_CLK",
                columns: table => new
                {
                    F254 = table.Column<DateTime>(type: "datetime", nullable: false),
                    F1056 = table.Column<string>(unicode: false, maxLength: 4, nullable: false),
                    F1057 = table.Column<string>(unicode: false, maxLength: 4, nullable: false),
                    F1185 = table.Column<int>(nullable: false),
                    F1032 = table.Column<int>(nullable: false),
                    F1034 = table.Column<int>(nullable: false),
                    F1101 = table.Column<int>(nullable: false),
                    F64 = table.Column<double>(nullable: false),
                    F65 = table.Column<decimal>(type: "money", nullable: false),
                    F67 = table.Column<double>(nullable: false),
                    F253 = table.Column<DateTime>(type: "datetime", nullable: false),
                    F1036 = table.Column<string>(unicode: false, maxLength: 6, nullable: false),
                    F1079 = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    F1765 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("TRS_CLK_P254", x => new { x.F254, x.F1056, x.F1057, x.F1185, x.F1032, x.F1034, x.F1101 });
                });

            migrationBuilder.CreateTable(
                name: "TRS_CLT",
                columns: table => new
                {
                    F254 = table.Column<DateTime>(type: "datetime", nullable: false),
                    F1056 = table.Column<string>(unicode: false, maxLength: 4, nullable: false),
                    F1057 = table.Column<string>(unicode: false, maxLength: 4, nullable: false),
                    F1148 = table.Column<string>(unicode: false, maxLength: 14, nullable: false),
                    F1032 = table.Column<int>(nullable: false),
                    F1034 = table.Column<int>(nullable: false),
                    F1101 = table.Column<int>(nullable: false),
                    F64 = table.Column<double>(nullable: false),
                    F65 = table.Column<decimal>(type: "money", nullable: false),
                    F67 = table.Column<double>(nullable: false),
                    F253 = table.Column<DateTime>(type: "datetime", nullable: false),
                    F1036 = table.Column<string>(unicode: false, maxLength: 6, nullable: false),
                    F1079 = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    F1100 = table.Column<int>(nullable: true),
                    F1765 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("TRS_CLT_P254", x => new { x.F254, x.F1056, x.F1057, x.F1148, x.F1032, x.F1034, x.F1101 });
                });

            migrationBuilder.CreateTable(
                name: "TRS_DPT",
                columns: table => new
                {
                    F254 = table.Column<DateTime>(type: "datetime", nullable: false),
                    F1056 = table.Column<string>(unicode: false, maxLength: 4, nullable: false),
                    F1057 = table.Column<string>(unicode: false, maxLength: 4, nullable: false),
                    F03 = table.Column<int>(nullable: false),
                    F1032 = table.Column<int>(nullable: false),
                    F1034 = table.Column<int>(nullable: false),
                    F1101 = table.Column<int>(nullable: false),
                    F64 = table.Column<double>(nullable: false),
                    F65 = table.Column<decimal>(type: "money", nullable: false),
                    F67 = table.Column<double>(nullable: false),
                    F253 = table.Column<DateTime>(type: "datetime", nullable: false),
                    F1036 = table.Column<string>(unicode: false, maxLength: 6, nullable: false),
                    F1079 = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    F1765 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("TRS_DPT_P254", x => new { x.F254, x.F1056, x.F1057, x.F03, x.F1032, x.F1034, x.F1101 });
                });

            migrationBuilder.CreateTable(
                name: "TRS_FIN",
                columns: table => new
                {
                    F254 = table.Column<DateTime>(type: "datetime", nullable: false),
                    F1056 = table.Column<string>(unicode: false, maxLength: 4, nullable: false),
                    F1057 = table.Column<string>(unicode: false, maxLength: 4, nullable: false),
                    F1032 = table.Column<int>(nullable: false),
                    F1034 = table.Column<int>(nullable: false),
                    F1101 = table.Column<int>(nullable: false),
                    F64 = table.Column<double>(nullable: false),
                    F65 = table.Column<decimal>(type: "money", nullable: false),
                    F67 = table.Column<double>(nullable: false),
                    F253 = table.Column<DateTime>(type: "datetime", nullable: false),
                    F1036 = table.Column<string>(unicode: false, maxLength: 6, nullable: false),
                    F1079 = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    F1765 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("TRS_FIN_P254", x => new { x.F254, x.F1056, x.F1057, x.F1032, x.F1034, x.F1101 });
                });

            migrationBuilder.CreateTable(
                name: "TRS_ITM",
                columns: table => new
                {
                    F254 = table.Column<DateTime>(type: "datetime", nullable: false),
                    F1056 = table.Column<string>(unicode: false, maxLength: 4, nullable: false),
                    F1057 = table.Column<string>(unicode: false, maxLength: 4, nullable: false),
                    F01 = table.Column<string>(unicode: false, maxLength: 13, nullable: false),
                    F1032 = table.Column<int>(nullable: false),
                    F1034 = table.Column<int>(nullable: false),
                    F1101 = table.Column<int>(nullable: false),
                    F30 = table.Column<decimal>(type: "money", nullable: true),
                    F31 = table.Column<double>(nullable: true),
                    F64 = table.Column<double>(nullable: false),
                    F65 = table.Column<decimal>(type: "money", nullable: false),
                    F67 = table.Column<double>(nullable: false),
                    F253 = table.Column<DateTime>(type: "datetime", nullable: false),
                    F1036 = table.Column<string>(unicode: false, maxLength: 6, nullable: false),
                    F1079 = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    F1765 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("TRS_ITM_P254", x => new { x.F254, x.F1056, x.F1057, x.F01, x.F1032, x.F1034, x.F1101 });
                });

            migrationBuilder.CreateTable(
                name: "TRS_LOG",
                columns: table => new
                {
                    F254 = table.Column<DateTime>(type: "datetime", nullable: false),
                    F990 = table.Column<string>(unicode: false, maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("TRS_LOG_P254", x => new { x.F254, x.F990 });
                });

            migrationBuilder.CreateTable(
                name: "TRS_SUB",
                columns: table => new
                {
                    F254 = table.Column<DateTime>(type: "datetime", nullable: false),
                    F1056 = table.Column<string>(unicode: false, maxLength: 4, nullable: false),
                    F1057 = table.Column<string>(unicode: false, maxLength: 4, nullable: false),
                    F04 = table.Column<int>(nullable: false),
                    F1032 = table.Column<int>(nullable: false),
                    F1034 = table.Column<int>(nullable: false),
                    F1101 = table.Column<int>(nullable: false),
                    F64 = table.Column<double>(nullable: false),
                    F65 = table.Column<decimal>(type: "money", nullable: false),
                    F67 = table.Column<double>(nullable: false),
                    F253 = table.Column<DateTime>(type: "datetime", nullable: false),
                    F1036 = table.Column<string>(unicode: false, maxLength: 6, nullable: false),
                    F1079 = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    F1765 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("TRS_SUB_P254", x => new { x.F254, x.F1056, x.F1057, x.F04, x.F1032, x.F1034, x.F1101 });
                });

            migrationBuilder.CreateTable(
                name: "TRS_VND",
                columns: table => new
                {
                    F254 = table.Column<DateTime>(type: "datetime", nullable: false),
                    F1056 = table.Column<string>(unicode: false, maxLength: 4, nullable: false),
                    F1057 = table.Column<string>(unicode: false, maxLength: 4, nullable: false),
                    F27 = table.Column<string>(unicode: false, maxLength: 14, nullable: false),
                    F1032 = table.Column<int>(nullable: false),
                    F1034 = table.Column<int>(nullable: false),
                    F1101 = table.Column<int>(nullable: false),
                    F64 = table.Column<double>(nullable: false),
                    F65 = table.Column<decimal>(type: "money", nullable: false),
                    F67 = table.Column<double>(nullable: false),
                    F253 = table.Column<DateTime>(type: "datetime", nullable: false),
                    F1036 = table.Column<string>(unicode: false, maxLength: 6, nullable: false),
                    F1079 = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    F1765 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("TRS_VND_P254", x => new { x.F254, x.F1056, x.F1057, x.F27, x.F1032, x.F1034, x.F1101 });
                });

            migrationBuilder.CreateTable(
                name: "TZS_TAB",
                columns: table => new
                {
                    F1179 = table.Column<int>(nullable: false),
                    F1183 = table.Column<string>(unicode: false, maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("TZS_TAB_P1179", x => x.F1179);
                });

            migrationBuilder.CreateTable(
                name: "UNT_TAB",
                columns: table => new
                {
                    F23 = table.Column<string>(unicode: false, maxLength: 10, nullable: false),
                    F1786 = table.Column<string>(unicode: false, maxLength: 12, nullable: false),
                    F1503 = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    F2876 = table.Column<double>(nullable: true),
                    F2877 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F2878 = table.Column<string>(unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("UNT_TAB_P23", x => new { x.F23, x.F1786 });
                });

            migrationBuilder.CreateTable(
                name: "VENDOR_DEL",
                columns: table => new
                {
                    F27 = table.Column<string>(unicode: false, maxLength: 14, nullable: false),
                    F902 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F1001 = table.Column<int>(nullable: true),
                    F253 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F334 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F335 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F336 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F337 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F338 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F339 = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    F340 = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    F341 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    F342 = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    F343 = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    F344 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    F345 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    F346 = table.Column<double>(nullable: true),
                    F347 = table.Column<double>(nullable: true),
                    F348 = table.Column<int>(nullable: true),
                    F349 = table.Column<double>(nullable: true),
                    F350 = table.Column<string>(unicode: false, maxLength: 9, nullable: true),
                    F351 = table.Column<string>(unicode: false, maxLength: 6, nullable: true),
                    F352 = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    F353 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F354 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F355 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F356 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F357 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F358 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F359 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F1000 = table.Column<string>(unicode: false, maxLength: 5, nullable: true),
                    F1168 = table.Column<int>(nullable: true),
                    F1642 = table.Column<string>(unicode: false, maxLength: 14, nullable: true),
                    F1654 = table.Column<double>(nullable: true),
                    F1655 = table.Column<double>(nullable: true),
                    F1656 = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    F1685 = table.Column<int>(nullable: true),
                    F1759 = table.Column<int>(nullable: true),
                    F1760 = table.Column<double>(nullable: true),
                    F1761 = table.Column<double>(nullable: true),
                    F1779 = table.Column<string>(unicode: false, maxLength: 120, nullable: true),
                    F1793 = table.Column<int>(nullable: true),
                    F1794 = table.Column<int>(nullable: true),
                    F1882 = table.Column<string>(unicode: false, maxLength: 120, nullable: true),
                    F1883 = table.Column<double>(nullable: true),
                    F1884 = table.Column<decimal>(type: "money", nullable: true),
                    F1887 = table.Column<string>(unicode: false, maxLength: 2, nullable: true),
                    F1889 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F1890 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    F1891 = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    F1948 = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    F1949 = table.Column<string>(unicode: false, maxLength: 6, nullable: true),
                    F1964 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F1965 = table.Column<int>(nullable: true),
                    F1966 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    F2597 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    F2602 = table.Column<string>(unicode: false, maxLength: 3, nullable: true),
                    F2603 = table.Column<string>(unicode: false, maxLength: 250, nullable: true),
                    F2630 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F2631 = table.Column<int>(nullable: true),
                    F2633 = table.Column<double>(nullable: true),
                    F2635 = table.Column<decimal>(type: "money", nullable: true),
                    F2658 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F2660 = table.Column<string>(unicode: false, maxLength: 250, nullable: true),
                    F2666 = table.Column<double>(nullable: true),
                    F2700 = table.Column<double>(nullable: true),
                    F2701 = table.Column<double>(nullable: true),
                    F2702 = table.Column<double>(nullable: true),
                    F2710 = table.Column<string>(unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("VENDOR_DEL_P27", x => x.F27);
                });

            migrationBuilder.CreateTable(
                name: "VENDOR_TAB",
                columns: table => new
                {
                    F27 = table.Column<string>(unicode: false, maxLength: 14, nullable: false),
                    F902 = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    F1001 = table.Column<int>(nullable: true),
                    F253 = table.Column<DateTime>(type: "datetime", nullable: true),
                    F334 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F335 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F336 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F337 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F338 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F339 = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    F340 = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    F341 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    F342 = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    F343 = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    F344 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    F345 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    F346 = table.Column<double>(nullable: true),
                    F347 = table.Column<double>(nullable: true),
                    F348 = table.Column<int>(nullable: true),
                    F349 = table.Column<double>(nullable: true),
                    F350 = table.Column<string>(unicode: false, maxLength: 9, nullable: true),
                    F351 = table.Column<string>(unicode: false, maxLength: 6, nullable: true),
                    F352 = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    F353 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F354 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F355 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F356 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F357 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F358 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F359 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F1000 = table.Column<string>(unicode: false, maxLength: 5, nullable: true),
                    F1168 = table.Column<int>(nullable: true),
                    F1642 = table.Column<string>(unicode: false, maxLength: 14, nullable: true),
                    F1654 = table.Column<double>(nullable: true),
                    F1655 = table.Column<double>(nullable: true),
                    F1656 = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    F1685 = table.Column<int>(nullable: true),
                    F1759 = table.Column<int>(nullable: true),
                    F1760 = table.Column<double>(nullable: true),
                    F1761 = table.Column<double>(nullable: true),
                    F1779 = table.Column<string>(unicode: false, maxLength: 120, nullable: true),
                    F1793 = table.Column<int>(nullable: true),
                    F1794 = table.Column<int>(nullable: true),
                    F1882 = table.Column<string>(unicode: false, maxLength: 120, nullable: true),
                    F1883 = table.Column<double>(nullable: true),
                    F1884 = table.Column<decimal>(type: "money", nullable: true),
                    F1887 = table.Column<string>(unicode: false, maxLength: 2, nullable: true),
                    F1889 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F1890 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    F1891 = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    F1948 = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    F1949 = table.Column<string>(unicode: false, maxLength: 6, nullable: true),
                    F1964 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F1965 = table.Column<int>(nullable: true),
                    F1966 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    F2597 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    F2602 = table.Column<string>(unicode: false, maxLength: 3, nullable: true),
                    F2603 = table.Column<string>(unicode: false, maxLength: 250, nullable: true),
                    F2630 = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    F2631 = table.Column<int>(nullable: true),
                    F2633 = table.Column<double>(nullable: true),
                    F2635 = table.Column<decimal>(type: "money", nullable: true),
                    F2658 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F2660 = table.Column<string>(unicode: false, maxLength: 250, nullable: true),
                    F2666 = table.Column<double>(nullable: true),
                    F2700 = table.Column<double>(nullable: true),
                    F2701 = table.Column<double>(nullable: true),
                    F2702 = table.Column<double>(nullable: true),
                    F2710 = table.Column<string>(unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("VENDOR_TAB_P27", x => x.F27);
                });

            migrationBuilder.CreateTable(
                name: "WATCH_TAB",
                columns: table => new
                {
                    F2734 = table.Column<string>(unicode: false, maxLength: 60, nullable: false),
                    F1101 = table.Column<int>(nullable: false),
                    F1000 = table.Column<string>(unicode: false, maxLength: 5, nullable: true),
                    F1031 = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    F1034 = table.Column<int>(nullable: true),
                    F1185 = table.Column<int>(nullable: true),
                    F1823 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    F2735 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    F2736 = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    F2737 = table.Column<string>(unicode: false, maxLength: 2, nullable: true),
                    F2738 = table.Column<double>(nullable: true),
                    F2739 = table.Column<string>(unicode: false, maxLength: 5, nullable: true),
                    F2740 = table.Column<string>(unicode: false, maxLength: 5, nullable: true),
                    F2741 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    F2742 = table.Column<string>(unicode: false, maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("WATCH_TAB_P2734", x => new { x.F2734, x.F1101 });
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "ALT_DEL_F01",
                table: "ALT_DEL",
                column: "F01");

            migrationBuilder.CreateIndex(
                name: "ALT_DEL_F902",
                table: "ALT_DEL",
                column: "F902");

            migrationBuilder.CreateIndex(
                name: "ALT_TAB_F01",
                table: "ALT_TAB",
                column: "F01");

            migrationBuilder.CreateIndex(
                name: "ALT_TAB_F902",
                table: "ALT_TAB",
                column: "F902");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "CLK_DEL_F1001",
                table: "CLK_DEL",
                column: "F1001");

            migrationBuilder.CreateIndex(
                name: "CLK_DEL_F1126",
                table: "CLK_DEL",
                column: "F1126",
                unique: true,
                filter: "[F1126] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "CLK_DEL_F1571",
                table: "CLK_DEL",
                column: "F1571");

            migrationBuilder.CreateIndex(
                name: "CLK_TAB_F1001",
                table: "CLK_TAB",
                column: "F1001");

            migrationBuilder.CreateIndex(
                name: "CLK_TAB_F1126",
                table: "CLK_TAB",
                column: "F1126",
                unique: true,
                filter: "[F1126] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "CLK_TAB_F1571",
                table: "CLK_TAB",
                column: "F1571");

            migrationBuilder.CreateIndex(
                name: "CLL_DEL_F1000",
                table: "CLL_DEL",
                column: "F1000");

            migrationBuilder.CreateIndex(
                name: "CLL_DEL_F1001",
                table: "CLL_DEL",
                column: "F1001");

            migrationBuilder.CreateIndex(
                name: "CLL_DEL_F1148",
                table: "CLL_DEL",
                column: "F1148");

            migrationBuilder.CreateIndex(
                name: "CLL_DEL_F902",
                table: "CLL_DEL",
                column: "F902");

            migrationBuilder.CreateIndex(
                name: "CLL_TAB_F1000",
                table: "CLL_TAB",
                column: "F1000");

            migrationBuilder.CreateIndex(
                name: "CLL_TAB_F1001",
                table: "CLL_TAB",
                column: "F1001");

            migrationBuilder.CreateIndex(
                name: "CLL_TAB_F1148",
                table: "CLL_TAB",
                column: "F1148");

            migrationBuilder.CreateIndex(
                name: "CLL_TAB_F902",
                table: "CLL_TAB",
                column: "F902");

            migrationBuilder.CreateIndex(
                name: "CLT_DEL_F1000",
                table: "CLT_DEL",
                column: "F1000");

            migrationBuilder.CreateIndex(
                name: "CLT_DEL_F1001",
                table: "CLT_DEL",
                column: "F1001");

            migrationBuilder.CreateIndex(
                name: "CLT_DEL_F1150",
                table: "CLT_DEL",
                column: "F1150");

            migrationBuilder.CreateIndex(
                name: "CLT_DEL_F1152",
                table: "CLT_DEL",
                column: "F1152");

            migrationBuilder.CreateIndex(
                name: "CLT_DEL_F1153",
                table: "CLT_DEL",
                column: "F1153");

            migrationBuilder.CreateIndex(
                name: "CLT_DEL_F1154",
                table: "CLT_DEL",
                column: "F1154");

            migrationBuilder.CreateIndex(
                name: "CLT_DEL_F1172",
                table: "CLT_DEL",
                column: "F1172");

            migrationBuilder.CreateIndex(
                name: "CLT_DEL_F1573",
                table: "CLT_DEL",
                column: "F1573");

            migrationBuilder.CreateIndex(
                name: "CLT_DEL_F902",
                table: "CLT_DEL",
                column: "F902");

            migrationBuilder.CreateIndex(
                name: "CLT_ITM_DEL_F1001",
                table: "CLT_ITM_DEL",
                column: "F1001");

            migrationBuilder.CreateIndex(
                name: "CLT_ITM_TAB_F1001",
                table: "CLT_ITM_TAB",
                column: "F1001");

            migrationBuilder.CreateIndex(
                name: "CLT_TAB_F1000",
                table: "CLT_TAB",
                column: "F1000");

            migrationBuilder.CreateIndex(
                name: "CLT_TAB_F1001",
                table: "CLT_TAB",
                column: "F1001");

            migrationBuilder.CreateIndex(
                name: "CLT_TAB_F1150",
                table: "CLT_TAB",
                column: "F1150");

            migrationBuilder.CreateIndex(
                name: "CLT_TAB_F1152",
                table: "CLT_TAB",
                column: "F1152");

            migrationBuilder.CreateIndex(
                name: "CLT_TAB_F1153",
                table: "CLT_TAB",
                column: "F1153");

            migrationBuilder.CreateIndex(
                name: "CLT_TAB_F1154",
                table: "CLT_TAB",
                column: "F1154");

            migrationBuilder.CreateIndex(
                name: "CLT_TAB_F1172",
                table: "CLT_TAB",
                column: "F1172");

            migrationBuilder.CreateIndex(
                name: "CLT_TAB_F1573",
                table: "CLT_TAB",
                column: "F1573");

            migrationBuilder.CreateIndex(
                name: "CLT_TAB_F902",
                table: "CLT_TAB",
                column: "F902");

            migrationBuilder.CreateIndex(
                name: "COST_DEL_F1000",
                table: "COST_DEL",
                column: "F1000");

            migrationBuilder.CreateIndex(
                name: "COST_DEL_F1001",
                table: "COST_DEL",
                column: "F1001");

            migrationBuilder.CreateIndex(
                name: "COST_DEL_F26",
                table: "COST_DEL",
                column: "F26");

            migrationBuilder.CreateIndex(
                name: "COST_DEL_F27",
                table: "COST_DEL",
                column: "F27");

            migrationBuilder.CreateIndex(
                name: "COST_DEL_F902",
                table: "COST_DEL",
                column: "F902");

            migrationBuilder.CreateIndex(
                name: "COST_TAB_F1000",
                table: "COST_TAB",
                column: "F1000");

            migrationBuilder.CreateIndex(
                name: "COST_TAB_F1001",
                table: "COST_TAB",
                column: "F1001");

            migrationBuilder.CreateIndex(
                name: "COST_TAB_F26",
                table: "COST_TAB",
                column: "F26");

            migrationBuilder.CreateIndex(
                name: "COST_TAB_F27",
                table: "COST_TAB",
                column: "F27");

            migrationBuilder.CreateIndex(
                name: "COST_TAB_F902",
                table: "COST_TAB",
                column: "F902");

            migrationBuilder.CreateIndex(
                name: "DSD_DEL_F1000",
                table: "DSD_DEL",
                column: "F1000");

            migrationBuilder.CreateIndex(
                name: "DSD_DEL_F1001",
                table: "DSD_DEL",
                column: "F1001");

            migrationBuilder.CreateIndex(
                name: "DSD_DEL_F902",
                table: "DSD_DEL",
                column: "F902");

            migrationBuilder.CreateIndex(
                name: "DSD_TAB_F1000",
                table: "DSD_TAB",
                column: "F1000");

            migrationBuilder.CreateIndex(
                name: "DSD_TAB_F1001",
                table: "DSD_TAB",
                column: "F1001");

            migrationBuilder.CreateIndex(
                name: "DSD_TAB_F902",
                table: "DSD_TAB",
                column: "F902");

            migrationBuilder.CreateIndex(
                name: "ECL_DEL_F1001",
                table: "ECL_DEL",
                column: "F1001");

            migrationBuilder.CreateIndex(
                name: "ECL_DEL_F902",
                table: "ECL_DEL",
                column: "F902");

            migrationBuilder.CreateIndex(
                name: "ECL_TAB_F1001",
                table: "ECL_TAB",
                column: "F1001");

            migrationBuilder.CreateIndex(
                name: "ECL_TAB_F902",
                table: "ECL_TAB",
                column: "F902");

            migrationBuilder.CreateIndex(
                name: "FCZ_TAB_F1034",
                table: "FCZ_TAB",
                column: "F1034");

            migrationBuilder.CreateIndex(
                name: "KIT_DEL_F1001",
                table: "KIT_DEL",
                column: "F1001");

            migrationBuilder.CreateIndex(
                name: "KIT_DEL_F1507",
                table: "KIT_DEL",
                column: "F1507");

            migrationBuilder.CreateIndex(
                name: "KIT_DEL_F902",
                table: "KIT_DEL",
                column: "F902");

            migrationBuilder.CreateIndex(
                name: "KIT_TAB_F1001",
                table: "KIT_TAB",
                column: "F1001");

            migrationBuilder.CreateIndex(
                name: "KIT_TAB_F1507",
                table: "KIT_TAB",
                column: "F1507");

            migrationBuilder.CreateIndex(
                name: "KIT_TAB_F902",
                table: "KIT_TAB",
                column: "F902");

            migrationBuilder.CreateIndex(
                name: "LNK_TAB_F1056",
                table: "LNK_TAB",
                column: "F1056");

            migrationBuilder.CreateIndex(
                name: "LNK_TAB_F1057",
                table: "LNK_TAB",
                column: "F1057");

            migrationBuilder.CreateIndex(
                name: "LOC_DEL_F1000",
                table: "LOC_DEL",
                column: "F1000");

            migrationBuilder.CreateIndex(
                name: "LOC_DEL_F1001",
                table: "LOC_DEL",
                column: "F1001");

            migrationBuilder.CreateIndex(
                name: "LOC_DEL_F117",
                table: "LOC_DEL",
                column: "F117");

            migrationBuilder.CreateIndex(
                name: "LOC_DEL_F902",
                table: "LOC_DEL",
                column: "F902");

            migrationBuilder.CreateIndex(
                name: "LOC_TAB_F1000",
                table: "LOC_TAB",
                column: "F1000");

            migrationBuilder.CreateIndex(
                name: "LOC_TAB_F1001",
                table: "LOC_TAB",
                column: "F1001");

            migrationBuilder.CreateIndex(
                name: "LOC_TAB_F117",
                table: "LOC_TAB",
                column: "F117");

            migrationBuilder.CreateIndex(
                name: "LOC_TAB_F902",
                table: "LOC_TAB",
                column: "F902");

            migrationBuilder.CreateIndex(
                name: "LST_HDR_F1148",
                table: "LST_HDR",
                column: "F1148");

            migrationBuilder.CreateIndex(
                name: "MIX_DEL_F1001",
                table: "MIX_DEL",
                column: "F1001");

            migrationBuilder.CreateIndex(
                name: "MIX_TAB_F1001",
                table: "MIX_TAB",
                column: "F1001");

            migrationBuilder.CreateIndex(
                name: "OBJ_DEL_F1001",
                table: "OBJ_DEL",
                column: "F1001");

            migrationBuilder.CreateIndex(
                name: "OBJ_DEL_F16",
                table: "OBJ_DEL",
                column: "F16");

            migrationBuilder.CreateIndex(
                name: "OBJ_DEL_F17",
                table: "OBJ_DEL",
                column: "F17");

            migrationBuilder.CreateIndex(
                name: "OBJ_DEL_F18",
                table: "OBJ_DEL",
                column: "F18");

            migrationBuilder.CreateIndex(
                name: "OBJ_DEL_F193",
                table: "OBJ_DEL",
                column: "F193");

            migrationBuilder.CreateIndex(
                name: "OBJ_DEL_F902",
                table: "OBJ_DEL",
                column: "F902");

            migrationBuilder.CreateIndex(
                name: "OBJ_DEL_F93",
                table: "OBJ_DEL",
                column: "F93");

            migrationBuilder.CreateIndex(
                name: "OBJ_TAB_F1001",
                table: "OBJ_TAB",
                column: "F1001");

            migrationBuilder.CreateIndex(
                name: "OBJ_TAB_F16",
                table: "OBJ_TAB",
                column: "F16");

            migrationBuilder.CreateIndex(
                name: "OBJ_TAB_F17",
                table: "OBJ_TAB",
                column: "F17");

            migrationBuilder.CreateIndex(
                name: "OBJ_TAB_F18",
                table: "OBJ_TAB",
                column: "F18");

            migrationBuilder.CreateIndex(
                name: "OBJ_TAB_F193",
                table: "OBJ_TAB",
                column: "F193");

            migrationBuilder.CreateIndex(
                name: "OBJ_TAB_F902",
                table: "OBJ_TAB",
                column: "F902");

            migrationBuilder.CreateIndex(
                name: "OBJ_TAB_F93",
                table: "OBJ_TAB",
                column: "F93");

            migrationBuilder.CreateIndex(
                name: "POS_DEL_F04",
                table: "POS_DEL",
                column: "F04");

            migrationBuilder.CreateIndex(
                name: "POS_DEL_F1000",
                table: "POS_DEL",
                column: "F1000");

            migrationBuilder.CreateIndex(
                name: "POS_DEL_F1001",
                table: "POS_DEL",
                column: "F1001");

            migrationBuilder.CreateIndex(
                name: "POS_DEL_F383",
                table: "POS_DEL",
                column: "F383");

            migrationBuilder.CreateIndex(
                name: "POS_DEL_F902",
                table: "POS_DEL",
                column: "F902");

            migrationBuilder.CreateIndex(
                name: "POS_TAB_F04",
                table: "POS_TAB",
                column: "F04");

            migrationBuilder.CreateIndex(
                name: "POS_TAB_F1000",
                table: "POS_TAB",
                column: "F1000");

            migrationBuilder.CreateIndex(
                name: "POS_TAB_F1001",
                table: "POS_TAB",
                column: "F1001");

            migrationBuilder.CreateIndex(
                name: "POS_TAB_F383",
                table: "POS_TAB",
                column: "F383");

            migrationBuilder.CreateIndex(
                name: "POS_TAB_F902",
                table: "POS_TAB",
                column: "F902");

            migrationBuilder.CreateIndex(
                name: "PRICE_DEL_F1000",
                table: "PRICE_DEL",
                column: "F1000");

            migrationBuilder.CreateIndex(
                name: "PRICE_DEL_F1001",
                table: "PRICE_DEL",
                column: "F1001");

            migrationBuilder.CreateIndex(
                name: "PRICE_DEL_F1014",
                table: "PRICE_DEL",
                column: "F1014");

            migrationBuilder.CreateIndex(
                name: "PRICE_DEL_F126",
                table: "PRICE_DEL",
                column: "F126");

            migrationBuilder.CreateIndex(
                name: "PRICE_DEL_F32",
                table: "PRICE_DEL",
                column: "F32");

            migrationBuilder.CreateIndex(
                name: "PRICE_DEL_F902",
                table: "PRICE_DEL",
                column: "F902");

            migrationBuilder.CreateIndex(
                name: "PRICE_TAB_F1000",
                table: "PRICE_TAB",
                column: "F1000");

            migrationBuilder.CreateIndex(
                name: "PRICE_TAB_F1001",
                table: "PRICE_TAB",
                column: "F1001");

            migrationBuilder.CreateIndex(
                name: "PRICE_TAB_F1014",
                table: "PRICE_TAB",
                column: "F1014");

            migrationBuilder.CreateIndex(
                name: "PRICE_TAB_F126",
                table: "PRICE_TAB",
                column: "F126");

            migrationBuilder.CreateIndex(
                name: "PRICE_TAB_F32",
                table: "PRICE_TAB",
                column: "F32");

            migrationBuilder.CreateIndex(
                name: "PRICE_TAB_F902",
                table: "PRICE_TAB",
                column: "F902");

            migrationBuilder.CreateIndex(
                name: "REC_BAT_F27",
                table: "REC_BAT",
                column: "F27");

            migrationBuilder.CreateIndex(
                name: "REC_HDR_F27",
                table: "REC_HDR",
                column: "F27");

            migrationBuilder.CreateIndex(
                name: "REC_HDR_SAV_F27",
                table: "REC_HDR_SAV",
                column: "F27");

            migrationBuilder.CreateIndex(
                name: "REC_REG_F01",
                table: "REC_REG",
                column: "F01");

            migrationBuilder.CreateIndex(
                name: "REC_REG_SAV_F01",
                table: "REC_REG_SAV",
                column: "F01");

            migrationBuilder.CreateIndex(
                name: "REV_HDRX2",
                table: "REV_HDR",
                columns: new[] { "F3007", "F3009", "F3003" });

            migrationBuilder.CreateIndex(
                name: "REV_HDR_X1",
                table: "REV_HDR",
                columns: new[] { "F3009", "F3007", "F3003" });

            migrationBuilder.CreateIndex(
                name: "RPT_CLK_D_F1034",
                table: "RPT_CLK_D",
                column: "F1034");

            migrationBuilder.CreateIndex(
                name: "RPT_CLK_D_F1185",
                table: "RPT_CLK_D",
                column: "F1185");

            migrationBuilder.CreateIndex(
                name: "RPT_CLK_F_F1034",
                table: "RPT_CLK_F",
                column: "F1034");

            migrationBuilder.CreateIndex(
                name: "RPT_CLK_F_F1185",
                table: "RPT_CLK_F",
                column: "F1185");

            migrationBuilder.CreateIndex(
                name: "RPT_CLK_M_F1034",
                table: "RPT_CLK_M",
                column: "F1034");

            migrationBuilder.CreateIndex(
                name: "RPT_CLK_M_F1185",
                table: "RPT_CLK_M",
                column: "F1185");

            migrationBuilder.CreateIndex(
                name: "RPT_CLK_P_F1034",
                table: "RPT_CLK_P",
                column: "F1034");

            migrationBuilder.CreateIndex(
                name: "RPT_CLK_P_F1185",
                table: "RPT_CLK_P",
                column: "F1185");

            migrationBuilder.CreateIndex(
                name: "RPT_CLK_W_F1034",
                table: "RPT_CLK_W",
                column: "F1034");

            migrationBuilder.CreateIndex(
                name: "RPT_CLK_W_F1185",
                table: "RPT_CLK_W",
                column: "F1185");

            migrationBuilder.CreateIndex(
                name: "RPT_CLK_Y_F1034",
                table: "RPT_CLK_Y",
                column: "F1034");

            migrationBuilder.CreateIndex(
                name: "RPT_CLK_Y_F1185",
                table: "RPT_CLK_Y",
                column: "F1185");

            migrationBuilder.CreateIndex(
                name: "RPT_CLT_D_F1034",
                table: "RPT_CLT_D",
                column: "F1034");

            migrationBuilder.CreateIndex(
                name: "RPT_CLT_D_F1148",
                table: "RPT_CLT_D",
                column: "F1148");

            migrationBuilder.CreateIndex(
                name: "RPT_CLT_F_F1034",
                table: "RPT_CLT_F",
                column: "F1034");

            migrationBuilder.CreateIndex(
                name: "RPT_CLT_F_F1148",
                table: "RPT_CLT_F",
                column: "F1148");

            migrationBuilder.CreateIndex(
                name: "RPT_CLT_M_F1034",
                table: "RPT_CLT_M",
                column: "F1034");

            migrationBuilder.CreateIndex(
                name: "RPT_CLT_M_F1148",
                table: "RPT_CLT_M",
                column: "F1148");

            migrationBuilder.CreateIndex(
                name: "RPT_CLT_P_F1034",
                table: "RPT_CLT_P",
                column: "F1034");

            migrationBuilder.CreateIndex(
                name: "RPT_CLT_P_F1148",
                table: "RPT_CLT_P",
                column: "F1148");

            migrationBuilder.CreateIndex(
                name: "RPT_CLT_W_F1034",
                table: "RPT_CLT_W",
                column: "F1034");

            migrationBuilder.CreateIndex(
                name: "RPT_CLT_W_F1148",
                table: "RPT_CLT_W",
                column: "F1148");

            migrationBuilder.CreateIndex(
                name: "RPT_CLT_Y_F1034",
                table: "RPT_CLT_Y",
                column: "F1034");

            migrationBuilder.CreateIndex(
                name: "RPT_CLT_Y_F1148",
                table: "RPT_CLT_Y",
                column: "F1148");

            migrationBuilder.CreateIndex(
                name: "RPT_HOU_F1034",
                table: "RPT_HOU",
                column: "F1034");

            migrationBuilder.CreateIndex(
                name: "RPT_ITM_D_F01",
                table: "RPT_ITM_D",
                column: "F01");

            migrationBuilder.CreateIndex(
                name: "RPT_ITM_D_F1034",
                table: "RPT_ITM_D",
                column: "F1034");

            migrationBuilder.CreateIndex(
                name: "RPT_ITM_F_F01",
                table: "RPT_ITM_F",
                column: "F01");

            migrationBuilder.CreateIndex(
                name: "RPT_ITM_F_F1034",
                table: "RPT_ITM_F",
                column: "F1034");

            migrationBuilder.CreateIndex(
                name: "RPT_ITM_M_F01",
                table: "RPT_ITM_M",
                column: "F01");

            migrationBuilder.CreateIndex(
                name: "RPT_ITM_M_F1034",
                table: "RPT_ITM_M",
                column: "F1034");

            migrationBuilder.CreateIndex(
                name: "RPT_ITM_P_F01",
                table: "RPT_ITM_P",
                column: "F01");

            migrationBuilder.CreateIndex(
                name: "RPT_ITM_P_F1034",
                table: "RPT_ITM_P",
                column: "F1034");

            migrationBuilder.CreateIndex(
                name: "RPT_ITM_W_F01",
                table: "RPT_ITM_W",
                column: "F01");

            migrationBuilder.CreateIndex(
                name: "RPT_ITM_W_F1034",
                table: "RPT_ITM_W",
                column: "F1034");

            migrationBuilder.CreateIndex(
                name: "RPT_ITM_Y_F01",
                table: "RPT_ITM_Y",
                column: "F01");

            migrationBuilder.CreateIndex(
                name: "RPT_ITM_Y_F1034",
                table: "RPT_ITM_Y",
                column: "F1034");

            migrationBuilder.CreateIndex(
                name: "RPT_VND_F1034",
                table: "RPT_VND",
                column: "F1034");

            migrationBuilder.CreateIndex(
                name: "RPT_VND_F27",
                table: "RPT_VND",
                column: "F27");

            migrationBuilder.CreateIndex(
                name: "SAL_BAT_F1148",
                table: "SAL_BAT",
                column: "F1148");

            migrationBuilder.CreateIndex(
                name: "SAL_HDR_F1148",
                table: "SAL_HDR",
                column: "F1148");

            migrationBuilder.CreateIndex(
                name: "SAL_HDR_SAV_F1148",
                table: "SAL_HDR_SAV",
                column: "F1148");

            migrationBuilder.CreateIndex(
                name: "SAL_REG_F01",
                table: "SAL_REG",
                column: "F01");

            migrationBuilder.CreateIndex(
                name: "SAL_REG_SAV_F01",
                table: "SAL_REG_SAV",
                column: "F01");

            migrationBuilder.CreateIndex(
                name: "SCL_DEL_F1000",
                table: "SCL_DEL",
                column: "F1000");

            migrationBuilder.CreateIndex(
                name: "SCL_DEL_F1001",
                table: "SCL_DEL",
                column: "F1001");

            migrationBuilder.CreateIndex(
                name: "SCL_DEL_F902",
                table: "SCL_DEL",
                column: "F902");

            migrationBuilder.CreateIndex(
                name: "SCL_TAB_F1000",
                table: "SCL_TAB",
                column: "F1000");

            migrationBuilder.CreateIndex(
                name: "SCL_TAB_F1001",
                table: "SCL_TAB",
                column: "F1001");

            migrationBuilder.CreateIndex(
                name: "SCL_TAB_F902",
                table: "SCL_TAB",
                column: "F902");

            migrationBuilder.CreateIndex(
                name: "SDP_TAB_F03",
                table: "SDP_TAB",
                column: "F03");

            migrationBuilder.CreateIndex(
                name: "STD_TAB_F1530",
                table: "STD_TAB",
                column: "F1530");

            migrationBuilder.CreateIndex(
                name: "TER_TAB_F1057",
                table: "TER_TAB",
                column: "F1057");

            migrationBuilder.CreateIndex(
                name: "TLZ_TAB_F1128",
                table: "TLZ_TAB",
                column: "F1128");

            migrationBuilder.CreateIndex(
                name: "TLZ_TAB_F1129",
                table: "TLZ_TAB",
                column: "F1129");

            migrationBuilder.CreateIndex(
                name: "TLZ_TAB_F1147",
                table: "TLZ_TAB",
                column: "F1147");

            migrationBuilder.CreateIndex(
                name: "TLZ_TAB_F1179",
                table: "TLZ_TAB",
                column: "F1179");

            migrationBuilder.CreateIndex(
                name: "TRS_CLK_F1032",
                table: "TRS_CLK",
                column: "F1032");

            migrationBuilder.CreateIndex(
                name: "TRS_CLK_F1034",
                table: "TRS_CLK",
                column: "F1034");

            migrationBuilder.CreateIndex(
                name: "TRS_CLK_F1185",
                table: "TRS_CLK",
                column: "F1185");

            migrationBuilder.CreateIndex(
                name: "TRS_CLT_F1032",
                table: "TRS_CLT",
                column: "F1032");

            migrationBuilder.CreateIndex(
                name: "TRS_CLT_F1034",
                table: "TRS_CLT",
                column: "F1034");

            migrationBuilder.CreateIndex(
                name: "TRS_CLT_F1148",
                table: "TRS_CLT",
                column: "F1148");

            migrationBuilder.CreateIndex(
                name: "TRS_DPT_F03",
                table: "TRS_DPT",
                column: "F03");

            migrationBuilder.CreateIndex(
                name: "TRS_DPT_F1032",
                table: "TRS_DPT",
                column: "F1032");

            migrationBuilder.CreateIndex(
                name: "TRS_DPT_F1034",
                table: "TRS_DPT",
                column: "F1034");

            migrationBuilder.CreateIndex(
                name: "TRS_FIN_F1032",
                table: "TRS_FIN",
                column: "F1032");

            migrationBuilder.CreateIndex(
                name: "TRS_FIN_F1034",
                table: "TRS_FIN",
                column: "F1034");

            migrationBuilder.CreateIndex(
                name: "TRS_ITM_F01",
                table: "TRS_ITM",
                column: "F01");

            migrationBuilder.CreateIndex(
                name: "TRS_ITM_F1032",
                table: "TRS_ITM",
                column: "F1032");

            migrationBuilder.CreateIndex(
                name: "TRS_ITM_F1034",
                table: "TRS_ITM",
                column: "F1034");

            migrationBuilder.CreateIndex(
                name: "TRS_SUB_F04",
                table: "TRS_SUB",
                column: "F04");

            migrationBuilder.CreateIndex(
                name: "TRS_SUB_F1032",
                table: "TRS_SUB",
                column: "F1032");

            migrationBuilder.CreateIndex(
                name: "TRS_SUB_F1034",
                table: "TRS_SUB",
                column: "F1034");

            migrationBuilder.CreateIndex(
                name: "TRS_VND_F1032",
                table: "TRS_VND",
                column: "F1032");

            migrationBuilder.CreateIndex(
                name: "TRS_VND_F1034",
                table: "TRS_VND",
                column: "F1034");

            migrationBuilder.CreateIndex(
                name: "TRS_VND_F27",
                table: "TRS_VND",
                column: "F27");

            migrationBuilder.CreateIndex(
                name: "VENDOR_DEL_F1001",
                table: "VENDOR_DEL",
                column: "F1001");

            migrationBuilder.CreateIndex(
                name: "VENDOR_DEL_F902",
                table: "VENDOR_DEL",
                column: "F902");

            migrationBuilder.CreateIndex(
                name: "VENDOR_TAB_F1001",
                table: "VENDOR_TAB",
                column: "F1001");

            migrationBuilder.CreateIndex(
                name: "VENDOR_TAB_F902",
                table: "VENDOR_TAB",
                column: "F902");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ACC_TAB");

            migrationBuilder.DropTable(
                name: "ALLOW_BAT");

            migrationBuilder.DropTable(
                name: "ALT_DEL");

            migrationBuilder.DropTable(
                name: "ALT_TAB");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "ASSRT_TAB");

            migrationBuilder.DropTable(
                name: "BIO_DEL");

            migrationBuilder.DropTable(
                name: "BIO_TAB");

            migrationBuilder.DropTable(
                name: "BMP_DEL");

            migrationBuilder.DropTable(
                name: "BMP_TAB");

            migrationBuilder.DropTable(
                name: "BTL_TAB");

            migrationBuilder.DropTable(
                name: "CAT_TAB");

            migrationBuilder.DropTable(
                name: "CFG_TAB");

            migrationBuilder.DropTable(
                name: "CKZ_TAB");

            migrationBuilder.DropTable(
                name: "CLF_SDP_TAB");

            migrationBuilder.DropTable(
                name: "CLF_TAB");

            migrationBuilder.DropTable(
                name: "CLG_TAB");

            migrationBuilder.DropTable(
                name: "CLK_DEL");

            migrationBuilder.DropTable(
                name: "CLK_TAB");

            migrationBuilder.DropTable(
                name: "CLL_DEL");

            migrationBuilder.DropTable(
                name: "CLL_TAB");

            migrationBuilder.DropTable(
                name: "CLR_TAB");

            migrationBuilder.DropTable(
                name: "CLS_AUX");

            migrationBuilder.DropTable(
                name: "CLS_DEL");

            migrationBuilder.DropTable(
                name: "CLS_TAB");

            migrationBuilder.DropTable(
                name: "CLT_DEL");

            migrationBuilder.DropTable(
                name: "CLT_ITM_DEL");

            migrationBuilder.DropTable(
                name: "CLT_ITM_TAB");

            migrationBuilder.DropTable(
                name: "CLT_TAB");

            migrationBuilder.DropTable(
                name: "COST_DEL");

            migrationBuilder.DropTable(
                name: "COST_TAB");

            migrationBuilder.DropTable(
                name: "CPN_TAB");

            migrationBuilder.DropTable(
                name: "DATA_REG");

            migrationBuilder.DropTable(
                name: "DELV_TAB");

            migrationBuilder.DropTable(
                name: "DEPT_TAB");

            migrationBuilder.DropTable(
                name: "Dril_File");

            migrationBuilder.DropTable(
                name: "Dril_Page");

            migrationBuilder.DropTable(
                name: "DSD_DEL");

            migrationBuilder.DropTable(
                name: "DSD_TAB");

            migrationBuilder.DropTable(
                name: "DSS_TAB");

            migrationBuilder.DropTable(
                name: "ECL_DEL");

            migrationBuilder.DropTable(
                name: "ECL_TAB");

            migrationBuilder.DropTable(
                name: "EXC_TAB");

            migrationBuilder.DropTable(
                name: "FAM_TAB");

            migrationBuilder.DropTable(
                name: "FBBACK_BAT");

            migrationBuilder.DropTable(
                name: "FCOST_BAT");

            migrationBuilder.DropTable(
                name: "FCSTBRK_BAT");

            migrationBuilder.DropTable(
                name: "FCT_TAB");

            migrationBuilder.DropTable(
                name: "FCZ_TAB");

            migrationBuilder.DropTable(
                name: "FDISC_BAT");

            migrationBuilder.DropTable(
                name: "FECL_BAT");

            migrationBuilder.DropTable(
                name: "FGCOST_BAT");

            migrationBuilder.DropTable(
                name: "FGPRICE_BAT");

            migrationBuilder.DropTable(
                name: "FIL_TAB");

            migrationBuilder.DropTable(
                name: "FINSTORE_BAT");

            migrationBuilder.DropTable(
                name: "FOBJ_BAT");

            migrationBuilder.DropTable(
                name: "FPID_BAT");

            migrationBuilder.DropTable(
                name: "FPOS_BAT");

            migrationBuilder.DropTable(
                name: "FPRICE_BAT");

            migrationBuilder.DropTable(
                name: "FREDEEM_BAT");

            migrationBuilder.DropTable(
                name: "FSPRICE_BAT");

            migrationBuilder.DropTable(
                name: "FTPRICE_BAT");

            migrationBuilder.DropTable(
                name: "HEADER_BAT");

            migrationBuilder.DropTable(
                name: "HEADER_DCT");

            migrationBuilder.DropTable(
                name: "HEADER_DEL");

            migrationBuilder.DropTable(
                name: "HEADER_EXE");

            migrationBuilder.DropTable(
                name: "HEADER_INS");

            migrationBuilder.DropTable(
                name: "HEADER_OLD");

            migrationBuilder.DropTable(
                name: "HEADER_SAV");

            migrationBuilder.DropTable(
                name: "HOOK_TAB");

            migrationBuilder.DropTable(
                name: "INV_BAT");

            migrationBuilder.DropTable(
                name: "INV_HDR");

            migrationBuilder.DropTable(
                name: "INV_REG");

            migrationBuilder.DropTable(
                name: "INV_TTL");

            migrationBuilder.DropTable(
                name: "ITD_DEL");

            migrationBuilder.DropTable(
                name: "ITD_TAB");

            migrationBuilder.DropTable(
                name: "ITZ_DEL");

            migrationBuilder.DropTable(
                name: "ITZ_TAB");

            migrationBuilder.DropTable(
                name: "KIT_DEL");

            migrationBuilder.DropTable(
                name: "KIT_TAB");

            migrationBuilder.DropTable(
                name: "LABEL_TAB");

            migrationBuilder.DropTable(
                name: "LABEL_TPL");

            migrationBuilder.DropTable(
                name: "LIKE_TAB");

            migrationBuilder.DropTable(
                name: "LNK_TAB");

            migrationBuilder.DropTable(
                name: "LOC_DEL");

            migrationBuilder.DropTable(
                name: "LOC_TAB");

            migrationBuilder.DropTable(
                name: "LST_HDR");

            migrationBuilder.DropTable(
                name: "LST_REG");

            migrationBuilder.DropTable(
                name: "LVL_TAB");

            migrationBuilder.DropTable(
                name: "MIX_DEL");

            migrationBuilder.DropTable(
                name: "MIX_TAB");

            migrationBuilder.DropTable(
                name: "MOD_ITM_TAB");

            migrationBuilder.DropTable(
                name: "MOD_TAB");

            migrationBuilder.DropTable(
                name: "NACS_TAB");

            migrationBuilder.DropTable(
                name: "OALLOW_BAT");

            migrationBuilder.DropTable(
                name: "OBBACK_BAT");

            migrationBuilder.DropTable(
                name: "OBJ_DEL");

            migrationBuilder.DropTable(
                name: "OBJ_TAB");

            migrationBuilder.DropTable(
                name: "OCOST_BAT");

            migrationBuilder.DropTable(
                name: "OCSTBRK_BAT");

            migrationBuilder.DropTable(
                name: "ODISC_BAT");

            migrationBuilder.DropTable(
                name: "OECL_BAT");

            migrationBuilder.DropTable(
                name: "OFR_TAB");

            migrationBuilder.DropTable(
                name: "OGCOST_BAT");

            migrationBuilder.DropTable(
                name: "OGPRICE_BAT");

            migrationBuilder.DropTable(
                name: "OINSTORE_BAT");

            migrationBuilder.DropTable(
                name: "OOBJ_BAT");

            migrationBuilder.DropTable(
                name: "OPID_BAT");

            migrationBuilder.DropTable(
                name: "OPOS_BAT");

            migrationBuilder.DropTable(
                name: "OPRICE_BAT");

            migrationBuilder.DropTable(
                name: "OREBATE_BAT");

            migrationBuilder.DropTable(
                name: "OREDEEM_BAT");

            migrationBuilder.DropTable(
                name: "OSPRICE_BAT");

            migrationBuilder.DropTable(
                name: "OTPRICE_BAT");

            migrationBuilder.DropTable(
                name: "PAY_TAB");

            migrationBuilder.DropTable(
                name: "PERIOD_TAB");

            migrationBuilder.DropTable(
                name: "POS_DEL");

            migrationBuilder.DropTable(
                name: "POS_TAB");

            migrationBuilder.DropTable(
                name: "PRICE_DEL");

            migrationBuilder.DropTable(
                name: "PRICE_TAB");

            migrationBuilder.DropTable(
                name: "PROFILE_TAB");

            migrationBuilder.DropTable(
                name: "PUB_TAB");

            migrationBuilder.DropTable(
                name: "RB_FIELDS");

            migrationBuilder.DropTable(
                name: "RB_JOINS");

            migrationBuilder.DropTable(
                name: "RB_TABLES");

            migrationBuilder.DropTable(
                name: "RCP_DET_TAB");

            migrationBuilder.DropTable(
                name: "RCP_ITM_TAB");

            migrationBuilder.DropTable(
                name: "RCP_TAB");

            migrationBuilder.DropTable(
                name: "REASON_TAB");

            migrationBuilder.DropTable(
                name: "REBATE_BAT");

            migrationBuilder.DropTable(
                name: "REC_BAT");

            migrationBuilder.DropTable(
                name: "REC_HDR");

            migrationBuilder.DropTable(
                name: "REC_HDR_SAV");

            migrationBuilder.DropTable(
                name: "REC_REG");

            migrationBuilder.DropTable(
                name: "REC_REG_SAV");

            migrationBuilder.DropTable(
                name: "REC_TTL");

            migrationBuilder.DropTable(
                name: "REC_TTL_SAV");

            migrationBuilder.DropTable(
                name: "RENT_TAB");

            migrationBuilder.DropTable(
                name: "RES_TAB");

            migrationBuilder.DropTable(
                name: "REV_EXEC");

            migrationBuilder.DropTable(
                name: "REV_HDR");

            migrationBuilder.DropTable(
                name: "REV_LIST");

            migrationBuilder.DropTable(
                name: "REV_QUEUE");

            migrationBuilder.DropTable(
                name: "ROUTE_TAB");

            migrationBuilder.DropTable(
                name: "RPC_TAB");

            migrationBuilder.DropTable(
                name: "RPT_CLK_D");

            migrationBuilder.DropTable(
                name: "RPT_CLK_F");

            migrationBuilder.DropTable(
                name: "RPT_CLK_M");

            migrationBuilder.DropTable(
                name: "RPT_CLK_N");

            migrationBuilder.DropTable(
                name: "RPT_CLK_P");

            migrationBuilder.DropTable(
                name: "RPT_CLK_W");

            migrationBuilder.DropTable(
                name: "RPT_CLK_Y");

            migrationBuilder.DropTable(
                name: "RPT_CLT_D");

            migrationBuilder.DropTable(
                name: "RPT_CLT_F");

            migrationBuilder.DropTable(
                name: "RPT_CLT_ITM_D");

            migrationBuilder.DropTable(
                name: "RPT_CLT_ITM_N");

            migrationBuilder.DropTable(
                name: "RPT_CLT_M");

            migrationBuilder.DropTable(
                name: "RPT_CLT_N");

            migrationBuilder.DropTable(
                name: "RPT_CLT_P");

            migrationBuilder.DropTable(
                name: "RPT_CLT_W");

            migrationBuilder.DropTable(
                name: "RPT_CLT_Y");

            migrationBuilder.DropTable(
                name: "RPT_DPT");

            migrationBuilder.DropTable(
                name: "RPT_FIN");

            migrationBuilder.DropTable(
                name: "RPT_HOU");

            migrationBuilder.DropTable(
                name: "RPT_ITM_D");

            migrationBuilder.DropTable(
                name: "RPT_ITM_F");

            migrationBuilder.DropTable(
                name: "RPT_ITM_M");

            migrationBuilder.DropTable(
                name: "RPT_ITM_N");

            migrationBuilder.DropTable(
                name: "RPT_ITM_P");

            migrationBuilder.DropTable(
                name: "RPT_ITM_W");

            migrationBuilder.DropTable(
                name: "RPT_ITM_Y");

            migrationBuilder.DropTable(
                name: "RPT_SUB");

            migrationBuilder.DropTable(
                name: "RPT_VND");

            migrationBuilder.DropTable(
                name: "RUN_TAB");

            migrationBuilder.DropTable(
                name: "SAL_BAT");

            migrationBuilder.DropTable(
                name: "SAL_DET");

            migrationBuilder.DropTable(
                name: "SAL_DET_SAV");

            migrationBuilder.DropTable(
                name: "SAL_HDR");

            migrationBuilder.DropTable(
                name: "SAL_HDR_SAV");

            migrationBuilder.DropTable(
                name: "SAL_REG");

            migrationBuilder.DropTable(
                name: "SAL_REG_SAV");

            migrationBuilder.DropTable(
                name: "SAL_TTL");

            migrationBuilder.DropTable(
                name: "SAL_TTL_SAV");

            migrationBuilder.DropTable(
                name: "SCL_CCT_DEL");

            migrationBuilder.DropTable(
                name: "SCL_CCT_TAB");

            migrationBuilder.DropTable(
                name: "SCL_CPT_DEL");

            migrationBuilder.DropTable(
                name: "SCL_CPT_TAB");

            migrationBuilder.DropTable(
                name: "SCL_CSL_DEL");

            migrationBuilder.DropTable(
                name: "SCL_CSL_TAB");

            migrationBuilder.DropTable(
                name: "SCL_CTX_DEL");

            migrationBuilder.DropTable(
                name: "SCL_CTX_TAB");

            migrationBuilder.DropTable(
                name: "SCL_DEL");

            migrationBuilder.DropTable(
                name: "SCL_NUT_DEL");

            migrationBuilder.DropTable(
                name: "SCL_NUT_TAB");

            migrationBuilder.DropTable(
                name: "SCL_STO_DEL");

            migrationBuilder.DropTable(
                name: "SCL_STO_TAB");

            migrationBuilder.DropTable(
                name: "SCL_TAB");

            migrationBuilder.DropTable(
                name: "SCL_TXT_DEL");

            migrationBuilder.DropTable(
                name: "SCL_TXT_TAB");

            migrationBuilder.DropTable(
                name: "SDP_TAB");

            migrationBuilder.DropTable(
                name: "SETUP_TAB");

            migrationBuilder.DropTable(
                name: "SHF_TAB");

            migrationBuilder.DropTable(
                name: "STD_TAB");

            migrationBuilder.DropTable(
                name: "STO_TAB");

            migrationBuilder.DropTable(
                name: "SYS_TAB");

            migrationBuilder.DropTable(
                name: "TAR_TAB");

            migrationBuilder.DropTable(
                name: "TASK_TAB");

            migrationBuilder.DropTable(
                name: "TER_TAB");

            migrationBuilder.DropTable(
                name: "TLZ_TAB");

            migrationBuilder.DropTable(
                name: "TRS_CLK");

            migrationBuilder.DropTable(
                name: "TRS_CLT");

            migrationBuilder.DropTable(
                name: "TRS_DPT");

            migrationBuilder.DropTable(
                name: "TRS_FIN");

            migrationBuilder.DropTable(
                name: "TRS_ITM");

            migrationBuilder.DropTable(
                name: "TRS_LOG");

            migrationBuilder.DropTable(
                name: "TRS_SUB");

            migrationBuilder.DropTable(
                name: "TRS_VND");

            migrationBuilder.DropTable(
                name: "TZS_TAB");

            migrationBuilder.DropTable(
                name: "UNT_TAB");

            migrationBuilder.DropTable(
                name: "VENDOR_DEL");

            migrationBuilder.DropTable(
                name: "VENDOR_TAB");

            migrationBuilder.DropTable(
                name: "WATCH_TAB");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
