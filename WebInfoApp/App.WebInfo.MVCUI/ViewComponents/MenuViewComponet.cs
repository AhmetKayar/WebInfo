using App.WebInfo.Business.Abstract;
using App.WebInfo.MVCUI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace App.WebInfo.MVCUI.ViewComponents
{
    public class MenuViewComponet: ViewComponent
    {
        private readonly IMenuService _menuService;
        public MenuViewComponet(IMenuService menuService)
        {
            _menuService = menuService;
        }
        public async Task<IViewComponentResult> InvokeAsync() {
            MenuViewModel view = new MenuViewModel()
            {
                list = await _menuService.GetList()
            };
            return View(view);
        }
    }
}
