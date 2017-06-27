using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace App.WebInfo.DataAccess.Migrations
{
    public partial class WebInfoInstance : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Menu",
                columns: table => new
                {
                    MenuId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsActive = table.Column<bool>(nullable: false),
                    MenuIcon = table.Column<int>(nullable: false),
                    MenuId1 = table.Column<long>(nullable: true),
                    MenuName = table.Column<string>(maxLength: 100, nullable: false),
                    MenuUrl = table.Column<string>(maxLength: 100, nullable: false),
                    Order = table.Column<int>(nullable: false),
                    ParentId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menu", x => x.MenuId);
                    table.ForeignKey(
                        name: "FK_Menu_Menu_MenuId1",
                        column: x => x.MenuId1,
                        principalTable: "Menu",
                        principalColumn: "MenuId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Personal",
                columns: table => new
                {
                    PersonalId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Adi = table.Column<string>(nullable: true),
                    AdliIslemDurumu = table.Column<string>(nullable: true),
                    AileNo = table.Column<string>(nullable: true),
                    AnaAdi = table.Column<string>(nullable: true),
                    AyakkabiNo = table.Column<string>(nullable: true),
                    BabaAdi = table.Column<string>(nullable: true),
                    Beden = table.Column<string>(nullable: true),
                    Cinsiyet = table.Column<string>(nullable: true),
                    Dini = table.Column<string>(nullable: true),
                    DogumTarihi = table.Column<string>(nullable: true),
                    DogumYeri = table.Column<string>(nullable: true),
                    Durumu = table.Column<string>(nullable: true),
                    EgitimDurumu = table.Column<string>(nullable: true),
                    EtnikKoken = table.Column<string>(nullable: true),
                    IslemiYapan = table.Column<string>(nullable: true),
                    Kacak = table.Column<string>(nullable: true),
                    KampAdi = table.Column<string>(nullable: true),
                    KampBolgesi = table.Column<string>(nullable: true),
                    KampIli = table.Column<string>(nullable: true),
                    KampMahallesi = table.Column<string>(nullable: true),
                    KanGrubu = table.Column<string>(nullable: true),
                    KayitTarihi = table.Column<string>(nullable: true),
                    KayitTipi = table.Column<string>(nullable: true),
                    KayitliOlduguIl = table.Column<string>(nullable: true),
                    KayitliOlduguIlce = table.Column<string>(nullable: true),
                    KonteynerNo = table.Column<string>(nullable: true),
                    Mahalle = table.Column<string>(nullable: true),
                    MedeniDurumu = table.Column<string>(nullable: true),
                    Meslegi = table.Column<string>(nullable: true),
                    Mezhep = table.Column<string>(nullable: true),
                    No = table.Column<string>(nullable: true),
                    SaglikDurumu = table.Column<string>(nullable: true),
                    Sokak = table.Column<string>(nullable: true),
                    SosyalYardimDurumu = table.Column<string>(nullable: true),
                    Soyadi = table.Column<string>(nullable: true),
                    Telefon = table.Column<string>(nullable: true),
                    Uygurugu = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personal", x => x.PersonalId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Menu_MenuId1",
                table: "Menu",
                column: "MenuId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Menu");

            migrationBuilder.DropTable(
                name: "Personal");
        }
    }
}
