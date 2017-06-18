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
    partial class WebInfoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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
                        .HasMaxLength(100);

                    b.Property<string>("AileNo")
                        .HasMaxLength(10);

                    b.Property<string>("AnaAdi")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("AyakkabiNo");

                    b.Property<string>("BabaAdi")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Beden");

                    b.Property<string>("Cinsiyet")
                        .HasMaxLength(10);

                    b.Property<string>("Dini");

                    b.Property<string>("DogumTarihi")
                        .HasMaxLength(20);

                    b.Property<string>("DogumYeri")
                        .HasMaxLength(100);

                    b.Property<string>("Durumu");

                    b.Property<string>("EgitimDurumu");

                    b.Property<string>("EtnikKoken");

                    b.Property<string>("IslemiYapan")
                        .HasMaxLength(100);

                    b.Property<string>("Kacak")
                        .HasMaxLength(100);

                    b.Property<string>("KampAdi");

                    b.Property<string>("KampBolgesi");

                    b.Property<string>("KampIli");

                    b.Property<string>("KampMahallesi");

                    b.Property<string>("KanGrubu");

                    b.Property<string>("KayitTarihi");

                    b.Property<string>("KayitTipi");

                    b.Property<string>("KayitliOlduguIl")
                        .HasMaxLength(100);

                    b.Property<string>("KayitliOlduguIlce")
                        .HasMaxLength(100);

                    b.Property<string>("KonteynerNo");

                    b.Property<string>("Mahalle")
                        .HasMaxLength(500);

                    b.Property<string>("MedeniDurumu")
                        .HasMaxLength(100);

                    b.Property<string>("Meslegi");

                    b.Property<string>("Mezhep");

                    b.Property<string>("No")
                        .HasMaxLength(100);

                    b.Property<string>("SaglikDurumu");

                    b.Property<string>("Sokak")
                        .HasMaxLength(200);

                    b.Property<string>("SosyalYardimDurumu")
                        .HasMaxLength(100);

                    b.Property<string>("Soyadi")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Telefon")
                        .HasMaxLength(30);

                    b.Property<string>("Uygurugu");

                    b.HasKey("PersonalId");

                    b.ToTable("Personal");
                });

            modelBuilder.Entity("App.WebInfo.Entities.Concrete.Menu", b =>
                {
                    b.HasOne("App.WebInfo.Entities.Concrete.Menu")
                        .WithMany("SubMenu")
                        .HasForeignKey("MenuId1");
                });
        }
    }
}
