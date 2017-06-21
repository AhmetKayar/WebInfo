using System.Collections.Generic;
using System.Threading.Tasks;
using App.WebInfo.Business.Abstract;
using App.WebInfo.DataAccess.Abstract;
using App.WebInfo.Entities.Concrete;

namespace App.WebInfo.Business.Concrete
{
    public class UtileManager : IUtileService
    {
        private readonly IUtileDal _utile;

        public UtileManager(IUtileDal utile)
        {
            _utile = utile;
        }

        public async Task<List<Cinsiyet>> GetCinsiyets()
        {
            return await _utile.GetCinsiyets();
        }

        public async Task<List<Din>> GetDins()
        {
            return await _utile.GetDins();

        }

        public async Task<List<DogumYeri>> GetDogumYeris()
        {
            return await _utile.GetDogumYeris();
        }

        public async Task<List<EgitimDurumu>> GetEgitimDurumus()
        {
            return await _utile.GetEgitimDurumus();
        }

        public async Task<List<IkametDurumu>> GetIkametDurumus()
        {
            return await _utile.GetIkametDurumus();
        }

        public async Task<List<Il>> GetIls()
        {
            return await _utile.GetIls();
        }

        public async Task<List<Ilce>> GetIlces()
        {
            return await _utile.GetIlces();
        }

        public async Task<List<IslemYapan>> GetIslemYapans()
        {
            return await _utile.GetIslemYapans();
        }

        public async Task<List<KanGrubu>> GetKanGrubus()
        {
            return await _utile.GetKanGrubus();
        }

        public async Task<List<Uyruk>> GetUyruks()
        {
            return await _utile.GetUyruks();
        }
    }
}
