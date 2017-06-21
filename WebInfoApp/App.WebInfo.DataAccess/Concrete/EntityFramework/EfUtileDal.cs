using System;
using App.WebInfo.DataAccess.Abstract;
using App.WebInfo.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace App.WebInfo.DataAccess.Concrete.EntityFramework
{
    public class EfUtileDal : IUtileDal
    {
        public async Task<List<Cinsiyet>> GetCinsiyets()
        {
            using (var context = new WebInfoContext())
            {
                return await context.Cinsiyet.ToListAsync();
            }
        }

        public async Task<List<Din>> GetDins()
        {
            using (var context = new WebInfoContext())
            {
                return await context.Din.ToListAsync();
            }
        }

        public async Task<List<DogumYeri>> GetDogumYeris()
        {
            using (var context = new WebInfoContext())
            {
                return await context.DogumYeri.ToListAsync();
            }
        }

        public async Task<List<EgitimDurumu>> GetEgitimDurumus()
        {
            using (var context = new WebInfoContext())
            {
                return await context.EgitimDurumu.ToListAsync();
            }
        }

        public async Task<List<IkametDurumu>> GetIkametDurumus()
        {
            using (var context = new WebInfoContext())
            {
                return await context.IkametDurumu.ToListAsync();
            }
        }

        public async Task<List<Il>> GetIls()
        {
            using (var context = new WebInfoContext())
            {
                return await context.Il.ToListAsync();
            }
        }

        public async Task<List<Ilce>> GetIlces()
        {
            using (var context = new WebInfoContext())
            {
                return await context.Ilce.ToListAsync();
            }
        }

        public async Task<List<IslemYapan>> GetIslemYapans()
        {
            using (var context = new WebInfoContext())
            {
                return await context.IslemYapan.ToListAsync();
            }
        }

        public async Task<List<KanGrubu>> GetKanGrubus()
        {
            using (var context = new WebInfoContext())
            {
                return await context.KanGrubu.ToListAsync();
            }
        }

        public async Task<List<Uyruk>> GetUyruks()
        {
            using (var context = new WebInfoContext())
            {
                return await context.Uyruk.ToListAsync();
            }
        }
    }
}
