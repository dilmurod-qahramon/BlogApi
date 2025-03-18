using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlogApi.Migrations
{
    /// <inheritdoc />
    public partial class FixAuthorRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_posts_authors_AuthorId1",
                table: "posts");

            migrationBuilder.DropIndex(
                name: "IX_posts_AuthorId1",
                table: "posts");

            migrationBuilder.DropColumn(
                name: "AuthorId1",
                table: "posts");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "AuthorId1",
                table: "posts",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_posts_AuthorId1",
                table: "posts",
                column: "AuthorId1");

            migrationBuilder.AddForeignKey(
                name: "FK_posts_authors_AuthorId1",
                table: "posts",
                column: "AuthorId1",
                principalTable: "authors",
                principalColumn: "Id");
        }
    }
}
