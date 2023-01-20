using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Marketplace.Migrations
{
    /// <inheritdoc />
    public partial class UserNavigationAndOwnedEntityOnReviewsAdjust : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemReviews_Users_Review_UserId",
                table: "ItemReviews");

            migrationBuilder.DropForeignKey(
                name: "FK_StoreReviews_Users_Review_UserId",
                table: "StoreReviews");

            migrationBuilder.RenameColumn(
                name: "Review_UserId",
                table: "StoreReviews",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_StoreReviews_Review_UserId",
                table: "StoreReviews",
                newName: "IX_StoreReviews_UserId");

            migrationBuilder.RenameColumn(
                name: "Review_UserId",
                table: "ItemReviews",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_ItemReviews_Review_UserId",
                table: "ItemReviews",
                newName: "IX_ItemReviews_UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemReviews_Users_UserId",
                table: "ItemReviews",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StoreReviews_Users_UserId",
                table: "StoreReviews",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemReviews_Users_UserId",
                table: "ItemReviews");

            migrationBuilder.DropForeignKey(
                name: "FK_StoreReviews_Users_UserId",
                table: "StoreReviews");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "StoreReviews",
                newName: "Review_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_StoreReviews_UserId",
                table: "StoreReviews",
                newName: "IX_StoreReviews_Review_UserId");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "ItemReviews",
                newName: "Review_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_ItemReviews_UserId",
                table: "ItemReviews",
                newName: "IX_ItemReviews_Review_UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemReviews_Users_Review_UserId",
                table: "ItemReviews",
                column: "Review_UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StoreReviews_Users_Review_UserId",
                table: "StoreReviews",
                column: "Review_UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
