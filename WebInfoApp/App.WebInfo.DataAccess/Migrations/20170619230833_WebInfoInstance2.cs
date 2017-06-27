using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace App.WebInfo.DataAccess.Migrations
{
    public partial class WebInfoInstance2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Beden",
                table: "Personal");

            migrationBuilder.DropColumn(
                name: "Cinsiyet",
                table: "Personal");

            migrationBuilder.DropColumn(
                name: "Dini",
                table: "Personal");

            migrationBuilder.DropColumn(
                name: "DogumYeri",
                table: "Personal");

            migrationBuilder.DropColumn(
                name: "Durumu",
                table: "Personal");

            migrationBuilder.DropColumn(
                name: "EgitimDurumu",
                table: "Personal");

            migrationBuilder.DropColumn(
                name: "EtnikKoken",
                table: "Personal");

            migrationBuilder.DropColumn(
                name: "IslemiYapan",
                table: "Personal");

            migrationBuilder.DropColumn(
                name: "Kacak",
                table: "Personal");

            migrationBuilder.DropColumn(
                name: "KampBolgesi",
                table: "Personal");

            migrationBuilder.DropColumn(
                name: "KampIli",
                table: "Personal");

            migrationBuilder.DropColumn(
                name: "KanGrubu",
                table: "Personal");

            migrationBuilder.DropColumn(
                name: "KayitliOlduguIl",
                table: "Personal");

            migrationBuilder.DropColumn(
                name: "KayitliOlduguIlce",
                table: "Personal");

            migrationBuilder.DropColumn(
                name: "MedeniDurumu",
                table: "Personal");

            migrationBuilder.DropColumn(
                name: "SaglikDurumu",
                table: "Personal");

            migrationBuilder.DropColumn(
                name: "Uygurugu",
                table: "Personal");

            migrationBuilder.RenameColumn(
                name: "SosyalYardimDurumu",
                table: "Personal",
                newName: "Sinif");

            migrationBuilder.RenameColumn(
                name: "No",
                table: "Personal",
                newName: "KapiNo");

            migrationBuilder.AlterColumn<string>(
                name: "Telefon",
                table: "Personal",
                maxLength: 15,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 30,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Mezhep",
                table: "Personal",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Meslegi",
                table: "Personal",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "KonteynerNo",
                table: "Personal",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "KayitTarihi",
                table: "Personal",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "KampMahallesi",
                table: "Personal",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "KampAdi",
                table: "Personal",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AyakkabiNo",
                table: "Personal",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AileNo",
                table: "Personal",
                maxLength: 6,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AdliIslemDurumu",
                table: "Personal",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Bedeni",
                table: "Personal",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CinsiyetCinsiyeId",
                table: "Personal",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DinId",
                table: "Personal",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DogumYeriId",
                table: "Personal",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EgitimDurumuId",
                table: "Personal",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IkametDurumuId",
                table: "Personal",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IlId",
                table: "Personal",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IlceId",
                table: "Personal",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IslemYapanId",
                table: "Personal",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "KampBolgesiIlceId",
                table: "Personal",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "KampIlIlId",
                table: "Personal",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "KanGrubuId",
                table: "Personal",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "KayitDurumuId",
                table: "Personal",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "KokenId",
                table: "Personal",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MedeniDurumuId",
                table: "Personal",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Okul",
                table: "Personal",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SaglikDurumuAciklama",
                table: "Personal",
                maxLength: 500,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SaglikDurumuId",
                table: "Personal",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SahisNo",
                table: "Personal",
                maxLength: 6,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SosyalYardimAciklama",
                table: "Personal",
                maxLength: 500,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SosyalYardimDurumuId",
                table: "Personal",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UyrukId",
                table: "Personal",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Cinsiyet",
                columns: table => new
                {
                    CinsiyeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CinsiyetName = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cinsiyet", x => x.CinsiyeId);
                });

            migrationBuilder.CreateTable(
                name: "Din",
                columns: table => new
                {
                    DinId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DinName = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Din", x => x.DinId);
                });

            migrationBuilder.CreateTable(
                name: "DogumYeri",
                columns: table => new
                {
                    DogumYeriId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DogumYeriName = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DogumYeri", x => x.DogumYeriId);
                });

            migrationBuilder.CreateTable(
                name: "EgitimDurumu",
                columns: table => new
                {
                    EgitimDurumuId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EgitimDurumuName = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EgitimDurumu", x => x.EgitimDurumuId);
                });

            migrationBuilder.CreateTable(
                name: "IkametDurumu",
                columns: table => new
                {
                    IkametDurumuId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IkametDurumuName = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IkametDurumu", x => x.IkametDurumuId);
                });

            migrationBuilder.CreateTable(
                name: "Il",
                columns: table => new
                {
                    IlId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IlName = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Il", x => x.IlId);
                });

            migrationBuilder.CreateTable(
                name: "IslemYapan",
                columns: table => new
                {
                    IslemYapanId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IslemYapanName = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IslemYapan", x => x.IslemYapanId);
                });

            migrationBuilder.CreateTable(
                name: "KanGrubu",
                columns: table => new
                {
                    KanGrubuId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    KanGrubuName = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KanGrubu", x => x.KanGrubuId);
                });

            migrationBuilder.CreateTable(
                name: "KayitDurumu",
                columns: table => new
                {
                    KayitDurumuId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    KayitDurumuName = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KayitDurumu", x => x.KayitDurumuId);
                });

            migrationBuilder.CreateTable(
                name: "Koken",
                columns: table => new
                {
                    KokenId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    KokenName = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Koken", x => x.KokenId);
                });

            migrationBuilder.CreateTable(
                name: "MedeniDurumu",
                columns: table => new
                {
                    MedeniDurumuId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MedeniDurumuName = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedeniDurumu", x => x.MedeniDurumuId);
                });

            migrationBuilder.CreateTable(
                name: "SaglikDurumu",
                columns: table => new
                {
                    SaglikDurumuId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SaglikDurumuName = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SaglikDurumu", x => x.SaglikDurumuId);
                });

            migrationBuilder.CreateTable(
                name: "SosyalYardimDurumu",
                columns: table => new
                {
                    SosyalYardimDurumuId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SosyalYardimDurumuName = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SosyalYardimDurumu", x => x.SosyalYardimDurumuId);
                });

            migrationBuilder.CreateTable(
                name: "Uyruk",
                columns: table => new
                {
                    UyrukId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UyrukName = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uyruk", x => x.UyrukId);
                });

            migrationBuilder.CreateTable(
                name: "Ilce",
                columns: table => new
                {
                    IlceId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IlId = table.Column<int>(nullable: true),
                    IlceName = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ilce", x => x.IlceId);
                    table.ForeignKey(
                        name: "FK_Ilce_Il_IlId",
                        column: x => x.IlId,
                        principalTable: "Il",
                        principalColumn: "IlId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Personal_CinsiyetCinsiyeId",
                table: "Personal",
                column: "CinsiyetCinsiyeId");

            migrationBuilder.CreateIndex(
                name: "IX_Personal_DinId",
                table: "Personal",
                column: "DinId");

            migrationBuilder.CreateIndex(
                name: "IX_Personal_DogumYeriId",
                table: "Personal",
                column: "DogumYeriId");

            migrationBuilder.CreateIndex(
                name: "IX_Personal_EgitimDurumuId",
                table: "Personal",
                column: "EgitimDurumuId");

            migrationBuilder.CreateIndex(
                name: "IX_Personal_IkametDurumuId",
                table: "Personal",
                column: "IkametDurumuId");

            migrationBuilder.CreateIndex(
                name: "IX_Personal_IlId",
                table: "Personal",
                column: "IlId");

            migrationBuilder.CreateIndex(
                name: "IX_Personal_IlceId",
                table: "Personal",
                column: "IlceId");

            migrationBuilder.CreateIndex(
                name: "IX_Personal_IslemYapanId",
                table: "Personal",
                column: "IslemYapanId");

            migrationBuilder.CreateIndex(
                name: "IX_Personal_KampBolgesiIlceId",
                table: "Personal",
                column: "KampBolgesiIlceId");

            migrationBuilder.CreateIndex(
                name: "IX_Personal_KampIlIlId",
                table: "Personal",
                column: "KampIlIlId");

            migrationBuilder.CreateIndex(
                name: "IX_Personal_KanGrubuId",
                table: "Personal",
                column: "KanGrubuId");

            migrationBuilder.CreateIndex(
                name: "IX_Personal_KayitDurumuId",
                table: "Personal",
                column: "KayitDurumuId");

            migrationBuilder.CreateIndex(
                name: "IX_Personal_KokenId",
                table: "Personal",
                column: "KokenId");

            migrationBuilder.CreateIndex(
                name: "IX_Personal_MedeniDurumuId",
                table: "Personal",
                column: "MedeniDurumuId");

            migrationBuilder.CreateIndex(
                name: "IX_Personal_SaglikDurumuId",
                table: "Personal",
                column: "SaglikDurumuId");

            migrationBuilder.CreateIndex(
                name: "IX_Personal_SosyalYardimDurumuId",
                table: "Personal",
                column: "SosyalYardimDurumuId");

            migrationBuilder.CreateIndex(
                name: "IX_Personal_UyrukId",
                table: "Personal",
                column: "UyrukId");

            migrationBuilder.CreateIndex(
                name: "IX_Ilce_IlId",
                table: "Ilce",
                column: "IlId");

            migrationBuilder.AddForeignKey(
                name: "FK_Personal_Cinsiyet_CinsiyetCinsiyeId",
                table: "Personal",
                column: "CinsiyetCinsiyeId",
                principalTable: "Cinsiyet",
                principalColumn: "CinsiyeId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Personal_Din_DinId",
                table: "Personal",
                column: "DinId",
                principalTable: "Din",
                principalColumn: "DinId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Personal_DogumYeri_DogumYeriId",
                table: "Personal",
                column: "DogumYeriId",
                principalTable: "DogumYeri",
                principalColumn: "DogumYeriId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Personal_EgitimDurumu_EgitimDurumuId",
                table: "Personal",
                column: "EgitimDurumuId",
                principalTable: "EgitimDurumu",
                principalColumn: "EgitimDurumuId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Personal_IkametDurumu_IkametDurumuId",
                table: "Personal",
                column: "IkametDurumuId",
                principalTable: "IkametDurumu",
                principalColumn: "IkametDurumuId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Personal_Il_IlId",
                table: "Personal",
                column: "IlId",
                principalTable: "Il",
                principalColumn: "IlId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Personal_Ilce_IlceId",
                table: "Personal",
                column: "IlceId",
                principalTable: "Ilce",
                principalColumn: "IlceId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Personal_IslemYapan_IslemYapanId",
                table: "Personal",
                column: "IslemYapanId",
                principalTable: "IslemYapan",
                principalColumn: "IslemYapanId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Personal_Ilce_KampBolgesiIlceId",
                table: "Personal",
                column: "KampBolgesiIlceId",
                principalTable: "Ilce",
                principalColumn: "IlceId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Personal_Il_KampIlIlId",
                table: "Personal",
                column: "KampIlIlId",
                principalTable: "Il",
                principalColumn: "IlId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Personal_KanGrubu_KanGrubuId",
                table: "Personal",
                column: "KanGrubuId",
                principalTable: "KanGrubu",
                principalColumn: "KanGrubuId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Personal_KayitDurumu_KayitDurumuId",
                table: "Personal",
                column: "KayitDurumuId",
                principalTable: "KayitDurumu",
                principalColumn: "KayitDurumuId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Personal_Koken_KokenId",
                table: "Personal",
                column: "KokenId",
                principalTable: "Koken",
                principalColumn: "KokenId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Personal_MedeniDurumu_MedeniDurumuId",
                table: "Personal",
                column: "MedeniDurumuId",
                principalTable: "MedeniDurumu",
                principalColumn: "MedeniDurumuId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Personal_SaglikDurumu_SaglikDurumuId",
                table: "Personal",
                column: "SaglikDurumuId",
                principalTable: "SaglikDurumu",
                principalColumn: "SaglikDurumuId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Personal_SosyalYardimDurumu_SosyalYardimDurumuId",
                table: "Personal",
                column: "SosyalYardimDurumuId",
                principalTable: "SosyalYardimDurumu",
                principalColumn: "SosyalYardimDurumuId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Personal_Uyruk_UyrukId",
                table: "Personal",
                column: "UyrukId",
                principalTable: "Uyruk",
                principalColumn: "UyrukId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Personal_Cinsiyet_CinsiyetCinsiyeId",
                table: "Personal");

            migrationBuilder.DropForeignKey(
                name: "FK_Personal_Din_DinId",
                table: "Personal");

            migrationBuilder.DropForeignKey(
                name: "FK_Personal_DogumYeri_DogumYeriId",
                table: "Personal");

            migrationBuilder.DropForeignKey(
                name: "FK_Personal_EgitimDurumu_EgitimDurumuId",
                table: "Personal");

            migrationBuilder.DropForeignKey(
                name: "FK_Personal_IkametDurumu_IkametDurumuId",
                table: "Personal");

            migrationBuilder.DropForeignKey(
                name: "FK_Personal_Il_IlId",
                table: "Personal");

            migrationBuilder.DropForeignKey(
                name: "FK_Personal_Ilce_IlceId",
                table: "Personal");

            migrationBuilder.DropForeignKey(
                name: "FK_Personal_IslemYapan_IslemYapanId",
                table: "Personal");

            migrationBuilder.DropForeignKey(
                name: "FK_Personal_Ilce_KampBolgesiIlceId",
                table: "Personal");

            migrationBuilder.DropForeignKey(
                name: "FK_Personal_Il_KampIlIlId",
                table: "Personal");

            migrationBuilder.DropForeignKey(
                name: "FK_Personal_KanGrubu_KanGrubuId",
                table: "Personal");

            migrationBuilder.DropForeignKey(
                name: "FK_Personal_KayitDurumu_KayitDurumuId",
                table: "Personal");

            migrationBuilder.DropForeignKey(
                name: "FK_Personal_Koken_KokenId",
                table: "Personal");

            migrationBuilder.DropForeignKey(
                name: "FK_Personal_MedeniDurumu_MedeniDurumuId",
                table: "Personal");

            migrationBuilder.DropForeignKey(
                name: "FK_Personal_SaglikDurumu_SaglikDurumuId",
                table: "Personal");

            migrationBuilder.DropForeignKey(
                name: "FK_Personal_SosyalYardimDurumu_SosyalYardimDurumuId",
                table: "Personal");

            migrationBuilder.DropForeignKey(
                name: "FK_Personal_Uyruk_UyrukId",
                table: "Personal");

            migrationBuilder.DropTable(
                name: "Cinsiyet");

            migrationBuilder.DropTable(
                name: "Din");

            migrationBuilder.DropTable(
                name: "DogumYeri");

            migrationBuilder.DropTable(
                name: "EgitimDurumu");

            migrationBuilder.DropTable(
                name: "IkametDurumu");

            migrationBuilder.DropTable(
                name: "Ilce");

            migrationBuilder.DropTable(
                name: "IslemYapan");

            migrationBuilder.DropTable(
                name: "KanGrubu");

            migrationBuilder.DropTable(
                name: "KayitDurumu");

            migrationBuilder.DropTable(
                name: "Koken");

            migrationBuilder.DropTable(
                name: "MedeniDurumu");

            migrationBuilder.DropTable(
                name: "SaglikDurumu");

            migrationBuilder.DropTable(
                name: "SosyalYardimDurumu");

            migrationBuilder.DropTable(
                name: "Uyruk");

            migrationBuilder.DropTable(
                name: "Il");

            migrationBuilder.DropIndex(
                name: "IX_Personal_CinsiyetCinsiyeId",
                table: "Personal");

            migrationBuilder.DropIndex(
                name: "IX_Personal_DinId",
                table: "Personal");

            migrationBuilder.DropIndex(
                name: "IX_Personal_DogumYeriId",
                table: "Personal");

            migrationBuilder.DropIndex(
                name: "IX_Personal_EgitimDurumuId",
                table: "Personal");

            migrationBuilder.DropIndex(
                name: "IX_Personal_IkametDurumuId",
                table: "Personal");

            migrationBuilder.DropIndex(
                name: "IX_Personal_IlId",
                table: "Personal");

            migrationBuilder.DropIndex(
                name: "IX_Personal_IlceId",
                table: "Personal");

            migrationBuilder.DropIndex(
                name: "IX_Personal_IslemYapanId",
                table: "Personal");

            migrationBuilder.DropIndex(
                name: "IX_Personal_KampBolgesiIlceId",
                table: "Personal");

            migrationBuilder.DropIndex(
                name: "IX_Personal_KampIlIlId",
                table: "Personal");

            migrationBuilder.DropIndex(
                name: "IX_Personal_KanGrubuId",
                table: "Personal");

            migrationBuilder.DropIndex(
                name: "IX_Personal_KayitDurumuId",
                table: "Personal");

            migrationBuilder.DropIndex(
                name: "IX_Personal_KokenId",
                table: "Personal");

            migrationBuilder.DropIndex(
                name: "IX_Personal_MedeniDurumuId",
                table: "Personal");

            migrationBuilder.DropIndex(
                name: "IX_Personal_SaglikDurumuId",
                table: "Personal");

            migrationBuilder.DropIndex(
                name: "IX_Personal_SosyalYardimDurumuId",
                table: "Personal");

            migrationBuilder.DropIndex(
                name: "IX_Personal_UyrukId",
                table: "Personal");

            migrationBuilder.DropColumn(
                name: "Bedeni",
                table: "Personal");

            migrationBuilder.DropColumn(
                name: "CinsiyetCinsiyeId",
                table: "Personal");

            migrationBuilder.DropColumn(
                name: "DinId",
                table: "Personal");

            migrationBuilder.DropColumn(
                name: "DogumYeriId",
                table: "Personal");

            migrationBuilder.DropColumn(
                name: "EgitimDurumuId",
                table: "Personal");

            migrationBuilder.DropColumn(
                name: "IkametDurumuId",
                table: "Personal");

            migrationBuilder.DropColumn(
                name: "IlId",
                table: "Personal");

            migrationBuilder.DropColumn(
                name: "IlceId",
                table: "Personal");

            migrationBuilder.DropColumn(
                name: "IslemYapanId",
                table: "Personal");

            migrationBuilder.DropColumn(
                name: "KampBolgesiIlceId",
                table: "Personal");

            migrationBuilder.DropColumn(
                name: "KampIlIlId",
                table: "Personal");

            migrationBuilder.DropColumn(
                name: "KanGrubuId",
                table: "Personal");

            migrationBuilder.DropColumn(
                name: "KayitDurumuId",
                table: "Personal");

            migrationBuilder.DropColumn(
                name: "KokenId",
                table: "Personal");

            migrationBuilder.DropColumn(
                name: "MedeniDurumuId",
                table: "Personal");

            migrationBuilder.DropColumn(
                name: "Okul",
                table: "Personal");

            migrationBuilder.DropColumn(
                name: "SaglikDurumuAciklama",
                table: "Personal");

            migrationBuilder.DropColumn(
                name: "SaglikDurumuId",
                table: "Personal");

            migrationBuilder.DropColumn(
                name: "SahisNo",
                table: "Personal");

            migrationBuilder.DropColumn(
                name: "SosyalYardimAciklama",
                table: "Personal");

            migrationBuilder.DropColumn(
                name: "SosyalYardimDurumuId",
                table: "Personal");

            migrationBuilder.DropColumn(
                name: "UyrukId",
                table: "Personal");

            migrationBuilder.RenameColumn(
                name: "Sinif",
                table: "Personal",
                newName: "SosyalYardimDurumu");

            migrationBuilder.RenameColumn(
                name: "KapiNo",
                table: "Personal",
                newName: "No");

            migrationBuilder.AlterColumn<string>(
                name: "Telefon",
                table: "Personal",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 15,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Mezhep",
                table: "Personal",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Meslegi",
                table: "Personal",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "KonteynerNo",
                table: "Personal",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "KayitTarihi",
                table: "Personal",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "KampMahallesi",
                table: "Personal",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "KampAdi",
                table: "Personal",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AyakkabiNo",
                table: "Personal",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "AileNo",
                table: "Personal",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 6);

            migrationBuilder.AlterColumn<string>(
                name: "AdliIslemDurumu",
                table: "Personal",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Beden",
                table: "Personal",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Cinsiyet",
                table: "Personal",
                maxLength: 10,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Dini",
                table: "Personal",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DogumYeri",
                table: "Personal",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Durumu",
                table: "Personal",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EgitimDurumu",
                table: "Personal",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EtnikKoken",
                table: "Personal",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IslemiYapan",
                table: "Personal",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Kacak",
                table: "Personal",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "KampBolgesi",
                table: "Personal",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "KampIli",
                table: "Personal",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "KanGrubu",
                table: "Personal",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "KayitliOlduguIl",
                table: "Personal",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "KayitliOlduguIlce",
                table: "Personal",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MedeniDurumu",
                table: "Personal",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SaglikDurumu",
                table: "Personal",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Uygurugu",
                table: "Personal",
                nullable: true);
        }
    }
}
