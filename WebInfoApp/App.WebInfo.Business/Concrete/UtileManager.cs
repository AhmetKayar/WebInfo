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
            return await _utile.GetList<Cinsiyet>();
        }

        public async Task<List<Din>> GetDins()
        {
            return await _utile.GetList<Din>();

        }

        public async Task<List<DogumYeri>> GetDogumYeris()
        {
            return await _utile.GetList<DogumYeri>();
        }

        public async Task<List<EgitimDurumu>> GetEgitimDurumus()
        {
            return await _utile.GetList<EgitimDurumu>();
        }

        public async Task<List<IkametDurumu>> GetIkametDurumus()
        {
            return await _utile.GetList<IkametDurumu>();
        }

        public async Task<List<Il>> GetIls()
        {
            return await _utile.GetList<Il>();
        }

        public async Task<List<Ilce>> GetIlces()
        {
            return await _utile.GetList<Ilce>();
        }

        public async Task<List<IslemYapan>> GetIslemYapans()
        {
            return await _utile.GetList<IslemYapan>();
        }

        public async Task<List<KanGrubu>> GetKanGrubus()
        {
            return await _utile.GetList<KanGrubu>();
        }

        public async Task<List<Uyruk>> GetUyruks()
        {
            return await _utile.GetList<Uyruk>();
        }

        public async Task<List<SaglikDurumu>> GetSaglikDurumus()
        {
            return await _utile.GetList<SaglikDurumu>();
        }
    }
}
