using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class api2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Games_GameId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_GameGalleries_Games_GameId",
                table: "GameGalleries");

            migrationBuilder.DropForeignKey(
                name: "FK_Games_Categories_CategoryId",
                table: "Games");

            migrationBuilder.DropForeignKey(
                name: "FK_Games_Developers_DeveloperId",
                table: "Games");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Games",
                table: "Games");

            migrationBuilder.RenameTable(
                name: "Games",
                newName: "Oyunlar");

            migrationBuilder.RenameIndex(
                name: "IX_Games_DeveloperId",
                table: "Oyunlar",
                newName: "IX_Oyunlar_DeveloperId");

            migrationBuilder.RenameIndex(
                name: "IX_Games_CategoryId",
                table: "Oyunlar",
                newName: "IX_Oyunlar_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Oyunlar",
                table: "Oyunlar",
                column: "GameId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Oyunlar_GameId",
                table: "Comments",
                column: "GameId",
                principalTable: "Oyunlar",
                principalColumn: "GameId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GameGalleries_Oyunlar_GameId",
                table: "GameGalleries",
                column: "GameId",
                principalTable: "Oyunlar",
                principalColumn: "GameId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Oyunlar_Categories_CategoryId",
                table: "Oyunlar",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Oyunlar_Developers_DeveloperId",
                table: "Oyunlar",
                column: "DeveloperId",
                principalTable: "Developers",
                principalColumn: "DeveloperId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Oyunlar_GameId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_GameGalleries_Oyunlar_GameId",
                table: "GameGalleries");

            migrationBuilder.DropForeignKey(
                name: "FK_Oyunlar_Categories_CategoryId",
                table: "Oyunlar");

            migrationBuilder.DropForeignKey(
                name: "FK_Oyunlar_Developers_DeveloperId",
                table: "Oyunlar");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Oyunlar",
                table: "Oyunlar");

            migrationBuilder.RenameTable(
                name: "Oyunlar",
                newName: "Games");

            migrationBuilder.RenameIndex(
                name: "IX_Oyunlar_DeveloperId",
                table: "Games",
                newName: "IX_Games_DeveloperId");

            migrationBuilder.RenameIndex(
                name: "IX_Oyunlar_CategoryId",
                table: "Games",
                newName: "IX_Games_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Games",
                table: "Games",
                column: "GameId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Games_GameId",
                table: "Comments",
                column: "GameId",
                principalTable: "Games",
                principalColumn: "GameId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GameGalleries_Games_GameId",
                table: "GameGalleries",
                column: "GameId",
                principalTable: "Games",
                principalColumn: "GameId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Games_Categories_CategoryId",
                table: "Games",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Games_Developers_DeveloperId",
                table: "Games",
                column: "DeveloperId",
                principalTable: "Developers",
                principalColumn: "DeveloperId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
