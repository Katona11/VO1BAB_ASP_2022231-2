using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VO1BAB_ASP_2022231.Data.Migrations
{
    public partial class addcars : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "332aadbe-247c-47a3-906c-6dba8f2f3a15" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "332aadbe-247c-47a3-906c-6dba8f2f3a15");

            migrationBuilder.CreateTable(
                name: "carbrand",
                columns: table => new
                {
                    CarBrandID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_carbrand", x => x.CarBrandID);
                });

            migrationBuilder.CreateTable(
                name: "cars",
                columns: table => new
                {
                    CarsID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarBrandID = table.Column<int>(type: "int", nullable: false),
                    LicensePlateNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PerformanceInHP = table.Column<int>(type: "int", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cars", x => x.CarsID);
                    table.ForeignKey(
                        name: "FK_cars_carbrand_CarBrandID",
                        column: x => x.CarBrandID,
                        principalTable: "carbrand",
                        principalColumn: "CarBrandID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "63472dcc-4a40-42c0-a971-604039d1120c", 0, "4ab91da9-5c0b-4397-bdf7-d137a6a48f0b", "katona@katona.com", true, false, null, null, "KATONA@KATONA.COM", "AQAAAAEAACcQAAAAEGNQs0l05chihejftvW75FN1kkMpJciseHZEUYKt3jHXOUcwdAmr/f5xMZCIUAFxlA==", null, false, "771b156c-96d7-48d5-b2c9-f6cda80a2ff0", false, "katona@katona.com" });

            migrationBuilder.InsertData(
                table: "carbrand",
                columns: new[] { "CarBrandID", "Name" },
                values: new object[,]
                {
                    { 1, "BMW" },
                    { 2, "Mercedes-Benz" },
                    { 3, "Ford" },
                    { 4, "Skoda" },
                    { 5, "Audi" },
                    { 6, "Kia" },
                    { 7, "Opel" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1", "63472dcc-4a40-42c0-a971-604039d1120c" });

            migrationBuilder.InsertData(
                table: "cars",
                columns: new[] { "CarsID", "CarBrandID", "Image", "LicensePlateNumber", "PerformanceInHP", "Type", "Year" },
                values: new object[,]
                {
                    { 1, 1, "https://www.netcarshow.com/Hamann-BMW_5er_E60_545i-2005-1280-01.jpg", "HFG-453", 310, "E60", 2004 },
                    { 2, 2, "https://www.netcarshow.com/Mercedes-Benz-CLS63_AMG-2015-1280-07.jpg", "SNK-955", 605, "CLS-63", 2019 },
                    { 3, 3, "https://www.netcarshow.com/Ford-Mondeo-2011-1280-01.jpg", "JPK-245", 110, "Mondeo", 2008 },
                    { 4, 3, "https://www.netcarshow.com/Ford-Mondeo_Concept-2007-1280-03.jpg", "KLK-615", 130, "Mondeo", 2009 },
                    { 5, 4, "https://www.netcarshow.com/Skoda-Octavia_Combi_RS-2014-1280-04.jpg", "MIH-400", 150, "Ocatavia", 2014 },
                    { 6, 5, "https://www.netcarshow.com/Audi-A3_Sportback_e-tron-2017-1280-01.jpg", "P-55332", 150, "A3", 2016 },
                    { 7, 5, "https://www.netcarshow.com/Audi-A3_Sportback_e-tron-2017-1280-02.jpg", "P-55456", 150, "A3", 2016 },
                    { 8, 6, "https://www.netcarshow.com/Kia-Ceed_SW_GT-Line-2016-1280-01.jpg", "SEZ-488", 190, "Ceed", 2016 },
                    { 9, 4, "https://www.netcarshow.com/Skoda-Kodiaq_Sportline-2018-1280-03.jpg", "SBC-888", 200, "Kodiaq", 2018 },
                    { 10, 4, "https://www.netcarshow.com/Skoda-Superb_Combi_4x4-2010-1280-02.jpg", "HCD-104", 200, "Superb", 2010 },
                    { 11, 7, "https://www.netcarshow.com/Vauxhall-Astra_VXR-2005-1280-02.jpg", "PET-555", 90, "Astra", 2004 },
                    { 12, 4, "https://www.netcarshow.com/Skoda-Octavia_Combi-2004-1280-12.jpg", "JKL-256", 80, "Octavia", 2004 },
                    { 13, 1, "https://www.netcarshow.com/BMW-M5_CS-2022-1280-01.jpg", "KCI-442", 190, "530D", 2011 },
                    { 14, 2, "https://www.netcarshow.com/Mercedes-Benz-GLE-2016-1280-01.jpg", "ONS-875", 220, "CLA", 2017 },
                    { 15, 2, "https://www.netcarshow.com/Mercedes-Benz-GLE-2016-1280-01.jpg", "OCC-325", 220, "CLA", 2017 },
                    { 16, 2, "https://www.netcarshow.com/Mercedes-Benz-GLE-2016-1280-01.jpg", "OBS-432", 220, "CLA", 2017 },
                    { 17, 4, "https://www.netcarshow.com/Skoda-Octavia_RS-2020-1280-01.jpg", "PRS-564", 150, "Octvia", 2018 },
                    { 18, 5, "https://www.netcarshow.com/Audi-SQ8_e-tron_quattro-2024-1280-01.jpg", "AA-AA-343", 400, "E-TRON", 2022 },
                    { 19, 4, "https://www.netcarshow.com/Skoda-Kodiaq-2017-1280-01.jpg", "AA-AY-789", 160, "Kodiaq", 2022 },
                    { 20, 1, "https://www.netcarshow.com/BMW-M5-2005-1280-01.jpg", "AA-AV-121", 700, "M5", 2022 },
                    { 21, 1, "https://www.netcarshow.com/BMW-M5-2005-1280-01.jpg", "HFG-453", 310, "E60", 2004 },
                    { 22, 1, "https://www.netcarshow.com/BMW-M5-2005-1280-01.jpg", "HFG-453", 310, "E60", 2004 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_cars_CarBrandID",
                table: "cars",
                column: "CarBrandID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "cars");

            migrationBuilder.DropTable(
                name: "carbrand");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "63472dcc-4a40-42c0-a971-604039d1120c" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "63472dcc-4a40-42c0-a971-604039d1120c");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "332aadbe-247c-47a3-906c-6dba8f2f3a15", 0, "5c61e0d2-de91-4570-9cc2-d832b0b7a74b", "katona@katona.com", true, false, null, null, "KATONA@KATONA.COM", "AQAAAAEAACcQAAAAEJYeJKshZekgVIRgPfsRZgRHOjYqf2Y0dzod44aKpHq9ysfHIOgr+k7O8pJ6R01kEA==", null, false, "7a0472b6-8965-472c-a69f-dade0607c140", false, "katona@katona.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1", "332aadbe-247c-47a3-906c-6dba8f2f3a15" });
        }
    }
}
