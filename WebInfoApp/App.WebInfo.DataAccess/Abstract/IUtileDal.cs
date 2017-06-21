using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using App.WebInfo.Entities.Concrete;

namespace App.WebInfo.DataAccess.Abstract
{
    public interface IUtileDal
    {
        Task<List<Cinsiyet>> GetCinsiyets();
        Task<List<Din>> GetDins ();
        Task<List<DogumYeri>> GetDogumYeris ();
        Task<List<EgitimDurumu>> GetEgitimDurumus ();
        Task<List<IkametDurumu>> GetIkametDurumus ();
        Task<List<Il>> GetIls ();
        Task<List<Ilce>> GetIlces ();
        Task<List<IslemYapan>> GetIslemYapans ();
        Task<List<KanGrubu>> GetKanGrubus ();
        Task<List<Uyruk>> GetUyruks();
    }
}
