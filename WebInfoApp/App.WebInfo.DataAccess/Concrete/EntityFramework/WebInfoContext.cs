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
    }
}
