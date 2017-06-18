using App.Core.Dal.EntityFramework;
using App.WebInfo.DataAccess.Abstract;
using App.WebInfo.Entities.Concrete;

namespace App.WebInfo.DataAccess.Concrete.EntityFramework
{
    public class EfMenuDal:EfEntityRepositoryBase<Menu,WebInfoContext>,IMenuDal
    {
    }
}
