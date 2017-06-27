using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace App.WebInfo.DataAccess.Migrations
{
    public partial class WebInfoInstance3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "CreatedBy",
                table: "Personal",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationDate",
                table: "Personal",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "Personal",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsState",
                table: "Personal",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<long>(
                name: "LastModified",
                table: "Personal",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedDate",
                table: "Personal",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Personal");

            migrationBuilder.DropColumn(
                name: "CreationDate",
                table: "Personal");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "Personal");

            migrationBuilder.DropColumn(
                name: "IsState",
                table: "Personal");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "Personal");

            migrationBuilder.DropColumn(
                name: "LastModifiedDate",
                table: "Personal");
        }
    }
}
