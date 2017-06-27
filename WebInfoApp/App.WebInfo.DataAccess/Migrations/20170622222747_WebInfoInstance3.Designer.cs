using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using App.WebInfo.DataAccess.Concrete.EntityFramework;
using App.WebInfo.Entities.Concrete;

namespace App.WebInfo.DataAccess.Migrations
{
    [DbContext(typeof(WebInfoContext))]
    [Migration("20170622222747_WebInfoInstance3")]
    partial class WebInfoInstance3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("App.WebInfo.Entities.Concrete.Cinsiyet", b =>
                {
                    b.Property<int>("CinsiyeId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CinsiyetName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("CinsiyeId");

                    b.ToTable("Cinsiyet");
                });

            modelBuilder.Entity("App.WebInfo.Entities.Concrete.Din", b =>
                {
                    b.Property<int>("DinId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DinName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("DinId");

                    b.ToTable("Din");
                });

            modelBuilder.Entity("App.WebInfo.Entities.Concrete.DogumYeri", b =>
                {
                    b.Property<int>("DogumYeriId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DogumYeriName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("DogumYeriId");

                    b.ToTable("DogumYeri");
                });

            modelBuilder.Entity("App.WebInfo.Entities.Concrete.EgitimDurumu", b =>
                {
                    b.Property<int>("EgitimDurumuId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("EgitimDurumuName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("EgitimDurumuId");

                    b.ToTable("EgitimDurumu");
                });

            modelBuilder.Entity("App.WebInfo.Entities.Concrete.IkametDurumu", b =>
                {
                    b.Property<int>("IkametDurumuId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("IkametDurumuName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("IkametDurumuId");

                    b.ToTable("IkametDurumu");
                });

            modelBuilder.Entity("App.WebInfo.Entities.Concrete.Il", b =>
                {
                    b.Property<int>("IlId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("IlName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("IlId");

                    b.ToTable("Il");
                });

            modelBuilder.Entity("App.WebInfo.Entities.Concrete.Ilce", b =>
                {
                    b.Property<int>("IlceId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("IlId");

                    b.Property<string>("IlceName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("IlceId");

                    b.HasIndex("IlId");

                    b.ToTable("Ilce");
                });

            modelBuilder.Entity("App.WebInfo.Entities.Concrete.IslemYapan", b =>
                {
                    b.Property<int>("IslemYapanId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("IslemYapanName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("IslemYapanId");

                    b.ToTable("IslemYapan");
                });

            modelBuilder.Entity("App.WebInfo.Entities.Concrete.KanGrubu", b =>
                {
                    b.Property<int>("KanGrubuId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("KanGrubuName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("KanGrubuId");

                    b.ToTable("KanGrubu");
                });

            modelBuilder.Entity("App.WebInfo.Entities.Concrete.KayitDurumu", b =>
                {
                    b.Property<int>("KayitDurumuId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("KayitDurumuName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("KayitDurumuId");

                    b.ToTable("KayitDurumu");
                });

            modelBuilder.Entity("App.WebInfo.Entities.Concrete.Koken", b =>
                {
                    b.Property<int>("KokenId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("KokenName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("KokenId");

                    b.ToTable("Koken");
                });

            modelBuilder.Entity("App.WebInfo.Entities.Concrete.MedeniDurumu", b =>
                {
                    b.Property<int>("MedeniDurumuId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("MedeniDurumuName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("MedeniDurumuId");

                    b.ToTable("MedeniDurumu");
                });

            modelBuilder.Entity("App.WebInfo.Entities.Concrete.Menu", b =>
                {
                    b.Property<long>("MenuId")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("IsActive");

                    b.Property<int>("MenuIcon");

                    b.Property<long?>("MenuId1");

                    b.Property<string>("MenuName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("MenuUrl")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<int>("Order");

                    b.Property<long>("ParentId");

                    b.Property<string>("UserType");

                    b.HasKey("MenuId");

                    b.HasIndex("MenuId1");

                    b.ToTable("Menu");
                });

            modelBuilder.Entity("App.WebInfo.Entities.Concrete.Personal", b =>
                {
                    b.Property<long>("PersonalId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Adi")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("AdliIslemDurumu")
                        .HasMaxLength(500);

                    b.Property<string>("AileNo")
                        .IsRequired()
                        .HasMaxLength(6);

                    b.Property<string>("AnaAdi")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<int>("AyakkabiNo");

                    b.Property<string>("BabaAdi")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<int>("Bedeni");

                    b.Property<int?>("CinsiyetCinsiyeId");

                    b.Property<long?>("CreatedBy");

                    b.Property<DateTime>("CreationDate");

                    b.Property<int?>("DinId");

                    b.Property<string>("DogumTarihi")
                        .HasMaxLength(20);

                    b.Property<int?>("DogumYeriId");

                    b.Property<int?>("EgitimDurumuId");

                    b.Property<int?>("IkametDurumuId");

                    b.Property<int?>("IlId");

                    b.Property<int?>("IlceId");

                    b.Property<bool>("IsDelete");

                    b.Property<bool>("IsState");

                    b.Property<int?>("IslemYapanId");

                    b.Property<string>("KampAdi")
                        .HasMaxLength(200);

                    b.Property<int?>("KampBolgesiIlceId");

                    b.Property<int?>("KampIlIlId");

                    b.Property<string>("KampMahallesi")
                        .HasMaxLength(200);

                    b.Property<int?>("KanGrubuId");

                    b.Property<string>("KapiNo")
                        .HasMaxLength(100);

                    b.Property<int?>("KayitDurumuId");

                    b.Property<string>("KayitTarihi")
                        .HasMaxLength(50);

                    b.Property<string>("KayitTipi");

                    b.Property<int?>("KokenId");

                    b.Property<string>("KonteynerNo")
                        .HasMaxLength(200);

                    b.Property<long?>("LastModified");

                    b.Property<DateTime?>("LastModifiedDate");

                    b.Property<string>("Mahalle")
                        .HasMaxLength(500);

                    b.Property<int?>("MedeniDurumuId");

                    b.Property<string>("Meslegi")
                        .HasMaxLength(200);

                    b.Property<string>("Mezhep")
                        .HasMaxLength(100);

                    b.Property<string>("Okul")
                        .HasMaxLength(200);

                    b.Property<string>("SaglikDurumuAciklama")
                        .HasMaxLength(500);

                    b.Property<int?>("SaglikDurumuId");

                    b.Property<string>("SahisNo")
                        .IsRequired()
                        .HasMaxLength(6);

                    b.Property<string>("Sinif")
                        .HasMaxLength(100);

                    b.Property<string>("Sokak")
                        .HasMaxLength(200);

                    b.Property<string>("SosyalYardimAciklama")
                        .HasMaxLength(500);

                    b.Property<int?>("SosyalYardimDurumuId");

                    b.Property<string>("Soyadi")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Telefon")
                        .HasMaxLength(15);

                    b.Property<int?>("UyrukId");

                    b.HasKey("PersonalId");

                    b.HasIndex("CinsiyetCinsiyeId");

                    b.HasIndex("DinId");

                    b.HasIndex("DogumYeriId");

                    b.HasIndex("EgitimDurumuId");

                    b.HasIndex("IkametDurumuId");

                    b.HasIndex("IlId");

                    b.HasIndex("IlceId");

                    b.HasIndex("IslemYapanId");

                    b.HasIndex("KampBolgesiIlceId");

                    b.HasIndex("KampIlIlId");

                    b.HasIndex("KanGrubuId");

                    b.HasIndex("KayitDurumuId");

                    b.HasIndex("KokenId");

                    b.HasIndex("MedeniDurumuId");

                    b.HasIndex("SaglikDurumuId");

                    b.HasIndex("SosyalYardimDurumuId");

                    b.HasIndex("UyrukId");

                    b.ToTable("Personal");
                });

            modelBuilder.Entity("App.WebInfo.Entities.Concrete.SaglikDurumu", b =>
                {
                    b.Property<int>("SaglikDurumuId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("SaglikDurumuName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("SaglikDurumuId");

                    b.ToTable("SaglikDurumu");
                });

            modelBuilder.Entity("App.WebInfo.Entities.Concrete.SosyalYardimDurumu", b =>
                {
                    b.Property<int>("SosyalYardimDurumuId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("SosyalYardimDurumuName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("SosyalYardimDurumuId");

                    b.ToTable("SosyalYardimDurumu");
                });

            modelBuilder.Entity("App.WebInfo.Entities.Concrete.Uyruk", b =>
                {
                    b.Property<int>("UyrukId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("UyrukName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("UyrukId");

                    b.ToTable("Uyruk");
                });

            modelBuilder.Entity("App.WebInfo.Entities.Concrete.Ilce", b =>
                {
                    b.HasOne("App.WebInfo.Entities.Concrete.Il", "Il")
                        .WithMany("Ilceler")
                        .HasForeignKey("IlId");
                });

            modelBuilder.Entity("App.WebInfo.Entities.Concrete.Menu", b =>
                {
                    b.HasOne("App.WebInfo.Entities.Concrete.Menu")
                        .WithMany("SubMenu")
                        .HasForeignKey("MenuId1");
                });

            modelBuilder.Entity("App.WebInfo.Entities.Concrete.Personal", b =>
                {
                    b.HasOne("App.WebInfo.Entities.Concrete.Cinsiyet", "Cinsiyet")
                        .WithMany()
                        .HasForeignKey("CinsiyetCinsiyeId");

                    b.HasOne("App.WebInfo.Entities.Concrete.Din", "Din")
                        .WithMany()
                        .HasForeignKey("DinId");

                    b.HasOne("App.WebInfo.Entities.Concrete.DogumYeri", "DogumYeri")
                        .WithMany()
                        .HasForeignKey("DogumYeriId");

                    b.HasOne("App.WebInfo.Entities.Concrete.EgitimDurumu", "EgitimDurumu")
                        .WithMany()
                        .HasForeignKey("EgitimDurumuId");

                    b.HasOne("App.WebInfo.Entities.Concrete.IkametDurumu", "IkametDurumu")
                        .WithMany()
                        .HasForeignKey("IkametDurumuId");

                    b.HasOne("App.WebInfo.Entities.Concrete.Il", "Il")
                        .WithMany()
                        .HasForeignKey("IlId");

                    b.HasOne("App.WebInfo.Entities.Concrete.Ilce", "Ilce")
                        .WithMany()
                        .HasForeignKey("IlceId");

                    b.HasOne("App.WebInfo.Entities.Concrete.IslemYapan", "IslemYapan")
                        .WithMany()
                        .HasForeignKey("IslemYapanId");

                    b.HasOne("App.WebInfo.Entities.Concrete.Ilce", "KampBolgesi")
                        .WithMany()
                        .HasForeignKey("KampBolgesiIlceId");

                    b.HasOne("App.WebInfo.Entities.Concrete.Il", "KampIl")
                        .WithMany()
                        .HasForeignKey("KampIlIlId");

                    b.HasOne("App.WebInfo.Entities.Concrete.KanGrubu", "KanGrubu")
                        .WithMany()
                        .HasForeignKey("KanGrubuId");

                    b.HasOne("App.WebInfo.Entities.Concrete.KayitDurumu", "KayitDurumu")
                        .WithMany()
                        .HasForeignKey("KayitDurumuId");

                    b.HasOne("App.WebInfo.Entities.Concrete.Koken", "Koken")
                        .WithMany()
                        .HasForeignKey("KokenId");

                    b.HasOne("App.WebInfo.Entities.Concrete.MedeniDurumu", "MedeniDurumu")
                        .WithMany()
                        .HasForeignKey("MedeniDurumuId");

                    b.HasOne("App.WebInfo.Entities.Concrete.SaglikDurumu", "SaglikDurumu")
                        .WithMany()
                        .HasForeignKey("SaglikDurumuId");

                    b.HasOne("App.WebInfo.Entities.Concrete.SosyalYardimDurumu", "SosyalYardimDurumu")
                        .WithMany()
                        .HasForeignKey("SosyalYardimDurumuId");

                    b.HasOne("App.WebInfo.Entities.Concrete.Uyruk", "Uyruk")
                        .WithMany()
                        .HasForeignKey("UyrukId");
                });
        }
    }
}
