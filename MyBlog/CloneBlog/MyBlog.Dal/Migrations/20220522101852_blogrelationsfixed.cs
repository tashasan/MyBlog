using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyBlog.Dal.Migrations
{
    public partial class blogrelationsfixed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_Comments_CommentId",
                table: "Blogs");

            migrationBuilder.DropIndex(
                name: "IX_Blogs_CategoryId",
                table: "Blogs");

            migrationBuilder.RenameColumn(
                name: "CommentId",
                table: "Blogs",
                newName: "WriterId");

            migrationBuilder.RenameIndex(
                name: "IX_Blogs_CommentId",
                table: "Blogs",
                newName: "IX_Blogs_WriterId");

            migrationBuilder.AddColumn<int>(
                name: "BlogId",
                table: "Comments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Comments_BlogId",
                table: "Comments",
                column: "BlogId");

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_CategoryId",
                table: "Blogs",
                column: "CategoryId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_Writers_WriterId",
                table: "Blogs",
                column: "WriterId",
                principalTable: "Writers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Blogs_BlogId",
                table: "Comments",
                column: "BlogId",
                principalTable: "Blogs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_Writers_WriterId",
                table: "Blogs");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Blogs_BlogId",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_BlogId",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Blogs_CategoryId",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "BlogId",
                table: "Comments");

            migrationBuilder.RenameColumn(
                name: "WriterId",
                table: "Blogs",
                newName: "CommentId");

            migrationBuilder.RenameIndex(
                name: "IX_Blogs_WriterId",
                table: "Blogs",
                newName: "IX_Blogs_CommentId");

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_CategoryId",
                table: "Blogs",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_Comments_CommentId",
                table: "Blogs",
                column: "CommentId",
                principalTable: "Comments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
