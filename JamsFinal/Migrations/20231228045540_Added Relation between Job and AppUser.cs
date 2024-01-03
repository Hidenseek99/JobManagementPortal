using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JamsFinal.Migrations
{
    /// <inheritdoc />
    public partial class AddedRelationbetweenJobandAppUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "userId",
                table: "Jobs",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Jobs_userId",
                table: "Jobs",
                column: "userId");

            migrationBuilder.AddForeignKey(
                name: "FK_Jobs_AspNetUsers_userId",
                table: "Jobs",
                column: "userId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Jobs_AspNetUsers_userId",
                table: "Jobs");

            migrationBuilder.DropIndex(
                name: "IX_Jobs_userId",
                table: "Jobs");

            migrationBuilder.DropColumn(
                name: "userId",
                table: "Jobs");
        }
    }
}