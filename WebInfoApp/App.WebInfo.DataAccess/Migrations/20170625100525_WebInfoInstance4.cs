using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace App.WebInfo.DataAccess.Migrations
{
    public partial class WebInfoInstance4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PersonalImage",
                table: "Personal",
                maxLength: 120,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PersonalImage",
                table: "Personal");
        }
    }
}
