using App.WebInfo.Entities.Concrete;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace App.WebInfo.Business.Abstract
{
    public interface IUtileService
    {
        Task<List<Cinsiyet>> GetCinsiyets();
        Task<List<Din>> GetDins();
        Task<List<DogumYeri>> GetDogumYeris();
        Task<List<EgitimDurumu>> GetEgitimDurumus();
        Task<List<IkametDurumu>> GetIkametDurumus();
        Task<List<Il>> GetIls();
        Task<List<Ilce>> GetIlces();
        Task<List<IslemYapan>> GetIslemYapans();
        Task<List<KanGrubu>> GetKanGrubus();
        Task<List<Uyruk>> GetUyruks();
        Task<List<SaglikDurumu>> GetSaglikDurumus();
    }
}
