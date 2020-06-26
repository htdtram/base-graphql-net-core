using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace base_graphql_net_core.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DelFlag = table.Column<bool>(nullable: false),
                    CreateAt = table.Column<DateTime>(nullable: false),
                    UpdateAt = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DelFlag = table.Column<bool>(nullable: false),
                    CreateAt = table.Column<DateTime>(nullable: false),
                    UpdateAt = table.Column<DateTime>(nullable: true),
                    Username = table.Column<string>(maxLength: 100, nullable: false),
                    Password = table.Column<string>(maxLength: 50, nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Gender = table.Column<int>(nullable: false),
                    Role = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DelFlag = table.Column<bool>(nullable: false),
                    CreateAt = table.Column<DateTime>(nullable: false),
                    UpdateAt = table.Column<DateTime>(nullable: true),
                    Title = table.Column<string>(maxLength: 100, nullable: false),
                    Desciption = table.Column<string>(maxLength: 500, nullable: true),
                    Price = table.Column<double>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Product_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Post",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DelFlag = table.Column<bool>(nullable: false),
                    CreateAt = table.Column<DateTime>(nullable: false),
                    UpdateAt = table.Column<DateTime>(nullable: true),
                    Title = table.Column<string>(maxLength: 100, nullable: false),
                    Description = table.Column<string>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Post", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Post_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "CreateAt", "DelFlag", "Name", "UpdateAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 6, 26, 3, 37, 37, 685, DateTimeKind.Utc).AddTicks(2952), false, "Shirt", null },
                    { 2, new DateTime(2020, 6, 26, 3, 37, 37, 685, DateTimeKind.Utc).AddTicks(4250), false, "Hat", null },
                    { 3, new DateTime(2020, 6, 26, 3, 37, 37, 685, DateTimeKind.Utc).AddTicks(4270), false, "Bike", null }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CreateAt", "DelFlag", "Gender", "Name", "Password", "Role", "UpdateAt", "Username" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 6, 26, 3, 37, 37, 696, DateTimeKind.Utc).AddTicks(5068), false, 1, "Admin", "e10adc3949ba59abbe56e057f20f883e", 0, null, "admin" },
                    { 2, new DateTime(2020, 6, 26, 3, 37, 37, 706, DateTimeKind.Utc).AddTicks(6512), false, 0, "Manager1", "e10adc3949ba59abbe56e057f20f883e", 1, null, "manager" },
                    { 3, new DateTime(2020, 6, 26, 3, 37, 37, 706, DateTimeKind.Utc).AddTicks(6743), false, 1, "Employee 1", "e10adc3949ba59abbe56e057f20f883e", 2, null, "employee1" },
                    { 4, new DateTime(2020, 6, 26, 3, 37, 37, 706, DateTimeKind.Utc).AddTicks(6766), false, 0, "Employee 2", "e10adc3949ba59abbe56e057f20f883e", 2, null, "employee2" },
                    { 5, new DateTime(2020, 6, 26, 3, 37, 37, 706, DateTimeKind.Utc).AddTicks(6828), false, 1, "Employee 3", "e10adc3949ba59abbe56e057f20f883e", 2, null, "employee3" }
                });

            migrationBuilder.InsertData(
                table: "Post",
                columns: new[] { "Id", "CreateAt", "DelFlag", "Description", "Title", "UpdateAt", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 6, 26, 3, 37, 37, 707, DateTimeKind.Utc).AddTicks(9137), false, "Description 1", "Post 1", null, 3 },
                    { 2, new DateTime(2020, 6, 26, 3, 37, 37, 708, DateTimeKind.Utc).AddTicks(444), false, "Description 2", "Post 2", null, 3 },
                    { 3, new DateTime(2020, 6, 26, 3, 37, 37, 708, DateTimeKind.Utc).AddTicks(473), false, "Description 3", "Post 3", null, 4 },
                    { 5, new DateTime(2020, 6, 26, 3, 37, 37, 708, DateTimeKind.Utc).AddTicks(476), false, "Description 5", "Post 5", null, 4 },
                    { 4, new DateTime(2020, 6, 26, 3, 37, 37, 708, DateTimeKind.Utc).AddTicks(475), false, "Description 4", "Post 4", null, 5 }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CategoryId", "CreateAt", "DelFlag", "Desciption", "Price", "Title", "UpdateAt" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2020, 6, 26, 3, 37, 37, 691, DateTimeKind.Utc).AddTicks(4130), false, "Desciption 01", 10.0, "Product 01", null },
                    { 2, 1, new DateTime(2020, 6, 26, 3, 37, 37, 691, DateTimeKind.Utc).AddTicks(6028), false, "Desciption 02", 11.0, "Product 02", null },
                    { 3, 2, new DateTime(2020, 6, 26, 3, 37, 37, 691, DateTimeKind.Utc).AddTicks(6061), false, "Desciption 03", 12.0, "Product 03", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Post_UserId",
                table: "Post",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_CategoryId",
                table: "Product",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_User_Username",
                table: "User",
                column: "Username",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Post");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Category");
        }
    }
}
