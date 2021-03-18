using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebShopIP.Migrations
{
    public partial class AlterProduct_Categorys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 250, nullable: false),
                    MetaTitle = table.Column<string>(maxLength: 250, nullable: true),
                    ParentID = table.Column<long>(nullable: true),
                    DisplayOrder = table.Column<int>(nullable: true),
                    SeoTitle = table.Column<string>(maxLength: 250, nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(maxLength: 50, nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    ModifiedBy = table.Column<string>(maxLength: 50, nullable: true),
                    MetaKeywords = table.Column<string>(maxLength: 250, nullable: true),
                    MetaDescriptions = table.Column<string>(maxLength: 250, nullable: true),
                    Status = table.Column<bool>(nullable: true),
                    ShowOnHome = table.Column<bool>(nullable: true),
                    Language = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 250, nullable: true),
                    Code = table.Column<string>(maxLength: 10, nullable: true),
                    MetaTitle = table.Column<string>(maxLength: 250, nullable: true),
                    Description = table.Column<string>(maxLength: 500, nullable: true),
                    Image = table.Column<string>(maxLength: 250, nullable: true),
                    MoreImages = table.Column<string>(type: "xml", nullable: true),
                    Price = table.Column<decimal>(nullable: true),
                    PromotionPrice = table.Column<decimal>(nullable: true),
                    IncludedVAT = table.Column<bool>(nullable: true),
                    Quantity = table.Column<int>(nullable: false),
                    CategoryID = table.Column<long>(nullable: true),
                    Detail = table.Column<string>(type: "ntext", nullable: true),
                    Warranty = table.Column<int>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(maxLength: 50, nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    ModifiedBy = table.Column<string>(maxLength: 50, nullable: true),
                    MetaKeywords = table.Column<string>(maxLength: 250, nullable: true),
                    MetaDescriptions = table.Column<string>(maxLength: 250, nullable: true),
                    Status = table.Column<bool>(nullable: true),
                    TopHot = table.Column<DateTime>(nullable: true),
                    ViewCount = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Product");
        }
    }
}
