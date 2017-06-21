using App.WebInfo.Business.Abstract;
using App.WebInfo.Entities.Concrete;
using App.WebInfo.MVCUI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using App.Core.Utilities;
using Microsoft.AspNetCore.Mvc.Rendering;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace App.WebInfo.MVCUI.Controllers
{
    public class PersonalController : ControllerBase
    {
        private readonly IPersonalService _personal;
        private readonly IUtileService _utileService;
        public PersonalController(IPersonalService personal, IUtileService utileService)
        {
            _personal = personal;
            _utileService = utileService;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var model = new PersonalViewModel
            {
                Personal = new Personal()
            };
            return View(model);
        }

        public async Task<IActionResult> Create()
        {
            var model = new PersonalViewModel
            {
                Personal = new Personal
                {
                    Cinsiyet = new Cinsiyet()
                }
            };
            var cinsiyetTask = _utileService.GetCinsiyets();
            var dinTask = _utileService.GetDins();
            var dogumYeriTask = _utileService.GetDogumYeris();
            var egitimDurumuTask = _utileService.GetEgitimDurumus();
            var ikametDurumuTask = _utileService.GetIkametDurumus();
            var ilTask = _utileService.GetIls();
            var ilceTask = _utileService.GetIlces();
            var islemYapanTask = _utileService.GetIslemYapans();
            var kanGrubuTask = _utileService.GetKanGrubus();
            var uyrukTask = _utileService.GetUyruks();
            

            await Task.WhenAll(cinsiyetTask, dinTask, dogumYeriTask, egitimDurumuTask, ikametDurumuTask, ilTask, ilceTask, islemYapanTask, kanGrubuTask, uyrukTask);

            model.CinsiyetList = ConvertSelectList(cinsiyetTask.Result.Select(x => new { Id = x.CinsiyeId, Value = x.CinsiyetName }));
            model.DinList = ConvertSelectList(dinTask.Result.Select(x => new { Id = x.DinId, Value = x.DinName }));
            model.DogumYeriList = ConvertSelectList(dogumYeriTask.Result.Select(x => new { Id = x.DogumYeriId, Value = x.DogumYeriName }));
            model.EgitimDurumuList = ConvertSelectList(egitimDurumuTask.Result.Select(x => new { Id = x.EgitimDurumuId, Value = x.EgitimDurumuName }));
            model.IkametDurumuList = ConvertSelectList(ikametDurumuTask.Result.Select(x => new { Id = x.IkametDurumuId, Value = x.IkametDurumuName }));
            model.IlList = ConvertSelectList(ilTask.Result.Select(x => new { Id = x.IlId, Value = x.IlName }));
            model.IlceList = ConvertSelectList(ilceTask.Result.Select(x => new { Id = x.IlceId, Value = x.IlceName }));
            model.IslemYapanList = ConvertSelectList(islemYapanTask.Result.Select(x => new { Id = x.IslemYapanId, Value = x.IslemYapanName }));
            model.KanGrubuList = ConvertSelectList(kanGrubuTask.Result.Select(x => new { Id = x.KanGrubuId, Value = x.KanGrubuName }));
            model.UyrukList= ConvertSelectList(uyrukTask.Result.Select(x => new { Id = x.UyrukId, Value = x.UyrukName }));
            
            return View(model);
        }

        public SelectList ConvertSelectList(IEnumerable<object> list)
        {
            return new SelectList(list, "Id", "Value");
        }
        [HttpPost]
        public async Task<IActionResult> Create(PersonalViewModel model)
        {
            try
            {
                await _personal.Add(model.Personal);
                alertUi.AlertUiType = AlertUiType.success;
                AlertUiMessage();

                return RedirectToAction("Index", model);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public async Task<JsonResult> getList(int iDisplayStart, int iDisplayLength, string sSearch, int iColumns, int iSortingCols, int iSortCol_0, string sSortDir_0, int sEcho)
        {
            //sSearch = sSearch.ToUpper();

            var lists = _personal.GetList(null, "Uyruk,Cinsiyet,EgitimDurumu,SaglikDurumu");
            await Task.WhenAll(lists);

            List<Personal> list = lists.Result;

            var filteredlist =
                list
                    .Select(x => new[] {
                        x.PersonalId.ToString(),
                        x.Adi,
                        x.Soyadi,
                        x.Uyruk.UyrukName,
                        x.EgitimDurumu.EgitimDurumuName,
                        x.Cinsiyet.CinsiyetName
                    }).Where(x => string.IsNullOrEmpty(sSearch) || x.Any(y => y.IndexOf(sSearch, StringComparison.CurrentCultureIgnoreCase) >= 0));

            var orderedlist = filteredlist
                //.OrderByOrdinal(x => (x[iSortCol_0]).Parse(), sSortDir_0 == "desc")
                .Skip(iDisplayStart)
                .Take(iDisplayLength);

            var model = new
            {
                aaData = orderedlist,
                iTotalDisplayRecords = filteredlist.Count(),
                iTotalRecords = list.Count(),
                sEcho = sEcho.ToString()
            };
            return Json(model);
        }
    }
}
