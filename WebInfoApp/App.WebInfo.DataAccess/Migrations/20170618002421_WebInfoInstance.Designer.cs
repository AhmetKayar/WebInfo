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
    [Migration("20170618002421_WebInfoInstance")]
    partial class WebInfoInstance
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.HasKey("MenuId");

                    b.HasIndex("MenuId1");

                    b.ToTable("Menu");
                });

            modelBuilder.Entity("App.WebInfo.Entities.Concrete.Personal", b =>
                {
                    b.Property<long>("PersonalId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Adi");

                    b.Property<string>("AdliIslemDurumu");

                    b.Property<string>("AileNo");

                    b.Property<string>("AnaAdi");

                    b.Property<string>("AyakkabiNo");

                    b.Property<string>("BabaAdi");

                    b.Property<string>("Beden");

                    b.Property<string>("Cinsiyet");

                    b.Property<string>("Dini");

                    b.Property<string>("DogumTarihi");

                    b.Property<string>("DogumYeri");

                    b.Property<string>("Durumu");

                    b.Property<string>("EgitimDurumu");

                    b.Property<string>("EtnikKoken");

                    b.Property<string>("IslemiYapan");

                    b.Property<string>("Kacak");

                    b.Property<string>("KampAdi");

                    b.Property<string>("KampBolgesi");

                    b.Property<string>("KampIli");

                    b.Property<string>("KampMahallesi");

                    b.Property<string>("KanGrubu");

                    b.Property<string>("KayitTarihi");

                    b.Property<string>("KayitTipi");

                    b.Property<string>("KayitliOlduguIl");

                    b.Property<string>("KayitliOlduguIlce");

                    b.Property<string>("KonteynerNo");

                    b.Property<string>("Mahalle");

                    b.Property<string>("MedeniDurumu");

                    b.Property<string>("Meslegi");

                    b.Property<string>("Mezhep");

                    b.Property<string>("No");

                    b.Property<string>("SaglikDurumu");

                    b.Property<string>("Sokak");

                    b.Property<string>("SosyalYardimDurumu");

                    b.Property<string>("Soyadi");

                    b.Property<string>("Telefon");

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
