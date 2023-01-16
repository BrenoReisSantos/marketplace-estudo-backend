using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Marketplace.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    ItemId = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(60)", maxLength: 60, nullable: false),
                    Price = table.Column<decimal>(type: "numeric", nullable: false),
                    BarCode = table.Column<string>(type: "text", nullable: false),
                    Rating = table.Column<double>(type: "double precision", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.ItemId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    Cpf = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Phone = table.Column<string>(type: "text", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    EmailConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    UserRole = table.Column<byte>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "CategoryItem",
                columns: table => new
                {
                    CategoriesCategoryId = table.Column<Guid>(type: "uuid", nullable: false),
                    ItemsItemId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryItem", x => new { x.CategoriesCategoryId, x.ItemsItemId });
                    table.ForeignKey(
                        name: "FK_CategoryItem_Categories_CategoriesCategoryId",
                        column: x => x.CategoriesCategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryItem_Items_ItemsItemId",
                        column: x => x.ItemsItemId,
                        principalTable: "Items",
                        principalColumn: "ItemId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemReviews",
                columns: table => new
                {
                    ItemReviewId = table.Column<Guid>(type: "uuid", nullable: false),
                    ItemId = table.Column<Guid>(type: "uuid", nullable: false),
                    ReviewRating = table.Column<double>(name: "Review_Rating", type: "double precision", nullable: false),
                    ReviewContent = table.Column<string>(name: "Review_Content", type: "text", nullable: true),
                    ReviewUserId = table.Column<Guid>(name: "Review_UserId", type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemReviews", x => x.ItemReviewId);
                    table.ForeignKey(
                        name: "FK_ItemReviews_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "ItemId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemReviews_Users_Review_UserId",
                        column: x => x.ReviewUserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Stores",
                columns: table => new
                {
                    StoreId = table.Column<Guid>(type: "uuid", nullable: false),
                    Cnpj = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "character varying(60)", maxLength: 60, nullable: false),
                    Cep = table.Column<string>(type: "text", nullable: false),
                    Number = table.Column<int>(type: "integer", nullable: false),
                    Phone = table.Column<string>(type: "text", nullable: false),
                    Rating = table.Column<double>(type: "double precision", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stores", x => x.StoreId);
                    table.ForeignKey(
                        name: "FK_Stores_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemStore",
                columns: table => new
                {
                    ItemsItemId = table.Column<Guid>(type: "uuid", nullable: false),
                    StoresStoreId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemStore", x => new { x.ItemsItemId, x.StoresStoreId });
                    table.ForeignKey(
                        name: "FK_ItemStore_Items_ItemsItemId",
                        column: x => x.ItemsItemId,
                        principalTable: "Items",
                        principalColumn: "ItemId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemStore_Stores_StoresStoreId",
                        column: x => x.StoresStoreId,
                        principalTable: "Stores",
                        principalColumn: "StoreId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StoreReviews",
                columns: table => new
                {
                    StoreReviewId = table.Column<Guid>(type: "uuid", nullable: false),
                    StoreId = table.Column<Guid>(type: "uuid", nullable: false),
                    ReviewRating = table.Column<double>(name: "Review_Rating", type: "double precision", nullable: false),
                    ReviewContent = table.Column<string>(name: "Review_Content", type: "text", nullable: true),
                    ReviewUserId = table.Column<Guid>(name: "Review_UserId", type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StoreReviews", x => x.StoreReviewId);
                    table.ForeignKey(
                        name: "FK_StoreReviews_Stores_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Stores",
                        principalColumn: "StoreId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StoreReviews_Users_Review_UserId",
                        column: x => x.ReviewUserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CategoryItem_ItemsItemId",
                table: "CategoryItem",
                column: "ItemsItemId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemReviews_ItemId",
                table: "ItemReviews",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemReviews_Review_UserId",
                table: "ItemReviews",
                column: "Review_UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemStore_StoresStoreId",
                table: "ItemStore",
                column: "StoresStoreId");

            migrationBuilder.CreateIndex(
                name: "IX_StoreReviews_Review_UserId",
                table: "StoreReviews",
                column: "Review_UserId");

            migrationBuilder.CreateIndex(
                name: "IX_StoreReviews_StoreId",
                table: "StoreReviews",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_Stores_Cnpj",
                table: "Stores",
                column: "Cnpj");

            migrationBuilder.CreateIndex(
                name: "IX_Stores_Email",
                table: "Stores",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Stores_Phone",
                table: "Stores",
                column: "Phone",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Stores_UserId",
                table: "Stores",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Cpf",
                table: "Users",
                column: "Cpf",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_Email",
                table: "Users",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_Phone",
                table: "Users",
                column: "Phone",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoryItem");

            migrationBuilder.DropTable(
                name: "ItemReviews");

            migrationBuilder.DropTable(
                name: "ItemStore");

            migrationBuilder.DropTable(
                name: "StoreReviews");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Stores");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
