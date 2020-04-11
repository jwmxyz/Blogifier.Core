using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Blogifier.Core.Migrations
{
    public partial class NewsletterIpDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "Newsletters",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ip",
                table: "Newsletters",
                maxLength: 80,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Created",
                table: "Newsletters");

            migrationBuilder.DropColumn(
                name: "Ip",
                table: "Newsletters");

        }
    }
}
