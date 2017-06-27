using App.WebInfo.Business.Abstract;
using App.WebInfo.DataAccess.Abstract;
using App.WebInfo.Entities.Concrete;

namespace App.WebInfo.Business.Concrete
{
    public class MenuManager : ManagerBase<IMenuDal, Menu>, IMenuService
    {
        public MenuManager(IMenuDal manager) : base(manager)
        {
        }
    }
}
