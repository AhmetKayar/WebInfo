using Microsoft.EntityFrameworkCore;
using App.WebInfo.Entities.Concrete;

namespace App.WebInfo.DataAccess.Concrete.EntityFramework
{
    public class WebInfoContext: DbContext
    {
        public WebInfoContext(DbContextOptions<WebInfoContext> options) : base(options) { }
        public WebInfoContext()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=tcp:boyut.database.windows.net,1433;Initial Catalog=WebInfo;Persist Security Info=False;User ID=webinfo;Password=201408As;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30");
        }

        public DbSet<Personal> Personal { get; set; }
        public DbSet<Menu> Menu { get; set; }
        public DbSet<IkametDurumu> IkametDurumu { get; set; }
        public DbSet<Cinsiyet> Cinsiyet { get; set; }
        public DbSet<Din> Din { get; set; }
        public DbSet<DogumYeri> DogumYeri { get; set; }
        public DbSet<EgitimDurumu> EgitimDurumu { get; set; }
        public DbSet<IslemYapan> IslemYapan { get; set; }
        public DbSet<Il> Il { get; set; }
        public DbSet<Ilce> Ilce { get; set; }
        public DbSet<KanGrubu> KanGrubu { get; set; }
        public DbSet<KayitDurumu> KayitDurumu { get; set; }
        public DbSet<Koken> Koken { get; set; }
        public DbSet<MedeniDurumu> MedeniDurumu { get; set; }
        public DbSet<SaglikDurumu> SaglikDurumu { get; set; }
        public DbSet<SosyalYardimDurumu> SosyalYardimDurumu { get; set; }
        public DbSet<Uyruk> Uyruk { get; set; }
    }
}
