using App.WebInfo.Business.Abstract;
using App.WebInfo.MVCUI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace App.WebInfo.MVCUI.Controllers
{
    public class HomeController : ControllerBase
    {
        private readonly IMenuService _menuService;

        public HomeController(IMenuService menuService)
        {
            _menuService = menuService;
        }

        public async Task<IActionResult> Index()
        {
            MenuViewModel item = new MenuViewModel()
            {
                list = await _menuService.GetList()
            };

           return View(item);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
